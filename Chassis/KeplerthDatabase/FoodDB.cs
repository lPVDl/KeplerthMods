//namespace ChassisMod.KeplerthDatabase
//{
//	public static class FoodDB
//	{
//		/// <summary>
//		/// PlayerHealth: 4%<para/>
//		/// PlayerSatiety: 7%<para/>
//		/// MinionHealth: 12%<para/>
//		/// MinionSatiety: 21%<para/>
//		/// BreedingSatiety: 4u<para/>
//		/// </summary>
//		public static Food Apple { get; } = new Food("Apple", 1);
//		/// <summary>
//		/// PlayerHealth: 6%<para/>
//		/// PlayerSatiety: 5%<para/>
//		/// MinionHealth: 18%<para/>
//		/// MinionSatiety: 15%<para/>
//		/// BreedingSatiety: 4u<para/>
//		/// </summary>
//		public static Food Berries { get; } = new Food("Berries", 2);
//		/// <summary>
//		/// PlayerSatiety: 10%<para/>
//		/// MinionSatiety: 30%<para/>
//		/// BreedingSatiety: 6u<para/>
//		/// </summary>
//		public static Food CompressedCookie { get; } = new Food("CompressedCookie", 3);
//		/// <summary>
//		/// Description: "Use: restore 1 HP for every second, lasts for 10 seconds."<para/>
//		/// Effect: [ Recovery ]<para/>
//		/// PlayerHealth: 10%<para/>
//		/// PlayerSatiety: 1%<para/>
//		/// MinionHealth: 60%<para/>
//		/// MinionSatiety: 3%<para/>
//		/// BreedingSatiety: 5u<para/>
//		/// </summary>
//		public static Food Nectar { get; } = new Food("Nectar", 4);
//		/// <summary>
//		/// Description: "Use: Get one of the mutated effects."<para/>
//		/// RandomEffect: 1 -> [ MutatedLeg, MutatedArm, MutatedSkin ]<para/>
//		/// PlayerSatiety: 10%<para/>
//		/// MinionSatiety: 30%<para/>
//		/// BreedingSatiety: 10u<para/>
//		/// </summary>
//		public static Food MonsterMeat { get; } = new Food("MonsterMeat", 5);
//		/// <summary>
//		/// PlayerSatiety: 12%<para/>
//		/// MinionSatiety: 36%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food ChickenMeat { get; } = new Food("ChickenMeat", 6);
//		/// <summary>
//		/// PlayerSatiety: 12%<para/>
//		/// MinionSatiety: 36%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food DogMeat { get; } = new Food("DogMeat", 7);
//		/// <summary>
//		/// PlayerSatiety: 12%<para/>
//		/// MinionSatiety: 36%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food Lamb { get; } = new Food("Lamb", 8);
//		/// <summary>
//		/// PlayerSatiety: 12%<para/>
//		/// MinionSatiety: 36%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food Pork { get; } = new Food("Pork", 9);
//		/// <summary>
//		/// PlayerSatiety: 12%<para/>
//		/// MinionSatiety: 36%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food Beef { get; } = new Food("Beef", 10);
//		/// <summary>
//		/// PlayerSatiety: 6%<para/>
//		/// MinionSatiety: 18%<para/>
//		/// BreedingSatiety: 6u<para/>
//		/// </summary>
//		public static Food Egg { get; } = new Food("Egg", 11);
//		/// <summary>
//		/// Effect: [ ToxinV ]<para/>
//		/// PlayerSatiety: 3%<para/>
//		/// MinionSatiety: 9%<para/>
//		/// </summary>
//		public static Food VenomSac { get; } = new Food("VenomSac", 12);
//		/// <summary>
//		/// Description: "Use: walking speed decrease by 25%, lasts for 1 minitue"<para/>
//		/// Effect: [ Nausea ]<para/>
//		/// PlayerSatiety: 10%<para/>
//		/// MinionSatiety: 30%<para/>
//		/// BreedingSatiety: 7u<para/>
//		/// </summary>
//		public static Food DisgustingOrgans { get; } = new Food("DisgustingOrgans", 13);
//		/// <summary>
//		/// PlayerSatiety: 10%<para/>
//		/// MinionSatiety: 30%<para/>
//		/// BreedingSatiety: 10u<para/>
//		/// </summary>
//		public static Food Jerky { get; } = new Food("Jerky", 17);
//		/// <summary>
//		/// Description: "Use: after using this,the stinky smell on you will attract the Boar King!"<para/>
//		/// PlayerHealth: 10%<para/>
//		/// PlayerSatiety: 5%<para/>
//		/// MinionHealth: 30%<para/>
//		/// MinionSatiety: 15%<para/>
//		/// BreedingSatiety: 20u<para/>
//		/// SpecialEvent: #1<para/>
//		/// </summary>
//		public static Food WildBoarGlands { get; } = new Food("WildBoarGlands", 18);
//		/// <summary>
//		/// Description: "Use: attract chickens around you, lasts for 30 seconds."<para/>
//		/// Effect: [ PheromonesChicken ]<para/>
//		/// BreedingSatiety: 1u<para/>
//		/// </summary>
//		public static Food PheromonesChicken { get; } = new Food("PheromonesChicken", 19);
//		/// <summary>
//		/// Description: "Use: attract goats around you, lasts for 30 seconds."<para/>
//		/// Effect: [ PheromonesGoat ]<para/>
//		/// BreedingSatiety: 1u<para/>
//		/// </summary>
//		public static Food PheromonesGoat { get; } = new Food("PheromonesGoat", 20);
//		/// <summary>
//		/// Description: "Use: attract pigs around you, lasts for 30 seconds."<para/>
//		/// Effect: [ PheromonesPig ]<para/>
//		/// BreedingSatiety: 1u<para/>
//		/// </summary>
//		public static Food PheromonesPig { get; } = new Food("PheromonesPig", 21);
//		/// <summary>
//		/// Description: "Use: attract cows around you, lasts for 30 seconds."<para/>
//		/// Effect: [ PheromonesCow ]<para/>
//		/// BreedingSatiety: 1u<para/>
//		/// </summary>
//		public static Food PheromonesCow { get; } = new Food("PheromonesCow", 22);
//		/// <summary>
//		/// Description: "Use: attract horses around you, lasts for 30 seconds."<para/>
//		/// Effect: [ PheromonesHorse ]<para/>
//		/// BreedingSatiety: 1u<para/>
//		/// </summary>
//		public static Food PheromonesHorse { get; } = new Food("PheromonesHorse", 23);
//		/// <summary>
//		/// PlayerSatiety: 12%<para/>
//		/// MinionSatiety: 36%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food HorseMeat { get; } = new Food("HorseMeat", 24);
//		/// <summary>
//		/// BreedingSatiety: 2u<para/>
//		/// </summary>
//		public static Food RedMushroom { get; } = new Food("RedMushroom", 502);
//		/// <summary>
//		/// PlayerHealth: 35%<para/>
//		/// MinionHealth: 100%<para/>
//		/// </summary>
//		public static Food Bandage { get; } = new Food("Bandage", 601);
//		/// <summary>
//		/// PlayerHealth: 50%<para/>
//		/// MinionHealth: 100%<para/>
//		/// </summary>
//		public static Food PainKiller { get; } = new Food("PainKiller", 602);
//		/// <summary>
//		/// PlayerHealth: 75%<para/>
//		/// MinionHealth: 100%<para/>
//		/// </summary>
//		public static Food FirstAidKit { get; } = new Food("FirstAidKit", 603);
//		/// <summary>
//		/// PlayerHealth: 100%<para/>
//		/// MinionHealth: 100%<para/>
//		/// </summary>
//		public static Food NanoCapsule { get; } = new Food("NanoCapsule", 604);
//		/// <summary>
//		/// PlayerHealth: 100%<para/>
//		/// MinionHealth: 100%<para/>
//		/// </summary>
//		public static Food LifeAgentV { get; } = new Food("LifeAgentV", 605);
//		/// <summary>
//		/// Effect: [ HealingI ]<para/>
//		/// </summary>
//		public static Food HealingAgentI { get; } = new Food("HealingAgentI", 606);
//		/// <summary>
//		/// Effect: [ HealingII ]<para/>
//		/// </summary>
//		public static Food HealingAgentII { get; } = new Food("HealingAgentII", 607);
//		/// <summary>
//		/// Effect: [ HealingIII ]<para/>
//		/// </summary>
//		public static Food HealingAgentIII { get; } = new Food("HealingAgentIII", 608);
//		/// <summary>
//		/// Effect: [ HealingIV ]<para/>
//		/// </summary>
//		public static Food HealingAgentIV { get; } = new Food("HealingAgentIV", 609);
//		/// <summary>
//		/// Effect: [ HealingV ]<para/>
//		/// </summary>
//		public static Food HealingAgentV { get; } = new Food("HealingAgentV", 610);
//		/// <summary>
//		/// Effect: [ HealingI ]<para/>
//		/// PlayerHealth: 20%<para/>
//		/// MinionHealth: 60%<para/>
//		/// </summary>
//		public static Food RecoveryAgentI { get; } = new Food("RecoveryAgentI", 611);
//		/// <summary>
//		/// Effect: [ HealingII ]<para/>
//		/// PlayerHealth: 30%<para/>
//		/// MinionHealth: 90%<para/>
//		/// </summary>
//		public static Food RecoveryAgentII { get; } = new Food("RecoveryAgentII", 612);
//		/// <summary>
//		/// Effect: [ HealingIII ]<para/>
//		/// PlayerHealth: 40%<para/>
//		/// MinionHealth: 100%<para/>
//		/// </summary>
//		public static Food RecoveryAgentIII { get; } = new Food("RecoveryAgentIII", 613);
//		/// <summary>
//		/// Effect: [ HealingIV ]<para/>
//		/// PlayerHealth: 50%<para/>
//		/// MinionHealth: 100%<para/>
//		/// </summary>
//		public static Food RecoveryAgentIV { get; } = new Food("RecoveryAgentIV", 614);
//		/// <summary>
//		/// Effect: [ HealingV ]<para/>
//		/// PlayerHealth: 60%<para/>
//		/// MinionHealth: 100%<para/>
//		/// </summary>
//		public static Food RecoveryAgentV { get; } = new Food("RecoveryAgentV", 615);
//		/// <summary>
//		/// Description: "Use: increase attack speed and walking speed by 20%, hunger speed will also be increased. Lasts for 1 minitue."<para/>
//		/// Effect: [ StimulantsI ]<para/>
//		/// </summary>
//		public static Food StimulantsI { get; } = new Food("StimulantsI", 616);
//		/// <summary>
//		/// Description: "Use: increase attack speed and walking speed by 40% , hunger speed will also be substantially increased. Lasts for 1 minute."<para/>
//		/// Effect: [ StimulantsII ]<para/>
//		/// </summary>
//		public static Food StimulantsII { get; } = new Food("StimulantsII", 617);
//		/// <summary>
//		/// Description: "Use: increase attack speed and walking speed by 60%, lasts for 1 minute. Satiety will be decreased to 0 once the effect is over."<para/>
//		/// Effect: [ StimulantsIII ]<para/>
//		/// </summary>
//		public static Food StimulantsIII { get; } = new Food("StimulantsIII", 618);
//		/// <summary>
//		/// Effect: [ Excited ]<para/>
//		/// </summary>
//		public static Food StimulantIV { get; } = new Food("StimulantIV", 619);
//		/// <summary>
//		/// Effect: [ Excited ]<para/>
//		/// </summary>
//		public static Food StimulantV { get; } = new Food("StimulantV", 620);
//		/// <summary>
//		/// Effect: [ NightVision ]<para/>
//		/// </summary>
//		public static Food NightVisionAgent { get; } = new Food("NightVisionAgent", 621);
//		/// <summary>
//		/// Effect: [ Stealth ]<para/>
//		/// </summary>
//		public static Food StealthPotion { get; } = new Food("StealthPotion", 622);
//		/// <summary>
//		/// Effect: [ Hallucinations ]<para/>
//		/// </summary>
//		public static Food Hallucinogenic { get; } = new Food("Hallucinogenic", 623);
//		/// <summary>
//		/// </summary>
//		public static Food XXMedicine0 { get; } = new Food("XXMedicine0", 624);
//		/// <summary>
//		/// </summary>
//		public static Food XXMedicine1 { get; } = new Food("XXMedicine1", 625);
//		/// <summary>
//		/// Description: "Use: increase attack by 2 points, lasts for 10 minutes."<para/>
//		/// Effect: [ StrengthI ]<para/>
//		/// </summary>
//		public static Food DamagedATKCapsule { get; } = new Food("DamagedATKCapsule", 626);
//		/// <summary>
//		/// Description: "Use: increase attack by 3 points, lasts for 10 minutes."<para/>
//		/// Effect: [ StrengthII ]<para/>
//		/// </summary>
//		public static Food ExpiredATKCapsule { get; } = new Food("ExpiredATKCapsule", 627);
//		/// <summary>
//		/// Description: "Use: increase attack by 4 points, lasts for 10 minutes."<para/>
//		/// Effect: [ StrengthIII ]<para/>
//		/// </summary>
//		public static Food ATKCapsule { get; } = new Food("ATKCapsule", 628);
//		/// <summary>
//		/// Description: "Use: increase attack by 6 points, lasts for 10 minutes."<para/>
//		/// Effect: [ StrengthIV ]<para/>
//		/// </summary>
//		public static Food ATKCapsuleExtra { get; } = new Food("ATKCapsuleExtra", 629);
//		/// <summary>
//		/// Description: "Use: increase attack by 9 points, lasts for 10 minutes."<para/>
//		/// Effect: [ StrengthV ]<para/>
//		/// </summary>
//		public static Food ATKCapsuleExtraAdvance { get; } = new Food("ATKCapsuleExtraAdvance", 630);
//		/// <summary>
//		/// Description: "Use: increase defense by 3 points, lasts for 10 minutes."<para/>
//		/// Effect: [ EnduranceI ]<para/>
//		/// </summary>
//		public static Food DamagedDEFCapsule { get; } = new Food("DamagedDEFCapsule", 631);
//		/// <summary>
//		/// Description: "Use: increase defense by 5 points, lasts for 10 minutes."<para/>
//		/// Effect: [ EnduranceII ]<para/>
//		/// </summary>
//		public static Food ExpiredDEFCapsule { get; } = new Food("ExpiredDEFCapsule", 632);
//		/// <summary>
//		/// Description: "Use: increase defense by 8 points, lasts for 10 minutes."<para/>
//		/// Effect: [ EnduranceIII ]<para/>
//		/// </summary>
//		public static Food DEFCapsule { get; } = new Food("DEFCapsule", 633);
//		/// <summary>
//		/// Description: "Use: increase defense by 12 points, lasts for 10 minutes."<para/>
//		/// Effect: [ EnduranceIV ]<para/>
//		/// </summary>
//		public static Food DEFCapsuleExtra { get; } = new Food("DEFCapsuleExtra", 634);
//		/// <summary>
//		/// Description: "Use: increase defense by 19 points, lasts for 10 minutes."<para/>
//		/// Effect: [ EnduranceV ]<para/>
//		/// </summary>
//		public static Food DEFCapsuleExtraAdvance { get; } = new Food("DEFCapsuleExtraAdvance", 635);
//		/// <summary>
//		/// Description: "Use: increase walking speed by 10%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken."<para/>
//		/// Effect: [ SpeedI ]<para/>
//		/// </summary>
//		public static Food DamagedAGLPotion { get; } = new Food("DamagedAGLPotion", 636);
//		/// <summary>
//		/// Description: "Use: increase walking speed by 15%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken."<para/>
//		/// Effect: [ SpeedII ]<para/>
//		/// </summary>
//		public static Food ExpiredAGLPotion { get; } = new Food("ExpiredAGLPotion", 637);
//		/// <summary>
//		/// Description: "Use: increase walking speed by 20%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken."<para/>
//		/// Effect: [ SpeedIII ]<para/>
//		/// </summary>
//		public static Food AGLPotion { get; } = new Food("AGLPotion", 638);
//		/// <summary>
//		/// Description: "Use: increase walking speed by 25%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken."<para/>
//		/// Effect: [ SpeedIV ]<para/>
//		/// </summary>
//		public static Food AGLPotionExtra { get; } = new Food("AGLPotionExtra", 639);
//		/// <summary>
//		/// Description: "Use: increase walking speed by 30%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken."<para/>
//		/// Effect: [ SpeedV ]<para/>
//		/// </summary>
//		public static Food AGLPotionExtraAdvance { get; } = new Food("AGLPotionExtraAdvance", 640);
//		/// <summary>
//		/// Description: "Use: increase attack speed by 10%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken."<para/>
//		/// Effect: [ AgilityI ]<para/>
//		/// </summary>
//		public static Food MecoJoyfulI { get; } = new Food("MecoJoyfulI", 641);
//		/// <summary>
//		/// Description: "Use: increase attack speed by 15%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken."<para/>
//		/// Effect: [ AgilityII ]<para/>
//		/// </summary>
//		public static Food MecoJoyfulII { get; } = new Food("MecoJoyfulII", 642);
//		/// <summary>
//		/// Description: "Use: increase attack speed by 20%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken."<para/>
//		/// Effect: [ AgilityIII ]<para/>
//		/// </summary>
//		public static Food MecoJoyfulIII { get; } = new Food("MecoJoyfulIII", 643);
//		/// <summary>
//		/// Description: "Use: increase attack speed by 25%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken."<para/>
//		/// Effect: [ AgilityIV ]<para/>
//		/// </summary>
//		public static Food MecoJoyfulIV { get; } = new Food("MecoJoyfulIV", 644);
//		/// <summary>
//		/// Description: "Use: increase attack speed by 30%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken."<para/>
//		/// Effect: [ AgilityV ]<para/>
//		/// </summary>
//		public static Food MecoJoyfulV { get; } = new Food("MecoJoyfulV", 645);
//		/// <summary>
//		/// Description: "Press the button! It will take you back home through the rift."<para/>
//		/// SpecialEvent: #2<para/>
//		/// </summary>
//		public static Food RifterStone { get; } = new Food("RifterStone", 901);
//		/// <summary>
//		/// Description: "Use: after using this, you will attract an angry Coopapa!"<para/>
//		/// PlayerHealth: 10%<para/>
//		/// MinionHealth: 30%<para/>
//		/// SpecialEvent: #3<para/>
//		/// </summary>
//		public static Food CoocooJelly { get; } = new Food("CoocooJelly", 902);
//		/// <summary>
//		/// Description: "Summon a friendly Coocoo, but the Coocoo will vanish after 2 minutes."<para/>
//		/// SpecialEvent: #4<para/>
//		/// Cooldown: 300s<para/>
//		/// </summary>
//		public static Food DollCoocoo { get; } = new Food("DollCoocoo", 903);
//		/// <summary>
//		/// Description: "Use: place a coocoo bomb. It will explode after 8 seconds and cause 40 damage."<para/>
//		/// SpecialEvent: #5<para/>
//		/// Cooldown: 15s<para/>
//		/// </summary>
//		public static Food CoocooBomb { get; } = new Food("CoocooBomb", 904);
//		/// <summary>
//		/// BreedingSatiety: 2u<para/>
//		/// </summary>
//		public static Food BloodMushroom { get; } = new Food("BloodMushroom", 3223);
//		/// <summary>
//		/// BreedingSatiety: 2u<para/>
//		/// </summary>
//		public static Food Grass { get; } = new Food("Grass", 9002);
//		/// <summary>
//		/// PlayerSatiety: 15%<para/>
//		/// MinionSatiety: 45%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food RoastedChicken { get; } = new Food("RoastedChicken", 10001);
//		/// <summary>
//		/// PlayerSatiety: 15%<para/>
//		/// MinionSatiety: 45%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food RoastedDogMeat { get; } = new Food("RoastedDogMeat", 10002);
//		/// <summary>
//		/// PlayerSatiety: 15%<para/>
//		/// MinionSatiety: 45%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food RoastedLamb { get; } = new Food("RoastedLamb", 10003);
//		/// <summary>
//		/// PlayerSatiety: 15%<para/>
//		/// MinionSatiety: 45%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food RoastedPork { get; } = new Food("RoastedPork", 10004);
//		/// <summary>
//		/// PlayerSatiety: 15%<para/>
//		/// MinionSatiety: 45%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food RoastedBeef { get; } = new Food("RoastedBeef", 10005);
//		/// <summary>
//		/// PlayerSatiety: 7%<para/>
//		/// MinionSatiety: 21%<para/>
//		/// BreedingSatiety: 7u<para/>
//		/// </summary>
//		public static Food RoastedEgg { get; } = new Food("RoastedEgg", 10006);
//		/// <summary>
//		/// Description: "Use: Get one of the mutated effects."<para/>
//		/// RandomEffect: 1 -> [ MutatedLeg, MutatedArm, MutatedSkin ]<para/>
//		/// PlayerSatiety: 12%<para/>
//		/// MinionSatiety: 36%<para/>
//		/// BreedingSatiety: 10u<para/>
//		/// </summary>
//		public static Food RoastedMonsterMeat { get; } = new Food("RoastedMonsterMeat", 10007);
//		/// <summary>
//		/// Description: "Use: walking speed decrease by 25%, lasts for 1 minutes."<para/>
//		/// Effect: [ Nausea ]<para/>
//		/// PlayerSatiety: 12%<para/>
//		/// MinionSatiety: 36%<para/>
//		/// BreedingSatiety: 7u<para/>
//		/// </summary>
//		public static Food RoastedDisgustingOrgans { get; } = new Food("RoastedDisgustingOrgans", 10008);
//		/// <summary>
//		/// Description: "Use: Get one of the mushroom toxin effects."<para/>
//		/// RandomEffect: 1 -> [ MushroomToxinNausea, MushroomToxinExcited, MushroomToxinTired, MushroomToxinCureI, MushroomToxinAGI, MushroomToxin ]<para/>
//		/// PlayerSatiety: 1%<para/>
//		/// MinionSatiety: 3%<para/>
//		/// BreedingSatiety: 2u<para/>
//		/// </summary>
//		public static Food RoastedMushroom { get; } = new Food("RoastedMushroom", 10009);
//		/// <summary>
//		/// PlayerSatiety: 15%<para/>
//		/// MinionSatiety: 45%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food RoastedHorseMeat { get; } = new Food("RoastedHorseMeat", 10010);
//		/// <summary>
//		/// Description: "Use: Get one of the mushroom toxin effects."<para/>
//		/// RandomEffect: 1 -> [ MushroomToxinNausea, MushroomToxinExcited, MushroomToxinTired, MushroomToxinCureI, MushroomToxinAGI, MushroomToxin ]<para/>
//		/// PlayerSatiety: 1%<para/>
//		/// MinionSatiety: 3%<para/>
//		/// BreedingSatiety: 2u<para/>
//		/// </summary>
//		public static Food RoastedBloodMushroom { get; } = new Food("RoastedBloodMushroom", 10011);
//		/// <summary>
//		/// PlayerSatiety: 25%<para/>
//		/// MinionSatiety: 75%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food BigFeast { get; } = new Food("BigFeast", 11001);
//		/// <summary>
//		/// Description: "Use: feeling satisfied with a delicious meal. Hunger speed decrease by 35%,lasts for 1 minutes."<para/>
//		/// Effect: [ Tasty ]<para/>
//		/// PlayerSatiety: 50%<para/>
//		/// MinionSatiety: 100%<para/>
//		/// BreedingSatiety: 40u<para/>
//		/// </summary>
//		public static Food AllMeat { get; } = new Food("AllMeat", 11002);
//		/// <summary>
//		/// Description: "Use: feeling satisfied with a delicious meal. Hunger speed decrease by 35%,lasts for 1 minutes."<para/>
//		/// Effect: [ Tasty ]<para/>
//		/// PlayerSatiety: 32%<para/>
//		/// MinionSatiety: 96%<para/>
//		/// BreedingSatiety: 35u<para/>
//		/// </summary>
//		public static Food Meatballs { get; } = new Food("Meatballs", 11003);
//		/// <summary>
//		/// Description: "Use: feeling satisfied with a delicious meal. Hunger speed decrease by 35%,lasts for 1 minutes."<para/>
//		/// Effect: [ Tasty ]<para/>
//		/// PlayerSatiety: 21%<para/>
//		/// MinionSatiety: 63%<para/>
//		/// BreedingSatiety: 20u<para/>
//		/// </summary>
//		public static Food ScrambledEggs { get; } = new Food("ScrambledEggs", 11004);
//		/// <summary>
//		/// Description: "Use: restore 1 HP for every second, lasts for 20 seconds."<para/>
//		/// Effect: [ ContinuousRecovery ]<para/>
//		/// PlayerHealth: 10%<para/>
//		/// PlayerSatiety: 25%<para/>
//		/// MinionHealth: 90%<para/>
//		/// MinionSatiety: 75%<para/>
//		/// BreedingSatiety: 30u<para/>
//		/// </summary>
//		public static Food SweetHam { get; } = new Food("SweetHam", 11005);
//		/// <summary>
//		/// PlayerHealth: 20%<para/>
//		/// PlayerSatiety: 10%<para/>
//		/// MinionHealth: 60%<para/>
//		/// MinionSatiety: 30%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food FruitJam { get; } = new Food("FruitJam", 11006);
//		/// <summary>
//		/// Description: "Use: restore 1 HP for every second, lasts for 20 seconds."<para/>
//		/// Effect: [ ContinuousRecovery ]<para/>
//		/// PlayerHealth: 15%<para/>
//		/// PlayerSatiety: 5%<para/>
//		/// MinionHealth: 100%<para/>
//		/// MinionSatiety: 15%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food FruitSalad { get; } = new Food("FruitSalad", 11007);
//		/// <summary>
//		/// Description: "Use： feeling satisfied with a delicious meal. Hunger speed decrease by 35%,lasts for 1 minutes."<para/>
//		/// Effect: [ Tasty ]<para/>
//		/// PlayerHealth: 10%<para/>
//		/// PlayerSatiety: 30%<para/>
//		/// MinionHealth: 30%<para/>
//		/// MinionSatiety: 90%<para/>
//		/// BreedingSatiety: 20u<para/>
//		/// </summary>
//		public static Food Sandwich { get; } = new Food("Sandwich", 11008);
//		/// <summary>
//		/// PlayerHealth: 15%<para/>
//		/// PlayerSatiety: 20%<para/>
//		/// MinionHealth: 45%<para/>
//		/// MinionSatiety: 60%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food Pie { get; } = new Food("Pie", 11009);
//		/// <summary>
//		/// Description: "Use: restore 2 HP for every second, lasts for 40 seconds."<para/>
//		/// Effect: [ SweetSoup ]<para/>
//		/// PlayerSatiety: 2%<para/>
//		/// MinionHealth: 100%<para/>
//		/// MinionSatiety: 6%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food SweetSoup { get; } = new Food("SweetSoup", 11010);
//		/// <summary>
//		/// Description: "Use: Get one or two of the mushroom toxin effects."<para/>
//		/// RandomEffect: 2 -> [ MushroomToxinNausea, MushroomToxinExcited, MushroomToxinTired, MushroomToxinCureI, MushroomToxinAGI, MushroomToxin ]<para/>
//		/// PlayerSatiety: 3%<para/>
//		/// MinionSatiety: 9%<para/>
//		/// BreedingSatiety: 5u<para/>
//		/// </summary>
//		public static Food MushroomSoup { get; } = new Food("MushroomSoup", 11011);
//		/// <summary>
//		/// Description: "Use: walking speed decrease by 25%, lasts for 1 minitue"<para/>
//		/// Effect: [ Nausea ]<para/>
//		/// PlayerSatiety: 25%<para/>
//		/// MinionSatiety: 75%<para/>
//		/// BreedingSatiety: 20u<para/>
//		/// </summary>
//		public static Food WeirdFood { get; } = new Food("WeirdFood", 11012);
//	}
//}
