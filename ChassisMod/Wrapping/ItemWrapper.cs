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
                ValidateValue = x => x != null,
                ReadValue = x => CustomResources.Load<Sprite>(x.DropTexture),
                WriteValue = (x, v) => x.DropTexture = SpritePatcher.FindOrAdd(v),
            };

            Durability = new Container<int>()
            {
                Name = nameof(Durability),
                Owner = this,
                ValidateValue = x => x >= 0,
                ReadValue = x => x.Durability,
                WriteValue = (x, v) => x.Durability = v,
            };

            Category = new Container<int>()
            {
                Name = nameof(Category),
                Owner = this,
                ValidateValue = x => x >= 0,
                ReadValue = x => x.ItemType,
                WriteValue = (x, v) => x.ItemType = v,
            };

            BuildDamageBonus = new Container<int>()
            {
                Name = nameof(BuildDamageBonus),
                Owner = this,
                ValidateValue = x => x > 0,
                ReadValue = x => x.AttBuild,
                WriteValue = (x, v) => x.AttBuild = v,
            };

            TreeDamageBonus = new Container<int>()
            {
                Name = nameof(TreeDamageBonus),
                Owner = this,
                ValidateValue = x => x > 0,
                ReadValue = x => x.AttTree,
                WriteValue = (x, v) => x.AttTree = v,
            };

            WallDamageBonus = new Container<int>()
            {
                Name = nameof(WallDamageBonus),
                Owner = this,
                ValidateValue = x => x > 0,
                ReadValue = x => x.AttWall,
                WriteValue = (x, v) => x.AttWall = v,
            };
        }

        internal void CopyData(ItemWrapper source, Assembly patcher, bool log = true)
        {
            Action patch = () =>
            {
                var info = new PatchLog.Message();

                try
                {
                    info.Patcher = patcher;
                    info.Target = this;
                    info.NewValue = source;

                    ConfigItem.Table[ID] = new ConfigItem(ConfigItem.Table[source.ID])
                    {
                        Name = "ItemName" + ID,
                        Description = "ItemDes" + ID,
                        FunctionDes = "ItemFunctionDes" + ID,
                    };
                }
                catch(Exception e)
                {
                    info.Error = e;
                    throw;
                }
                finally
                {
                    if (log) { info.Log(); }
                }
            };

            ConfigPatcher.Add(patch, patcher);
        }
    }
}
