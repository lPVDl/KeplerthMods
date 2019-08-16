using System.Collections.Generic;

namespace Common.Extensions
{
    internal static class DictionaryExtensions
    {
        public static TValue GetOrCreate<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key) where TValue : class, new()
        {
            if (dictionary.TryGetValue(key, out var value)) { return value; }

            var result = new TValue();
            dictionary[key] = result;

            return result;
        }
    }
}
