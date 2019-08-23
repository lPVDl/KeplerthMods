using Chassis.Utilities;
using Chassis.Patching;
using Chassis.Entities;
using Keplerth;
using System;

namespace Chassis.Wrapping
{ 
    internal sealed class Localization : ILocalization, IPropertyInfo
    {
        public IEntity Owner { get; set; }
        public string Prefix { get; set; }
        public string Name { get; set; }

        string IPropertyInfo.Name => Name;

        bool IPropertyInfo.ValueIsDefault
        {
            get
            {
                var key = Prefix + Owner.ID;
                if (LanguageUtil.TryGetInEnglish(key, out var text)) return true;

                return false;
            }
        }

        string IPropertyInfo.Value
        {
            get
            {
                var key = Prefix + Owner.ID;
                if (LanguageUtil.TryGetInEnglish(key, out var text)) return text;

                return "";
            }
        }

        void ILocalization.Set(string defaultText)
        {
            if (string.IsNullOrEmpty(defaultText)) throw new ArgumentException("defaultText was null or empty");

            var key = Prefix + Owner.ID;
            LanguagePatcher.Set(key, defaultText);
        }

        void ILocalization.Set(Language language, string text)
        {
            if (language == null) throw new ArgumentNullException("language was null");
            if (string.IsNullOrEmpty(text)) throw new ArgumentException("text was null or empty");

            var key = Prefix + Owner.ID;
            LanguagePatcher.Set(language, key, text);
        }

        
        void ILocalization.Edit(Func<string, string> converter)
        {
            if (converter == null) throw new ArgumentNullException("converter was null");

            var key = Prefix + Owner.ID;
            LanguagePatcher.Modify(key, converter);
        }

        void ILocalization.Copy(ILocalization source)
        {
            if (source == null) throw new ArgumentNullException("source was null");

            var data = source as Localization;
            if (data == null) throw new NotSupportedException($"Can copy only from {typeof(Localization)}");

            Func<string, string> converter = (_) =>
            {
                var dataKey = data.Prefix + data.Owner.ID;
                return Config.DictLang[dataKey];
            };

            var key = Prefix + Owner.ID;
            LanguagePatcher.Modify(key, converter);
        }
    }       
}
