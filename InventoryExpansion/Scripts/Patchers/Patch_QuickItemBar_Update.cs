using Harmony;
using Keplerth;
using UnityEngine;

namespace InventoryExpansion
{
    [HarmonyPatch(typeof(QuickItemBar), "Update")]
    public static class Patch_QuickItemBar_Update
    {
        private static bool Prefix()
        {
            if (Config.BagInfoScript.BigBagButtonList[0].activeInHierarchy)
            {
                var axis = Input.GetAxis("Mouse ScrollWheel");
                if (axis > 0) InventoryController.InventoryPanelIndex--;
                if (axis < 0) InventoryController.InventoryPanelIndex++;
                for (var key = KeyBindingType.Quickbar1; key <= KeyBindingType.Quickbar0; key++)
                    if (KeyBindings.GetKeyDown(key))
                        InventoryController.InventoryPanelIndex = key - KeyBindingType.Quickbar1;

                return false;
            }

            return true;
        }
    }
}
