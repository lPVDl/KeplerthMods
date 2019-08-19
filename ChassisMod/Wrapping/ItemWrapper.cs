using ChassisMod.Patching;
using System.Reflection;
using UnityEngine;
using Keplerth;
using DataBase;
using System;

namespace ChassisMod.Wrapping
{
    internal sealed class ItemWrapper : ConfigWrapper<ConfigItem>
    {
        public ConfigContainer<Sprite> Icon { get; }
        public ConfigContainer<int> Durability { get; }
        public ConfigContainer<int> Category { get; }
        public ConfigContainer<int> BuildDamageBonus { get; }
        public ConfigContainer<int> TreeDamageBonus { get ; }
        public ConfigContainer<int> WallDamageBonus { get; }

        internal ItemWrapper()
        {
            Icon = new ConfigContainer<Sprite>()
            {
                Name = nameof(Icon),
                Owner = this,
                ReadValue = x => CustomResources.Load<Sprite>(x.DropTexture),
                WriteValue = (x, v) => x.DropTexture = SpritePatcher.FindOrAdd(v),
                ValidateValue = x => x != null,
            };

            Durability = new ConfigContainer<int>()
            {
                Name = nameof(Durability),
                Owner = this,
                ReadValue = x => x.Durability,
                WriteValue = (x, v) => x.Durability = v,
                ValidateValue = x => x > 0,
            };

            Category = new ConfigContainer<int>()
            {
                Name = nameof(Category),
                Owner = this,
                ReadValue = x => x.ItemType,
                WriteValue = (x, v) => x.ItemType = v,
                ValidateValue = x => x >= 0,
            };

            BuildDamageBonus = new ConfigContainer<int>()
            {
                Name = nameof(BuildDamageBonus),
                Owner = this,
                ReadValue = x => x.AttBuild,
                WriteValue = (x, v) => x.AttBuild = v,
                ValidateValue = x => x > 0,
            };

            TreeDamageBonus = new ConfigContainer<int>()
            {
                Name = nameof(TreeDamageBonus),
                Owner = this,
                ReadValue = x => x.AttTree,
                WriteValue = (x, v) => x.AttTree = v,
                ValidateValue = x => x > 0,
            };

            WallDamageBonus = new ConfigContainer<int>()
            {
                Name = nameof(WallDamageBonus),
                Owner = this,
                ReadValue = x => x.AttWall,
                WriteValue = (x, v) => x.AttWall = v,
                ValidateValue = x => x > 0,
            };
        }

        //internal void CopyData(ItemWrapper source, Assembly patcher, bool log = true)
        //{
        //    Action patch = () =>
        //    {
        //        var info = new PatchLog.Message();

        //        try
        //        {
        //            info.Patcher = patcher;
        //            info.Target = this;
        //            info.NewValue = source;

        //            ConfigItem.Table[ID] = new ConfigItem(ConfigItem.Table[source.ID])
        //            {
        //                Name = "ItemName" + ID,
        //                Description = "ItemDes" + ID,
        //                FunctionDes = "ItemFunctionDes" + ID,
        //            };
        //        }
        //        catch(Exception e)
        //        {
        //            info.Error = e;
        //            throw;
        //        }
        //        finally
        //        {
        //            if (log) { info.Log(); }
        //        }
        //    };

        //    ConfigPatcher.Add(patch, patcher);
        //}
    }
}
