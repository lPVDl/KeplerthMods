//namespace ChassisMod.KeplerthDatabase
//{
//	public static class CraftDB
//	{
//		/// <summary>
//		/// Recipe: 1x(Wood) -> 1x(Wood)<para/>
//		/// </summary>
//		public static Craft Wood { get; } = new Craft("Wood", 1);
//		/// <summary>
//		/// Recipe: 10x(Bud) -> 1x(Nectar)<para/>
//		/// </summary>
//		public static Craft Nectar { get; } = new Craft("Nectar", 4);
//		/// <summary>
//		/// Recipe: 1x(ChickenMeat) + 10x(Mucus) -> 1x(PheromonesChicken)<para/>
//		/// </summary>
//		public static Craft PheromonesChicken0 { get; } = new Craft("PheromonesChicken0", 19);
//		/// <summary>
//		/// Recipe: 1x(Lamb) + 10x(Mucus) -> 1x(PheromonesGoat)<para/>
//		/// </summary>
//		public static Craft PheromonesGoat0 { get; } = new Craft("PheromonesGoat0", 20);
//		/// <summary>
//		/// Recipe: 1x(Pork) + 10x(Mucus) -> 1x(PheromonesPig)<para/>
//		/// </summary>
//		public static Craft PheromonesPig0 { get; } = new Craft("PheromonesPig0", 21);
//		/// <summary>
//		/// Recipe: 1x(Beef) + 10x(Mucus) -> 1x(PheromonesCow)<para/>
//		/// </summary>
//		public static Craft PheromonesCow0 { get; } = new Craft("PheromonesCow0", 22);
//		/// <summary>
//		/// Recipe: 1x(HorseMeat) + 10x(Mucus) -> 1x(PheromonesHorse)<para/>
//		/// </summary>
//		public static Craft PheromonesHorse0 { get; } = new Craft("PheromonesHorse0", 23);
//		/// <summary>
//		/// Recipe: 8x(Nectar) + 3x(MecoParasectMass) + 1x(Tenergy) -> 1x(NanoCapsule)<para/>
//		/// </summary>
//		public static Craft NanoCapsule { get; } = new Craft("NanoCapsule", 604);
//		/// <summary>
//		/// Recipe: 10x(Bone) + 3x(MecoParasectMass) + 1x(Tenergy) -> 1x(StimulantsI)<para/>
//		/// </summary>
//		public static Craft StimulantsI { get; } = new Craft("StimulantsI", 616);
//		/// <summary>
//		/// Recipe: 3x(MecoParasectMass) + 1x(Tenergy) -> 1x(ATKCapsule)<para/>
//		/// </summary>
//		public static Craft ATKCapsule0 { get; } = new Craft("ATKCapsule0", 628);
//		/// <summary>
//		/// Recipe: 3x(MecoParasectMass) + 1x(Tenergy) -> 1x(DEFCapsule)<para/>
//		/// </summary>
//		public static Craft DEFCapsule0 { get; } = new Craft("DEFCapsule0", 633);
//		/// <summary>
//		/// Recipe: 3x(MecoParasectMass) + 1x(Tenergy) -> 1x(AGLPotion)<para/>
//		/// </summary>
//		public static Craft AGLPotion0 { get; } = new Craft("AGLPotion0", 638);
//		/// <summary>
//		/// Recipe: 3x(MecoParasectMass) + 1x(Tenergy) -> 1x(MecoJoyfulIII)<para/>
//		/// </summary>
//		public static Craft MecoJoyfulIII0 { get; } = new Craft("MecoJoyfulIII0", 643);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(WoodenSword)<para/>
//		/// </summary>
//		public static Craft WoodenSword { get; } = new Craft("WoodenSword", 1001);
//		/// <summary>
//		/// Recipe: 8x(StoneBlock) -> 1x(StoneClub)<para/>
//		/// </summary>
//		public static Craft StoneClub { get; } = new Craft("StoneClub", 1002);
//		/// <summary>
//		/// Recipe: 8x(CopperBar) -> 1x(CopperSword)<para/>
//		/// </summary>
//		public static Craft CopperSword { get; } = new Craft("CopperSword", 1003);
//		/// <summary>
//		/// Recipe: 8x(IronBar) -> 1x(IronSword)<para/>
//		/// </summary>
//		public static Craft IronSword { get; } = new Craft("IronSword", 1004);
//		/// <summary>
//		/// Recipe: 8x(SilverBar) -> 1x(SilverSword)<para/>
//		/// </summary>
//		public static Craft SilverSword { get; } = new Craft("SilverSword", 1005);
//		/// <summary>
//		/// Recipe: 8x(GoldBar) -> 1x(GoldenSword)<para/>
//		/// </summary>
//		public static Craft GoldenSword { get; } = new Craft("GoldenSword", 1006);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(DiamondSword)<para/>
//		/// </summary>
//		public static Craft DiamondSword { get; } = new Craft("DiamondSword", 1007);
//		/// <summary>
//		/// Recipe: 35x(Bone) -> 1x(GoblinBoneSword)<para/>
//		/// </summary>
//		public static Craft GoblinBoneSword { get; } = new Craft("GoblinBoneSword", 1008);
//		/// <summary>
//		/// Recipe: 1x(InsectorSickle) + 10x(ParasytorPrimordium) -> 1x(ParasectSickle)<para/>
//		/// </summary>
//		public static Craft ParasectSickle { get; } = new Craft("ParasectSickle", 1013);
//		/// <summary>
//		/// Recipe: 10x(Amber) + 10x(SilverBar) -> 1x(GrounderSamuraiSword)<para/>
//		/// </summary>
//		public static Craft GrounderSamuraiSword { get; } = new Craft("GrounderSamuraiSword", 1015);
//		/// <summary>
//		/// Recipe: 10x(Wood) -> 1x(WoodenBow)<para/>
//		/// </summary>
//		public static Craft WoodenBow { get; } = new Craft("WoodenBow", 1101);
//		/// <summary>
//		/// Recipe: 6x(CopperBar) -> 1x(CopperBow)<para/>
//		/// </summary>
//		public static Craft CopperBow { get; } = new Craft("CopperBow", 1102);
//		/// <summary>
//		/// Recipe: 6x(IronBar) -> 1x(IronBow)<para/>
//		/// </summary>
//		public static Craft IronBow { get; } = new Craft("IronBow", 1103);
//		/// <summary>
//		/// Recipe: 6x(SilverBar) -> 1x(SilverBow)<para/>
//		/// </summary>
//		public static Craft SilverBow { get; } = new Craft("SilverBow", 1104);
//		/// <summary>
//		/// Recipe: 6x(GoldBar) -> 1x(GoldenBow)<para/>
//		/// </summary>
//		public static Craft GoldenBow { get; } = new Craft("GoldenBow", 1105);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(DiamondBow)<para/>
//		/// </summary>
//		public static Craft DiamondBow { get; } = new Craft("DiamondBow", 1106);
//		/// <summary>
//		/// Recipe: 15x(Bone) -> 1x(GoblinBoneBow)<para/>
//		/// </summary>
//		public static Craft GoblinBoneBow { get; } = new Craft("GoblinBoneBow", 1107);
//		/// <summary>
//		/// Recipe: 8x(CopperBar) + 3x(Wood) -> 1x(CopperMusket)<para/>
//		/// </summary>
//		public static Craft CopperMusket { get; } = new Craft("CopperMusket", 1201);
//		/// <summary>
//		/// Recipe: 8x(IronBar) + 3x(Wood) -> 1x(IronMusket)<para/>
//		/// </summary>
//		public static Craft IronMusket { get; } = new Craft("IronMusket", 1202);
//		/// <summary>
//		/// Recipe: 8x(SilverBar) + 3x(Wood) -> 1x(SilverMusket)<para/>
//		/// </summary>
//		public static Craft SilverMusket { get; } = new Craft("SilverMusket", 1203);
//		/// <summary>
//		/// Recipe: 8x(GoldBar) + 3x(Wood) -> 1x(GoldenMusket)<para/>
//		/// </summary>
//		public static Craft GoldenMusket { get; } = new Craft("GoldenMusket", 1204);
//		/// <summary>
//		/// Recipe: 8x(CopperBar) + 3x(Wood) -> 1x(CopperShotgun)<para/>
//		/// </summary>
//		public static Craft CopperShotgun { get; } = new Craft("CopperShotgun", 1211);
//		/// <summary>
//		/// Recipe: 8x(IronBar) + 3x(Wood) -> 1x(IronShotgun)<para/>
//		/// </summary>
//		public static Craft IronShotgun { get; } = new Craft("IronShotgun", 1212);
//		/// <summary>
//		/// Recipe: 8x(SilverBar) + 3x(Wood) -> 1x(SilverShotgun)<para/>
//		/// </summary>
//		public static Craft SilverShotgun { get; } = new Craft("SilverShotgun", 1213);
//		/// <summary>
//		/// Recipe: 8x(GoldBar) + 3x(Wood) -> 1x(GoldenShotgun)<para/>
//		/// </summary>
//		public static Craft GoldenShotgun { get; } = new Craft("GoldenShotgun", 1214);
//		/// <summary>
//		/// Recipe: 8x(MecoAlloy) + 3x(MecoParasectMass) -> 1x(MecoP7B)<para/>
//		/// </summary>
//		public static Craft MecoP7B { get; } = new Craft("MecoP7B", 1222);
//		/// <summary>
//		/// Recipe: 20x(Amber) + 12x(SilverBar) -> 1x(GrounderSniperRifle)<para/>
//		/// </summary>
//		public static Craft GrounderSniperRifle { get; } = new Craft("GrounderSniperRifle", 1223);
//		/// <summary>
//		/// Recipe: 20x(Amber) + 12x(SilverBar) -> 1x(GrounderAssaultRifle)<para/>
//		/// </summary>
//		public static Craft GrounderAssaultRifle { get; } = new Craft("GrounderAssaultRifle", 1224);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(MecoEA6C)<para/>
//		/// </summary>
//		public static Craft MecoEA6C { get; } = new Craft("MecoEA6C", 1301);
//		/// <summary>
//		/// Recipe: 8x(MecoAlloy) + 8x(MecoParasectMass) + 15x(Tenergy) -> 1x(MecoLP8B)<para/>
//		/// </summary>
//		public static Craft MecoLP8B { get; } = new Craft("MecoLP8B", 1303);
//		/// <summary>
//		/// Recipe: 10x(MecoAlloy) + 10x(MecoParasectMass) + 25x(Tenergy) -> 1x(MecoLG6B)<para/>
//		/// </summary>
//		public static Craft MecoLG6B { get; } = new Craft("MecoLG6B", 1304);
//		/// <summary>
//		/// Recipe: 10x(StoneBlock) -> 1x(WoodenSpear)<para/>
//		/// </summary>
//		public static Craft WoodenSpear { get; } = new Craft("WoodenSpear", 1401);
//		/// <summary>
//		/// Recipe: 10x(CopperBar) -> 1x(CopperSpear)<para/>
//		/// </summary>
//		public static Craft CopperSpear { get; } = new Craft("CopperSpear", 1402);
//		/// <summary>
//		/// Recipe: 10x(IronBar) -> 1x(IronSpear)<para/>
//		/// </summary>
//		public static Craft IronSpear { get; } = new Craft("IronSpear", 1403);
//		/// <summary>
//		/// Recipe: 10x(SilverBar) -> 1x(SilverSpear)<para/>
//		/// </summary>
//		public static Craft SilverSpear { get; } = new Craft("SilverSpear", 1404);
//		/// <summary>
//		/// Recipe: 10x(GoldBar) -> 1x(GoldenSpear)<para/>
//		/// </summary>
//		public static Craft GoldenSpear { get; } = new Craft("GoldenSpear", 1405);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(DiamondSpear)<para/>
//		/// </summary>
//		public static Craft DiamondSpear { get; } = new Craft("DiamondSpear", 1406);
//		/// <summary>
//		/// Recipe: 1x(InsectorSpear) + 10x(ParasytorPrimordium) -> 1x(ParasectSpear)<para/>
//		/// </summary>
//		public static Craft ParasectSpear { get; } = new Craft("ParasectSpear", 1408);
//		/// <summary>
//		/// Recipe: 8x(CopperBar) -> 1x(CopperDagger)<para/>
//		/// </summary>
//		public static Craft CopperDagger { get; } = new Craft("CopperDagger", 1501);
//		/// <summary>
//		/// Recipe: 8x(IronBar) -> 1x(IronDagger)<para/>
//		/// </summary>
//		public static Craft IronDagger { get; } = new Craft("IronDagger", 1502);
//		/// <summary>
//		/// Recipe: 8x(SilverBar) -> 1x(SilverDagger)<para/>
//		/// </summary>
//		public static Craft SilverDagger { get; } = new Craft("SilverDagger", 1503);
//		/// <summary>
//		/// Recipe: 8x(GoldBar) -> 1x(GoldenDagger)<para/>
//		/// </summary>
//		public static Craft GoldenDagger { get; } = new Craft("GoldenDagger", 1504);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(DiamondDagger)<para/>
//		/// </summary>
//		public static Craft DiamondDagger { get; } = new Craft("DiamondDagger", 1505);
//		/// <summary>
//		/// Recipe: 15x(Bone) -> 1x(GoblinBoneDagger)<para/>
//		/// </summary>
//		public static Craft GoblinBoneDagger { get; } = new Craft("GoblinBoneDagger", 1506);
//		/// <summary>
//		/// Recipe: 10x(Amber) + 10x(SilverBar) -> 1x(GrounderDagger)<para/>
//		/// </summary>
//		public static Craft GrounderDagger { get; } = new Craft("GrounderDagger", 1509);
//		/// <summary>
//		/// Recipe: 1x(Wood) + 1x(Grass) -> 10x(WoodenArrow)<para/>
//		/// </summary>
//		public static Craft WoodenArrow { get; } = new Craft("WoodenArrow", 1601);
//		/// <summary>
//		/// Recipe: 3x(StoneBlock) + 1x(Wood) -> 10x(StoneArrow)<para/>
//		/// </summary>
//		public static Craft StoneArrow { get; } = new Craft("StoneArrow", 1602);
//		/// <summary>
//		/// Recipe: 1x(CopperBar) + 1x(Wood) -> 10x(CopperArrow)<para/>
//		/// </summary>
//		public static Craft CopperArrow { get; } = new Craft("CopperArrow", 1603);
//		/// <summary>
//		/// Recipe: 1x(IronBar) + 1x(Wood) -> 10x(IronArrow)<para/>
//		/// </summary>
//		public static Craft IronArrow { get; } = new Craft("IronArrow", 1604);
//		/// <summary>
//		/// Recipe: 1x(SilverBar) + 1x(Wood) -> 10x(SilverArrow)<para/>
//		/// </summary>
//		public static Craft SilverArrow { get; } = new Craft("SilverArrow", 1605);
//		/// <summary>
//		/// Recipe: 1x(GoldBar) + 1x(Wood) -> 10x(GoldenArrow)<para/>
//		/// </summary>
//		public static Craft GoldenArrow { get; } = new Craft("GoldenArrow", 1606);
//		/// <summary>
//		/// Recipe: 10x(WoodenArrow) + 2x(Gunpowder) -> 10x(ExplosiveWoodenArrow)<para/>
//		/// </summary>
//		public static Craft ExplosiveWoodenArrow { get; } = new Craft("ExplosiveWoodenArrow", 1611);
//		/// <summary>
//		/// Recipe: 10x(StoneArrow) + 2x(Gunpowder) -> 10x(ExplosiveStoneArrow)<para/>
//		/// </summary>
//		public static Craft ExplosiveStoneArrow { get; } = new Craft("ExplosiveStoneArrow", 1612);
//		/// <summary>
//		/// Recipe: 10x(CopperArrow) + 2x(Gunpowder) -> 10x(ExplosiveCopperArrow)<para/>
//		/// </summary>
//		public static Craft ExplosiveCopperArrow { get; } = new Craft("ExplosiveCopperArrow", 1613);
//		/// <summary>
//		/// Recipe: 10x(IronArrow) + 2x(Gunpowder) -> 10x(ExplosiveIronArrow)<para/>
//		/// </summary>
//		public static Craft ExplosiveIronArrow { get; } = new Craft("ExplosiveIronArrow", 1614);
//		/// <summary>
//		/// Recipe: 10x(SilverArrow) + 2x(Gunpowder) -> 10x(ExplosiveSilverArrow)<para/>
//		/// </summary>
//		public static Craft ExplosiveSilverArrow { get; } = new Craft("ExplosiveSilverArrow", 1615);
//		/// <summary>
//		/// Recipe: 10x(GoldenArrow) + 2x(Gunpowder) -> 10x(ExplosiveGoldenArrow)<para/>
//		/// </summary>
//		public static Craft ExplosiveGoldenArrow { get; } = new Craft("ExplosiveGoldenArrow", 1616);
//		/// <summary>
//		/// Recipe: 2x(Gunpowder) + 1x(CopperBar) -> 10x(CopperBullet)<para/>
//		/// </summary>
//		public static Craft CopperBullet { get; } = new Craft("CopperBullet", 1651);
//		/// <summary>
//		/// Recipe: 2x(Gunpowder) + 1x(IronBar) -> 10x(IronBullet)<para/>
//		/// </summary>
//		public static Craft IronBullet { get; } = new Craft("IronBullet", 1652);
//		/// <summary>
//		/// Recipe: 2x(Gunpowder) + 1x(SilverBar) -> 10x(SilverBullet)<para/>
//		/// </summary>
//		public static Craft SilverBullet { get; } = new Craft("SilverBullet", 1653);
//		/// <summary>
//		/// Recipe: 2x(Gunpowder) + 1x(GoldBar) -> 10x(GoldenBullet)<para/>
//		/// </summary>
//		public static Craft GoldenBullet { get; } = new Craft("GoldenBullet", 1654);
//		/// <summary>
//		/// Recipe: 1x(MecoAlloy) + 2x(MecoParasectMass) + 2x(Gunpowder) -> 10x(MecoBiotechBullet)<para/>
//		/// </summary>
//		public static Craft MecoBiotechBullet { get; } = new Craft("MecoBiotechBullet", 1665);
//		/// <summary>
//		/// Recipe: 1x(SnowBlock) -> 10x(Snowball)<para/>
//		/// </summary>
//		public static Craft Snowball { get; } = new Craft("Snowball", 1701);
//		/// <summary>
//		/// Recipe: 1x(StoneBlock) -> 10x(Gravel)<para/>
//		/// </summary>
//		public static Craft Gravel { get; } = new Craft("Gravel", 1702);
//		/// <summary>
//		/// Recipe: 1x(Cactus) -> 10x(LargeCactus)<para/>
//		/// </summary>
//		public static Craft LargeCactus { get; } = new Craft("LargeCactus", 1703);
//		/// <summary>
//		/// Recipe: 10x(DirtBlock) + 5x(Bone) -> 10x(BonyBall)<para/>
//		/// </summary>
//		public static Craft BonyBall { get; } = new Craft("BonyBall", 1704);
//		/// <summary>
//		/// Recipe: 5x(ParasytorPrimordium) + 5x(Mucus) -> 10x(ParasytorPox)<para/>
//		/// </summary>
//		public static Craft ParasytorPox { get; } = new Craft("ParasytorPox", 1706);
//		/// <summary>
//		/// Recipe: 1x(SilverBar) + 2x(Gunpowder) -> 10x(GrounderGrenade)<para/>
//		/// </summary>
//		public static Craft GrounderGrenade { get; } = new Craft("GrounderGrenade", 1708);
//		/// <summary>
//		/// Recipe: 15x(InsectorExoskeleton) + 15x(Mucus) + 10x(ParasytorPrimordium) -> 1x(ParasectPlasmaGun)<para/>
//		/// </summary>
//		public static Craft ParasectPlasmaGun { get; } = new Craft("ParasectPlasmaGun", 1901);
//		/// <summary>
//		/// Recipe: 8x(Wood) -> 1x(WoodenArmor)<para/>
//		/// </summary>
//		public static Craft WoodenArmor { get; } = new Craft("WoodenArmor", 2001);
//		/// <summary>
//		/// Recipe: 5x(Leather) -> 1x(LeatherArmor)<para/>
//		/// </summary>
//		public static Craft LeatherArmor { get; } = new Craft("LeatherArmor", 2002);
//		/// <summary>
//		/// Recipe: 8x(CopperBar) + 2x(Wool) -> 1x(CopperArmor)<para/>
//		/// </summary>
//		public static Craft CopperArmor { get; } = new Craft("CopperArmor", 2003);
//		/// <summary>
//		/// Recipe: 8x(IronBar) + 2x(Wool) -> 1x(IronArmor)<para/>
//		/// </summary>
//		public static Craft IronArmor { get; } = new Craft("IronArmor", 2004);
//		/// <summary>
//		/// Recipe: 8x(SilverBar) + 2x(Wool) -> 1x(SilverArmor)<para/>
//		/// </summary>
//		public static Craft SilverArmor { get; } = new Craft("SilverArmor", 2005);
//		/// <summary>
//		/// Recipe: 8x(GoldBar) + 2x(Wool) -> 1x(GoldenPlate)<para/>
//		/// </summary>
//		public static Craft GoldenPlate { get; } = new Craft("GoldenPlate", 2006);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(DiamondPlate)<para/>
//		/// </summary>
//		public static Craft DiamondPlate { get; } = new Craft("DiamondPlate", 2007);
//		/// <summary>
//		/// Recipe: 8x(IronBar) + 10x(Bone) -> 1x(GoblinSteelArmor)<para/>
//		/// </summary>
//		public static Craft GoblinSteelArmor { get; } = new Craft("GoblinSteelArmor", 2021);
//		/// <summary>
//		/// Recipe: 45x(InsectorExoskeleton) + 15x(ParasytorPrimordium) + 2x(Wool) -> 1x(ParasectOutfit)<para/>
//		/// </summary>
//		public static Craft ParasectOutfit { get; } = new Craft("ParasectOutfit", 2026);
//		/// <summary>
//		/// Recipe: 8x(MecoAlloy) + 10x(MecoParasectMass) + 2x(Wool) -> 1x(MecoParasectArmor)<para/>
//		/// </summary>
//		public static Craft MecoParasectArmor { get; } = new Craft("MecoParasectArmor", 2027);
//		/// <summary>
//		/// Recipe: 1x(GrounderLightweightOutfit) + 10x(Amber) + 4x(SilverBar) -> 1x(GrounderAntiMecoArmor)<para/>
//		/// </summary>
//		public static Craft GrounderAntiMecoArmor0 { get; } = new Craft("GrounderAntiMecoArmor0", 20371);
//		/// <summary>
//		/// Recipe: 1x(GrounderOutfit) + 10x(Amber) + 4x(SilverBar) -> 1x(GrounderAntiMecoArmor)<para/>
//		/// </summary>
//		public static Craft GrounderAntiMecoArmor1 { get; } = new Craft("GrounderAntiMecoArmor1", 20372);
//		/// <summary>
//		/// Recipe: 1x(GrounderCombatOutfit) + 5x(Amber) + 2x(SilverBar) -> 1x(GrounderAntiMecoArmor)<para/>
//		/// </summary>
//		public static Craft GrounderAntiMecoArmor2 { get; } = new Craft("GrounderAntiMecoArmor2", 20373);
//		/// <summary>
//		/// Recipe: 1x(GrounderHunterOutfit) + 5x(Amber) + 2x(SilverBar) -> 1x(GrounderAntiMecoArmor)<para/>
//		/// </summary>
//		public static Craft GrounderAntiMecoArmor3 { get; } = new Craft("GrounderAntiMecoArmor3", 20374);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(WoodenGloves)<para/>
//		/// </summary>
//		public static Craft WoodenGloves { get; } = new Craft("WoodenGloves", 2101);
//		/// <summary>
//		/// Recipe: 3x(Leather) -> 1x(LeatherGloves)<para/>
//		/// </summary>
//		public static Craft LeatherGloves { get; } = new Craft("LeatherGloves", 2102);
//		/// <summary>
//		/// Recipe: 6x(CopperBar) + 1x(Wool) -> 1x(CopperGloves)<para/>
//		/// </summary>
//		public static Craft CopperGloves { get; } = new Craft("CopperGloves", 2103);
//		/// <summary>
//		/// Recipe: 6x(IronBar) + 1x(Wool) -> 1x(IronGloves)<para/>
//		/// </summary>
//		public static Craft IronGloves { get; } = new Craft("IronGloves", 2104);
//		/// <summary>
//		/// Recipe: 6x(SilverBar) + 1x(Wool) -> 1x(SilverGloves)<para/>
//		/// </summary>
//		public static Craft SilverGloves { get; } = new Craft("SilverGloves", 2105);
//		/// <summary>
//		/// Recipe: 6x(GoldBar) + 1x(Wool) -> 1x(GoldenGloves)<para/>
//		/// </summary>
//		public static Craft GoldenGloves { get; } = new Craft("GoldenGloves", 2106);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(DiamondGloves)<para/>
//		/// </summary>
//		public static Craft DiamondGloves { get; } = new Craft("DiamondGloves", 2107);
//		/// <summary>
//		/// Recipe: 30x(InsectorExoskeleton) + 10x(ParasytorPrimordium) + 1x(Wool) -> 1x(ParasectGloves)<para/>
//		/// </summary>
//		public static Craft ParasectGloves { get; } = new Craft("ParasectGloves", 2108);
//		/// <summary>
//		/// Recipe: 6x(MecoAlloy) + 6x(MecoParasectMass) + 1x(Wool) -> 1x(MecoParasectGloves)<para/>
//		/// </summary>
//		public static Craft MecoParasectGloves { get; } = new Craft("MecoParasectGloves", 2109);
//		/// <summary>
//		/// Recipe: 10x(Amber) + 6x(SilverBar) + 1x(Wool) -> 1x(GrenaderGloves)<para/>
//		/// </summary>
//		public static Craft GrenaderGloves { get; } = new Craft("GrenaderGloves", 2110);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(WoodenShoes)<para/>
//		/// </summary>
//		public static Craft WoodenShoes { get; } = new Craft("WoodenShoes", 2201);
//		/// <summary>
//		/// Recipe: 3x(Leather) -> 1x(LeatherShoes)<para/>
//		/// </summary>
//		public static Craft LeatherShoes { get; } = new Craft("LeatherShoes", 2202);
//		/// <summary>
//		/// Recipe: 6x(CopperBar) + 1x(Wool) -> 1x(CopperShoes)<para/>
//		/// </summary>
//		public static Craft CopperShoes { get; } = new Craft("CopperShoes", 2203);
//		/// <summary>
//		/// Recipe: 6x(IronBar) + 1x(Wool) -> 1x(IronShoes)<para/>
//		/// </summary>
//		public static Craft IronShoes { get; } = new Craft("IronShoes", 2204);
//		/// <summary>
//		/// Recipe: 6x(SilverBar) + 1x(Wool) -> 1x(SilverShoes)<para/>
//		/// </summary>
//		public static Craft SilverShoes { get; } = new Craft("SilverShoes", 2205);
//		/// <summary>
//		/// Recipe: 6x(GoldBar) + 1x(Wool) -> 1x(GoldenShoes)<para/>
//		/// </summary>
//		public static Craft GoldenShoes { get; } = new Craft("GoldenShoes", 2206);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(DiamondShoes)<para/>
//		/// </summary>
//		public static Craft DiamondShoes { get; } = new Craft("DiamondShoes", 2207);
//		/// <summary>
//		/// Recipe: 30x(InsectorExoskeleton) + 10x(ParasytorPrimordium) + 1x(Wool) -> 1x(ParasectShoes)<para/>
//		/// </summary>
//		public static Craft ParasectShoes { get; } = new Craft("ParasectShoes", 2208);
//		/// <summary>
//		/// Recipe: 6x(MecoAlloy) + 6x(MecoParasectMass) + 1x(Wool) -> 1x(MecoParasectShoes)<para/>
//		/// </summary>
//		public static Craft MecoParasectShoes { get; } = new Craft("MecoParasectShoes", 2209);
//		/// <summary>
//		/// Recipe: 10x(Amber) + 6x(SilverBar) + 1x(Wool) -> 1x(GrounderShoes)<para/>
//		/// </summary>
//		public static Craft GrounderShoes { get; } = new Craft("GrounderShoes", 2210);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(GoblinKingsNecklace)<para/>
//		/// </summary>
//		public static Craft GoblinKingsNecklace { get; } = new Craft("GoblinKingsNecklace", 2301);
//		/// <summary>
//		/// Recipe: 1x(DirtBlock) + 1x(SandBlock) -> 1x(Clay)<para/>
//		/// </summary>
//		public static Craft Clay { get; } = new Craft("Clay", 3013);
//		/// <summary>
//		/// Recipe: 3x(DirtBlock) -> 1x(SaltpeterOre)<para/>
//		/// </summary>
//		public static Craft SaltpeterOre { get; } = new Craft("SaltpeterOre", 3015);
//		/// <summary>
//		/// Recipe: 3x(DirtBlock) + 1x(InsectorExoskeleton) + 3x(ParasytorPrimordium) -> 1x(InsectorWall)<para/>
//		/// </summary>
//		public static Craft InsectorWall { get; } = new Craft("InsectorWall", 3016);
//		/// <summary>
//		/// Recipe: 3x(DirtBlock) + 3x(ParasytorPrimordium) -> 1x(ParasytorWall)<para/>
//		/// </summary>
//		public static Craft ParasytorWall { get; } = new Craft("ParasytorWall", 3017);
//		/// <summary>
//		/// Recipe: 3x(Wood) -> 1x(WoodWall)<para/>
//		/// </summary>
//		public static Craft WoodWall { get; } = new Craft("WoodWall", 3101);
//		/// <summary>
//		/// Recipe: 3x(DirtBlock) -> 1x(DirtWall)<para/>
//		/// </summary>
//		public static Craft DirtWall { get; } = new Craft("DirtWall", 3102);
//		/// <summary>
//		/// Recipe: 3x(StoneBlock) -> 1x(StoneWall)<para/>
//		/// </summary>
//		public static Craft StoneWall { get; } = new Craft("StoneWall", 3103);
//		/// <summary>
//		/// Recipe: 3x(CopperBar) -> 1x(CopperWall)<para/>
//		/// </summary>
//		public static Craft CopperWall { get; } = new Craft("CopperWall", 3104);
//		/// <summary>
//		/// Recipe: 3x(IronBar) -> 1x(IronWall)<para/>
//		/// </summary>
//		public static Craft IronWall { get; } = new Craft("IronWall", 3105);
//		/// <summary>
//		/// Recipe: 3x(SilverBar) -> 1x(SilverWall)<para/>
//		/// </summary>
//		public static Craft SilverWall { get; } = new Craft("SilverWall", 3106);
//		/// <summary>
//		/// Recipe: 3x(GoldBar) -> 1x(GoldenWall)<para/>
//		/// </summary>
//		public static Craft GoldenWall { get; } = new Craft("GoldenWall", 3107);
//		/// <summary>
//		/// Recipe: 3x(Diamond) -> 1x(DiamondWall)<para/>
//		/// </summary>
//		public static Craft DiamondWall { get; } = new Craft("DiamondWall", 3108);
//		/// <summary>
//		/// Recipe: 3x(Glass) -> 1x(GlassWall)<para/>
//		/// </summary>
//		public static Craft GlassWall { get; } = new Craft("GlassWall", 3109);
//		/// <summary>
//		/// Recipe: 3x(SnowBlock) -> 1x(SnowWall)<para/>
//		/// </summary>
//		public static Craft SnowWall { get; } = new Craft("SnowWall", 3110);
//		/// <summary>
//		/// Recipe: 3x(IceBlock) -> 1x(IceWall)<para/>
//		/// </summary>
//		public static Craft IceWall { get; } = new Craft("IceWall", 3111);
//		/// <summary>
//		/// Recipe: 1x(Wood) -> 3x(WoodenFence)<para/>
//		/// </summary>
//		public static Craft WoodenFence { get; } = new Craft("WoodenFence", 3112);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(LogFence)<para/>
//		/// </summary>
//		public static Craft LogFence { get; } = new Craft("LogFence", 3113);
//		/// <summary>
//		/// Recipe: 1x(CopperBar) -> 3x(CopperFence)<para/>
//		/// </summary>
//		public static Craft CopperFence { get; } = new Craft("CopperFence", 3114);
//		/// <summary>
//		/// Recipe: 1x(IronBar) -> 3x(IronFence)<para/>
//		/// </summary>
//		public static Craft IronFence { get; } = new Craft("IronFence", 3115);
//		/// <summary>
//		/// Recipe: 1x(SilverBar) -> 3x(SilverFence)<para/>
//		/// </summary>
//		public static Craft SilverFence { get; } = new Craft("SilverFence", 3116);
//		/// <summary>
//		/// Recipe: 1x(GoldBar) -> 3x(GoldenFence)<para/>
//		/// </summary>
//		public static Craft GoldenFence { get; } = new Craft("GoldenFence", 3117);
//		/// <summary>
//		/// Recipe: 1x(Diamond) -> 3x(DiamondFence)<para/>
//		/// </summary>
//		public static Craft DiamondFence { get; } = new Craft("DiamondFence", 3118);
//		/// <summary>
//		/// Recipe: 5x(Bone) -> 3x(BoneFence)<para/>
//		/// </summary>
//		public static Craft BoneFence { get; } = new Craft("BoneFence", 3120);
//		/// <summary>
//		/// Recipe: 3x(DirtBlock) + 5x(Bone) -> 1x(BoneWall)<para/>
//		/// </summary>
//		public static Craft BoneWall { get; } = new Craft("BoneWall", 3121);
//		/// <summary>
//		/// Recipe: 1x(ParasytorPrimordium) + 3x(InsectorEgg) -> 1x(InsectorEye)<para/>
//		/// </summary>
//		public static Craft InsectorEye { get; } = new Craft("InsectorEye", 3218);
//		/// <summary>
//		/// Recipe: 5x(InsectorExoskeleton) + 5x(Mucus) -> 1x(InsectorNidus)<para/>
//		/// </summary>
//		public static Craft InsectorNidus { get; } = new Craft("InsectorNidus", 3219);
//		/// <summary>
//		/// Recipe: 1x(ParasytorPrimordium) + 1x(GrassSeed) -> 1x(ParasytorSeed)<para/>
//		/// </summary>
//		public static Craft ParasytorSeed { get; } = new Craft("ParasytorSeed", 3226);
//		/// <summary>
//		/// Recipe: 1x(Wood) + 1x(CoalOre) -> 1x(Torch)<para/>
//		/// </summary>
//		public static Craft Torch0 { get; } = new Craft("Torch0", 3501);
//		/// <summary>
//		/// Recipe: 1x(Wood) + 3x(Grass) -> 1x(Torch)<para/>
//		/// </summary>
//		public static Craft Torch1 { get; } = new Craft("Torch1", 35010);
//		/// <summary>
//		/// Recipe: 5x(Wood) + 3x(CoalOre) -> 1x(Campfire)<para/>
//		/// </summary>
//		public static Craft Campfire0 { get; } = new Craft("Campfire0", 3502);
//		/// <summary>
//		/// Recipe: 5x(Wood) + 10x(Grass) -> 1x(Campfire)<para/>
//		/// </summary>
//		public static Craft Campfire1 { get; } = new Craft("Campfire1", 35020);
//		/// <summary>
//		/// Recipe: 1x(Torch) + 1x(Wood) -> 1x(WoodenTikiTorch)<para/>
//		/// </summary>
//		public static Craft WoodenTikiTorch { get; } = new Craft("WoodenTikiTorch", 3503);
//		/// <summary>
//		/// Recipe: 1x(Torch) + 3x(Bone) -> 1x(GoblinTikiTorch)<para/>
//		/// </summary>
//		public static Craft GoblinTikiTorch { get; } = new Craft("GoblinTikiTorch", 3504);
//		/// <summary>
//		/// Recipe: 1x(Torch) + 1x(StoneBlock) -> 1x(StoneTikiTorch)<para/>
//		/// </summary>
//		public static Craft StoneTikiTorch { get; } = new Craft("StoneTikiTorch", 3505);
//		/// <summary>
//		/// Recipe: 1x(Torch) + 1x(CopperBar) -> 1x(CopperTikiTorch)<para/>
//		/// </summary>
//		public static Craft CopperTikiTorch { get; } = new Craft("CopperTikiTorch", 3506);
//		/// <summary>
//		/// Recipe: 1x(Torch) + 1x(IronBar) -> 1x(IronTikiTorch)<para/>
//		/// </summary>
//		public static Craft IronTikiTorch { get; } = new Craft("IronTikiTorch", 3507);
//		/// <summary>
//		/// Recipe: 1x(Torch) + 1x(SilverBar) -> 1x(SilverTikiTorch)<para/>
//		/// </summary>
//		public static Craft SilverTikiTorch { get; } = new Craft("SilverTikiTorch", 3508);
//		/// <summary>
//		/// Recipe: 1x(Torch) + 1x(GoldBar) -> 1x(GoldenTikiTorch)<para/>
//		/// </summary>
//		public static Craft GoldenTikiTorch { get; } = new Craft("GoldenTikiTorch", 3509);
//		/// <summary>
//		/// Recipe: 10x(Wood) -> 1x(WoodenSimpleWorkbench)<para/>
//		/// </summary>
//		public static Craft WoodenSimpleWorkbench { get; } = new Craft("WoodenSimpleWorkbench", 3510);
//		/// <summary>
//		/// Recipe: 10x(StoneBlock) -> 1x(StoneSimpleWorkbench)<para/>
//		/// </summary>
//		public static Craft StoneSimpleWorkbench { get; } = new Craft("StoneSimpleWorkbench", 3511);
//		/// <summary>
//		/// Recipe: 10x(CopperBar) -> 1x(CopperSimpleWorkbench)<para/>
//		/// </summary>
//		public static Craft CopperSimpleWorkbench { get; } = new Craft("CopperSimpleWorkbench", 3512);
//		/// <summary>
//		/// Recipe: 10x(IronBar) -> 1x(IronSimpleWorkbench)<para/>
//		/// </summary>
//		public static Craft IronSimpleWorkbench { get; } = new Craft("IronSimpleWorkbench", 3513);
//		/// <summary>
//		/// Recipe: 10x(SilverBar) -> 1x(SilverSimpleWorkbench)<para/>
//		/// </summary>
//		public static Craft SilverSimpleWorkbench { get; } = new Craft("SilverSimpleWorkbench", 3514);
//		/// <summary>
//		/// Recipe: 10x(GoldBar) -> 1x(GoldenSimpleWorkbench)<para/>
//		/// </summary>
//		public static Craft GoldenSimpleWorkbench { get; } = new Craft("GoldenSimpleWorkbench", 3515);
//		/// <summary>
//		/// Recipe: 10x(Diamond) -> 1x(DiamondSimpleWorkbench)<para/>
//		/// </summary>
//		public static Craft DiamondSimpleWorkbench { get; } = new Craft("DiamondSimpleWorkbench", 3516);
//		/// <summary>
//		/// Recipe: 10x(StoneBlock) -> 1x(StoneStove)<para/>
//		/// </summary>
//		public static Craft StoneStove { get; } = new Craft("StoneStove", 3517);
//		/// <summary>
//		/// Recipe: 10x(CopperBar) -> 1x(CopperStove)<para/>
//		/// </summary>
//		public static Craft CopperStove { get; } = new Craft("CopperStove", 3518);
//		/// <summary>
//		/// Recipe: 10x(IronBar) -> 1x(IronStove)<para/>
//		/// </summary>
//		public static Craft IronStove { get; } = new Craft("IronStove", 3519);
//		/// <summary>
//		/// Recipe: 10x(SilverBar) -> 1x(SilverStove)<para/>
//		/// </summary>
//		public static Craft SilverStove { get; } = new Craft("SilverStove", 3520);
//		/// <summary>
//		/// Recipe: 10x(GoldBar) -> 1x(GoldenStove)<para/>
//		/// </summary>
//		public static Craft GoldenStove { get; } = new Craft("GoldenStove", 3521);
//		/// <summary>
//		/// Recipe: 10x(Diamond) -> 1x(DiamondStove)<para/>
//		/// </summary>
//		public static Craft DiamondStove { get; } = new Craft("DiamondStove", 3522);
//		/// <summary>
//		/// Recipe: 10x(StoneBlock) -> 1x(Furnace)<para/>
//		/// </summary>
//		public static Craft Furnace { get; } = new Craft("Furnace", 3523);
//		/// <summary>
//		/// Recipe: 10x(CopperBar) -> 1x(CopperAnvil)<para/>
//		/// </summary>
//		public static Craft CopperAnvil { get; } = new Craft("CopperAnvil", 3524);
//		/// <summary>
//		/// Recipe: 10x(IronBar) -> 1x(IronAnvil)<para/>
//		/// </summary>
//		public static Craft IronAnvil { get; } = new Craft("IronAnvil", 3525);
//		/// <summary>
//		/// Recipe: 10x(SilverBar) -> 1x(SilverAnvil)<para/>
//		/// </summary>
//		public static Craft SilverAnvil { get; } = new Craft("SilverAnvil", 3526);
//		/// <summary>
//		/// Recipe: 10x(GoldBar) -> 1x(GoldenAnvil)<para/>
//		/// </summary>
//		public static Craft GoldenAnvil { get; } = new Craft("GoldenAnvil", 3527);
//		/// <summary>
//		/// Recipe: 10x(Diamond) -> 1x(DiamondAnvil)<para/>
//		/// </summary>
//		public static Craft DiamondAnvil { get; } = new Craft("DiamondAnvil", 3528);
//		/// <summary>
//		/// Recipe: 10x(Wood) -> 1x(WoodenBrewery)<para/>
//		/// </summary>
//		public static Craft WoodenBrewery { get; } = new Craft("WoodenBrewery", 3529);
//		/// <summary>
//		/// Recipe: 10x(StoneBlock) -> 1x(StoneBrewery)<para/>
//		/// </summary>
//		public static Craft StoneBrewery { get; } = new Craft("StoneBrewery", 3530);
//		/// <summary>
//		/// Recipe: 10x(CopperBar) -> 1x(CopperBrewery)<para/>
//		/// </summary>
//		public static Craft CopperBrewery { get; } = new Craft("CopperBrewery", 3531);
//		/// <summary>
//		/// Recipe: 10x(IronBar) -> 1x(IronBrewery)<para/>
//		/// </summary>
//		public static Craft IronBrewery { get; } = new Craft("IronBrewery", 3532);
//		/// <summary>
//		/// Recipe: 10x(SilverBar) -> 1x(SilverBrewery)<para/>
//		/// </summary>
//		public static Craft SilverBrewery { get; } = new Craft("SilverBrewery", 3533);
//		/// <summary>
//		/// Recipe: 10x(GoldBar) -> 1x(GoldenBrewery)<para/>
//		/// </summary>
//		public static Craft GoldenBrewery { get; } = new Craft("GoldenBrewery", 3534);
//		/// <summary>
//		/// Recipe: 10x(Diamond) -> 1x(DiamondBrewery)<para/>
//		/// </summary>
//		public static Craft DiamondBrewery { get; } = new Craft("DiamondBrewery", 3535);
//		/// <summary>
//		/// Recipe: 10x(Wood) -> 1x(WoodenFurnitureWorkbench)<para/>
//		/// </summary>
//		public static Craft WoodenFurnitureWorkbench { get; } = new Craft("WoodenFurnitureWorkbench", 3536);
//		/// <summary>
//		/// Recipe: 10x(StoneBlock) -> 1x(StoneFurnitureWorkbench)<para/>
//		/// </summary>
//		public static Craft StoneFurnitureWorkbench { get; } = new Craft("StoneFurnitureWorkbench", 3537);
//		/// <summary>
//		/// Recipe: 10x(CopperBar) -> 1x(CopperFurnitureWorkbench)<para/>
//		/// </summary>
//		public static Craft CopperFurnitureWorkbench { get; } = new Craft("CopperFurnitureWorkbench", 3538);
//		/// <summary>
//		/// Recipe: 10x(IronBar) -> 1x(IronFurnitureWorkbench)<para/>
//		/// </summary>
//		public static Craft IronFurnitureWorkbench { get; } = new Craft("IronFurnitureWorkbench", 3539);
//		/// <summary>
//		/// Recipe: 10x(SilverBar) -> 1x(SilverFurnitureWorkbench)<para/>
//		/// </summary>
//		public static Craft SilverFurnitureWorkbench { get; } = new Craft("SilverFurnitureWorkbench", 3540);
//		/// <summary>
//		/// Recipe: 10x(GoldBar) -> 1x(GoldenFurnitureWorkbench)<para/>
//		/// </summary>
//		public static Craft GoldenFurnitureWorkbench { get; } = new Craft("GoldenFurnitureWorkbench", 3541);
//		/// <summary>
//		/// Recipe: 10x(Diamond) -> 1x(DiamondFurnitureBench)<para/>
//		/// </summary>
//		public static Craft DiamondFurnitureBench { get; } = new Craft("DiamondFurnitureBench", 3542);
//		/// <summary>
//		/// Recipe: 10x(Wood) -> 1x(WoodCraftTable)<para/>
//		/// </summary>
//		public static Craft WoodCraftTable { get; } = new Craft("WoodCraftTable", 3543);
//		/// <summary>
//		/// Recipe: 10x(StoneBlock) -> 1x(StoneCraft)<para/>
//		/// </summary>
//		public static Craft StoneCraft { get; } = new Craft("StoneCraft", 3544);
//		/// <summary>
//		/// Recipe: 10x(CopperBar) -> 1x(CopperCraftTable)<para/>
//		/// </summary>
//		public static Craft CopperCraftTable { get; } = new Craft("CopperCraftTable", 3545);
//		/// <summary>
//		/// Recipe: 10x(IronBar) -> 1x(IronCraftTable)<para/>
//		/// </summary>
//		public static Craft IronCraftTable { get; } = new Craft("IronCraftTable", 3546);
//		/// <summary>
//		/// Recipe: 10x(SilverBar) -> 1x(SilverCraftTable)<para/>
//		/// </summary>
//		public static Craft SilverCraftTable { get; } = new Craft("SilverCraftTable", 3547);
//		/// <summary>
//		/// Recipe: 10x(GoldBar) -> 1x(GoldCraftTable)<para/>
//		/// </summary>
//		public static Craft GoldCraftTable { get; } = new Craft("GoldCraftTable", 3548);
//		/// <summary>
//		/// Recipe: 10x(Diamond) -> 1x(DiamondCraftTable)<para/>
//		/// </summary>
//		public static Craft DiamondCraftTable { get; } = new Craft("DiamondCraftTable", 3549);
//		/// <summary>
//		/// Recipe: 10x(Wood) -> 1x(WoodenFirearmWorkbench)<para/>
//		/// </summary>
//		public static Craft WoodenFirearmWorkbench { get; } = new Craft("WoodenFirearmWorkbench", 3550);
//		/// <summary>
//		/// Recipe: 10x(StoneBlock) -> 1x(StoneFirearmWorkbench)<para/>
//		/// </summary>
//		public static Craft StoneFirearmWorkbench { get; } = new Craft("StoneFirearmWorkbench", 3551);
//		/// <summary>
//		/// Recipe: 10x(CopperBar) + 5x(SulfurOre) -> 1x(CopperFirearmWorkbench)<para/>
//		/// </summary>
//		public static Craft CopperFirearmWorkbench { get; } = new Craft("CopperFirearmWorkbench", 3552);
//		/// <summary>
//		/// Recipe: 10x(IronBar) + 5x(SulfurOre) -> 1x(IronFirearmWorkbench)<para/>
//		/// </summary>
//		public static Craft IronFirearmWorkbench { get; } = new Craft("IronFirearmWorkbench", 3553);
//		/// <summary>
//		/// Recipe: 10x(SilverBar) + 5x(SulfurOre) -> 1x(SilverFirearmWorkbench)<para/>
//		/// </summary>
//		public static Craft SilverFirearmWorkbench { get; } = new Craft("SilverFirearmWorkbench", 3554);
//		/// <summary>
//		/// Recipe: 10x(GoldBar) + 5x(SulfurOre) -> 1x(GoldenFirearmWorkbench)<para/>
//		/// </summary>
//		public static Craft GoldenFirearmWorkbench { get; } = new Craft("GoldenFirearmWorkbench", 3555);
//		/// <summary>
//		/// Recipe: 10x(Diamond) + 5x(SulfurOre) -> 1x(DiamondFirearmWorkbench)<para/>
//		/// </summary>
//		public static Craft DiamondFirearmWorkbench { get; } = new Craft("DiamondFirearmWorkbench", 3556);
//		/// <summary>
//		/// Recipe: 10x(StoneBlock) -> 1x(StoneDigester)<para/>
//		/// </summary>
//		public static Craft StoneDigester { get; } = new Craft("StoneDigester", 3557);
//		/// <summary>
//		/// Recipe: 10x(CopperBar) -> 1x(CopperBiogasTank)<para/>
//		/// </summary>
//		public static Craft CopperBiogasTank { get; } = new Craft("CopperBiogasTank", 3558);
//		/// <summary>
//		/// Recipe: 10x(IronBar) -> 1x(IronDigester)<para/>
//		/// </summary>
//		public static Craft IronDigester { get; } = new Craft("IronDigester", 3559);
//		/// <summary>
//		/// Recipe: 10x(SilverBar) -> 1x(SilverBiogasPool)<para/>
//		/// </summary>
//		public static Craft SilverBiogasPool { get; } = new Craft("SilverBiogasPool", 3560);
//		/// <summary>
//		/// Recipe: 10x(GoldBar) -> 1x(GoldBiogasPool)<para/>
//		/// </summary>
//		public static Craft GoldBiogasPool { get; } = new Craft("GoldBiogasPool", 3561);
//		/// <summary>
//		/// Recipe: 10x(Diamond) -> 1x(DiamondBiogasTank)<para/>
//		/// </summary>
//		public static Craft DiamondBiogasTank { get; } = new Craft("DiamondBiogasTank", 3562);
//		/// <summary>
//		/// Recipe: 20x(Bone) -> 1x(GoblinWorkbench)<para/>
//		/// </summary>
//		public static Craft GoblinWorkbench { get; } = new Craft("GoblinWorkbench", 3563);
//		/// <summary>
//		/// Recipe: 20x(InsectorExoskeleton) + 20x(Mucus) + 10x(InsectorEgg) -> 1x(FusionPool)<para/>
//		/// </summary>
//		public static Craft FusionPool { get; } = new Craft("FusionPool", 3564);
//		/// <summary>
//		/// Recipe: 3x(InsectorExoskeleton) + 3x(Mucus) + 3x(InsectorEgg) + 3x(ParasytorPrimordium) -> 1x(PlatingPool)<para/>
//		/// </summary>
//		public static Craft PlatingPool { get; } = new Craft("PlatingPool", 3565);
//		/// <summary>
//		/// Recipe: 20x(Amber) + 10x(SilverBar) -> 1x(GrounderWorkbench)<para/>
//		/// </summary>
//		public static Craft GrounderWorkbench { get; } = new Craft("GrounderWorkbench", 3569);
//		/// <summary>
//		/// Recipe: 3x(MecoAlloy) + 5x(MecoParasectMass) -> 1x(MecoTFurnace)<para/>
//		/// </summary>
//		public static Craft MecoTFurnace { get; } = new Craft("MecoTFurnace", 3572);
//		/// <summary>
//		/// Recipe: 6x(Wood) -> 1x(WoodenDoor)<para/>
//		/// </summary>
//		public static Craft WoodenDoor { get; } = new Craft("WoodenDoor", 3601);
//		/// <summary>
//		/// Recipe: 6x(StoneBlock) -> 1x(StoneDoor)<para/>
//		/// </summary>
//		public static Craft StoneDoor { get; } = new Craft("StoneDoor", 3602);
//		/// <summary>
//		/// Recipe: 6x(CopperBar) -> 1x(CopperDoor)<para/>
//		/// </summary>
//		public static Craft CopperDoor { get; } = new Craft("CopperDoor", 3603);
//		/// <summary>
//		/// Recipe: 6x(IronBar) -> 1x(IronDoor)<para/>
//		/// </summary>
//		public static Craft IronDoor { get; } = new Craft("IronDoor", 3604);
//		/// <summary>
//		/// Recipe: 6x(SilverBar) -> 1x(SilverDoor)<para/>
//		/// </summary>
//		public static Craft SilverDoor { get; } = new Craft("SilverDoor", 3605);
//		/// <summary>
//		/// Recipe: 6x(GoldBar) -> 1x(GoldenDoor)<para/>
//		/// </summary>
//		public static Craft GoldenDoor { get; } = new Craft("GoldenDoor", 3606);
//		/// <summary>
//		/// Recipe: 6x(SandBlock) -> 1x(SandDoor)<para/>
//		/// </summary>
//		public static Craft SandDoor { get; } = new Craft("SandDoor", 3607);
//		/// <summary>
//		/// Recipe: 6x(IceBlock) -> 1x(IceDoor)<para/>
//		/// </summary>
//		public static Craft IceDoor { get; } = new Craft("IceDoor", 3608);
//		/// <summary>
//		/// Recipe: 6x(SnowBlock) -> 1x(SnowDoor)<para/>
//		/// </summary>
//		public static Craft SnowDoor { get; } = new Craft("SnowDoor", 3609);
//		/// <summary>
//		/// Recipe: 6x(Glass) -> 1x(GlassDoor)<para/>
//		/// </summary>
//		public static Craft GlassDoor { get; } = new Craft("GlassDoor", 3610);
//		/// <summary>
//		/// Recipe: 5x(Wood) -> 1x(WoodenRoundTable)<para/>
//		/// </summary>
//		public static Craft WoodenRoundTable { get; } = new Craft("WoodenRoundTable", 3611);
//		/// <summary>
//		/// Recipe: 5x(StoneBlock) -> 1x(StoneRoundTable)<para/>
//		/// </summary>
//		public static Craft StoneRoundTable { get; } = new Craft("StoneRoundTable", 3612);
//		/// <summary>
//		/// Recipe: 5x(CopperBar) -> 1x(CopperRoundTable)<para/>
//		/// </summary>
//		public static Craft CopperRoundTable { get; } = new Craft("CopperRoundTable", 3613);
//		/// <summary>
//		/// Recipe: 5x(IronBar) -> 1x(IronRoundTable)<para/>
//		/// </summary>
//		public static Craft IronRoundTable { get; } = new Craft("IronRoundTable", 3614);
//		/// <summary>
//		/// Recipe: 5x(SilverBar) -> 1x(SilverRoundTable)<para/>
//		/// </summary>
//		public static Craft SilverRoundTable { get; } = new Craft("SilverRoundTable", 3615);
//		/// <summary>
//		/// Recipe: 5x(GoldBar) -> 1x(GoldenRoundTable)<para/>
//		/// </summary>
//		public static Craft GoldenRoundTable { get; } = new Craft("GoldenRoundTable", 3616);
//		/// <summary>
//		/// Recipe: 5x(DirtBlock) -> 1x(DirtRoundTable)<para/>
//		/// </summary>
//		public static Craft DirtRoundTable { get; } = new Craft("DirtRoundTable", 3617);
//		/// <summary>
//		/// Recipe: 5x(SnowBlock) -> 1x(SnowRoundTable)<para/>
//		/// </summary>
//		public static Craft SnowRoundTable { get; } = new Craft("SnowRoundTable", 3618);
//		/// <summary>
//		/// Recipe: 5x(DirtBlock) + 5x(Bone) -> 1x(BoneRoundTable)<para/>
//		/// </summary>
//		public static Craft BoneRoundTable { get; } = new Craft("BoneRoundTable", 3619);
//		/// <summary>
//		/// Recipe: 3x(Wood) -> 1x(WoodenChair)<para/>
//		/// </summary>
//		public static Craft WoodenChair { get; } = new Craft("WoodenChair", 3621);
//		/// <summary>
//		/// Recipe: 3x(StoneBlock) -> 1x(StoneChair)<para/>
//		/// </summary>
//		public static Craft StoneChair { get; } = new Craft("StoneChair", 3622);
//		/// <summary>
//		/// Recipe: 3x(CopperBar) -> 1x(CopperChair)<para/>
//		/// </summary>
//		public static Craft CopperChair { get; } = new Craft("CopperChair", 3623);
//		/// <summary>
//		/// Recipe: 3x(IronBar) -> 1x(IronChair)<para/>
//		/// </summary>
//		public static Craft IronChair { get; } = new Craft("IronChair", 3624);
//		/// <summary>
//		/// Recipe: 3x(SilverBar) -> 1x(SilverChair)<para/>
//		/// </summary>
//		public static Craft SilverChair { get; } = new Craft("SilverChair", 3625);
//		/// <summary>
//		/// Recipe: 3x(GoldBar) -> 1x(GoldenChair)<para/>
//		/// </summary>
//		public static Craft GoldenChair { get; } = new Craft("GoldenChair", 3626);
//		/// <summary>
//		/// Recipe: 3x(DirtBlock) -> 1x(DirtChair)<para/>
//		/// </summary>
//		public static Craft DirtChair { get; } = new Craft("DirtChair", 3627);
//		/// <summary>
//		/// Recipe: 3x(SnowBlock) -> 1x(SnowChair)<para/>
//		/// </summary>
//		public static Craft SnowChair { get; } = new Craft("SnowChair", 3628);
//		/// <summary>
//		/// Recipe: 5x(Bone) -> 1x(BoneChair)<para/>
//		/// </summary>
//		public static Craft BoneChair { get; } = new Craft("BoneChair", 3629);
//		/// <summary>
//		/// Recipe: 5x(Wood) -> 1x(WoodenChest)<para/>
//		/// </summary>
//		public static Craft WoodenChest { get; } = new Craft("WoodenChest", 3631);
//		/// <summary>
//		/// Recipe: 5x(CopperBar) -> 1x(CopperChest)<para/>
//		/// </summary>
//		public static Craft CopperChest { get; } = new Craft("CopperChest", 3632);
//		/// <summary>
//		/// Recipe: 5x(IronBar) -> 1x(IronChest)<para/>
//		/// </summary>
//		public static Craft IronChest { get; } = new Craft("IronChest", 3633);
//		/// <summary>
//		/// Recipe: 5x(SilverBar) -> 1x(SilverChest)<para/>
//		/// </summary>
//		public static Craft SilverChest { get; } = new Craft("SilverChest", 3634);
//		/// <summary>
//		/// Recipe: 5x(GoldBar) -> 1x(GoldenChest)<para/>
//		/// </summary>
//		public static Craft GoldenChest { get; } = new Craft("GoldenChest", 3635);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(VintageCopperChest)<para/>
//		/// </summary>
//		public static Craft VintageCopperChest { get; } = new Craft("VintageCopperChest", 3636);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(VintageIronChest)<para/>
//		/// </summary>
//		public static Craft VintageIronChest { get; } = new Craft("VintageIronChest", 3637);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(VintageSilverChest)<para/>
//		/// </summary>
//		public static Craft VintageSilverChest { get; } = new Craft("VintageSilverChest", 3638);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(BlueChest)<para/>
//		/// </summary>
//		public static Craft BlueChest { get; } = new Craft("BlueChest", 3639);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(GreenChest)<para/>
//		/// </summary>
//		public static Craft GreenChest { get; } = new Craft("GreenChest", 3640);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(PurpleChest)<para/>
//		/// </summary>
//		public static Craft PurpleChest { get; } = new Craft("PurpleChest", 3641);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(RedChest)<para/>
//		/// </summary>
//		public static Craft RedChest { get; } = new Craft("RedChest", 3642);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(VintageGoldChest)<para/>
//		/// </summary>
//		public static Craft VintageGoldChest { get; } = new Craft("VintageGoldChest", 3643);
//		/// <summary>
//		/// Recipe: 10x(Bone) -> 1x(BoneChest)<para/>
//		/// </summary>
//		public static Craft BoneChest { get; } = new Craft("BoneChest", 3644);
//		/// <summary>
//		/// Recipe: 5x(InsectorExoskeleton) + 1x(InsectorEgg) -> 1x(InsectorHaworth)<para/>
//		/// </summary>
//		public static Craft InsectorHaworth { get; } = new Craft("InsectorHaworth", 3646);
//		/// <summary>
//		/// Recipe: 8x(Wood) + 3x(Wool) -> 1x(WoodenBed)<para/>
//		/// </summary>
//		public static Craft WoodenBed { get; } = new Craft("WoodenBed", 3651);
//		/// <summary>
//		/// Recipe: 8x(StoneBlock) + 3x(Wool) -> 1x(StoneBed)<para/>
//		/// </summary>
//		public static Craft StoneBed { get; } = new Craft("StoneBed", 3652);
//		/// <summary>
//		/// Recipe: 8x(CopperBar) + 3x(Wool) -> 1x(CopperBed)<para/>
//		/// </summary>
//		public static Craft CopperBed { get; } = new Craft("CopperBed", 3653);
//		/// <summary>
//		/// Recipe: 8x(IronBar) + 3x(Wool) -> 1x(IronBed)<para/>
//		/// </summary>
//		public static Craft IronBed { get; } = new Craft("IronBed", 3654);
//		/// <summary>
//		/// Recipe: 8x(SilverBar) + 3x(Wool) -> 1x(SilverBed)<para/>
//		/// </summary>
//		public static Craft SilverBed { get; } = new Craft("SilverBed", 3655);
//		/// <summary>
//		/// Recipe: 8x(GoldBar) + 3x(Wool) -> 1x(GoldenBed)<para/>
//		/// </summary>
//		public static Craft GoldenBed { get; } = new Craft("GoldenBed", 3656);
//		/// <summary>
//		/// Recipe: 8x(DirtBlock) + 5x(Bone) + 3x(Wool) -> 1x(GoblinBed)<para/>
//		/// </summary>
//		public static Craft GoblinBed { get; } = new Craft("GoblinBed", 3660);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(VintageCopperDoor)<para/>
//		/// </summary>
//		public static Craft VintageCopperDoor { get; } = new Craft("VintageCopperDoor", 3661);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(VintageIronDoor)<para/>
//		/// </summary>
//		public static Craft VintageIronDoor { get; } = new Craft("VintageIronDoor", 3662);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(VintageSilverDoor)<para/>
//		/// </summary>
//		public static Craft VintageSilverDoor { get; } = new Craft("VintageSilverDoor", 3663);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(VintageGoldenDoor)<para/>
//		/// </summary>
//		public static Craft VintageGoldenDoor { get; } = new Craft("VintageGoldenDoor", 3664);
//		/// <summary>
//		/// Recipe: 6x(DirtBlock) -> 1x(DirtDoor)<para/>
//		/// </summary>
//		public static Craft DirtDoor { get; } = new Craft("DirtDoor", 3665);
//		/// <summary>
//		/// Recipe: 6x(Bone) -> 1x(BoneDoor)<para/>
//		/// </summary>
//		public static Craft BoneDoor { get; } = new Craft("BoneDoor", 3667);
//		/// <summary>
//		/// Recipe: 5x(Snowball) -> 1x(Snowman)<para/>
//		/// </summary>
//		public static Craft Snowman { get; } = new Craft("Snowman", 3701);
//		/// <summary>
//		/// Recipe: 3x(Clay) -> 1x(ClayFlowerPot)<para/>
//		/// </summary>
//		public static Craft ClayFlowerPot { get; } = new Craft("ClayFlowerPot", 3711);
//		/// <summary>
//		/// Recipe: 1x(Clay) -> 1x(ClayBottle)<para/>
//		/// </summary>
//		public static Craft ClayBottle { get; } = new Craft("ClayBottle", 3712);
//		/// <summary>
//		/// Recipe: 2x(Clay) -> 1x(ClayJar)<para/>
//		/// </summary>
//		public static Craft ClayJar { get; } = new Craft("ClayJar", 3713);
//		/// <summary>
//		/// Recipe: 3x(Glass) -> 1x(GlassFlowerPot)<para/>
//		/// </summary>
//		public static Craft GlassFlowerPot { get; } = new Craft("GlassFlowerPot", 3714);
//		/// <summary>
//		/// Recipe: 1x(Glass) -> 1x(GlassBottle)<para/>
//		/// </summary>
//		public static Craft GlassBottle { get; } = new Craft("GlassBottle", 3715);
//		/// <summary>
//		/// Recipe: 2x(Glass) -> 1x(GlassJar)<para/>
//		/// </summary>
//		public static Craft GlassJar { get; } = new Craft("GlassJar", 3716);
//		/// <summary>
//		/// Recipe: 10x(Glass) -> 1x(CeramicFlowerPot)<para/>
//		/// </summary>
//		public static Craft CeramicFlowerPot { get; } = new Craft("CeramicFlowerPot", 3717);
//		/// <summary>
//		/// Recipe: 10x(Clay) -> 1x(CeramicBottle)<para/>
//		/// </summary>
//		public static Craft CeramicBottle { get; } = new Craft("CeramicBottle", 3718);
//		/// <summary>
//		/// Recipe: 3x(DirtBlock) -> 1x(FlowerPot)<para/>
//		/// </summary>
//		public static Craft FlowerPot { get; } = new Craft("FlowerPot", 3723);
//		/// <summary>
//		/// Recipe: 1x(DirtBlock) -> 1x(Bottle)<para/>
//		/// </summary>
//		public static Craft Bottle { get; } = new Craft("Bottle", 3724);
//		/// <summary>
//		/// Recipe: 2x(DirtBlock) -> 1x(Jar)<para/>
//		/// </summary>
//		public static Craft Jar { get; } = new Craft("Jar", 3725);
//		/// <summary>
//		/// Recipe: 10x(DirtBlock) -> 1x(Sculpture)<para/>
//		/// </summary>
//		public static Craft Sculpture { get; } = new Craft("Sculpture", 3726);
//		/// <summary>
//		/// Recipe: 10x(Wood) -> 1x(WoodenModel)<para/>
//		/// </summary>
//		public static Craft WoodenModel { get; } = new Craft("WoodenModel", 3731);
//		/// <summary>
//		/// Recipe: 5x(Bone) -> 1x(BoneFlowerPot)<para/>
//		/// </summary>
//		public static Craft BoneFlowerPot { get; } = new Craft("BoneFlowerPot", 3741);
//		/// <summary>
//		/// Recipe: 5x(Wood) -> 1x(WoodenTable)<para/>
//		/// </summary>
//		public static Craft WoodenTable { get; } = new Craft("WoodenTable", 3761);
//		/// <summary>
//		/// Recipe: 5x(StoneBlock) -> 1x(StoneTable)<para/>
//		/// </summary>
//		public static Craft StoneTable { get; } = new Craft("StoneTable", 3762);
//		/// <summary>
//		/// Recipe: 5x(CopperBar) -> 1x(CopperTable)<para/>
//		/// </summary>
//		public static Craft CopperTable { get; } = new Craft("CopperTable", 3763);
//		/// <summary>
//		/// Recipe: 5x(IronBar) -> 1x(IronTable)<para/>
//		/// </summary>
//		public static Craft IronTable { get; } = new Craft("IronTable", 3764);
//		/// <summary>
//		/// Recipe: 5x(SilverBar) -> 1x(SilverTable)<para/>
//		/// </summary>
//		public static Craft SilverTable { get; } = new Craft("SilverTable", 3765);
//		/// <summary>
//		/// Recipe: 5x(GoldBar) -> 1x(GoldenTable)<para/>
//		/// </summary>
//		public static Craft GoldenTable { get; } = new Craft("GoldenTable", 3766);
//		/// <summary>
//		/// Recipe: 3x(Wood) + 3x(Gunpowder) + 1x(StoneBlock) -> 1x(ExplosiveBarrel)<para/>
//		/// </summary>
//		public static Craft ExplosiveBarrel { get; } = new Craft("ExplosiveBarrel", 3771);
//		/// <summary>
//		/// Recipe: 10x(Wood) -> 1x(WoodenFeedingTrough)<para/>
//		/// </summary>
//		public static Craft WoodenFeedingTrough { get; } = new Craft("WoodenFeedingTrough", 3781);
//		/// <summary>
//		/// Recipe: 10x(StoneBlock) -> 1x(StoneFeedingTrough)<para/>
//		/// </summary>
//		public static Craft StoneFeedingTrough { get; } = new Craft("StoneFeedingTrough", 3782);
//		/// <summary>
//		/// Recipe: 10x(CopperBar) -> 1x(CopperFeedingTrough)<para/>
//		/// </summary>
//		public static Craft CopperFeedingTrough { get; } = new Craft("CopperFeedingTrough", 3783);
//		/// <summary>
//		/// Recipe: 10x(IronBar) -> 1x(IronFeedingTrough)<para/>
//		/// </summary>
//		public static Craft IronFeedingTrough { get; } = new Craft("IronFeedingTrough", 3784);
//		/// <summary>
//		/// Recipe: 10x(SilverBar) -> 1x(SilverFeedingTrough)<para/>
//		/// </summary>
//		public static Craft SilverFeedingTrough { get; } = new Craft("SilverFeedingTrough", 3785);
//		/// <summary>
//		/// Recipe: 10x(GoldBar) -> 1x(GoldenFeedingTrough)<para/>
//		/// </summary>
//		public static Craft GoldenFeedingTrough { get; } = new Craft("GoldenFeedingTrough", 3786);
//		/// <summary>
//		/// Recipe: 5x(SilverBar) + 3x(Wool) + 3x(Leather) -> 1x(GrounderTent)<para/>
//		/// </summary>
//		public static Craft GrounderTent { get; } = new Craft("GrounderTent", 3832);
//		/// <summary>
//		/// Recipe: 10x(Wood) + 5x(CopperBar) + 5x(IronBar) -> 1x(MinerSimpleLift)<para/>
//		/// </summary>
//		public static Craft MinerSimpleLift { get; } = new Craft("MinerSimpleLift", 3871);
//		/// <summary>
//		/// Recipe: 10x(CopperBar) + 20x(InsectorExoskeleton) + 10x(ParasytorPrimordium) -> 1x(CopperInsectorHarvester)<para/>
//		/// </summary>
//		public static Craft CopperInsectorHarvester { get; } = new Craft("CopperInsectorHarvester", 3881);
//		/// <summary>
//		/// Recipe: 10x(IronBar) + 20x(InsectorExoskeleton) + 10x(ParasytorPrimordium) -> 1x(IronInsectorHarvester)<para/>
//		/// </summary>
//		public static Craft IronInsectorHarvester { get; } = new Craft("IronInsectorHarvester", 3882);
//		/// <summary>
//		/// Recipe: 10x(SilverBar) + 20x(InsectorExoskeleton) + 10x(ParasytorPrimordium) -> 1x(SilverInsectorHarvester)<para/>
//		/// </summary>
//		public static Craft SilverInsectorHarvester { get; } = new Craft("SilverInsectorHarvester", 3883);
//		/// <summary>
//		/// Recipe: 10x(GoldBar) + 20x(InsectorExoskeleton) + 10x(ParasytorPrimordium) -> 1x(GoldenInsectorHarvester)<para/>
//		/// </summary>
//		public static Craft GoldenInsectorHarvester { get; } = new Craft("GoldenInsectorHarvester", 3884);
//		/// <summary>
//		/// Recipe: 1x(WoodenModel) + 3x(Wool) + 3x(Leather) -> 1x(TargetDummy)<para/>
//		/// </summary>
//		public static Craft TargetDummy { get; } = new Craft("TargetDummy", 3891);
//		/// <summary>
//		/// Recipe: 1x(Wood) -> 3x(WoodenFloor)<para/>
//		/// </summary>
//		public static Craft WoodenFloor0 { get; } = new Craft("WoodenFloor0", 5001);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 3x(WoodenFloor)<para/>
//		/// </summary>
//		public static Craft WoodenFloor1 { get; } = new Craft("WoodenFloor1", 5002);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 3x(WoodenFloor)<para/>
//		/// </summary>
//		public static Craft WoodenFloor2 { get; } = new Craft("WoodenFloor2", 5003);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 3x(WoodenFloor)<para/>
//		/// </summary>
//		public static Craft WoodenFloor3 { get; } = new Craft("WoodenFloor3", 5004);
//		/// <summary>
//		/// Recipe: 1x(DirtBlock) -> 3x(DirtFloor)<para/>
//		/// </summary>
//		public static Craft DirtFloor0 { get; } = new Craft("DirtFloor0", 5005);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 3x(DirtFloor)<para/>
//		/// </summary>
//		public static Craft DirtFloor1 { get; } = new Craft("DirtFloor1", 5006);
//		/// <summary>
//		/// Recipe: 1x(StoneBlock) -> 3x(StoneFloor)<para/>
//		/// </summary>
//		public static Craft StoneFloor0 { get; } = new Craft("StoneFloor0", 5007);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 3x(StoneFloor)<para/>
//		/// </summary>
//		public static Craft StoneFloor1 { get; } = new Craft("StoneFloor1", 5008);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 3x(StoneFloor)<para/>
//		/// </summary>
//		public static Craft StoneFloor2 { get; } = new Craft("StoneFloor2", 5009);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 3x(StoneFloor)<para/>
//		/// </summary>
//		public static Craft StoneFloor3 { get; } = new Craft("StoneFloor3", 5010);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 3x(StoneFloor)<para/>
//		/// </summary>
//		public static Craft StoneFloor4 { get; } = new Craft("StoneFloor4", 5011);
//		/// <summary>
//		/// Recipe: 1x(CopperBar) -> 3x(CopperFloor)<para/>
//		/// </summary>
//		public static Craft CopperFloor0 { get; } = new Craft("CopperFloor0", 5012);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 3x(CopperFloor)<para/>
//		/// </summary>
//		public static Craft CopperFloor1 { get; } = new Craft("CopperFloor1", 5013);
//		/// <summary>
//		/// Recipe: 1x(IronBar) -> 3x(IronFloor)<para/>
//		/// </summary>
//		public static Craft IronFloor0 { get; } = new Craft("IronFloor0", 5014);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 3x(IronFloor)<para/>
//		/// </summary>
//		public static Craft IronFloor1 { get; } = new Craft("IronFloor1", 5015);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 3x(IronFloor)<para/>
//		/// </summary>
//		public static Craft IronFloor2 { get; } = new Craft("IronFloor2", 5016);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 3x(IronFloor)<para/>
//		/// </summary>
//		public static Craft IronFloor3 { get; } = new Craft("IronFloor3", 5017);
//		/// <summary>
//		/// Recipe: 1x(SilverBar) -> 3x(SilverFloor)<para/>
//		/// </summary>
//		public static Craft SilverFloor0 { get; } = new Craft("SilverFloor0", 5018);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 3x(SilverFloor)<para/>
//		/// </summary>
//		public static Craft SilverFloor1 { get; } = new Craft("SilverFloor1", 5019);
//		/// <summary>
//		/// Recipe: 1x(GoldBar) -> 3x(GoldFloor)<para/>
//		/// </summary>
//		public static Craft GoldFloor0 { get; } = new Craft("GoldFloor0", 5020);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 3x(GoldFloor)<para/>
//		/// </summary>
//		public static Craft GoldFloor1 { get; } = new Craft("GoldFloor1", 5021);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 3x(GoldFloor)<para/>
//		/// </summary>
//		public static Craft GoldFloor2 { get; } = new Craft("GoldFloor2", 5022);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 3x(GoldFloor)<para/>
//		/// </summary>
//		public static Craft GoldFloor3 { get; } = new Craft("GoldFloor3", 5023);
//		/// <summary>
//		/// Recipe: 1x(Glass) -> 3x(GlassFloor)<para/>
//		/// </summary>
//		public static Craft GlassFloor { get; } = new Craft("GlassFloor", 5024);
//		/// <summary>
//		/// Recipe: 1x(SnowBlock) -> 3x(SnowFloor)<para/>
//		/// </summary>
//		public static Craft SnowFloor { get; } = new Craft("SnowFloor", 5025);
//		/// <summary>
//		/// Recipe: 1x(IceBlock) -> 3x(IceFloor)<para/>
//		/// </summary>
//		public static Craft IceFloor { get; } = new Craft("IceFloor", 5026);
//		/// <summary>
//		/// Recipe: 1x(SandBlock) -> 3x(SandFloor)<para/>
//		/// </summary>
//		public static Craft SandFloor { get; } = new Craft("SandFloor", 5027);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldWoodenFloor)<para/>
//		/// </summary>
//		public static Craft OldWoodenFloor0 { get; } = new Craft("OldWoodenFloor0", 5501);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldWoodenFloor)<para/>
//		/// </summary>
//		public static Craft OldWoodenFloor1 { get; } = new Craft("OldWoodenFloor1", 5502);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldWoodenFloor)<para/>
//		/// </summary>
//		public static Craft OldWoodenFloor2 { get; } = new Craft("OldWoodenFloor2", 5503);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldWoodenFloor)<para/>
//		/// </summary>
//		public static Craft OldWoodenFloor3 { get; } = new Craft("OldWoodenFloor3", 5504);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldDirtFloor)<para/>
//		/// </summary>
//		public static Craft OldDirtFloor0 { get; } = new Craft("OldDirtFloor0", 5505);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldDirtFloor)<para/>
//		/// </summary>
//		public static Craft OldDirtFloor1 { get; } = new Craft("OldDirtFloor1", 5506);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldStoneFloor)<para/>
//		/// </summary>
//		public static Craft OldStoneFloor0 { get; } = new Craft("OldStoneFloor0", 5507);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldStoneFloor)<para/>
//		/// </summary>
//		public static Craft OldStoneFloor1 { get; } = new Craft("OldStoneFloor1", 5508);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldStoneFloor)<para/>
//		/// </summary>
//		public static Craft OldStoneFloor2 { get; } = new Craft("OldStoneFloor2", 5509);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldStoneFloor)<para/>
//		/// </summary>
//		public static Craft OldStoneFloor3 { get; } = new Craft("OldStoneFloor3", 5510);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldStoneFloor)<para/>
//		/// </summary>
//		public static Craft OldStoneFloor4 { get; } = new Craft("OldStoneFloor4", 5511);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldCopperFloor)<para/>
//		/// </summary>
//		public static Craft OldCopperFloor0 { get; } = new Craft("OldCopperFloor0", 5512);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldCopperFloor)<para/>
//		/// </summary>
//		public static Craft OldCopperFloor1 { get; } = new Craft("OldCopperFloor1", 5513);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldIronFloor)<para/>
//		/// </summary>
//		public static Craft OldIronFloor0 { get; } = new Craft("OldIronFloor0", 5514);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldIronFloor)<para/>
//		/// </summary>
//		public static Craft OldIronFloor1 { get; } = new Craft("OldIronFloor1", 5515);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldIronFloor)<para/>
//		/// </summary>
//		public static Craft OldIronFloor2 { get; } = new Craft("OldIronFloor2", 5516);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldIronFloor)<para/>
//		/// </summary>
//		public static Craft OldIronFloor3 { get; } = new Craft("OldIronFloor3", 5517);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldSilverFloor)<para/>
//		/// </summary>
//		public static Craft OldSilverFloor0 { get; } = new Craft("OldSilverFloor0", 5518);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldSilverFloor)<para/>
//		/// </summary>
//		public static Craft OldSilverFloor1 { get; } = new Craft("OldSilverFloor1", 5519);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldGoldFloor)<para/>
//		/// </summary>
//		public static Craft OldGoldFloor0 { get; } = new Craft("OldGoldFloor0", 5520);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldGoldFloor)<para/>
//		/// </summary>
//		public static Craft OldGoldFloor1 { get; } = new Craft("OldGoldFloor1", 5521);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldGoldFloor)<para/>
//		/// </summary>
//		public static Craft OldGoldFloor2 { get; } = new Craft("OldGoldFloor2", 5522);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldGoldFloor)<para/>
//		/// </summary>
//		public static Craft OldGoldFloor3 { get; } = new Craft("OldGoldFloor3", 5523);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldGlassFloor)<para/>
//		/// </summary>
//		public static Craft OldGlassFloor { get; } = new Craft("OldGlassFloor", 5524);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldSnowFloor)<para/>
//		/// </summary>
//		public static Craft OldSnowFloor { get; } = new Craft("OldSnowFloor", 5525);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldIceFloor)<para/>
//		/// </summary>
//		public static Craft OldIceFloor { get; } = new Craft("OldIceFloor", 5526);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(OldSandFloor)<para/>
//		/// </summary>
//		public static Craft OldSandFloor { get; } = new Craft("OldSandFloor", 5527);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(WoodAxe)<para/>
//		/// </summary>
//		public static Craft WoodAxe { get; } = new Craft("WoodAxe", 6001);
//		/// <summary>
//		/// Recipe: 6x(StoneBlock) + 1x(Wood) -> 1x(StoneAxe)<para/>
//		/// </summary>
//		public static Craft StoneAxe { get; } = new Craft("StoneAxe", 6002);
//		/// <summary>
//		/// Recipe: 6x(CopperBar) + 1x(Wood) -> 1x(CopperAxe)<para/>
//		/// </summary>
//		public static Craft CopperAxe { get; } = new Craft("CopperAxe", 6003);
//		/// <summary>
//		/// Recipe: 6x(IronBar) + 1x(Wood) -> 1x(IronAxe)<para/>
//		/// </summary>
//		public static Craft IronAxe { get; } = new Craft("IronAxe", 6004);
//		/// <summary>
//		/// Recipe: 6x(SilverBar) + 1x(Wood) -> 1x(SilverAxe)<para/>
//		/// </summary>
//		public static Craft SilverAxe { get; } = new Craft("SilverAxe", 6005);
//		/// <summary>
//		/// Recipe: 6x(GoldBar) + 1x(Wood) -> 1x(GoldAxe)<para/>
//		/// </summary>
//		public static Craft GoldAxe { get; } = new Craft("GoldAxe", 6006);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(DiamondAxe)<para/>
//		/// </summary>
//		public static Craft DiamondAxe { get; } = new Craft("DiamondAxe", 6007);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(WoodPickaxe)<para/>
//		/// </summary>
//		public static Craft WoodPickaxe { get; } = new Craft("WoodPickaxe", 6101);
//		/// <summary>
//		/// Recipe: 6x(StoneBlock) + 1x(Wood) -> 1x(StonePickaxe)<para/>
//		/// </summary>
//		public static Craft StonePickaxe { get; } = new Craft("StonePickaxe", 6102);
//		/// <summary>
//		/// Recipe: 6x(CopperBar) + 1x(Wood) -> 1x(CopperPickaxe)<para/>
//		/// </summary>
//		public static Craft CopperPickaxe { get; } = new Craft("CopperPickaxe", 6103);
//		/// <summary>
//		/// Recipe: 6x(IronBar) + 1x(Wood) -> 1x(IronPickaxe)<para/>
//		/// </summary>
//		public static Craft IronPickaxe { get; } = new Craft("IronPickaxe", 6104);
//		/// <summary>
//		/// Recipe: 6x(SilverBar) + 1x(Wood) -> 1x(SilverPickaxe)<para/>
//		/// </summary>
//		public static Craft SilverPickaxe { get; } = new Craft("SilverPickaxe", 6105);
//		/// <summary>
//		/// Recipe: 6x(GoldBar) + 1x(Wood) -> 1x(GoldPickaxe)<para/>
//		/// </summary>
//		public static Craft GoldPickaxe { get; } = new Craft("GoldPickaxe", 6106);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(Diamond)<para/>
//		/// </summary>
//		public static Craft Diamond { get; } = new Craft("Diamond", 6107);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(WoodenShovel)<para/>
//		/// </summary>
//		public static Craft WoodenShovel { get; } = new Craft("WoodenShovel", 6201);
//		/// <summary>
//		/// Recipe: 6x(StoneBlock) + 1x(Wood) -> 1x(StoneShovel)<para/>
//		/// </summary>
//		public static Craft StoneShovel { get; } = new Craft("StoneShovel", 6202);
//		/// <summary>
//		/// Recipe: 6x(CopperBar) + 1x(Wood) -> 1x(CopperShovel)<para/>
//		/// </summary>
//		public static Craft CopperShovel { get; } = new Craft("CopperShovel", 6203);
//		/// <summary>
//		/// Recipe: 6x(IronBar) + 1x(Wood) -> 1x(IronShovel)<para/>
//		/// </summary>
//		public static Craft IronShovel { get; } = new Craft("IronShovel", 6204);
//		/// <summary>
//		/// Recipe: 6x(SilverBar) + 1x(Wood) -> 1x(SilverShovel)<para/>
//		/// </summary>
//		public static Craft SilverShovel { get; } = new Craft("SilverShovel", 6205);
//		/// <summary>
//		/// Recipe: 6x(GoldBar) + 1x(Wood) -> 1x(GoldShovel)<para/>
//		/// </summary>
//		public static Craft GoldShovel { get; } = new Craft("GoldShovel", 6206);
//		/// <summary>
//		/// Recipe: 0x(Item0) -> 1x(DiamondShovel)<para/>
//		/// </summary>
//		public static Craft DiamondShovel { get; } = new Craft("DiamondShovel", 6207);
//		/// <summary>
//		/// Recipe: 10x(Bone) -> 1x(BoneCage)<para/>
//		/// </summary>
//		public static Craft BoneCage { get; } = new Craft("BoneCage", 6301);
//		/// <summary>
//		/// Recipe: 25x(InsectorExoskeleton) + 10x(ParasytorPrimordium) -> 1x(InsectorDrill)<para/>
//		/// </summary>
//		public static Craft InsectorDrill { get; } = new Craft("InsectorDrill", 6401);
//		/// <summary>
//		/// Recipe: 5x(InsectorExoskeleton) + 5x(Mucus) + 20x(InsectorEgg) -> 1x(InsectorNest)<para/>
//		/// </summary>
//		public static Craft InsectorNest { get; } = new Craft("InsectorNest", 7301);
//		/// <summary>
//		/// Recipe: 6x(Wood) -> 1x(PunjiSticks)<para/>
//		/// </summary>
//		public static Craft PunjiSticks { get; } = new Craft("PunjiSticks", 7631);
//		/// <summary>
//		/// Recipe: 10x(Bone) -> 1x(GoblinBearTrap)<para/>
//		/// </summary>
//		public static Craft GoblinBearTrap { get; } = new Craft("GoblinBearTrap", 7632);
//		/// <summary>
//		/// Recipe: 20x(Mucus) + 10x(InsectorEgg) + 20x(ParasytorPrimordium) -> 1x(PoisonousSacTrap)<para/>
//		/// </summary>
//		public static Craft PoisonousSacTrap { get; } = new Craft("PoisonousSacTrap", 7633);
//		/// <summary>
//		/// Recipe: 1x(SilverBar) + 3x(Gunpowder) -> 3x(GrounderLandmine)<para/>
//		/// </summary>
//		public static Craft GrounderLandmine { get; } = new Craft("GrounderLandmine", 7634);
//		/// <summary>
//		/// Recipe: 5x(SilverBar) + 5x(Wood) + 2x(Leather) -> 1x(TwoSeaterSofa)<para/>
//		/// </summary>
//		public static Craft TwoSeaterSofa { get; } = new Craft("TwoSeaterSofa", 8201);
//		/// <summary>
//		/// Recipe: 3x(SilverBar) + 3x(Wood) + 1x(Leather) -> 1x(SingleSeaterSofa)<para/>
//		/// </summary>
//		public static Craft SingleSeaterSofa { get; } = new Craft("SingleSeaterSofa", 8202);
//		/// <summary>
//		/// Recipe: 5x(MonsterSkin) -> 1x(Leather)<para/>
//		/// </summary>
//		public static Craft Leather { get; } = new Craft("Leather", 9008);
//		/// <summary>
//		/// Recipe: 1x(GoblinBoneBow) -> 3x(Bone)<para/>
//		/// </summary>
//		public static Craft Bone0 { get; } = new Craft("Bone0", 20001);
//		/// <summary>
//		/// Recipe: 1x(GoblinBoneDagger) -> 3x(Bone)<para/>
//		/// </summary>
//		public static Craft Bone1 { get; } = new Craft("Bone1", 20002);
//		/// <summary>
//		/// Recipe: 1x(BoneWall) -> 2x(Bone)<para/>
//		/// </summary>
//		public static Craft Bone2 { get; } = new Craft("Bone2", 20003);
//		/// <summary>
//		/// Recipe: 1x(BoneFence) -> 1x(Bone)<para/>
//		/// </summary>
//		public static Craft Bone3 { get; } = new Craft("Bone3", 20004);
//		/// <summary>
//		/// Recipe: 1x(BonyBall) -> 1x(Bone)<para/>
//		/// </summary>
//		public static Craft Bone4 { get; } = new Craft("Bone4", 20005);
//		/// <summary>
//		/// Recipe: 1x(BoneFlowerPot) -> 2x(Bone)<para/>
//		/// </summary>
//		public static Craft Bone5 { get; } = new Craft("Bone5", 20006);
//		/// <summary>
//		/// Recipe: 1x(BoneDoor) -> 2x(Bone)<para/>
//		/// </summary>
//		public static Craft Bone6 { get; } = new Craft("Bone6", 20007);
//		/// <summary>
//		/// Recipe: 1x(GoblinTikiTorch) -> 1x(Bone)<para/>
//		/// </summary>
//		public static Craft Bone7 { get; } = new Craft("Bone7", 20008);
//		/// <summary>
//		/// Recipe: 1x(BoneChest) -> 2x(Bone)<para/>
//		/// </summary>
//		public static Craft Bone8 { get; } = new Craft("Bone8", 20009);
//		/// <summary>
//		/// Recipe: 1x(BoneRoundTable) -> 2x(Bone)<para/>
//		/// </summary>
//		public static Craft Bone9 { get; } = new Craft("Bone9", 20010);
//		/// <summary>
//		/// Recipe: 1x(BoneChair) -> 2x(Bone)<para/>
//		/// </summary>
//		public static Craft Bone10 { get; } = new Craft("Bone10", 20011);
//		/// <summary>
//		/// Recipe: 1x(GoblinBoneSword) -> 8x(Bone)<para/>
//		/// </summary>
//		public static Craft Bone11 { get; } = new Craft("Bone11", 20012);
//		/// <summary>
//		/// Recipe: 1x(GoblinWorkbench) -> 5x(Bone)<para/>
//		/// </summary>
//		public static Craft Bone12 { get; } = new Craft("Bone12", 20013);
//		/// <summary>
//		/// Recipe: 1x(GoblinBed) -> 2x(Bone)<para/>
//		/// </summary>
//		public static Craft Bone13 { get; } = new Craft("Bone13", 20014);
//		/// <summary>
//		/// Recipe: 1x(RoastedChicken) + 10x(Mucus) -> 1x(PheromonesChicken)<para/>
//		/// </summary>
//		public static Craft PheromonesChicken1 { get; } = new Craft("PheromonesChicken1", 20020);
//		/// <summary>
//		/// Recipe: 1x(RoastedLamb) + 10x(Mucus) -> 1x(PheromonesGoat)<para/>
//		/// </summary>
//		public static Craft PheromonesGoat1 { get; } = new Craft("PheromonesGoat1", 20021);
//		/// <summary>
//		/// Recipe: 1x(RoastedPork) + 10x(Mucus) -> 1x(PheromonesPig)<para/>
//		/// </summary>
//		public static Craft PheromonesPig1 { get; } = new Craft("PheromonesPig1", 20022);
//		/// <summary>
//		/// Recipe: 1x(RoastedBeef) + 10x(Mucus) -> 1x(PheromonesCow)<para/>
//		/// </summary>
//		public static Craft PheromonesCow1 { get; } = new Craft("PheromonesCow1", 20023);
//		/// <summary>
//		/// Recipe: 1x(RoastedHorseMeat) + 10x(Mucus) -> 1x(PheromonesHorse)<para/>
//		/// </summary>
//		public static Craft PheromonesHorse1 { get; } = new Craft("PheromonesHorse1", 20024);
//		/// <summary>
//		/// Recipe: 15x(TenergyShard) -> 1x(Tenergy)<para/>
//		/// </summary>
//		public static Craft Tenergy0 { get; } = new Craft("Tenergy0", 20025);
//		/// <summary>
//		/// Recipe: 4x(SilverBar) -> 1x(Tenergy)<para/>
//		/// </summary>
//		public static Craft Tenergy1 { get; } = new Craft("Tenergy1", 20026);
//		/// <summary>
//		/// Recipe: 1x(GoldBar) -> 1x(Tenergy)<para/>
//		/// </summary>
//		public static Craft Tenergy2 { get; } = new Craft("Tenergy2", 20027);
//		/// <summary>
//		/// Recipe: 1x(ChickenMeat) + 3x(ParasytorPrimordium) + 1x(InsectorEgg) -> 1x(MonsterMeat)<para/>
//		/// </summary>
//		public static Craft MonsterMeat0 { get; } = new Craft("MonsterMeat0", 20028);
//		/// <summary>
//		/// Recipe: 1x(DogMeat) + 3x(ParasytorPrimordium) + 1x(InsectorEgg) -> 1x(MonsterMeat)<para/>
//		/// </summary>
//		public static Craft MonsterMeat1 { get; } = new Craft("MonsterMeat1", 20029);
//		/// <summary>
//		/// Recipe: 1x(Lamb) + 3x(ParasytorPrimordium) + 1x(InsectorEgg) -> 1x(MonsterMeat)<para/>
//		/// </summary>
//		public static Craft MonsterMeat2 { get; } = new Craft("MonsterMeat2", 20030);
//		/// <summary>
//		/// Recipe: 1x(Pork) + 3x(ParasytorPrimordium) + 1x(InsectorEgg) -> 1x(MonsterMeat)<para/>
//		/// </summary>
//		public static Craft MonsterMeat3 { get; } = new Craft("MonsterMeat3", 20031);
//		/// <summary>
//		/// Recipe: 1x(Beef) + 3x(ParasytorPrimordium) + 1x(InsectorEgg) -> 1x(MonsterMeat)<para/>
//		/// </summary>
//		public static Craft MonsterMeat4 { get; } = new Craft("MonsterMeat4", 20032);
//		/// <summary>
//		/// Recipe: 1x(HorseMeat) + 3x(ParasytorPrimordium) + 1x(InsectorEgg) -> 1x(MonsterMeat)<para/>
//		/// </summary>
//		public static Craft MonsterMeat5 { get; } = new Craft("MonsterMeat5", 20033);
//		/// <summary>
//		/// Recipe: 5x(StimulantsI) + 3x(Tenergy) -> 1x(StimulantsII)<para/>
//		/// </summary>
//		public static Craft StimulantsII { get; } = new Craft("StimulantsII", 20034);
//		/// <summary>
//		/// Recipe: 5x(StimulantsII) + 3x(Tenergy) -> 1x(StimulantsIII)<para/>
//		/// </summary>
//		public static Craft StimulantsIII { get; } = new Craft("StimulantsIII", 20035);
//		/// <summary>
//		/// Recipe: 5x(DamagedATKCapsule) + 1x(Tenergy) -> 1x(ATKCapsule)<para/>
//		/// </summary>
//		public static Craft ATKCapsule1 { get; } = new Craft("ATKCapsule1", 20036);
//		/// <summary>
//		/// Recipe: 3x(ExpiredATKCapsule) + 1x(Tenergy) -> 1x(ATKCapsule)<para/>
//		/// </summary>
//		public static Craft ATKCapsule2 { get; } = new Craft("ATKCapsule2", 20037);
//		/// <summary>
//		/// Recipe: 5x(ATKCapsule) + 3x(Tenergy) -> 1x(ATKCapsuleExtra)<para/>
//		/// </summary>
//		public static Craft ATKCapsuleExtra { get; } = new Craft("ATKCapsuleExtra", 20038);
//		/// <summary>
//		/// Recipe: 5x(ATKCapsuleExtra) + 3x(Tenergy) -> 1x(ATKCapsuleExtraAdvance)<para/>
//		/// </summary>
//		public static Craft ATKCapsuleExtraAdvance { get; } = new Craft("ATKCapsuleExtraAdvance", 20039);
//		/// <summary>
//		/// Recipe: 5x(DamagedDEFCapsule) + 1x(Tenergy) -> 1x(DEFCapsule)<para/>
//		/// </summary>
//		public static Craft DEFCapsule1 { get; } = new Craft("DEFCapsule1", 20040);
//		/// <summary>
//		/// Recipe: 3x(ExpiredDEFCapsule) + 1x(Tenergy) -> 1x(DEFCapsule)<para/>
//		/// </summary>
//		public static Craft DEFCapsule2 { get; } = new Craft("DEFCapsule2", 20041);
//		/// <summary>
//		/// Recipe: 5x(DEFCapsule) + 3x(Tenergy) -> 1x(DEFCapsuleExtra)<para/>
//		/// </summary>
//		public static Craft DEFCapsuleExtra { get; } = new Craft("DEFCapsuleExtra", 20042);
//		/// <summary>
//		/// Recipe: 5x(DEFCapsuleExtra) + 3x(Tenergy) -> 1x(DEFCapsuleExtraAdvance)<para/>
//		/// </summary>
//		public static Craft DEFCapsuleExtraAdvance { get; } = new Craft("DEFCapsuleExtraAdvance", 20043);
//		/// <summary>
//		/// Recipe: 5x(DamagedAGLPotion) + 1x(Tenergy) -> 1x(AGLPotion)<para/>
//		/// </summary>
//		public static Craft AGLPotion1 { get; } = new Craft("AGLPotion1", 20044);
//		/// <summary>
//		/// Recipe: 3x(ExpiredAGLPotion) + 1x(Tenergy) -> 1x(AGLPotion)<para/>
//		/// </summary>
//		public static Craft AGLPotion2 { get; } = new Craft("AGLPotion2", 20045);
//		/// <summary>
//		/// Recipe: 5x(AGLPotion) + 3x(Tenergy) -> 1x(AGLPotionExtra)<para/>
//		/// </summary>
//		public static Craft AGLPotionExtra { get; } = new Craft("AGLPotionExtra", 20046);
//		/// <summary>
//		/// Recipe: 5x(AGLPotionExtra) + 3x(Tenergy) -> 1x(AGLPotionExtraAdvance)<para/>
//		/// </summary>
//		public static Craft AGLPotionExtraAdvance { get; } = new Craft("AGLPotionExtraAdvance", 20047);
//		/// <summary>
//		/// Recipe: 5x(MecoJoyfulI) + 1x(Tenergy) -> 1x(MecoJoyfulIII)<para/>
//		/// </summary>
//		public static Craft MecoJoyfulIII1 { get; } = new Craft("MecoJoyfulIII1", 20048);
//		/// <summary>
//		/// Recipe: 3x(MecoJoyfulII) + 1x(Tenergy) -> 1x(MecoJoyfulIII)<para/>
//		/// </summary>
//		public static Craft MecoJoyfulIII2 { get; } = new Craft("MecoJoyfulIII2", 20049);
//		/// <summary>
//		/// Recipe: 5x(MecoJoyfulIII) + 3x(Tenergy) -> 1x(MecoJoyfulIV)<para/>
//		/// </summary>
//		public static Craft MecoJoyfulIV { get; } = new Craft("MecoJoyfulIV", 20050);
//		/// <summary>
//		/// Recipe: 5x(MecoJoyfulIV) + 3x(Tenergy) -> 1x(MecoJoyfulV)<para/>
//		/// </summary>
//		public static Craft MecoJoyfulV { get; } = new Craft("MecoJoyfulV", 20051);
//		/// <summary>
//		/// Recipe: 1x(Wool) -> 3x(String)<para/>
//		/// </summary>
//		public static Craft String { get; } = new Craft("String", 9010);
//		/// <summary>
//		/// Recipe: 1x(SulfurOre) + 1x(SaltpeterOre) + 1x(Wood) -> 1x(Gunpowder)<para/>
//		/// </summary>
//		public static Craft Gunpowder0 { get; } = new Craft("Gunpowder0", 9015);
//		/// <summary>
//		/// Recipe: 2x(Amber) + 1x(Wood) -> 1x(Gunpowder)<para/>
//		/// </summary>
//		public static Craft Gunpowder1 { get; } = new Craft("Gunpowder1", 90151);
//		/// <summary>
//		/// Recipe: 1x(SilverBar) -> 10x(SilverCoin)<para/>
//		/// </summary>
//		public static Craft SilverCoin { get; } = new Craft("SilverCoin", 9016);
//		/// <summary>
//		/// Recipe: 1x(GoldBar) -> 10x(GoldCoin)<para/>
//		/// </summary>
//		public static Craft GoldCoin { get; } = new Craft("GoldCoin", 9017);
//		/// <summary>
//		/// Recipe: 4x(Leather) + 2x(Wool) + 5x(Bone) -> 1x(PetCollar)<para/>
//		/// </summary>
//		public static Craft PetCollar { get; } = new Craft("PetCollar", 9022);
//		/// <summary>
//		/// Recipe: 6x(CopperBar) + 6x(IronBar) + 1x(Tenergy) -> 1x(MecoAlloy)<para/>
//		/// </summary>
//		public static Craft MecoAlloy { get; } = new Craft("MecoAlloy", 9025);
//		/// <summary>
//		/// Recipe: 3x(InsectorExoskeleton) + 3x(Mucus) + 3x(MonsterMeat) + 5x(ParasytorPrimordium) -> 1x(MecoParasectMass)<para/>
//		/// </summary>
//		public static Craft MecoParasectMass0 { get; } = new Craft("MecoParasectMass0", 9026);
//		/// <summary>
//		/// Recipe: 3x(InsectorExoskeleton) + 3x(Mucus) + 3x(RoastedMonsterMeat) + 5x(ParasytorPrimordium) -> 1x(MecoParasectMass)<para/>
//		/// </summary>
//		public static Craft MecoParasectMass1 { get; } = new Craft("MecoParasectMass1", 39026);
//	}
//}
