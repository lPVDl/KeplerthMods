using System.Collections.Generic;
using Keplerth;
using Harmony;
using System;
using Common;

namespace ChassisMod.Core
{
    internal static class LanguagePatcher
    {
        [HarmonyPatch(typeof(Config), "LoadCurSelectLanguage")]
        internal static class Patch
        {
            private static void Postfix()
            {
                try
                {
                    if (Entries.TryGetValue(CurrentLanguage, out var records))
                    {
                        records.Do(x => Config.DictLang[x.Key] = x.Value);
                    }
                    Defaults.DoIf(x => !Config.DictLang.ContainsKey(x.Key) || Config.DictLang[x.Key] == "0", x => Config.DictLang[x.Key] = x.Value);
                }
                catch (Exception e) { Log.Exception(e); }
            }
        }

        private static Dictionary<string, Dictionary<string, string>> Entries { get; } = new Dictionary<string, Dictionary<string, string>>();
        private static Dictionary<string, string> Defaults { get; } = new Dictionary<string, string>();

        private static string CurrentLanguage => Config.LanguageCodes[(int)Config.SelectLanguage].Trim('\u0009');

        public static void AddDefault(string key, string defaultValue)
        {
            Defaults[key] = defaultValue;

            if (!Config.DictLang.ContainsKey(key) || Config.DictLang[key] == "0")
            {
                Config.DictLang[key] = defaultValue;
            }
                
        }

        public static void Add(Language language, string key, string value)
        {
            var langName = language.Name;

            if (!Entries.ContainsKey(langName))
            {
                Entries[langName] = new Dictionary<string, string>();
            }
            Entries[langName][key] = value;

            if (langName == CurrentLanguage)
            {
                Config.DictLang[key] = value;
            }
        }
    }
}
