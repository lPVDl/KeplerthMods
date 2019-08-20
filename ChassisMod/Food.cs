using ChassisMod.Wrapping;
using System.Reflection;

namespace ChassisMod
{
    public sealed partial class Food : Entity, IWrapperManipulator
    {
        public override int ID
        {
            get => base.ID;

            internal set
            {
                base.ID = value;
                _item.ID = value;
                _food.ID = value;
            }
        }

        public override string Name
        {
            get => base.Name;

            internal set
            {
                base.Name = value;
                _item.Name = value;
                _food.Name = value;
            }
        }

        public Reader<float> PlayerSatiety
        {
            get => _food.PlayerSatiety.Reader;
            set => _food.PlayerSatiety.Set(value, Assembly.GetCallingAssembly());
        }

        private readonly ItemWrapper _item = new ItemWrapper();
        private readonly FoodWrapper _food = new FoodWrapper();

        internal Food()
        {

        }
    }
}
