//namespace ChassisMod.KeplerthDatabase
//{
//	public static class EffectDB
//	{
//		/// <summary>
//		/// Description: "Restore 1 HP for every second."<para/>
//		/// Modifiers: [ +1 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 11s<para/>
//		/// </summary>
//		public static Effect Recovery { get; } = new Effect("Recovery", 1);
//		/// <summary>
//		/// Description: "Feeling cold…"<para/>
//		/// Modifiers: [ -1 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 30s<para/>
//		/// </summary>
//		public static Effect Cold { get; } = new Effect("Cold", 2);
//		/// <summary>
//		/// Description: "Feeling hot…"<para/>
//		/// Tier: 1<para/>
//		/// Duration: 30s<para/>
//		/// </summary>
//		public static Effect Fever { get; } = new Effect("Fever", 3);
//		/// <summary>
//		/// Description: "Walking speed decrease by 25%."<para/>
//		/// Modifiers: [ -25% MovementSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 60s<para/>
//		/// </summary>
//		public static Effect Nausea { get; } = new Effect("Nausea", 4);
//		/// <summary>
//		/// Description: "Attack speed increase by 30%, but hunger speed increase by 50%."<para/>
//		/// Modifiers: [ +30% AttackSpeed, +50% HungerSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 60s<para/>
//		/// </summary>
//		public static Effect Excited { get; } = new Effect("Excited", 5);
//		/// <summary>
//		/// Description: "Hunger speed increase by 50%."<para/>
//		/// Modifiers: [ +50% HungerSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 60s<para/>
//		/// </summary>
//		public static Effect Fatigue { get; } = new Effect("Fatigue", 6);
//		/// <summary>
//		/// Description: "Stun…"<para/>
//		/// Modifiers: [ Stunned ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 3s<para/>
//		/// </summary>
//		public static Effect Stun0 { get; } = new Effect("Stun0", 7);
//		/// <summary>
//		/// Description: "Night vision is improved."<para/>
//		/// Tier: 1<para/>
//		/// Duration: 30s<para/>
//		/// </summary>
//		public static Effect NightVision { get; } = new Effect("NightVision", 8);
//		/// <summary>
//		/// Description: "Shush…"<para/>
//		/// Tier: 1<para/>
//		/// Duration: 30s<para/>
//		/// </summary>
//		public static Effect Stealth { get; } = new Effect("Stealth", 9);
//		/// <summary>
//		/// Description: "vu！hweb#$UJ*Bd45"<para/>
//		/// Tier: 1<para/>
//		/// Duration: 30s<para/>
//		/// </summary>
//		public static Effect Hallucinations { get; } = new Effect("Hallucinations", 10);
//		/// <summary>
//		/// Description: "Attack increase by 2 points."<para/>
//		/// Modifiers: [ +2 Attack ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect StrengthI { get; } = new Effect("StrengthI", 11);
//		/// <summary>
//		/// Description: "Attack increase by 3 points."<para/>
//		/// Modifiers: [ +3 Attack ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect StrengthII { get; } = new Effect("StrengthII", 12);
//		/// <summary>
//		/// Description: "Attack increase by 4 points."<para/>
//		/// Modifiers: [ +4 Attack ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect StrengthIII { get; } = new Effect("StrengthIII", 13);
//		/// <summary>
//		/// Description: "Attack increase by 6 points."<para/>
//		/// Modifiers: [ +6 Attack ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect StrengthIV { get; } = new Effect("StrengthIV", 14);
//		/// <summary>
//		/// Description: "Attack increase by 9 points."<para/>
//		/// Modifiers: [ +9 Attack ]<para/>
//		/// Tier: 5<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect StrengthV { get; } = new Effect("StrengthV", 15);
//		/// <summary>
//		/// Description: "Attack increase by 10%."<para/>
//		/// Modifiers: [ +10% Attack ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect AttackI { get; } = new Effect("AttackI", 16);
//		/// <summary>
//		/// Description: "Attack increase by 20%."<para/>
//		/// Modifiers: [ +20% Attack ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect AttackII { get; } = new Effect("AttackII", 17);
//		/// <summary>
//		/// Description: "Attack increase by 30%."<para/>
//		/// Modifiers: [ +30% Attack ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect AttackIII { get; } = new Effect("AttackIII", 18);
//		/// <summary>
//		/// Description: "Attack increase by 40%."<para/>
//		/// Modifiers: [ +40% Attack ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect AttackIV { get; } = new Effect("AttackIV", 19);
//		/// <summary>
//		/// Description: "Attack increase by 50%."<para/>
//		/// Modifiers: [ +50% Attack ]<para/>
//		/// Tier: 5<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect AttackV { get; } = new Effect("AttackV", 20);
//		/// <summary>
//		/// Description: "Defense increase by 3 points."<para/>
//		/// Modifiers: [ +3 Defence ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect EnduranceI { get; } = new Effect("EnduranceI", 21);
//		/// <summary>
//		/// Description: "Defense increase by 5 points."<para/>
//		/// Modifiers: [ +5 Defence ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect EnduranceII { get; } = new Effect("EnduranceII", 22);
//		/// <summary>
//		/// Description: "Defense increase by 8 points."<para/>
//		/// Modifiers: [ +8 Defence ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect EnduranceIII { get; } = new Effect("EnduranceIII", 23);
//		/// <summary>
//		/// Description: "Defense increase by 12 points."<para/>
//		/// Modifiers: [ +12 Defence ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect EnduranceIV { get; } = new Effect("EnduranceIV", 24);
//		/// <summary>
//		/// Description: "Defense increase by 19 points."<para/>
//		/// Modifiers: [ +19 Defence ]<para/>
//		/// Tier: 5<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect EnduranceV { get; } = new Effect("EnduranceV", 25);
//		/// <summary>
//		/// Description: "Defense increase by 10%."<para/>
//		/// Modifiers: [ +10% Defence ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect DefenseI { get; } = new Effect("DefenseI", 26);
//		/// <summary>
//		/// Description: "Defense increase by 20%."<para/>
//		/// Modifiers: [ +20% Defence ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect DefenseII { get; } = new Effect("DefenseII", 27);
//		/// <summary>
//		/// Description: "Defense increase by 30%."<para/>
//		/// Modifiers: [ +30% Defence ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect DefenseIII { get; } = new Effect("DefenseIII", 28);
//		/// <summary>
//		/// Description: "Defense increase by 40%."<para/>
//		/// Modifiers: [ +40% Defence ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect DefenseIV { get; } = new Effect("DefenseIV", 29);
//		/// <summary>
//		/// Description: "Defense increase by 50%."<para/>
//		/// Modifiers: [ +50% Defence ]<para/>
//		/// Tier: 5<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect DefenseV { get; } = new Effect("DefenseV", 30);
//		/// <summary>
//		/// Description: "Attack decrease by 1 points."<para/>
//		/// Modifiers: [ -1 Attack ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect WeakI0 { get; } = new Effect("WeakI0", 31);
//		/// <summary>
//		/// Description: "Attack decrease by 3 points."<para/>
//		/// Modifiers: [ -3 Attack ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect WeakII { get; } = new Effect("WeakII", 32);
//		/// <summary>
//		/// Description: "Attack decrease by 5 points."<para/>
//		/// Modifiers: [ -5 Attack ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect WeakIII { get; } = new Effect("WeakIII", 33);
//		/// <summary>
//		/// Description: "Attack decrease by 7 points."<para/>
//		/// Modifiers: [ -7 Attack ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect WeakIV { get; } = new Effect("WeakIV", 34);
//		/// <summary>
//		/// Description: "Attack decrease by 9 points."<para/>
//		/// Modifiers: [ -9 Attack ]<para/>
//		/// Tier: 5<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect WeakI1 { get; } = new Effect("WeakI1", 35);
//		/// <summary>
//		/// Description: "Attack decrease by 10%."<para/>
//		/// Modifiers: [ -10% Attack ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect ATKWeakenedI { get; } = new Effect("ATKWeakenedI", 36);
//		/// <summary>
//		/// Description: "Attack decrease by 20%."<para/>
//		/// Modifiers: [ -20% Attack ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect ATKWeakenedII { get; } = new Effect("ATKWeakenedII", 37);
//		/// <summary>
//		/// Description: "Attack decrease by 30%."<para/>
//		/// Modifiers: [ -30% Attack ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect ATKWeakenedIII { get; } = new Effect("ATKWeakenedIII", 38);
//		/// <summary>
//		/// Description: "Attack decrease by 40%."<para/>
//		/// Modifiers: [ -40% Attack ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect ATKWeakenedIV { get; } = new Effect("ATKWeakenedIV", 39);
//		/// <summary>
//		/// Description: "Attack decrease by 50%."<para/>
//		/// Modifiers: [ -50% Attack ]<para/>
//		/// Tier: 5<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect ATKWeakenedV { get; } = new Effect("ATKWeakenedV", 40);
//		/// <summary>
//		/// Description: "Defense decrease by 3 points."<para/>
//		/// Modifiers: [ -3 Defence ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect CorrosionI { get; } = new Effect("CorrosionI", 41);
//		/// <summary>
//		/// Description: "Defense decrease by 6 points."<para/>
//		/// Modifiers: [ -6 Defence ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect CorrosionII { get; } = new Effect("CorrosionII", 42);
//		/// <summary>
//		/// Description: "Defense decrease by 9 points."<para/>
//		/// Modifiers: [ -9 Defence ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect CorrosionIII { get; } = new Effect("CorrosionIII", 43);
//		/// <summary>
//		/// Description: "Defense decrease by 12 points."<para/>
//		/// Modifiers: [ -12 Defence ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect CorrosionIV { get; } = new Effect("CorrosionIV", 44);
//		/// <summary>
//		/// Description: "Defense decrease by 15 points."<para/>
//		/// Modifiers: [ -15 Defence ]<para/>
//		/// Tier: 5<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect CorrosionV { get; } = new Effect("CorrosionV", 45);
//		/// <summary>
//		/// Description: "Defense decrease by 10%."<para/>
//		/// Modifiers: [ -10% Defence ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect DEFWeakenedI { get; } = new Effect("DEFWeakenedI", 46);
//		/// <summary>
//		/// Description: "Defense decrease by 20%."<para/>
//		/// Modifiers: [ -20% Defence ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect DEFWeakenedII { get; } = new Effect("DEFWeakenedII", 47);
//		/// <summary>
//		/// Description: "Defense decrease by 30%."<para/>
//		/// Modifiers: [ -30% Defence ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect DEFWeakenedIII { get; } = new Effect("DEFWeakenedIII", 48);
//		/// <summary>
//		/// Description: "Defense decrease by 40%."<para/>
//		/// Modifiers: [ -40% Defence ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect DEFWeakenedIV { get; } = new Effect("DEFWeakenedIV", 49);
//		/// <summary>
//		/// Description: "Defense decrease by 50%."<para/>
//		/// Modifiers: [ -50% Defence ]<para/>
//		/// Tier: 5<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect DEFWeakenedV { get; } = new Effect("DEFWeakenedV", 50);
//		/// <summary>
//		/// Description: "Restore 1 HP for every second."<para/>
//		/// Modifiers: [ +1 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 180s<para/>
//		/// </summary>
//		public static Effect HealingI { get; } = new Effect("HealingI", 51);
//		/// <summary>
//		/// Description: "Restore 2 HP for every second."<para/>
//		/// Modifiers: [ +2 HP/s ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: 180s<para/>
//		/// </summary>
//		public static Effect HealingII { get; } = new Effect("HealingII", 52);
//		/// <summary>
//		/// Description: "Restore 3 HP for every second."<para/>
//		/// Modifiers: [ +3 HP/s ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: 180s<para/>
//		/// </summary>
//		public static Effect HealingIII { get; } = new Effect("HealingIII", 53);
//		/// <summary>
//		/// Description: "Restore 4 HP for every second."<para/>
//		/// Modifiers: [ +4 HP/s ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: 180s<para/>
//		/// </summary>
//		public static Effect HealingIV { get; } = new Effect("HealingIV", 54);
//		/// <summary>
//		/// Description: "Restore 5 HP for every second."<para/>
//		/// Modifiers: [ +5 HP/s ]<para/>
//		/// Tier: 5<para/>
//		/// Duration: 180s<para/>
//		/// </summary>
//		public static Effect HealingV { get; } = new Effect("HealingV", 55);
//		/// <summary>
//		/// Description: "Walking speed increase by 10%."<para/>
//		/// Modifiers: [ +10% MovementSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect SpeedI { get; } = new Effect("SpeedI", 56);
//		/// <summary>
//		/// Description: "Walking speed increase by 15%."<para/>
//		/// Modifiers: [ +15% MovementSpeed ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect SpeedII { get; } = new Effect("SpeedII", 57);
//		/// <summary>
//		/// Description: "Walking speed increase by 20%."<para/>
//		/// Modifiers: [ +20% MovementSpeed ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect SpeedIII { get; } = new Effect("SpeedIII", 58);
//		/// <summary>
//		/// Description: "Walking speed increase by 25%."<para/>
//		/// Modifiers: [ +25% MovementSpeed ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect SpeedIV { get; } = new Effect("SpeedIV", 59);
//		/// <summary>
//		/// Description: "Walking speed increase by 30%."<para/>
//		/// Modifiers: [ +30% MovementSpeed ]<para/>
//		/// Tier: 5<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect SpeedV { get; } = new Effect("SpeedV", 60);
//		/// <summary>
//		/// Description: "Walking speed decrease by 10%."<para/>
//		/// Modifiers: [ -10% MovementSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect SPDWeakenedI { get; } = new Effect("SPDWeakenedI", 61);
//		/// <summary>
//		/// Description: "Walking speed decrease by 15%."<para/>
//		/// Modifiers: [ -15% MovementSpeed ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect SPDWeakenedII { get; } = new Effect("SPDWeakenedII", 62);
//		/// <summary>
//		/// Description: "Walking speed decrease by 20%."<para/>
//		/// Modifiers: [ -20% MovementSpeed ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect SPDWeakenedIII { get; } = new Effect("SPDWeakenedIII", 63);
//		/// <summary>
//		/// Description: "Walking speed decrease by 25%."<para/>
//		/// Modifiers: [ -25% MovementSpeed ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect SPDWeakenedIV { get; } = new Effect("SPDWeakenedIV", 64);
//		/// <summary>
//		/// Description: "Walking speed decrease by 30%."<para/>
//		/// Modifiers: [ -30% MovementSpeed ]<para/>
//		/// Tier: 5<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect SPDWeakenedV { get; } = new Effect("SPDWeakenedV", 65);
//		/// <summary>
//		/// Description: "Attack speed increase by 10%."<para/>
//		/// Modifiers: [ +10% AttackSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect AgilityI { get; } = new Effect("AgilityI", 66);
//		/// <summary>
//		/// Description: "Attack speed increase by 15%."<para/>
//		/// Modifiers: [ +15% AttackSpeed ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect AgilityII { get; } = new Effect("AgilityII", 67);
//		/// <summary>
//		/// Description: "Attack speed increase by 20%."<para/>
//		/// Modifiers: [ +20% AttackSpeed ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect AgilityIII { get; } = new Effect("AgilityIII", 68);
//		/// <summary>
//		/// Description: "Attack speed increase by 25%."<para/>
//		/// Modifiers: [ +25% AttackSpeed ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect AgilityIV { get; } = new Effect("AgilityIV", 69);
//		/// <summary>
//		/// Description: "Attack speed increase by 30%."<para/>
//		/// Modifiers: [ +30% AttackSpeed ]<para/>
//		/// Tier: 5<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect AgilityV { get; } = new Effect("AgilityV", 70);
//		/// <summary>
//		/// Description: "Attack speed decrease by 10%."<para/>
//		/// Modifiers: [ -10% AttackSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect AGIWeakenedI { get; } = new Effect("AGIWeakenedI", 71);
//		/// <summary>
//		/// Description: "Attack speed decrease by 15%."<para/>
//		/// Modifiers: [ -15% AttackSpeed ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect AGIWeakenedII { get; } = new Effect("AGIWeakenedII", 72);
//		/// <summary>
//		/// Description: "Attack speed decrease by 20%."<para/>
//		/// Modifiers: [ -20% AttackSpeed ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect AGIWeakenedIII { get; } = new Effect("AGIWeakenedIII", 73);
//		/// <summary>
//		/// Description: "Attack speed decrease by 25%."<para/>
//		/// Modifiers: [ -25% AttackSpeed ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect AGIWeakenedIV { get; } = new Effect("AGIWeakenedIV", 74);
//		/// <summary>
//		/// Description: "Attack speed decrease by 30%."<para/>
//		/// Modifiers: [ -30% AttackSpeed ]<para/>
//		/// Tier: 5<para/>
//		/// Duration: 600s<para/>
//		/// </summary>
//		public static Effect AGIWeakenedV { get; } = new Effect("AGIWeakenedV", 75);
//		/// <summary>
//		/// Description: "Attack speed and walking speed both increase by 20%, but hunger speed increase by 150%."<para/>
//		/// Modifiers: [ +20% AttackSpeed, +150% HungerSpeed, +20% MovementSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 60s<para/>
//		/// </summary>
//		public static Effect StimulantsI { get; } = new Effect("StimulantsI", 76);
//		/// <summary>
//		/// Description: "Attack speed and walking speed both increase by 40%, but hunger speed increase by 300%."<para/>
//		/// Modifiers: [ +40% AttackSpeed, +300% HungerSpeed, +40% MovementSpeed ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: 60s<para/>
//		/// </summary>
//		public static Effect StimulantsII { get; } = new Effect("StimulantsII", 77);
//		/// <summary>
//		/// Description: "Attack speed and walking speed both increase by 60%, but satiety will decrease to 0 once the effect is over."<para/>
//		/// Modifiers: [ +60% AttackSpeed, Hunger -= 36000, +60% MovementSpeed ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: 60s<para/>
//		/// </summary>
//		public static Effect StimulantsIII { get; } = new Effect("StimulantsIII", 78);
//		/// <summary>
//		/// Description: "Attack speed increase by 50%, but hunger speed increase by 100%."<para/>
//		/// Modifiers: [ +50% AttackSpeed, +100% HungerSpeed ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: 60s<para/>
//		/// </summary>
//		public static Effect Excitement0 { get; } = new Effect("Excitement0", 79);
//		/// <summary>
//		/// Description: "Attack speed increase by 50%, but hunger speed increase by 100%."<para/>
//		/// Modifiers: [ +50% AttackSpeed, +100% HungerSpeed ]<para/>
//		/// Tier: 5<para/>
//		/// Duration: 60s<para/>
//		/// </summary>
//		public static Effect Excitement1 { get; } = new Effect("Excitement1", 80);
//		/// <summary>
//		/// Description: "Stun…"<para/>
//		/// Modifiers: [ Stunned ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 1s<para/>
//		/// </summary>
//		public static Effect Stun1 { get; } = new Effect("Stun1", 81);
//		/// <summary>
//		/// Description: "Stun…"<para/>
//		/// Modifiers: [ Stunned ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: 2s<para/>
//		/// </summary>
//		public static Effect Stun2 { get; } = new Effect("Stun2", 82);
//		/// <summary>
//		/// Description: "Stun…"<para/>
//		/// Modifiers: [ Stunned ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: 3s<para/>
//		/// </summary>
//		public static Effect Stun3 { get; } = new Effect("Stun3", 83);
//		/// <summary>
//		/// Description: "Stun…"<para/>
//		/// Modifiers: [ Stunned ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: 4s<para/>
//		/// </summary>
//		public static Effect Stun4 { get; } = new Effect("Stun4", 84);
//		/// <summary>
//		/// Description: "Stun…"<para/>
//		/// Modifiers: [ Stunned ]<para/>
//		/// Tier: 5<para/>
//		/// Duration: 5s<para/>
//		/// </summary>
//		public static Effect Stun5 { get; } = new Effect("Stun5", 85);
//		/// <summary>
//		/// Description: "Feeling scared…"<para/>
//		/// Tier: 1<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect Fear { get; } = new Effect("Fear", 101);
//		/// <summary>
//		/// Description: "You're shaking…"<para/>
//		/// Tier: 1<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect Tremble { get; } = new Effect("Tremble", 102);
//		/// <summary>
//		/// Description: "Feeling satisfied with a delicious meal. Hunger speed decrease by 35%."<para/>
//		/// Modifiers: [ -35% HungerSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 60s<para/>
//		/// </summary>
//		public static Effect Tasty { get; } = new Effect("Tasty", 103);
//		/// <summary>
//		/// Description: "If you don't eat something, you will starve to death!"<para/>
//		/// Tier: 1<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect HungerDiscarded { get; } = new Effect("HungerDiscarded", 104);
//		/// <summary>
//		/// Description: "Lose 1 HP for every second."<para/>
//		/// Modifiers: [ -1 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 11s<para/>
//		/// </summary>
//		public static Effect ToxinI { get; } = new Effect("ToxinI", 105);
//		/// <summary>
//		/// Description: "Lose 1 HP for every second."<para/>
//		/// Modifiers: [ -1 HP/s ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: 16s<para/>
//		/// </summary>
//		public static Effect ToxinII { get; } = new Effect("ToxinII", 106);
//		/// <summary>
//		/// Description: "Lose 2 HP for every second."<para/>
//		/// Modifiers: [ -2 HP/s ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: 11s<para/>
//		/// </summary>
//		public static Effect ToxinIII { get; } = new Effect("ToxinIII", 107);
//		/// <summary>
//		/// Description: "Lose 2 HP for every second."<para/>
//		/// Modifiers: [ -2 HP/s ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: 16s<para/>
//		/// </summary>
//		public static Effect ToxinIV { get; } = new Effect("ToxinIV", 108);
//		/// <summary>
//		/// Description: "Lose 3 HP for every second."<para/>
//		/// Modifiers: [ -3 HP/s ]<para/>
//		/// Tier: 5<para/>
//		/// Duration: 11s<para/>
//		/// </summary>
//		public static Effect ToxinV { get; } = new Effect("ToxinV", 109);
//		/// <summary>
//		/// Description: "Lose 2 HP for every second."<para/>
//		/// Modifiers: [ -2 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 6s<para/>
//		/// </summary>
//		public static Effect BleedingI { get; } = new Effect("BleedingI", 110);
//		/// <summary>
//		/// Description: "Lose 3 HP for every second."<para/>
//		/// Modifiers: [ -3 HP/s ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: 6s<para/>
//		/// </summary>
//		public static Effect BleedingII { get; } = new Effect("BleedingII", 111);
//		/// <summary>
//		/// Description: "Lose 3 HP for every second."<para/>
//		/// Modifiers: [ -3 HP/s ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: 11s<para/>
//		/// </summary>
//		public static Effect BleedingIII { get; } = new Effect("BleedingIII", 112);
//		/// <summary>
//		/// Description: "Lose 4 HP for every second."<para/>
//		/// Modifiers: [ -4 HP/s ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: 11s<para/>
//		/// </summary>
//		public static Effect BleedingIV { get; } = new Effect("BleedingIV", 113);
//		/// <summary>
//		/// Description: "Lose 4 HP for every second."<para/>
//		/// Modifiers: [ -4 HP/s ]<para/>
//		/// Tier: 5<para/>
//		/// Duration: 16s<para/>
//		/// </summary>
//		public static Effect BleedingV { get; } = new Effect("BleedingV", 114);
//		/// <summary>
//		/// Description: "Walking speed increase by 15%, but hunger speed increase by 10% and defense decrease by 2 points."<para/>
//		/// Modifiers: [ +15% MovementSpeed, -3 Defence, +10% HungerSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 180s<para/>
//		/// </summary>
//		public static Effect MutatedLeg { get; } = new Effect("MutatedLeg", 115);
//		/// <summary>
//		/// Description: "Attack increase by 3 points, but hunger speed increase by 10% and walking speed decrease by 10%."<para/>
//		/// Modifiers: [ +3 Attack, -10% MovementSpeed, +10% HungerSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 180s<para/>
//		/// </summary>
//		public static Effect MutatedArm { get; } = new Effect("MutatedArm", 116);
//		/// <summary>
//		/// Description: "Defense increase by 4 points, but hunger speed increase by 10% and attack decrease by 2 points."<para/>
//		/// Modifiers: [ +6 Defence, -2 Attack, +10% HungerSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 180s<para/>
//		/// </summary>
//		public static Effect MutatedSkin { get; } = new Effect("MutatedSkin", 117);
//		/// <summary>
//		/// Description: "You're hungry! Attack speed and walking speed are slowing down."<para/>
//		/// Modifiers: [ -15% AttackSpeed, -15% MovementSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect HungerI { get; } = new Effect("HungerI", 118);
//		/// <summary>
//		/// Description: "You're starving! Attack speed and walking speed are slowing down."<para/>
//		/// Modifiers: [ -30% AttackSpeed, -30% MovementSpeed ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect HungerII { get; } = new Effect("HungerII", 119);
//		/// <summary>
//		/// Description: "You're dying! Attack speed and walking speed are slowing down."<para/>
//		/// Modifiers: [ -50% AttackSpeed, -40% MovementSpeed ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect HungerIII { get; } = new Effect("HungerIII", 120);
//		/// <summary>
//		/// Description: "Walking speed decrease by 25%."<para/>
//		/// Modifiers: [ -25% MovementSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 60s<para/>
//		/// </summary>
//		public static Effect MushroomToxinNausea { get; } = new Effect("MushroomToxinNausea", 121);
//		/// <summary>
//		/// Description: "Attack speed increase by 30%, but hunger speed increase by 50%."<para/>
//		/// Modifiers: [ +30% AttackSpeed, +50% HungerSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 60s<para/>
//		/// </summary>
//		public static Effect MushroomToxinExcited { get; } = new Effect("MushroomToxinExcited", 122);
//		/// <summary>
//		/// Description: "Hunger speed increase by 50%."<para/>
//		/// Modifiers: [ +50% HungerSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 60s<para/>
//		/// </summary>
//		public static Effect MushroomToxinTired { get; } = new Effect("MushroomToxinTired", 123);
//		/// <summary>
//		/// Description: "Restore 1 HP for every second."<para/>
//		/// Modifiers: [ +1 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 180s<para/>
//		/// </summary>
//		public static Effect MushroomToxinCureI { get; } = new Effect("MushroomToxinCureI", 124);
//		/// <summary>
//		/// Description: "Restore 2 HP for every second."<para/>
//		/// Modifiers: [ +2 HP/s ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: 180s<para/>
//		/// </summary>
//		public static Effect MushroomToxinCureII { get; } = new Effect("MushroomToxinCureII", 125);
//		/// <summary>
//		/// Description: "Walking speed increase by 20%."<para/>
//		/// Modifiers: [ +20% MovementSpeed ]<para/>
//		/// Tier: 0<para/>
//		/// Duration: 180s<para/>
//		/// </summary>
//		public static Effect MushroomToxinAGI { get; } = new Effect("MushroomToxinAGI", 126);
//		/// <summary>
//		/// Description: "Lose 1 HP for every second."<para/>
//		/// Modifiers: [ -1 HP/s ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: 16s<para/>
//		/// </summary>
//		public static Effect MushroomToxin { get; } = new Effect("MushroomToxin", 127);
//		/// <summary>
//		/// Description: "Restore 1 HP for every second."<para/>
//		/// Modifiers: [ +1 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 20s<para/>
//		/// </summary>
//		public static Effect ContinuousRecovery { get; } = new Effect("ContinuousRecovery", 128);
//		/// <summary>
//		/// Description: "Restore 2 HP for every second."<para/>
//		/// Modifiers: [ +2 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 40s<para/>
//		/// </summary>
//		public static Effect SweetSoup { get; } = new Effect("SweetSoup", 129);
//		/// <summary>
//		/// Description: "Attracting chickens around you…"<para/>
//		/// Modifiers: [ 0 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 30s<para/>
//		/// </summary>
//		public static Effect PheromonesChicken { get; } = new Effect("PheromonesChicken", 130);
//		/// <summary>
//		/// Description: "Attracting goats around you…"<para/>
//		/// Modifiers: [ 0 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 30s<para/>
//		/// </summary>
//		public static Effect PheromonesGoat { get; } = new Effect("PheromonesGoat", 131);
//		/// <summary>
//		/// Description: "Attracting pigs around you…"<para/>
//		/// Modifiers: [ 0 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 30s<para/>
//		/// </summary>
//		public static Effect PheromonesPig { get; } = new Effect("PheromonesPig", 132);
//		/// <summary>
//		/// Description: "Attracting cows around you…"<para/>
//		/// Modifiers: [ 0 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 30s<para/>
//		/// </summary>
//		public static Effect PheromonesCow { get; } = new Effect("PheromonesCow", 133);
//		/// <summary>
//		/// Description: "Attracting horses around you…"<para/>
//		/// Modifiers: [ 0 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 30s<para/>
//		/// </summary>
//		public static Effect PheromonesHorse { get; } = new Effect("PheromonesHorse", 134);
//		/// <summary>
//		/// Description: "Walking speed decrease by 10% and lose 1 HP for every second."<para/>
//		/// Modifiers: [ -1 HP/s, -10% MovementSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect SuffocatingGas0 { get; } = new Effect("SuffocatingGas0", 135);
//		/// <summary>
//		/// Description: "Walking speed decrease by 25% and lose 5 HP for every second."<para/>
//		/// Modifiers: [ -5 HP/s, -25% MovementSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect SuffocatingGas1 { get; } = new Effect("SuffocatingGas1", 136);
//		/// <summary>
//		/// Description: "Bear Trap:  unable to move,and lose 1 HP for every second."<para/>
//		/// Modifiers: [ Stuck, -1 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 5s<para/>
//		/// </summary>
//		public static Effect BearTrap { get; } = new Effect("BearTrap", 137);
//		/// <summary>
//		/// Description: "Restore 1 HP for every second."<para/>
//		/// Modifiers: [ +2 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 5s<para/>
//		/// </summary>
//		public static Effect RecoveryI { get; } = new Effect("RecoveryI", 138);
//		/// <summary>
//		/// Description: "Restore 2 HP for every second."<para/>
//		/// Modifiers: [ +3 HP/s ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: 5s<para/>
//		/// </summary>
//		public static Effect RecoveryII { get; } = new Effect("RecoveryII", 139);
//		/// <summary>
//		/// Description: "Restore 3 HP for every second."<para/>
//		/// Modifiers: [ +4 HP/s ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: 5s<para/>
//		/// </summary>
//		public static Effect RecoveryIII { get; } = new Effect("RecoveryIII", 140);
//		/// <summary>
//		/// Description: "Restore 4 HP for every second."<para/>
//		/// Modifiers: [ +5 HP/s ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: 5s<para/>
//		/// </summary>
//		public static Effect RecoveryIV0 { get; } = new Effect("RecoveryIV0", 141);
//		/// <summary>
//		/// Description: "Goblin accelerates to escape"<para/>
//		/// Modifiers: [ 1 Afterimage, +40% MovementSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 3s<para/>
//		/// </summary>
//		public static Effect RecoveryIV1 { get; } = new Effect("RecoveryIV1", 501);
//		/// <summary>
//		/// Description: "Test BUFF"<para/>
//		/// Tier: 1<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect TestTheAttackToTheTargetBUFF { get; } = new Effect("TestTheAttackToTheTargetBUFF", 1001);
//		/// <summary>
//		/// Description: "Test BUFF"<para/>
//		/// Tier: 1<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect TestTheAttackToYourselfBUFF { get; } = new Effect("TestTheAttackToYourselfBUFF", 1002);
//		/// <summary>
//		/// Description: "Test BUFF"<para/>
//		/// Modifiers: [ +15 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect TestDoesNotDisplayBUFF { get; } = new Effect("TestDoesNotDisplayBUFF", 1003);
//		/// <summary>
//		/// Description: "Test BUFF"<para/>
//		/// Modifiers: [ +15% MovementSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 60s<para/>
//		/// </summary>
//		public static Effect TestDoesNotClearBUFF { get; } = new Effect("TestDoesNotClearBUFF", 1004);
//		/// <summary>
//		/// Description: "Test BUFF"<para/>
//		/// Modifiers: [ Hunger += 3 ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect TestUnlimitedBUFF { get; } = new Effect("TestUnlimitedBUFF", 1005);
//		/// <summary>
//		/// Description: "Remote weapon limit DEBUFF"<para/>
//		/// Modifiers: [ -50% MovementSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 2s<para/>
//		/// </summary>
//		public static Effect LongRangeWeaponAttackSlowdown { get; } = new Effect("LongRangeWeaponAttackSlowdown", 2001);
//		/// <summary>
//		/// Description: "Defense decrease by 5 points."<para/>
//		/// Modifiers: [ -5 Defence ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect Corrosion { get; } = new Effect("Corrosion", 2002);
//		/// <summary>
//		/// Description: "Attack decrease by 4 points."<para/>
//		/// Modifiers: [ -4 Attack ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 10s<para/>
//		/// </summary>
//		public static Effect Weak { get; } = new Effect("Weak", 2003);
//		/// <summary>
//		/// Description: "Remote weapon limit DEBUFF"<para/>
//		/// Modifiers: [ -1000% MovementSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 1s<para/>
//		/// </summary>
//		public static Effect GatlinCompletelySlowsDown { get; } = new Effect("GatlinCompletelySlowsDown", 2004);
//		/// <summary>
//		/// Description: "Restore 1 HP for every two seconds."<para/>
//		/// Modifiers: [ +0.25 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect SlowReturnOfPets { get; } = new Effect("SlowReturnOfPets", 2005);
//		/// <summary>
//		/// Description: "Equip: gathering speed increase by 50%."<para/>
//		/// Modifiers: [ +50% GatheringSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect IncreaseCollectionEfficiencyBy50 { get; } = new Effect("IncreaseCollectionEfficiencyBy50", 5001);
//		/// <summary>
//		/// Description: "Equip: gathering speed increase by 100%."<para/>
//		/// Modifiers: [ +100% GatheringSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect IncreaseCollectionEfficiencyBy100 { get; } = new Effect("IncreaseCollectionEfficiencyBy100", 5002);
//		/// <summary>
//		/// Description: "Equip: gathering speed increase by 200%."<para/>
//		/// Modifiers: [ +200% GatheringSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect IncreaseCollectionEfficiencyBy200 { get; } = new Effect("IncreaseCollectionEfficiencyBy200", 5003);
//		/// <summary>
//		/// Description: "Equip: eating speed increase by 50%."<para/>
//		/// Modifiers: [ +50% EatingSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect FasterEating0 { get; } = new Effect("FasterEating0", 5011);
//		/// <summary>
//		/// Description: "Equip: eating speed increase by 100%."<para/>
//		/// Modifiers: [ +100% EatingSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect FasterEating1 { get; } = new Effect("FasterEating1", 5012);
//		/// <summary>
//		/// Description: "Equip: eating speed increase by 200%."<para/>
//		/// Modifiers: [ +200% EatingSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect FasterEating2 { get; } = new Effect("FasterEating2", 5013);
//		/// <summary>
//		/// Description: "Equip: become stealth if no attack or injury occurred within 5 seconds."<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect IfYouAreNotAttackedOrInjuredWithin5SecondsYouWillEnterStealth { get; } = new Effect("IfYouAreNotAttackedOrInjuredWithin5SecondsYouWillEnterStealth", 5021);
//		/// <summary>
//		/// Description: "Equip: melee knockback increase by 50%."<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect IncreaseTheRepellingAbilityOfMeleeAttacksBy50 { get; } = new Effect("IncreaseTheRepellingAbilityOfMeleeAttacksBy50", 5031);
//		/// <summary>
//		/// Description: "Equip: walking speed increase by 10%"<para/>
//		/// Modifiers: [ +10% MovementSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect FasterMovement0 { get; } = new Effect("FasterMovement0", 5041);
//		/// <summary>
//		/// Description: "Equip: walking speed increase by 15%"<para/>
//		/// Modifiers: [ +15% MovementSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect IncreasedMovementSpeedBy15 { get; } = new Effect("IncreasedMovementSpeedBy15", 5042);
//		/// <summary>
//		/// Description: "Equip: walking speed increase by 20%"<para/>
//		/// Modifiers: [ +20% MovementSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect FasterMovement1 { get; } = new Effect("FasterMovement1", 5043);
//		/// <summary>
//		/// Description: "Equip: walking speed increase by 25%"<para/>
//		/// Modifiers: [ +25% MovementSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect FasterMovement2 { get; } = new Effect("FasterMovement2", 5044);
//		/// <summary>
//		/// Description: "Equip: walking speed increase by 30%"<para/>
//		/// Modifiers: [ +30% MovementSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect FasterMovement3 { get; } = new Effect("FasterMovement3", 5045);
//		/// <summary>
//		/// Description: "Equip: double tap a direction to dash."<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect PressTheArrowKeysContinuouslyToSprintAShortDistance { get; } = new Effect("PressTheArrowKeysContinuouslyToSprintAShortDistance", 5051);
//		/// <summary>
//		/// Description: "Equip: your attack will poison your target."<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect YourAttackPoisonsTheEnemy { get; } = new Effect("YourAttackPoisonsTheEnemy", 5061);
//		/// <summary>
//		/// Description: "Equip: illuminate your vision."<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect IlluminateTheFrontConeView { get; } = new Effect("IlluminateTheFrontConeView", 5071);
//		/// <summary>
//		/// Description: "Equip: damage received from ranged attacks decrease by 15%."<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Reduces15OfRemoteDamage { get; } = new Effect("Reduces15OfRemoteDamage", 5081);
//		/// <summary>
//		/// Description: "Equip: damage received from ranged attacks decrease by 20%."<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Reduce20OfRemoteDamage { get; } = new Effect("Reduce20OfRemoteDamage", 5082);
//		/// <summary>
//		/// Description: "Equip: damage received from ranged attacks decrease by 25%."<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Reduces25OfRemoteDamage { get; } = new Effect("Reduces25OfRemoteDamage", 5083);
//		/// <summary>
//		/// Description: "Equip: damage received from ranged attacks decrease by 30%."<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Reduce30OfRemoteDamage { get; } = new Effect("Reduce30OfRemoteDamage", 5084);
//		/// <summary>
//		/// Description: "Equip: chance to scare target away on hit for 2 seconds"<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect TheCreatureBeingHitHasAChanceToEscapeFor2Seconds { get; } = new Effect("TheCreatureBeingHitHasAChanceToEscapeFor2Seconds", 5091);
//		/// <summary>
//		/// Description: "Equip: defense increase by 2 points."<para/>
//		/// Modifiers: [ +2 Defence ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect DefenseIncrease2 { get; } = new Effect("DefenseIncrease2", 5101);
//		/// <summary>
//		/// Description: "Equip: defense increase by 4 points."<para/>
//		/// Modifiers: [ +4 Defence ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect DefenseIncrease4 { get; } = new Effect("DefenseIncrease4", 5102);
//		/// <summary>
//		/// Description: "Equip: defense increase by 6 points."<para/>
//		/// Modifiers: [ +6 Defence ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect DefenseIncrease6 { get; } = new Effect("DefenseIncrease6", 5103);
//		/// <summary>
//		/// Description: "Equip: defense increase by 8 points."<para/>
//		/// Modifiers: [ +8 Defence ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect DefenseIncreased8 { get; } = new Effect("DefenseIncreased8", 5104);
//		/// <summary>
//		/// Description: "Equip: defense increase by 10 points."<para/>
//		/// Modifiers: [ +10 Defence ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect DefenseIncreasedBy10 { get; } = new Effect("DefenseIncreasedBy10", 5105);
//		/// <summary>
//		/// Description: "Equip: chance to confuse target on hit for 3 seconds."<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect HitTheProbabilityToConfuseTheEnemyAndFightForYouFor3Seconds { get; } = new Effect("HitTheProbabilityToConfuseTheEnemyAndFightForYouFor3Seconds", 5111);
//		/// <summary>
//		/// Description: "Equip: duration of poisoned effect decrease by 50%."<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ReducePoisoningDurationBy50 { get; } = new Effect("ReducePoisoningDurationBy50", 5121);
//		/// <summary>
//		/// Description: "Equip: duration of bleeding effect decrease by 50%."<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ReduceBleedingDurationBy50 { get; } = new Effect("ReduceBleedingDurationBy50", 5131);
//		/// <summary>
//		/// Description: "Equip: when death occurs, this will be destroyed to protect items in your bag from dropping off."<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect DoNotDropItemsWhenYouDieConsumeAfterDeath { get; } = new Effect("DoNotDropItemsWhenYouDieConsumeAfterDeath", 5141);
//		/// <summary>
//		/// Description: "Equip: when lethal damage occurs, you will be restored to 30% of your health and invincible for 5 seconds."<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect RestoresYourBloodTo30And5SecondsInvincibleWhenYouAreDealtLethalDamage { get; } = new Effect("RestoresYourBloodTo30And5SecondsInvincibleWhenYouAreDealtLethalDamage", 5151);
//		/// <summary>
//		/// Description: "Equip: Tenergy may not be consumed when using the Tenergy weapons."<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ProbabilityDoesNotConsumeEnergyWhenUsingEnergyWeapons { get; } = new Effect("ProbabilityDoesNotConsumeEnergyWhenUsingEnergyWeapons", 5161);
//		/// <summary>
//		/// Description: "Equip: restore 1 HP for every second."<para/>
//		/// Modifiers: [ +1 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Restore1LifePerSecond { get; } = new Effect("Restore1LifePerSecond", 5171);
//		/// <summary>
//		/// Description: "Equip: restore 2 HP for every second."<para/>
//		/// Modifiers: [ +2 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Restore2LivesPerSecond { get; } = new Effect("Restore2LivesPerSecond", 5172);
//		/// <summary>
//		/// Description: "Equip: releasing a firefly that slightly illuminates the area around you."<para/>
//		/// Modifiers: [ LightOrb ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ReleaseAFireflyThatSlightlyIlluminatesTheAreaAroundYou { get; } = new Effect("ReleaseAFireflyThatSlightlyIlluminatesTheAreaAroundYou", 5181);
//		/// <summary>
//		/// Description: "Equip: attack speed increase by 10%."<para/>
//		/// Modifiers: [ +10% AttackSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect IncreaseAttackSpeedBy10 { get; } = new Effect("IncreaseAttackSpeedBy10", 5191);
//		/// <summary>
//		/// Description: "Equip: attack speed increase by 15%."<para/>
//		/// Modifiers: [ +15% AttackSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect IncreaseAttackSpeedBy15 { get; } = new Effect("IncreaseAttackSpeedBy15", 5192);
//		/// <summary>
//		/// Description: "Equip: attack speed increase by 20%."<para/>
//		/// Modifiers: [ +20% AttackSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect IncreaseAttackSpeedBy20 { get; } = new Effect("IncreaseAttackSpeedBy20", 5193);
//		/// <summary>
//		/// Description: "Equip: attack speed increase by 25%."<para/>
//		/// Modifiers: [ +25% AttackSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect IncreaseAttackSpeedBy25 { get; } = new Effect("IncreaseAttackSpeedBy25", 5194);
//		/// <summary>
//		/// Description: "Equip: attack speed increase by 30%."<para/>
//		/// Modifiers: [ +30% AttackSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect IncreaseAttackSpeedBy30 { get; } = new Effect("IncreaseAttackSpeedBy30", 5195);
//		/// <summary>
//		/// Description: "Equip: melee attack increase by 1 point."<para/>
//		/// Modifiers: [ +1 Attack ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ImproveMeleeAttackDamage1 { get; } = new Effect("ImproveMeleeAttackDamage1", 5201);
//		/// <summary>
//		/// Description: "Equip: melee attack increase by 3 points."<para/>
//		/// Modifiers: [ +3 Attack ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ImproveMeleeAttackDamage3 { get; } = new Effect("ImproveMeleeAttackDamage3", 5202);
//		/// <summary>
//		/// Description: "Equip: melee attack increase by 5 points."<para/>
//		/// Modifiers: [ +5 Attack ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ImproveMeleeAttackDamage5 { get; } = new Effect("ImproveMeleeAttackDamage5", 5203);
//		/// <summary>
//		/// Description: "Equip: melee attack increase by 7 points."<para/>
//		/// Modifiers: [ +7 Attack ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ImproveMeleeAttackDamage7 { get; } = new Effect("ImproveMeleeAttackDamage7", 5204);
//		/// <summary>
//		/// Description: "Equip: melee attack increase by 10 points."<para/>
//		/// Modifiers: [ +10 Attack ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ImproveMeleeAttackDamage10 { get; } = new Effect("ImproveMeleeAttackDamage10", 5205);
//		/// <summary>
//		/// Description: "Equip: attack increase by 10%."<para/>
//		/// Modifiers: [ +10% Attack ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect AttackDamageIncreasedBy10 { get; } = new Effect("AttackDamageIncreasedBy10", 5211);
//		/// <summary>
//		/// Description: "Equip: attack increase by 15%."<para/>
//		/// Modifiers: [ +15% Attack ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect AttackDamageIncreasedBy15 { get; } = new Effect("AttackDamageIncreasedBy15", 5212);
//		/// <summary>
//		/// Description: "Equip: attack increase by 20%."<para/>
//		/// Modifiers: [ +20% Attack ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect AttackDamageIncreasedBy20 { get; } = new Effect("AttackDamageIncreasedBy20", 5213);
//		/// <summary>
//		/// Description: "Equip: attack increase by 25%."<para/>
//		/// Modifiers: [ +25% Attack ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect AttackDamageIncreasedBy25 { get; } = new Effect("AttackDamageIncreasedBy25", 5214);
//		/// <summary>
//		/// Description: "Equip: attack increase by 30%."<para/>
//		/// Modifiers: [ +30% Attack ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect AttackDamageIncreasedBy30 { get; } = new Effect("AttackDamageIncreasedBy30", 5215);
//		/// <summary>
//		/// Description: "Equip: slower durability loss on armor by 20%."<para/>
//		/// Modifiers: [ -20% EquipmentWearSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect DurableProtection20 { get; } = new Effect("DurableProtection20", 5216);
//		/// <summary>
//		/// Description: "Equip: slower durability loss on armor by 25%."<para/>
//		/// Modifiers: [ -25% EquipmentWearSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect DurableProtection25 { get; } = new Effect("DurableProtection25", 5217);
//		/// <summary>
//		/// Description: "Equip: slower durability loss on armor by 30%."<para/>
//		/// Modifiers: [ -30% EquipmentWearSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect DurableProtection30 { get; } = new Effect("DurableProtection30", 5218);
//		/// <summary>
//		/// Description: "Equip: slower durability loss on armor by 35%."<para/>
//		/// Modifiers: [ -35% EquipmentWearSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect DurableProtection35 { get; } = new Effect("DurableProtection35", 5219);
//		/// <summary>
//		/// Description: "Equip: slower durability loss on armor by 40%."<para/>
//		/// Modifiers: [ -40% EquipmentWearSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect DurableProtection40 { get; } = new Effect("DurableProtection40", 5220);
//		/// <summary>
//		/// Description: "Equip: hunger speed decrease by 20%."<para/>
//		/// Modifiers: [ -20% HungerSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ReduceHungerConsumptionBy20 { get; } = new Effect("ReduceHungerConsumptionBy20", 5221);
//		/// <summary>
//		/// Description: "Equip: hunger speed decrease by 25%."<para/>
//		/// Modifiers: [ -25% HungerSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect HungerConsumptionReducedBy25 { get; } = new Effect("HungerConsumptionReducedBy25", 5222);
//		/// <summary>
//		/// Description: "Equip: hunger speed decrease by 30%."<para/>
//		/// Modifiers: [ -30% HungerSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ReduceHungerConsumptionBy30 { get; } = new Effect("ReduceHungerConsumptionBy30", 5223);
//		/// <summary>
//		/// Description: "Equip: hunger speed decrease by 35%."<para/>
//		/// Modifiers: [ -35% HungerSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ReducedHungerConsumptionBy35 { get; } = new Effect("ReducedHungerConsumptionBy35", 5224);
//		/// <summary>
//		/// Description: "Equip: hunger speed decrease by 40%."<para/>
//		/// Modifiers: [ -40% HungerSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ReducedHungerConsumptionBy40 { get; } = new Effect("ReducedHungerConsumptionBy40", 5225);
//		/// <summary>
//		/// Description: "Equip: build distance increase by 3."<para/>
//		/// Modifiers: [ +1.5 BuildRange ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ConstructionDistance3 { get; } = new Effect("ConstructionDistance3", 5226);
//		/// <summary>
//		/// Description: "Equip: build distance increase by 4."<para/>
//		/// Modifiers: [ +2 BuildRange ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ConstructionDistance4 { get; } = new Effect("ConstructionDistance4", 5227);
//		/// <summary>
//		/// Description: "Equip: build distance increase by 5."<para/>
//		/// Modifiers: [ +2.5 BuildRange ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ConstructionDistance5 { get; } = new Effect("ConstructionDistance5", 5228);
//		/// <summary>
//		/// Description: "Equip: build distance increase by 6."<para/>
//		/// Modifiers: [ +3 BuildRange ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ConstructionDistance6 { get; } = new Effect("ConstructionDistance6", 5229);
//		/// <summary>
//		/// Description: "Equip: build distance increase by 7."<para/>
//		/// Modifiers: [ +3.5 BuildRange ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ConstructionDistance7 { get; } = new Effect("ConstructionDistance7", 5230);
//		/// <summary>
//		/// Description: "Equip: restore a certain amount of HP when you kill a creature."<para/>
//		/// Modifiers: [ Vampirism ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WormNestBloodsuckingJewelry { get; } = new Effect("WormNestBloodsuckingJewelry", 5231);
//		/// <summary>
//		/// Description: "Equip: generate a poisonous spore that follows you around. The spore will cause poisonous gas once it explodes, and the gas will poison the enemies and cause them a decrease in walking speed by 25% and lose 3 HP for every second, lasts for 10 seconds."<para/>
//		/// Modifiers: [ PoisonOrb ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WormNestPufferfish { get; } = new Effect("WormNestPufferfish", 5232);
//		/// <summary>
//		/// Description: "Equip: can illuminate a certain range in front."<para/>
//		/// Modifiers: [ Flashlight ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Flashlight { get; } = new Effect("Flashlight", 5241);
//		/// <summary>
//		/// Description: "Equip: can detect metals."<para/>
//		/// Modifiers: [ MetalDetector ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect MinersLamp { get; } = new Effect("MinersLamp", 5242);
//		/// <summary>
//		/// Description: "Equip: restore 1 HP for every two seconds."<para/>
//		/// Modifiers: [ +0.5 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ParasytorSymbioticWorm { get; } = new Effect("ParasytorSymbioticWorm", 5243);
//		/// <summary>
//		/// Description: "Equip: eating speed increase by 50%."<para/>
//		/// Modifiers: [ +50% EatingSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect GoblinFork { get; } = new Effect("GoblinFork", 5244);
//		/// <summary>
//		/// Description: "Equip: attack speed increase by 10%."<para/>
//		/// Modifiers: [ +10% AttackSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect GoblinBracelet { get; } = new Effect("GoblinBracelet", 5245);
//		/// <summary>
//		/// Description: "Equip: defense increase by 20%."<para/>
//		/// Modifiers: [ +20% Defence ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect GoblinShield { get; } = new Effect("GoblinShield", 5246);
//		/// <summary>
//		/// Description: "Equip: defense increase by 8 points."<para/>
//		/// Modifiers: [ +8 Defence ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect InsectorElytronShield { get; } = new Effect("InsectorElytronShield", 5247);
//		/// <summary>
//		/// Description: "Equip: walking speed increase by 15%."<para/>
//		/// Modifiers: [ +15% MovementSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect InsectorWings { get; } = new Effect("InsectorWings", 5248);
//		/// <summary>
//		/// Description: "Equip: attack increase by 4 points."<para/>
//		/// Modifiers: [ +3 Attack ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ParasectThorn { get; } = new Effect("ParasectThorn", 5249);
//		/// <summary>
//		/// Description: "Equip: hunger speed decrease by 30%, and restore 1 HP for every seconds."<para/>
//		/// Modifiers: [ -30% HungerSpeed, +1 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect MecoLifeSupportDevice { get; } = new Effect("MecoLifeSupportDevice", 5250);
//		/// <summary>
//		/// Description: "Equip: defense increase by 30%."<para/>
//		/// Modifiers: [ +30% Defence ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect MecoShield { get; } = new Effect("MecoShield", 5251);
//		/// <summary>
//		/// Description: "Equip: eating speed increase by 100%."<para/>
//		/// Modifiers: [ +100% EatingSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect MecoElectricSpoon { get; } = new Effect("MecoElectricSpoon", 5252);
//		/// <summary>
//		/// Description: "Equip: attack speed increase by 15%."<para/>
//		/// Modifiers: [ +15% AttackSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect MecoPoweredExoskeletonArm { get; } = new Effect("MecoPoweredExoskeletonArm", 5253);
//		/// <summary>
//		/// Description: "Equip: attack increase by 15%."<para/>
//		/// Modifiers: [ +15% Attack ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect MecoBiotechPoweredExoskeletonArm { get; } = new Effect("MecoBiotechPoweredExoskeletonArm", 5254);
//		/// <summary>
//		/// Description: "Equip: gain a stack of amber shield every 6 seconds, and stacks up to 3 times. Each shield can withstand one attack. Generation of an amber shield will be stopped when you are being attacked."<para/>
//		/// Modifiers: [ AmberShield ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect UndergroundManShield { get; } = new Effect("UndergroundManShield", 5255);
//		/// <summary>
//		/// Description: "Equip: summon a modified detector that will follow you and help you to pick up items on the ground around you."<para/>
//		/// Modifiers: [ CollectorDrone ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect UndergroundMan { get; } = new Effect("UndergroundMan", 5256);
//		/// <summary>
//		/// Description: "Equip: can detect metals."<para/>
//		/// Modifiers: [ 1 LandMineDrone ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect BuriedDrone { get; } = new Effect("BuriedDrone", 5257);
//		/// <summary>
//		/// Description: "ImmuneStun"<para/>
//		/// Modifiers: [ 1 ImmuneDebuffStun ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Immunestun { get; } = new Effect("Immunestun", 9987);
//		/// <summary>
//		/// Description: "God Cure"<para/>
//		/// Modifiers: [ +0.01 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect GodCure { get; } = new Effect("GodCure", 9988);
//		/// <summary>
//		/// Description: "Dodge"<para/>
//		/// Modifiers: [ 1 OnHitProtect ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Dodge { get; } = new Effect("Dodge", 9989);
//		/// <summary>
//		/// Description: "ImmuneRemote"<para/>
//		/// Modifiers: [ 100% RangeDamageResistance ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Immuneremote { get; } = new Effect("Immuneremote", 9990);
//		/// <summary>
//		/// Description: "ImmuneExploed"<para/>
//		/// Modifiers: [ 100% ExplosiveDamageResistance ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Immuneexploed { get; } = new Effect("Immuneexploed", 9991);
//		/// <summary>
//		/// Description: "ImmuneTrap"<para/>
//		/// Modifiers: [ 100% TrapDamageResistance ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Immunetrap { get; } = new Effect("Immunetrap", 9992);
//		/// <summary>
//		/// Description: "ImmuneBuff"<para/>
//		/// Modifiers: [ 1 ImmuneBuffNoneType ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Immunebuff { get; } = new Effect("Immunebuff", 9993);
//		/// <summary>
//		/// Description: "ImmuneDebuff"<para/>
//		/// Modifiers: [ 1 ImmuneDebuffNoneType ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Immunedebuff { get; } = new Effect("Immunedebuff", 9994);
//		/// <summary>
//		/// Description: "ImmuneBleed"<para/>
//		/// Modifiers: [ 1 ImmuneDebuffBleed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Immunebleed { get; } = new Effect("Immunebleed", 9995);
//		/// <summary>
//		/// Description: "ImmunePoison"<para/>
//		/// Modifiers: [ 1 ImmuneDebuffPoison ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Immunepoison { get; } = new Effect("Immunepoison", 9996);
//		/// <summary>
//		/// Description: "Unlimited build distance."<para/>
//		/// Modifiers: [ +10 BuildRange ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect GodBuildingMode { get; } = new Effect("GodBuildingMode", 9997);
//		/// <summary>
//		/// Description: "Your body is still stiff and with no sense of pain."<para/>
//		/// Modifiers: [ +5000 Defence ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: 5s<para/>
//		/// </summary>
//		public static Effect Cloning { get; } = new Effect("Cloning", 9998);
//		/// <summary>
//		/// Description: "You're the god."<para/>
//		/// Modifiers: [ +10 HP/s, +999 Defence, Hunger += 3000 ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect GodMode { get; } = new Effect("GodMode", 9999);
//		/// <summary>
//		/// Description: "Gathering speed and eating speed both increase by 100%."<para/>
//		/// Modifiers: [ +100% EatingSpeed, +100% GatheringSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect HumanAdaptation { get; } = new Effect("HumanAdaptation", 10001);
//		/// <summary>
//		/// Description: "Attack increase by 1 points and attack increase by 10%."<para/>
//		/// Modifiers: [ +10% Attack, +1 Attack ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect BarbarianAnger { get; } = new Effect("BarbarianAnger", 10002);
//		/// <summary>
//		/// Description: "Walking speed increase by 10% and attack speed increase by 6%."<para/>
//		/// Modifiers: [ +10% MovementSpeed, +6% AttackSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect HalfElfSixthSense { get; } = new Effect("HalfElfSixthSense", 10003);
//		/// <summary>
//		/// Description: "Walking speed increase by 15%."<para/>
//		/// Modifiers: [ +15% MovementSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ElfLight { get; } = new Effect("ElfLight", 10004);
//		/// <summary>
//		/// Description: "Attack speed increase by 10%."<para/>
//		/// Modifiers: [ +10% AttackSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect BlackElfSwift { get; } = new Effect("BlackElfSwift", 10005);
//		/// <summary>
//		/// Description: "Attack increase by 7% and defense increase by 14%."<para/>
//		/// Modifiers: [ +7% Attack, +14% Defence ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect HalfOrcStrong { get; } = new Effect("HalfOrcStrong", 10006);
//		/// <summary>
//		/// Description: "Restore 1 HP for every two seconds."<para/>
//		/// Modifiers: [ +0.5 HP/s ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect MummyResurrection { get; } = new Effect("MummyResurrection", 10007);
//		/// <summary>
//		/// Description: "Defense increase by 3 points and defense increase by 20%."<para/>
//		/// Modifiers: [ +20% Defence, +3 Defence ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WildBoarThickSkin { get; } = new Effect("WildBoarThickSkin", 10008);
//		/// <summary>
//		/// Description: "Weapon - attack 5%"<para/>
//		/// Modifiers: [ +5% Attack ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WeaponAttack50 { get; } = new Effect("WeaponAttack50", 20001);
//		/// <summary>
//		/// Description: "Weapon - attack 10%"<para/>
//		/// Modifiers: [ +10% Attack ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WeaponAttack10 { get; } = new Effect("WeaponAttack10", 20002);
//		/// <summary>
//		/// Description: "Weapon - attack 15%"<para/>
//		/// Modifiers: [ +15% Attack ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WeaponAttack15 { get; } = new Effect("WeaponAttack15", 20003);
//		/// <summary>
//		/// Description: "Weapon - attack 20%"<para/>
//		/// Modifiers: [ +20% Attack ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WeaponAttack20 { get; } = new Effect("WeaponAttack20", 20004);
//		/// <summary>
//		/// Description: "Weapon - attack 2"<para/>
//		/// Modifiers: [ +2 Attack ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WeaponAttack2 { get; } = new Effect("WeaponAttack2", 20005);
//		/// <summary>
//		/// Description: "Weapon - attack 3"<para/>
//		/// Modifiers: [ +3 Attack ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WeaponAttack3 { get; } = new Effect("WeaponAttack3", 20006);
//		/// <summary>
//		/// Description: "Weapon - attack 5"<para/>
//		/// Modifiers: [ +5 Attack ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WeaponAttack51 { get; } = new Effect("WeaponAttack51", 20007);
//		/// <summary>
//		/// Description: "Weapon - attack 7"<para/>
//		/// Modifiers: [ +7 Attack ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WeaponAttack7 { get; } = new Effect("WeaponAttack7", 20008);
//		/// <summary>
//		/// Description: "Weapon - Durable consumption reduced by 20%"<para/>
//		/// Modifiers: [ -20% WeaponWearSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WeaponDurableConsumptionReducedBy20 { get; } = new Effect("WeaponDurableConsumptionReducedBy20", 20009);
//		/// <summary>
//		/// Description: "Weapon - Durable consumption reduced by 30%"<para/>
//		/// Modifiers: [ -30% WeaponWearSpeed ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WeaponDurableConsumptionReducedBy30 { get; } = new Effect("WeaponDurableConsumptionReducedBy30", 20010);
//		/// <summary>
//		/// Description: "Weapon - Durable consumption reduced by 40%"<para/>
//		/// Modifiers: [ -40% WeaponWearSpeed ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WeaponDurableConsumptionReducedBy40 { get; } = new Effect("WeaponDurableConsumptionReducedBy40", 20011);
//		/// <summary>
//		/// Description: "Weapon - Durable consumption reduced by 50%"<para/>
//		/// Modifiers: [ -50% WeaponWearSpeed ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WeaponDurableConsumptionReducedBy50 { get; } = new Effect("WeaponDurableConsumptionReducedBy50", 20012);
//		/// <summary>
//		/// Description: "Weapons - Kill Monsters Drop 10%"<para/>
//		/// Modifiers: [ +10% LootDrop ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WeaponsKillMonstersDrop10 { get; } = new Effect("WeaponsKillMonstersDrop10", 20013);
//		/// <summary>
//		/// Description: "Weapon - kill monsters drop 15%"<para/>
//		/// Modifiers: [ +15% LootDrop ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WeaponKillMonstersDrop15 { get; } = new Effect("WeaponKillMonstersDrop15", 20014);
//		/// <summary>
//		/// Description: "Weapons - Kill monsters drop 20%"<para/>
//		/// Modifiers: [ +20% LootDrop ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WeaponsKillMonstersDrop20 { get; } = new Effect("WeaponsKillMonstersDrop20", 20015);
//		/// <summary>
//		/// Description: "Weapon - kill monsters drop 25%"<para/>
//		/// Modifiers: [ +25% LootDrop ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WeaponKillMonstersDrop25 { get; } = new Effect("WeaponKillMonstersDrop25", 20016);
//		/// <summary>
//		/// Description: "Weapon - mineral drops 10%"<para/>
//		/// Modifiers: [ +10% OreDrop ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WeaponMineralDrops10 { get; } = new Effect("WeaponMineralDrops10", 20017);
//		/// <summary>
//		/// Description: "Weapon - mineral drop 15%"<para/>
//		/// Modifiers: [ +15% OreDrop ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WeaponMineralDrop15 { get; } = new Effect("WeaponMineralDrop15", 20018);
//		/// <summary>
//		/// Description: "Weapon - mineral drop 20%"<para/>
//		/// Modifiers: [ +20% OreDrop ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WeaponMineralDrop20 { get; } = new Effect("WeaponMineralDrop20", 20019);
//		/// <summary>
//		/// Description: "Weapons - mineral drops 25%"<para/>
//		/// Modifiers: [ +25% OreDrop ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect WeaponsMineralDrops25 { get; } = new Effect("WeaponsMineralDrops25", 20020);
//		/// <summary>
//		/// Description: "Melee - ignore target defense 20%"<para/>
//		/// Modifiers: [ 20% IgnoreDefence ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect MeleeIgnoreTargetDefense20 { get; } = new Effect("MeleeIgnoreTargetDefense20", 20021);
//		/// <summary>
//		/// Description: "Melee - ignore target defense 30%"<para/>
//		/// Modifiers: [ 30% IgnoreDefence ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect MeleeIgnoreTargetDefense30 { get; } = new Effect("MeleeIgnoreTargetDefense30", 20022);
//		/// <summary>
//		/// Description: "Melee - ignore target defense 40%"<para/>
//		/// Modifiers: [ 40% IgnoreDefence ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect MeleeIgnoreTargetDefense40 { get; } = new Effect("MeleeIgnoreTargetDefense40", 20023);
//		/// <summary>
//		/// Description: "Melee - ignore target defense 50%"<para/>
//		/// Modifiers: [ 50% IgnoreDefence ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect MeleeIgnoreTargetDefense50 { get; } = new Effect("MeleeIgnoreTargetDefense50", 20024);
//		/// <summary>
//		/// Description: "Remote-probability penetration 20%"<para/>
//		/// Modifiers: [ 20% PenetrationChance ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect RemoteProbabilityPenetration20 { get; } = new Effect("RemoteProbabilityPenetration20", 20025);
//		/// <summary>
//		/// Description: "Remote-probability penetration 30%"<para/>
//		/// Modifiers: [ 30% PenetrationChance ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect RemoteProbabilityPenetration30 { get; } = new Effect("RemoteProbabilityPenetration30", 20026);
//		/// <summary>
//		/// Description: "Remote-probability penetration 40%"<para/>
//		/// Modifiers: [ 40% PenetrationChance ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect RemoteProbabilityPenetration40 { get; } = new Effect("RemoteProbabilityPenetration40", 20027);
//		/// <summary>
//		/// Description: "Remote-probability penetration 50%"<para/>
//		/// Modifiers: [ 50% PenetrationChance ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect RemoteProbabilityPenetration50 { get; } = new Effect("RemoteProbabilityPenetration50", 20028);
//		/// <summary>
//		/// Description: "Remote - Repel 100"<para/>
//		/// Modifiers: [ +80 RangedKnockback ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect RemoteRepel80 { get; } = new Effect("RemoteRepel80", 20029);
//		/// <summary>
//		/// Description: "Remote - Repel 130"<para/>
//		/// Modifiers: [ +100 RangedKnockback ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect RemoteRepel100 { get; } = new Effect("RemoteRepel100", 20030);
//		/// <summary>
//		/// Description: "Remote - Repel 160"<para/>
//		/// Modifiers: [ +120 RangedKnockback ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect RemoteRepel120 { get; } = new Effect("RemoteRepel120", 20031);
//		/// <summary>
//		/// Description: "Remote - Repel 190"<para/>
//		/// Modifiers: [ +140 RangedKnockback ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect RemoteRepel140 { get; } = new Effect("RemoteRepel140", 20032);
//		/// <summary>
//		/// Description: "Bow Gun - Probability does not consume 20% of ammunition"<para/>
//		/// Modifiers: [ 20% AmmoSaveChance ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect BowGunProbabilityDoesNotConsume20OfAmmunition { get; } = new Effect("BowGunProbabilityDoesNotConsume20OfAmmunition", 20033);
//		/// <summary>
//		/// Description: "Bow Gun - Probability does not consume 25% of ammunition"<para/>
//		/// Modifiers: [ 25% AmmoSaveChance ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect BowGunProbabilityDoesNotConsume25OfAmmunition { get; } = new Effect("BowGunProbabilityDoesNotConsume25OfAmmunition", 20034);
//		/// <summary>
//		/// Description: "Bow Gun - Probability does not consume ammunition 30%"<para/>
//		/// Modifiers: [ 30% AmmoSaveChance ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect BowGunProbabilityDoesNotConsumeAmmunition30 { get; } = new Effect("BowGunProbabilityDoesNotConsumeAmmunition30", 20035);
//		/// <summary>
//		/// Description: "Bow Gun - Probability does not consume 35% of ammunition"<para/>
//		/// Modifiers: [ 35% AmmoSaveChance ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect BowGunProbabilityDoesNotConsume35OfAmmunition { get; } = new Effect("BowGunProbabilityDoesNotConsume35OfAmmunition", 20036);
//		/// <summary>
//		/// Description: "Armor - Defense 2"<para/>
//		/// Modifiers: [ +2 Defence ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ArmorDefense2 { get; } = new Effect("ArmorDefense2", 20037);
//		/// <summary>
//		/// Description: "Armor - Defense 4"<para/>
//		/// Modifiers: [ +4 Defence ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ArmorDefense4 { get; } = new Effect("ArmorDefense4", 20038);
//		/// <summary>
//		/// Description: "Armor - Defense 6"<para/>
//		/// Modifiers: [ +6 Defence ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ArmorDefense6 { get; } = new Effect("ArmorDefense6", 20039);
//		/// <summary>
//		/// Description: "Armor - Defense 8"<para/>
//		/// Modifiers: [ +8 Defence ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ArmorDefense8 { get; } = new Effect("ArmorDefense8", 20040);
//		/// <summary>
//		/// Description: "Armor - damage reduced by 6%"<para/>
//		/// Modifiers: [ 6% DamageResistance ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ArmorDamageReducedBy6 { get; } = new Effect("ArmorDamageReducedBy6", 20041);
//		/// <summary>
//		/// Description: "Armor - damage reduced by 9%"<para/>
//		/// Modifiers: [ 9% DamageResistance ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ArmorDamageReducedBy9 { get; } = new Effect("ArmorDamageReducedBy9", 20042);
//		/// <summary>
//		/// Description: "Armor - Damage reduced by 12%"<para/>
//		/// Modifiers: [ 12% DamageResistance ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ArmorDamageReducedBy12 { get; } = new Effect("ArmorDamageReducedBy12", 20043);
//		/// <summary>
//		/// Description: "Armor - damage reduced by 15%"<para/>
//		/// Modifiers: [ 15% DamageResistance ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ArmorDamageReducedBy15 { get; } = new Effect("ArmorDamageReducedBy15", 20044);
//		/// <summary>
//		/// Description: "Clothes - slow down the endurance consumption by 20%"<para/>
//		/// Modifiers: [ -20% ArmorWearSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ClothesSlowDownTheEnduranceConsumptionBy20 { get; } = new Effect("ClothesSlowDownTheEnduranceConsumptionBy20", 20045);
//		/// <summary>
//		/// Description: "Clothes - 30% reduction in endurance consumption"<para/>
//		/// Modifiers: [ -30% ArmorWearSpeed ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Clothes30ReductionInEnduranceConsumption { get; } = new Effect("Clothes30ReductionInEnduranceConsumption", 20046);
//		/// <summary>
//		/// Description: "Clothes - 40% reduction in endurance consumption"<para/>
//		/// Modifiers: [ -40% ArmorWearSpeed ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Clothes40ReductionInEnduranceConsumption { get; } = new Effect("Clothes40ReductionInEnduranceConsumption", 20047);
//		/// <summary>
//		/// Description: "Clothes - slow down the endurance consumption by 50%"<para/>
//		/// Modifiers: [ -50% ArmorWearSpeed ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ClothesSlowDownTheEnduranceConsumptionBy50 { get; } = new Effect("ClothesSlowDownTheEnduranceConsumptionBy50", 20048);
//		/// <summary>
//		/// Description: "Clothes - Defense increased by 15%"<para/>
//		/// Modifiers: [ +15% Defence ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ClothesDefenseIncreasedBy15 { get; } = new Effect("ClothesDefenseIncreasedBy15", 20049);
//		/// <summary>
//		/// Description: "Clothes - defense increased by 20%"<para/>
//		/// Modifiers: [ +20% Defence ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ClothesDefenseIncreasedBy20 { get; } = new Effect("ClothesDefenseIncreasedBy20", 20050);
//		/// <summary>
//		/// Description: "Clothes - Defense increased by 25%"<para/>
//		/// Modifiers: [ +25% Defence ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ClothesDefenseIncreasedBy25 { get; } = new Effect("ClothesDefenseIncreasedBy25", 20051);
//		/// <summary>
//		/// Description: "Clothes - defense increased by 30%"<para/>
//		/// Modifiers: [ +30% Defence ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ClothesDefenseIncreasedBy30 { get; } = new Effect("ClothesDefenseIncreasedBy30", 20052);
//		/// <summary>
//		/// Description: "Clothes - 25% protection"<para/>
//		/// Modifiers: [ 25% KnockbackResistance ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Clothes25Protection { get; } = new Effect("Clothes25Protection", 20053);
//		/// <summary>
//		/// Description: "Clothes - 50% protection"<para/>
//		/// Modifiers: [ 50% KnockbackResistance ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Clothes50Protection { get; } = new Effect("Clothes50Protection", 20054);
//		/// <summary>
//		/// Description: "Clothes - Repel protection 75%"<para/>
//		/// Modifiers: [ 75% KnockbackResistance ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ClothesRepelProtection75 { get; } = new Effect("ClothesRepelProtection75", 20055);
//		/// <summary>
//		/// Description: "Clothes - Repel protection 100%"<para/>
//		/// Modifiers: [ 100% KnockbackResistance ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ClothesRepelProtection100 { get; } = new Effect("ClothesRepelProtection100", 20056);
//		/// <summary>
//		/// Description: "Clothes - Explosive damage reduced by 15%"<para/>
//		/// Modifiers: [ 15% ExplosiveDamageResistance ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ClothesExplosiveDamageReducedBy15 { get; } = new Effect("ClothesExplosiveDamageReducedBy15", 20057);
//		/// <summary>
//		/// Description: "Clothes - Explosive damage reduced by 20%"<para/>
//		/// Modifiers: [ 20% ExplosiveDamageResistance ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ClothesExplosiveDamageReducedBy20 { get; } = new Effect("ClothesExplosiveDamageReducedBy20", 20058);
//		/// <summary>
//		/// Description: "Clothes - Explosive damage reduced by 25%"<para/>
//		/// Modifiers: [ 25% ExplosiveDamageResistance ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ClothesExplosiveDamageReducedBy25 { get; } = new Effect("ClothesExplosiveDamageReducedBy25", 20059);
//		/// <summary>
//		/// Description: "Clothes - Explosive damage reduced by 30%"<para/>
//		/// Modifiers: [ 30% ExplosiveDamageResistance ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ClothesExplosiveDamageReducedBy30 { get; } = new Effect("ClothesExplosiveDamageReducedBy30", 20060);
//		/// <summary>
//		/// Description: "Clothes - Remote Damage reduced by 15%"<para/>
//		/// Modifiers: [ 15% RangeDamageResistance ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ClothesRemoteDamageReducedBy15 { get; } = new Effect("ClothesRemoteDamageReducedBy15", 20061);
//		/// <summary>
//		/// Description: "Clothes - 20% reduction in range damage"<para/>
//		/// Modifiers: [ 20% RangeDamageResistance ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Clothes20ReductionInRangeDamage { get; } = new Effect("Clothes20ReductionInRangeDamage", 20062);
//		/// <summary>
//		/// Description: "Clothes - Remote damage reduced by 25%"<para/>
//		/// Modifiers: [ 25% RangeDamageResistance ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ClothesRemoteDamageReducedBy25 { get; } = new Effect("ClothesRemoteDamageReducedBy25", 20063);
//		/// <summary>
//		/// Description: "Clothes - Remote damage reduced by 30%"<para/>
//		/// Modifiers: [ 30% RangeDamageResistance ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ClothesRemoteDamageReducedBy30 { get; } = new Effect("ClothesRemoteDamageReducedBy30", 20064);
//		/// <summary>
//		/// Description: "Gloves - Reduces endurance consumption by 20%"<para/>
//		/// Modifiers: [ -20% GlovesWearSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect GlovesReducesEnduranceConsumptionBy20 { get; } = new Effect("GlovesReducesEnduranceConsumptionBy20", 20065);
//		/// <summary>
//		/// Description: "Gloves - Reduces endurance consumption by 30%"<para/>
//		/// Modifiers: [ -30% GlovesWearSpeed ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect GlovesReducesEnduranceConsumptionBy30 { get; } = new Effect("GlovesReducesEnduranceConsumptionBy30", 20066);
//		/// <summary>
//		/// Description: "Gloves - Reduces endurance consumption by 40%"<para/>
//		/// Modifiers: [ -40% GlovesWearSpeed ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect GlovesReducesEnduranceConsumptionBy40 { get; } = new Effect("GlovesReducesEnduranceConsumptionBy40", 20067);
//		/// <summary>
//		/// Description: "Gloves - Reduces endurance consumption by 50%"<para/>
//		/// Modifiers: [ -50% GlovesWearSpeed ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect GlovesReducesEnduranceConsumptionBy50 { get; } = new Effect("GlovesReducesEnduranceConsumptionBy50", 20068);
//		/// <summary>
//		/// Description: "Gloves - eating up to 40% faster"<para/>
//		/// Modifiers: [ +40% EatingSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect GlovesEatingUpTo40Faster { get; } = new Effect("GlovesEatingUpTo40Faster", 20069);
//		/// <summary>
//		/// Description: "Gloves - 60% faster eating"<para/>
//		/// Modifiers: [ +60% EatingSpeed ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Gloves60FasterEating { get; } = new Effect("Gloves60FasterEating", 20070);
//		/// <summary>
//		/// Description: "Gloves - Eat 80% faster"<para/>
//		/// Modifiers: [ +80% EatingSpeed ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect GlovesEat80Faster { get; } = new Effect("GlovesEat80Faster", 20071);
//		/// <summary>
//		/// Description: "Gloves - Eat 100% faster"<para/>
//		/// Modifiers: [ +100% EatingSpeed ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect GlovesEat100Faster { get; } = new Effect("GlovesEat100Faster", 20072);
//		/// <summary>
//		/// Description: "Gloves - Acquisition Acceleration 40%"<para/>
//		/// Modifiers: [ +40% GatheringSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect GlovesAcquisitionAcceleration40 { get; } = new Effect("GlovesAcquisitionAcceleration40", 20073);
//		/// <summary>
//		/// Description: "Gloves - Acquisition Acceleration 60%"<para/>
//		/// Modifiers: [ +60% GatheringSpeed ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect GlovesAcquisitionAcceleration60 { get; } = new Effect("GlovesAcquisitionAcceleration60", 20074);
//		/// <summary>
//		/// Description: "Gloves - Acquisition Acceleration 80%"<para/>
//		/// Modifiers: [ +80% GatheringSpeed ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect GlovesAcquisitionAcceleration80 { get; } = new Effect("GlovesAcquisitionAcceleration80", 20075);
//		/// <summary>
//		/// Description: "Gloves - Acquisition Acceleration 100%"<para/>
//		/// Modifiers: [ +100% GatheringSpeed ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect GlovesAcquisitionAcceleration100 { get; } = new Effect("GlovesAcquisitionAcceleration100", 20076);
//		/// <summary>
//		/// Description: "Gloves - Axe, 镐 attack speed increased by 15%"<para/>
//		/// Modifiers: [ +15% AxeSpeed, +15% PickaxeSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect GlovesAxeAttackSpeedIncreasedBy15 { get; } = new Effect("GlovesAxeAttackSpeedIncreasedBy15", 20077);
//		/// <summary>
//		/// Description: "Gloves - Axe, 镐 attack speed increased by 20%"<para/>
//		/// Modifiers: [ +20% AxeSpeed, +20% PickaxeSpeed ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect GlovesAxeAttackSpeedIncreasedBy20 { get; } = new Effect("GlovesAxeAttackSpeedIncreasedBy20", 20078);
//		/// <summary>
//		/// Description: "Gloves - Axe, 镐 attack speed increased by 25%"<para/>
//		/// Modifiers: [ +25% AxeSpeed, +25% PickaxeSpeed ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect GlovesAxeAttackSpeedIncreasedBy25 { get; } = new Effect("GlovesAxeAttackSpeedIncreasedBy25", 20079);
//		/// <summary>
//		/// Description: "Gloves - Axe, 镐 attack speed increased by 30%"<para/>
//		/// Modifiers: [ +30% AxeSpeed, +30% PickaxeSpeed ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect GlovesAxeAttackSpeedIncreasedBy30 { get; } = new Effect("GlovesAxeAttackSpeedIncreasedBy30", 20080);
//		/// <summary>
//		/// Description: "Shoes - slow down endurance consumption by 20%"<para/>
//		/// Modifiers: [ -20% ShoesWearSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ShoesSlowDownEnduranceConsumptionBy20 { get; } = new Effect("ShoesSlowDownEnduranceConsumptionBy20", 20081);
//		/// <summary>
//		/// Description: "Shoes - Reduces endurance consumption by 30%"<para/>
//		/// Modifiers: [ -30% ShoesWearSpeed ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ShoesReducesEnduranceConsumptionBy30 { get; } = new Effect("ShoesReducesEnduranceConsumptionBy30", 20082);
//		/// <summary>
//		/// Description: "Shoes - 40% reduction in endurance consumption"<para/>
//		/// Modifiers: [ -40% ShoesWearSpeed ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect Shoes40ReductionInEnduranceConsumption { get; } = new Effect("Shoes40ReductionInEnduranceConsumption", 20083);
//		/// <summary>
//		/// Description: "Shoes - slow down the endurance consumption by 50%"<para/>
//		/// Modifiers: [ -50% ShoesWearSpeed ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ShoesSlowDownTheEnduranceConsumptionBy50 { get; } = new Effect("ShoesSlowDownTheEnduranceConsumptionBy50", 20084);
//		/// <summary>
//		/// Description: "Shoes - move up 10%"<para/>
//		/// Modifiers: [ +10% MovementSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ShoesMoveUp10 { get; } = new Effect("ShoesMoveUp10", 20085);
//		/// <summary>
//		/// Description: "Shoes - move up 15%"<para/>
//		/// Modifiers: [ +15% MovementSpeed ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ShoesMoveUp15 { get; } = new Effect("ShoesMoveUp15", 20086);
//		/// <summary>
//		/// Description: "Shoes - move up 20%"<para/>
//		/// Modifiers: [ +20% MovementSpeed ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ShoesMoveUp20 { get; } = new Effect("ShoesMoveUp20", 20087);
//		/// <summary>
//		/// Description: "Shoes - move up 25%"<para/>
//		/// Modifiers: [ +25% MovementSpeed ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ShoesMoveUp25 { get; } = new Effect("ShoesMoveUp25", 20088);
//		/// <summary>
//		/// Description: "Shoes - reduce hunger by 10%"<para/>
//		/// Modifiers: [ -10% HungerSpeed ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ShoesReduceHungerBy10 { get; } = new Effect("ShoesReduceHungerBy10", 20089);
//		/// <summary>
//		/// Description: "Shoes - reduce hunger by 20%"<para/>
//		/// Modifiers: [ -20% HungerSpeed ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ShoesReduceHungerBy20 { get; } = new Effect("ShoesReduceHungerBy20", 20090);
//		/// <summary>
//		/// Description: "Shoes - reduce hunger by 30%"<para/>
//		/// Modifiers: [ -30% HungerSpeed ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ShoesReduceHungerBy30 { get; } = new Effect("ShoesReduceHungerBy30", 20091);
//		/// <summary>
//		/// Description: "Shoes - reduce hunger by 40%"<para/>
//		/// Modifiers: [ -40% HungerSpeed ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ShoesReduceHungerBy40 { get; } = new Effect("ShoesReduceHungerBy40", 20092);
//		/// <summary>
//		/// Description: "Shoes - reduce trap damage by 20%"<para/>
//		/// Modifiers: [ 20% TrapDamageResistance ]<para/>
//		/// Tier: 1<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ShoesReduceTrapDamageBy20 { get; } = new Effect("ShoesReduceTrapDamageBy20", 20093);
//		/// <summary>
//		/// Description: "Shoes - reduce trap damage by 30%"<para/>
//		/// Modifiers: [ 30% TrapDamageResistance ]<para/>
//		/// Tier: 2<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ShoesReduceTrapDamageBy30 { get; } = new Effect("ShoesReduceTrapDamageBy30", 20094);
//		/// <summary>
//		/// Description: "Shoes - reduce trap damage by 40%"<para/>
//		/// Modifiers: [ 40% TrapDamageResistance ]<para/>
//		/// Tier: 3<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ShoesReduceTrapDamageBy40 { get; } = new Effect("ShoesReduceTrapDamageBy40", 20095);
//		/// <summary>
//		/// Description: "Shoes - reduce trap damage by 50%"<para/>
//		/// Modifiers: [ 50% TrapDamageResistance ]<para/>
//		/// Tier: 4<para/>
//		/// Duration: ∞<para/>
//		/// </summary>
//		public static Effect ShoesReduceTrapDamageBy50 { get; } = new Effect("ShoesReduceTrapDamageBy50", 20096);
//	}
//}
