using ChassisMod.Wrapping;

namespace ChassisMod
{
    public sealed partial class Food : WrapperHybrid
    {
        private readonly ItemWrapper _item;
        private readonly FoodWrapper _food;

        private Food(string name, int id) : base(name, id)
        {
            _item = new ItemWrapper(this);
            _food = new FoodWrapper(this);
        }
    }
}
