//using Common.Reflection;
//using Keplerth;
//using Harmony;
//using System;
//using Common;

//namespace StackSplitMod
//{
//    [HarmonyPatch(typeof(UnPackItem), "OpenUnPackUI")]
//    internal static class UnpackItemPatch
//    {
//        private static void Postfix(UnPackItem __instance)
//        {
//            try
//            {
//                var item = (ItemData)__instance.GetInstanceFieldValue("curItem");
//                var amount = item.count / 2 + item.count % 2;
//                __instance.inputNumber.text = amount.ToString();
//                __instance.OnClickOK();
//            }
//            catch (Exception e) { Log.ExceptionOnce(e); }
//        }
//    }
//}
