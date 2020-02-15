using Keplerth;
using Harmony;
using System;
using Common;
using System.Reflection;

namespace StackSplit
{
    internal static class BagItemPatch
    {
        [HarmonyPatch(typeof(BagItem), "MouseRightClickItem")]
        private static class MouseRightClickItem
        {
            private static readonly FieldInfo BagItem_isMouseInButton = typeof(BagItem).GetField("isMouseInButton", BindingFlags.NonPublic | BindingFlags.Instance);

            private static bool Prefix(BagItem __instance)
            {
                try
                {
                    var isMouseInButton = (bool) BagItem_isMouseInButton.GetValue(__instance);
                    var rmbClicked = isMouseInButton && UnityEngine.Input.GetMouseButtonDown(1);
                    if (!rmbClicked) { return true; }

                    var item = __instance.GetItem();
                    var moneyHovered = (item != null) && (item.id == 9027);
                    if (moneyHovered) { return true; }

                    if (BaseBag.PickItem != null)
                    {
                        var count = KeyBindings.GetKey(KeyBindingType.Unpack) ? 10 : 1;
                        BagItemUtil.FillWithPickedItem(__instance, count);
                        return false;
                    }
                }
                catch (Exception e) { Log.ExceptionOnce(e); }

                return true;
            }
        }
    }
}
