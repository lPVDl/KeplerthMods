using DataBase;
using System;

namespace ChassisMod.Wrapping
{
    internal sealed class FoodWrapper : Wrapper<ConfigFood>
    {
        public Container<float> PlayerSatiety { get; }

        internal FoodWrapper()
        {
            PlayerSatiety = new Container<float>()
            {
                Name = nameof(PlayerSatiety),
                Owner = this,
                ReadValue = x => x.EffectHunger / (float)Constant.PlayerMaxSatiety,
                WriteValue = (x, v) => x.EffectHunger = (int)Math.Floor(v * Constant.PlayerMaxSatiety),
                ValidateValue = x => x >= 0 && x <= 1,
                ValueToString = x => x * 100 + "%"
            };
        }
    }
}
