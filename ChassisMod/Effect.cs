using System.Collections.Generic;
using ChassisMod.Core;
using System.Linq;
using DataBase;

namespace ChassisMod
{
    public sealed partial class Effect : DataWrapper<ConfigBuff>
    {
        public sealed class ModifiersWrapper : CollectionWrapper<Modifier>
        {
            internal ModifiersWrapper(string name, Effect owner) : base(name, owner) { }

            protected override IEnumerable<Modifier> GetCollection(ConfigBuff config) => ReadModifiers(config);

            protected override void SetCollection(ConfigBuff config, IEnumerable<Modifier> collection) => WriteModifiers(config, collection);
        }

        public ModifiersWrapper Modifiers { get; }

        internal static Modifier[] KnownModifiers { get; } = 
        {
            new HealthGenerationMod(0),
            new MovementSpeedMul(1),
            new AttackSpeedMul(1),
            new HungerSpeedMul(1),
            new DefenceMul(1),
            new AttackMul(1),
            new AttackMod(0),
            new DefenceMod(0),
            new HungerChange(0),
            new Stunned(),
            new Stuck(),
            new GatheringSpeedMul(1),
            new EatingSpeedMul(1),
            new LightOrb(),
            new EquipmentWearSpeedMul(1),
            new WeaponWearSpeedMul(1),
            new ArmorWearSpeedMul(1),
            new BuildRangeMod(0),
            new FlashLight(),
            new Vampirism(),
            new MetalDetector(),
            new PoisonOrb(),
            new AmberShield(),
            new CollectorDrone(),
            new LootDropAmountMul(1),
            new OreDropAmountMul(1),
            new IgnoreDefence(0),
            new PenetrationChance(0),
            new AmmoSaveChance(0),
            new DamageResistance(0),
            new KnockbackResistance(0),
            new ExplosiveDamageResistance(0),
            new RangeDamageResistance(0),
            new AxeSwingSpeedMul(1),
            new PickaxeSwingSpeedMul(1),
            new ShoesWearSpeedMul(1),
            new GlovesWearSpeedMul(1),
            new TrapDamageResistance(0),
            new RangedKnockback(0),
        };

        internal Effect(string name, int id) : base(name, id)
        {
            Modifiers = new ModifiersWrapper("Modifiers", this);
        }

        internal static IEnumerable<Modifier> ReadModifiers(ConfigBuff config)
        {
            var result = new List<Modifier>();
            
            if (config.EffectId0 != 0) { result.Add(CreateModifier(config.Target0, config.EffectValue0)); }
            if (config.EffectId1 != 0) { result.Add(CreateModifier(config.Target1, config.EffectValue1)); }
            if (config.EffectId2 != 0) { result.Add(CreateModifier(config.Target2, config.EffectValue2)); }

            return result;
        }

        internal static void WriteModifiers(ConfigBuff config, IEnumerable<Modifier> modifiers)
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

        private static Modifier CreateModifier(string propertyName, float propertyValue)
        {
            var result = KnownModifiers.FirstOrDefault(x => x.Name == propertyName);
            if (result == null) return new Modifier() { Name = propertyName, Value = propertyValue };

            result = result.Clone();
            result.Value = propertyValue;
            return result;
        }
    }
}
