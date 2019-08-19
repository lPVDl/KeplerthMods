using ChassisMod.Patching;
using System.Reflection;
using DataBase;
using System;

namespace ChassisMod.Wrapping
{  
    internal sealed class ConfigContainer<TConfig, TValue> : Patchable<TValue>, IEntityInfo where TConfig : DBBase
    {
        string IEntityInfo.Info
        {
            get
            {
                var config = GetConfig();
                var value = ReadValue(config);

                if (FormatValue != null) { return FormatValue(config, value); }

                if (value == null) { return "null"; }

                return value.ToString();
            }
        }

        bool IEntityInfo.Display
        {
            get
            {
                if (DisplayValue != null)
                {
                    var config = GetConfig();
                    var value = ReadValue(config);

                    return DisplayValue(config, value);
                }

                return true;
            }
        }

        public string Name { get; set; }
        public ConfigWrapper<TConfig> Owner { get; set; }
        public Func<TConfig, TValue> ReadValue { get; set; }
        public Action<TConfig, TValue> WriteValue { get; set; }
        public Func<TValue, bool> ValidateValue { get; set; }
        public Func<TConfig, TValue, string> FormatValue { get; set; }
        public Func<TConfig, TValue, bool> DisplayValue { get; set; }

        internal override TValue Read()
        {
            var config = GetConfig();

            return ReadValue(config);
        }

        internal override void Write(TValue value)
        {
            var config = GetConfig();

            WriteValue(config, value);             
        }

        private TConfig GetConfig()
        {
            var table = ConfigWrapper<TConfig>.Table;

            if (table.TryGetValue(Owner.ID, out var config)) { return config; }

            throw new InvalidOperationException($"{Owner}({Owner.ID}) was not found in {typeof(TConfig).Name}.{nameof(ConfigWrapper<TConfig>.Table)}");
        }

        protected override bool Validate(TValue value) => ValidateValue(value);

        protected override void AddPatch(Action patch, Assembly patcher) => ConfigPatcher.Add(patch, patcher);

        public override string ToString() => $"{Owner}.{Name}";
    } 
}
