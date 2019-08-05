using System.Collections.Generic;
using UnityEngine;
using Keplerth;
using Harmony;

namespace ChassisMod.Core
{
    [HarmonyPatch(typeof(WorkshopMod), "GetSprite")]
    internal static class SpritePatcher
    {
        private static Dictionary<string, Sprite> Sprites { get; } = new Dictionary<string, Sprite>();

        public static void Set(string id, Sprite sprite)
        {
            Sprites[id] = sprite;
        }

        public static string Add(Sprite sprite)
        {
            var name = "";
            do
            {
                name = System.IO.Path.GetRandomFileName();
            } while (Sprites.ContainsKey(name));

            Sprites[name] = sprite;

            return name;
        }

        private static bool Prefix(string filePath, ref Sprite __result)
        {
            if (Sprites.TryGetValue(filePath, out __result)) return false;
            return true;
        }
    }
}
