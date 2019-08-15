using System;

namespace ChassisMod
{
    partial class StatusEffect
    {
        public class PropertyModifier
        {
            internal string Name { get; set; }
            internal float Value { get; set; }

            internal PropertyModifier() { }
            internal PropertyModifier Clone() => MemberwiseClone() as PropertyModifier;

            public override string ToString() => $"{Value} {Name}";
        }

        public sealed class HealthGenerationModifier : PropertyModifier
        {
            public HealthGenerationModifier(float healthPerSecond)
            {
                Name = "Hp";
                Value = healthPerSecond * 10000;
            }

            public override string ToString() => $"{(Value > 0 ? "+" : "")}{Value / 100} HP/s";
        }

        public abstract class PropertyMultiplier : PropertyModifier
        {
            internal PropertyMultiplier(float multiplier)
            {
                if (multiplier < 0) throw new ArgumentException("multiplier must be greater than zero");
                Value = multiplier - 1;
            }
        }

        public sealed class MovementSpeedMultiplier : PropertyMultiplier
        {
            public MovementSpeedMultiplier(float multiplier) : base(multiplier) => Name = "MoveSpeedMultiplierVaule";

            public override string ToString() => FormatMultiplier(Value) + " MovementSpeed";
        }

        public sealed class AttackSpeedMultiplier : PropertyMultiplier
        {
            public AttackSpeedMultiplier(float multiplier) : base(multiplier) => Name = "AttackSpeedMultiplierVaule";

            public override string ToString() =>  FormatMultiplier(Value) + " AttackSpeed";
        }

        public sealed class HungerSpeedMultiplier : PropertyMultiplier
        {
            public HungerSpeedMultiplier(float multiplier) : base(multiplier) => Name = "HungerDecMultiplierVaule";

            public override string ToString() => FormatMultiplier(Value) + " HungerSpeed";
        }

        public sealed class GatheringSpeedMultiplier : PropertyMultiplier
        {
            public GatheringSpeedMultiplier(float multiplier) : base(multiplier) => Name = "GatheringSpeed2";

            public override string ToString() => FormatMultiplier(Value) + " GatheringSpeed";
        }

        public sealed class EatingSpeedMultiplier : PropertyMultiplier
        {
            public EatingSpeedMultiplier(float multiplier) : base(multiplier) => Name = "EatingSpeed2";

            public override string ToString() => FormatMultiplier(Value) + " EatingSpeed";
        }

        public sealed class AttackMultiplier : PropertyMultiplier
        {
            public AttackMultiplier(float multiplier) : base(multiplier) => Name = "AttackMultiplierVaule";

            public override string ToString() => FormatMultiplier(Value) + " Attack";
        }

        public sealed class DefenceMultiplier : PropertyMultiplier
        {
            public DefenceMultiplier(float multiplier) : base(multiplier) => Name = "DefenceMultiplierVaule";

            public override string ToString() => FormatMultiplier(Value) + " Defence";
        }

        public sealed class EquipmentWearSpeedMultiplier : PropertyMultiplier
        {
            public EquipmentWearSpeedMultiplier(float multiplier) : base(multiplier) => Name = "EquipmentDecDurability";

            public override string ToString() => FormatMultiplier(Value) + " EquipmentWearSpeed";
        }

        public sealed class ArmorWearSpeedMultiplier : PropertyMultiplier
        {
            public ArmorWearSpeedMultiplier(float multiplier) : base(multiplier) => Name = "ArmourDecDurability";

            public override string ToString() => FormatMultiplier(Value) + " ArmorWearSpeed";
        }

        public sealed class ShoesWearSpeedMultiplier : PropertyMultiplier
        {
            public ShoesWearSpeedMultiplier(float multiplier) : base(multiplier) => Name = "ShoesDecDurability";

            public override string ToString() => FormatMultiplier(Value) + " ShoesWearSpeed";
        }

        public sealed class GlovesWearSpeedMultiplier : PropertyMultiplier
        {
            public GlovesWearSpeedMultiplier(float multiplier) : base(multiplier) => Name = "HandDecDurability";

            public override string ToString() => FormatMultiplier(Value) + " GlovesWearSpeed";
        }

        public sealed class AxeSpeedMultiplier : PropertyMultiplier
        {
            public AxeSpeedMultiplier(float multiplier) : base(multiplier) => Name = "AxeAttackSpeedMultiplierVaule";

            public override string ToString() => FormatMultiplier(Value) + " AxeSpeed";
        }

        public sealed class PickaxeSpeedMultiplier : PropertyMultiplier
        {
            public PickaxeSpeedMultiplier(float multiplier) : base(multiplier) => Name = "PickaxeAttackSpeedMultiplierVaule";

            public override string ToString() => FormatMultiplier(Value) + " PickaxeSpeed";
        }

        public sealed class WeaponWearSpeedMultiplier : PropertyMultiplier
        {
            public WeaponWearSpeedMultiplier(float multiplier) : base(multiplier) => Name = "WeaponDecDurability";

            public override string ToString() => FormatMultiplier(Value) + " WeaponWearSpeed";
        }

        public sealed class LootDropMultiplier : PropertyMultiplier
        {
            public LootDropMultiplier(float multiplier) : base(multiplier) => Name = "MoreDropFromMonster";

            public override string ToString() => FormatMultiplier(Value) + " LootDrop";
        }

        public sealed class OreDropMultiplier : PropertyMultiplier
        {
            public OreDropMultiplier(float multiplier) : base(multiplier) => Name = "MoreDropFromMine";

            public override string ToString() => FormatMultiplier(Value) + " OreDrop";
        }     

