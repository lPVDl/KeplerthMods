using System.Collections.Generic;
using Common.Reflection;
using System.Reflection;
using System;

namespace ChassisMod.Wrappers
{
    internal static class WrapperExtensions
    {
        private static Property<object, object> Dummy { get; }

        private static Dictionary<Type, IEnumerable<PropertyInfo>> Cash { get; } = new Dictionary<Type, IEnumerable<PropertyInfo>>();

        public static void InitializeProperties<T>(this IWrapper<T> target)
        {
            foreach(var prop in GetProperties(target))
            {
                var value = prop.GetValue(target);

                value.SetInstancePropertyValue(nameof(Dummy.Name), prop.Name);
                value.SetInstancePropertyValue(nameof(Dummy.Owner), target);
            }
        }

        private static IEnumerable<PropertyInfo> GetProperties<T>(IWrapper<T> target)
        {
            var targetType = target.GetType();
            
            if (Cash.TryGetValue(targetType, out var cash)) { return cash; }

            var props = target.GetInstanceProperties();
            var newCash = new List<PropertyInfo>();

            foreach(var prop in props)
            {
                if (!prop.PropertyType.IsGenericType) continue;

                try
                {
                    var obj = prop.GetValue(target);
                    var objType = obj.GetType();

                    if (!objType.IsConstructedGenericType) continue;

                    var genericType = objType.GetGenericTypeDefinition();

                    if (genericType != typeof(Property<,>)) continue;

                    if (objType.GetGenericArguments()[0] != typeof(T)) continue;

                    newCash.Add(prop);
                }
                catch (Exception) { }
            }

            Cash[targetType] = newCash;

            return newCash;
        }
    }
}
