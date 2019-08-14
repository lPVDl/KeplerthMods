namespace ChassisMod.KeplerthDatabase
{
	public static class CraftGroupDB
	{
		/// <summary>
		/// Crafts: Nectar, Snowball, Gravel, LargeCactus, Snowman<para/>
		/// At: <para/>
		/// </summary>
		public static CraftGroup Handcraft { get; } = new CraftGroup("Handcraft", 1);
		/// <summary>
		/// Crafts: Torch, Torch<para/>
		/// At: CraftTable_1<para/>
		/// </summary>
		public static CraftGroup Torch { get; } = new CraftGroup("Torch", 2);
		/// <summary>
		/// Crafts: Campfire, Campfire<para/>
		/// At: CraftTable_1<para/>
		/// </summary>
		public static CraftGroup Campfire { get; } = new CraftGroup("Campfire", 3);
		/// <summary>
		/// Crafts: String<para/>
		/// At: <para/>
		/// </summary>
		public static CraftGroup String { get; } = new CraftGroup("String", 4);
		/// <summary>
		/// Crafts: Leather<para/>
		/// At: CraftTable_1<para/>
		/// </summary>
		public static CraftGroup Leather { get; } = new CraftGroup("Leather", 5);
		/// <summary>
		/// Crafts: PunjiSticks<para/>
		/// At: CraftTable_1<para/>
		/// </summary>
		public static CraftGroup PunjiSticks { get; } = new CraftGroup("PunjiSticks", 6);
		/// <summary>
		/// Crafts: WoodenSimpleWorkbench, CopperSimpleWorkbench, IronSimpleWorkbench, SilverSimpleWorkbench, GoldenSimpleWorkbench<para/>
		/// At: CraftTable_1, WoodenSimpleWorkbench, StoneSimpleWorkbench, CopperSimpleWorkbench, IronSimpleWorkbench, SilverSimpleWorkbench, GoldenSimpleWorkbench, DiamondSimpleWorkbench, OldWoodProductionDesk, OldStoneProductionPlatform, OldCopperMakingTable, OldIronMakingTable, OldSilverProductionDesk, OldGoldProductionDesk, OldDiamondMakingTable<para/>
		/// </summary>
		public static CraftGroup SimpleWorkbench { get; } = new CraftGroup("SimpleWorkbench", 50);
		/// <summary>
		/// Crafts: StoneStove, CopperStove, IronStove, SilverStove, GoldenStove, DiamondStove<para/>
		/// At: WoodenSimpleWorkbench, StoneSimpleWorkbench, CopperSimpleWorkbench, IronSimpleWorkbench, SilverSimpleWorkbench, GoldenSimpleWorkbench, DiamondSimpleWorkbench, OldWoodProductionDesk, OldStoneProductionPlatform, OldCopperMakingTable, OldIronMakingTable, OldSilverProductionDesk, OldGoldProductionDesk, OldDiamondMakingTable<para/>
		/// </summary>
		public static CraftGroup Stove { get; } = new CraftGroup("Stove", 51);
		/// <summary>
		/// Crafts: Furnace<para/>
		/// At: WoodenSimpleWorkbench, StoneSimpleWorkbench, CopperSimpleWorkbench, IronSimpleWorkbench, SilverSimpleWorkbench, GoldenSimpleWorkbench, DiamondSimpleWorkbench, OldWoodProductionDesk, OldStoneProductionPlatform, OldCopperMakingTable, OldIronMakingTable, OldSilverProductionDesk, OldGoldProductionDesk, OldDiamondMakingTable<para/>
		/// </summary>
		public static CraftGroup Furnace { get; } = new CraftGroup("Furnace", 52);
		/// <summary>
		/// Crafts: CopperAnvil, IronAnvil, SilverAnvil, GoldenAnvil<para/>
		/// At: WoodenSimpleWorkbench, StoneSimpleWorkbench, CopperSimpleWorkbench, IronSimpleWorkbench, SilverSimpleWorkbench, GoldenSimpleWorkbench, DiamondSimpleWorkbench, OldWoodProductionDesk, OldStoneProductionPlatform, OldCopperMakingTable, OldIronMakingTable, OldSilverProductionDesk, OldGoldProductionDesk, OldDiamondMakingTable<para/>
		/// </summary>
		public static CraftGroup Anvil { get; } = new CraftGroup("Anvil", 53);
		/// <summary>
		/// Crafts: WoodenBrewery, StoneBrewery, CopperBrewery, IronBrewery, SilverBrewery, GoldenBrewery, DiamondBrewery<para/>
		/// At: <para/>
		/// </summary>
		public static CraftGroup BrewingBarrel { get; } = new CraftGroup("BrewingBarrel", 54);
		/// <summary>
		/// Crafts: WoodenFurnitureWorkbench, CopperFurnitureWorkbench, IronFurnitureWorkbench, SilverFurnitureWorkbench, GoldenFurnitureWorkbench<para/>
		/// At: WoodenSimpleWorkbench, StoneSimpleWorkbench, CopperSimpleWorkbench, IronSimpleWorkbench, SilverSimpleWorkbench, GoldenSimpleWorkbench, DiamondSimpleWorkbench, OldWoodProductionDesk, OldStoneProductionPlatform, OldCopperMakingTable, OldIronMakingTable, OldSilverProductionDesk, OldGoldProductionDesk, OldDiamondMakingTable<para/>
		/// </summary>
		public static CraftGroup FurnitureBench { get; } = new CraftGroup("FurnitureBench", 55);
		/// <summary>
		/// Crafts: WoodCraftTable, StoneCraft, CopperCraftTable, IronCraftTable, SilverCraftTable, GoldCraftTable<para/>
		/// At: <para/>
		/// </summary>
		public static CraftGroup Masonry { get; } = new CraftGroup("Masonry", 56);
		/// <summary>
		/// Crafts: CopperFirearmWorkbench, IronFirearmWorkbench, SilverFirearmWorkbench, GoldenFirearmWorkbench<para/>
		/// At: WoodenSimpleWorkbench, StoneSimpleWorkbench, CopperSimpleWorkbench, IronSimpleWorkbench, SilverSimpleWorkbench, GoldenSimpleWorkbench, DiamondSimpleWorkbench, OldWoodProductionDesk, OldStoneProductionPlatform, OldCopperMakingTable, OldIronMakingTable, OldSilverProductionDesk, OldGoldProductionDesk, OldDiamondMakingTable<para/>
		/// </summary>
		public static CraftGroup FirearmWorkbench { get; } = new CraftGroup("FirearmWorkbench", 57);
		/// <summary>
		/// Crafts: StoneDigester, CopperBiogasTank, IronDigester, SilverBiogasPool, GoldBiogasPool<para/>
		/// At: <para/>
		/// </summary>
		public static CraftGroup BiogasPool { get; } = new CraftGroup("BiogasPool", 58);
		/// <summary>
		/// Crafts: WoodenFeedingTrough, CopperFeedingTrough, IronFeedingTrough, SilverFeedingTrough, GoldenFeedingTrough<para/>
		/// At: WoodenSimpleWorkbench, StoneSimpleWorkbench, CopperSimpleWorkbench, IronSimpleWorkbench, SilverSimpleWorkbench, GoldenSimpleWorkbench, DiamondSimpleWorkbench, OldWoodProductionDesk, OldStoneProductionPlatform, OldCopperMakingTable, OldIronMakingTable, OldSilverProductionDesk, OldGoldProductionDesk, OldDiamondMakingTable<para/>
		/// </summary>
		public static CraftGroup FeedingTrough { get; } = new CraftGroup("FeedingTrough", 59);
		/// <summary>
		/// Crafts: WoodenDoor, StoneDoor, CopperDoor, IronDoor, SilverDoor, GoldenDoor, SandDoor, IceDoor, SnowDoor, GlassDoor, DirtDoor<para/>
		/// At: WoodenFurnitureBench, StoneFurnitureBench, CopperFurnitureBench, IronFurnitureBench, SilverFurnitureBench, GoldenFurnitureBench, DiamondFurnitureBench<para/>
		/// </summary>
		public static CraftGroup Door { get; } = new CraftGroup("Door", 101);
		/// <summary>
		/// Crafts: WoodWall, DirtWall, StoneWall, CopperWall, IronWall, SilverWall, GoldenWall, DiamondWall, GlassWall, SnowWall, IceWall<para/>
		/// At: WoodenFurnitureBench, StoneFurnitureBench, CopperFurnitureBench, IronFurnitureBench, SilverFurnitureBench, GoldenFurnitureBench, DiamondFurnitureBench<para/>
		/// </summary>
		public static CraftGroup Wall { get; } = new CraftGroup("Wall", 102);
		/// <summary>
		/// Crafts: WoodenFence, CopperFence, IronFence, SilverFence, GoldenFence<para/>
		/// At: WoodenFurnitureBench, StoneFurnitureBench, CopperFurnitureBench, IronFurnitureBench, SilverFurnitureBench, GoldenFurnitureBench, DiamondFurnitureBench<para/>
		/// </summary>
		public static CraftGroup Fence { get; } = new CraftGroup("Fence", 103);
		/// <summary>
		/// Crafts: WoodenRoundTable, StoneRoundTable, CopperRoundTable, IronRoundTable, SilverRoundTable, GoldenRoundTable, DirtRoundTable, SnowRoundTable<para/>
		/// At: WoodenFurnitureBench, StoneFurnitureBench, CopperFurnitureBench, IronFurnitureBench, SilverFurnitureBench, GoldenFurnitureBench, DiamondFurnitureBench<para/>
		/// </summary>
		public static CraftGroup RoundTable { get; } = new CraftGroup("RoundTable", 104);
		/// <summary>
		/// Crafts: WoodenTable, CopperTable, IronTable, SilverTable, GoldenTable<para/>
		/// At: WoodenFurnitureBench, StoneFurnitureBench, CopperFurnitureBench, IronFurnitureBench, SilverFurnitureBench, GoldenFurnitureBench, DiamondFurnitureBench<para/>
		/// </summary>
		public static CraftGroup Table { get; } = new CraftGroup("Table", 105);
		/// <summary>
		/// Crafts: WoodenChair, StoneChair, CopperChair, IronChair, SilverChair, GoldenChair, DirtChair, SnowChair<para/>
		/// At: WoodenFurnitureBench, StoneFurnitureBench, CopperFurnitureBench, IronFurnitureBench, SilverFurnitureBench, GoldenFurnitureBench, DiamondFurnitureBench<para/>
		/// </summary>
		public static CraftGroup Chair { get; } = new CraftGroup("Chair", 106);
		/// <summary>
		/// Crafts: WoodenFloor, DirtFloor, StoneFloor, CopperFloor, IronFloor, SilverFloor, GoldFloor, GlassFloor, SnowFloor, IceFloor, SandFloor<para/>
		/// At: WoodenFurnitureBench, StoneFurnitureBench, CopperFurnitureBench, IronFurnitureBench, SilverFurnitureBench, GoldenFurnitureBench, DiamondFurnitureBench<para/>
		/// </summary>
		public static CraftGroup Floor { get; } = new CraftGroup("Floor", 107);
		/// <summary>
		/// Crafts: WoodenChest, CopperChest, IronChest, SilverChest, GoldenChest<para/>
		/// At: WoodenFurnitureBench, StoneFurnitureBench, CopperFurnitureBench, IronFurnitureBench, SilverFurnitureBench, GoldenFurnitureBench, DiamondFurnitureBench<para/>
		/// </summary>
		public static CraftGroup Chest { get; } = new CraftGroup("Chest", 108);
		/// <summary>
		/// Crafts: WoodenBed, CopperBed, IronBed, SilverBed, GoldenBed<para/>
		/// At: WoodenFurnitureBench, StoneFurnitureBench, CopperFurnitureBench, IronFurnitureBench, SilverFurnitureBench, GoldenFurnitureBench, DiamondFurnitureBench<para/>
		/// </summary>
		public static CraftGroup Bed { get; } = new CraftGroup("Bed", 109);
		/// <summary>
		/// Crafts: WoodenTikiTorch, CopperTikiTorch, IronTikiTorch, SilverTikiTorch, GoldenTikiTorch<para/>
		/// At: WoodenFurnitureBench, StoneFurnitureBench, CopperFurnitureBench, IronFurnitureBench, SilverFurnitureBench, GoldenFurnitureBench, DiamondFurnitureBench<para/>
		/// </summary>
		public static CraftGroup TikiTorch0 { get; } = new CraftGroup("TikiTorch0", 110);
		/// <summary>
		/// Crafts: StoneClub<para/>
		/// At: CraftTable_1<para/>
		/// </summary>
		public static CraftGroup StoneClub { get; } = new CraftGroup("StoneClub", 201);
		/// <summary>
		/// Crafts: StoneClub, CopperSword, IronSword, SilverSword, GoldenSword<para/>
		/// At: CopperAnvil, IronAnvil, SilverAnvil, GoldenAnvil, DiamondAnvil, OldCopperForgingTable, OldIronForgingTable, OldSilverForgingTable, OldGoldForgingTable, OldDiamondForgingTable<para/>
		/// </summary>
		public static CraftGroup Sword { get; } = new CraftGroup("Sword", 202);
		/// <summary>
		/// Crafts: WoodenBow<para/>
		/// At: CraftTable_1<para/>
		/// </summary>
		public static CraftGroup WoodenBow { get; } = new CraftGroup("WoodenBow", 203);
		/// <summary>
		/// Crafts: CopperBow, IronBow, SilverBow, GoldenBow<para/>
		/// At: CopperAnvil, IronAnvil, SilverAnvil, GoldenAnvil, DiamondAnvil, OldCopperForgingTable, OldIronForgingTable, OldSilverForgingTable, OldGoldForgingTable, OldDiamondForgingTable<para/>
		/// </summary>
		public static CraftGroup Bow { get; } = new CraftGroup("Bow", 204);
		/// <summary>
		/// Crafts: WoodenSpear<para/>
		/// At: <para/>
		/// </summary>
		public static CraftGroup WoodenSpear { get; } = new CraftGroup("WoodenSpear", 205);
		/// <summary>
		/// Crafts: CopperSpear, IronSpear, SilverSpear, GoldenSpear<para/>
		/// At: CopperAnvil, IronAnvil, SilverAnvil, GoldenAnvil, DiamondAnvil, OldCopperForgingTable, OldIronForgingTable, OldSilverForgingTable, OldGoldForgingTable, OldDiamondForgingTable<para/>
		/// </summary>
		public static CraftGroup Spear { get; } = new CraftGroup("Spear", 206);
		/// <summary>
		/// Crafts: CopperDagger, IronDagger, SilverDagger, GoldenDagger<para/>
		/// At: CopperAnvil, IronAnvil, SilverAnvil, GoldenAnvil, DiamondAnvil, OldCopperForgingTable, OldIronForgingTable, OldSilverForgingTable, OldGoldForgingTable, OldDiamondForgingTable<para/>
		/// </summary>
		public static CraftGroup Dagger { get; } = new CraftGroup("Dagger", 207);
		/// <summary>
		/// Crafts: StoneAxe<para/>
		/// At: CraftTable_1<para/>
		/// </summary>
		public static CraftGroup StoneAxe { get; } = new CraftGroup("StoneAxe", 208);
		/// <summary>
		/// Crafts: StonePickaxe<para/>
		/// At: CraftTable_1<para/>
		/// </summary>
		public static CraftGroup StonePickaxe { get; } = new CraftGroup("StonePickaxe", 209);
		/// <summary>
		/// Crafts: StoneShovel<para/>
		/// At: <para/>
		/// </summary>
		public static CraftGroup StoneShovel { get; } = new CraftGroup("StoneShovel", 210);
		/// <summary>
		/// Crafts: StoneAxe, CopperAxe, IronAxe, SilverAxe, GoldAxe<para/>
		/// At: CopperAnvil, IronAnvil, SilverAnvil, GoldenAnvil, DiamondAnvil, OldCopperForgingTable, OldIronForgingTable, OldSilverForgingTable, OldGoldForgingTable, OldDiamondForgingTable<para/>
		/// </summary>
		public static CraftGroup Axe { get; } = new CraftGroup("Axe", 211);
		/// <summary>
		/// Crafts: StonePickaxe, CopperPickaxe, IronPickaxe, SilverPickaxe, GoldPickaxe<para/>
		/// At: CopperAnvil, IronAnvil, SilverAnvil, GoldenAnvil, DiamondAnvil, OldCopperForgingTable, OldIronForgingTable, OldSilverForgingTable, OldGoldForgingTable, OldDiamondForgingTable<para/>
		/// </summary>
		public static CraftGroup Pickaxe { get; } = new CraftGroup("Pickaxe", 212);
		/// <summary>
		/// Crafts: CopperShovel, IronShovel, SilverShovel, GoldShovel<para/>
		/// At: CopperAnvil, IronAnvil, SilverAnvil, GoldenAnvil, DiamondAnvil, OldCopperForgingTable, OldIronForgingTable, OldSilverForgingTable, OldGoldForgingTable, OldDiamondForgingTable<para/>
		/// </summary>
		public static CraftGroup Shovel { get; } = new CraftGroup("Shovel", 213);
		/// <summary>
		/// Crafts: StoneArrow, CopperArrow, IronArrow, SilverArrow, GoldenArrow<para/>
		/// At: CopperAnvil, IronAnvil, SilverAnvil, GoldenAnvil, DiamondAnvil, OldCopperForgingTable, OldIronForgingTable, OldSilverForgingTable, OldGoldForgingTable, OldDiamondForgingTable<para/>
		/// </summary>
		public static CraftGroup Arrow { get; } = new CraftGroup("Arrow", 214);
		/// <summary>
		/// Crafts: StoneArrow, CopperArrow, IronArrow, SilverArrow, GoldenArrow<para/>
		/// At: CraftTable_1<para/>
		/// </summary>
		public static CraftGroup StoneArrow { get; } = new CraftGroup("StoneArrow", 215);
		/// <summary>
		/// Crafts: CopperArmor, IronArmor, SilverArmor, GoldenPlate<para/>
		/// At: CopperAnvil, IronAnvil, SilverAnvil, GoldenAnvil, DiamondAnvil, OldCopperForgingTable, OldIronForgingTable, OldSilverForgingTable, OldGoldForgingTable, OldDiamondForgingTable<para/>
		/// </summary>
		public static CraftGroup Armor { get; } = new CraftGroup("Armor", 301);
		/// <summary>
		/// Crafts: CopperGloves, IronGloves, SilverGloves, GoldenGloves<para/>
		/// At: CopperAnvil, IronAnvil, SilverAnvil, GoldenAnvil, DiamondAnvil, OldCopperForgingTable, OldIronForgingTable, OldSilverForgingTable, OldGoldForgingTable, OldDiamondForgingTable<para/>
		/// </summary>
		public static CraftGroup Gloves { get; } = new CraftGroup("Gloves", 302);
		/// <summary>
		/// Crafts: CopperShoes, IronShoes, SilverShoes, GoldenShoes<para/>
		/// At: CopperAnvil, IronAnvil, SilverAnvil, GoldenAnvil, DiamondAnvil, OldCopperForgingTable, OldIronForgingTable, OldSilverForgingTable, OldGoldForgingTable, OldDiamondForgingTable<para/>
		/// </summary>
		public static CraftGroup Shoes { get; } = new CraftGroup("Shoes", 303);
		/// <summary>
		/// Crafts: WoodenArmor<para/>
		/// At: CraftTable_1<para/>
		/// </summary>
		public static CraftGroup WoodenArmor { get; } = new CraftGroup("WoodenArmor", 304);
		/// <summary>
		/// Crafts: LeatherArmor<para/>
		/// At: CraftTable_1<para/>
		/// </summary>
		public static CraftGroup LeatherArmor { get; } = new CraftGroup("LeatherArmor", 305);
		/// <summary>
		/// Crafts: LeatherGloves<para/>
		/// At: CraftTable_1<para/>
		/// </summary>
		public static CraftGroup LeatherGloves { get; } = new CraftGroup("LeatherGloves", 306);
		/// <summary>
		/// Crafts: LeatherShoes<para/>
		/// At: CraftTable_1<para/>
		/// </summary>
		public static CraftGroup LeatherShoes { get; } = new CraftGroup("LeatherShoes", 307);
		/// <summary>
		/// Crafts: SilverCoin, GoldCoin<para/>
		/// At: <para/>
		/// </summary>
		public static CraftGroup Coin { get; } = new CraftGroup("Coin", 399);
		/// <summary>
		/// Crafts: Clay<para/>
		/// At: Exo, StoneCraft, CopperCraftTable, IronCraftTable, SilverCraftTable, GoldCraftTable, DiamondCraftTable, OldWoodCraftBench, OldStoneCraft, OldCopperCraftTable, OldIronCraftTable, OldSilverCraftTable, OldGoldCraft, OldDiamondCraftTable<para/>
		/// </summary>
		public static CraftGroup Clay { get; } = new CraftGroup("Clay", 401);
		/// <summary>
		/// Crafts: ClayFlowerPot, GlassFlowerPot, FlowerPot<para/>
		/// At: Exo, StoneCraft, CopperCraftTable, IronCraftTable, SilverCraftTable, GoldCraftTable, DiamondCraftTable, OldWoodCraftBench, OldStoneCraft, OldCopperCraftTable, OldIronCraftTable, OldSilverCraftTable, OldGoldCraft, OldDiamondCraftTable<para/>
		/// </summary>
		public static CraftGroup FlowerPot { get; } = new CraftGroup("FlowerPot", 402);
		/// <summary>
		/// Crafts: ClayBottle, GlassBottle, Jar<para/>
		/// At: Exo, StoneCraft, CopperCraftTable, IronCraftTable, SilverCraftTable, GoldCraftTable, DiamondCraftTable, OldWoodCraftBench, OldStoneCraft, OldCopperCraftTable, OldIronCraftTable, OldSilverCraftTable, OldGoldCraft, OldDiamondCraftTable<para/>
		/// </summary>
		public static CraftGroup Bottle { get; } = new CraftGroup("Bottle", 403);
		/// <summary>
		/// Crafts: ClayJar, GlassJar, Bottle<para/>
		/// At: Exo, StoneCraft, CopperCraftTable, IronCraftTable, SilverCraftTable, GoldCraftTable, DiamondCraftTable, OldWoodCraftBench, OldStoneCraft, OldCopperCraftTable, OldIronCraftTable, OldSilverCraftTable, OldGoldCraft, OldDiamondCraftTable<para/>
		/// </summary>
		public static CraftGroup Jar { get; } = new CraftGroup("Jar", 404);
		/// <summary>
		/// Crafts: CeramicFlowerPot, CeramicBottle, Sculpture<para/>
		/// At: Exo, StoneCraft, CopperCraftTable, IronCraftTable, SilverCraftTable, GoldCraftTable, DiamondCraftTable, OldWoodCraftBench, OldStoneCraft, OldCopperCraftTable, OldIronCraftTable, OldSilverCraftTable, OldGoldCraft, OldDiamondCraftTable<para/>
		/// </summary>
		public static CraftGroup Sculpture { get; } = new CraftGroup("Sculpture", 405);
		/// <summary>
		/// Crafts: WoodenModel<para/>
		/// At: WoodenFurnitureBench, StoneFurnitureBench, CopperFurnitureBench, IronFurnitureBench, SilverFurnitureBench, GoldenFurnitureBench, DiamondFurnitureBench<para/>
		/// </summary>
		public static CraftGroup WoodenModel { get; } = new CraftGroup("WoodenModel", 406);
		/// <summary>
		/// Crafts: TargetDummy<para/>
		/// At: WoodenFurnitureBench, StoneFurnitureBench, CopperFurnitureBench, IronFurnitureBench, SilverFurnitureBench, GoldenFurnitureBench, DiamondFurnitureBench<para/>
		/// </summary>
		public static CraftGroup TargetDummy { get; } = new CraftGroup("TargetDummy", 407);
		/// <summary>
		/// Crafts: SaltpeterOre<para/>
		/// At: FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, OldWoodGunpowderProcessingStation, OldStoneGunpowderProcessingStation, OldCopperPowderProcessingStation, OldIronPowderProcessingStation, OldSilverPowderProcessingStation, OldGoldPowderProcessingStation, OldDiamondGunpowderProcessingStation<para/>
		/// </summary>
		public static CraftGroup MakingSaltpeter { get; } = new CraftGroup("MakingSaltpeter", 501);
		/// <summary>
		/// Crafts: Gunpowder<para/>
		/// At: FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, OldWoodGunpowderProcessingStation, OldStoneGunpowderProcessingStation, OldCopperPowderProcessingStation, OldIronPowderProcessingStation, OldSilverPowderProcessingStation, OldGoldPowderProcessingStation, OldDiamondGunpowderProcessingStation<para/>
		/// </summary>
		public static CraftGroup Gunpowder0 { get; } = new CraftGroup("Gunpowder0", 502);
		/// <summary>
		/// Crafts: CopperMusket, IronMusket, SilverMusket, GoldenMusket<para/>
		/// At: FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, OldWoodGunpowderProcessingStation, OldStoneGunpowderProcessingStation, OldCopperPowderProcessingStation, OldIronPowderProcessingStation, OldSilverPowderProcessingStation, OldGoldPowderProcessingStation, OldDiamondGunpowderProcessingStation<para/>
		/// </summary>
		public static CraftGroup Musket { get; } = new CraftGroup("Musket", 503);
		/// <summary>
		/// Crafts: CopperShotgun, IronShotgun, SilverShotgun, GoldenShotgun<para/>
		/// At: FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, OldWoodGunpowderProcessingStation, OldStoneGunpowderProcessingStation, OldCopperPowderProcessingStation, OldIronPowderProcessingStation, OldSilverPowderProcessingStation, OldGoldPowderProcessingStation, OldDiamondGunpowderProcessingStation<para/>
		/// </summary>
		public static CraftGroup Shotgun { get; } = new CraftGroup("Shotgun", 504);
		/// <summary>
		/// Crafts: CopperBullet, IronBullet, SilverBullet, GoldenBullet<para/>
		/// At: FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, OldWoodGunpowderProcessingStation, OldStoneGunpowderProcessingStation, OldCopperPowderProcessingStation, OldIronPowderProcessingStation, OldSilverPowderProcessingStation, OldGoldPowderProcessingStation, OldDiamondGunpowderProcessingStation<para/>
		/// </summary>
		public static CraftGroup Bullet { get; } = new CraftGroup("Bullet", 505);
		/// <summary>
		/// Crafts: ExplosiveStoneArrow, ExplosiveCopperArrow, ExplosiveIronArrow, ExplosiveSilverArrow, ExplosiveGoldenArrow<para/>
		/// At: FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, OldWoodGunpowderProcessingStation, OldStoneGunpowderProcessingStation, OldCopperPowderProcessingStation, OldIronPowderProcessingStation, OldSilverPowderProcessingStation, OldGoldPowderProcessingStation, OldDiamondGunpowderProcessingStation<para/>
		/// </summary>
		public static CraftGroup ExplosiveArrow { get; } = new CraftGroup("ExplosiveArrow", 506);
		/// <summary>
		/// Crafts: ExplosiveBarrel<para/>
		/// At: FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, FirearmWorkbench, OldWoodGunpowderProcessingStation, OldStoneGunpowderProcessingStation, OldCopperPowderProcessingStation, OldIronPowderProcessingStation, OldSilverPowderProcessingStation, OldGoldPowderProcessingStation, OldDiamondGunpowderProcessingStation<para/>
		/// </summary>
		public static CraftGroup ExplosiveBarrel { get; } = new CraftGroup("ExplosiveBarrel", 507);
		/// <summary>
		/// Crafts: Bone, Bone, Bone, Bone, Bone, Bone, Bone, Bone, Bone, Bone, Bone, Bone, Bone<para/>
		/// At: GoblinWorkbench, BloodStainedGoblinProcessingStation<para/>
		/// </summary>
		public static CraftGroup DismantlingBones { get; } = new CraftGroup("DismantlingBones", 601);
		/// <summary>
		/// Crafts: GoblinWorkbench<para/>
		/// At: <para/>
		/// </summary>
		public static CraftGroup GoblinWorkbench { get; } = new CraftGroup("GoblinWorkbench", 602);
		/// <summary>
		/// Crafts: BoneCage<para/>
		/// At: GoblinWorkbench, BloodStainedGoblinProcessingStation<para/>
		/// </summary>
		public static CraftGroup BoneCage { get; } = new CraftGroup("BoneCage", 603);
		/// <summary>
		/// Crafts: PetCollar<para/>
		/// At: GoblinWorkbench, BloodStainedGoblinProcessingStation<para/>
		/// </summary>
		public static CraftGroup PetCollar { get; } = new CraftGroup("PetCollar", 604);
		/// <summary>
		/// Crafts: GoblinBoneBow<para/>
		/// At: GoblinWorkbench, BloodStainedGoblinProcessingStation<para/>
		/// </summary>
		public static CraftGroup BoneBow { get; } = new CraftGroup("BoneBow", 605);
		/// <summary>
		/// Crafts: GoblinBoneDagger<para/>
		/// At: GoblinWorkbench, BloodStainedGoblinProcessingStation<para/>
		/// </summary>
		public static CraftGroup BoneDagger { get; } = new CraftGroup("BoneDagger", 606);
		/// <summary>
		/// Crafts: GoblinBoneSword<para/>
		/// At: GoblinWorkbench, BloodStainedGoblinProcessingStation<para/>
		/// </summary>
		public static CraftGroup BoneSword { get; } = new CraftGroup("BoneSword", 607);
		/// <summary>
		/// Crafts: BonyBall<para/>
		/// At: GoblinWorkbench, BloodStainedGoblinProcessingStation<para/>
		/// </summary>
		public static CraftGroup BonyBall { get; } = new CraftGroup("BonyBall", 608);
		/// <summary>
		/// Crafts: GoblinSteelArmor<para/>
		/// At: GoblinWorkbench, BloodStainedGoblinProcessingStation<para/>
		/// </summary>
		public static CraftGroup SteelArmor { get; } = new CraftGroup("SteelArmor", 609);
		/// <summary>
		/// Crafts: GoblinBearTrap<para/>
		/// At: GoblinWorkbench, BloodStainedGoblinProcessingStation<para/>
		/// </summary>
		public static CraftGroup GobinBearTrap { get; } = new CraftGroup("GobinBearTrap", 610);
		/// <summary>
		/// Crafts: BoneDoor<para/>
		/// At: GoblinWorkbench, BloodStainedGoblinProcessingStation<para/>
		/// </summary>
		public static CraftGroup BoneDoor { get; } = new CraftGroup("BoneDoor", 611);
		/// <summary>
		/// Crafts: BoneWall<para/>
		/// At: GoblinWorkbench, BloodStainedGoblinProcessingStation<para/>
		/// </summary>
		public static CraftGroup BoneWall { get; } = new CraftGroup("BoneWall", 612);
		/// <summary>
		/// Crafts: BoneFence<para/>
		/// At: GoblinWorkbench, BloodStainedGoblinProcessingStation<para/>
		/// </summary>
		public static CraftGroup BoneFence { get; } = new CraftGroup("BoneFence", 613);
		/// <summary>
		/// Crafts: BoneRoundTable<para/>
		/// At: GoblinWorkbench, BloodStainedGoblinProcessingStation<para/>
		/// </summary>
		public static CraftGroup BoneRoundTable { get; } = new CraftGroup("BoneRoundTable", 614);
		/// <summary>
		/// Crafts: BoneChair<para/>
		/// At: GoblinWorkbench, BloodStainedGoblinProcessingStation<para/>
		/// </summary>
		public static CraftGroup BoneChair { get; } = new CraftGroup("BoneChair", 615);
		/// <summary>
		/// Crafts: BoneChest<para/>
		/// At: GoblinWorkbench, BloodStainedGoblinProcessingStation<para/>
		/// </summary>
		public static CraftGroup BoneChest { get; } = new CraftGroup("BoneChest", 616);
		/// <summary>
		/// Crafts: BoneFlowerPot<para/>
		/// At: GoblinWorkbench, BloodStainedGoblinProcessingStation<para/>
		/// </summary>
		public static CraftGroup BoneFlowerPot { get; } = new CraftGroup("BoneFlowerPot", 617);
		/// <summary>
		/// Crafts: GoblinBed<para/>
		/// At: GoblinWorkbench, BloodStainedGoblinProcessingStation<para/>
		/// </summary>
		public static CraftGroup BoneBed { get; } = new CraftGroup("BoneBed", 618);
		/// <summary>
		/// Crafts: GoblinTikiTorch<para/>
		/// At: GoblinWorkbench, BloodStainedGoblinProcessingStation<para/>
		/// </summary>
		public static CraftGroup TikiTorch1 { get; } = new CraftGroup("TikiTorch1", 619);
		/// <summary>
		/// Crafts: FusionPool<para/>
		/// At: <para/>
		/// </summary>
		public static CraftGroup FusionPool { get; } = new CraftGroup("FusionPool", 701);
		/// <summary>
		/// Crafts: ParasectOutfit<para/>
		/// At: WormFusionPool<para/>
		/// </summary>
		public static CraftGroup ParasectOutfit { get; } = new CraftGroup("ParasectOutfit", 702);
		/// <summary>
		/// Crafts: ParasectGloves<para/>
		/// At: WormFusionPool<para/>
		/// </summary>
		public static CraftGroup ParasectGloves { get; } = new CraftGroup("ParasectGloves", 703);
		/// <summary>
		/// Crafts: ParasectShoes<para/>
		/// At: WormFusionPool<para/>
		/// </summary>
		public static CraftGroup ParasectShoes { get; } = new CraftGroup("ParasectShoes", 704);
		/// <summary>
		/// Crafts: ParasectSickle<para/>
		/// At: WormFusionPool<para/>
		/// </summary>
		public static CraftGroup ParasectSickle { get; } = new CraftGroup("ParasectSickle", 705);
		/// <summary>
		/// Crafts: ParasectSpear<para/>
		/// At: WormFusionPool<para/>
		/// </summary>
		public static CraftGroup ParasectSpear { get; } = new CraftGroup("ParasectSpear", 706);
		/// <summary>
		/// Crafts: ParasytorPox<para/>
		/// At: WormFusionPool<para/>
		/// </summary>
		public static CraftGroup ParasytorPox { get; } = new CraftGroup("ParasytorPox", 707);
		/// <summary>
		/// Crafts: ParasectPlasmaGun<para/>
		/// At: WormFusionPool<para/>
		/// </summary>
		public static CraftGroup ParasectPlasmaGun { get; } = new CraftGroup("ParasectPlasmaGun", 708);
		/// <summary>
		/// Crafts: InsectorDrill<para/>
		/// At: WormFusionPool<para/>
		/// </summary>
		public static CraftGroup InsectorDrill { get; } = new CraftGroup("InsectorDrill", 709);
		/// <summary>
		/// Crafts: PoisonousSacTrap<para/>
		/// At: WormFusionPool<para/>
		/// </summary>
		public static CraftGroup PoisonousSacTrap { get; } = new CraftGroup("PoisonousSacTrap", 710);
		/// <summary>
		/// Crafts: InsectorNidus<para/>
		/// At: WormFusionPool<para/>
		/// </summary>
		public static CraftGroup InsectorNidus { get; } = new CraftGroup("InsectorNidus", 711);
		/// <summary>
		/// Crafts: InsectorEye<para/>
		/// At: WormFusionPool<para/>
		/// </summary>
		public static CraftGroup InsectorEye { get; } = new CraftGroup("InsectorEye", 712);
		/// <summary>
		/// Crafts: PlatingPool<para/>
		/// At: <para/>
		/// </summary>
		public static CraftGroup PlatingPool { get; } = new CraftGroup("PlatingPool", 713);
		/// <summary>
		/// Crafts: InsectorWall<para/>
		/// At: WormFusionPool<para/>
		/// </summary>
		public static CraftGroup InsectorWall { get; } = new CraftGroup("InsectorWall", 714);
		/// <summary>
		/// Crafts: InsectorHaworth<para/>
		/// At: WormFusionPool<para/>
		/// </summary>
		public static CraftGroup InsectorHaworth { get; } = new CraftGroup("InsectorHaworth", 715);
		/// <summary>
		/// Crafts: InsectorNest<para/>
		/// At: WormFusionPool<para/>
		/// </summary>
		public static CraftGroup InsectorNest { get; } = new CraftGroup("InsectorNest", 716);
		/// <summary>
		/// Crafts: MonsterMeat, MonsterMeat, MonsterMeat, MonsterMeat, MonsterMeat, MonsterMeat<para/>
		/// At: WormFusionPool<para/>
		/// </summary>
		public static CraftGroup MonsterMeat { get; } = new CraftGroup("MonsterMeat", 717);
		/// <summary>
		/// Crafts: PheromonesChicken, PheromonesGoat, PheromonesPig, PheromonesCow, PheromonesHorse, PheromonesChicken, PheromonesGoat, PheromonesPig, PheromonesCow, PheromonesHorse<para/>
		/// At: WormFusionPool<para/>
		/// </summary>
		public static CraftGroup Pheromones { get; } = new CraftGroup("Pheromones", 718);
		/// <summary>
		/// Crafts: CopperInsectorHarvester, IronInsectorHarvester, SilverInsectorHarvester, GoldenInsectorHarvester<para/>
		/// At: WormFusionPool<para/>
		/// </summary>
		public static CraftGroup InsectorHarvester { get; } = new CraftGroup("InsectorHarvester", 719);
		/// <summary>
		/// Crafts: ParasytorSeed<para/>
		/// At: WormFusionPool<para/>
		/// </summary>
		public static CraftGroup ParasytorSeed { get; } = new CraftGroup("ParasytorSeed", 720);
		/// <summary>
		/// Crafts: Tenergy, Tenergy, Tenergy<para/>
		/// At: MecoTFurnace, MecoTFurnace<para/>
		/// </summary>
		public static CraftGroup Tenergy { get; } = new CraftGroup("Tenergy", 801);
		/// <summary>
		/// Crafts: MecoAlloy<para/>
		/// At: MecoTFurnace, MecoTFurnace<para/>
		/// </summary>
		public static CraftGroup MecoAlloy { get; } = new CraftGroup("MecoAlloy", 802);
		/// <summary>
		/// Crafts: MecoParasectMass, MecoParasectMass<para/>
		/// At: MecoTFurnace, MecoTFurnace<para/>
		/// </summary>
		public static CraftGroup MecoParasectMass { get; } = new CraftGroup("MecoParasectMass", 803);
		/// <summary>
		/// Crafts: MecoBiotechBullet<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup MecoBiotechBullet { get; } = new CraftGroup("MecoBiotechBullet", 901);
		/// <summary>
		/// Crafts: MecoP7B<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup MecoP7B { get; } = new CraftGroup("MecoP7B", 902);
		/// <summary>
		/// Crafts: MecoLP8B<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup MecoLP8B { get; } = new CraftGroup("MecoLP8B", 903);
		/// <summary>
		/// Crafts: MecoLG6B<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup MecoLG6B { get; } = new CraftGroup("MecoLG6B", 904);
		/// <summary>
		/// Crafts: MecoParasectArmor<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup MecoParasectArmor { get; } = new CraftGroup("MecoParasectArmor", 905);
		/// <summary>
		/// Crafts: MecoParasectGloves<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup MecoParasectGloves { get; } = new CraftGroup("MecoParasectGloves", 906);
		/// <summary>
		/// Crafts: MecoParasectShoes<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup MecoParasectShoes { get; } = new CraftGroup("MecoParasectShoes", 907);
		/// <summary>
		/// Crafts: ATKCapsule<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup ATKCapsule { get; } = new CraftGroup("ATKCapsule", 908);
		/// <summary>
		/// Crafts: DEFCapsule<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup DEFCapsule { get; } = new CraftGroup("DEFCapsule", 909);
		/// <summary>
		/// Crafts: AGLPotion<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup AGLPotion { get; } = new CraftGroup("AGLPotion", 910);
		/// <summary>
		/// Crafts: MecoJoyfulIII<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup MecoJoyful { get; } = new CraftGroup("MecoJoyful", 911);
		/// <summary>
		/// Crafts: NanoCapsule<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup NanoCapsule { get; } = new CraftGroup("NanoCapsule", 912);
		/// <summary>
		/// Crafts: StimulantsI<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup Stimulants { get; } = new CraftGroup("Stimulants", 913);
		/// <summary>
		/// Crafts: StimulantsII, StimulantsIII, ATKCapsule, ATKCapsule, ATKCapsuleExtra, ATKCapsuleExtraAdvance, DEFCapsule, DEFCapsule, DEFCapsuleExtra, DEFCapsuleExtraAdvance, AGLPotion, AGLPotion, AGLPotionExtra, AGLPotionExtraAdvance, MecoJoyfulIII, MecoJoyfulIII, MecoJoyfulIV, MecoJoyfulV<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup DrugTPurification { get; } = new CraftGroup("DrugTPurification", 914);
		/// <summary>
		/// Crafts: MecoTFurnace<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup MecoTFurnace { get; } = new CraftGroup("MecoTFurnace", 915);
		/// <summary>
		/// Crafts: Gunpowder<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup Gunpowder1 { get; } = new CraftGroup("Gunpowder1", 1001);
		/// <summary>
		/// Crafts: GrounderSamuraiSword<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup GrounderSamuraiSword { get; } = new CraftGroup("GrounderSamuraiSword", 1002);
		/// <summary>
		/// Crafts: GrounderDagger<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup GrounderDagger { get; } = new CraftGroup("GrounderDagger", 1003);
		/// <summary>
		/// Crafts: GrounderSniperRifle<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup GrounderSniperRifle { get; } = new CraftGroup("GrounderSniperRifle", 1004);
		/// <summary>
		/// Crafts: GrounderAssaultRifle<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup GrounderAssaultRifle { get; } = new CraftGroup("GrounderAssaultRifle", 1005);
		/// <summary>
		/// Crafts: GrounderGrenade<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup GrounderGrenade { get; } = new CraftGroup("GrounderGrenade", 1006);
		/// <summary>
		/// Crafts: GrounderAntiMecoArmor, GrounderAntiMecoArmor, GrounderAntiMecoArmor, GrounderAntiMecoArmor<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup GrounderAntiMecoArmor { get; } = new CraftGroup("GrounderAntiMecoArmor", 1007);
		/// <summary>
		/// Crafts: GrenaderGloves<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup GrenaderGloves { get; } = new CraftGroup("GrenaderGloves", 1008);
		/// <summary>
		/// Crafts: GrounderShoes<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup GrounderShoes { get; } = new CraftGroup("GrounderShoes", 1009);
		/// <summary>
		/// Crafts: GrounderLandmine<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup GrounderLandmine { get; } = new CraftGroup("GrounderLandmine", 1010);
		/// <summary>
		/// Crafts: GrounderTent<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup GrounderTent { get; } = new CraftGroup("GrounderTent", 1011);
		/// <summary>
		/// Crafts: TwoSeaterSofa<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup TwoSeaterSofa { get; } = new CraftGroup("TwoSeaterSofa", 1012);
		/// <summary>
		/// Crafts: SingleSeaterSofa<para/>
		/// At: MecoBiotechFoundry<para/>
		/// </summary>
		public static CraftGroup SingleSeaterSofa { get; } = new CraftGroup("SingleSeaterSofa", 1013);
		/// <summary>
		/// Crafts: MinerSimpleLift<para/>
		/// At: CraftTable_2<para/>
		/// </summary>
		public static CraftGroup MinerSimpleLift { get; } = new CraftGroup("MinerSimpleLift", 3001);
	}
}
