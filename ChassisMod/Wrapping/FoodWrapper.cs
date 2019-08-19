using DataBase;
using System;

namespace ChassisMod.Wrapping
{
    internal sealed class FoodWrapper : ConfigWrapper<ConfigFood>
    {
        public ConfigContainer<float> PlayerSatiety { get; }

        internal FoodWrapper()
        {
            PlayerSatiety = new ConfigContainer<float>()
            {
                Owner = this,
                Name = nameof(PlayerSatiety),           

                ReadValue = x => x.EffectHunger / (float)Constant.PlayerMaxSatiety,
                WriteValue = (x, v) => x.EffectHunger = (int)Math.Floor(v * Constant.PlayerMaxSatiety),
                ValidateValue = x => x >= 0 && x <= 1,

                FormatValue = (x, v) => v * 100 + "%",
                DisplayValue = (x, v) => x.EffectHunger > 0
            };
        }
    }
}
