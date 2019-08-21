using DataBase;
using System;

namespace ChassisMod.Wrapping
{
    internal sealed class FoodWrapper : Wrapper<ConfigFood>
    {
        public IPatchable<float> PlayerSatiety { get; }

        internal FoodWrapper(IEntity owner) : base(owner)
        {
            PlayerSatiety = new Patchable<float>()
            {
                Owner = this,
                Name = nameof(PlayerSatiety),

                Read = x => x.EffectHunger / (float)Constant.PlayerMaxSatiety,
                Write = (x, v) => x.EffectHunger = (int)Math.Floor(v * Constant.PlayerMaxSatiety),
                Validate = x => x >= 0 && x <= 1,

                Format = (x, v) => v * 100 + "%",
                IsDefault = (x, v) => x.EffectHunger == 0
            };
        }
    }
}
