using Common;
using DataBase;
using Harmony;
using Keplerth;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Scythe
{
    [HarmonyPatch(typeof(Init), "InitTableData")]
    internal static class ConfigPatch
    {
        public static readonly int RecipeGroupID = 103200;
        public static readonly int[] ScytheID = { 103200, 103201, 103202, 103203 };
        public static readonly float[] AttackSpeed = { 0.6f, 0.8f, 1f, 1.2f };
        public static readonly int[] Durability = { 80, 120, 150, 200 };
        public static readonly int[] TreeDamage = { 2, 2, 4, 4 };
        public static readonly string[] Material = { "Copper", "Iron", "Silver", "Gold" };
        public static readonly float[] ExtraYieldChances = { 0.03f, 0.05f, 0.07f, 0.1f };

        private static void Postfix()
        {
            try
            {
                int[] anvils = { 3024, 3025, 3026, 3027 };
                for (var i = 0; i < anvils.Length; i++)
                {
                    var craftTable = ConfigCraftTable.Table[anvils[i]];
                    var list = new List<int>(craftTable.CraftBaseList);
                    list.Insert(list.IndexOf(213) + 1, RecipeGroupID);
                    craftTable.CraftBaseList = list.ToArray();
                }

                ConfigCraftBase.Table[RecipeGroupID] = new ConfigCraftBase()
                {
                    CraftCellList = ScytheID,
                    Introduce = "CraftBaseIntroduce" + RecipeGroupID,
                    Name = "CraftBaseName" + RecipeGroupID,
                    Tips = "CraftBaseTips" + RecipeGroupID,
                };

                int[] pickaxes = { 6103, 6104, 6105, 6106 };
                var scytheItems = Clone<ConfigItem>(pickaxes);
                var scytheWeapons = Clone<ConfigWeapon>(pickaxes);
                var scytheRecipes = Clone<ConfigCraftCell>(pickaxes);
                for (var i = 0; i < pickaxes.Length; i++)
                {
                    scytheItems[i].AttTree = TreeDamage[i];
                    scytheItems[i].Durability = Durability[i];
                    scytheItems[i].ItemType = 0;
                    scytheItems[i].DropTexture = "Scythe" + Material[i] + "Icon";
                    scytheItems[i].Name = "ItemName" + ScytheID[i];
                    scytheItems[i].Description = "ItemDes" + ScytheID[i];

                    scytheWeapons[i].AttackSpeed = AttackSpeed[i];
                    scytheWeapons[i].Texture = "Scythe" + Material[i] + "Weapon";

                    scytheRecipes[i].CraftItem = ScytheID[i];

                    ConfigItem.Table[ScytheID[i]] = scytheItems[i];
                    ConfigWeapon.Table[ScytheID[i]] = scytheWeapons[i];
                    ConfigCraftCell.Table[ScytheID[i]] = scytheRecipes[i];
                }
            }
            catch (Exception e)
            {
                Log.Exception(e);
            }
        }

        private static IList<T> Clone<T>(params int[] ids) where T : DBBase => ids.Select(id => Clone<T>(id)).ToList();

        private static T Clone<T>(int id) where T : DBBase
        {
            var field = typeof(T).GetField("Table", BindingFlags.Static | BindingFlags.Public);
            var table = field.GetValue(null) as Dictionary<int, T>;
            var text = JsonConvert.SerializeObject(table[id]);
            return JsonConvert.DeserializeObject<T>(text);
        }
    }
}
