//namespace ChassisMod
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
//		public static Food Apple { get; } = new Food() { ID = 1, Name = "Apple", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerHealth: 6%<para/>
//		/// PlayerSatiety: 5%<para/>
//		/// MinionHealth: 18%<para/>
//		/// MinionSatiety: 15%<para/>
//		/// BreedingSatiety: 4u<para/>
//		/// </summary>
//		public static Food Berries { get; } = new Food() { ID = 2, Name = "Berries", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerSatiety: 10%<para/>
//		/// MinionSatiety: 30%<para/>
//		/// BreedingSatiety: 6u<para/>
//		/// </summary>
//		public static Food CompressedCookie { get; } = new Food() { ID = 3, Name = "CompressedCookie", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: restore 1 HP for every second, lasts for 10 seconds."<para/>
//		/// PlayerHealth: 10%<para/>
//		/// PlayerSatiety: 1%<para/>
//		/// MinionHealth: 60%<para/>
//		/// MinionSatiety: 3%<para/>
//		/// BreedingSatiety: 5u<para/>
//		/// </summary>
//		public static Food Nectar { get; } = new Food() { ID = 4, Name = "Nectar", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: Get one of the mutated effects."<para/>
//		/// PlayerSatiety: 10%<para/>
//		/// MinionSatiety: 30%<para/>
//		/// BreedingSatiety: 10u<para/>
//		/// </summary>
//		public static Food MonsterMeat { get; } = new Food() { ID = 5, Name = "MonsterMeat", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerSatiety: 12%<para/>
//		/// MinionSatiety: 36%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food ChickenMeat { get; } = new Food() { ID = 6, Name = "ChickenMeat", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerSatiety: 12%<para/>
//		/// MinionSatiety: 36%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food DogMeat { get; } = new Food() { ID = 7, Name = "DogMeat", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerSatiety: 12%<para/>
//		/// MinionSatiety: 36%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food Lamb { get; } = new Food() { ID = 8, Name = "Lamb", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerSatiety: 12%<para/>
//		/// MinionSatiety: 36%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food Pork { get; } = new Food() { ID = 9, Name = "Pork", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerSatiety: 12%<para/>
//		/// MinionSatiety: 36%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food Beef { get; } = new Food() { ID = 10, Name = "Beef", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerSatiety: 6%<para/>
//		/// MinionSatiety: 18%<para/>
//		/// BreedingSatiety: 6u<para/>
//		/// </summary>
//		public static Food Egg { get; } = new Food() { ID = 11, Name = "Egg", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerSatiety: 3%<para/>
//		/// MinionSatiety: 9%<para/>
//		/// </summary>
//		public static Food VenomSac { get; } = new Food() { ID = 12, Name = "VenomSac", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: walking speed decrease by 25%, lasts for 1 minitue"<para/>
//		/// PlayerSatiety: 10%<para/>
//		/// MinionSatiety: 30%<para/>
//		/// BreedingSatiety: 7u<para/>
//		/// </summary>
//		public static Food DisgustingOrgans { get; } = new Food() { ID = 13, Name = "DisgustingOrgans", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerSatiety: 10%<para/>
//		/// MinionSatiety: 30%<para/>
//		/// BreedingSatiety: 10u<para/>
//		/// </summary>
//		public static Food Jerky { get; } = new Food() { ID = 17, Name = "Jerky", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: after using this,the stinky smell on you will attract the Boar King!"<para/>
//		/// PlayerHealth: 10%<para/>
//		/// PlayerSatiety: 5%<para/>
//		/// MinionHealth: 30%<para/>
//		/// MinionSatiety: 15%<para/>
//		/// BreedingSatiety: 20u<para/>
//		/// SpecialEvent: #1<para/>
//		/// </summary>
//		public static Food WildBoarGlands { get; } = new Food() { ID = 18, Name = "WildBoarGlands", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: attract chickens around you, lasts for 30 seconds."<para/>
//		/// BreedingSatiety: 1u<para/>
//		/// </summary>
//		public static Food PheromonesChicken { get; } = new Food() { ID = 19, Name = "PheromonesChicken", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: attract goats around you, lasts for 30 seconds."<para/>
//		/// BreedingSatiety: 1u<para/>
//		/// </summary>
//		public static Food PheromonesGoat { get; } = new Food() { ID = 20, Name = "PheromonesGoat", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: attract pigs around you, lasts for 30 seconds."<para/>
//		/// BreedingSatiety: 1u<para/>
//		/// </summary>
//		public static Food PheromonesPig { get; } = new Food() { ID = 21, Name = "PheromonesPig", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: attract cows around you, lasts for 30 seconds."<para/>
//		/// BreedingSatiety: 1u<para/>
//		/// </summary>
//		public static Food PheromonesCow { get; } = new Food() { ID = 22, Name = "PheromonesCow", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: attract horses around you, lasts for 30 seconds."<para/>
//		/// BreedingSatiety: 1u<para/>
//		/// </summary>
//		public static Food PheromonesHorse { get; } = new Food() { ID = 23, Name = "PheromonesHorse", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerSatiety: 12%<para/>
//		/// MinionSatiety: 36%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food HorseMeat { get; } = new Food() { ID = 24, Name = "HorseMeat", Assembly = "Keplerth" };
//		/// <summary>
//		/// BreedingSatiety: 2u<para/>
//		/// </summary>
//		public static Food RedMushroom { get; } = new Food() { ID = 502, Name = "RedMushroom", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerHealth: 35%<para/>
//		/// MinionHealth: 100%<para/>
//		/// </summary>
//		public static Food Bandage { get; } = new Food() { ID = 601, Name = "Bandage", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerHealth: 50%<para/>
//		/// MinionHealth: 100%<para/>
//		/// </summary>
//		public static Food PainKiller { get; } = new Food() { ID = 602, Name = "PainKiller", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerHealth: 75%<para/>
//		/// MinionHealth: 100%<para/>
//		/// </summary>
//		public static Food FirstAidKit { get; } = new Food() { ID = 603, Name = "FirstAidKit", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerHealth: 100%<para/>
//		/// MinionHealth: 100%<para/>
//		/// </summary>
//		public static Food NanoCapsule { get; } = new Food() { ID = 604, Name = "NanoCapsule", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerHealth: 100%<para/>
//		/// MinionHealth: 100%<para/>
//		/// </summary>
//		public static Food LifeAgentV { get; } = new Food() { ID = 605, Name = "LifeAgentV", Assembly = "Keplerth" };
//		/// <summary>
//		/// </summary>
//		public static Food HealingAgentI { get; } = new Food() { ID = 606, Name = "HealingAgentI", Assembly = "Keplerth" };
//		/// <summary>
//		/// </summary>
//		public static Food HealingAgentII { get; } = new Food() { ID = 607, Name = "HealingAgentII", Assembly = "Keplerth" };
//		/// <summary>
//		/// </summary>
//		public static Food HealingAgentIII { get; } = new Food() { ID = 608, Name = "HealingAgentIII", Assembly = "Keplerth" };
//		/// <summary>
//		/// </summary>
//		public static Food HealingAgentIV { get; } = new Food() { ID = 609, Name = "HealingAgentIV", Assembly = "Keplerth" };
//		/// <summary>
//		/// </summary>
//		public static Food HealingAgentV { get; } = new Food() { ID = 610, Name = "HealingAgentV", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerHealth: 20%<para/>
//		/// MinionHealth: 60%<para/>
//		/// </summary>
//		public static Food RecoveryAgentI { get; } = new Food() { ID = 611, Name = "RecoveryAgentI", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerHealth: 30%<para/>
//		/// MinionHealth: 90%<para/>
//		/// </summary>
//		public static Food RecoveryAgentII { get; } = new Food() { ID = 612, Name = "RecoveryAgentII", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerHealth: 40%<para/>
//		/// MinionHealth: 100%<para/>
//		/// </summary>
//		public static Food RecoveryAgentIII { get; } = new Food() { ID = 613, Name = "RecoveryAgentIII", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerHealth: 50%<para/>
//		/// MinionHealth: 100%<para/>
//		/// </summary>
//		public static Food RecoveryAgentIV { get; } = new Food() { ID = 614, Name = "RecoveryAgentIV", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerHealth: 60%<para/>
//		/// MinionHealth: 100%<para/>
//		/// </summary>
//		public static Food RecoveryAgentV { get; } = new Food() { ID = 615, Name = "RecoveryAgentV", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase attack speed and walking speed by 20%, hunger speed will also be increased. Lasts for 1 minitue."<para/>
//		/// </summary>
//		public static Food StimulantsI { get; } = new Food() { ID = 616, Name = "StimulantsI", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase attack speed and walking speed by 40% , hunger speed will also be substantially increased. Lasts for 1 minute."<para/>
//		/// </summary>
//		public static Food StimulantsII { get; } = new Food() { ID = 617, Name = "StimulantsII", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase attack speed and walking speed by 60%, lasts for 1 minute. Satiety will be decreased to 0 once the effect is over."<para/>
//		/// </summary>
//		public static Food StimulantsIII { get; } = new Food() { ID = 618, Name = "StimulantsIII", Assembly = "Keplerth" };
//		/// <summary>
//		/// </summary>
//		public static Food StimulantIV { get; } = new Food() { ID = 619, Name = "StimulantIV", Assembly = "Keplerth" };
//		/// <summary>
//		/// </summary>
//		public static Food StimulantV { get; } = new Food() { ID = 620, Name = "StimulantV", Assembly = "Keplerth" };
//		/// <summary>
//		/// </summary>
//		public static Food NightVisionAgent { get; } = new Food() { ID = 621, Name = "NightVisionAgent", Assembly = "Keplerth" };
//		/// <summary>
//		/// </summary>
//		public static Food StealthPotion { get; } = new Food() { ID = 622, Name = "StealthPotion", Assembly = "Keplerth" };
//		/// <summary>
//		/// </summary>
//		public static Food Hallucinogenic { get; } = new Food() { ID = 623, Name = "Hallucinogenic", Assembly = "Keplerth" };
//		/// <summary>
//		/// </summary>
//		public static Food XXMedicine0 { get; } = new Food() { ID = 624, Name = "XXMedicine0", Assembly = "Keplerth" };
//		/// <summary>
//		/// </summary>
//		public static Food XXMedicine1 { get; } = new Food() { ID = 625, Name = "XXMedicine1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase attack by 2 points, lasts for 10 minutes."<para/>
//		/// </summary>
//		public static Food DamagedATKCapsule { get; } = new Food() { ID = 626, Name = "DamagedATKCapsule", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase attack by 3 points, lasts for 10 minutes."<para/>
//		/// </summary>
//		public static Food ExpiredATKCapsule { get; } = new Food() { ID = 627, Name = "ExpiredATKCapsule", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase attack by 4 points, lasts for 10 minutes."<para/>
//		/// </summary>
//		public static Food ATKCapsule { get; } = new Food() { ID = 628, Name = "ATKCapsule", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase attack by 6 points, lasts for 10 minutes."<para/>
//		/// </summary>
//		public static Food ATKCapsuleExtra { get; } = new Food() { ID = 629, Name = "ATKCapsuleExtra", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase attack by 9 points, lasts for 10 minutes."<para/>
//		/// </summary>
//		public static Food ATKCapsuleExtraAdvance { get; } = new Food() { ID = 630, Name = "ATKCapsuleExtraAdvance", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase defense by 3 points, lasts for 10 minutes."<para/>
//		/// </summary>
//		public static Food DamagedDEFCapsule { get; } = new Food() { ID = 631, Name = "DamagedDEFCapsule", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase defense by 5 points, lasts for 10 minutes."<para/>
//		/// </summary>
//		public static Food ExpiredDEFCapsule { get; } = new Food() { ID = 632, Name = "ExpiredDEFCapsule", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase defense by 8 points, lasts for 10 minutes."<para/>
//		/// </summary>
//		public static Food DEFCapsule { get; } = new Food() { ID = 633, Name = "DEFCapsule", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase defense by 12 points, lasts for 10 minutes."<para/>
//		/// </summary>
//		public static Food DEFCapsuleExtra { get; } = new Food() { ID = 634, Name = "DEFCapsuleExtra", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase defense by 19 points, lasts for 10 minutes."<para/>
//		/// </summary>
//		public static Food DEFCapsuleExtraAdvance { get; } = new Food() { ID = 635, Name = "DEFCapsuleExtraAdvance", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase walking speed by 10%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken."<para/>
//		/// </summary>
//		public static Food DamagedAGLPotion { get; } = new Food() { ID = 636, Name = "DamagedAGLPotion", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase walking speed by 15%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken."<para/>
//		/// </summary>
//		public static Food ExpiredAGLPotion { get; } = new Food() { ID = 637, Name = "ExpiredAGLPotion", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase walking speed by 20%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken."<para/>
//		/// </summary>
//		public static Food AGLPotion { get; } = new Food() { ID = 638, Name = "AGLPotion", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase walking speed by 25%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken."<para/>
//		/// </summary>
//		public static Food AGLPotionExtra { get; } = new Food() { ID = 639, Name = "AGLPotionExtra", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase walking speed by 30%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken."<para/>
//		/// </summary>
//		public static Food AGLPotionExtraAdvance { get; } = new Food() { ID = 640, Name = "AGLPotionExtraAdvance", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase attack speed by 10%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken."<para/>
//		/// </summary>
//		public static Food MecoJoyfulI { get; } = new Food() { ID = 641, Name = "MecoJoyfulI", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase attack speed by 15%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken."<para/>
//		/// </summary>
//		public static Food MecoJoyfulII { get; } = new Food() { ID = 642, Name = "MecoJoyfulII", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase attack speed by 20%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken."<para/>
//		/// </summary>
//		public static Food MecoJoyfulIII { get; } = new Food() { ID = 643, Name = "MecoJoyfulIII", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase attack speed by 25%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken."<para/>
//		/// </summary>
//		public static Food MecoJoyfulIV { get; } = new Food() { ID = 644, Name = "MecoJoyfulIV", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: increase attack speed by 30%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken."<para/>
//		/// </summary>
//		public static Food MecoJoyfulV { get; } = new Food() { ID = 645, Name = "MecoJoyfulV", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Press the button! It will take you back home through the rift."<para/>
//		/// SpecialEvent: #2<para/>
//		/// </summary>
//		public static Food RifterStone { get; } = new Food() { ID = 901, Name = "RifterStone", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: after using this, you will attract an angry Coopapa!"<para/>
//		/// PlayerHealth: 10%<para/>
//		/// MinionHealth: 30%<para/>
//		/// SpecialEvent: #3<para/>
//		/// </summary>
//		public static Food CoocooJelly { get; } = new Food() { ID = 902, Name = "CoocooJelly", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Summon a friendly Coocoo, but the Coocoo will vanish after 2 minutes."<para/>
//		/// SpecialEvent: #4<para/>
//		/// Cooldown: 300s<para/>
//		/// </summary>
//		public static Food DollCoocoo { get; } = new Food() { ID = 903, Name = "DollCoocoo", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: place a coocoo bomb. It will explode after 8 seconds and cause 40 damage."<para/>
//		/// SpecialEvent: #5<para/>
//		/// Cooldown: 15s<para/>
//		/// </summary>
//		public static Food CoocooBomb { get; } = new Food() { ID = 904, Name = "CoocooBomb", Assembly = "Keplerth" };
//		/// <summary>
//		/// BreedingSatiety: 2u<para/>
//		/// </summary>
//		public static Food BloodMushroom { get; } = new Food() { ID = 3223, Name = "BloodMushroom", Assembly = "Keplerth" };
//		/// <summary>
//		/// BreedingSatiety: 2u<para/>
//		/// </summary>
//		public static Food Grass { get; } = new Food() { ID = 9002, Name = "Grass", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerSatiety: 15%<para/>
//		/// MinionSatiety: 45%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food RoastedChicken { get; } = new Food() { ID = 10001, Name = "RoastedChicken", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerSatiety: 15%<para/>
//		/// MinionSatiety: 45%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food RoastedDogMeat { get; } = new Food() { ID = 10002, Name = "RoastedDogMeat", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerSatiety: 15%<para/>
//		/// MinionSatiety: 45%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food RoastedLamb { get; } = new Food() { ID = 10003, Name = "RoastedLamb", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerSatiety: 15%<para/>
//		/// MinionSatiety: 45%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food RoastedPork { get; } = new Food() { ID = 10004, Name = "RoastedPork", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerSatiety: 15%<para/>
//		/// MinionSatiety: 45%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food RoastedBeef { get; } = new Food() { ID = 10005, Name = "RoastedBeef", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerSatiety: 7%<para/>
//		/// MinionSatiety: 21%<para/>
//		/// BreedingSatiety: 7u<para/>
//		/// </summary>
//		public static Food RoastedEgg { get; } = new Food() { ID = 10006, Name = "RoastedEgg", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: Get one of the mutated effects."<para/>
//		/// PlayerSatiety: 12%<para/>
//		/// MinionSatiety: 36%<para/>
//		/// BreedingSatiety: 10u<para/>
//		/// </summary>
//		public static Food RoastedMonsterMeat { get; } = new Food() { ID = 10007, Name = "RoastedMonsterMeat", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: walking speed decrease by 25%, lasts for 1 minutes."<para/>
//		/// PlayerSatiety: 12%<para/>
//		/// MinionSatiety: 36%<para/>
//		/// BreedingSatiety: 7u<para/>
//		/// </summary>
//		public static Food RoastedDisgustingOrgans { get; } = new Food() { ID = 10008, Name = "RoastedDisgustingOrgans", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: Get one of the mushroom toxin effects."<para/>
//		/// PlayerSatiety: 1%<para/>
//		/// MinionSatiety: 3%<para/>
//		/// BreedingSatiety: 2u<para/>
//		/// </summary>
//		public static Food RoastedMushroom { get; } = new Food() { ID = 10009, Name = "RoastedMushroom", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerSatiety: 15%<para/>
//		/// MinionSatiety: 45%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food RoastedHorseMeat { get; } = new Food() { ID = 10010, Name = "RoastedHorseMeat", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: Get one of the mushroom toxin effects."<para/>
//		/// PlayerSatiety: 1%<para/>
//		/// MinionSatiety: 3%<para/>
//		/// BreedingSatiety: 2u<para/>
//		/// </summary>
//		public static Food RoastedBloodMushroom { get; } = new Food() { ID = 10011, Name = "RoastedBloodMushroom", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerSatiety: 25%<para/>
//		/// MinionSatiety: 75%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food BigFeast { get; } = new Food() { ID = 11001, Name = "BigFeast", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: feeling satisfied with a delicious meal. Hunger speed decrease by 35%,lasts for 1 minutes."<para/>
//		/// PlayerSatiety: 50%<para/>
//		/// MinionSatiety: 100%<para/>
//		/// BreedingSatiety: 40u<para/>
//		/// </summary>
//		public static Food AllMeat { get; } = new Food() { ID = 11002, Name = "AllMeat", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: feeling satisfied with a delicious meal. Hunger speed decrease by 35%,lasts for 1 minutes."<para/>
//		/// PlayerSatiety: 32%<para/>
//		/// MinionSatiety: 96%<para/>
//		/// BreedingSatiety: 35u<para/>
//		/// </summary>
//		public static Food Meatballs { get; } = new Food() { ID = 11003, Name = "Meatballs", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: feeling satisfied with a delicious meal. Hunger speed decrease by 35%,lasts for 1 minutes."<para/>
//		/// PlayerSatiety: 21%<para/>
//		/// MinionSatiety: 63%<para/>
//		/// BreedingSatiety: 20u<para/>
//		/// </summary>
//		public static Food ScrambledEggs { get; } = new Food() { ID = 11004, Name = "ScrambledEggs", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: restore 1 HP for every second, lasts for 20 seconds."<para/>
//		/// PlayerHealth: 10%<para/>
//		/// PlayerSatiety: 25%<para/>
//		/// MinionHealth: 90%<para/>
//		/// MinionSatiety: 75%<para/>
//		/// BreedingSatiety: 30u<para/>
//		/// </summary>
//		public static Food SweetHam { get; } = new Food() { ID = 11005, Name = "SweetHam", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerHealth: 20%<para/>
//		/// PlayerSatiety: 10%<para/>
//		/// MinionHealth: 60%<para/>
//		/// MinionSatiety: 30%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food FruitJam { get; } = new Food() { ID = 11006, Name = "FruitJam", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: restore 1 HP for every second, lasts for 20 seconds."<para/>
//		/// PlayerHealth: 15%<para/>
//		/// PlayerSatiety: 5%<para/>
//		/// MinionHealth: 100%<para/>
//		/// MinionSatiety: 15%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food FruitSalad { get; } = new Food() { ID = 11007, Name = "FruitSalad", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use： feeling satisfied with a delicious meal. Hunger speed decrease by 35%,lasts for 1 minutes."<para/>
//		/// PlayerHealth: 10%<para/>
//		/// PlayerSatiety: 30%<para/>
//		/// MinionHealth: 30%<para/>
//		/// MinionSatiety: 90%<para/>
//		/// BreedingSatiety: 20u<para/>
//		/// </summary>
//		public static Food Sandwich { get; } = new Food() { ID = 11008, Name = "Sandwich", Assembly = "Keplerth" };
//		/// <summary>
//		/// PlayerHealth: 15%<para/>
//		/// PlayerSatiety: 20%<para/>
//		/// MinionHealth: 45%<para/>
//		/// MinionSatiety: 60%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food Pie { get; } = new Food() { ID = 11009, Name = "Pie", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: restore 2 HP for every second, lasts for 40 seconds."<para/>
//		/// PlayerSatiety: 2%<para/>
//		/// MinionHealth: 100%<para/>
//		/// MinionSatiety: 6%<para/>
//		/// BreedingSatiety: 15u<para/>
//		/// </summary>
//		public static Food SweetSoup { get; } = new Food() { ID = 11010, Name = "SweetSoup", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: Get one or two of the mushroom toxin effects."<para/>
//		/// PlayerSatiety: 3%<para/>
//		/// MinionSatiety: 9%<para/>
//		/// BreedingSatiety: 5u<para/>
//		/// </summary>
//		public static Food MushroomSoup { get; } = new Food() { ID = 11011, Name = "MushroomSoup", Assembly = "Keplerth" };
//		/// <summary>
//		/// Description: "Use: walking speed decrease by 25%, lasts for 1 minitue"<para/>
//		/// PlayerSatiety: 25%<para/>
//		/// MinionSatiety: 75%<para/>
//		/// BreedingSatiety: 20u<para/>
//		/// </summary>
//		public static Food WeirdFood { get; } = new Food() { ID = 11012, Name = "WeirdFood", Assembly = "Keplerth" };
//	}
//}
