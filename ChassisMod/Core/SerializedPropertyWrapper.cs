using System;

namespace ChassisMod.Core
{
    partial class DataWrapper<TConfig>
    {
        public sealed class SerializedPropertyWrapper<TProperty, TSerialized, TPropertyID>
        {
            private Func<TSerialized, TSerialized> Modification { get; set; }
            private DataWrapper<TConfig> Source { get; set; }
            private TSerialized Data { get; set; }

            public static implicit operator SerializedPropertyWrapper<TProperty, TSerialized, TPropertyID>(DataWrapper<TConfig> source)
            {
                return new SerializedPropertyWrapper<TProperty, TSerialized, TPropertyID>()
                {
                    Source = source ?? throw new ArgumentNullException("source was null")
                };
            }

            public static implicit operator SerializedPropertyWrapper<TProperty, TSerialized, TPropertyID>(TSerialized data)
            {
                if (typeof(TSerialized).IsClass && data == null)
                    throw new ArgumentNullException("data was null");

                return new SerializedPropertyWrapper<TProperty, TSerialized, TPropertyID>() { Data = data };
            }

            public static implicit operator SerializedPropertyWrapper<TProperty, TSerialized, TPropertyID>(Func<TSerialized, TSerialized> modification)
            {
                return new SerializedPropertyWrapper<TProperty, TSerialized, TPropertyID>()
                {
                    Modification = modification ?? throw new ArgumentNullException("modification was null")
                };
            }

            private SerializedPropertyWrapper() { }

            internal void Patch(DataWrapper<TConfig> target, string propertyName, Func<TConfig, TProperty> get, Action<TConfig, TProperty> set,
                Func<TProperty, TSerialized> serialize, Func<TSerialized, TProperty> deserialize)
            {
                if (Source != null)
                {
                    PropertyPatcher.PatchFromSource(Source, target, propertyName, get, set);
                }
                else if (Modification != null)
                {
                    PropertyPatcher.PatchFromSerializedModification(Modification, target, propertyName, get, set, serialize, deserialize);
                }
                else
                {
                    PropertyPatcher.PatchFromSerializedData(Data, target, propertyName, set, deserialize);
                }
            }
        }
    }
}