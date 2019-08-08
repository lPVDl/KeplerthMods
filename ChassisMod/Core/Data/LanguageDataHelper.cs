using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

namespace ChassisMod.Core.Data
{
    internal static class LanguageDataHelper
    {
        internal static List<Dictionary<string, string>> Database { get; } = LoadDatabase();
        internal static Dictionary<string, string> English { get; } = Database[1];

        private static string[] DefaultText = { "English", "0", "", null };

        public static bool IsDefault(string text) => DefaultText.Any(x => x == text);

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
