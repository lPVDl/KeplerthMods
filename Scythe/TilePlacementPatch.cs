using System.Collections.Generic;
using System.Reflection;
using UnityEngine.UI;
using System.Linq;
using UnityEngine;
using DataBase;
using Keplerth;
using Harmony;
using Common;
using System;

namespace Scythe
{
    [HarmonyPatch(typeof(TilePlacement), "PlacementDie")]
    internal static class TilePlacementPatch
    {
        [HarmonyPatch(typeof(DropItems), "SetDropItem")]
        private static class DropItemsPatch
        {
            public static List<GameObject> CapturedDrops { get; } = new List<GameObject>();

            private static void Postfix(ItemData item, ref GameObject __result)
            {
                try
                {
                    if (Recording) CapturedDrops.Add(__result);
                }
                catch (Exception e) { Log.ExceptionOnce(e); }
            }
        }

        [HarmonyPatch(typeof(SoundsPublic), "PlaySound")]
        private static class SoundsPublicPatch
        {
            public static List<Tuple<AudioSource, Vector3, bool, float, bool, bool>> CapturedData { get; } = new List<Tuple<AudioSource, Vector3, bool, float, bool, bool>>();

            private static bool Prefix(AudioSource audio, Vector3 postion, bool enable, float volume, bool isPitch, bool isContinuous)
            {
                try
                {
                    if (Recording)
                    {
                        CapturedData.Add(Tuple.Create(audio, postion, enable, volume, isPitch, isContinuous));
                        return false;
                    }
                }
                catch (Exception e) { Log.ExceptionOnce(e); }

                return true;
            }
        }

        private static bool Recording { get; set; }
        private static int[] SeedID = { 3221, 3226, 3224, 3222 };
        private static MethodInfo DropItemDelete { get; } = typeof(DropItem).GetMethod("DeleteItem", BindingFlags.Instance | BindingFlags.NonPublic);

        private static void Prefix(Character source)
        {
            try
            {
                if (source == null) return;
                if (!source.IsPlayer) return;

                if (ConfigPatch.ScytheID.Contains(source.Weapon.WeaponId))
                {
                    Recording = true;
                }
            }
            catch (Exception e) { Log.ExceptionOnce(e); }
        }

        private static void Postfix(TilePlacement __instance, Character source)
        {
            try
            {
                if (!Recording) return;

                var drop = from obj in DropItemsPatch.CapturedDrops
                           let dropITem = obj.GetComponent<DropItem>()
                           where SeedID.Contains(dropITem.itemInfo.id)
                           select dropITem;
                if (drop.Count() > 0)
                {
                    var seed = drop.Single();

                    var seedData = ConfigItem.Table[seed.itemInfo.id];
                    PlacementSetup.SetThing(__instance.TiledObject.X, __instance.TiledObject.Y, seedData.PlacenmentId);

                    if (DropItemsPatch.CapturedDrops.Count == 1 && seed.itemInfo.count == 1)
                    {
                        (source.Weapon.Proto as ItemWeaponProto).item.curDurability++;
                    }
                    else
                    {
                        Recording = false;
                        SoundsPublicPatch.CapturedData.Do(x => SoundsPublic.PlaySound(x.Item1, x.Item2, x.Item3, x.Item4, x.Item5, x.Item6));
                    }

                    var scytheIndex = ConfigPatch.ScytheID.ToList().IndexOf(source.Weapon.WeaponId);
                    if (DropItemsPatch.CapturedDrops.Count == 1 || UnityEngine.Random.value > ConfigPatch.ExtraYieldChances[scytheIndex])
                    {
                        seed.itemInfo.count--;
                        UpdateDropItemText(seed);
                        if (seed.itemInfo.count == 0)
                        {
                            DropItemDelete.Invoke(seed, null);
                        }
                    }
                }
            }
            catch (Exception e) { Log.ExceptionOnce(e); }

            Recording = false;
            DropItemsPatch.CapturedDrops.Clear();
            SoundsPublicPatch.CapturedData.Clear();
        }

        private static void UpdateDropItemText(DropItem item)
        {
            if (item.itemInfo.count < 2)
            {
                item.NumberText.SetActive(false);
            }
            else
            {
                item.NumberText.SetActive(true);
                item.NumberText.GetComponent<Text>().text = item.itemInfo.count.ToString();
            }
        }
    }
}
