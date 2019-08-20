using System.Collections.Generic;
using System;

namespace Common.Extensions
{
    internal static class DictionaryExtensions
    {
        //public static TValue GetOrCreate<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key) where TValue : class, new()
        //{
        //    if (dictionary.TryGetValue(key, out var value)) { return value; }

        //    var result = new TValue();
        //    dictionary[key] = result;

        //    return result;
        //}

        public static TValue Cash<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TKey, TValue> keyToValue)
        {
            if (dictionary == null) throw new ArgumentNullException("dictionary was null");

            if (dictionary.TryGetValue(key, out var value)) { return value; }

            var newValue = keyToValue(key);

            dictionary[key] = newValue;

            return newValue;
        }
    }
}
