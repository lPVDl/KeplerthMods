using Common;
using Harmony;
using Keplerth;
using System;
using UnityEngine;

namespace BrokenItems
{
    // Change weapon color when equiped
    [HarmonyPatch(typeof(Character), "EquipWeapon", new[] { typeof(ItemData) })]
    internal static class Patch_Character_EquipWeapon
    {
        private static void Prefix(ItemData weaponItemData, Character __instance)
        {
            try
            {
                if (weaponItemData == null || weaponItemData.IsWeapon() == false) return;
                var spriteRenderer = __instance.Weapon.GetComponentInChildren<SpriteRenderer>();
                ItemColorUtil.ModifyColor(spriteRenderer, weaponItemData);
            }
            catch (Exception e)
            {
                Log.ExceptionOnce(e);
            }
        }
    }
}
