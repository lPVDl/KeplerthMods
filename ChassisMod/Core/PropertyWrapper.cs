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

            internal void Patch(DataWrapper<TConfig> target, string propertyName, Func<TConfig, TProperty> get, Action<TConfig, TProperty> set)
            {
                if (Source != null)
                {
                    PropertyPatcher.PatchFromSource(Source, target, propertyName, get, set);
                }
                else if (Modification != null)
                {
                    PropertyPatcher.PatchFromModification(Modification, target, propertyName, get, set);
                }
                else
                {
                    PropertyPatcher.PatchFromData(Data, target, propertyName, set);
                }
            }
        }  
    }    
}
