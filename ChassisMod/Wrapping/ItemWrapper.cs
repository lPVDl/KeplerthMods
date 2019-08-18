using ChassisMod.Patching;
using System.Reflection;
using UnityEngine;
using Keplerth;
using DataBase;
using System;

namespace ChassisMod.Wrapping
{
    public sealed class ItemWrapper : Entity, IWrapper<ConfigItem>
    {
        ConfigItem IWrapper<ConfigItem>.GetObject() => ConfigItem.Table[ID];

        void IWrapper<ConfigItem>.AddPatch(Action patch, Assembly patchOwner) => ConfigPatcher.Add(patch, patchOwner);

        public Container<Sprite> Icon { get; }
        public Container<int> Durability { get; }
        public Container<int> Category { get; }
        public Container<int> BuildDamageBonus { get; }
        public Container<int> TreeDamageBonus { get ; }
        public Container<int> WallDamageBonus { get; }

        internal ItemWrapper()
        {
            Icon = new WrapperContainer<ConfigItem, Sprite>()
            {
                Name = nameof(Icon),
                Owner = this,
                ValidateValue = x => x != null,
                ReadValue = x => CustomResources.Load<Sprite>(x.DropTexture),
                WriteValue = (x, v) => x.DropTexture = SpritePatcher.FindOrAdd(v),
            };

            Durability = new WrapperContainer<ConfigItem, int>()
            {
                Name = nameof(Durability),
                Owner = this,
                ValidateValue = x => x >= 0,
                ReadValue = x => x.Durability,
                WriteValue = (x, v) => x.Durability = v,
            };

            Category = new WrapperContainer<ConfigItem, int>()
            {
                Name = nameof(Category),
                Owner = this,
                ValidateValue = x => x >= 0,
                ReadValue = x => x.ItemType,
                WriteValue = (x, v) => x.ItemType = v,
            };

            BuildDamageBonus = new WrapperContainer<ConfigItem, int>()
            {
                Name = nameof(BuildDamageBonus),
                Owner = this,
                ValidateValue = x => x > 0,
                ReadValue = x => x.AttBuild,
                WriteValue = (x, v) => x.AttBuild = v,
            };

            TreeDamageBonus = new WrapperContainer<ConfigItem, int>()
            {
                Name = nameof(TreeDamageBonus),
                Owner = this,
                ValidateValue = x => x > 0,
                ReadValue = x => x.AttTree,
                WriteValue = (x, v) => x.AttTree = v,
            };

            WallDamageBonus = new WrapperContainer<ConfigItem, int>()
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
                    info.Entity = this;
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
                    info.Exception = e;
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
