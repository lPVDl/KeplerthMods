using DataBase;

namespace ChassisMod.Wrapping
{
    internal sealed class FoodWrapper : Wrapper<ConfigFood>
    {
        public Container<int> PlayerSatiety { get; }

        internal FoodWrapper()
        {
            PlayerSatiety = new Container<int>()
            {
                Name = nameof(PlayerSatiety),
                Owner = this,
                ReadValue = x => x.EffectHunger,
                WriteValue = (x, v) => x.EffectHunger = v,
                ValidateValue = x => x > 0
            };
        }
    }
}
