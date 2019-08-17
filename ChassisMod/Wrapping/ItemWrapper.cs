using ChassisMod.Patching;
using System.Reflection;
using ChassisMod.Core;
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

        public Property<Sprite> Icon { get; }
        public Property<int> Durability { get; }
        public Property<int> Category { get; }
        public Property<int> BuildDamageBonus { get; }
        public Property<int> TreeDamageBonus { get ; }
        public Property<int> WallDamageBonus { get; }

        internal ItemWrapper()
        {
            Icon = new Property<ConfigItem, Sprite>()
            {
                ValidateData = x => x != null,
                ReadData = x => CustomResources.Load<Sprite>(x.DropTexture),
                WriteData = (x, v) => x.DropTexture = SpritePatcher.FindOrAdd(v),
            };

            Durability = new Property<ConfigItem, int>()
            {
                ValidateData = x => x >= 0,
                ReadData = x => x.Durability,
                WriteData = (x, v) => x.Durability = v,
            };

            Category = new Property<ConfigItem, int>()
            {
                ValidateData = x => x >= 0,
                ReadData = x => x.ItemType,
                WriteData = (x, v) => x.ItemType = v,
            };

            BuildDamageBonus = new Property<ConfigItem, int>()
            {
                ValidateData = x => x > 0,
                ReadData = x => x.AttBuild,
                WriteData = (x, v) => x.AttBuild = v,
            };

            TreeDamageBonus = new Property<ConfigItem, int>()
            {
                ValidateData = x => x > 0,
                ReadData = x => x.AttTree,
                WriteData = (x, v) => x.AttTree = v,
            };

            WallDamageBonus = new Property<ConfigItem, int>()
            {
                ValidateData = x => x > 0,
                ReadData = x => x.AttWall,
                WriteData = (x, v) => x.AttWall = v,
            };

            this.InitializeProperties();
        }

        internal void CopyData(ItemWrapper source, Assembly patchOwner)
        {
            Action patch = () =>
            {
                ConfigItem.Table[ID] = new ConfigItem(ConfigItem.Table[source.ID])
                {
                    Name = "ItemName" + ID,
                    Description = "ItemDes" + ID,
                    FunctionDes = "ItemFunctionDes" + ID,
                };
            };

            ConfigPatcher.Add(patch, patchOwner);
        }
    }
}
