using System.Collections.Generic;
using System.Collections;
using Common.Reflection;
using System.Linq;
using System;

namespace ChassisMod.Core.Data.Util
{
    internal static class FormatUtil
    {
        public static string ContinuousEnumeration(string name)
        {
            var underIndex = name.IndexOf('_');
            if (underIndex < 0) return name + "_0";

            var numberText = name.Substring(underIndex + 1, name.Length - underIndex - 1);
            if (int.TryParse(numberText, out var value))
            {
                value++;
                return name.Substring(0, underIndex) + "_" + value;
            }

            return name + "_0";
        }

        public static IEnumerable<string> GetPropertiesWithValues<T>(T obj, params string[] toExclude)
        {
            return from prop in obj.GetInstanceProperties()
                   let name = prop.Name
                   where !toExclude.Any(x => x == name)
                   select name + ": " + ContentToString(prop.GetValue(obj));
        }

        private static string ContentToString(object data)
        {
            if (data is IEnumerable)
            {
                if (data is string) return "\"" + data + "\"";

                var enumeration = data as IEnumerable;
                var text = "[ ";
                foreach (var item in enumeration)
                {
                    text += ContentToString(item) + ", ";
                }
                if (text.Length > 2) text = text.Remove(text.Length - 2, 2);
                text += " ]";
                return text;
            }

            return data.ToString();
        }

        public static IEnumerable<string> GroupJoin(string separator, int groupSize, IEnumerable<string> values)
        {
            if (groupSize <= 0) throw new ArgumentException("group size must be greater than zero");

            var result = new List<string>();
            var source = values.ToArray();
            for(var i = 0; i < source.Length; i += groupSize)
            {
                var size = Math.Min(groupSize, source.Length - i);
                var line = string.Join(separator, source, i, size);
                result.Add(line);
            }

            return result;
        }
    }
}
