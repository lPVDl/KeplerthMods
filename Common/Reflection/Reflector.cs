using System.Reflection;
using System.Linq;
using System;

namespace Common.Reflection
{
    internal static class Reflector
    {
        //private const BindingFlags FlagsForStatic = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;

        //private const BindingFlags FlagsForInstance = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

        //public static object GetFieldValue(Type type, string fieldName)
        //{
        //    if (type == null) throw new ArgumentNullException("type was null");
        //    if (string.IsNullOrEmpty(fieldName)) throw new ArgumentException("fieldName was null or empty");

        //    var field = type.GetField(fieldName, FlagsForStatic);
        //    if (field == null) throw new InvalidOperationException($"{type}.{fieldName} was not found");

        //    return field.GetValue(null);
        //}

        //public static object InvokeMethod(this object obj, string name)
        //{
        //    if (obj == null) throw new ArgumentNullException("obj was null");
        //    if (string.IsNullOrEmpty(name)) throw new ArgumentException("name was null or empty");

        //    var type = obj.GetType();

        //    var method = type.GetMethod(name, FlagsForInstance);

        //    if (method == null) throw new InvalidOperationException($"{type}.{name}() was not found");

        //    return method.Invoke(obj, null);
        //}

        //public static object InvokeMethod(this object obj, string name, object arg0)
        //{
        //    if (obj == null) throw new ArgumentNullException("obj was null");
        //    if (string.IsNullOrEmpty(name)) throw new ArgumentException("name was null or empty");

        //    var type = obj.GetType();

        //    var method = type.GetMethod(name, FlagsForInstance);

        //    if (method == null) throw new InvalidOperationException($"{type}.{name}({arg0.GetType().Name}) was not found");

        //    return method.Invoke(obj, new object[] { arg0 });
        //}

        // stackoverflow.com/questions/22842949
        public static bool IsDerivedGenericType(Type type, Type baseGeneric)
        {
            if (type == null) throw new ArgumentNullException("type was null");
            if (baseGeneric == null) throw new ArgumentNullException("baseGeneric was null");

            while (type != null && type != typeof(object))
            {
                var current = type.IsGenericType ? type.GetGenericTypeDefinition() : type;
                if (baseGeneric == current)
                {
                    return true;
                }

                type = type.BaseType;
            }
            return false;
        }
    }
}
