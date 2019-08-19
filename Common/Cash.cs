using System.Collections.Generic;
using Common.Extensions;
using System;

namespace Common
{
    public static class Cash
    {
        private static class Storage<TKey, TValue>
        {
            public static readonly Dictionary<object, Dictionary<TKey, TValue>> Values = new Dictionary<object, Dictionary<TKey, TValue>>();
        }

        public static TValue Read<TKey, TValue>(object obj, TKey key, Func<TKey, TValue> getValue)
        {
            if (obj == null) throw new ArgumentNullException("obj was null");

            var cash = Storage<TKey, TValue>.Values.GetOrCreate(obj);

            if (cash.TryGetValue(key, out var value)) { return value; }

            var newValue = getValue(key);

            cash[key] = newValue;

            return newValue;
        }
    }
}
