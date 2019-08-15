using System.Collections.Generic;
using ChassisMod.Core;
using System.Linq;
using DataBase;

namespace ChassisMod
{
    public sealed partial class StatusEffect : DataWrapper<ConfigBuff>
    {
        public sealed class ModifiersWrapper : CollectionWrapper<PropertyModifier>
        {
            internal ModifiersWrapper(string name, StatusEffect owner) : base(name, owner) { }

            protected override IEnumerable<PropertyModifier> GetCollection(ConfigBuff config) => ReadModifiers(config);

            protected override void SetCollection(ConfigBuff config, IEnumerable<PropertyModifier> collection) => WriteModifiers(config, collection);
        }

        public ModifiersWrapper Modifiers { get; }

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

        internal StatusEffect(string name, int id) : base(name, id)
        {
            Modifiers = new ModifiersWrapper("Modifiers", this);
        }

        internal static IEnumerable<PropertyModifier> ReadModifiers(ConfigBuff config)
        {
            var result = new List<PropertyModifier>();
            
            if (config.EffectId0 != 0) { result.Add(CreateModifier(config.Target0, config.EffectValue0)); }
            if (config.EffectId1 != 0) { result.Add(CreateModifier(config.Target1, config.EffectValue1)); }
            if (config.EffectId2 != 0) { result.Add(CreateModifier(config.Target2, config.EffectValue2)); }

            return result;
        }

        internal static void WriteModifiers(ConfigBuff config, IEnumerable<PropertyModifier> modifiers)
        {
            var mods = modifiers.ToList();

            if (mods.Count > 3) throw new System.ArgumentException("Can not set more than 3 modifiers.");
            
            if (mods.Count > 0) { config.EffectId0 = 1; config.Target0 = mods[0].Name; config.EffectValue0 = mods[0].Value; }
            else { config.EffectId0 = 0; config.Target0 = ""; config.EffectValue0 = 0; }

            if (mods.Count > 1) { config.EffectId1 = 1; config.Target1 = mods[1].Name; config.EffectValue1 = mods[1].Value; }
            else { config.EffectId1 = 0; config.Target1 = ""; config.EffectValue1 = 0; }

            if (mods.Count > 2) { config.EffectId2 = 1; config.Target2 = mods[2].Name; config.EffectValue2 = mods[2].Value; }
            else { config.EffectId2 = 0; config.Target2 = ""; config.EffectValue2 = 0; }
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
