using System;

namespace ChassisMod
{
    partial class Effect
    {
        public class Modifier
        {
            internal string Name { get; set; }
            internal float Value { get; set; }

            internal Modifier() { }
            internal Modifier Clone() => MemberwiseClone() as Modifier;

            public override string ToString() => $"{Value} {Name}";
        }

        public sealed class HealthGenerationMod : Modifier
        {
            public HealthGenerationMod(float healthPerSecond)
            {
                Name = "Hp";
                Value = healthPerSecond * 10000;
            }

            public override string ToString() => $"{(Value > 0 ? "+" : "")}{Value / 100} HP/s";
        }

        public abstract class Multiplier : Modifier
        {
            internal Multiplier(float multiplier)
            {
                if (multiplier < -1) throw new ArgumentException("multiplier must be greater than -1");

                Value = multiplier;
            }
        }

        public sealed class MovementSpeedMul : Multiplier
        {
            public MovementSpeedMul(float multiplier) : base(multiplier) => Name = "MoveSpeedMultiplierVaule";

            public override string ToString() => FormatMultiplier(Value) + " MovementSpeed";
        }

        public sealed class AttackSpeedMul : Multiplier
        {
            public AttackSpeedMul(float multiplier) : base(multiplier) => Name = "AttackSpeedMultiplierVaule";

            public override string ToString() =>  FormatMultiplier(Value) + " AttackSpeed";
        }

        public sealed class HungerSpeedMul : Multiplier
        {
            public HungerSpeedMul(float multiplier) : base(multiplier) => Name = "HungerDecMultiplierVaule";

            public override string ToString() => FormatMultiplier(Value) + " HungerSpeed";
        }

        public sealed class GatheringSpeedMul : Multiplier
        {
            public GatheringSpeedMul(float multiplier) : base(multiplier) => Name = "GatheringSpeed2";

            public override string ToString() => FormatMultiplier(Value) + " GatheringSpeed";
        }

        public sealed class EatingSpeedMul : Multiplier
        {
            public EatingSpeedMul(float multiplier) : base(multiplier) => Name = "EatingSpeed2";

            public override string ToString() => FormatMultiplier(Value) + " EatingSpeed";
        }

        public sealed class AttackMul : Multiplier
        {
            public AttackMul(float multiplier) : base(multiplier) => Name = "AttackMultiplierVaule";

            public override string ToString() => FormatMultiplier(Value) + " Attack";
        }

        public sealed class DefenceMul : Multiplier
        {
            public DefenceMul(float multiplier) : base(multiplier) => Name = "DefenceMultiplierVaule";

            public override string ToString() => FormatMultiplier(Value) + " Defence";
        }

        public sealed class EquipmentWearSpeedMul : Multiplier
        {
            public EquipmentWearSpeedMul(float multiplier) : base(multiplier) => Name = "EquipmentDecDurability";

            public override string ToString() => FormatMultiplier(Value) + " EquipmentWearSpeed";
        }

        public sealed class ArmorWearSpeedMul : Multiplier
        {
            public ArmorWearSpeedMul(float multiplier) : base(multiplier) => Name = "ArmourDecDurability";

            public override string ToString() => FormatMultiplier(Value) + " ArmorWearSpeed";
        }

        public sealed class ShoesWearSpeedMul : Multiplier
        {
            public ShoesWearSpeedMul(float multiplier) : base(multiplier) => Name = "ShoesDecDurability";

            public override string ToString() => FormatMultiplier(Value) + " ShoesWearSpeed";
        }

        public sealed class GlovesWearSpeedMul : Multiplier
        {
            public GlovesWearSpeedMul(float multiplier) : base(multiplier) => Name = "HandDecDurability";

            public override string ToString() => FormatMultiplier(Value) + " GlovesWearSpeed";
        }

        public sealed class AxeSwingSpeedMul : Multiplier
        {
            public AxeSwingSpeedMul(float multiplier) : base(multiplier) => Name = "AxeAttackSpeedMultiplierVaule";

            public override string ToString() => FormatMultiplier(Value) + " AxeSpeed";
        }

        public sealed class PickaxeSwingSpeedMul : Multiplier
        {
            public PickaxeSwingSpeedMul(float multiplier) : base(multiplier) => Name = "PickaxeAttackSpeedMultiplierVaule";

            public override string ToString() => FormatMultiplier(Value) + " PickaxeSpeed";
        }

        public sealed class WeaponWearSpeedMul : Multiplier
        {
            public WeaponWearSpeedMul(float multiplier) : base(multiplier) => Name = "WeaponDecDurability";

            public override string ToString() => FormatMultiplier(Value) + " WeaponWearSpeed";
        }

        public sealed class LootDropAmountMul : Multiplier
        {
            public LootDropAmountMul(float multiplier) : base(multiplier) => Name = "MoreDropFromMonster";

            public override string ToString() => FormatMultiplier(Value) + " LootDrop";
        }

