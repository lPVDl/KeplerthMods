namespace Chassis.Utilities
{
    internal static class FormatUtil
    {
        public static string ToString<T>(T obj)
        {
            if (obj == null) return "null";

            return obj.ToString();
        }
    }
}
