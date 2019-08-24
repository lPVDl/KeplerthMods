using System.Collections.Generic;
using Chassis.Utilities;
using System.Reflection;
using Chassis.Wrapping;
using System.Linq;
using System;

namespace Chassis.Entities
{
    public sealed partial class Weapon : IEntity, IEntityManager
    {
        #region Manager
        IEnumerable<IEntity> IEntityManager.CompiledEntities => Entity.FindCompiledEntitiesCashed<Weapon>();

        IEnumerable<IEntity> IEntityManager.RuntimeEntities => Entity.CreateRuntimeEntitiesCashed(GetIDs, GetNameOrNull, (id, name) => new Weapon(id, name));

        bool IEntityManager.CreationRequiresSource => true;

        Entity.ManagerGroup IEntityManager.NamingGroup => Item.NamingGroup;

        IEnumerable<IPropertyInfo> IEntityManager.GetProperties(IEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("entity was null");
            var weapon = entity as Weapon;
            if (weapon == null) throw new InvalidOperationException($"entity was not {typeof(Weapon)}");

            return Entity.GetPropertyValues<Weapon, IPropertyInfo>(weapon);
        }

        IEntity IEntityManager.Create(string entityName, IEntity source, IInvokationAddress patcher)
        {
            if (string.IsNullOrEmpty(entityName)) throw new ArgumentException("entityName was null or empty");
            if (source == null) throw new ArgumentNullException("source was null");
            if (patcher == null) throw new ArgumentNullException("patcher was null");

            var sourceWeapon = source as Weapon;
            if (sourceWeapon == null) throw new InvalidOperationException($"source was not {typeof(Weapon)}");

            var id = Item.CreateID(entityName);
            var weapon = new Weapon(id, entityName);

            weapon._item.Initialize(sourceWeapon._item, patcher, true);
            weapon._weapon.Initialize(sourceWeapon._weapon, patcher, true);

            return weapon;
        }
        #endregion

        public ILocalization Name => _item.Name;
        public ILocalization Description => _item.Description;

        public Reader<int> TreeDamageBonus
        {
            get => _item.TreeDamageBonus.Reader;
            set => _item.TreeDamageBonus.Set(value, new InvokationAddress(Assembly.GetCallingAssembly(), Environment.StackTrace));
        }

        public Reader<int> WallDamageBonus
        {
            get => _item.WallDamageBonus.Reader;
            set => _item.WallDamageBonus.Set(value, new InvokationAddress(Assembly.GetCallingAssembly(), Environment.StackTrace));
        }

        public Reader<int> BuildDamageBonus
        {
            get => _item.BuildDamageBonus.Reader;
            set => _item.BuildDamageBonus.Set(value, new InvokationAddress(Assembly.GetCallingAssembly(), Environment.StackTrace));
        }

        public int ID { get; }
        string IEntity.Name => _name;

        private readonly ItemWrapper _item;
        private readonly WeaponWrapper _weapon;
        private readonly string _name;

        private Weapon(int id, string name)
        {
            ID = id;
            _name = name;

            _item = new ItemWrapper(this);
            _weapon = new WeaponWrapper(this);
        }

        private static IEnumerable<int> GetIDs()
        {
            return from id in WeaponWrapper.Table.Keys
                   where ItemWrapper.Table.ContainsKey(id)
                   select id;
        }

        private static string GetNameOrNull(int id) => LanguageUtil.GetNameOrNull(ItemWrapper.Table[id].Name);
    }
}
