using Common;
using Harmony;
using Keplerth;
using System;

namespace BrokenItems
{
    // Add colored durabity text next to item name.
    [HarmonyPatch(typeof(SelectItem), "ShowBaseText")]
    public static class Patch_SelectItem_ShowBaseText
    {
        private static float[] _durability = { 0, 0.15f, 0.80f };
        private static string[] _colors = { "red", "yellow", "green" };

        private static void Postfix(ItemData item, SelectItem __instance)
        {
            try
            {
                if (item.maxDurability <= 1) return;

                var t = item.curDurability / (float)item.maxDurability;
                var color = "white";
                for (var i = 0; i < _colors.Length; i++)
                    if (t >= _durability[i])
                        color = _colors[i];

                __instance.ItemNameText.text += $" <color={color}>[{item.curDurability }/{item.maxDurability }]</color>";
            }
            catch (Exception e)
            {
                Log.Exception(e);
            }
        }
    }
}
