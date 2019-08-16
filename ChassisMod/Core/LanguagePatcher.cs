//using System.Collections.Generic;
//using Common.Extensions;
//using Keplerth;
//using Harmony;
//using System;
//using Common;

//namespace ChassisMod.Core
//{
//    internal static class LanguagePatcher
//    {
//        [HarmonyPatch(typeof(Config), "LoadCurSelectLanguage")]
//        internal static class Patch
//        {
//            private static void Postfix()
//            {
//                try
//                {
//                    if (Entries.TryGetValue(CurrentLanguage, out var records))
//                    {
//                        records.Do(x => Config.DictLang[x.Key] = x.Value);
//                    }
//                    Defaults.DoIf(x => !Config.DictLang.ContainsKey(x.Key) || Config.DictLang[x.Key] == "0", x => Config.DictLang[x.Key] = x.Value);

//                    Modifications.Do(x => TryApplyModifications(x.Key, x.Value));
//                }
//                catch (Exception e) { Log.Exception(e); }
//            }
//        }

//        private static Dictionary<string, Dictionary<string, string>> Entries { get; } = new Dictionary<string, Dictionary<string, string>>();
//        private static Dictionary<string, string> Defaults { get; } = new Dictionary<string, string>();
//        private static Dictionary<string, List<Func<string, string>>> Modifications { get; } = new Dictionary<string, List<Func<string, string>>>(); 

//        private static string CurrentLanguage => Config.LanguageCodes[(int)Config.SelectLanguage].Trim('\u0009');

//        public static void SetDefault(string key, string defaultValue)
//        {
//            Defaults[key] = defaultValue;

//            if (!Config.DictLang.ContainsKey(key) || Config.DictLang[key] == "0")
//            {
//                Config.DictLang[key] = defaultValue;
//                if (Modifications.TryGetValue(key, out var mods)) { TryApplyModifications(key, mods); }
//            }              
//        }

//        public static void Set(Language language, string key, string value)
//        {
//            var langName = language.Name;

//            Entries.GetOrCreate(langName)[key] = value;

//            if (langName == CurrentLanguage) { Config.DictLang[key] = value; }
//        }

//        public static void AddModification(string key, Func<string, string> modification)
//        {
//            var mods = Modifications.GetOrCreate(key);
//            mods.Add(modification);
//            TryApplyModifications(key, mods);
//        }

//        private static bool TryApplyModifications(string key, IEnumerable<Func<string, string>> modifications)
//        {
//            if (!Config.DictLang.ContainsKey(key)) return false;

//            try
//            {
//                var value = Config.DictLang[key];
//                modifications.Do(x => value = x(value));
//                Config.DictLang[key] = value;

//                return true;
//            }
//            catch (Exception e) { Log.ExceptionOnce(e); }

//            return false;
//        }
//    }
//}
