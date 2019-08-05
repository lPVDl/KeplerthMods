using Common.Reflection;
using Keplerth;
using Harmony;
using System;
using Common;

namespace StackSplitMod
{
    internal static class BagItemPatch
    {
        [HarmonyPatch(typeof(BagItem), "MouseRightClickItem")]
        private static class MouseRightClickItem
        {
            private static bool Prefix(BagItem __instance)
            {
                try
                {
                    var rmbClicked = (bool)__instance.GetInstanceFieldValue("isMouseInButton") && UnityEngine.Input.GetMouseButtonDown(1);
                    if (!rmbClicked) { return true; }

                    var item = __instance.GetItem();
                    var moneyHovered = (item != null) && (item.id == 9027);
                    if (moneyHovered) { return true; }

                    if (BaseBag.PickItem != null)
                    {
                        var count = KeyBindings.GetKey(KeyBindingType.Unpack) ? 10 : 1;
                        __instance.FillWithPickedItem(count);
                        return false;
                    }
                }
                catch(Exception e) { Log.ExceptionOnce(e); }

                return true;
            }            
        }
    }
}
