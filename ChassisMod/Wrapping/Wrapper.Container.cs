using ChassisMod.Patching;
using System.Reflection;
using System;

namespace ChassisMod.Wrapping
{
    partial class Wrapper<TConfig>
    {
        public sealed class Container<TValue> : Patchable<TValue>
        {
            public string Name { get; set; }
            public Wrapper<TConfig> Owner { get; set; }
            public Func<TConfig, TValue> ReadValue { get; set; }
            public Action<TConfig, TValue> WriteValue { get; set; }
            public Func<TValue, bool> ValidateValue { get; set; }
            public Func<TValue, string> ValueToString { get; set; }

            internal override TValue Read()
            {
                if (Table.TryGetValue(Owner.ID, out var entity)) { return ReadValue(entity); }

                throw new InvalidOperationException($"{Owner}({Owner.ID}) was not found in {typeof(TConfig).Name}.{nameof(Table)}");
            }

            internal override void Write(TValue value)
            {
                if (Table.TryGetValue(Owner.ID, out var entity))
                {
                    WriteValue(entity, value);
                    return;
                }

                throw new InvalidOperationException($"{Owner}({Owner.ID}) was not found in {typeof(TConfig).Name}.{nameof(Table)}");
            }

            protected override bool Validate(TValue value) => ValidateValue(value);

            protected override void AddPatch(Action patch, Assembly patcher) => ConfigPatcher.Add(patch, patcher);

            public override string ToString() => $"{Owner}.{Name}";

            internal override string Format(TValue value)
            {
                if (ValueToString != null) { return ValueToString(value); }

                return base.Format(value);
            }
        }
    }
}
