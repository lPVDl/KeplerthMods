using Common;
using DataBase;
using Harmony;
using Keplerth;
using System;

namespace InventoryCapacity
{
    [HarmonyPatch(typeof(Config), "Init")]
    public static class Patch_Config_Init
    {
        private static void Postfix()
        {
            try
            {
                InventoryController.Initialize();

                foreach (var item in ConfigItem.Table.Values)
                    if (item.MaxCount > 1)
                        item.MaxCount = 999;
            }
            catch (Exception e)
            {
                Log.ExceptionOnce(e);
            }
        }
    }
}
