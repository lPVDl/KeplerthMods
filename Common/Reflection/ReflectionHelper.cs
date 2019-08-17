using Common.Extensions;
using System.Collections.Generic;
using System.Reflection;
using System;

namespace Common.Reflection
{
    internal static class ReflectionHelper
    {
        private static BindingFlags InstanceFlags { get; } = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

        private static Dictionary<Type, IEnumerable<PropertyInfo>> PropertyCollectionCash { get; } = new Dictionary<Type, IEnumerable<PropertyInfo>>();

        private static Dictionary<Type, Dictionary<string, PropertyInfo>> PropertyCash { get; } = new Dictionary<Type, Dictionary<string, PropertyInfo>>();

        public static IEnumerable<PropertyInfo> GetInstanceProperties(this object obj)
        {
            if (obj == null) throw new ArgumentNullException("obj was null");

            var objType = obj.GetType();

            if (PropertyCollectionCash.TryGetValue(objType, out var cash)) { return cash; }

            var newCash = objType.GetProperties(InstanceFlags);
            PropertyCollectionCash[objType] = newCash;

            return newCash;
        }

        public static void SetInstancePropertyValue(this object obj, string name, object value)
        {
            var prop = GetInstanceProperty(obj, name);
            prop.SetValue(obj, value);
        }

        public static PropertyInfo GetInstanceProperty(this object obj, string name)
        {
            if (obj == null) throw new ArgumentNullException("obj was null");
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("name was null or empty");

            var objType = obj.GetType();

            var cashSet = PropertyCash.GetOrCreate(objType);

            if (cashSet.TryGetValue(name, out var cash)) { return cash; }

            var newCash = objType.GetProperty(name, InstanceFlags);

            cashSet[name] = newCash ?? throw new InvalidOperationException($"Property {obj.GetType()}.{name} was not found");

            return newCash;
        }    
    }
}
