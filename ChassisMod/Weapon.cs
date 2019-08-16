using Common.Reflection;
using ChassisMod.Core;
using UnityEngine;
using Keplerth;
using DataBase;
using System;

namespace ChassisMod
{
    public sealed class Weapon : DataWrapper<ConfigWeapon>
    {
        public PropertyWrapper<Sprite, PropertyIdentity.ID0> Icon
        {
            get => this;
            set => value.Patch(this, "Icon", x => CustomResources.Load<Sprite>(x.Texture), (x, v) => x.Texture = SpritePatcher.FindOrAdd(v));
        }

        //public PropertyWrapper<float, PropertyIdentity.ID1> AttackSpeed
        //{
        //    get => this;
        //    set => value.Patch(this, "AttackSpeed", x => x.AttackSpeed, (x, v) => x.AttackSpeed = Math.Max(v, .01f));
        //}

        public SmartProperty<float> AttackSpeed { get => _attackSpeed; set => _attackSpeed.Patch(value); }

        private readonly SmartProperty<float> _attackSpeed;

        internal Weapon(string name, int id) : base(name, id)
        {
            _attackSpeed = new SmartProperty<float>("AttackSpeed", this, x => x.AttackSpeed, (x, v) => x.AttackSpeed = v, x => x > 0);
        }

        internal Weapon(string assemblyID, string name, int id) : base(assemblyID, name, id)
        {
            _attackSpeed = new SmartProperty<float>("AttackSpeed", this, x => x.AttackSpeed, (x, v) => x.AttackSpeed = v, x => x > 0);
        }

        internal void CopyFrom(Weapon source)
        {
            if (source == null) throw new ArgumentNullException("source was null");

            AddModification("", item => 
            {
                var data = ConfigWeapon.Table[source.ID];
                item.CopyInstanceFieldValues(data);
            });
        }
    }
}
