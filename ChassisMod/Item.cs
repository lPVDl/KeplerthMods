﻿using Common.Reflection;
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

        public PropertyWrapper<string, Sprite, PropertyIdentity.ID0> Icon
        {
            get => this;
            set => value.Patch(this, "Icon", x => x.DropTexture, (x, v) => x.DropTexture = v, x => SpritePatcher.FindOrAdd(x));
        }

        public PropertyWrapper<int, PropertyIdentity.ID1> Durability
        {
            get => this;
            set => value.Patch(this, "Durability", x => x.Durability, (x, v) => x.Durability = Math.Max(v, 1));
        }

        public PropertyWrapper<int, PropertyIdentity.ID2> ItemType
        {
            get => this;
            set => value.Patch(this, "ItemType", x => x.ItemType, (x, v) => x.ItemType = Math.Max(v, 0));
        }

        public PropertyWrapper<int, PropertyIdentity.ID3> WallDamageBonus
        {
            get => this;
            set => value.Patch(this, "WallDamageBonus", x => x.AttWall, (x, v) => x.AttWall = Math.Max(v, 1));
        }

        public PropertyWrapper<int, PropertyIdentity.ID4> TreeDamageBonus
        {
            get => this;
            set => value.Patch(this, "TreeDamageBonus", x => x.AttTree, (x, v) => x.AttTree = Math.Max(v, 1));
        }

        public PropertyWrapper<int, PropertyIdentity.ID5> BuildDamageBonus
        {
            get => this;
            set => value.Patch(this, "BuildDamageBonus", x => x.AttBuild, (x, v) => x.AttBuild = Math.Max(v, 1));
        }

        internal Item(string name, int id) : base(name, id)
        {
            Weapon = new Weapon(AssemblyID, Name + ".Weapon", ID);
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
            AddInstatiation(data, source.ToString());

            Weapon = new Weapon(AssemblyID, Name + ".Weapon", ID);
            Weapon.AddInstatiation(new ConfigWeapon(), source.Weapon.ToString());

            CopyFrom(source);
            Weapon.CopyFrom(source.Weapon);

            LanguagePatcher.AddDefault(data.Description, "0");
            LanguagePatcher.AddDefault(data.FunctionDes, "0");
        }

        internal void CopyFrom(Item source)
        { 
            // var patchInfo = $"{this} = {source}";
            AddModification("", CopyData);

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