        public sealed class OreDropAmountMul : Multiplier
        {
            public OreDropAmountMul(float multiplier) : base(multiplier) => Name = "MoreDropFromMine";

            public override string ToString() => FormatMultiplier(Value) + " OreDrop";
        }     

        public sealed class AttackMod : Modifier
        {
            public AttackMod(int modifier)
            {
                Name = "AttackAddValue";
                Value = modifier;
            }

            public override string ToString() => FormatModifier(Value) + " Attack";
        }

        public sealed class DefenceMod : Modifier
        {
            public DefenceMod(int modifier)
            {
                Name = "DefenceAddValue";
                Value = modifier;
            }

            public override string ToString() => FormatModifier(Value) + " Defence";
        }

        public sealed class BuildRangeMod : Modifier
        {
            public BuildRangeMod(float modifier)
            {
                Name = "PlacedDistance";
                Value = modifier;
            }

            public override string ToString() => FormatModifier(Value) + " BuildRange";
        }       

        public abstract class Rate : Modifier
        {
            internal Rate(float rate)
            {
                if (rate < 0 || rate > 1) throw new ArgumentException("rate must be in range [0, 1]");
                Value = rate;
            }
        }

        public sealed class IgnoreDefence : Rate
        {
            public IgnoreDefence(float rate) : base(rate) => Name = "IgnoreDefence";

            public override string ToString() => $"{Value * 100}% IgnoreDefence";
        }

        public sealed class DamageResistance: Rate
        {
            public DamageResistance(float rate) : base(rate) => Name = "ExDamageResistance";

            public override string ToString() => $"{Value * 100}% DamageResistance";
        }

        public sealed class ExplosiveDamageResistance : Rate
        {
            public ExplosiveDamageResistance(float rate) : base(rate) => Name = "ExploedProtect";

            public override string ToString() => $"{Value * 100}% ExplosiveDamageResistance";
        }

        public sealed class RangeDamageResistance : Rate
        {
            public RangeDamageResistance(float rate) : base(rate) => Name = "RemoteProtect";

            public override string ToString() => $"{Value * 100}% RangeDamageResistance";
        }

        public sealed class TrapDamageResistance : Rate
        {
            public TrapDamageResistance(float rate) : base(rate) => Name = "TrapProtect";

            public override string ToString() => $"{Value * 100}% TrapDamageResistance";
        }

        public sealed class KnockbackResistance : Rate
        {
            public KnockbackResistance(float rate) : base(rate) => Name = "ExResKnockBack";

            public override string ToString() => $"{Value * 100}% KnockbackResistance";
        }

        public sealed class PenetrationChance : Rate
        {
            public PenetrationChance(float rate) : base(rate) => Name = "ExPenetrate";

            public override string ToString() => $"{Value * 100}% PenetrationChance";
        }

        public sealed class AmmoSaveChance : Rate
        {
            public AmmoSaveChance(float rate) : base(rate) => Name = "SaveBulletRate";

            public override string ToString() => $"{Value * 100}% AmmoSaveChance";
        }

        public sealed class HungerChange : Modifier
        {
            public HungerChange(int delta)
            {
                Name = "Hunger";
                Value = delta;
            }

            public override string ToString() => $"Hunger {(Value >= 0 ? "+" : "-")}= {Math.Abs(Value)}";
        }

        public abstract class Special : Modifier
        {
            internal Special() => Value = 1;
        }

        public sealed class Stunned : Special
        {
            public Stunned() => Name = "Stun";

            public override string ToString() => "Stunned";
        }

        public sealed class Stuck : Special
        {
            public Stuck() => Name = "Freeze";

            public override string ToString() => "Stuck";
        }

        public sealed class LightOrb : Special
        {
            public LightOrb() => Name = "PlayerInfo.FlyLight";

            public override string ToString() => "LightOrb";
        }

        public sealed class Vampirism : Special
        {
            public Vampirism() => Name = "PlayerInfo.EatBody";

            public override string ToString() => "Vampirism";
        }

        public sealed class FlashLight : Special
        {
            public FlashLight() => Name = "PlayerInfo.FlashLight";

            public override string ToString() => "Flashlight";
        }

        public sealed class PoisonOrb : Special
        {
            public PoisonOrb() => Name = "PlayerInfo.PosionPet";

            public override string ToString() => "PoisonOrb";
        }

        public sealed class MetalDetector : Special
        {
            public MetalDetector() => Name = "PlayerInfo.MineLight";

            public override string ToString() => "MetalDetector";
        }

        public sealed class AmberShield : Special
        {
            public AmberShield() => Name = "AmberShield";

            public override string ToString() => "AmberShield";
        }

        public sealed class CollectorDrone : Special
        {
            public CollectorDrone() => Name = "PlayerInfo.CollectionDrone";

            public override string ToString() => "CollectorDrone";
        }

        public sealed class RangedKnockback : Modifier
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
