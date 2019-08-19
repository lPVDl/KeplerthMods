using DataBase;
using System;
using Common;

namespace ChassisMod.Wrapping
{
    internal sealed class FoodWrapper : ConfigWrapper<ConfigFood>
    {
        public ConfigContainer<ConfigFood, float> PlayerSatiety { get; }

        internal FoodWrapper()
        {
            PlayerSatiety = new ConfigContainer<ConfigFood, float>()
            {
                ReadValue = x => x.EffectHunger / (float)Constant.PlayerMaxSatiety,
                WriteValue = (x, v) => x.EffectHunger = (int)Math.Floor(v * Constant.PlayerMaxSatiety),
                ValidateValue = x => x >= 0 && x <= 1,

                FormatValue = (x, v) => v * 100 + "%",
                DisplayValue = (x, v) => x.EffectHunger > 0
            };

            try
            {
                FinishContainersInitialization();
            }
            catch (Exception e) { Log.ExceptionOnce(e); }
        }
    }
}
