using System.Collections;

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

        public static string ContentToString(object data)
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
    }
}
