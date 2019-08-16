using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Globalization;

namespace ChassisMod
{
    public sealed class Language
    {
        public static Language Russian { get; } = new Language() { Name = "russian", FriendlyName = "Русский" };
        public static Language English { get; } = new Language() { Name = "english", FriendlyName = "English" };
        public static Language SimplifiedChinese { get; } = new Language() { Name = "schinese", FriendlyName = "简体中文" };

        public static IEnumerable<Language> All { get; } = new Language[] { Russian, English, SimplifiedChinese };

        private static Regex BadCharacters { get; } = new Regex("[^a-zA-Z0-9]", RegexOptions.Compiled);
        private static Regex FirstNumber { get; } = new Regex("^[0-9]{1,}", RegexOptions.Compiled);
        private static CultureInfo CultureUS { get; } = new CultureInfo("en-US", false);

        internal string Name { get; private set; }
        internal string FriendlyName { get; private set; }

        internal static string Normalize(string name)
        {
            var normalized = CultureUS.TextInfo.ToTitleCase(name);
            normalized = BadCharacters.Replace(normalized, "");
            normalized = FirstNumber.Replace(normalized, "");

            if (normalized == "") throw new System.FormatException($"'{name}' can not be used as entity name");

            return normalized;
        }

        internal static string Normalize(int id)
        {
            if (id >= 0) return id.ToString();
            return "_" + -id;
        }

        private Language() { }
    }
}
