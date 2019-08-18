using ChassisMod.Patching;
using System.Reflection;
using UnityEngine;
using Keplerth;
using DataBase;
using System;

namespace ChassisMod.Wrapping
{
    internal sealed class ItemWrapper : Wrapper<ConfigItem>
    {
        public Container<Sprite> Icon { get; }
        public Container<int> Durability { get; }
        public Container<int> Category { get; }
        public Container<int> BuildDamageBonus { get; }
        public Container<int> TreeDamageBonus { get ; }
        public Container<int> WallDamageBonus { get; }

        internal ItemWrapper()
        {
            Icon = new Container<Sprite>()
            {
                Name = nameof(Icon),
                Owner = this,
                ReadValue = x => CustomResources.Load<Sprite>(x.DropTexture),
                WriteValue = (x, v) => x.DropTexture = SpritePatcher.FindOrAdd(v),
                ValidateValue = x => x != null,
            };

            Durability = new Container<int>()
            {
                Name = nameof(Durability),
                Owner = this,
                ReadValue = x => x.Durability,
                WriteValue = (x, v) => x.Durability = v,
                ValidateValue = x => x > 0,
            };

            Category = new Container<int>()
            {
                Name = nameof(Category),
                Owner = this,
                ReadValue = x => x.ItemType,
                WriteValue = (x, v) => x.ItemType = v,
                ValidateValue = x => x >= 0,
            };

            BuildDamageBonus = new Container<int>()
            {
                Name = nameof(BuildDamageBonus),
                Owner = this,
                ReadValue = x => x.AttBuild,
                WriteValue = (x, v) => x.AttBuild = v,
                ValidateValue = x => x > 0,
            };

            TreeDamageBonus = new Container<int>()
            {
                Name = nameof(TreeDamageBonus),
                Owner = this,
                ReadValue = x => x.AttTree,
                WriteValue = (x, v) => x.AttTree = v,
                ValidateValue = x => x > 0,
            };

            WallDamageBonus = new Container<int>()
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
