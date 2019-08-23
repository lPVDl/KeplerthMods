using System.Collections.Generic;
using System;

namespace Chassis
{
    internal static class IDGenerator
    {
        private static Dictionary<int, string> OccupiedID { get; } = new Dictionary<int, string>();

        internal static int CreateID(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("name was null or empty");

            name = name.ToLower();

            var random = new Random(name.GetHashCode());
            var id = random.Next((int)1e+6, int.MaxValue);

            if (OccupiedID.TryGetValue(id, out var occupiedName))
            {
                throw new InvalidOperationException($"ID {name} was already token by {occupiedName}");
            }

            OccupiedID[id] = name;

            return id;
        }
    }
}
