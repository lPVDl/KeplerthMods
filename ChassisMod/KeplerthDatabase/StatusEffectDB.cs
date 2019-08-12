namespace ChassisMod.KeplerthDatabase
{
	public static class StatusEffectDB
	{
		/// <summary>
		/// Restore 1 HP for every second.<para/>
		/// EffectType: 1<para/>
		/// Type: 1<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 100<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 11<para/>
		/// BackGround: "GameUI/UI-Buff-02"<para/>
		/// TimeProgress: "GameUI/UI-Buff-06"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Recovery { get; } = new StatusEffect("Recovery", 1);
		/// <summary>
		/// Feeling cold…<para/>
		/// EffectType: 0<para/>
		/// Type: 2<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: -100<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 30<para/>
		/// BackGround: "GameUI/UI-Buff-04"<para/>
		/// TimeProgress: "GameUI/UI-Buff-08"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Cold { get; } = new StatusEffect("Cold", 2);
		/// <summary>
		/// Feeling hot…<para/>
		/// EffectType: 0<para/>
		/// Type: 3<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 30<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Fever { get; } = new StatusEffect("Fever", 3);
		/// <summary>
		/// Walking speed decrease by 25%.<para/>
		/// EffectType: 0<para/>
		/// Type: 4<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: -0.25<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 60<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/2"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Nausea { get; } = new StatusEffect("Nausea", 4);
		/// <summary>
		/// Attack speed increase by 30%, but hunger speed increase by 50%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.3<para/>
		/// EffectId1: 1<para/>
		/// Target1: "HungerDecMultiplierVaule"<para/>
		/// EffectValue1: 0.5<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 60<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/3"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Excited { get; } = new StatusEffect("Excited", 5);
		/// <summary>
		/// Hunger speed increase by 50%.<para/>
		/// EffectType: 0<para/>
		/// Type: 6<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "HungerDecMultiplierVaule"<para/>
		/// EffectValue0: 0.5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 60<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/4"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Fatigue { get; } = new StatusEffect("Fatigue", 6);
		/// <summary>
		/// Stun…<para/>
		/// EffectType: 5<para/>
		/// Type: 7<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "Stun"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 3<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/5"<para/>
		/// BuffParticle: "StunEffect"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Stun0 { get; } = new StatusEffect("Stun0", 7);
		/// <summary>
		/// Night vision is improved.<para/>
		/// EffectType: 0<para/>
		/// Type: 8<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 30<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect NightVision { get; } = new StatusEffect("NightVision", 8);
		/// <summary>
		/// Shush…<para/>
		/// EffectType: 0<para/>
		/// Type: 9<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 30<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Stealth { get; } = new StatusEffect("Stealth", 9);
		/// <summary>
		/// vu！hweb#$UJ*Bd45<para/>
		/// EffectType: 0<para/>
		/// Type: 10<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 30<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Hallucinations { get; } = new StatusEffect("Hallucinations", 10);
		/// <summary>
		/// Attack increase by 2 points.<para/>
		/// EffectType: 1<para/>
		/// Type: 11<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackAddValue"<para/>
		/// EffectValue0: 2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/6"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect StrengthI { get; } = new StatusEffect("StrengthI", 11);
		/// <summary>
		/// Attack increase by 3 points.<para/>
		/// EffectType: 1<para/>
		/// Type: 11<para/>
		/// Level: 2<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackAddValue"<para/>
		/// EffectValue0: 3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/6"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect StrengthII { get; } = new StatusEffect("StrengthII", 12);
		/// <summary>
		/// Attack increase by 4 points.<para/>
		/// EffectType: 1<para/>
		/// Type: 11<para/>
		/// Level: 3<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackAddValue"<para/>
		/// EffectValue0: 4<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/6"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect StrengthIII { get; } = new StatusEffect("StrengthIII", 13);
		/// <summary>
		/// Attack increase by 6 points.<para/>
		/// EffectType: 1<para/>
		/// Type: 11<para/>
		/// Level: 4<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackAddValue"<para/>
		/// EffectValue0: 6<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/6"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect StrengthIV { get; } = new StatusEffect("StrengthIV", 14);
		/// <summary>
		/// Attack increase by 9 points.<para/>
		/// EffectType: 1<para/>
		/// Type: 11<para/>
		/// Level: 5<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackAddValue"<para/>
		/// EffectValue0: 9<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/6"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect StrengthV { get; } = new StatusEffect("StrengthV", 15);
		/// <summary>
		/// Attack increase by 10%.<para/>
		/// EffectType: 1<para/>
		/// Type: 12<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackMultiplierVaule"<para/>
		/// EffectValue0: 0.1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/7"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect AttackI { get; } = new StatusEffect("AttackI", 16);
		/// <summary>
		/// Attack increase by 20%.<para/>
		/// EffectType: 1<para/>
		/// Type: 12<para/>
		/// Level: 2<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackMultiplierVaule"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/7"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect AttackII { get; } = new StatusEffect("AttackII", 17);
		/// <summary>
		/// Attack increase by 30%.<para/>
		/// EffectType: 1<para/>
		/// Type: 12<para/>
		/// Level: 3<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackMultiplierVaule"<para/>
		/// EffectValue0: 0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/7"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect AttackIII { get; } = new StatusEffect("AttackIII", 18);
		/// <summary>
		/// Attack increase by 40%.<para/>
		/// EffectType: 1<para/>
		/// Type: 12<para/>
		/// Level: 4<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackMultiplierVaule"<para/>
		/// EffectValue0: 0.4<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/7"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect AttackIV { get; } = new StatusEffect("AttackIV", 19);
		/// <summary>
		/// Attack increase by 50%.<para/>
		/// EffectType: 1<para/>
		/// Type: 12<para/>
		/// Level: 5<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackMultiplierVaule"<para/>
		/// EffectValue0: 0.5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/7"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect AttackV { get; } = new StatusEffect("AttackV", 20);
		/// <summary>
		/// Defense increase by 3 points.<para/>
		/// EffectType: 1<para/>
		/// Type: 13<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: 3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/8"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect EnduranceI { get; } = new StatusEffect("EnduranceI", 21);
		/// <summary>
		/// Defense increase by 5 points.<para/>
		/// EffectType: 1<para/>
		/// Type: 13<para/>
		/// Level: 2<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: 5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/8"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect EnduranceII { get; } = new StatusEffect("EnduranceII", 22);
		/// <summary>
		/// Defense increase by 8 points.<para/>
		/// EffectType: 1<para/>
		/// Type: 13<para/>
		/// Level: 3<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: 8<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/8"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect EnduranceIII { get; } = new StatusEffect("EnduranceIII", 23);
		/// <summary>
		/// Defense increase by 12 points.<para/>
		/// EffectType: 1<para/>
		/// Type: 13<para/>
		/// Level: 4<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: 12<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/8"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect EnduranceIV { get; } = new StatusEffect("EnduranceIV", 24);
		/// <summary>
		/// Defense increase by 19 points.<para/>
		/// EffectType: 1<para/>
		/// Type: 13<para/>
		/// Level: 5<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: 19<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/8"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect EnduranceV { get; } = new StatusEffect("EnduranceV", 25);
		/// <summary>
		/// Defense increase by 10%.<para/>
		/// EffectType: 1<para/>
		/// Type: 14<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceMultiplierVaule"<para/>
		/// EffectValue0: 0.1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/9"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect DefenseI { get; } = new StatusEffect("DefenseI", 26);
		/// <summary>
		/// Defense increase by 20%.<para/>
		/// EffectType: 1<para/>
		/// Type: 14<para/>
		/// Level: 2<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceMultiplierVaule"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/9"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect DefenseII { get; } = new StatusEffect("DefenseII", 27);
		/// <summary>
		/// Defense increase by 30%.<para/>
		/// EffectType: 1<para/>
		/// Type: 14<para/>
		/// Level: 3<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceMultiplierVaule"<para/>
		/// EffectValue0: 0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/9"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect DefenseIII { get; } = new StatusEffect("DefenseIII", 28);
		/// <summary>
		/// Defense increase by 40%.<para/>
		/// EffectType: 1<para/>
		/// Type: 14<para/>
		/// Level: 4<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceMultiplierVaule"<para/>
		/// EffectValue0: 0.4<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/9"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect DefenseIV { get; } = new StatusEffect("DefenseIV", 29);
		/// <summary>
		/// Defense increase by 50%.<para/>
		/// EffectType: 1<para/>
		/// Type: 14<para/>
		/// Level: 5<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceMultiplierVaule"<para/>
		/// EffectValue0: 0.5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/9"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect DefenseV { get; } = new StatusEffect("DefenseV", 30);
		/// <summary>
		/// Attack decrease by 1 points.<para/>
		/// EffectType: 1<para/>
		/// Type: 15<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackAddValue"<para/>
		/// EffectValue0: -1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/10"<para/>
		/// BuffParticle: "DebuffAtkDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect WeakI0 { get; } = new StatusEffect("WeakI0", 31);
		/// <summary>
		/// Attack decrease by 3 points.<para/>
		/// EffectType: 1<para/>
		/// Type: 15<para/>
		/// Level: 2<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackAddValue"<para/>
		/// EffectValue0: -3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/10"<para/>
		/// BuffParticle: "DebuffAtkDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect WeakII { get; } = new StatusEffect("WeakII", 32);
		/// <summary>
		/// Attack decrease by 5 points.<para/>
		/// EffectType: 1<para/>
		/// Type: 15<para/>
		/// Level: 3<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackAddValue"<para/>
		/// EffectValue0: -5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/10"<para/>
		/// BuffParticle: "DebuffAtkDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect WeakIII { get; } = new StatusEffect("WeakIII", 33);
		/// <summary>
		/// Attack decrease by 7 points.<para/>
		/// EffectType: 1<para/>
		/// Type: 15<para/>
		/// Level: 4<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackAddValue"<para/>
		/// EffectValue0: -7<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/10"<para/>
		/// BuffParticle: "DebuffAtkDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect WeakIV { get; } = new StatusEffect("WeakIV", 34);
		/// <summary>
		/// Attack decrease by 9 points.<para/>
		/// EffectType: 1<para/>
		/// Type: 15<para/>
		/// Level: 5<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackAddValue"<para/>
		/// EffectValue0: -9<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/10"<para/>
		/// BuffParticle: "DebuffAtkDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect WeakI1 { get; } = new StatusEffect("WeakI1", 35);
		/// <summary>
		/// Attack decrease by 10%.<para/>
		/// EffectType: 2<para/>
		/// Type: 16<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackMultiplierVaule"<para/>
		/// EffectValue0: -0.1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/11"<para/>
		/// BuffParticle: "DebuffAtkDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect ATKWeakenedI { get; } = new StatusEffect("ATKWeakenedI", 36);
		/// <summary>
		/// Attack decrease by 20%.<para/>
		/// EffectType: 2<para/>
		/// Type: 16<para/>
		/// Level: 2<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackMultiplierVaule"<para/>
		/// EffectValue0: -0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/11"<para/>
		/// BuffParticle: "DebuffAtkDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect ATKWeakenedII { get; } = new StatusEffect("ATKWeakenedII", 37);
		/// <summary>
		/// Attack decrease by 30%.<para/>
		/// EffectType: 2<para/>
		/// Type: 16<para/>
		/// Level: 3<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackMultiplierVaule"<para/>
		/// EffectValue0: -0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/11"<para/>
		/// BuffParticle: "DebuffAtkDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect ATKWeakenedIII { get; } = new StatusEffect("ATKWeakenedIII", 38);
		/// <summary>
		/// Attack decrease by 40%.<para/>
		/// EffectType: 2<para/>
		/// Type: 16<para/>
		/// Level: 4<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackMultiplierVaule"<para/>
		/// EffectValue0: -0.4<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/11"<para/>
		/// BuffParticle: "DebuffAtkDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect ATKWeakenedIV { get; } = new StatusEffect("ATKWeakenedIV", 39);
		/// <summary>
		/// Attack decrease by 50%.<para/>
		/// EffectType: 2<para/>
		/// Type: 16<para/>
		/// Level: 5<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackMultiplierVaule"<para/>
		/// EffectValue0: -0.5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/11"<para/>
		/// BuffParticle: "DebuffAtkDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect ATKWeakenedV { get; } = new StatusEffect("ATKWeakenedV", 40);
		/// <summary>
		/// Defense decrease by 3 points.<para/>
		/// EffectType: 2<para/>
		/// Type: 17<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: -3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/12"<para/>
		/// BuffParticle: "DebuffDefDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect CorrosionI { get; } = new StatusEffect("CorrosionI", 41);
		/// <summary>
		/// Defense decrease by 6 points.<para/>
		/// EffectType: 2<para/>
		/// Type: 17<para/>
		/// Level: 2<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: -6<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/12"<para/>
		/// BuffParticle: "DebuffDefDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect CorrosionII { get; } = new StatusEffect("CorrosionII", 42);
		/// <summary>
		/// Defense decrease by 9 points.<para/>
		/// EffectType: 2<para/>
		/// Type: 17<para/>
		/// Level: 3<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: -9<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/12"<para/>
		/// BuffParticle: "DebuffDefDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect CorrosionIII { get; } = new StatusEffect("CorrosionIII", 43);
		/// <summary>
		/// Defense decrease by 12 points.<para/>
		/// EffectType: 2<para/>
		/// Type: 17<para/>
		/// Level: 4<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: -12<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/12"<para/>
		/// BuffParticle: "DebuffDefDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect CorrosionIV { get; } = new StatusEffect("CorrosionIV", 44);
		/// <summary>
		/// Defense decrease by 15 points.<para/>
		/// EffectType: 2<para/>
		/// Type: 17<para/>
		/// Level: 5<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: -15<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/12"<para/>
		/// BuffParticle: "DebuffDefDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect CorrosionV { get; } = new StatusEffect("CorrosionV", 45);
		/// <summary>
		/// Defense decrease by 10%.<para/>
		/// EffectType: 2<para/>
		/// Type: 18<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceMultiplierVaule"<para/>
		/// EffectValue0: -0.1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/13"<para/>
		/// BuffParticle: "DebuffDefDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect DEFWeakenedI { get; } = new StatusEffect("DEFWeakenedI", 46);
		/// <summary>
		/// Defense decrease by 20%.<para/>
		/// EffectType: 2<para/>
		/// Type: 18<para/>
		/// Level: 2<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceMultiplierVaule"<para/>
		/// EffectValue0: -0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/13"<para/>
		/// BuffParticle: "DebuffDefDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect DEFWeakenedII { get; } = new StatusEffect("DEFWeakenedII", 47);
		/// <summary>
		/// Defense decrease by 30%.<para/>
		/// EffectType: 2<para/>
		/// Type: 18<para/>
		/// Level: 3<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceMultiplierVaule"<para/>
		/// EffectValue0: -0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/13"<para/>
		/// BuffParticle: "DebuffDefDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect DEFWeakenedIII { get; } = new StatusEffect("DEFWeakenedIII", 48);
		/// <summary>
		/// Defense decrease by 40%.<para/>
		/// EffectType: 2<para/>
		/// Type: 18<para/>
		/// Level: 4<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceMultiplierVaule"<para/>
		/// EffectValue0: -0.4<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/13"<para/>
		/// BuffParticle: "DebuffDefDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect DEFWeakenedIV { get; } = new StatusEffect("DEFWeakenedIV", 49);
		/// <summary>
		/// Defense decrease by 50%.<para/>
		/// EffectType: 2<para/>
		/// Type: 18<para/>
		/// Level: 5<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceMultiplierVaule"<para/>
		/// EffectValue0: -0.5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/13"<para/>
		/// BuffParticle: "DebuffDefDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect DEFWeakenedV { get; } = new StatusEffect("DEFWeakenedV", 50);
		/// <summary>
		/// Restore 1 HP for every second.<para/>
		/// EffectType: 1<para/>
		/// Type: 19<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 100<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 180<para/>
		/// BackGround: "GameUI/UI-Buff-02"<para/>
		/// TimeProgress: "GameUI/UI-Buff-06"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect HealingI { get; } = new StatusEffect("HealingI", 51);
		/// <summary>
		/// Restore 2 HP for every second.<para/>
		/// EffectType: 1<para/>
		/// Type: 19<para/>
		/// Level: 2<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 200<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 180<para/>
		/// BackGround: "GameUI/UI-Buff-02"<para/>
		/// TimeProgress: "GameUI/UI-Buff-06"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect HealingII { get; } = new StatusEffect("HealingII", 52);
		/// <summary>
		/// Restore 3 HP for every second.<para/>
		/// EffectType: 1<para/>
		/// Type: 19<para/>
		/// Level: 3<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 300<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 180<para/>
		/// BackGround: "GameUI/UI-Buff-02"<para/>
		/// TimeProgress: "GameUI/UI-Buff-06"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect HealingIII { get; } = new StatusEffect("HealingIII", 53);
		/// <summary>
		/// Restore 4 HP for every second.<para/>
		/// EffectType: 1<para/>
		/// Type: 19<para/>
		/// Level: 4<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 400<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 180<para/>
		/// BackGround: "GameUI/UI-Buff-02"<para/>
		/// TimeProgress: "GameUI/UI-Buff-06"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect HealingIV { get; } = new StatusEffect("HealingIV", 54);
		/// <summary>
		/// Restore 5 HP for every second.<para/>
		/// EffectType: 1<para/>
		/// Type: 19<para/>
		/// Level: 5<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 500<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 180<para/>
		/// BackGround: "GameUI/UI-Buff-02"<para/>
		/// TimeProgress: "GameUI/UI-Buff-06"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect HealingV { get; } = new StatusEffect("HealingV", 55);
		/// <summary>
		/// Walking speed increase by 10%.<para/>
		/// EffectType: 1<para/>
		/// Type: 20<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/14"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect SpeedI { get; } = new StatusEffect("SpeedI", 56);
		/// <summary>
		/// Walking speed increase by 15%.<para/>
		/// EffectType: 1<para/>
		/// Type: 20<para/>
		/// Level: 2<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.15<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/14"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect SpeedII { get; } = new StatusEffect("SpeedII", 57);
		/// <summary>
		/// Walking speed increase by 20%.<para/>
		/// EffectType: 1<para/>
		/// Type: 20<para/>
		/// Level: 3<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/14"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect SpeedIII { get; } = new StatusEffect("SpeedIII", 58);
		/// <summary>
		/// Walking speed increase by 25%.<para/>
		/// EffectType: 1<para/>
		/// Type: 20<para/>
		/// Level: 4<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.25<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/14"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect SpeedIV { get; } = new StatusEffect("SpeedIV", 59);
		/// <summary>
		/// Walking speed increase by 30%.<para/>
		/// EffectType: 1<para/>
		/// Type: 20<para/>
		/// Level: 5<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/14"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect SpeedV { get; } = new StatusEffect("SpeedV", 60);
		/// <summary>
		/// Walking speed decrease by 10%.<para/>
		/// EffectType: 2<para/>
		/// Type: 21<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: -0.1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/15"<para/>
		/// BuffParticle: "Debuff_SpeedSlowDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect SPDWeakenedI { get; } = new StatusEffect("SPDWeakenedI", 61);
		/// <summary>
		/// Walking speed decrease by 15%.<para/>
		/// EffectType: 2<para/>
		/// Type: 21<para/>
		/// Level: 2<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: -0.15<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/15"<para/>
		/// BuffParticle: "Debuff_SpeedSlowDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect SPDWeakenedII { get; } = new StatusEffect("SPDWeakenedII", 62);
		/// <summary>
		/// Walking speed decrease by 20%.<para/>
		/// EffectType: 2<para/>
		/// Type: 21<para/>
		/// Level: 3<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: -0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/15"<para/>
		/// BuffParticle: "Debuff_SpeedSlowDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect SPDWeakenedIII { get; } = new StatusEffect("SPDWeakenedIII", 63);
		/// <summary>
		/// Walking speed decrease by 25%.<para/>
		/// EffectType: 2<para/>
		/// Type: 21<para/>
		/// Level: 4<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: -0.25<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/15"<para/>
		/// BuffParticle: "Debuff_SpeedSlowDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect SPDWeakenedIV { get; } = new StatusEffect("SPDWeakenedIV", 64);
		/// <summary>
		/// Walking speed decrease by 30%.<para/>
		/// EffectType: 2<para/>
		/// Type: 21<para/>
		/// Level: 5<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: -0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/15"<para/>
		/// BuffParticle: "Debuff_SpeedSlowDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect SPDWeakenedV { get; } = new StatusEffect("SPDWeakenedV", 65);
		/// <summary>
		/// Attack speed increase by 10%.<para/>
		/// EffectType: 1<para/>
		/// Type: 22<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/16"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect AgilityI { get; } = new StatusEffect("AgilityI", 66);
		/// <summary>
		/// Attack speed increase by 15%.<para/>
		/// EffectType: 1<para/>
		/// Type: 22<para/>
		/// Level: 2<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.15<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/16"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect AgilityII { get; } = new StatusEffect("AgilityII", 67);
		/// <summary>
		/// Attack speed increase by 20%.<para/>
		/// EffectType: 1<para/>
		/// Type: 22<para/>
		/// Level: 3<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/16"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect AgilityIII { get; } = new StatusEffect("AgilityIII", 68);
		/// <summary>
		/// Attack speed increase by 25%.<para/>
		/// EffectType: 1<para/>
		/// Type: 22<para/>
		/// Level: 4<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.25<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/16"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect AgilityIV { get; } = new StatusEffect("AgilityIV", 69);
		/// <summary>
		/// Attack speed increase by 30%.<para/>
		/// EffectType: 1<para/>
		/// Type: 22<para/>
		/// Level: 5<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/16"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect AgilityV { get; } = new StatusEffect("AgilityV", 70);
		/// <summary>
		/// Attack speed decrease by 10%.<para/>
		/// EffectType: 2<para/>
		/// Type: 23<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: -0.1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/17"<para/>
		/// BuffParticle: "DebuffATKSpeedDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect AGIWeakenedI { get; } = new StatusEffect("AGIWeakenedI", 71);
		/// <summary>
		/// Attack speed decrease by 15%.<para/>
		/// EffectType: 2<para/>
		/// Type: 23<para/>
		/// Level: 2<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: -0.15<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/17"<para/>
		/// BuffParticle: "DebuffATKSpeedDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect AGIWeakenedII { get; } = new StatusEffect("AGIWeakenedII", 72);
		/// <summary>
		/// Attack speed decrease by 20%.<para/>
		/// EffectType: 2<para/>
		/// Type: 23<para/>
		/// Level: 3<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: -0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/17"<para/>
		/// BuffParticle: "DebuffATKSpeedDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect AGIWeakenedIII { get; } = new StatusEffect("AGIWeakenedIII", 73);
		/// <summary>
		/// Attack speed decrease by 25%.<para/>
		/// EffectType: 2<para/>
		/// Type: 23<para/>
		/// Level: 4<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: -0.25<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/17"<para/>
		/// BuffParticle: "DebuffATKSpeedDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect AGIWeakenedIV { get; } = new StatusEffect("AGIWeakenedIV", 74);
		/// <summary>
		/// Attack speed decrease by 30%.<para/>
		/// EffectType: 2<para/>
		/// Type: 23<para/>
		/// Level: 5<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: -0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 600<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/17"<para/>
		/// BuffParticle: "DebuffATKSpeedDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect AGIWeakenedV { get; } = new StatusEffect("AGIWeakenedV", 75);
		/// <summary>
		/// Attack speed and walking speed both increase by 20%, but hunger speed increase by 150%.<para/>
		/// EffectType: 1<para/>
		/// Type: 24<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 1<para/>
		/// Target1: "HungerDecMultiplierVaule"<para/>
		/// EffectValue1: 1.5<para/>
		/// EffectId2: 1<para/>
		/// Target2: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue2: 0.2<para/>
		/// DurationTime: 60<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/3"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect StimulantsI { get; } = new StatusEffect("StimulantsI", 76);
		/// <summary>
		/// Attack speed and walking speed both increase by 40%, but hunger speed increase by 300%.<para/>
		/// EffectType: 1<para/>
		/// Type: 24<para/>
		/// Level: 2<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.4<para/>
		/// EffectId1: 1<para/>
		/// Target1: "HungerDecMultiplierVaule"<para/>
		/// EffectValue1: 3<para/>
		/// EffectId2: 1<para/>
		/// Target2: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue2: 0.4<para/>
		/// DurationTime: 60<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/3"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect StimulantsII { get; } = new StatusEffect("StimulantsII", 77);
		/// <summary>
		/// Attack speed and walking speed both increase by 60%, but satiety will decrease to 0 once the effect is over.<para/>
		/// EffectType: 1<para/>
		/// Type: 24<para/>
		/// Level: 3<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.6<para/>
		/// EffectId1: 3<para/>
		/// Target1: "Hunger"<para/>
		/// EffectValue1: -36000<para/>
		/// EffectId2: 1<para/>
		/// Target2: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue2: 0.6<para/>
		/// DurationTime: 60<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/3"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect StimulantsIII { get; } = new StatusEffect("StimulantsIII", 78);
		/// <summary>
		/// Attack speed increase by 50%, but hunger speed increase by 100%.<para/>
		/// EffectType: 0<para/>
		/// Type: 24<para/>
		/// Level: 4<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.5<para/>
		/// EffectId1: 1<para/>
		/// Target1: "HungerDecMultiplierVaule"<para/>
		/// EffectValue1: 1<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 60<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/3"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Excitement0 { get; } = new StatusEffect("Excitement0", 79);
		/// <summary>
		/// Attack speed increase by 50%, but hunger speed increase by 100%.<para/>
		/// EffectType: 0<para/>
		/// Type: 24<para/>
		/// Level: 5<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.5<para/>
		/// EffectId1: 1<para/>
		/// Target1: "HungerDecMultiplierVaule"<para/>
		/// EffectValue1: 1<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 60<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/3"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Excitement1 { get; } = new StatusEffect("Excitement1", 80);
		/// <summary>
		/// Stun…<para/>
		/// EffectType: 5<para/>
		/// Type: 7<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "Stun"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/5"<para/>
		/// BuffParticle: "StunEffect"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Stun1 { get; } = new StatusEffect("Stun1", 81);
		/// <summary>
		/// Stun…<para/>
		/// EffectType: 5<para/>
		/// Type: 7<para/>
		/// Level: 2<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "Stun"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 2<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/5"<para/>
		/// BuffParticle: "StunEffect"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Stun2 { get; } = new StatusEffect("Stun2", 82);
		/// <summary>
		/// Stun…<para/>
		/// EffectType: 5<para/>
		/// Type: 7<para/>
		/// Level: 3<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "Stun"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 3<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/5"<para/>
		/// BuffParticle: "StunEffect"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Stun3 { get; } = new StatusEffect("Stun3", 83);
		/// <summary>
		/// Stun…<para/>
		/// EffectType: 5<para/>
		/// Type: 7<para/>
		/// Level: 4<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "Stun"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 4<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/5"<para/>
		/// BuffParticle: "StunEffect"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Stun4 { get; } = new StatusEffect("Stun4", 84);
		/// <summary>
		/// Stun…<para/>
		/// EffectType: 5<para/>
		/// Type: 7<para/>
		/// Level: 5<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "Stun"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 5<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/5"<para/>
		/// BuffParticle: "StunEffect"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Stun5 { get; } = new StatusEffect("Stun5", 85);
		/// <summary>
		/// Feeling scared…<para/>
		/// EffectType: 0<para/>
		/// Type: 25<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Fear { get; } = new StatusEffect("Fear", 101);
		/// <summary>
		/// You're shaking…<para/>
		/// EffectType: 0<para/>
		/// Type: 26<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Tremble { get; } = new StatusEffect("Tremble", 102);
		/// <summary>
		/// Feeling satisfied with a delicious meal. Hunger speed decrease by 35%.<para/>
		/// EffectType: 1<para/>
		/// Type: 27<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "HungerDecMultiplierVaule"<para/>
		/// EffectValue0: -0.35<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 60<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/18"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Tasty { get; } = new StatusEffect("Tasty", 103);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 28<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-04"<para/>
		/// TimeProgress: "GameUI/UI-Buff-08"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect104 { get; } = new StatusEffect("Effect104", 104);
		/// <summary>
		/// Lose 1 HP for every second.<para/>
		/// EffectType: 4<para/>
		/// Type: 29<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: -100<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 11<para/>
		/// BackGround: "GameUI/UI-Buff-04"<para/>
		/// TimeProgress: "GameUI/UI-Buff-08"<para/>
		/// Icon: "BuffIcon/19"<para/>
		/// BuffParticle: "DebuffPosion"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect ToxinI { get; } = new StatusEffect("ToxinI", 105);
		/// <summary>
		/// Lose 1 HP for every second.<para/>
		/// EffectType: 4<para/>
		/// Type: 29<para/>
		/// Level: 2<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: -100<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 16<para/>
		/// BackGround: "GameUI/UI-Buff-04"<para/>
		/// TimeProgress: "GameUI/UI-Buff-08"<para/>
		/// Icon: "BuffIcon/19"<para/>
		/// BuffParticle: "DebuffPosion"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect ToxinII { get; } = new StatusEffect("ToxinII", 106);
		/// <summary>
		/// Lose 2 HP for every second.<para/>
		/// EffectType: 4<para/>
		/// Type: 29<para/>
		/// Level: 3<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: -200<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 11<para/>
		/// BackGround: "GameUI/UI-Buff-04"<para/>
		/// TimeProgress: "GameUI/UI-Buff-08"<para/>
		/// Icon: "BuffIcon/19"<para/>
		/// BuffParticle: "DebuffPosion"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect ToxinIII { get; } = new StatusEffect("ToxinIII", 107);
		/// <summary>
		/// Lose 2 HP for every second.<para/>
		/// EffectType: 4<para/>
		/// Type: 29<para/>
		/// Level: 4<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: -200<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 16<para/>
		/// BackGround: "GameUI/UI-Buff-04"<para/>
		/// TimeProgress: "GameUI/UI-Buff-08"<para/>
		/// Icon: "BuffIcon/19"<para/>
		/// BuffParticle: "DebuffPosion"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect ToxinIV { get; } = new StatusEffect("ToxinIV", 108);
		/// <summary>
		/// Lose 3 HP for every second.<para/>
		/// EffectType: 4<para/>
		/// Type: 29<para/>
		/// Level: 5<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: -300<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 11<para/>
		/// BackGround: "GameUI/UI-Buff-04"<para/>
		/// TimeProgress: "GameUI/UI-Buff-08"<para/>
		/// Icon: "BuffIcon/19"<para/>
		/// BuffParticle: "DebuffPosion"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect ToxinV { get; } = new StatusEffect("ToxinV", 109);
		/// <summary>
		/// Lose 2 HP for every second.<para/>
		/// EffectType: 3<para/>
		/// Type: 30<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: -200<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 6<para/>
		/// BackGround: "GameUI/UI-Buff-04"<para/>
		/// TimeProgress: "GameUI/UI-Buff-08"<para/>
		/// Icon: "BuffIcon/20"<para/>
		/// BuffParticle: "DebuffBleed"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect BleedingI { get; } = new StatusEffect("BleedingI", 110);
		/// <summary>
		/// Lose 3 HP for every second.<para/>
		/// EffectType: 3<para/>
		/// Type: 30<para/>
		/// Level: 2<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: -300<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 6<para/>
		/// BackGround: "GameUI/UI-Buff-04"<para/>
		/// TimeProgress: "GameUI/UI-Buff-08"<para/>
		/// Icon: "BuffIcon/20"<para/>
		/// BuffParticle: "DebuffBleed"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect BleedingII { get; } = new StatusEffect("BleedingII", 111);
		/// <summary>
		/// Lose 3 HP for every second.<para/>
		/// EffectType: 3<para/>
		/// Type: 30<para/>
		/// Level: 3<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: -300<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 11<para/>
		/// BackGround: "GameUI/UI-Buff-04"<para/>
		/// TimeProgress: "GameUI/UI-Buff-08"<para/>
		/// Icon: "BuffIcon/20"<para/>
		/// BuffParticle: "DebuffBleed"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect BleedingIII { get; } = new StatusEffect("BleedingIII", 112);
		/// <summary>
		/// Lose 4 HP for every second.<para/>
		/// EffectType: 3<para/>
		/// Type: 30<para/>
		/// Level: 4<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: -400<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 11<para/>
		/// BackGround: "GameUI/UI-Buff-04"<para/>
		/// TimeProgress: "GameUI/UI-Buff-08"<para/>
		/// Icon: "BuffIcon/20"<para/>
		/// BuffParticle: "DebuffBleed"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect BleedingIV { get; } = new StatusEffect("BleedingIV", 113);
		/// <summary>
		/// Lose 4 HP for every second.<para/>
		/// EffectType: 3<para/>
		/// Type: 30<para/>
		/// Level: 5<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: -400<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 16<para/>
		/// BackGround: "GameUI/UI-Buff-04"<para/>
		/// TimeProgress: "GameUI/UI-Buff-08"<para/>
		/// Icon: "BuffIcon/20"<para/>
		/// BuffParticle: "DebuffBleed"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect BleedingV { get; } = new StatusEffect("BleedingV", 114);
		/// <summary>
		/// Walking speed increase by 15%, but hunger speed increase by 10% and defense decrease by 2 points.<para/>
		/// EffectType: 0<para/>
		/// Type: 31<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.15<para/>
		/// EffectId1: 1<para/>
		/// Target1: "DefenceAddValue"<para/>
		/// EffectValue1: -3<para/>
		/// EffectId2: 1<para/>
		/// Target2: "HungerDecMultiplierVaule"<para/>
		/// EffectValue2: 0.1<para/>
		/// DurationTime: 180<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/26"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect MutatedLeg { get; } = new StatusEffect("MutatedLeg", 115);
		/// <summary>
		/// Attack increase by 3 points, but hunger speed increase by 10% and walking speed decrease by 10%.<para/>
		/// EffectType: 0<para/>
		/// Type: 32<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackAddValue"<para/>
		/// EffectValue0: 3<para/>
		/// EffectId1: 1<para/>
		/// Target1: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue1: -0.1<para/>
		/// EffectId2: 1<para/>
		/// Target2: "HungerDecMultiplierVaule"<para/>
		/// EffectValue2: 0.1<para/>
		/// DurationTime: 180<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/25"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect MutatedArm { get; } = new StatusEffect("MutatedArm", 116);
		/// <summary>
		/// Defense increase by 4 points, but hunger speed increase by 10% and attack decrease by 2 points.<para/>
		/// EffectType: 0<para/>
		/// Type: 33<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: 6<para/>
		/// EffectId1: 1<para/>
		/// Target1: "AttackAddValue"<para/>
		/// EffectValue1: -2<para/>
		/// EffectId2: 1<para/>
		/// Target2: "HungerDecMultiplierVaule"<para/>
		/// EffectValue2: 0.1<para/>
		/// DurationTime: 180<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/27"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect MutatedSkin { get; } = new StatusEffect("MutatedSkin", 117);
		/// <summary>
		/// You're hungry! Attack speed and walking speed are slowing down.<para/>
		/// EffectType: 0<para/>
		/// Type: 34<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: -0.15<para/>
		/// EffectId1: 1<para/>
		/// Target1: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue1: -0.15<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/22"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect HungerI { get; } = new StatusEffect("HungerI", 118);
		/// <summary>
		/// You're starving! Attack speed and walking speed are slowing down.<para/>
		/// EffectType: 0<para/>
		/// Type: 34<para/>
		/// Level: 2<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: -0.3<para/>
		/// EffectId1: 1<para/>
		/// Target1: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue1: -0.3<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/23"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect HungerII { get; } = new StatusEffect("HungerII", 119);
		/// <summary>
		/// You're dying! Attack speed and walking speed are slowing down.<para/>
		/// EffectType: 0<para/>
		/// Type: 34<para/>
		/// Level: 3<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: -0.5<para/>
		/// EffectId1: 1<para/>
		/// Target1: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue1: -0.4<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-04"<para/>
		/// TimeProgress: "GameUI/UI-Buff-08"<para/>
		/// Icon: "BuffIcon/24"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect HungerIII { get; } = new StatusEffect("HungerIII", 120);
		/// <summary>
		/// Walking speed decrease by 25%.<para/>
		/// EffectType: 2<para/>
		/// Type: 4<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: -0.25<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 60<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/2"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect MushroomToxinNausea { get; } = new StatusEffect("MushroomToxinNausea", 121);
		/// <summary>
		/// Attack speed increase by 30%, but hunger speed increase by 50%.<para/>
		/// EffectType: 1<para/>
		/// Type: 5<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.3<para/>
		/// EffectId1: 1<para/>
		/// Target1: "HungerDecMultiplierVaule"<para/>
		/// EffectValue1: 0.5<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 60<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/3"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect MushroomToxinExcited { get; } = new StatusEffect("MushroomToxinExcited", 122);
		/// <summary>
		/// Hunger speed increase by 50%.<para/>
		/// EffectType: 2<para/>
		/// Type: 6<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "HungerDecMultiplierVaule"<para/>
		/// EffectValue0: 0.5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 60<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/4"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect MushroomToxinTired { get; } = new StatusEffect("MushroomToxinTired", 123);
		/// <summary>
		/// Restore 1 HP for every second.<para/>
		/// EffectType: 1<para/>
		/// Type: 124<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 100<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 180<para/>
		/// BackGround: "GameUI/UI-Buff-02"<para/>
		/// TimeProgress: "GameUI/UI-Buff-06"<para/>
		/// Icon: "BuffIcon/34"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect MushroomToxinCureI { get; } = new StatusEffect("MushroomToxinCureI", 124);
		/// <summary>
		/// Restore 2 HP for every second.<para/>
		/// EffectType: 1<para/>
		/// Type: 124<para/>
		/// Level: 2<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 200<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 180<para/>
		/// BackGround: "GameUI/UI-Buff-02"<para/>
		/// TimeProgress: "GameUI/UI-Buff-06"<para/>
		/// Icon: "BuffIcon/34"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect MushroomToxinCureII { get; } = new StatusEffect("MushroomToxinCureII", 125);
		/// <summary>
		/// Walking speed increase by 20%.<para/>
		/// EffectType: 1<para/>
		/// Type: 20<para/>
		/// Level: 0<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 180<para/>
		/// BackGround: "GameUI/UI-Buff-01"<para/>
		/// TimeProgress: "GameUI/UI-Buff-05"<para/>
		/// Icon: "BuffIcon/14"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect MushroomToxinAGI { get; } = new StatusEffect("MushroomToxinAGI", 126);
		/// <summary>
		/// Lose 1 HP for every second.<para/>
		/// EffectType: 4<para/>
		/// Type: 29<para/>
		/// Level: 2<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: -100<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 16<para/>
		/// BackGround: "GameUI/UI-Buff-04"<para/>
		/// TimeProgress: "GameUI/UI-Buff-08"<para/>
		/// Icon: "BuffIcon/33"<para/>
		/// BuffParticle: "DebuffPosion"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect MushroomToxin { get; } = new StatusEffect("MushroomToxin", 127);
		/// <summary>
		/// Restore 1 HP for every second.<para/>
		/// EffectType: 1<para/>
		/// Type: 128<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 100<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 20<para/>
		/// BackGround: "GameUI/UI-Buff-02"<para/>
		/// TimeProgress: "GameUI/UI-Buff-06"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect ContinuousRecovery { get; } = new StatusEffect("ContinuousRecovery", 128);
		/// <summary>
		/// Restore 2 HP for every second.<para/>
		/// EffectType: 1<para/>
		/// Type: 129<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 200<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 40<para/>
		/// BackGround: "GameUI/UI-Buff-02"<para/>
		/// TimeProgress: "GameUI/UI-Buff-06"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect SweetSoup { get; } = new StatusEffect("SweetSoup", 129);
		/// <summary>
		/// Attracting chickens around you…<para/>
		/// EffectType: 0<para/>
		/// Type: 130<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 30<para/>
		/// BackGround: "GameUI/UI-Buff-11"<para/>
		/// TimeProgress: "GameUI/UI-Buff-12"<para/>
		/// Icon: "BuffIcon/29"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect PheromonesChicken { get; } = new StatusEffect("PheromonesChicken", 130);
		/// <summary>
		/// Attracting goats around you…<para/>
		/// EffectType: 0<para/>
		/// Type: 131<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 30<para/>
		/// BackGround: "GameUI/UI-Buff-11"<para/>
		/// TimeProgress: "GameUI/UI-Buff-12"<para/>
		/// Icon: "BuffIcon/30"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect PheromonesGoat { get; } = new StatusEffect("PheromonesGoat", 131);
		/// <summary>
		/// Attracting pigs around you…<para/>
		/// EffectType: 0<para/>
		/// Type: 132<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 30<para/>
		/// BackGround: "GameUI/UI-Buff-11"<para/>
		/// TimeProgress: "GameUI/UI-Buff-12"<para/>
		/// Icon: "BuffIcon/31"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect PheromonesPig { get; } = new StatusEffect("PheromonesPig", 132);
		/// <summary>
		/// Attracting cows around you…<para/>
		/// EffectType: 0<para/>
		/// Type: 133<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 30<para/>
		/// BackGround: "GameUI/UI-Buff-11"<para/>
		/// TimeProgress: "GameUI/UI-Buff-12"<para/>
		/// Icon: "BuffIcon/32"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect PheromonesCow { get; } = new StatusEffect("PheromonesCow", 133);
		/// <summary>
		/// Attracting horses around you…<para/>
		/// EffectType: 0<para/>
		/// Type: 134<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 30<para/>
		/// BackGround: "GameUI/UI-Buff-11"<para/>
		/// TimeProgress: "GameUI/UI-Buff-12"<para/>
		/// Icon: "BuffIcon/35"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect PheromonesHorse { get; } = new StatusEffect("PheromonesHorse", 134);
		/// <summary>
		/// Walking speed decrease by 10% and lose 1 HP for every second.<para/>
		/// EffectType: 4<para/>
		/// Type: 135<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: -100<para/>
		/// EffectId1: 1<para/>
		/// Target1: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue1: -0.1<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-04"<para/>
		/// TimeProgress: "GameUI/UI-Buff-08"<para/>
		/// Icon: "BuffIcon/36"<para/>
		/// BuffParticle: "DebuffEffect1"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect SuffocatingGas0 { get; } = new StatusEffect("SuffocatingGas0", 135);
		/// <summary>
		/// Walking speed decrease by 25% and lose 5 HP for every second.<para/>
		/// EffectType: 4<para/>
		/// Type: 136<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: -500<para/>
		/// EffectId1: 1<para/>
		/// Target1: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue1: -0.25<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-04"<para/>
		/// TimeProgress: "GameUI/UI-Buff-08"<para/>
		/// Icon: "BuffIcon/36"<para/>
		/// BuffParticle: "DebuffEffect1"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect SuffocatingGas1 { get; } = new StatusEffect("SuffocatingGas1", 136);
		/// <summary>
		/// Bear Trap:  unable to move,and lose 1 HP for every second.<para/>
		/// EffectType: 3<para/>
		/// Type: 137<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "Freeze"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 2<para/>
		/// Target1: "Hp"<para/>
		/// EffectValue1: -100<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 5<para/>
		/// BackGround: "GameUI/UI-Buff-04"<para/>
		/// TimeProgress: "GameUI/UI-Buff-08"<para/>
		/// Icon: "BuffIcon/37"<para/>
		/// BuffParticle: "DebuffBleed"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect BearTrap { get; } = new StatusEffect("BearTrap", 137);
		/// <summary>
		/// Restore 1 HP for every second.<para/>
		/// EffectType: 1<para/>
		/// Type: 138<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 200<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 5<para/>
		/// BackGround: "GameUI/UI-Buff-02"<para/>
		/// TimeProgress: "GameUI/UI-Buff-06"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect RecoveryI { get; } = new StatusEffect("RecoveryI", 138);
		/// <summary>
		/// Restore 2 HP for every second.<para/>
		/// EffectType: 1<para/>
		/// Type: 138<para/>
		/// Level: 2<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 300<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 5<para/>
		/// BackGround: "GameUI/UI-Buff-02"<para/>
		/// TimeProgress: "GameUI/UI-Buff-06"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect RecoveryII { get; } = new StatusEffect("RecoveryII", 139);
		/// <summary>
		/// Restore 3 HP for every second.<para/>
		/// EffectType: 1<para/>
		/// Type: 138<para/>
		/// Level: 3<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 400<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 5<para/>
		/// BackGround: "GameUI/UI-Buff-02"<para/>
		/// TimeProgress: "GameUI/UI-Buff-06"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect RecoveryIII { get; } = new StatusEffect("RecoveryIII", 140);
		/// <summary>
		/// Restore 4 HP for every second.<para/>
		/// EffectType: 1<para/>
		/// Type: 138<para/>
		/// Level: 4<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 500<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 5<para/>
		/// BackGround: "GameUI/UI-Buff-02"<para/>
		/// TimeProgress: "GameUI/UI-Buff-06"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect RecoveryIV0 { get; } = new StatusEffect("RecoveryIV0", 141);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 501<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 0<para/>
		/// EffectId0: 1<para/>
		/// Target0: "Afterimage"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 1<para/>
		/// Target1: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue1: 0.4<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 3<para/>
		/// BackGround: "GameUI/UI-Buff-02"<para/>
		/// TimeProgress: "GameUI/UI-Buff-06"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect RecoveryIV1 { get; } = new StatusEffect("RecoveryIV1", 501);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 45<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect1001 { get; } = new StatusEffect("Effect1001", 1001);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 46<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect1002 { get; } = new StatusEffect("Effect1002", 1002);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 47<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 2<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 1500<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect1003 { get; } = new StatusEffect("Effect1003", 1003);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 48<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.15<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 60<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect1004 { get; } = new StatusEffect("Effect1004", 1004);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 49<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hunger"<para/>
		/// EffectValue0: 3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect1005 { get; } = new StatusEffect("Effect1005", 1005);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 2001<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: -0.5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 2<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect2001 { get; } = new StatusEffect("Effect2001", 2001);
		/// <summary>
		/// Defense decrease by 5 points.<para/>
		/// EffectType: 0<para/>
		/// Type: 2002<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: -5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/12"<para/>
		/// BuffParticle: "DebuffDefDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Corrosion { get; } = new StatusEffect("Corrosion", 2002);
		/// <summary>
		/// Attack decrease by 4 points.<para/>
		/// EffectType: 0<para/>
		/// Type: 2003<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackAddValue"<para/>
		/// EffectValue0: -4<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 10<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/10"<para/>
		/// BuffParticle: "DebuffAtkDown"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Weak { get; } = new StatusEffect("Weak", 2003);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 2004<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: -10<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect2004 { get; } = new StatusEffect("Effect2004", 2004);
		/// <summary>
		/// Restore 1 HP for every two seconds.<para/>
		/// EffectType: 0<para/>
		/// Type: 2005<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 2<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 25<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect2005 { get; } = new StatusEffect("Effect2005", 2005);
		/// <summary>
		/// Equip: gathering speed increase by 50%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5001<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "GatheringSpeed2"<para/>
		/// EffectValue0: 0.5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5001 { get; } = new StatusEffect("Effect5001", 5001);
		/// <summary>
		/// Equip: gathering speed increase by 100%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5002<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "GatheringSpeed2"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5002 { get; } = new StatusEffect("Effect5002", 5002);
		/// <summary>
		/// Equip: gathering speed increase by 200%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5003<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "GatheringSpeed2"<para/>
		/// EffectValue0: 2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5003 { get; } = new StatusEffect("Effect5003", 5003);
		/// <summary>
		/// Equip: eating speed increase by 50%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5011<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "EatingSpeed2"<para/>
		/// EffectValue0: 0.5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5011 { get; } = new StatusEffect("Effect5011", 5011);
		/// <summary>
		/// Equip: eating speed increase by 100%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5012<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "EatingSpeed2"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5012 { get; } = new StatusEffect("Effect5012", 5012);
		/// <summary>
		/// Equip: eating speed increase by 200%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5013<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "EatingSpeed2"<para/>
		/// EffectValue0: 2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5013 { get; } = new StatusEffect("Effect5013", 5013);
		/// <summary>
		/// Equip: become stealth if no attack or injury occurred within 5 seconds.<para/>
		/// EffectType: 0<para/>
		/// Type: 5021<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5021 { get; } = new StatusEffect("Effect5021", 5021);
		/// <summary>
		/// Equip: melee knockback increase by 50%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5031<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5031 { get; } = new StatusEffect("Effect5031", 5031);
		/// <summary>
		/// Equip: walking speed increase by 10%<para/>
		/// EffectType: 0<para/>
		/// Type: 5041<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5041 { get; } = new StatusEffect("Effect5041", 5041);
		/// <summary>
		/// Equip: walking speed increase by 15%<para/>
		/// EffectType: 0<para/>
		/// Type: 5042<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.15<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5042 { get; } = new StatusEffect("Effect5042", 5042);
		/// <summary>
		/// Equip: walking speed increase by 20%<para/>
		/// EffectType: 0<para/>
		/// Type: 5043<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5043 { get; } = new StatusEffect("Effect5043", 5043);
		/// <summary>
		/// Equip: walking speed increase by 25%<para/>
		/// EffectType: 0<para/>
		/// Type: 5044<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.25<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5044 { get; } = new StatusEffect("Effect5044", 5044);
		/// <summary>
		/// Equip: walking speed increase by 30%<para/>
		/// EffectType: 0<para/>
		/// Type: 5045<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5045 { get; } = new StatusEffect("Effect5045", 5045);
		/// <summary>
		/// Equip: double tap a direction to dash.<para/>
		/// EffectType: 0<para/>
		/// Type: 5051<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5051 { get; } = new StatusEffect("Effect5051", 5051);
		/// <summary>
		/// Equip: your attack will poison your target.<para/>
		/// EffectType: 0<para/>
		/// Type: 5061<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5061 { get; } = new StatusEffect("Effect5061", 5061);
		/// <summary>
		/// Equip: illuminate your vision.<para/>
		/// EffectType: 0<para/>
		/// Type: 5071<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5071 { get; } = new StatusEffect("Effect5071", 5071);
		/// <summary>
		/// Equip: damage received from ranged attacks decrease by 15%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5081<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5081 { get; } = new StatusEffect("Effect5081", 5081);
		/// <summary>
		/// Equip: damage received from ranged attacks decrease by 20%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5082<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5082 { get; } = new StatusEffect("Effect5082", 5082);
		/// <summary>
		/// Equip: damage received from ranged attacks decrease by 25%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5083<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5083 { get; } = new StatusEffect("Effect5083", 5083);
		/// <summary>
		/// Equip: damage received from ranged attacks decrease by 30%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5084<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5084 { get; } = new StatusEffect("Effect5084", 5084);
		/// <summary>
		/// Equip: chance to scare target away on hit for 2 seconds<para/>
		/// EffectType: 0<para/>
		/// Type: 5091<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5091 { get; } = new StatusEffect("Effect5091", 5091);
		/// <summary>
		/// Equip: defense increase by 2 points.<para/>
		/// EffectType: 0<para/>
		/// Type: 5101<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: 2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5101 { get; } = new StatusEffect("Effect5101", 5101);
		/// <summary>
		/// Equip: defense increase by 4 points.<para/>
		/// EffectType: 0<para/>
		/// Type: 5102<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: 4<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5102 { get; } = new StatusEffect("Effect5102", 5102);
		/// <summary>
		/// Equip: defense increase by 6 points.<para/>
		/// EffectType: 0<para/>
		/// Type: 5103<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: 6<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5103 { get; } = new StatusEffect("Effect5103", 5103);
		/// <summary>
		/// Equip: defense increase by 8 points.<para/>
		/// EffectType: 0<para/>
		/// Type: 5104<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: 8<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5104 { get; } = new StatusEffect("Effect5104", 5104);
		/// <summary>
		/// Equip: defense increase by 10 points.<para/>
		/// EffectType: 0<para/>
		/// Type: 5105<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: 10<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5105 { get; } = new StatusEffect("Effect5105", 5105);
		/// <summary>
		/// Equip: chance to confuse target on hit for 3 seconds.<para/>
		/// EffectType: 0<para/>
		/// Type: 5111<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5111 { get; } = new StatusEffect("Effect5111", 5111);
		/// <summary>
		/// Equip: duration of poisoned effect decrease by 50%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5121<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5121 { get; } = new StatusEffect("Effect5121", 5121);
		/// <summary>
		/// Equip: duration of bleeding effect decrease by 50%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5131<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5131 { get; } = new StatusEffect("Effect5131", 5131);
		/// <summary>
		/// Equip: when death occurs, this will be destroyed to protect items in your bag from dropping off.<para/>
		/// EffectType: 0<para/>
		/// Type: 5141<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5141 { get; } = new StatusEffect("Effect5141", 5141);
		/// <summary>
		/// Equip: when lethal damage occurs, you will be restored to 30% of your health and invincible for 5 seconds.<para/>
		/// EffectType: 0<para/>
		/// Type: 5151<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5151 { get; } = new StatusEffect("Effect5151", 5151);
		/// <summary>
		/// Equip: Tenergy may not be consumed when using the Tenergy weapons.<para/>
		/// EffectType: 0<para/>
		/// Type: 5161<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 0<para/>
		/// Target0: "0"<para/>
		/// EffectValue0: 0<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5161 { get; } = new StatusEffect("Effect5161", 5161);
		/// <summary>
		/// Equip: restore 1 HP for every second.<para/>
		/// EffectType: 0<para/>
		/// Type: 5171<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 100<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5171 { get; } = new StatusEffect("Effect5171", 5171);
		/// <summary>
		/// Equip: restore 2 HP for every second.<para/>
		/// EffectType: 0<para/>
		/// Type: 5172<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 200<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5172 { get; } = new StatusEffect("Effect5172", 5172);
		/// <summary>
		/// Equip: releasing a firefly that slightly illuminates the area around you.<para/>
		/// EffectType: 0<para/>
		/// Type: 5181<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "PlayerInfo.FlyLight"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5181 { get; } = new StatusEffect("Effect5181", 5181);
		/// <summary>
		/// Equip: attack speed increase by 10%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5191<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5191 { get; } = new StatusEffect("Effect5191", 5191);
		/// <summary>
		/// Equip: attack speed increase by 15%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5192<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.15<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5192 { get; } = new StatusEffect("Effect5192", 5192);
		/// <summary>
		/// Equip: attack speed increase by 20%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5193<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5193 { get; } = new StatusEffect("Effect5193", 5193);
		/// <summary>
		/// Equip: attack speed increase by 25%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5194<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.25<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5194 { get; } = new StatusEffect("Effect5194", 5194);
		/// <summary>
		/// Equip: attack speed increase by 30%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5195<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5195 { get; } = new StatusEffect("Effect5195", 5195);
		/// <summary>
		/// Equip: melee attack increase by 1 point.<para/>
		/// EffectType: 0<para/>
		/// Type: 5201<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackAddValue"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5201 { get; } = new StatusEffect("Effect5201", 5201);
		/// <summary>
		/// Equip: melee attack increase by 3 points.<para/>
		/// EffectType: 0<para/>
		/// Type: 5202<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackAddValue"<para/>
		/// EffectValue0: 3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5202 { get; } = new StatusEffect("Effect5202", 5202);
		/// <summary>
		/// Equip: melee attack increase by 5 points.<para/>
		/// EffectType: 0<para/>
		/// Type: 5203<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackAddValue"<para/>
		/// EffectValue0: 5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5203 { get; } = new StatusEffect("Effect5203", 5203);
		/// <summary>
		/// Equip: melee attack increase by 7 points.<para/>
		/// EffectType: 0<para/>
		/// Type: 5204<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackAddValue"<para/>
		/// EffectValue0: 7<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5204 { get; } = new StatusEffect("Effect5204", 5204);
		/// <summary>
		/// Equip: melee attack increase by 10 points.<para/>
		/// EffectType: 0<para/>
		/// Type: 5205<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackAddValue"<para/>
		/// EffectValue0: 10<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5205 { get; } = new StatusEffect("Effect5205", 5205);
		/// <summary>
		/// Equip: attack increase by 10%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5211<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackMultiplierVaule"<para/>
		/// EffectValue0: 0.1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5211 { get; } = new StatusEffect("Effect5211", 5211);
		/// <summary>
		/// Equip: attack increase by 15%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5212<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackMultiplierVaule"<para/>
		/// EffectValue0: 0.15<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5212 { get; } = new StatusEffect("Effect5212", 5212);
		/// <summary>
		/// Equip: attack increase by 20%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5213<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackMultiplierVaule"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5213 { get; } = new StatusEffect("Effect5213", 5213);
		/// <summary>
		/// Equip: attack increase by 25%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5214<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackMultiplierVaule"<para/>
		/// EffectValue0: 0.25<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5214 { get; } = new StatusEffect("Effect5214", 5214);
		/// <summary>
		/// Equip: attack increase by 30%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5215<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackMultiplierVaule"<para/>
		/// EffectValue0: 0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5215 { get; } = new StatusEffect("Effect5215", 5215);
		/// <summary>
		/// Equip: slower durability loss on armor by 20%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5216<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "EquipmentDecDurability"<para/>
		/// EffectValue0: -0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5216 { get; } = new StatusEffect("Effect5216", 5216);
		/// <summary>
		/// Equip: slower durability loss on armor by 25%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5217<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "EquipmentDecDurability"<para/>
		/// EffectValue0: -0.25<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5217 { get; } = new StatusEffect("Effect5217", 5217);
		/// <summary>
		/// Equip: slower durability loss on armor by 30%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5218<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "EquipmentDecDurability"<para/>
		/// EffectValue0: -0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5218 { get; } = new StatusEffect("Effect5218", 5218);
		/// <summary>
		/// Equip: slower durability loss on armor by 35%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5219<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "EquipmentDecDurability"<para/>
		/// EffectValue0: -0.35<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5219 { get; } = new StatusEffect("Effect5219", 5219);
		/// <summary>
		/// Equip: slower durability loss on armor by 40%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5220<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "EquipmentDecDurability"<para/>
		/// EffectValue0: -0.4<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5220 { get; } = new StatusEffect("Effect5220", 5220);
		/// <summary>
		/// Equip: hunger speed decrease by 20%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5221<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "HungerDecMultiplierVaule"<para/>
		/// EffectValue0: -0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5221 { get; } = new StatusEffect("Effect5221", 5221);
		/// <summary>
		/// Equip: hunger speed decrease by 25%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5222<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "HungerDecMultiplierVaule"<para/>
		/// EffectValue0: -0.25<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5222 { get; } = new StatusEffect("Effect5222", 5222);
		/// <summary>
		/// Equip: hunger speed decrease by 30%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5223<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "HungerDecMultiplierVaule"<para/>
		/// EffectValue0: -0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5223 { get; } = new StatusEffect("Effect5223", 5223);
		/// <summary>
		/// Equip: hunger speed decrease by 35%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5224<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "HungerDecMultiplierVaule"<para/>
		/// EffectValue0: -0.35<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5224 { get; } = new StatusEffect("Effect5224", 5224);
		/// <summary>
		/// Equip: hunger speed decrease by 40%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5225<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "HungerDecMultiplierVaule"<para/>
		/// EffectValue0: -0.4<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5225 { get; } = new StatusEffect("Effect5225", 5225);
		/// <summary>
		/// Equip: build distance increase by 3.<para/>
		/// EffectType: 0<para/>
		/// Type: 5226<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "PlacedDistance"<para/>
		/// EffectValue0: 1.5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5226 { get; } = new StatusEffect("Effect5226", 5226);
		/// <summary>
		/// Equip: build distance increase by 4.<para/>
		/// EffectType: 0<para/>
		/// Type: 5227<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "PlacedDistance"<para/>
		/// EffectValue0: 2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5227 { get; } = new StatusEffect("Effect5227", 5227);
		/// <summary>
		/// Equip: build distance increase by 5.<para/>
		/// EffectType: 0<para/>
		/// Type: 5228<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "PlacedDistance"<para/>
		/// EffectValue0: 2.5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5228 { get; } = new StatusEffect("Effect5228", 5228);
		/// <summary>
		/// Equip: build distance increase by 6.<para/>
		/// EffectType: 0<para/>
		/// Type: 5229<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "PlacedDistance"<para/>
		/// EffectValue0: 3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5229 { get; } = new StatusEffect("Effect5229", 5229);
		/// <summary>
		/// Equip: build distance increase by 7.<para/>
		/// EffectType: 0<para/>
		/// Type: 5230<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "PlacedDistance"<para/>
		/// EffectValue0: 3.5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5230 { get; } = new StatusEffect("Effect5230", 5230);
		/// <summary>
		/// Equip: restore a certain amount of HP when you kill a creature.<para/>
		/// EffectType: 0<para/>
		/// Type: 5231<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "PlayerInfo.EatBody"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5231 { get; } = new StatusEffect("Effect5231", 5231);
		/// <summary>
		/// Equip: generate a poisonous spore that follows you around. The spore will cause poisonous gas once it explodes, and the gas will poison the enemies and cause them a decrease in walking speed by 25% and lose 3 HP for every second, lasts for 10 seconds.<para/>
		/// EffectType: 0<para/>
		/// Type: 5232<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "PlayerInfo.PosionPet"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5232 { get; } = new StatusEffect("Effect5232", 5232);
		/// <summary>
		/// Equip: can illuminate a certain range in front.<para/>
		/// EffectType: 0<para/>
		/// Type: 5241<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "PlayerInfo.FlashLight"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5241 { get; } = new StatusEffect("Effect5241", 5241);
		/// <summary>
		/// Equip: can detect metals.<para/>
		/// EffectType: 0<para/>
		/// Type: 5242<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "PlayerInfo.MineLight"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5242 { get; } = new StatusEffect("Effect5242", 5242);
		/// <summary>
		/// Equip: restore 1 HP for every two seconds.<para/>
		/// EffectType: 0<para/>
		/// Type: 5243<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 50<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect ParasytorSymbioticWorm { get; } = new StatusEffect("ParasytorSymbioticWorm", 5243);
		/// <summary>
		/// Equip: eating speed increase by 50%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5244<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "EatingSpeed2"<para/>
		/// EffectValue0: 0.5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect GoblinFork { get; } = new StatusEffect("GoblinFork", 5244);
		/// <summary>
		/// Equip: attack speed increase by 10%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5245<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect GoblinBracelet { get; } = new StatusEffect("GoblinBracelet", 5245);
		/// <summary>
		/// Equip: defense increase by 20%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5246<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceMultiplierVaule"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect GoblinShield { get; } = new StatusEffect("GoblinShield", 5246);
		/// <summary>
		/// Equip: defense increase by 8 points.<para/>
		/// EffectType: 0<para/>
		/// Type: 5247<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: 8<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect InsectorElytronShield { get; } = new StatusEffect("InsectorElytronShield", 5247);
		/// <summary>
		/// Equip: walking speed increase by 15%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5248<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.15<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect InsectorWings { get; } = new StatusEffect("InsectorWings", 5248);
		/// <summary>
		/// Equip: attack increase by 4 points.<para/>
		/// EffectType: 0<para/>
		/// Type: 5249<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackAddValue"<para/>
		/// EffectValue0: 3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect ParasectThorn { get; } = new StatusEffect("ParasectThorn", 5249);
		/// <summary>
		/// Equip: hunger speed decrease by 30%, and restore 1 HP for every seconds.<para/>
		/// EffectType: 0<para/>
		/// Type: 5250<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "HungerDecMultiplierVaule"<para/>
		/// EffectValue0: -0.3<para/>
		/// EffectId1: 2<para/>
		/// Target1: "Hp"<para/>
		/// EffectValue1: 100<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect MecoLifeSupportDevice { get; } = new StatusEffect("MecoLifeSupportDevice", 5250);
		/// <summary>
		/// Equip: defense increase by 30%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5251<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceMultiplierVaule"<para/>
		/// EffectValue0: 0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect MecoShield { get; } = new StatusEffect("MecoShield", 5251);
		/// <summary>
		/// Equip: eating speed increase by 100%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5252<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "EatingSpeed2"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect MecoElectricSpoon { get; } = new StatusEffect("MecoElectricSpoon", 5252);
		/// <summary>
		/// Equip: attack speed increase by 15%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5253<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.15<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect MecoPoweredExoskeletonArm { get; } = new StatusEffect("MecoPoweredExoskeletonArm", 5253);
		/// <summary>
		/// Equip: attack increase by 15%.<para/>
		/// EffectType: 0<para/>
		/// Type: 5254<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackMultiplierVaule"<para/>
		/// EffectValue0: 0.15<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect MecoBiotechPoweredExoskeletonArm { get; } = new StatusEffect("MecoBiotechPoweredExoskeletonArm", 5254);
		/// <summary>
		/// Equip: gain a stack of amber shield every 6 seconds, and stacks up to 3 times. Each shield can withstand one attack. Generation of an amber shield will be stopped when you are being attacked.<para/>
		/// EffectType: 0<para/>
		/// Type: 5255<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AmberShield"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5255 { get; } = new StatusEffect("Effect5255", 5255);
		/// <summary>
		/// Equip: summon a modified detector that will follow you and help you to pick up items on the ground around you.<para/>
		/// EffectType: 0<para/>
		/// Type: 5256<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "PlayerInfo.CollectionDrone"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5256 { get; } = new StatusEffect("Effect5256", 5256);
		/// <summary>
		/// Equip: can detect metals.<para/>
		/// EffectType: 0<para/>
		/// Type: 5257<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "LandMineDrone"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect5257 { get; } = new StatusEffect("Effect5257", 5257);
		/// <summary>
		/// ImmuneStun<para/>
		/// EffectType: 0<para/>
		/// Type: 9987<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ImmuneDebuffStun"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Immunestun { get; } = new StatusEffect("Immunestun", 9987);
		/// <summary>
		/// God Cure<para/>
		/// EffectType: 0<para/>
		/// Type: 9988<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 4<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect GodCure { get; } = new StatusEffect("GodCure", 9988);
		/// <summary>
		/// Dodge<para/>
		/// EffectType: 0<para/>
		/// Type: 9989<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "OnHitProtect"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Dodge { get; } = new StatusEffect("Dodge", 9989);
		/// <summary>
		/// ImmuneRemote<para/>
		/// EffectType: 0<para/>
		/// Type: 9990<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "RemoteProtect"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Immuneremote { get; } = new StatusEffect("Immuneremote", 9990);
		/// <summary>
		/// ImmuneExploed<para/>
		/// EffectType: 0<para/>
		/// Type: 9991<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ExploedProtect"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Immuneexploed { get; } = new StatusEffect("Immuneexploed", 9991);
		/// <summary>
		/// ImmuneTrap<para/>
		/// EffectType: 0<para/>
		/// Type: 9992<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "TrapProtect"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Immunetrap { get; } = new StatusEffect("Immunetrap", 9992);
		/// <summary>
		/// ImmuneBuff<para/>
		/// EffectType: 0<para/>
		/// Type: 9993<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ImmuneBuffNoneType"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Immunebuff { get; } = new StatusEffect("Immunebuff", 9993);
		/// <summary>
		/// ImmuneDebuff<para/>
		/// EffectType: 0<para/>
		/// Type: 9994<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ImmuneDebuffNoneType"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Immunedebuff { get; } = new StatusEffect("Immunedebuff", 9994);
		/// <summary>
		/// ImmuneBleed<para/>
		/// EffectType: 0<para/>
		/// Type: 9995<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ImmuneDebuffBleed"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Immunebleed { get; } = new StatusEffect("Immunebleed", 9995);
		/// <summary>
		/// ImmunePoison<para/>
		/// EffectType: 0<para/>
		/// Type: 9996<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ImmuneDebuffPoison"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Immunepoison { get; } = new StatusEffect("Immunepoison", 9996);
		/// <summary>
		/// Unlimited build distance.<para/>
		/// EffectType: 0<para/>
		/// Type: 9997<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "PlacedDistance"<para/>
		/// EffectValue0: 10<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect GodBuildingMode { get; } = new StatusEffect("GodBuildingMode", 9997);
		/// <summary>
		/// Your body is still stiff and with no sense of pain.<para/>
		/// EffectType: 0<para/>
		/// Type: 9998<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: 5000<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: 5<para/>
		/// BackGround: "GameUI/UI-Buff-09"<para/>
		/// TimeProgress: "GameUI/UI-Buff-10"<para/>
		/// Icon: "BuffIcon/28"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Cloning { get; } = new StatusEffect("Cloning", 9998);
		/// <summary>
		/// You're the god.<para/>
		/// EffectType: 0<para/>
		/// Type: 9999<para/>
		/// Level: 1<para/>
		/// CanClean: 1<para/>
		/// Visable: 1<para/>
		/// EffectId0: 4<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 1000<para/>
		/// EffectId1: 1<para/>
		/// Target1: "DefenceAddValue"<para/>
		/// EffectValue1: 999<para/>
		/// EffectId2: 4<para/>
		/// Target2: "Hunger"<para/>
		/// EffectValue2: 3000<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect GodMode { get; } = new StatusEffect("GodMode", 9999);
		/// <summary>
		/// Gathering speed and eating speed both increase by 100%.<para/>
		/// EffectType: 0<para/>
		/// Type: 10001<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "EatingSpeed2"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 1<para/>
		/// Target1: "GatheringSpeed2"<para/>
		/// EffectValue1: 1<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect10001 { get; } = new StatusEffect("Effect10001", 10001);
		/// <summary>
		/// Attack increase by 1 points and attack increase by 10%.<para/>
		/// EffectType: 0<para/>
		/// Type: 10002<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackMultiplierVaule"<para/>
		/// EffectValue0: 0.1<para/>
		/// EffectId1: 1<para/>
		/// Target1: "AttackAddValue"<para/>
		/// EffectValue1: 1<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect10002 { get; } = new StatusEffect("Effect10002", 10002);
		/// <summary>
		/// Walking speed increase by 10% and attack speed increase by 6%.<para/>
		/// EffectType: 0<para/>
		/// Type: 10003<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.1<para/>
		/// EffectId1: 1<para/>
		/// Target1: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue1: 0.06<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect10003 { get; } = new StatusEffect("Effect10003", 10003);
		/// <summary>
		/// Walking speed increase by 15%.<para/>
		/// EffectType: 0<para/>
		/// Type: 10004<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.15<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect10004 { get; } = new StatusEffect("Effect10004", 10004);
		/// <summary>
		/// Attack speed increase by 10%.<para/>
		/// EffectType: 0<para/>
		/// Type: 10005<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect10005 { get; } = new StatusEffect("Effect10005", 10005);
		/// <summary>
		/// Attack increase by 7% and defense increase by 14%.<para/>
		/// EffectType: 0<para/>
		/// Type: 10006<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackMultiplierVaule"<para/>
		/// EffectValue0: 0.07<para/>
		/// EffectId1: 1<para/>
		/// Target1: "DefenceMultiplierVaule"<para/>
		/// EffectValue1: 0.14<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect10006 { get; } = new StatusEffect("Effect10006", 10006);
		/// <summary>
		/// Restore 1 HP for every two seconds.<para/>
		/// EffectType: 0<para/>
		/// Type: 10007<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 2<para/>
		/// Target0: "Hp"<para/>
		/// EffectValue0: 50<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect10007 { get; } = new StatusEffect("Effect10007", 10007);
		/// <summary>
		/// Defense increase by 3 points and defense increase by 20%.<para/>
		/// EffectType: 0<para/>
		/// Type: 10008<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceMultiplierVaule"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 1<para/>
		/// Target1: "DefenceAddValue"<para/>
		/// EffectValue1: 3<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect10008 { get; } = new StatusEffect("Effect10008", 10008);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20001<para/>
		/// Level: 1<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackMultiplierVaule"<para/>
		/// EffectValue0: 0.05<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20001 { get; } = new StatusEffect("Effect20001", 20001);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20001<para/>
		/// Level: 2<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackMultiplierVaule"<para/>
		/// EffectValue0: 0.1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20002 { get; } = new StatusEffect("Effect20002", 20002);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20001<para/>
		/// Level: 3<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackMultiplierVaule"<para/>
		/// EffectValue0: 0.15<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20003 { get; } = new StatusEffect("Effect20003", 20003);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20001<para/>
		/// Level: 4<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackMultiplierVaule"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20004 { get; } = new StatusEffect("Effect20004", 20004);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20005<para/>
		/// Level: 1<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackAddValue"<para/>
		/// EffectValue0: 2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20005 { get; } = new StatusEffect("Effect20005", 20005);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20005<para/>
		/// Level: 2<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackAddValue"<para/>
		/// EffectValue0: 3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20006 { get; } = new StatusEffect("Effect20006", 20006);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20005<para/>
		/// Level: 3<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackAddValue"<para/>
		/// EffectValue0: 5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20007 { get; } = new StatusEffect("Effect20007", 20007);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20005<para/>
		/// Level: 4<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AttackAddValue"<para/>
		/// EffectValue0: 7<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20008 { get; } = new StatusEffect("Effect20008", 20008);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20009<para/>
		/// Level: 1<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "WeaponDecDurability"<para/>
		/// EffectValue0: -0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20009 { get; } = new StatusEffect("Effect20009", 20009);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20009<para/>
		/// Level: 2<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "WeaponDecDurability"<para/>
		/// EffectValue0: -0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20010 { get; } = new StatusEffect("Effect20010", 20010);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20009<para/>
		/// Level: 3<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "WeaponDecDurability"<para/>
		/// EffectValue0: -0.4<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20011 { get; } = new StatusEffect("Effect20011", 20011);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20009<para/>
		/// Level: 4<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "WeaponDecDurability"<para/>
		/// EffectValue0: -0.5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20012 { get; } = new StatusEffect("Effect20012", 20012);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20013<para/>
		/// Level: 1<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoreDropFromMonster"<para/>
		/// EffectValue0: 0.1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20013 { get; } = new StatusEffect("Effect20013", 20013);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20013<para/>
		/// Level: 2<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoreDropFromMonster"<para/>
		/// EffectValue0: 0.15<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20014 { get; } = new StatusEffect("Effect20014", 20014);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20013<para/>
		/// Level: 3<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoreDropFromMonster"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20015 { get; } = new StatusEffect("Effect20015", 20015);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20013<para/>
		/// Level: 4<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoreDropFromMonster"<para/>
		/// EffectValue0: 0.25<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20016 { get; } = new StatusEffect("Effect20016", 20016);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20017<para/>
		/// Level: 4<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoreDropFromMine"<para/>
		/// EffectValue0: 0.1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/2"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20017 { get; } = new StatusEffect("Effect20017", 20017);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20017<para/>
		/// Level: 4<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoreDropFromMine"<para/>
		/// EffectValue0: 0.15<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/3"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20018 { get; } = new StatusEffect("Effect20018", 20018);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20017<para/>
		/// Level: 4<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoreDropFromMine"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/4"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20019 { get; } = new StatusEffect("Effect20019", 20019);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20017<para/>
		/// Level: 4<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoreDropFromMine"<para/>
		/// EffectValue0: 0.25<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/5"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20020 { get; } = new StatusEffect("Effect20020", 20020);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20021<para/>
		/// Level: 1<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "IgnoreDefence"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20021 { get; } = new StatusEffect("Effect20021", 20021);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20021<para/>
		/// Level: 2<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "IgnoreDefence"<para/>
		/// EffectValue0: 0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20022 { get; } = new StatusEffect("Effect20022", 20022);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20021<para/>
		/// Level: 3<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "IgnoreDefence"<para/>
		/// EffectValue0: 0.4<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20023 { get; } = new StatusEffect("Effect20023", 20023);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20021<para/>
		/// Level: 4<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "IgnoreDefence"<para/>
		/// EffectValue0: 0.5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20024 { get; } = new StatusEffect("Effect20024", 20024);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20025<para/>
		/// Level: 1<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ExPenetrate"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20025 { get; } = new StatusEffect("Effect20025", 20025);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20025<para/>
		/// Level: 2<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ExPenetrate"<para/>
		/// EffectValue0: 0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20026 { get; } = new StatusEffect("Effect20026", 20026);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20025<para/>
		/// Level: 3<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ExPenetrate"<para/>
		/// EffectValue0: 0.4<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20027 { get; } = new StatusEffect("Effect20027", 20027);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20025<para/>
		/// Level: 4<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ExPenetrate"<para/>
		/// EffectValue0: 0.5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20028 { get; } = new StatusEffect("Effect20028", 20028);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20029<para/>
		/// Level: 1<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ExKnockBackValue"<para/>
		/// EffectValue0: 80<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20029 { get; } = new StatusEffect("Effect20029", 20029);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20029<para/>
		/// Level: 2<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ExKnockBackValue"<para/>
		/// EffectValue0: 100<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20030 { get; } = new StatusEffect("Effect20030", 20030);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20029<para/>
		/// Level: 3<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ExKnockBackValue"<para/>
		/// EffectValue0: 120<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20031 { get; } = new StatusEffect("Effect20031", 20031);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20029<para/>
		/// Level: 4<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ExKnockBackValue"<para/>
		/// EffectValue0: 140<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20032 { get; } = new StatusEffect("Effect20032", 20032);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20033<para/>
		/// Level: 1<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "SaveBulletRate"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20033 { get; } = new StatusEffect("Effect20033", 20033);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20033<para/>
		/// Level: 2<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "SaveBulletRate"<para/>
		/// EffectValue0: 0.25<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20034 { get; } = new StatusEffect("Effect20034", 20034);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20033<para/>
		/// Level: 3<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "SaveBulletRate"<para/>
		/// EffectValue0: 0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20035 { get; } = new StatusEffect("Effect20035", 20035);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20033<para/>
		/// Level: 4<para/>
		/// CanClean: 3<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "SaveBulletRate"<para/>
		/// EffectValue0: 0.35<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20036 { get; } = new StatusEffect("Effect20036", 20036);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20037<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: 2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20037 { get; } = new StatusEffect("Effect20037", 20037);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20037<para/>
		/// Level: 2<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: 4<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20038 { get; } = new StatusEffect("Effect20038", 20038);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20037<para/>
		/// Level: 3<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: 6<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20039 { get; } = new StatusEffect("Effect20039", 20039);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20037<para/>
		/// Level: 4<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceAddValue"<para/>
		/// EffectValue0: 8<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20040 { get; } = new StatusEffect("Effect20040", 20040);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20041<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ExDamageResistance"<para/>
		/// EffectValue0: 0.06<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20041 { get; } = new StatusEffect("Effect20041", 20041);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20041<para/>
		/// Level: 2<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ExDamageResistance"<para/>
		/// EffectValue0: 0.09<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20042 { get; } = new StatusEffect("Effect20042", 20042);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20041<para/>
		/// Level: 3<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ExDamageResistance"<para/>
		/// EffectValue0: 0.12<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20043 { get; } = new StatusEffect("Effect20043", 20043);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20041<para/>
		/// Level: 4<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ExDamageResistance"<para/>
		/// EffectValue0: 0.15<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20044 { get; } = new StatusEffect("Effect20044", 20044);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20045<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ArmourDecDurability"<para/>
		/// EffectValue0: -0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20045 { get; } = new StatusEffect("Effect20045", 20045);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20045<para/>
		/// Level: 2<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ArmourDecDurability"<para/>
		/// EffectValue0: -0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20046 { get; } = new StatusEffect("Effect20046", 20046);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20045<para/>
		/// Level: 3<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ArmourDecDurability"<para/>
		/// EffectValue0: -0.4<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20047 { get; } = new StatusEffect("Effect20047", 20047);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20045<para/>
		/// Level: 4<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ArmourDecDurability"<para/>
		/// EffectValue0: -0.5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20048 { get; } = new StatusEffect("Effect20048", 20048);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20049<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceMultiplierVaule"<para/>
		/// EffectValue0: 0.15<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20049 { get; } = new StatusEffect("Effect20049", 20049);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20049<para/>
		/// Level: 2<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceMultiplierVaule"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20050 { get; } = new StatusEffect("Effect20050", 20050);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20049<para/>
		/// Level: 3<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceMultiplierVaule"<para/>
		/// EffectValue0: 0.25<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20051 { get; } = new StatusEffect("Effect20051", 20051);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20049<para/>
		/// Level: 4<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "DefenceMultiplierVaule"<para/>
		/// EffectValue0: 0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20052 { get; } = new StatusEffect("Effect20052", 20052);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20053<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ExResKnockBack"<para/>
		/// EffectValue0: 0.25<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20053 { get; } = new StatusEffect("Effect20053", 20053);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20053<para/>
		/// Level: 2<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ExResKnockBack"<para/>
		/// EffectValue0: 0.5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20054 { get; } = new StatusEffect("Effect20054", 20054);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20053<para/>
		/// Level: 3<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ExResKnockBack"<para/>
		/// EffectValue0: 0.75<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20055 { get; } = new StatusEffect("Effect20055", 20055);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20053<para/>
		/// Level: 4<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ExResKnockBack"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20056 { get; } = new StatusEffect("Effect20056", 20056);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20057<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ExploedProtect"<para/>
		/// EffectValue0: 0.15<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20057 { get; } = new StatusEffect("Effect20057", 20057);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20057<para/>
		/// Level: 2<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ExploedProtect"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20058 { get; } = new StatusEffect("Effect20058", 20058);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20057<para/>
		/// Level: 3<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ExploedProtect"<para/>
		/// EffectValue0: 0.25<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20059 { get; } = new StatusEffect("Effect20059", 20059);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20057<para/>
		/// Level: 4<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ExploedProtect"<para/>
		/// EffectValue0: 0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20060 { get; } = new StatusEffect("Effect20060", 20060);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20061<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "RemoteProtect"<para/>
		/// EffectValue0: 0.15<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20061 { get; } = new StatusEffect("Effect20061", 20061);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20061<para/>
		/// Level: 2<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "RemoteProtect"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20062 { get; } = new StatusEffect("Effect20062", 20062);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20061<para/>
		/// Level: 3<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "RemoteProtect"<para/>
		/// EffectValue0: 0.25<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20063 { get; } = new StatusEffect("Effect20063", 20063);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20061<para/>
		/// Level: 4<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "RemoteProtect"<para/>
		/// EffectValue0: 0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20064 { get; } = new StatusEffect("Effect20064", 20064);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20045<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "HandDecDurability"<para/>
		/// EffectValue0: -0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20065 { get; } = new StatusEffect("Effect20065", 20065);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20045<para/>
		/// Level: 2<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "HandDecDurability"<para/>
		/// EffectValue0: -0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20066 { get; } = new StatusEffect("Effect20066", 20066);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20045<para/>
		/// Level: 3<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "HandDecDurability"<para/>
		/// EffectValue0: -0.4<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20067 { get; } = new StatusEffect("Effect20067", 20067);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20045<para/>
		/// Level: 4<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "HandDecDurability"<para/>
		/// EffectValue0: -0.5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20068 { get; } = new StatusEffect("Effect20068", 20068);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20065<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "EatingSpeed2"<para/>
		/// EffectValue0: 0.4<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20069 { get; } = new StatusEffect("Effect20069", 20069);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20065<para/>
		/// Level: 2<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "EatingSpeed2"<para/>
		/// EffectValue0: 0.6<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20070 { get; } = new StatusEffect("Effect20070", 20070);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20065<para/>
		/// Level: 3<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "EatingSpeed2"<para/>
		/// EffectValue0: 0.8<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20071 { get; } = new StatusEffect("Effect20071", 20071);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20065<para/>
		/// Level: 4<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "EatingSpeed2"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20072 { get; } = new StatusEffect("Effect20072", 20072);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20069<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "GatheringSpeed2"<para/>
		/// EffectValue0: 0.4<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20073 { get; } = new StatusEffect("Effect20073", 20073);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20069<para/>
		/// Level: 2<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "GatheringSpeed2"<para/>
		/// EffectValue0: 0.6<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20074 { get; } = new StatusEffect("Effect20074", 20074);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20069<para/>
		/// Level: 3<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "GatheringSpeed2"<para/>
		/// EffectValue0: 0.8<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20075 { get; } = new StatusEffect("Effect20075", 20075);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20069<para/>
		/// Level: 4<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "GatheringSpeed2"<para/>
		/// EffectValue0: 1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20076 { get; } = new StatusEffect("Effect20076", 20076);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20073<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AxeAttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.15<para/>
		/// EffectId1: 1<para/>
		/// Target1: "PickaxeAttackSpeedMultiplierVaule"<para/>
		/// EffectValue1: 0.15<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20077 { get; } = new StatusEffect("Effect20077", 20077);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20073<para/>
		/// Level: 2<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AxeAttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 1<para/>
		/// Target1: "PickaxeAttackSpeedMultiplierVaule"<para/>
		/// EffectValue1: 0.2<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20078 { get; } = new StatusEffect("Effect20078", 20078);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20073<para/>
		/// Level: 3<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AxeAttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.25<para/>
		/// EffectId1: 1<para/>
		/// Target1: "PickaxeAttackSpeedMultiplierVaule"<para/>
		/// EffectValue1: 0.25<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20079 { get; } = new StatusEffect("Effect20079", 20079);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20073<para/>
		/// Level: 4<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "AxeAttackSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.3<para/>
		/// EffectId1: 1<para/>
		/// Target1: "PickaxeAttackSpeedMultiplierVaule"<para/>
		/// EffectValue1: 0.3<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20080 { get; } = new StatusEffect("Effect20080", 20080);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20045<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ShoesDecDurability"<para/>
		/// EffectValue0: -0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20081 { get; } = new StatusEffect("Effect20081", 20081);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20045<para/>
		/// Level: 2<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ShoesDecDurability"<para/>
		/// EffectValue0: -0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20082 { get; } = new StatusEffect("Effect20082", 20082);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20045<para/>
		/// Level: 3<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ShoesDecDurability"<para/>
		/// EffectValue0: -0.4<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20083 { get; } = new StatusEffect("Effect20083", 20083);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20045<para/>
		/// Level: 4<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "ShoesDecDurability"<para/>
		/// EffectValue0: -0.5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20084 { get; } = new StatusEffect("Effect20084", 20084);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20077<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20085 { get; } = new StatusEffect("Effect20085", 20085);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20077<para/>
		/// Level: 2<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.15<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20086 { get; } = new StatusEffect("Effect20086", 20086);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20077<para/>
		/// Level: 3<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20087 { get; } = new StatusEffect("Effect20087", 20087);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20077<para/>
		/// Level: 4<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "MoveSpeedMultiplierVaule"<para/>
		/// EffectValue0: 0.25<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20088 { get; } = new StatusEffect("Effect20088", 20088);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20081<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "HungerDecMultiplierVaule"<para/>
		/// EffectValue0: -0.1<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20089 { get; } = new StatusEffect("Effect20089", 20089);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20081<para/>
		/// Level: 2<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "HungerDecMultiplierVaule"<para/>
		/// EffectValue0: -0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20090 { get; } = new StatusEffect("Effect20090", 20090);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20081<para/>
		/// Level: 3<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "HungerDecMultiplierVaule"<para/>
		/// EffectValue0: -0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20091 { get; } = new StatusEffect("Effect20091", 20091);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20081<para/>
		/// Level: 4<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "HungerDecMultiplierVaule"<para/>
		/// EffectValue0: -0.4<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20092 { get; } = new StatusEffect("Effect20092", 20092);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20085<para/>
		/// Level: 1<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "TrapProtect"<para/>
		/// EffectValue0: 0.2<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20093 { get; } = new StatusEffect("Effect20093", 20093);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20085<para/>
		/// Level: 2<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "TrapProtect"<para/>
		/// EffectValue0: 0.3<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20094 { get; } = new StatusEffect("Effect20094", 20094);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20085<para/>
		/// Level: 3<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "TrapProtect"<para/>
		/// EffectValue0: 0.4<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20095 { get; } = new StatusEffect("Effect20095", 20095);
		/// <summary>
		/// EffectType: 0<para/>
		/// Type: 20085<para/>
		/// Level: 4<para/>
		/// CanClean: 2<para/>
		/// Visable: 2<para/>
		/// EffectId0: 1<para/>
		/// Target0: "TrapProtect"<para/>
		/// EffectValue0: 0.5<para/>
		/// EffectId1: 0<para/>
		/// Target1: "0"<para/>
		/// EffectValue1: 0<para/>
		/// EffectId2: 0<para/>
		/// Target2: "0"<para/>
		/// EffectValue2: 0<para/>
		/// DurationTime: -1<para/>
		/// BackGround: "GameUI/UI-Buff-03"<para/>
		/// TimeProgress: "GameUI/UI-Buff-07"<para/>
		/// Icon: "BuffIcon/1"<para/>
		/// BuffParticle: "0"<para/>
		/// BuffParticleTexture: "0"<para/>
		/// </summary>
		public static StatusEffect Effect20096 { get; } = new StatusEffect("Effect20096", 20096);
	}
}
