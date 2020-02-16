using Common;
using Harmony;
using Keplerth;
using System;
using UnityEngine;

namespace BrokenItems
{
    // Makes broken items on ground be red.
    [HarmonyPatch(typeof(DropItems), "SetDropItem")]
    public class Patch_DropItems_SetDropItem
    {
        private static void Postfix(ItemData item, GameObject __result)
        {
            try
            {
                var spriteRenderer = __result.GetComponentInChildren<SpriteRenderer>();
                ItemColorUtil.ModifyColor(spriteRenderer, item);
            }
            catch (Exception e)
            {
                Log.ExceptionOnce(e);
            }
        }
    }
}
