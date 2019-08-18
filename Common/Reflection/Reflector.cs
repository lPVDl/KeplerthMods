using System.Reflection;
using System;

namespace Common.Reflection
{
    internal static class Reflector
    {
        public static object GetFieldValue(Type type, string fieldName)
        {
            if (type == null) throw new ArgumentNullException("type was null");
            if (string.IsNullOrEmpty(fieldName)) throw new ArgumentException("fieldName was null or empty");

            var field = type.GetField(fieldName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
            if (field == null) throw new InvalidOperationException($"{type}.{fieldName} not exists");

            return field.GetValue(null);
        }

        public static object InvokeMethod(this object obj, string methodName)
        {
            if (obj == null) throw new ArgumentNullException("obj was null");
            if (string.IsNullOrEmpty(methodName)) throw new ArgumentException("methodName was null or empty");

            var type = obj.GetType();

            var method = type.GetMethod(methodName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            if (method == null) throw new InvalidOperationException($"{type}.{methodName}() not exists");

            return method.Invoke(obj, null);
        }

        // stackoverflow.com/questions/22842949
        public static bool IsDerivedFromGeneric(this object obj, Type generic)
        {
            if (obj == null) throw new ArgumentNullException("obj was null");

            var derived = obj.GetType();

            while (derived != null && derived != typeof(object))
            {
                var current = derived.IsGenericType ? derived.GetGenericTypeDefinition() : derived;
                if (generic == current)
                {
                    return true;
                }

                derived = derived.BaseType;
            }
            return false;
        }
    }
}
