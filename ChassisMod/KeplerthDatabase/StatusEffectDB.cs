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
		/// If you don't eat something, you will starve to death!<para/>
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
		public static StatusEffect HungerDiscarded { get; } = new StatusEffect("HungerDiscarded", 104);
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
		/// Goblin accelerates to escape<para/>
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
		/// Test BUFF<para/>
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
		public static StatusEffect TestTheAttackToTheTargetBUFF { get; } = new StatusEffect("TestTheAttackToTheTargetBUFF", 1001);
		/// <summary>
		/// Test BUFF<para/>
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
		public static StatusEffect TestTheAttackToYourselfBUFF { get; } = new StatusEffect("TestTheAttackToYourselfBUFF", 1002);
		/// <summary>
		/// Test BUFF<para/>
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
		public static StatusEffect TestDoesNotDisplayBUFF { get; } = new StatusEffect("TestDoesNotDisplayBUFF", 1003);
		/// <summary>
		/// Test BUFF<para/>
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
		public static StatusEffect TestDoesNotClearBUFF { get; } = new StatusEffect("TestDoesNotClearBUFF", 1004);
		/// <summary>
		/// Test BUFF<para/>
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
		public static StatusEffect TestUnlimitedBUFF { get; } = new StatusEffect("TestUnlimitedBUFF", 1005);
		/// <summary>
		/// Remote weapon limit DEBUFF<para/>
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
		public static StatusEffect LongRangeWeaponAttackSlowdown { get; } = new StatusEffect("LongRangeWeaponAttackSlowdown", 2001);
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
		/// Remote weapon limit DEBUFF<para/>
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
		public static StatusEffect GatlinCompletelySlowsDown { get; } = new StatusEffect("GatlinCompletelySlowsDown", 2004);
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
		public static StatusEffect SlowReturnOfPets { get; } = new StatusEffect("SlowReturnOfPets", 2005);
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
		public static StatusEffect IncreaseCollectionEfficiencyBy50 { get; } = new StatusEffect("IncreaseCollectionEfficiencyBy50", 5001);
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
		public static StatusEffect IncreaseCollectionEfficiencyBy100 { get; } = new StatusEffect("IncreaseCollectionEfficiencyBy100", 5002);
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
		public static StatusEffect IncreaseCollectionEfficiencyBy200 { get; } = new StatusEffect("IncreaseCollectionEfficiencyBy200", 5003);
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
		public static StatusEffect FasterEating0 { get; } = new StatusEffect("FasterEating0", 5011);
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
		public static StatusEffect FasterEating1 { get; } = new StatusEffect("FasterEating1", 5012);
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
		public static StatusEffect FasterEating2 { get; } = new StatusEffect("FasterEating2", 5013);
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
		public static StatusEffect IfYouAreNotAttackedOrInjuredWithin5SecondsYouWillEnterStealth { get; } = new StatusEffect("IfYouAreNotAttackedOrInjuredWithin5SecondsYouWillEnterStealth", 5021);
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
		public static StatusEffect IncreaseTheRepellingAbilityOfMeleeAttacksBy50 { get; } = new StatusEffect("IncreaseTheRepellingAbilityOfMeleeAttacksBy50", 5031);
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
		public static StatusEffect FasterMovement0 { get; } = new StatusEffect("FasterMovement0", 5041);
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
		public static StatusEffect IncreasedMovementSpeedBy15 { get; } = new StatusEffect("IncreasedMovementSpeedBy15", 5042);
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
		public static StatusEffect FasterMovement1 { get; } = new StatusEffect("FasterMovement1", 5043);
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
		public static StatusEffect FasterMovement2 { get; } = new StatusEffect("FasterMovement2", 5044);
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
		public static StatusEffect FasterMovement3 { get; } = new StatusEffect("FasterMovement3", 5045);
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
		public static StatusEffect PressTheArrowKeysContinuouslyToSprintAShortDistance { get; } = new StatusEffect("PressTheArrowKeysContinuouslyToSprintAShortDistance", 5051);
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
		public static StatusEffect YourAttackPoisonsTheEnemy { get; } = new StatusEffect("YourAttackPoisonsTheEnemy", 5061);
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
		public static StatusEffect IlluminateTheFrontConeView { get; } = new StatusEffect("IlluminateTheFrontConeView", 5071);
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
		public static StatusEffect Reduces15OfRemoteDamage { get; } = new StatusEffect("Reduces15OfRemoteDamage", 5081);
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
		public static StatusEffect Reduce20OfRemoteDamage { get; } = new StatusEffect("Reduce20OfRemoteDamage", 5082);
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
		public static StatusEffect Reduces25OfRemoteDamage { get; } = new StatusEffect("Reduces25OfRemoteDamage", 5083);
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
		public static StatusEffect Reduce30OfRemoteDamage { get; } = new StatusEffect("Reduce30OfRemoteDamage", 5084);
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
		public static StatusEffect TheCreatureBeingHitHasAChanceToEscapeFor2Seconds { get; } = new StatusEffect("TheCreatureBeingHitHasAChanceToEscapeFor2Seconds", 5091);
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
		public static StatusEffect DefenseIncrease2 { get; } = new StatusEffect("DefenseIncrease2", 5101);
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
		public static StatusEffect DefenseIncrease4 { get; } = new StatusEffect("DefenseIncrease4", 5102);
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
		public static StatusEffect DefenseIncrease6 { get; } = new StatusEffect("DefenseIncrease6", 5103);
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
		public static StatusEffect DefenseIncreased8 { get; } = new StatusEffect("DefenseIncreased8", 5104);
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
		public static StatusEffect DefenseIncreasedBy10 { get; } = new StatusEffect("DefenseIncreasedBy10", 5105);
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
		public static StatusEffect HitTheProbabilityToConfuseTheEnemyAndFightForYouFor3Seconds { get; } = new StatusEffect("HitTheProbabilityToConfuseTheEnemyAndFightForYouFor3Seconds", 5111);
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
		public static StatusEffect ReducePoisoningDurationBy50 { get; } = new StatusEffect("ReducePoisoningDurationBy50", 5121);
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
		public static StatusEffect ReduceBleedingDurationBy50 { get; } = new StatusEffect("ReduceBleedingDurationBy50", 5131);
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
		public static StatusEffect DoNotDropItemsWhenYouDieConsumeAfterDeath { get; } = new StatusEffect("DoNotDropItemsWhenYouDieConsumeAfterDeath", 5141);
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
		public static StatusEffect RestoresYourBloodTo30And5SecondsInvincibleWhenYouAreDealtLethalDamage { get; } = new StatusEffect("RestoresYourBloodTo30And5SecondsInvincibleWhenYouAreDealtLethalDamage", 5151);
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
		public static StatusEffect ProbabilityDoesNotConsumeEnergyWhenUsingEnergyWeapons { get; } = new StatusEffect("ProbabilityDoesNotConsumeEnergyWhenUsingEnergyWeapons", 5161);
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
		public static StatusEffect Restore1LifePerSecond { get; } = new StatusEffect("Restore1LifePerSecond", 5171);
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
		public static StatusEffect Restore2LivesPerSecond { get; } = new StatusEffect("Restore2LivesPerSecond", 5172);
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
		public static StatusEffect ReleaseAFireflyThatSlightlyIlluminatesTheAreaAroundYou { get; } = new StatusEffect("ReleaseAFireflyThatSlightlyIlluminatesTheAreaAroundYou", 5181);
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
		public static StatusEffect IncreaseAttackSpeedBy10 { get; } = new StatusEffect("IncreaseAttackSpeedBy10", 5191);
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
		public static StatusEffect IncreaseAttackSpeedBy15 { get; } = new StatusEffect("IncreaseAttackSpeedBy15", 5192);
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
		public static StatusEffect IncreaseAttackSpeedBy20 { get; } = new StatusEffect("IncreaseAttackSpeedBy20", 5193);
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
		public static StatusEffect IncreaseAttackSpeedBy25 { get; } = new StatusEffect("IncreaseAttackSpeedBy25", 5194);
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
		public static StatusEffect IncreaseAttackSpeedBy30 { get; } = new StatusEffect("IncreaseAttackSpeedBy30", 5195);
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
		public static StatusEffect ImproveMeleeAttackDamage1 { get; } = new StatusEffect("ImproveMeleeAttackDamage1", 5201);
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
		public static StatusEffect ImproveMeleeAttackDamage3 { get; } = new StatusEffect("ImproveMeleeAttackDamage3", 5202);
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
		public static StatusEffect ImproveMeleeAttackDamage5 { get; } = new StatusEffect("ImproveMeleeAttackDamage5", 5203);
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
		public static StatusEffect ImproveMeleeAttackDamage7 { get; } = new StatusEffect("ImproveMeleeAttackDamage7", 5204);
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
		public static StatusEffect ImproveMeleeAttackDamage10 { get; } = new StatusEffect("ImproveMeleeAttackDamage10", 5205);
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
		public static StatusEffect AttackDamageIncreasedBy10 { get; } = new StatusEffect("AttackDamageIncreasedBy10", 5211);
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
		public static StatusEffect AttackDamageIncreasedBy15 { get; } = new StatusEffect("AttackDamageIncreasedBy15", 5212);
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
		public static StatusEffect AttackDamageIncreasedBy20 { get; } = new StatusEffect("AttackDamageIncreasedBy20", 5213);
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
		public static StatusEffect AttackDamageIncreasedBy25 { get; } = new StatusEffect("AttackDamageIncreasedBy25", 5214);
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
		public static StatusEffect AttackDamageIncreasedBy30 { get; } = new StatusEffect("AttackDamageIncreasedBy30", 5215);
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
		public static StatusEffect DurableProtection20 { get; } = new StatusEffect("DurableProtection20", 5216);
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
		public static StatusEffect DurableProtection25 { get; } = new StatusEffect("DurableProtection25", 5217);
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
		public static StatusEffect DurableProtection30 { get; } = new StatusEffect("DurableProtection30", 5218);
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
		public static StatusEffect DurableProtection35 { get; } = new StatusEffect("DurableProtection35", 5219);
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
		public static StatusEffect DurableProtection40 { get; } = new StatusEffect("DurableProtection40", 5220);
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
		public static StatusEffect ReduceHungerConsumptionBy20 { get; } = new StatusEffect("ReduceHungerConsumptionBy20", 5221);
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
		public static StatusEffect HungerConsumptionReducedBy25 { get; } = new StatusEffect("HungerConsumptionReducedBy25", 5222);
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
		public static StatusEffect ReduceHungerConsumptionBy30 { get; } = new StatusEffect("ReduceHungerConsumptionBy30", 5223);
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
		public static StatusEffect ReducedHungerConsumptionBy35 { get; } = new StatusEffect("ReducedHungerConsumptionBy35", 5224);
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
		public static StatusEffect ReducedHungerConsumptionBy40 { get; } = new StatusEffect("ReducedHungerConsumptionBy40", 5225);
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
		public static StatusEffect ConstructionDistance3 { get; } = new StatusEffect("ConstructionDistance3", 5226);
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
		public static StatusEffect ConstructionDistance4 { get; } = new StatusEffect("ConstructionDistance4", 5227);
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
		public static StatusEffect ConstructionDistance5 { get; } = new StatusEffect("ConstructionDistance5", 5228);
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
		public static StatusEffect ConstructionDistance6 { get; } = new StatusEffect("ConstructionDistance6", 5229);
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
		public static StatusEffect ConstructionDistance7 { get; } = new StatusEffect("ConstructionDistance7", 5230);
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
		public static StatusEffect WormNestBloodsuckingJewelry { get; } = new StatusEffect("WormNestBloodsuckingJewelry", 5231);
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
		public static StatusEffect WormNestPufferfish { get; } = new StatusEffect("WormNestPufferfish", 5232);
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
		public static StatusEffect Flashlight { get; } = new StatusEffect("Flashlight", 5241);
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
		public static StatusEffect MinersLamp { get; } = new StatusEffect("MinersLamp", 5242);
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
		public static StatusEffect UndergroundManShield { get; } = new StatusEffect("UndergroundManShield", 5255);
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
		public static StatusEffect UndergroundMan { get; } = new StatusEffect("UndergroundMan", 5256);
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
		public static StatusEffect BuriedDrone { get; } = new StatusEffect("BuriedDrone", 5257);
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
		public static StatusEffect HumanAdaptation { get; } = new StatusEffect("HumanAdaptation", 10001);
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
		public static StatusEffect BarbarianAnger { get; } = new StatusEffect("BarbarianAnger", 10002);
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
		public static StatusEffect HalfElfSixthSense { get; } = new StatusEffect("HalfElfSixthSense", 10003);
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
		public static StatusEffect ElfLight { get; } = new StatusEffect("ElfLight", 10004);
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
		public static StatusEffect BlackElfSwift { get; } = new StatusEffect("BlackElfSwift", 10005);
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
		public static StatusEffect HalfOrcStrong { get; } = new StatusEffect("HalfOrcStrong", 10006);
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
		public static StatusEffect MummyResurrection { get; } = new StatusEffect("MummyResurrection", 10007);
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
		public static StatusEffect WildBoarThickSkin { get; } = new StatusEffect("WildBoarThickSkin", 10008);
		/// <summary>
		/// Weapon - attack 5%<para/>
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
		public static StatusEffect WeaponAttack50 { get; } = new StatusEffect("WeaponAttack50", 20001);
		/// <summary>
		/// Weapon - attack 10%<para/>
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
		public static StatusEffect WeaponAttack10 { get; } = new StatusEffect("WeaponAttack10", 20002);
		/// <summary>
		/// Weapon - attack 15%<para/>
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
		public static StatusEffect WeaponAttack15 { get; } = new StatusEffect("WeaponAttack15", 20003);
		/// <summary>
		/// Weapon - attack 20%<para/>
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
		public static StatusEffect WeaponAttack20 { get; } = new StatusEffect("WeaponAttack20", 20004);
		/// <summary>
		/// Weapon - attack 2<para/>
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
		public static StatusEffect WeaponAttack2 { get; } = new StatusEffect("WeaponAttack2", 20005);
		/// <summary>
		/// Weapon - attack 3<para/>
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
		public static StatusEffect WeaponAttack3 { get; } = new StatusEffect("WeaponAttack3", 20006);
		/// <summary>
		/// Weapon - attack 5<para/>
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
		public static StatusEffect WeaponAttack51 { get; } = new StatusEffect("WeaponAttack51", 20007);
		/// <summary>
		/// Weapon - attack 7<para/>
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
		public static StatusEffect WeaponAttack7 { get; } = new StatusEffect("WeaponAttack7", 20008);
		/// <summary>
		/// Weapon - Durable consumption reduced by 20%<para/>
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
		public static StatusEffect WeaponDurableConsumptionReducedBy20 { get; } = new StatusEffect("WeaponDurableConsumptionReducedBy20", 20009);
		/// <summary>
		/// Weapon - Durable consumption reduced by 30%<para/>
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
		public static StatusEffect WeaponDurableConsumptionReducedBy30 { get; } = new StatusEffect("WeaponDurableConsumptionReducedBy30", 20010);
		/// <summary>
		/// Weapon - Durable consumption reduced by 40%<para/>
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
		public static StatusEffect WeaponDurableConsumptionReducedBy40 { get; } = new StatusEffect("WeaponDurableConsumptionReducedBy40", 20011);
		/// <summary>
		/// Weapon - Durable consumption reduced by 50%<para/>
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
		public static StatusEffect WeaponDurableConsumptionReducedBy50 { get; } = new StatusEffect("WeaponDurableConsumptionReducedBy50", 20012);
		/// <summary>
		/// Weapons - Kill Monsters Drop 10%<para/>
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
		public static StatusEffect WeaponsKillMonstersDrop10 { get; } = new StatusEffect("WeaponsKillMonstersDrop10", 20013);
		/// <summary>
		/// Weapon - kill monsters drop 15%<para/>
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
		public static StatusEffect WeaponKillMonstersDrop15 { get; } = new StatusEffect("WeaponKillMonstersDrop15", 20014);
		/// <summary>
		/// Weapons - Kill monsters drop 20%<para/>
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
		public static StatusEffect WeaponsKillMonstersDrop20 { get; } = new StatusEffect("WeaponsKillMonstersDrop20", 20015);
		/// <summary>
		/// Weapon - kill monsters drop 25%<para/>
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
		public static StatusEffect WeaponKillMonstersDrop25 { get; } = new StatusEffect("WeaponKillMonstersDrop25", 20016);
		/// <summary>
		/// Weapon - mineral drops 10%<para/>
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
		public static StatusEffect WeaponMineralDrops10 { get; } = new StatusEffect("WeaponMineralDrops10", 20017);
		/// <summary>
		/// Weapon - mineral drop 15%<para/>
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
		public static StatusEffect WeaponMineralDrop15 { get; } = new StatusEffect("WeaponMineralDrop15", 20018);
		/// <summary>
		/// Weapon - mineral drop 20%<para/>
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
		public static StatusEffect WeaponMineralDrop20 { get; } = new StatusEffect("WeaponMineralDrop20", 20019);
		/// <summary>
		/// Weapons - mineral drops 25%<para/>
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
		public static StatusEffect WeaponsMineralDrops25 { get; } = new StatusEffect("WeaponsMineralDrops25", 20020);
		/// <summary>
		/// Melee - ignore target defense 20%<para/>
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
		public static StatusEffect MeleeIgnoreTargetDefense20 { get; } = new StatusEffect("MeleeIgnoreTargetDefense20", 20021);
		/// <summary>
		/// Melee - ignore target defense 30%<para/>
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
		public static StatusEffect MeleeIgnoreTargetDefense30 { get; } = new StatusEffect("MeleeIgnoreTargetDefense30", 20022);
		/// <summary>
		/// Melee - ignore target defense 40%<para/>
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
		public static StatusEffect MeleeIgnoreTargetDefense40 { get; } = new StatusEffect("MeleeIgnoreTargetDefense40", 20023);
		/// <summary>
		/// Melee - ignore target defense 50%<para/>
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
		public static StatusEffect MeleeIgnoreTargetDefense50 { get; } = new StatusEffect("MeleeIgnoreTargetDefense50", 20024);
		/// <summary>
		/// Remote-probability penetration 20%<para/>
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
		public static StatusEffect RemoteProbabilityPenetration20 { get; } = new StatusEffect("RemoteProbabilityPenetration20", 20025);
		/// <summary>
		/// Remote-probability penetration 30%<para/>
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
		public static StatusEffect RemoteProbabilityPenetration30 { get; } = new StatusEffect("RemoteProbabilityPenetration30", 20026);
		/// <summary>
		/// Remote-probability penetration 40%<para/>
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
		public static StatusEffect RemoteProbabilityPenetration40 { get; } = new StatusEffect("RemoteProbabilityPenetration40", 20027);
		/// <summary>
		/// Remote-probability penetration 50%<para/>
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
		public static StatusEffect RemoteProbabilityPenetration50 { get; } = new StatusEffect("RemoteProbabilityPenetration50", 20028);
		/// <summary>
		/// Remote - Repel 100<para/>
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
		public static StatusEffect RemoteRepel80 { get; } = new StatusEffect("RemoteRepel80", 20029);
		/// <summary>
		/// Remote - Repel 130<para/>
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
		public static StatusEffect RemoteRepel100 { get; } = new StatusEffect("RemoteRepel100", 20030);
		/// <summary>
		/// Remote - Repel 160<para/>
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
		public static StatusEffect RemoteRepel120 { get; } = new StatusEffect("RemoteRepel120", 20031);
		/// <summary>
		/// Remote - Repel 190<para/>
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
		public static StatusEffect RemoteRepel140 { get; } = new StatusEffect("RemoteRepel140", 20032);
		/// <summary>
		/// Bow Gun - Probability does not consume 20% of ammunition<para/>
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
		public static StatusEffect BowGunProbabilityDoesNotConsume20OfAmmunition { get; } = new StatusEffect("BowGunProbabilityDoesNotConsume20OfAmmunition", 20033);
		/// <summary>
		/// Bow Gun - Probability does not consume 25% of ammunition<para/>
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
		public static StatusEffect BowGunProbabilityDoesNotConsume25OfAmmunition { get; } = new StatusEffect("BowGunProbabilityDoesNotConsume25OfAmmunition", 20034);
		/// <summary>
		/// Bow Gun - Probability does not consume ammunition 30%<para/>
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
		public static StatusEffect BowGunProbabilityDoesNotConsumeAmmunition30 { get; } = new StatusEffect("BowGunProbabilityDoesNotConsumeAmmunition30", 20035);
		/// <summary>
		/// Bow Gun - Probability does not consume 35% of ammunition<para/>
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
		public static StatusEffect BowGunProbabilityDoesNotConsume35OfAmmunition { get; } = new StatusEffect("BowGunProbabilityDoesNotConsume35OfAmmunition", 20036);
		/// <summary>
		/// Armor - Defense 2<para/>
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
		public static StatusEffect ArmorDefense2 { get; } = new StatusEffect("ArmorDefense2", 20037);
		/// <summary>
		/// Armor - Defense 4<para/>
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
		public static StatusEffect ArmorDefense4 { get; } = new StatusEffect("ArmorDefense4", 20038);
		/// <summary>
		/// Armor - Defense 6<para/>
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
		public static StatusEffect ArmorDefense6 { get; } = new StatusEffect("ArmorDefense6", 20039);
		/// <summary>
		/// Armor - Defense 8<para/>
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
		public static StatusEffect ArmorDefense8 { get; } = new StatusEffect("ArmorDefense8", 20040);
		/// <summary>
		/// Armor - damage reduced by 6%<para/>
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
		public static StatusEffect ArmorDamageReducedBy6 { get; } = new StatusEffect("ArmorDamageReducedBy6", 20041);
		/// <summary>
		/// Armor - damage reduced by 9%<para/>
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
		public static StatusEffect ArmorDamageReducedBy9 { get; } = new StatusEffect("ArmorDamageReducedBy9", 20042);
		/// <summary>
		/// Armor - Damage reduced by 12%<para/>
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
		public static StatusEffect ArmorDamageReducedBy12 { get; } = new StatusEffect("ArmorDamageReducedBy12", 20043);
		/// <summary>
		/// Armor - damage reduced by 15%<para/>
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
		public static StatusEffect ArmorDamageReducedBy15 { get; } = new StatusEffect("ArmorDamageReducedBy15", 20044);
		/// <summary>
		/// Clothes - slow down the endurance consumption by 20%<para/>
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
		public static StatusEffect ClothesSlowDownTheEnduranceConsumptionBy20 { get; } = new StatusEffect("ClothesSlowDownTheEnduranceConsumptionBy20", 20045);
		/// <summary>
		/// Clothes - 30% reduction in endurance consumption<para/>
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
		public static StatusEffect Clothes30ReductionInEnduranceConsumption { get; } = new StatusEffect("Clothes30ReductionInEnduranceConsumption", 20046);
		/// <summary>
		/// Clothes - 40% reduction in endurance consumption<para/>
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
		public static StatusEffect Clothes40ReductionInEnduranceConsumption { get; } = new StatusEffect("Clothes40ReductionInEnduranceConsumption", 20047);
		/// <summary>
		/// Clothes - slow down the endurance consumption by 50%<para/>
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
		public static StatusEffect ClothesSlowDownTheEnduranceConsumptionBy50 { get; } = new StatusEffect("ClothesSlowDownTheEnduranceConsumptionBy50", 20048);
		/// <summary>
		/// Clothes - Defense increased by 15%<para/>
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
		public static StatusEffect ClothesDefenseIncreasedBy15 { get; } = new StatusEffect("ClothesDefenseIncreasedBy15", 20049);
		/// <summary>
		/// Clothes - defense increased by 20%<para/>
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
		public static StatusEffect ClothesDefenseIncreasedBy20 { get; } = new StatusEffect("ClothesDefenseIncreasedBy20", 20050);
		/// <summary>
		/// Clothes - Defense increased by 25%<para/>
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
		public static StatusEffect ClothesDefenseIncreasedBy25 { get; } = new StatusEffect("ClothesDefenseIncreasedBy25", 20051);
		/// <summary>
		/// Clothes - defense increased by 30%<para/>
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
		public static StatusEffect ClothesDefenseIncreasedBy30 { get; } = new StatusEffect("ClothesDefenseIncreasedBy30", 20052);
		/// <summary>
		/// Clothes - 25% protection<para/>
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
		public static StatusEffect Clothes25Protection { get; } = new StatusEffect("Clothes25Protection", 20053);
		/// <summary>
		/// Clothes - 50% protection<para/>
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
		public static StatusEffect Clothes50Protection { get; } = new StatusEffect("Clothes50Protection", 20054);
		/// <summary>
		/// Clothes - Repel protection 75%<para/>
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
		public static StatusEffect ClothesRepelProtection75 { get; } = new StatusEffect("ClothesRepelProtection75", 20055);
		/// <summary>
		/// Clothes - Repel protection 100%<para/>
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
		public static StatusEffect ClothesRepelProtection100 { get; } = new StatusEffect("ClothesRepelProtection100", 20056);
		/// <summary>
		/// Clothes - Explosive damage reduced by 15%<para/>
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
		public static StatusEffect ClothesExplosiveDamageReducedBy15 { get; } = new StatusEffect("ClothesExplosiveDamageReducedBy15", 20057);
		/// <summary>
		/// Clothes - Explosive damage reduced by 20%<para/>
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
		public static StatusEffect ClothesExplosiveDamageReducedBy20 { get; } = new StatusEffect("ClothesExplosiveDamageReducedBy20", 20058);
		/// <summary>
		/// Clothes - Explosive damage reduced by 25%<para/>
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
		public static StatusEffect ClothesExplosiveDamageReducedBy25 { get; } = new StatusEffect("ClothesExplosiveDamageReducedBy25", 20059);
		/// <summary>
		/// Clothes - Explosive damage reduced by 30%<para/>
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
		public static StatusEffect ClothesExplosiveDamageReducedBy30 { get; } = new StatusEffect("ClothesExplosiveDamageReducedBy30", 20060);
		/// <summary>
		/// Clothes - Remote Damage reduced by 15%<para/>
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
		public static StatusEffect ClothesRemoteDamageReducedBy15 { get; } = new StatusEffect("ClothesRemoteDamageReducedBy15", 20061);
		/// <summary>
		/// Clothes - 20% reduction in range damage<para/>
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
		public static StatusEffect Clothes20ReductionInRangeDamage { get; } = new StatusEffect("Clothes20ReductionInRangeDamage", 20062);
		/// <summary>
		/// Clothes - Remote damage reduced by 25%<para/>
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
		public static StatusEffect ClothesRemoteDamageReducedBy25 { get; } = new StatusEffect("ClothesRemoteDamageReducedBy25", 20063);
		/// <summary>
		/// Clothes - Remote damage reduced by 30%<para/>
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
		public static StatusEffect ClothesRemoteDamageReducedBy30 { get; } = new StatusEffect("ClothesRemoteDamageReducedBy30", 20064);
		/// <summary>
		/// Gloves - Reduces endurance consumption by 20%<para/>
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
		public static StatusEffect GlovesReducesEnduranceConsumptionBy20 { get; } = new StatusEffect("GlovesReducesEnduranceConsumptionBy20", 20065);
		/// <summary>
		/// Gloves - Reduces endurance consumption by 30%<para/>
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
		public static StatusEffect GlovesReducesEnduranceConsumptionBy30 { get; } = new StatusEffect("GlovesReducesEnduranceConsumptionBy30", 20066);
		/// <summary>
		/// Gloves - Reduces endurance consumption by 40%<para/>
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
		public static StatusEffect GlovesReducesEnduranceConsumptionBy40 { get; } = new StatusEffect("GlovesReducesEnduranceConsumptionBy40", 20067);
		/// <summary>
		/// Gloves - Reduces endurance consumption by 50%<para/>
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
		public static StatusEffect GlovesReducesEnduranceConsumptionBy50 { get; } = new StatusEffect("GlovesReducesEnduranceConsumptionBy50", 20068);
		/// <summary>
		/// Gloves - eating up to 40% faster<para/>
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
		public static StatusEffect GlovesEatingUpTo40Faster { get; } = new StatusEffect("GlovesEatingUpTo40Faster", 20069);
		/// <summary>
		/// Gloves - 60% faster eating<para/>
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
		public static StatusEffect Gloves60FasterEating { get; } = new StatusEffect("Gloves60FasterEating", 20070);
		/// <summary>
		/// Gloves - Eat 80% faster<para/>
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
		public static StatusEffect GlovesEat80Faster { get; } = new StatusEffect("GlovesEat80Faster", 20071);
		/// <summary>
		/// Gloves - Eat 100% faster<para/>
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
		public static StatusEffect GlovesEat100Faster { get; } = new StatusEffect("GlovesEat100Faster", 20072);
		/// <summary>
		/// Gloves - Acquisition Acceleration 40%<para/>
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
		public static StatusEffect GlovesAcquisitionAcceleration40 { get; } = new StatusEffect("GlovesAcquisitionAcceleration40", 20073);
		/// <summary>
		/// Gloves - Acquisition Acceleration 60%<para/>
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
		public static StatusEffect GlovesAcquisitionAcceleration60 { get; } = new StatusEffect("GlovesAcquisitionAcceleration60", 20074);
		/// <summary>
		/// Gloves - Acquisition Acceleration 80%<para/>
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
		public static StatusEffect GlovesAcquisitionAcceleration80 { get; } = new StatusEffect("GlovesAcquisitionAcceleration80", 20075);
		/// <summary>
		/// Gloves - Acquisition Acceleration 100%<para/>
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
		public static StatusEffect GlovesAcquisitionAcceleration100 { get; } = new StatusEffect("GlovesAcquisitionAcceleration100", 20076);
		/// <summary>
		/// Gloves - Axe, 镐 attack speed increased by 15%<para/>
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
		public static StatusEffect GlovesAxeAttackSpeedIncreasedBy15 { get; } = new StatusEffect("GlovesAxeAttackSpeedIncreasedBy15", 20077);
		/// <summary>
		/// Gloves - Axe, 镐 attack speed increased by 20%<para/>
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
		public static StatusEffect GlovesAxeAttackSpeedIncreasedBy20 { get; } = new StatusEffect("GlovesAxeAttackSpeedIncreasedBy20", 20078);
		/// <summary>
		/// Gloves - Axe, 镐 attack speed increased by 25%<para/>
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
		public static StatusEffect GlovesAxeAttackSpeedIncreasedBy25 { get; } = new StatusEffect("GlovesAxeAttackSpeedIncreasedBy25", 20079);
		/// <summary>
		/// Gloves - Axe, 镐 attack speed increased by 30%<para/>
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
		public static StatusEffect GlovesAxeAttackSpeedIncreasedBy30 { get; } = new StatusEffect("GlovesAxeAttackSpeedIncreasedBy30", 20080);
		/// <summary>
		/// Shoes - slow down endurance consumption by 20%<para/>
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
		public static StatusEffect ShoesSlowDownEnduranceConsumptionBy20 { get; } = new StatusEffect("ShoesSlowDownEnduranceConsumptionBy20", 20081);
		/// <summary>
		/// Shoes - Reduces endurance consumption by 30%<para/>
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
		public static StatusEffect ShoesReducesEnduranceConsumptionBy30 { get; } = new StatusEffect("ShoesReducesEnduranceConsumptionBy30", 20082);
		/// <summary>
		/// Shoes - 40% reduction in endurance consumption<para/>
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
		public static StatusEffect Shoes40ReductionInEnduranceConsumption { get; } = new StatusEffect("Shoes40ReductionInEnduranceConsumption", 20083);
		/// <summary>
		/// Shoes - slow down the endurance consumption by 50%<para/>
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
		public static StatusEffect ShoesSlowDownTheEnduranceConsumptionBy50 { get; } = new StatusEffect("ShoesSlowDownTheEnduranceConsumptionBy50", 20084);
		/// <summary>
		/// Shoes - move up 10%<para/>
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
		public static StatusEffect ShoesMoveUp10 { get; } = new StatusEffect("ShoesMoveUp10", 20085);
		/// <summary>
		/// Shoes - move up 15%<para/>
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
		public static StatusEffect ShoesMoveUp15 { get; } = new StatusEffect("ShoesMoveUp15", 20086);
		/// <summary>
		/// Shoes - move up 20%<para/>
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
		public static StatusEffect ShoesMoveUp20 { get; } = new StatusEffect("ShoesMoveUp20", 20087);
		/// <summary>
		/// Shoes - move up 25%<para/>
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
		public static StatusEffect ShoesMoveUp25 { get; } = new StatusEffect("ShoesMoveUp25", 20088);
		/// <summary>
		/// Shoes - reduce hunger by 10%<para/>
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
		public static StatusEffect ShoesReduceHungerBy10 { get; } = new StatusEffect("ShoesReduceHungerBy10", 20089);
		/// <summary>
		/// Shoes - reduce hunger by 20%<para/>
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
		public static StatusEffect ShoesReduceHungerBy20 { get; } = new StatusEffect("ShoesReduceHungerBy20", 20090);
		/// <summary>
		/// Shoes - reduce hunger by 30%<para/>
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
		public static StatusEffect ShoesReduceHungerBy30 { get; } = new StatusEffect("ShoesReduceHungerBy30", 20091);
		/// <summary>
		/// Shoes - reduce hunger by 40%<para/>
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
		public static StatusEffect ShoesReduceHungerBy40 { get; } = new StatusEffect("ShoesReduceHungerBy40", 20092);
		/// <summary>
		/// Shoes - reduce trap damage by 20%<para/>
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
		public static StatusEffect ShoesReduceTrapDamageBy20 { get; } = new StatusEffect("ShoesReduceTrapDamageBy20", 20093);
		/// <summary>
		/// Shoes - reduce trap damage by 30%<para/>
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
		public static StatusEffect ShoesReduceTrapDamageBy30 { get; } = new StatusEffect("ShoesReduceTrapDamageBy30", 20094);
		/// <summary>
		/// Shoes - reduce trap damage by 40%<para/>
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
		public static StatusEffect ShoesReduceTrapDamageBy40 { get; } = new StatusEffect("ShoesReduceTrapDamageBy40", 20095);
		/// <summary>
		/// Shoes - reduce trap damage by 50%<para/>
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
		public static StatusEffect ShoesReduceTrapDamageBy50 { get; } = new StatusEffect("ShoesReduceTrapDamageBy50", 20096);
	}
}
