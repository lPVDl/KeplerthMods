using Common.Reflection;
using System.Reflection;
using ChassisMod.Core;
using UnityEngine;
using DataBase;
using System;

namespace ChassisMod
{
    public sealed class Item : DataWrapper<ConfigItem>
    {
        public Weapon Weapon { get; }

        public Sprite Icon
        {
            set
            {
                if (value == null) throw new ArgumentNullException("value was null");

                var sprite = SpritePatcher.Add(value);
                var patchInfo = $"SET_ICON [{this}] -> {value}";
                AddModification(patchInfo, item =>
                {
                    item.DropTexture = sprite;
                });
            }
        }

        public int Durability
        {
            set
            {
                if (value <= 0) throw new ArgumentException("value must be greater than zero");

                var patchInfo = $"SET_DURABILITY [{this}] -> {value}";
                AddModification(patchInfo, item =>
                {
                    item.Durability = value;
                });
            }
        }

        public int ItemType
        {
            set
            {
                if (value < 0) throw new ArgumentException("value must be greater than zero");

                var patchInfo = $"SET_ITEM_TYPE [{this}] -> {value}";
                AddModification(patchInfo, item =>
                {
                    item.ItemType = value;
                });
            }
        }

        public int WallDamageBonus
        {
            set
            {
                if (value <= 0) throw new ArgumentException("value must be greater than zero");

                var patchInfo = $"SET_WALL_DMG_BONUS [{this}] -> {value}";
                AddModification(patchInfo, item =>
                {
                    item.AttWall = value;
                });
            }
        }

        public int TreeDamageBonus
        {
            set
            {
                if (value <= 0) throw new ArgumentException("value must be greater than zero");

                var patchInfo = $"SET_TREE_DMG_BONUS [{this}] -> {value}";
                AddModification(patchInfo, item =>
                {
                    item.AttTree = value;
                });
            }
        }

        public int BuildDamageBonus
        {
            set
            {
                if (value <= 0) throw new ArgumentException("value must be greater than zero");

                var patchInfo = $"SET_BUILD_DMG_BONUS [{this}] -> {value}";
                AddModification(patchInfo, item =>
                {
                    item.AttBuild = value;
                });
            }
        }

        internal Item(string name, int id) : base(name, id)
        {
            Weapon = new Weapon(AssemblyID, Name, ID);
        }

        public Item(string name, Item source) : base(Assembly.GetCallingAssembly().GetName().Name, name)
        {
            if (source == null) throw new ArgumentNullException("source was null");

            var data = new ConfigItem()
            {
                Name = "ItemName" + ID,
                Description = "ItemDes" + ID,
                FunctionDes = "ItemFunctionDes" + ID,
            };
            AddInstatiation(data);

            Weapon = new Weapon(AssemblyID, Name, ID);
            Weapon.AddInstatiation(new ConfigWeapon());

            CopyFrom(source);
            Weapon.CopyFrom(source.Weapon);

            LanguagePatcher.AddDefault(data.Description, "0");
            LanguagePatcher.AddDefault(data.FunctionDes, "0");
        }

        internal void CopyFrom(Item source)
        { 
            var patchInfo = $"COPY_TO [{this}] FROM [{source}]";
            AddModification(patchInfo, CopyData);

            void CopyData(ConfigItem item)
            {
                var name = item.GetInstanceFieldValue("name");
                var description = item.GetInstanceFieldValue("description");
                var functionDes = item.GetInstanceFieldValue("functionDes");

                var data = ConfigItem.Table[source.ID];
                item.CopyInstanceFieldValues(data);

                item.SetInstanceFieldValue("name", name);
                item.SetInstanceFieldValue("description", description);
                item.SetInstanceFieldValue("functionDes", functionDes);
            }
        }

        public void SetDefaultTranslation(string name, string description = "0", string functional = "0")
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("name was null or empty");
            if (string.IsNullOrEmpty(description)) throw new ArgumentException("description was null or empty");
            if (string.IsNullOrEmpty(functional)) throw new ArgumentException("function was null or empty");

            LanguagePatcher.AddDefault("ItemName" + ID, name);
            LanguagePatcher.AddDefault("ItemDes" + ID, description);
            LanguagePatcher.AddDefault("ItemFunctionDes" + ID, functional);
        }
    }
}
