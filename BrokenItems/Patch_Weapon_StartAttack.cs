using Common;
using DataBase;
using Harmony;
using Keplerth;
using System;

namespace BrokenItems
{
    // Prevent weapon usage when has zero durability.
    [HarmonyPatch(typeof(Character), "PlayAttack")]
    public class Patch_Character_PlayAttack
    {
        private static bool Prefix(Character __instance)
        {
            try
            {   
                var item = Config.BagInfoScript.GetItem(__instance.Weapon.BagIndex);
                if (ConfigItem.getDurability(item.id) > 0 && item.curDurability == 0) return false;
            }
            catch (Exception e)
            {
                Log.ExceptionOnce(e);
            }

            return true;
        }
    }
}
