using ChassisMod.KeplerDatabase;
using ChassisMod.Core.Data;
using UnityEngine;
using ChassisMod;
using Keplerth;
using Harmony;
using Common;
using System;

namespace ScytheMod
{
    [StaticConstructorOnStartup]
    internal static class DataPatch
    {
        internal static Item[] Scythes { get; } = new Item[4];
        internal static float[] ExtraYieldChances { get; } = { .03f, .05f, .07f, 0.1f };

        static DataPatch()
        {
            try
            {
                // DataScanner.SaveDefinitions(@"T:\KeplerthDatabase\");
                // SpriteScanner.ExportAll(@"T:\KeplerthDatabase\Sprites\");

                var assets = AssetBundle.LoadFromMemory(Properties.Resources.Assets);
                string[] materials = { "Copper", "Iron", "Silver", "Gold" };
                Item[] pickaxes = { ItemDB.CopperPickaxe, ItemDB.IronPickaxe, ItemDB.SilverPickaxe, ItemDB.GoldPickaxe0 };
                Item[] ingots = { ItemDB.CopperBar, ItemDB.IronBar, ItemDB.SilverBar, ItemDB.GoldBar };
                Craft[] crafts = new Craft[4];
                float[] attackSpeeds = { .6f, .8f, 1f, 1.2f };
                int[] durabilities = { 80, 120, 150, 200 };
                int[] treeDamageBonuses = { 2, 3, 4, 5 };

                for(var i = 0; i < 4; i++)
                {
                    Scythes[i] = new Item(materials[i] + "Scythe", pickaxes[i]);
                    Scythes[i].Icon = assets.LoadAsset<Sprite>("Scythe" + materials[i] + "Icon");
                    Scythes[i].Weapon.Sprite = assets.LoadAsset<Sprite>("Scythe" + materials[i] + "Weapon");
                    Scythes[i].Weapon.AttackSpeed = attackSpeeds[i];
                    Scythes[i].Durability = durabilities[i];
                    Scythes[i].BuildDamageBonus = 1;
                    Scythes[i].WallDamageBonus = 1;
                    Scythes[i].TreeDamageBonus = treeDamageBonuses[i];
                    Scythes[i].SetDefaultTranslation(materials[i] + " Scythe", $"Harvests extra seed with {(int)Math.Round(ExtraYieldChances[i] * 100)}% chance.");
                    Scythes[i].ItemType = 0;

                    crafts[i] = new Craft(materials[i] + "Scythe", Scythes[i], 1, Tuple.Create(ingots[i], 6), Tuple.Create(ItemDB.Wood, 1));
                }

                var scytheGroup = new CraftGroup("Scythe", crafts);
                CraftTable[] anvils = { CraftTableDB.CopperAnvil, CraftTableDB.IronAnvil, CraftTableDB.SilverAnvil, CraftTableDB.GoldenAnvil };
                anvils.Do(a => a.Insert(scytheGroup, CraftGroupDB.Shovel, 1));

                scytheGroup.SetDefaultTranslation("Scythe", "An cutting-edge sharp tool which obviously your grass would not like to deal with.", "Materials: Metal Bar + Wood");
            }
            catch (Exception e) { Log.Exception(e); }           
        }       
    }
}
