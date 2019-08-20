using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using Common;

namespace ChassisMod.Utilities
{
    internal static partial class LanguageUtil
    {
        internal static List<Dictionary<string, string>> Database { get; } = LoadDatabase();

        private static Dictionary<string, string> English { get; } = Database[1];
        private static Dictionary<string, string> Chinese { get; } = Database[0];

        private static string[] DefaultText = { "English", "0", "", null };

        public static string NameFromTextID(string textID)
        {
            try
            {
                if (TryGetInEnglish(textID, out var name)) { return Language.Normalize(name); }
            }
            catch (Exception e) { Log.Exception(e); }

            return null;
        }

        private static bool TryGetInEnglish(string textID, out string result)
        {
            result = null;

            try
            {
                var text = English[textID];
                if (!IsDefault(text))
                {
                    result = text;
                    return true;
                }

                text = Chinese[textID];
                if (!IsDefault(text))
                {
                    if (!WebTranslator.Available) WebTranslator.WaitUntilAvailable();
                    if (WebTranslator.TryTranslate(text, "zh-CN", "en", out result)) return true;
                }
            }
            catch (Exception e) { Log.ExceptionOnce(e); }

            return false;
        }

        private static bool IsDefault(string text) => DefaultText.Any(x => x == text);

        private static List<Dictionary<string, string>> LoadDatabase()
        {
            var file = Application.streamingAssetsPath + "/Language/Language.txt";
            var lines = System.IO.File.ReadAllLines(file);

            var trimCharacters = new char[] { ' ', '\t' };
            var result = new List<Dictionary<string, string>>();
            foreach (var line in lines)
            {
                var words = line.Split('┋');
                words = Array.ConvertAll(words, x => x.Trim(trimCharacters));
                for (var i = 1; i < words.Length; i++)
                {
                    if (result.Count < i) { result.Add(new Dictionary<string, string>()); }
                    result[i - 1][words[0]] = words[i];
                }
            }

            return result;
        }
    }
}
