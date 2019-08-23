using Chassis.Patching;
using System.Reflection;
using System;

namespace Chassis.Wrapping
{  
    partial class Wrapper<TConfig>
    {
        protected sealed class Patchable<TValue> : IPatchable<TValue>, IPropertyInfo
        {
            private sealed class ConfigReader : Reader<TValue>, IPropertyInfo
            {
                string IPropertyInfo.Name => _owner.Name;

                string IPropertyInfo.Value => (_owner as IPropertyInfo).Value;

                bool IPropertyInfo.ValueIsDefault => (_owner as IPropertyInfo).ValueIsDefault;

                private readonly Patchable<TValue> _owner;
          
                public ConfigReader(Patchable<TValue> owner) => _owner = owner;

                internal override TValue Read()
                {
                    var config = _owner.GetConfig();

                    return _owner.Read(config);
                }

                public override string ToString() => _owner.ToString();
            }

            string IPropertyInfo.Value
            {
                get
                {
                    var config = GetConfig();
                    var value = Read(config);

                    if (Format != null) { return Format(config, value); }

                    if (value == null) { return "null"; }

                    return value.ToString();
                }
            }

            bool IPropertyInfo.ValueIsDefault
            {
                get
                {
                    if (IsDefault != null)
                    {
                        var config = GetConfig();
                        var value = Read(config);

                        return IsDefault(config, value);
                    }

                    return false;
                }
            }

            public string Name { get; set; }
            public IWrapper<TConfig> Owner { get; set; }
            public Func<TConfig, TValue> Read { get; set; }
            public Action<TConfig, TValue> Write { get; set; }
            public Func<TValue, bool> Validate { get; set; }
            public Func<TConfig, TValue, string> Format { get; set; }
            public Func<TConfig, TValue, bool> IsDefault { get; set; }

            Reader<TValue> IPatchable<TValue>.Reader => _reader;

            private readonly Reader<TValue> _reader;

            public Patchable()
            {
                _reader = new ConfigReader(this);
            }

            void IPatchable<TValue>.Set(Reader<TValue> value, IInvokationAddress patcher)
            {
                if (value == null) throw new ArgumentNullException("value was null");

                var info = new PatchLog.Message();

                Action patch = () =>
                {
                    try
                    {
                        info.Patcher = patcher;

                        info.Target = this;

                        info.Source = value;

                        var config = GetConfig();

                        info.OldValue = Read(config);

                        var newValue = value.Read();

                        info.NewValue = newValue;

                        if (!Validate(newValue)) throw new InvalidOperationException($"'{newValue}' is invalid value");

                        Write(config, newValue);
                    }
                    catch (Exception e)
                    {
                        info.Error = e;

                        throw new Exception(info.ToString(), e);
                    }
                    finally
                    {
                        info.Log();
                    }

                };

                ConfigPatcher.Add(patch, patcher);
            }

            private TConfig GetConfig() => Owner.GetConfig();

            public override string ToString() => $"{Owner}.{Name}";
        }
    }
}
