using Common.Reflection;
using ChassisMod.Core;
using UnityEngine;
using DataBase;
using System;

namespace ChassisMod
{
    public sealed class Weapon : DataWrapper<ConfigWeapon>
    {
        public Sprite Sprite
        {
            set
            {
                if (value == null) throw new ArgumentNullException("value was null");

                var sprite = SpritePatcher.Add(value);
                var patchInfo = $"SET_SPRITE [{this}] -> {value}";
                AddModification(patchInfo, weapon =>
                {
                    weapon.Texture = sprite;
                });
            }
        }

        public float AttackSpeed
        {
            set
            {
                if (value <= 0) throw new ArgumentException("value must be greater than zero");

                var patchInfo = $"SET_ATTACK_SPEED [{this}] -> {value}";
                AddModification(patchInfo, weapon => 
                {
                    weapon.AttackSpeed = value;
                });
            }
        }

        internal Weapon(string name, int id) : base(name, id) { }

        internal Weapon(string assemblyID, string name, int id) : base(assemblyID, name, id) { }

        internal void CopyFrom(Weapon source)
        {
            if (source == null) throw new ArgumentNullException("source was null");

            var patchInfo = $"COPY_TO [{this}] FROM [{source}]";
            AddModification(patchInfo, item => 
            {
                var data = ConfigWeapon.Table[source.ID];
                item.CopyInstanceFieldValues(data);
            });
        }
    }
}
