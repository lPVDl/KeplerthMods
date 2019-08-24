using System.Collections.Generic;
using Chassis.Utilities;
using Chassis.Wrapping;
using System.Linq;
using System;
using Common;

namespace Chassis.Entities
{
    public sealed partial class Item : IEntity, IEntityManager
    {
        #region Manager
        IEnumerable<IEntity> IEntityManager.CompiledEntities => Entity.FindCompiledEntitiesCashed<Item>();

        IEnumerable<IEntity> IEntityManager.RuntimeEntities => Entity.CreateRuntimeEntitiesCashed(GetIDs, GetNameOrNull, (id, name) => new Item(id, name));

        bool IEntityManager.CreationRequiresSource => true;

        Entity.ManagerGroup IEntityManager.NamingGroup => Item.NamingGroup;

        IEnumerable<IPropertyInfo> IEntityManager.GetProperties(IEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("entity was null");
            var item = entity as Item;
            if (item == null) throw new InvalidOperationException($"entity was not {typeof(Item)}");

            return Entity.GetPropertyValues<Item, IPropertyInfo>(item);
        }

        IEntity IEntityManager.Create(string entityName, IEntity source, IInvokationAddress patcher)
        {
            if (string.IsNullOrEmpty(entityName)) throw new ArgumentException("entityName was null or empty");
            if (source == null) throw new ArgumentNullException("source was null");
            if (patcher == null) throw new ArgumentNullException("patcher was null");

            var sourceItem = source as Item;
            if (sourceItem == null) throw new InvalidOperationException($"source was not {typeof(Item)}");

            var id = CreateID(entityName);
            var item = new Item(id, entityName);

            item._item.Initialize(sourceItem._item, patcher, true);

            return item;
        }
        #endregion

        internal static Entity.ManagerGroup NamingGroup { get; }

        public ILocalization Name => _item.Name;
        public ILocalization Description => _item.Description;

        public int ID { get; }
        string IEntity.Name => _name;

        private readonly ItemWrapper _item;
        private readonly string _name;

        static Item()
        {
            try
            {
                IEntityManager[] managers =
                {
                    Entity.GetManager<Item>(),
                    Entity.GetManager<Food>(),
                    Entity.GetManager<Weapon>()
                };
                NamingGroup = new Entity.ManagerGroup(managers);
            }
            catch (Exception e) { Log.Exception(e); }
        }

        private Item(int id, string name)
        {
            ID = id;
            _name = name;

            _item = new ItemWrapper(this);
        }

        private static IEnumerable<int> GetIDs()
        {
            return from id in ItemWrapper.Table.Keys
                   where !FoodWrapper.Table.ContainsKey(id)
                   where !WeaponWrapper.Table.ContainsKey(id)
                   select id;
        }      

        private static string GetNameOrNull(int id) => LanguageUtil.GetNameOrNull(ItemWrapper.Table[id].Name);

        internal static int CreateID(string name) => IDGenerator.CreateID("Item." + name);
    }
}
