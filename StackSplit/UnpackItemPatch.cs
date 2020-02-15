using Keplerth;
using Harmony;
using System;
using Common;
using System.Reflection;

namespace StackSplit
{
    [HarmonyPatch(typeof(UnPackItem), "OpenUnPackUI")]
    internal static class UnpackItemPatch
    {
        private static readonly FieldInfo UnPackItem_curItem = typeof(UnPackItem).GetField("curItem", BindingFlags.NonPublic | BindingFlags.Instance);

        private static void Postfix(UnPackItem __instance)
        {
            try
            {
                var item = UnPackItem_curItem.GetValue(__instance) as ItemData;
                var amount = item.count / 2 + item.count % 2;
                __instance.inputNumber.text = amount.ToString();
                __instance.OnClickOK();
            }
            catch (Exception e) { Log.ExceptionOnce(e); }
        }
    }
}
