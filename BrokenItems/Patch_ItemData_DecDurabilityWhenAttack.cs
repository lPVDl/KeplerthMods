using Common;
using Harmony;
using Keplerth;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace BrokenItems
{
    // Changes item icon to red when durabity == 0 (when updated from attack).
    [HarmonyPatch(typeof(ItemData), "DecDurabilityWhenAttack")]
    public class Patch_ItemData_DecDurabilityWhenAttack
    {
        private static void Postfix(int ItemIndex, ItemData __instance)
        {
            try
            {
                var gameObject = GameObject.Find("GlobalUI/Bag/ItemBar/QuickButton (" + ItemIndex + ")");
                var bagItem = gameObject.GetComponent<BagItem>();
                ItemColorUtil.ModifyColor(bagItem.selfImage.GetComponent<Image>(), __instance);
            }
            catch (Exception e)
            {
                Log.ExceptionOnce(e);
            }
        }
    }
}
