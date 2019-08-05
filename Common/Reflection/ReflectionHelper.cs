using System.Collections.Generic;
using System.Reflection;

namespace Common.Reflection
{
    internal static class ReflectionHelper
    {
        private static class Storage<TObject, TItem>
        {
            public static IEnumerable<TItem> instanceGroup;
            public static readonly Dictionary<string, TItem> instanceItems = new Dictionary<string, TItem>();
            public static readonly Dictionary<string, TItem> staticItems = new Dictionary<string, TItem>();
        }

        private static readonly BindingFlags instanceFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
        private static readonly BindingFlags staticFlags = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

        public static object GetStaticFieldValue<T>(string fieldName)
        {
            var cash = Storage<T, FieldInfo>.staticItems;
            if (cash.TryGetValue(fieldName, out var field))
            {
                return field.GetValue(null);
            }
            else
            {
                cash[fieldName] = typeof(T).GetField(fieldName, staticFlags);
                return cash[fieldName].GetValue(null);
            }
        }

        public static void CopyInstanceFieldValues<T>(this T obj, T source)
        {
            var fields = obj.GetInstanceFields();
            foreach (var field in fields)
                field.SetValue(obj, field.GetValue(source));
        }

        public static IEnumerable<FieldInfo> GetInstanceFields<T>(this T Object)
        {
            var fields = Storage<T, FieldInfo>.instanceGroup;
            if (fields == null)
            {
                fields = typeof(T).GetFields(instanceFlags);
                Storage<T, FieldInfo>.instanceGroup = fields;
            }

            return fields;
        }

        public static IEnumerable<PropertyInfo> GetInstanceProperties<T>(this T Object)
        {
            var properties = Storage<T, PropertyInfo>.instanceGroup;
            if (properties == null)
            {
                properties = typeof(T).GetProperties(instanceFlags);
                Storage<T, PropertyInfo>.instanceGroup = properties;
            }

            return properties;
        }

        /*public static object GetInstancePropertyValue<T>(this T obj, string propertyName)
        {
            var cash = Storage<T, PropertyInfo>.instanceItems;
            if (cash.TryGetValue(propertyName, out var property))
            {
                return property.GetValue(obj);
            }
            else
            {
                cash[propertyName] = typeof(T).GetProperty(propertyName, instanceFlags);
                return cash[propertyName].GetValue(obj);
            }
        }*/

        public static object GetInstanceFieldValue<T>(this T obj, string fieldName)
        {
            var cash = Storage<T, FieldInfo>.instanceItems;
            if (cash.TryGetValue(fieldName, out var field))
            {
                return field.GetValue(obj);
            }
            else
            {
                cash[fieldName] = typeof(T).GetField(fieldName, instanceFlags);
                return cash[fieldName].GetValue(obj);
            }
        }

        public static void SetInstanceFieldValue<T>(this T obj, string fieldName, object value)
        {
            var cash = Storage<T, FieldInfo>.instanceItems;
            if (cash.TryGetValue(fieldName, out var field))
            {
                field.SetValue(obj, value);
            }
            else
            {
                cash[fieldName] = typeof(T).GetField(fieldName, instanceFlags);
                cash[fieldName].SetValue(obj, value);
            }
        }
    }
}
