using System.Collections.Generic;
using Common.Reflection;
using System;

namespace ChassisMod.Core
{
    partial class DataWrapper<TConfig>
    {
        private static class PropertyPatcher
        {
            public static void PatchFromSource<TProperty>(DataWrapper<TConfig> source, DataWrapper<TConfig> target, string propertyName, Func<TConfig, TProperty> propertyGet, Action<TConfig, TProperty> propertySet)
            {
                var patchInfo = $"{target}.{propertyName} = {source}.{propertyName}";
                target.AddModification(patchInfo, config =>
                {
                    var table = ReflectionHelper.GetStaticFieldValue<TConfig>("Table") as Dictionary<int, TConfig>;
                    var value = propertyGet(table[source.ID]);
                    propertySet(config, value);
                });
            }

            public static void PatchFromModification<TProperty>(Func<TProperty, TProperty> modification, DataWrapper<TConfig> target, string propertyName, Func<TConfig, TProperty> propertyGet, Action<TConfig, TProperty> propertySet)
            {
                var patchInfo = $"{target}.{propertyName} = f(x)";
                target.AddModification(patchInfo, config =>
                {
                    var value = propertyGet(config);
                    value = modification(value);
                    propertySet(config, value);
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

            public static void PatchFromConvertedData<TProperty, TConvertFrom>(TConvertFrom data, DataWrapper<TConfig> target, string propertyName, Action<TConfig, TProperty> propertySet, Func<TConvertFrom, TProperty> converter)
            {
                var patchInfo = $"{target}.{propertyName} = {data}";
                target.AddModification(patchInfo, config =>
                {
                    var value = converter(data);
                    propertySet(config, value);
                });
            }
        }
    }
}
