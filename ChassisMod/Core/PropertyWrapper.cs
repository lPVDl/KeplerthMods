using System;

namespace ChassisMod.Core
{
    partial class DataWrapper<TConfig>
    {
        public sealed class PropertyWrapper<TProperty, TPropertyID> where TPropertyID : PropertyIdentity
        {
            private DataWrapper<TConfig> Source { get; set; }
            private Func<TProperty, TProperty> Modification { get; set; }
            private TProperty Data { get; set; }

            public static implicit operator PropertyWrapper<TProperty, TPropertyID> (TProperty data)
            {
                if (typeof(TProperty).IsClass && data == null)
                    throw new ArgumentNullException("data was null");

                return new PropertyWrapper<TProperty, TPropertyID>() { Data = data };
            }

            public static implicit operator PropertyWrapper<TProperty, TPropertyID>(Func<TProperty, TProperty> modification)
            {
                return new PropertyWrapper<TProperty, TPropertyID>()
                {
                    Modification = modification ?? throw new ArgumentNullException("modification was null")
                };
            }

            public static implicit operator PropertyWrapper<TProperty, TPropertyID>(DataWrapper<TConfig> source)
            {
                return new PropertyWrapper<TProperty, TPropertyID>()
                {
                    Source = source ?? throw new ArgumentNullException("source was null")
                };
            }

            private PropertyWrapper() { }

            internal void Patch(DataWrapper<TConfig> target, string propertyName, Func<TConfig, TProperty> propertyGet, Action<TConfig, TProperty> propertySet)
            {
                if (Source != null)
                {
                    PropertyPatcher.PatchFromSource(Source, target, propertyName, propertyGet, propertySet);
                }
                else if (Modification != null)
                {
                    PropertyPatcher.PatchFromModification(Modification, target, propertyName, propertyGet, propertySet);
                }
                else
                {
                    PropertyPatcher.PatchFromData(Data, target, propertyName, propertySet);
                }
            }
        }

        public sealed class PropertyWrapper<TProperty, TConvertFrom, TPropertyID>
        {
            private DataWrapper<TConfig> Source { get; set; }
            private TConvertFrom Data { get; set; }

            public static implicit operator PropertyWrapper<TProperty, TConvertFrom, TPropertyID>(DataWrapper<TConfig> source)
            {
                return new PropertyWrapper<TProperty, TConvertFrom, TPropertyID>()
                {
                    Source = source ?? throw new ArgumentNullException("source was null")
                };
            }

            public static implicit operator PropertyWrapper<TProperty, TConvertFrom, TPropertyID>(TConvertFrom data)
            {
                if (typeof(TConvertFrom).IsClass && data == null)
                    throw new ArgumentNullException("data was null");

                return new PropertyWrapper<TProperty, TConvertFrom, TPropertyID>() { Data = data };
            }

            private PropertyWrapper() { }

            internal void Patch(DataWrapper<TConfig> target, string propertyName, Func<TConfig, TProperty> propertyGet, Action<TConfig, TProperty> propertySet, Func<TConvertFrom, TProperty> converter)
            {
                if (Source != null)
                {
                    PropertyPatcher.PatchFromSource(Source, target, propertyName, propertyGet, propertySet);
                }
                else
                {
                    PropertyPatcher.PatchFromConvertedData(Data, target, propertyName, propertySet, converter);
                }
            }
        }
    }    
}
