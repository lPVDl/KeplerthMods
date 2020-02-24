using Common;
using DataBase;
using Harmony;
using Keplerth;
using System;

namespace DrugOverload
{
    // Prevent item from vanishing when item is weapon.
    [HarmonyPatch(typeof(ItemData), "DurabilityJudge")]
    internal static class Patch_ItemData_DurabilityJudge
    {
        private static bool Prefix(ItemData __instance)
        {
            try
            {
                if (ConfigWeapon.Table.ContainsKey(__instance.id) && ConfigItem.Table[__instance.id].Durability > 1)
                    return false;
            }
            catch(Exception e)
            {
                Log.ExceptionOnce(e);
            }

            return true;
        }
    }
}
