using Common;
using Harmony;
using Keplerth;

namespace InventoryExpansion
{
    [HarmonyPatch(typeof(BaseBag), "MergeItem")]
    public static class Patch_BaseBag_MergeItem
    {
        private static void Postfix(int bagId, int i)
        {
            if (bagId == 0)
            {
                InventoryController.OnItemMoved(i);
            }
        }
    }
}
