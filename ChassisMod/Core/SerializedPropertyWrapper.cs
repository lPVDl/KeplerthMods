using System.Collections.Generic;
using Common.Reflection;
using System;

namespace ChassisMod.Core
{
    partial class DataWrapper<TConfig>
    {
        public abstract class SerializedPropertyWrapper<TProperty, TSerialized, TPropertyID> where TPropertyID : PropertyIdentity
        {
            private sealed class WithModification : SerializedPropertyWrapper<TProperty, TSerialized, TPropertyID>
            {
                public Func<TSerialized, TSerialized> Modification { get; set; }

                internal override void Patch(DataWrapper<TConfig> target, string propertyName, Func<TConfig, TProperty> get, Action<TConfig, TProperty> set, Func<TProperty, TSerialized> serialize, Func<TSerialized, TProperty> deserialize)
                {
                    var patchInfo = $"{target}.{propertyName} = f(x)";
                    target.AddModification(patchInfo, config =>
                    {
                        var value = serialize(get(config));
                        value = Modification(value);
                        set(config, deserialize(value));
                    });
                }
            }

            private sealed class WithAction : SerializedPropertyWrapper<TProperty, TSerialized, TPropertyID>
            {
                public Action<TSerialized> Action { get; set; }

                internal override void Patch(DataWrapper<TConfig> target, string propertyName, Func<TConfig, TProperty> get, Action<TConfig, TProperty> set, Func<TProperty, TSerialized> serialize, Func<TSerialized, TProperty> deserialize)
                {
                    var patchInfo = $"{target}.{propertyName} = f(x)";
                    target.AddModification(patchInfo, config =>
                    {
                        var value = serialize(get(config));
                        Action(value);
                        set(config, deserialize(value));
                    });
                }
            }

            private sealed class WithSource : SerializedPropertyWrapper<TProperty, TSerialized, TPropertyID>
            {
                public DataWrapper<TConfig> Source { get; set; }

                internal override void Patch(DataWrapper<TConfig> target, string propertyName, Func<TConfig, TProperty> get, Action<TConfig, TProperty> set, Func<TProperty, TSerialized> serialize, Func<TSerialized, TProperty> deserialize)
                {
                    var patchInfo = $"{target}.{propertyName} = {Source}.{propertyName}";
                    target.AddModification(patchInfo, config =>
                    {
                        var table = ReflectionHelper.GetStaticFieldValue<TConfig>("Table") as Dictionary<int, TConfig>;
                        var value = get(table[Source.ID]);
                        set(config, value);
                    });
                }
            }

            private sealed class WithData : SerializedPropertyWrapper<TProperty, TSerialized, TPropertyID>
            {
                public TSerialized Data { get; set; }

                internal override void Patch(DataWrapper<TConfig> target, string propertyName, Func<TConfig, TProperty> get, Action<TConfig, TProperty> set, Func<TProperty, TSerialized> serialize, Func<TSerialized, TProperty> deserialize)
                {
                    var patchInfo = $"{target}.{propertyName} = {Data}";
                    target.AddModification(patchInfo, config =>
                    {
                        var value = deserialize(Data);
                        set(config, value);
                    });
                }
            }

            public static implicit operator SerializedPropertyWrapper<TProperty, TSerialized, TPropertyID>(DataWrapper<TConfig> source)
            {
                return new WithSource() { Source = source ?? throw new ArgumentNullException("source was null") };
            }

            public static implicit operator SerializedPropertyWrapper<TProperty, TSerialized, TPropertyID>(TSerialized data)
            {
                if (typeof(TSerialized).IsClass && data == null)
                    throw new ArgumentNullException("data was null");

                return new WithData() { Data = data };
            }

            public static implicit operator SerializedPropertyWrapper<TProperty, TSerialized, TPropertyID>(Func<TSerialized, TSerialized> modification)
            {
                return new WithModification() { Modification = modification ?? throw new ArgumentNullException("modification was null") };
            }

            public static implicit operator SerializedPropertyWrapper<TProperty, TSerialized, TPropertyID>(Action<TSerialized> action)
            {
                return new WithAction() { Action = action ?? throw new ArgumentNullException("action was null") };
            }

            internal SerializedPropertyWrapper() { }

            internal abstract void Patch(DataWrapper<TConfig> target, string propertyName, Func<TConfig, TProperty> get, Action<TConfig, TProperty> set, Func<TProperty, TSerialized> serialize, Func<TSerialized, TProperty> deserialize);
        }
    }
}