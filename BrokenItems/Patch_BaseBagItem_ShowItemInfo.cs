using Common;
using Harmony;
using Keplerth;
using System;
using UnityEngine.UI;

namespace BrokenItems
{
    // Make item icon color be based on durabity (when shown from main ui).
    [HarmonyPatch(typeof(BaseBagItem), "ShowItemInfo", new[] { typeof(ItemData), typeof(int) })]
    public static class Patch_BaseBagItem_ShowItemInfo
    {
        private static void Postfix(ItemData item, BaseBagItem __instance, int targetIndex)
        {
            try
            {
                if (item == null) return;

                ItemColorUtil.ModifyColor(__instance.selfImage.GetComponent<Image>(), item);
            }
            catch (Exception e)
            {
                Log.ExceptionOnce(e);
            }
        }
    }
}
