using ChassisMod.Patching;
using UnityEngine;
using Keplerth;
using DataBase;
using System;
using Common;

namespace ChassisMod.Wrapping
{
    internal sealed class ItemWrapper : ConfigWrapper<ConfigItem>
    {
        public ConfigContainer<ConfigItem, Sprite> Icon { get; }
        public ConfigContainer<ConfigItem, int> Durability { get; }
        public ConfigContainer<ConfigItem, int> Category { get; }
        public ConfigContainer<ConfigItem, int> BuildDamageBonus { get; }
        public ConfigContainer<ConfigItem, int> TreeDamageBonus { get ; }
        public ConfigContainer<ConfigItem, int> WallDamageBonus { get; }

        internal ItemWrapper()
        {
            Icon = new ConfigContainer<ConfigItem, Sprite>()
            {
                ReadValue = x => CustomResources.Load<Sprite>(x.DropTexture),
                WriteValue = (x, v) => x.DropTexture = SpritePatcher.FindOrAdd(v),
                ValidateValue = x => x != null,
            };

            Durability = new ConfigContainer<ConfigItem, int>()
            {
                ReadValue = x => x.Durability,
                WriteValue = (x, v) => x.Durability = v,
                ValidateValue = x => x > 0,
            };

            Category = new ConfigContainer<ConfigItem, int>()
            {
                ReadValue = x => x.ItemType,
                WriteValue = (x, v) => x.ItemType = v,
                ValidateValue = x => x >= 0,
            };

            BuildDamageBonus = new ConfigContainer<ConfigItem, int>()
            {
                ReadValue = x => x.AttBuild,
                WriteValue = (x, v) => x.AttBuild = v,
                ValidateValue = x => x > 0,
            };

            TreeDamageBonus = new ConfigContainer<ConfigItem, int>()
            {
                ReadValue = x => x.AttTree,
                WriteValue = (x, v) => x.AttTree = v,
                ValidateValue = x => x > 0,
            };

            WallDamageBonus = new ConfigContainer<ConfigItem, int>()
            {
                ReadValue = x => x.AttWall,
                WriteValue = (x, v) => x.AttWall = v,
                ValidateValue = x => x > 0,
            };

            try
            {
                FinishContainersInitialization();
            }
            catch (Exception e) { Log.ExceptionOnce(e); }
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
