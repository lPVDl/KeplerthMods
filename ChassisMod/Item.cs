using ChassisMod.Wrapping;
using System.Reflection;

namespace ChassisMod
{
    public sealed partial class Item : WrapperHybrid
    {
        public static readonly Item StonePickaxe = new Item("StonePickaxe", 6102);

        public Reader<int> TreeDamageBonus
        {
            get => _item.TreeDamageBonus.Reader;
            set => _item.TreeDamageBonus.Set(value, Assembly.GetCallingAssembly());
        }

        private readonly ItemWrapper _item;

        private Item(string name, int id) : base(name, id)
        {
            _item = new ItemWrapper(this);
        }
    }
}
