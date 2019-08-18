using ChassisMod.Wrapping;
using System.Reflection;

namespace ChassisMod
{
    public sealed class Item : Entity
    {
        public static Item StonePickaxe = new Item() { ID = 6102, Name = "StonePickaxe" };

        public override int ID
        {
            get => id.Get();

            internal set
            {
                id.Set(value);
                _item.ID = value;
            }
        }

        public override string Name
        {
            get => name.Get();

            internal set
            {
                name.Set(value);
                _item.Name = value;
            }
        }

        public Container<int> TreeDamageBonus
        {
            get => _item.TreeDamageBonus;
            set => _item.TreeDamageBonus.Set(value, Assembly.GetCallingAssembly());
        }

        private readonly ItemWrapper _item = new ItemWrapper();

        internal Item()
        {
            
        }
    }
}
