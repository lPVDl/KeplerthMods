using System.Collections.Generic;
using Common.Reflection;
using System;

namespace ChassisMod.Core
{
    partial class DataWrapper<TConfig>
    {
        private static class PropertyPatcher
        {
            public static void PatchFromSource<TProperty>(DataWrapper<TConfig> source, DataWrapper<TConfig> target, string propertyName, Func<TConfig, TProperty> get, 
                Action<TConfig, TProperty> set)
            {
                var patchInfo = $"{target}.{propertyName} = {source}.{propertyName}";
                target.AddModification(patchInfo, config =>
                {
                    var table = ReflectionHelper.GetStaticFieldValue<TConfig>("Table") as Dictionary<int, TConfig>;
                    var value = get(table[source.ID]);
                    set(config, value);
                });
            }

            public static void PatchFromModification<TProperty>(Func<TProperty, TProperty> modification, 
                DataWrapper<TConfig> target, string propertyName, Func<TConfig, TProperty> get, Action<TConfig, TProperty> set)
            {
                var patchInfo = $"{target}.{propertyName} = f(x)";
                target.AddModification(patchInfo, config =>
                {
                    var value = get(config);
                    value = modification(value);
                    set(config, value);
                });
            }

            public static void PatchFromSerializedModification<TProperty, TSerializedProperty>(Func<TSerializedProperty, TSerializedProperty> modification,
                DataWrapper<TConfig> target, string propertyName, Func<TConfig, TProperty> get, Action<TConfig, TProperty> set, 
                 Func<TProperty, TSerializedProperty> serialize, Func<TSerializedProperty, TProperty> deserialize)
            {
                var patchInfo = $"{target}.{propertyName} = f(x)";
                target.AddModification(patchInfo, config =>
                {
                    var value = serialize(get(config));
                    value = modification(value);
                    set(config, deserialize(value));
                });
            }

            public static void PatchFromData<TProperty>(TProperty data, DataWrapper<TConfig> target, string propertyName, Action<TConfig, TProperty> propertySet)
            {
                var patchInfo = $"{target}.{propertyName} = {data}";
                target.AddModification(patchInfo, config =>
                {
                    propertySet(config, data);
                });
            }

            public static void PatchFromSerializedData<TProperty, TSerialized>(TSerialized data, DataWrapper<TConfig> target, string propertyName, 
                Action<TConfig, TProperty> set, Func<TSerialized, TProperty> deserialize)
            {
                var patchInfo = $"{target}.{propertyName} = {data}";
                target.AddModification(patchInfo, config =>
                {
                    var value = deserialize(data);
                    set(config, value);
                });
            }
        }
    }
}
