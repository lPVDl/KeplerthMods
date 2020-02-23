using Harmony;
using Keplerth;

namespace InventoryExpansion
{
    [HarmonyPatch(typeof(BaseBag), "DoAddItem")]
    public static class Patch_BaseBag_DoAddItem
    {
        private static void Postfix(int bagID, int i)
        {
            if (bagID == 0)
            {
                InventoryController.OnItemMoved(i);
            }
        }
    }
}
