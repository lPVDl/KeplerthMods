using System.Collections.Generic;
using ChassisMod.Utilities;
using ChassisMod.Wrapping;
using System.Reflection;
using System.Linq;
using System;

namespace ChassisMod
{
    public sealed partial class Item : IEntity, IEntityManager
    {
        IEnumerable<IEntity> IEntityManager.CompiledInstances => Entity.FindCompiledEntitiesCashed<Item>();

        IEnumerable<IEntity> IEntityManager.RuntimeInstances => Entity.CreateRuntimeEntitiesCashed(GetIDs, GetNameOrNull, (id, name) => new Item(id, name));

        IEnumerable<IPropertyInfo> IEntityManager.GetProperties(IEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("entity was null");

            var item = entity as Item;

            if (item == null) throw new InvalidOperationException($"entity was not {typeof(Item)}");

            return Entity.GetPropertyValues<Item, IPropertyInfo>(item);
        }          

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
