using System.Collections.Generic;
using ChassisMod.Core;
using System.Linq;
using DataBase;

namespace ChassisMod
{
    public sealed partial class StatusEffect : DataWrapper<ConfigBuff>
    {
        internal StatusEffect(string name, int id) : base(name, id) { }

        internal static PropertyModifier[] KnownModifiers { get; } = 
        {
            new HealthGenerationModifier(0),
            new MovementSpeedMultiplier(1),
            new AttackSpeedMultiplier(1),
            new HungerSpeedMultiplier(1),
            new DefenceMultiplier(1),
            new AttackMultiplier(1),
            new AttackModifier(0),
            new DefenceModifier(0),
            new HungerChange(0),
            new Stunned(),
            new Stuck(),
            new GatheringSpeedMultiplier(1),
            new EatingSpeedMultiplier(1),
            new LightOrb(),
            new EquipmentWearSpeedMultiplier(1),
            new WeaponWearSpeedMultiplier(1),
            new ArmorWearSpeedMultiplier(1),
            new BuildRangeModifier(0),
            new FlashLight(),
            new Vampirism(),
            new MetalDetector(),
            new PoisonOrb(),
            new AmberShield(),
            new CollectorDrone(),
            new LootDropMultiplier(1),
            new OreDropMultiplier(1),
            new IgnoreDefence(0),
            new PenetrationChance(0),
            new AmmoSaveChance(0),
            new DamageResistance(0),
            new KnockbackResistance(0),
            new ExplosiveDamageResistance(0),
            new RangeDamageResistance(0),
            new AxeSpeedMultiplier(1),
            new PickaxeSpeedMultiplier(1),
            new ShoesWearSpeedMultiplier(1),
            new GlovesWearSpeedMultiplier(1),
            new TrapDamageResistance(0),
            new RangedKnockback(0),
        };

        internal static IEnumerable<PropertyModifier> ReadModifiers(ConfigBuff config)
        {
            var result = new List<PropertyModifier>();
            
            if (config.EffectId0 != 0) { result.Add(CreateModifier(config.Target0, config.EffectValue0)); }
            if (config.EffectId1 != 0) { result.Add(CreateModifier(config.Target1, config.EffectValue1)); }
            if (config.EffectId2 != 0) { result.Add(CreateModifier(config.Target2, config.EffectValue2)); }

            return result;
        }

        private static PropertyModifier CreateModifier(string propertyName, float propertyValue)
        {
            var result = KnownModifiers.FirstOrDefault(x => x.Name == propertyName);
            if (result == null) return new PropertyModifier() { Name = propertyName, Value = propertyValue };

            result = result.Clone();
            result.Value = propertyValue;
            return result;
        }
    }
}
