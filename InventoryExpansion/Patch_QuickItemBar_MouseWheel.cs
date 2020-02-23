using Harmony;
using Keplerth;
using UnityEngine;

namespace InventoryExpansion
{
    [HarmonyPatch(typeof(QuickItemBar), "MouseWheel")]
    public static class Patch_QuickItemBar_MouseWheel
    {
        private static bool Prefix()
        {
            if (Config.BagInfoScript.BigBagButtonList[0].activeInHierarchy)
            {
                var axis = Input.GetAxis("Mouse ScrollWheel");
                if (axis > 0) InventoryController.InventoryPanelIndex--;
                if (axis < 0) InventoryController.InventoryPanelIndex++;

                return false;
            }
                

            return true;
        }
    }
}
