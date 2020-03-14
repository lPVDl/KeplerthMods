using Common;
using Harmony;
using Keplerth;
using System;

namespace InventoryCapacity.Scripts.Patchers
{
    [HarmonyPatch(typeof(PlatingPool), "Awake")]
    public static class Patch_PlatingPool_Awake
    {
        private static void Postfix(PlatingPool __instance)
        {
            try
            {
                foreach (var obj in PlatingPool.This.MaterialItems)
                    obj.GetComponent<BagItem>().index += 1000;
            }
            catch (Exception e)
            {
                Log.ExceptionOnce(e);
            }
            
        }
    }
}