        public sealed class AttackModifier : PropertyModifier
        {
            public AttackModifier(int modifier)
            {
                Name = "AttackAddValue";
                Value = modifier;
            }

            public override string ToString() => FormatModifier(Value) + " Attack";
        }

        public sealed class DefenceModifier : PropertyModifier
        {
            public DefenceModifier(int modifier)
            {
                Name = "DefenceAddValue";
                Value = modifier;
            }

            public override string ToString() => FormatModifier(Value) + " Defence";
        }

        public sealed class BuildRangeModifier : PropertyModifier
        {
            public BuildRangeModifier(float modifier)
            {
                Name = "PlacedDistance";
                Value = modifier;
            }

            public override string ToString() => FormatModifier(Value) + " BuildRange";
        }       

        public abstract class RateModifier : PropertyModifier
        {
            internal RateModifier(float rate)
            {
                if (rate < 0 || rate > 1) throw new ArgumentException("rate must be in range [0, 1]");
                Value = rate;
            }
        }

        public sealed class IgnoreDefence : RateModifier
        {
            public IgnoreDefence(float rate) : base(rate) => Name = "IgnoreDefence";

            public override string ToString() => $"{Value * 100}% IgnoreDefence";
        }

        public sealed class DamageResistance: RateModifier
        {
            public DamageResistance(float rate) : base(rate) => Name = "ExDamageResistance";

            public override string ToString() => $"{Value * 100}% DamageResistance";
        }

        public sealed class ExplosiveDamageResistance : RateModifier
        {
            public ExplosiveDamageResistance(float rate) : base(rate) => Name = "ExploedProtect";

            public override string ToString() => $"{Value * 100}% ExplosiveDamageResistance";
        }

        public sealed class RangeDamageResistance : RateModifier
        {
            public RangeDamageResistance(float rate) : base(rate) => Name = "RemoteProtect";

            public override string ToString() => $"{Value * 100}% RangeDamageResistance";
        }

        public sealed class TrapDamageResistance : RateModifier
        {
            public TrapDamageResistance(float rate) : base(rate) => Name = "TrapProtect";

            public override string ToString() => $"{Value * 100}% TrapDamageResistance";
        }

        public sealed class KnockbackResistance : RateModifier
        {
            public KnockbackResistance(float rate) : base(rate) => Name = "ExResKnockBack";

            public override string ToString() => $"{Value * 100}% KnockbackResistance";
        }

        public sealed class PenetrationChance : RateModifier
        {
            public PenetrationChance(float rate) : base(rate) => Name = "ExPenetrate";

            public override string ToString() => $"{Value * 100}% PenetrationChance";
        }

        public sealed class AmmoSaveChance : RateModifier
        {
            public AmmoSaveChance(float rate) : base(rate) => Name = "SaveBulletRate";

            public override string ToString() => $"{Value * 100}% AmmoSaveChance";
        }

        public sealed class HungerChange : PropertyModifier
        {
            public HungerChange(int delta)
            {
                Name = "Hunger";
                Value = delta;
            }

            public override string ToString() => $"Hunger {(Value >= 0 ? "+" : "-")}= {Math.Abs(Value)}";
        }

        public sealed class Stunned : PropertyModifier
        {
            public Stunned()
            {
                Name = "Stun";
                Value = 1;
            }

            public override string ToString() => "Stunned";
        }

        public sealed class Stuck : PropertyModifier
        {
            public Stuck()
            {
                Name = "Freeze";
                Value = 1;
            }

            public override string ToString() => "Stuck";
        }

        public sealed class LightOrb : PropertyModifier
        {
            public LightOrb()
            {
                Name = "PlayerInfo.FlyLight";
                Value = 1;
            }

            public override string ToString() => "LightOrb";
        }

        public sealed class Vampirism : PropertyModifier
        {
            public Vampirism()
            {
                Name = "PlayerInfo.EatBody";
                Value = 1;
            }

            public override string ToString() => "Vampirism";
        }

        public sealed class FlashLight : PropertyModifier
        {
            public FlashLight()
            {
                Name = "PlayerInfo.FlashLight";
                Value = 1;
            }

            public override string ToString() => "Flashlight";
        }

        public sealed class PoisonOrb : PropertyModifier
        {
            public PoisonOrb()
            {
                Name = "PlayerInfo.PosionPet";
                Value = 1;
            }

            public override string ToString() => "PoisonOrb";
        }

        public sealed class MetalDetector : PropertyModifier
        {
            public MetalDetector()
            {
                Name = "PlayerInfo.MineLight";
                Value = 1;
            }

            public override string ToString() => "MetalDetector";
        }

        public sealed class AmberShield : PropertyModifier
        {
            public AmberShield()
            {
                Name = "AmberShield";
                Value = 1;
            }

            public override string ToString() => "AmberShield";
        }

        public sealed class CollectorDrone : PropertyModifier
        {
            public CollectorDrone()
            {
                Name = "PlayerInfo.CollectionDrone";
                Value = 1;
            }

            public override string ToString() => "CollectorDrone";
        }

        public sealed class RangedKnockback : PropertyModifier
        {
            public RangedKnockback(int amount)
            {
                if (amount < 0) throw new ArgumentException("amount must be more than zero");

                Name = "ExKnockBackValue";
                Value = amount;
            }

            public override string ToString() => $"+{Value} RangedKnockback";
        }

        private static string FormatMultiplier(float multiplier) => $"{(multiplier > 0 ? "+" : "")}{multiplier * 100}%";

        private static string FormatModifier(float modifier) => (modifier > 0 ? "+" : "") + modifier;
    }
}
