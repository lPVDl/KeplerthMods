using ChassisMod.Core;
using UnityEngine;
using Keplerth;
using DataBase;
using System;

namespace ChassisMod
{
    public class Item : SmartConfig, IWrapper<ConfigItem>
    {
        ConfigItem IWrapper<ConfigItem>.GetObject() => ConfigItem.Table[ID];

        public Property<Sprite> Icon    { get => _icon;       set => _icon.Set(value); }
        public Property<int> Durability { get => _durability; set => _durability.Set(value); }
        public Property<int> Category   { get => _category;   set => _category.Set(value); }
        public Property<int> BuildDamageBonus { get => _buildDamageBonus; set => _buildDamageBonus.Set(value); }
        public Property<int> TreeDamageBonus  { get => _treeDamageBonus;  set => _treeDamageBonus.Set(value); }
        public Property<int> WallDamageBonus  { get => _wallDamageBonus;  set => _wallDamageBonus.Set(value); }

        private readonly Property<Sprite> _icon;
        private readonly Property<int> _durability;
        private readonly Property<int> _category;
        private readonly Property<int> _buildDamageBonus;
        private readonly Property<int> _treeDamageBonus;
        private readonly Property<int> _wallDamageBonus;

        internal Item()
        {
            _icon = new Property<ConfigItem, Sprite>()
            {
                Name = nameof(Icon),
                Owner = this,
                ValidateData = x => x != null,
                ReadData = x => CustomResources.Load<Sprite>(x.DropTexture),
                WriteData = (x, v) => x.DropTexture = SpritePatcher.FindOrAdd(v),
                Patcher = DatabasePatcher
            };

            _durability = new Property<ConfigItem, int>()
            {
                Name = nameof(Durability),
                Owner = this,
                ValidateData = x => x >= 0,
                ReadData = x => x.Durability,
                WriteData = (x, v) => x.Durability = v,
                Patcher = DatabasePatcher
            };

            _category = new Property<ConfigItem, int>()
            {
                Name = nameof(Category),
                Owner = this,
                ValidateData = x => x >= 0,
                ReadData = x => x.ItemType,
                WriteData = (x, v) => x.ItemType = v,
                Patcher = DatabasePatcher
            };

            _buildDamageBonus = new Property<ConfigItem, int>()
            {
                Name = nameof(BuildDamageBonus),
                Owner = this,
                ValidateData = x => x > 0,
                ReadData = x => x.AttBuild,
                WriteData = (x, v) => x.AttBuild = v,
                Patcher = DatabasePatcher
            };

            _wallDamageBonus = new Property<ConfigItem, int>()
            {
                Name = nameof(WallDamageBonus),
                Owner = this,
                ValidateData = x => x > 0,
                ReadData = x => x.AttWall,
                WriteData = (x, v) => x.AttWall = v,
                Patcher = DatabasePatcher
            };

            _treeDamageBonus = new Property<ConfigItem, int>()
            {
                Name = nameof(TreeDamageBonus),
                Owner = this,
                ValidateData = x => x > 0,
                ReadData = x => x.AttTree,
                WriteData = (x, v) => x.AttTree = v,
                Patcher = DatabasePatcher
            };
        }

        public Item(string name, Item source) : this()
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("name was null or empty");
            if (source == null) throw new ArgumentNullException("source was null");

            Name = name;
            Assembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            ID = IDGenerator.CreateID("Item." + Assembly + "." + Name);

            Action patch = () =>
            {
                ConfigItem.Table[ID] = new ConfigItem(ConfigItem.Table[source.ID])
                {
                    Name = "ItemName" + ID,
                    Description = "ItemDes" + ID,
                    FunctionDes = "ItemFunctionDes" + ID,
                };
            };

            DatabasePatcher.Add(patch, $"{this} = {source}");
        }
    }
}
