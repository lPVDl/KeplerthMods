using Common;
using Harmony;
using Keplerth;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Scythe
{
    [HarmonyPatch(typeof(WorkshopMod), "GetSprite")]
    internal static class SpritePatch
    {
        private static readonly Dictionary<string, Sprite> Sprites = new Dictionary<string, Sprite>();

        static SpritePatch()
        {
            try
            {
                var assets = AssetBundle.LoadFromMemory(Properties.Resources.Assets);
                for (var i = 0; i < ConfigPatch.ScytheID.Length; i++)
                {
                    Sprites["Scythe" + ConfigPatch.Material[i] + "Icon"] = assets.LoadAsset<Sprite>("Scythe" + ConfigPatch.Material[i] + "Icon");
                    Sprites["Scythe" + ConfigPatch.Material[i] + "Weapon"] = assets.LoadAsset<Sprite>("Scythe" + ConfigPatch.Material[i] + "Weapon");
                }
            }
            catch (Exception e) { Log.Exception(e); }
        }

        private static bool Prefix(string filePath, ref Sprite __result)
        {
            if (Sprites.TryGetValue(filePath, out __result)) return false;
            return true;
        }
    }
}
