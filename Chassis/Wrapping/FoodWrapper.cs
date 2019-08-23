using Chassis.Entities;
using DataBase;
using System;

namespace Chassis.Wrapping
{
    internal sealed class FoodWrapper : Wrapper<ConfigFood>
    {
        public ILocalization EffectInfo { get; }

        public IPatchable<float> PlayerSatiety { get; }

        internal FoodWrapper(IEntity owner) : base(owner)
        {
            EffectInfo = new Localization()
            {
                Owner = owner,
                Name = "EffectInfo",
                Prefix = "EatBuffDescription",
            };

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

        internal void Initialize(FoodWrapper source, IInvokationAddress patcher, bool log) => Initialize(source, SetTranslationKeys, patcher, log);

        private void SetTranslationKeys(ConfigFood config)
        {
            config.EatBuffDescription = "EatBuffDescription" + Owner.ID;
        }
    }
}
