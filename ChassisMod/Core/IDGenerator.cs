using System.Collections.Generic;
using System;

namespace ChassisMod.Core
{
    internal static class IDGenerator
    {
        private static Dictionary<int, string> OccupiedID { get; } = new Dictionary<int, string>();

        internal static int CreateID(string name)
        {
            var random = new Random(name.GetHashCode());
            var id = random.Next((int)1e+6, int.MaxValue);

            if (OccupiedID.TryGetValue(id, out var occupiedName))
            {
                throw new InvalidOperationException($"ID {name} was already token by {occupiedName}");
            }

            OccupiedID[id] = name;
            PatchLog.WriteLine($"{name} = {id}");

            return id;
        }
    }
}
