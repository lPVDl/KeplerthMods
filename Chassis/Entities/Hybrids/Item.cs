using System.Collections.Generic;
using Chassis.Utilities;
using Chassis.Wrapping;
using System.Reflection;
using System.Linq;
using System;

namespace Chassis.Entities
{
    public sealed partial class Item : IEntity, IEntityManager
    {
        #region Manager
        IEnumerable<IEntity> IEntityManager.CompiledEntities => Entity.FindCompiledEntitiesCashed<Item>();

        IEnumerable<IEntity> IEntityManager.RuntimeEntities => Entity.CreateRuntimeEntitiesCashed(GetIDs, GetNameOrNull, (id, name) => new Item(id, name));

        bool IEntityManager.RequiresSourceForCreation => true;

        Entity.ManagerGroup IEntityManager.NamingGroup => Item.NamingGroup;

        IEnumerable<IPropertyInfo> IEntityManager.GetProperties(IEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("entity was null");
            var item = entity as Item;
            if (item == null) throw new InvalidOperationException($"entity was not {typeof(Item)}");

            return Entity.GetPropertyValues<Item, IPropertyInfo>(item);
        }

        IEntity IEntityManager.Create(Assembly owner, string entityName, IEntity source) => throw new NotImplementedException();
        #endregion

        internal static readonly Entity.ManagerGroup NamingGroup = new Entity.ManagerGroup(Entity.GetManager<Item>(), Entity.GetManager<Food>());

        public int ID { get; }
        public string Name { get; }

        public Reader<int> TreeDamageBonus
        {
            get => _item.TreeDamageBonus.Reader;
            set => _item.TreeDamageBonus.Set(value, Assembly.GetCallingAssembly());
        }

        private readonly ItemWrapper _item;

        private Item(int id, string name)
        {
            ID = id;
            Name = name;

            _item = new ItemWrapper(this);
        }

        private static IEnumerable<int> GetIDs()
        {
            return from id in ItemWrapper.Table.Keys
                   where !FoodWrapper.Table.ContainsKey(id)
                   select id;
        }      

        private static string GetNameOrNull(int id) => LanguageUtil.GetNameOrNull(ItemWrapper.Table[id].Name);
    }
}
