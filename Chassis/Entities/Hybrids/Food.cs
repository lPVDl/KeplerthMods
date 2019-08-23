using System.Collections.Generic;
using Chassis.Utilities;
using Chassis.Wrapping;
using System.Reflection;
using System.Linq;
using System;

namespace Chassis.Entities
{
    public sealed partial class Food : IEntity, IEntityManager
    {
        #region Manager
        IEnumerable<IEntity> IEntityManager.CompiledEntities => Entity.FindCompiledEntitiesCashed<Food>();

        IEnumerable<IEntity> IEntityManager.RuntimeEntities => Entity.CreateRuntimeEntitiesCashed(GetIDs, GetNameOrNull, (id, name) => new Food(id, name));

        bool IEntityManager.CreationRequiresSource => true;

        Entity.ManagerGroup IEntityManager.NamingGroup => Item.NamingGroup;

        IEnumerable<IPropertyInfo> IEntityManager.GetProperties(IEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("entity was null");
            var food = entity as Food;
            if (food == null) throw new InvalidOperationException($"entity was not {typeof(Food)}");

            return Entity.GetPropertyValues<Food, IPropertyInfo>(food);
        }

        IEntity IEntityManager.Create(string entityName, IEntity source, Assembly patcher)
        {
            if (string.IsNullOrEmpty(entityName)) throw new ArgumentException("entityName was null or empty");
            if (source == null) throw new ArgumentNullException("source was null");
            if (patcher == null) throw new ArgumentNullException("patcher was null");

            var sourceFood = source as Food;
            if (sourceFood == null) throw new InvalidOperationException($"source was not {typeof(Food)}");

            var id = Item.CreateID(entityName);
            var food = new Food(id, entityName);

            food._item.Initialize(sourceFood._item, patcher, true);
            food._food.Initialize(sourceFood._food, patcher, false);

            return food;
        }
        #endregion

        public int ID { get; }
        public string Name { get; }

        public Reader<float> PlayerSatiety
        {
            get => _food.PlayerSatiety.Reader;
            set => _food.PlayerSatiety.Set(value, Assembly.GetExecutingAssembly());
        }

        private readonly ItemWrapper _item;
        private readonly FoodWrapper _food;

        private Food(int id, string name)
        {
            ID = id;
            Name = name;

            _item = new ItemWrapper(this);
            _food = new FoodWrapper(this);
        }

        private static IEnumerable<int> GetIDs()
        {
            return from id in FoodWrapper.Table.Keys
                   where ItemWrapper.Table.ContainsKey(id)
                   select id;
        }

        private static string GetNameOrNull(int id) => LanguageUtil.GetNameOrNull(ItemWrapper.Table[id].Name);
    }
}
