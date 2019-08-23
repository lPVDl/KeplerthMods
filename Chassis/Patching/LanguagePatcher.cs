using System.Collections.Generic;
using Common.Extensions;
using Keplerth;
using Harmony;
using System;
using Common;

namespace Chassis.Patching
{
    internal static class LanguagePatcher
    {
        [HarmonyPatch(typeof(Config), "LoadCurSelectLanguage")]
        private static class Patch
        {
            private static void Postfix()
            {
                try
                {
                    if (Entries.TryGetValue(CurrentLanguage, out var records))
                        foreach (var rec in records)
                        {
                            Config.DictLang[rec.Key] = rec.Value;
                        }                

                    foreach(var def in Defaults)
                    {
                        TryApplyDefault(def.Key, def.Value);
                    }

                    foreach(var mod in Modifications)
                    {
                        TryApplyModifications(mod.Key, mod.Value);
                    }
                }
                catch (Exception e) { Log.Exception(e); }
            }
        }

        private static Dictionary<string, Dictionary<string, string>> Entries { get; } = new Dictionary<string, Dictionary<string, string>>();
        private static Dictionary<string, string> Defaults { get; } = new Dictionary<string, string>();
        private static Dictionary<string, List<Func<string, string>>> Modifications { get; } = new Dictionary<string, List<Func<string, string>>>();

        private static string CurrentLanguage => Config.LanguageCodes[(int)Config.SelectLanguage].Trim('\u0009');

        public static void Set(string key, string defaultText)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentException("key was null or empty");
            if (string.IsNullOrEmpty(defaultText)) throw new ArgumentException("defaultText was null or empty");

            Defaults[key] = defaultText;
            if (TryApplyDefault(key, defaultText) && Modifications.TryGetValue(key, out var mods))
            {
                TryApplyModifications(key, mods);
            }

        }

        private static bool TryApplyDefault(string key, string defaultText)
        {
            if (!Config.DictLang.ContainsKey(key) || Config.DictLang[key] == Constant.EmptyString)
            {
                Config.DictLang[key] = defaultText;
                return true;        
            }

            return false;
        }

        public static void Set(Language language, string key, string text)
        {
            if (language == null) throw new ArgumentNullException("language was null");
            if (string.IsNullOrEmpty(key)) throw new ArgumentException("key was null or empty");
            if (string.IsNullOrEmpty(text)) throw new ArgumentException("text was null or empty");

            var langName = language.Name;

            Entries.GetOrCreate(langName)[key] = text;

            if (langName == CurrentLanguage) { Config.DictLang[key] = text; }
        }

        public static void Modify(string key, Func<string, string> converter)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentException("key was null or empty");
            if (converter == null) throw new ArgumentNullException("textConverter was null");

            var mods = Modifications.GetOrCreate(key);
            mods.Add(converter);

            TryApplyModifications(key, mods);
        }

        private static bool TryApplyModifications(string key, IEnumerable<Func<string, string>> modifications)
        {
            if (!Config.DictLang.ContainsKey(key)) return false;

            try
            {
                var value = Config.DictLang[key];
                modifications.Do(x => value = x(value));
                Config.DictLang[key] = value;

                return true;
            }
            catch (Exception e) { Log.ExceptionOnce(e); }

            return false;
        }
    }
}
