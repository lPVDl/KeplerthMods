using Harmony;
using Keplerth;
using System.Reflection;

namespace InventoryExpansion
{
    [HarmonyPatch(typeof(BaseBag), "AddItemToBag")]
    public static class Patch_BagItem_AddItemToBag
    {
        private static MethodInfo _setItem = typeof(BaseBag).GetMethod("SetItem", BindingFlags.Instance | BindingFlags.NonPublic);

        private static bool Prefix(int index, BaseBag __instance)
        {
            if (Config.BagInfoScript == __instance)
            {
                var obj = Config.BagInfoScript.BigBagButtonList[index];
                obj.GetComponent<ChestItem>()?.OnUIOpen();
                _setItem.Invoke(__instance, new object[] { index, obj });

                return false;
            }

            return true;
        }
    }
}
