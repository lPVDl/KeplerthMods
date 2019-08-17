//namespace ChassisMod
//{
//	public static class ItemDB
//	{
//		/// <summary>
//		/// Name: "Error Item"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 0<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 0<para/>
//		/// AttWall: 0<para/>
//		/// AttBuild: 0<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		///// DropTexture: "Icon/error-item"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ErrorItem { get; } = new Item() { ID = -99, Name = "ErrorItem", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Bud"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 24<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Bud { get; } = new Item() { ID = 501, Name = "Bud", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Scarlet flower"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 24<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ScarletFlower { get; } = new Item() { ID = 503, Name = "ScarletFlower", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Luminous grass"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 24<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item LuminousGrass { get; } = new Item() { ID = 504, Name = "LuminousGrass", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Pearl leaf"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 24<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item PearlLeaf { get; } = new Item() { ID = 505, Name = "PearlLeaf", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Mint"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 24<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Mint { get; } = new Item() { ID = 506, Name = "Mint", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Bezoar"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 24<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Bezoar { get; } = new Item() { ID = 507, Name = "Bezoar", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 100<para/>
//		/// BurnTime: 15<para/>
//		/// DropTexture: "Icon/armor-wood-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenArmor { get; } = new Item() { ID = 2001, Name = "WoodenArmor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Leather Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 21<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 250<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-leather-01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item LeatherArmor { get; } = new Item() { ID = 2002, Name = "LeatherArmor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 42<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 400<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-copper-01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9011, 2 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperArmor { get; } = new Item() { ID = 2003, Name = "CopperArmor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 65<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 450<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-iron-01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 2 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronArmor { get; } = new Item() { ID = 2004, Name = "IronArmor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 108<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-silver-01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 2 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverArmor { get; } = new Item() { ID = 2005, Name = "SilverArmor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Golden Plate"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 180<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-gold-01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 2 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldenPlate { get; } = new Item() { ID = 2006, Name = "GoldenPlate", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Diamond Plate"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 1000<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DiamondPlate { get; } = new Item() { ID = 2007, Name = "DiamondPlate", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Assassin Leather Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 32<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 250<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-goblin01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item AssassinLeatherArmor { get; } = new Item() { ID = 2008, Name = "AssassinLeatherArmor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Scale Armour"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 32<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 250<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-goblin02-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ScaleArmour { get; } = new Item() { ID = 2009, Name = "ScaleArmour", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Warrior Leather Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 24<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 220<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-goblin09-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WarriorLeatherArmor { get; } = new Item() { ID = 2010, Name = "WarriorLeatherArmor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Archer Leather Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 24<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 220<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-goblin06-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ArcherLeatherArmor { get; } = new Item() { ID = 2011, Name = "ArcherLeatherArmor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Warrior Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 12<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 200<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-goblin08-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WarriorOutfit { get; } = new Item() { ID = 2012, Name = "WarriorOutfit", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Archer Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 12<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 200<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-goblin05-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ArcherOutfit { get; } = new Item() { ID = 2013, Name = "ArcherOutfit", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Basic Goblin Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 6<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 150<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-goblin07-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BasicGoblinOutfit0 { get; } = new Item() { ID = 2014, Name = "BasicGoblinOutfit0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Basic Goblin Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 6<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 150<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-goblin04-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BasicGoblinOutfit1 { get; } = new Item() { ID = 2015, Name = "BasicGoblinOutfit1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 6<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 150<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-goblin10-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinOutfit0 { get; } = new Item() { ID = 2016, Name = "GoblinOutfit0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 6<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 150<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-goblin11-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinOutfit1 { get; } = new Item() { ID = 2017, Name = "GoblinOutfit1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin Plate"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 48<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 300<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-goblin12-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinPlate0 { get; } = new Item() { ID = 2018, Name = "GoblinPlate0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin Lightweight Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 48<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 300<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-goblin13-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinLightweightArmor0 { get; } = new Item() { ID = 2019, Name = "GoblinLightweightArmor0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Battle Rhino"<para/>
//		/// Description: "A new type of armor that is made by Meco company for their soldiers."<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 400<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-titanium-01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoBattleRhino { get; } = new Item() { ID = 2020, Name = "MecoBattleRhino", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin Steel Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 66<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 350<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-goblin03-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 2 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinSteelArmor { get; } = new Item() { ID = 2021, Name = "GoblinSteelArmor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin Plate"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 48<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 300<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-goblin12-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinPlate1 { get; } = new Item() { ID = 2024, Name = "GoblinPlate1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin Lightweight Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 48<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 300<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-goblin13-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinLightweightArmor1 { get; } = new Item() { ID = 2025, Name = "GoblinLightweightArmor1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Parasect Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 87<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 450<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-28-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ParasectOutfit { get; } = new Item() { ID = 2026, Name = "ParasectOutfit", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Parasect Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 273<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/MecoBiology-1-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoParasectArmor { get; } = new Item() { ID = 2027, Name = "MecoParasectArmor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Infected biological armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/MecoBiology-1-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InfectedBiologicalArmor { get; } = new Item() { ID = 2028, Name = "InfectedBiologicalArmor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Divil's Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 320<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-33-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DivilsOutfit { get; } = new Item() { ID = 2029, Name = "DivilsOutfit", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "V's Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 320<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-36-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item VsOutfit { get; } = new Item() { ID = 2030, Name = "VsOutfit", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Matthew Schipper's costume"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 320<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-315-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MatthewSchippersCostume { get; } = new Item() { ID = 2031, Name = "MatthewSchippersCostume", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Danny's costume"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 320<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-314-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DannysCostume { get; } = new Item() { ID = 2032, Name = "DannysCostume", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Grounder Lightweight Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 108<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-grounder01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 2 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GrounderLightweightOutfit0 { get; } = new Item() { ID = 2033, Name = "GrounderLightweightOutfit0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Grounder Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 108<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-grounder02-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 2 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GrounderOutfit0 { get; } = new Item() { ID = 2034, Name = "GrounderOutfit0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Grounder Combat Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 129<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-grounder03-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 2 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GrounderCombatOutfit0 { get; } = new Item() { ID = 2035, Name = "GrounderCombatOutfit0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Grounder Hunter Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 129<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-grounder04-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 2 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GrounderHunterOutfit0 { get; } = new Item() { ID = 2036, Name = "GrounderHunterOutfit0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Grounder Anti-Meco Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 150<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-grounder05-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 2 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GrounderAntiMecoArmor0 { get; } = new Item() { ID = 2037, Name = "GrounderAntiMecoArmor0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Grounder Anti-Meco Plate"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 176<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-grounder06-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 2 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GrounderAntiMecoPlate0 { get; } = new Item() { ID = 2038, Name = "GrounderAntiMecoPlate0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Grounder Lightweight Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 176<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GrounderLightweightOutfit1 { get; } = new Item() { ID = 2039, Name = "GrounderLightweightOutfit1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Grounder Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 176<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GrounderOutfit1 { get; } = new Item() { ID = 2040, Name = "GrounderOutfit1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Grounder Combat Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 176<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GrounderCombatOutfit1 { get; } = new Item() { ID = 2041, Name = "GrounderCombatOutfit1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Grounder Hunter Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 176<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GrounderHunterOutfit1 { get; } = new Item() { ID = 2042, Name = "GrounderHunterOutfit1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Grounder Anti-Meco Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 176<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GrounderAntiMecoArmor1 { get; } = new Item() { ID = 2043, Name = "GrounderAntiMecoArmor1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Grounder Anti-Meco Plate"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 176<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GrounderAntiMecoPlate1 { get; } = new Item() { ID = 2044, Name = "GrounderAntiMecoPlate1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Papa Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 2000<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-313-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item PapaArmor { get; } = new Item() { ID = 2099, Name = "PapaArmor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Gloves"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 17<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 100<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenGloves { get; } = new Item() { ID = 2101, Name = "WoodenGloves", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Leather Gloves"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 17<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 14<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 250<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/gloves-leather-01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item LeatherGloves { get; } = new Item() { ID = 2102, Name = "LeatherGloves", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Gloves"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 17<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 29<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 400<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/gloves-copper-01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9011, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperGloves { get; } = new Item() { ID = 2103, Name = "CopperGloves", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Gloves"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 17<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 47<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 450<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/gloves-iron-01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronGloves { get; } = new Item() { ID = 2104, Name = "IronGloves", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Gloves"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 17<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 79<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/gloves-silver-01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverGloves { get; } = new Item() { ID = 2105, Name = "SilverGloves", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Golden Gloves"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 17<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 133<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/gloves-gold-01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldenGloves { get; } = new Item() { ID = 2106, Name = "GoldenGloves", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Diamond Gloves"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 17<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 100<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DiamondGloves { get; } = new Item() { ID = 2107, Name = "DiamondGloves", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Parasect Gloves"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 17<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 66<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 450<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/gloves-28-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ParasectGloves { get; } = new Item() { ID = 2108, Name = "ParasectGloves", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Parasect Gloves"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 17<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 198<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/gloves-MecoBiology1-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoParasectGloves { get; } = new Item() { ID = 2109, Name = "MecoParasectGloves", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Grenader Gloves"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 17<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 97<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/gloves-grounder-01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GrenaderGloves { get; } = new Item() { ID = 2110, Name = "GrenaderGloves", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Shoes"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 18<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 100<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenShoes { get; } = new Item() { ID = 2201, Name = "WoodenShoes", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Leather Shoes"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 18<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 14<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 250<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/shoes-leather-01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item LeatherShoes { get; } = new Item() { ID = 2202, Name = "LeatherShoes", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Shoes"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 18<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 29<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 400<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/shoes-copper-01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9011, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperShoes { get; } = new Item() { ID = 2203, Name = "CopperShoes", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Shoes"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 18<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 47<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 450<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/shoes-iron-01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronShoes { get; } = new Item() { ID = 2204, Name = "IronShoes", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Shoes"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 18<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 79<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/shoes-silver-01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverShoes { get; } = new Item() { ID = 2205, Name = "SilverShoes", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Golden Shoes"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 18<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 133<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/shoes-gold-01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldenShoes { get; } = new Item() { ID = 2206, Name = "GoldenShoes", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Diamond Shoes"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 18<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 100<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DiamondShoes { get; } = new Item() { ID = 2207, Name = "DiamondShoes", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Parasect Shoes"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 18<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 66<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 450<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/shoes-28-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ParasectShoes { get; } = new Item() { ID = 2208, Name = "ParasectShoes", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Parasect Shoes"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 18<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 198<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/shoes-MecoBiology1-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoParasectShoes { get; } = new Item() { ID = 2209, Name = "MecoParasectShoes", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Grounder Shoes"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 18<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 97<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/shoes-grounder-01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GrounderShoes { get; } = new Item() { ID = 2210, Name = "GrounderShoes", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin King's Necklace"<para/>
//		/// Description: "A necklace with mysterious power."<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 70<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-0001-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinKingsNecklace { get; } = new Item() { ID = 2301, Name = "GoblinKingsNecklace", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Cecil"<para/>
//		/// Description: "Something is glowing."<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 70<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-0002-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Cecil { get; } = new Item() { ID = 2302, Name = "Cecil", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Thick Leather"<para/>
//		/// Description: "A thick and tough leather"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 50<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-skin-bulldrome-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ThickLeather { get; } = new Item() { ID = 2303, Name = "ThickLeather", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Damaged Life Support Device"<para/>
//		/// Description: "A man killed by the Boar King and left this."<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 50<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-life-support-device-b-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DamagedLifeSupportDevice { get; } = new Item() { ID = 2304, Name = "DamagedLifeSupportDevice", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Parasytor Mucosa"<para/>
//		/// Description: "Ugh!"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 50<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-skin-mutants-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ParasytorMucosa { get; } = new Item() { ID = 2305, Name = "ParasytorMucosa", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Agricultural Manual"<para/>
//		/// Description: "This book looks outdated."<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 70<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-agricultural-manual-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item AgriculturalManual { get; } = new Item() { ID = 2306, Name = "AgriculturalManual", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Ord Toolbox"<para/>
//		/// Description: "Although this looks old, but it is still good for use."<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 70<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-toolbox-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OrdToolbox { get; } = new Item() { ID = 2307, Name = "OrdToolbox", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Parasect Stone"<para/>
//		/// Description: "A mysterious living ruby."<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 120<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-0004-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ParasectStone { get; } = new Item() { ID = 2308, Name = "ParasectStone", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Poison Spore"<para/>
//		/// Description: "Very soft and sticky."<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 120<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-0005-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item PoisonSpore { get; } = new Item() { ID = 2309, Name = "PoisonSpore", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Flashlight"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 190<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-flashlight-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Flashlight { get; } = new Item() { ID = 2310, Name = "Flashlight", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Metal Detector"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 190<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-metaldetector-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MetalDetector { get; } = new Item() { ID = 2311, Name = "MetalDetector", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Parasytor Symbiotic Worm"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 50<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-0015-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ParasytorSymbioticWorm { get; } = new Item() { ID = 2312, Name = "ParasytorSymbioticWorm", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin Fork"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 70<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-0014-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinFork { get; } = new Item() { ID = 2313, Name = "GoblinFork", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin Bracelet"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 70<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-0013-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinBracelet { get; } = new Item() { ID = 2314, Name = "GoblinBracelet", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin Shield"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 70<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-0003-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinShield { get; } = new Item() { ID = 2315, Name = "GoblinShield", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Elytron Shield"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 120<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-0012-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorElytronShield { get; } = new Item() { ID = 2316, Name = "InsectorElytronShield", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Wings"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 120<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-0011-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorWings { get; } = new Item() { ID = 2317, Name = "InsectorWings", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Parasect Thorn"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 120<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-0006-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ParasectThorn { get; } = new Item() { ID = 2318, Name = "ParasectThorn", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Life Support Device"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 190<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-life-support-device-a-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoLifeSupportDevice { get; } = new Item() { ID = 2319, Name = "MecoLifeSupportDevice", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Shield"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 190<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-0010-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoShield { get; } = new Item() { ID = 2320, Name = "MecoShield", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Electric Spoon"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 190<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-0007-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoElectricSpoon { get; } = new Item() { ID = 2321, Name = "MecoElectricSpoon", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Powered Exoskeleton Arm"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 190<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-0008-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoPoweredExoskeletonArm { get; } = new Item() { ID = 2322, Name = "MecoPoweredExoskeletonArm", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Biotech Powered Exoskeleton Arm"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 190<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-0009-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoBiotechPoweredExoskeletonArm { get; } = new Item() { ID = 2323, Name = "MecoBiotechPoweredExoskeletonArm", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Amber Shield"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 175<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-amber-shield-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item AmberShield { get; } = new Item() { ID = 2324, Name = "AmberShield", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Modified Detector"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 19<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 175<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/accessories-detector-custom-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ModifiedDetector { get; } = new Item() { ID = 2325, Name = "ModifiedDetector", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Fur Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-100-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item FurOutfit { get; } = new Item() { ID = 2401, Name = "FurOutfit", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Hunter Lightweight Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-101-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item HunterLightweightOutfit { get; } = new Item() { ID = 2402, Name = "HunterLightweightOutfit", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Desert Lightweight Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-102-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DesertLightweightOutfit { get; } = new Item() { ID = 2403, Name = "DesertLightweightOutfit", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meow-tea's Silk Cloak"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-103-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MeowTeasSilkCloak { get; } = new Item() { ID = 2404, Name = "MeowTeasSilkCloak", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Rainforest Grass Skirt"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-104-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item RainforestGrassSkirt { get; } = new Item() { ID = 2405, Name = "RainforestGrassSkirt", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Half-elf Lightweight Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-105-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item HalfElfLightweightArmor { get; } = new Item() { ID = 2406, Name = "HalfElfLightweightArmor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Orc Soft Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-106-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OrcSoftArmor { get; } = new Item() { ID = 2407, Name = "OrcSoftArmor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Dark Elf Soft Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-107-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DarkElfSoftArmor { get; } = new Item() { ID = 2408, Name = "DarkElfSoftArmor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Elf Lightweight Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-108-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ElfLightweightArmor { get; } = new Item() { ID = 2409, Name = "ElfLightweightArmor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Work Bib"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-109-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WorkBib { get; } = new Item() { ID = 2410, Name = "WorkBib", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Jungle Soft Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-110-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item JungleSoftArmor { get; } = new Item() { ID = 2411, Name = "JungleSoftArmor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Barbarian Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-111-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BarbarianOutfit { get; } = new Item() { ID = 2412, Name = "BarbarianOutfit", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Boarman Plate"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-112-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BoarmanPlate { get; } = new Item() { ID = 2413, Name = "BoarmanPlate", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Fur Lightweight Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-200-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item FurLightweightArmor { get; } = new Item() { ID = 2501, Name = "FurLightweightArmor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Hunter Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-201-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item HunterOutfit { get; } = new Item() { ID = 2502, Name = "HunterOutfit", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Desert Leather Skirt"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-202-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DesertLeatherSkirt { get; } = new Item() { ID = 2503, Name = "DesertLeatherSkirt", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meow-tea's Short Cloak"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-203-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MeowTeasShortCloak { get; } = new Item() { ID = 2504, Name = "MeowTeasShortCloak", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Rainforest Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-204-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item RainforestOutfit { get; } = new Item() { ID = 2505, Name = "RainforestOutfit", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Half-elf Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-205-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item HalfElfOutfit { get; } = new Item() { ID = 2506, Name = "HalfElfOutfit", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Orc Lightweight Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-206-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OrcLightweightArmor { get; } = new Item() { ID = 2507, Name = "OrcLightweightArmor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Dark Elf Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-207-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DarkElfOutfit { get; } = new Item() { ID = 2508, Name = "DarkElfOutfit", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Elf Short Cloak"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-208-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ElfShortCloak { get; } = new Item() { ID = 2509, Name = "ElfShortCloak", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Researcher Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-209-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoResearcherOutfit0 { get; } = new Item() { ID = 2510, Name = "MecoResearcherOutfit0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Jungle Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-210-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item JungleOutfit { get; } = new Item() { ID = 2511, Name = "JungleOutfit", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Barbarian Plate"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-211-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BarbarianPlate { get; } = new Item() { ID = 2512, Name = "BarbarianPlate", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Boarman Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-212-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BoarmanOutfit { get; } = new Item() { ID = 2513, Name = "BoarmanOutfit", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Fur Plate"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-300-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item FurPlate { get; } = new Item() { ID = 2601, Name = "FurPlate", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Hunter Cloak"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-301-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item HunterCloak { get; } = new Item() { ID = 2602, Name = "HunterCloak", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Desert Leather Vest"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-302-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DesertLeatherVest { get; } = new Item() { ID = 2603, Name = "DesertLeatherVest", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meow-tea's Shawlish"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-303-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MeowTeasShawlish { get; } = new Item() { ID = 2604, Name = "MeowTeasShawlish", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Rainforest Cloak"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-304-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item RainforestCloak { get; } = new Item() { ID = 2605, Name = "RainforestCloak", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Half-elf Plate"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-305-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item HalfElfPlate { get; } = new Item() { ID = 2606, Name = "HalfElfPlate", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Orc Plate"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-306-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OrcPlate { get; } = new Item() { ID = 2607, Name = "OrcPlate", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Dark Elf Lightweight Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-307-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DarkElfLightweightOutfit { get; } = new Item() { ID = 2608, Name = "DarkElfLightweightOutfit", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Elf Plate"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-308-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ElfPlate { get; } = new Item() { ID = 2609, Name = "ElfPlate", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Combat Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-309-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CombatOutfit { get; } = new Item() { ID = 2610, Name = "CombatOutfit", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Jungle Combat Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-310-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item JungleCombatOutfit { get; } = new Item() { ID = 2611, Name = "JungleCombatOutfit", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Barbarian Lightweight Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-311-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BarbarianLightweightArmor { get; } = new Item() { ID = 2612, Name = "BarbarianLightweightArmor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Boarman Lightweight Armor"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 375<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-312-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BoarmanLightweightArmor { get; } = new Item() { ID = 2613, Name = "BoarmanLightweightArmor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Researcher Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-29-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoResearcherOutfit1 { get; } = new Item() { ID = 2701, Name = "MecoResearcherOutfit1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Researcher Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-30-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoResearcherOutfit2 { get; } = new Item() { ID = 2702, Name = "MecoResearcherOutfit2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Researcher Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-31-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoResearcherOutfit3 { get; } = new Item() { ID = 2703, Name = "MecoResearcherOutfit3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Researcher Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-32-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoResearcherOutfit4 { get; } = new Item() { ID = 2704, Name = "MecoResearcherOutfit4", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Researcher Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-NPC-cook-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoResearcherOutfit5 { get; } = new Item() { ID = 2705, Name = "MecoResearcherOutfit5", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Researcher Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-NPC-ArchitecturalBusinessman-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoResearcherOutfit6 { get; } = new Item() { ID = 2706, Name = "MecoResearcherOutfit6", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Researcher Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-NPC-miner-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoResearcherOutfit7 { get; } = new Item() { ID = 2707, Name = "MecoResearcherOutfit7", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Researcher Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-NPC-herdsman-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoResearcherOutfit8 { get; } = new Item() { ID = 2708, Name = "MecoResearcherOutfit8", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Researcher Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-NPC-farmer-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoResearcherOutfit9 { get; } = new Item() { ID = 2709, Name = "MecoResearcherOutfit9", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Researcher Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-NPC-blacksmith-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoResearcherOutfit10 { get; } = new Item() { ID = 2710, Name = "MecoResearcherOutfit10", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Researcher Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-NPC-doctor-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoResearcherOutfit11 { get; } = new Item() { ID = 2711, Name = "MecoResearcherOutfit11", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Rifter Outfit"<para/>
//		/// Type: 5<para/>
//		/// ItemType: 16<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 37<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 500<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/armor-Rifter-01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item RifterOutfit { get; } = new Item() { ID = 2712, Name = "RifterOutfit", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Dirt Block"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 41<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/hill-earth-icon"<para/>
//		/// PlacenmentId: 1001<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1, 6 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DirtBlock { get; } = new Item() { ID = 3001, Name = "DirtBlock", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Frozen Soil Block"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 41<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 1002<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item FrozenSoilBlock { get; } = new Item() { ID = 3002, Name = "FrozenSoilBlock", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Sand Block"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 41<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/hill-sand-icon"<para/>
//		/// PlacenmentId: 1003<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9009, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SandBlock { get; } = new Item() { ID = 3003, Name = "SandBlock", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone Block"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 41<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/hill-stone-icon"<para/>
//		/// PlacenmentId: 1004<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1, 6 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneBlock { get; } = new Item() { ID = 3004, Name = "StoneBlock", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Ore"<para/>
//		/// Description: "A metal bar that is smelted from an ore through a furnace."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 22<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 12<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/hill-copper-icon"<para/>
//		/// PlacenmentId: 1005<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9011, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperOre { get; } = new Item() { ID = 3005, Name = "CopperOre", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Ore"<para/>
//		/// Description: "A metal bar that is smelted from an ore through a furnace."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 22<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 20<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/hill-iron-icon"<para/>
//		/// PlacenmentId: 1006<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronOre { get; } = new Item() { ID = 3006, Name = "IronOre", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Ore"<para/>
//		/// Description: "A metal bar that is smelted from an ore through a furnace."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 22<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 35<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/hill-silver-icon"<para/>
//		/// PlacenmentId: 1007<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverOre { get; } = new Item() { ID = 3007, Name = "SilverOre", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Gold Ore"<para/>
//		/// Description: "A metal bar that is smelted from an ore through a furnace."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 22<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 60<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/hill-gold-icon"<para/>
//		/// PlacenmentId: 1008<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldOre { get; } = new Item() { ID = 3008, Name = "GoldOre", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Diamond"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 27<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/hill-diamond-icon"<para/>
//		/// PlacenmentId: 1009<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Diamond { get; } = new Item() { ID = 3009, Name = "Diamond", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Snow Block"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 41<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/hill-snow-icon"<para/>
//		/// PlacenmentId: 1010<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1, 6 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SnowBlock { get; } = new Item() { ID = 3010, Name = "SnowBlock", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Ice Block"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 41<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/hill-ice-icon"<para/>
//		/// PlacenmentId: 1011<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1, 6 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IceBlock { get; } = new Item() { ID = 3011, Name = "IceBlock", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Coal Ore"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 4<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 25<para/>
//		/// DropTexture: "Icon/hill-coal-icon"<para/>
//		/// PlacenmentId: 1012<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CoalOre { get; } = new Item() { ID = 3012, Name = "CoalOre", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clay"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clay { get; } = new Item() { ID = 3013, Name = "Clay", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Sulfur Ore"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 10<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/hill-sulphur-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SulfurOre { get; } = new Item() { ID = 3014, Name = "SulfurOre", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Saltpeter Ore"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/hill-saltpeter-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SaltpeterOre { get; } = new Item() { ID = 3015, Name = "SaltpeterOre", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/hill-mutants&demon-icon"<para/>
//		/// PlacenmentId: 1016<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorWall { get; } = new Item() { ID = 3016, Name = "InsectorWall", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Parasytor Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/hill-mutants-icon"<para/>
//		/// PlacenmentId: 1017<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ParasytorWall0 { get; } = new Item() { ID = 3017, Name = "ParasytorWall0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wood Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 25<para/>
//		/// DropTexture: "Icon/wall-wood-icon"<para/>
//		/// PlacenmentId: 2001<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodWall { get; } = new Item() { ID = 3101, Name = "WoodWall", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Dirt Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/wall-earth-icon"<para/>
//		/// PlacenmentId: 2002<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DirtWall { get; } = new Item() { ID = 3102, Name = "DirtWall", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/wall-stone-icon"<para/>
//		/// PlacenmentId: 2003<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneWall { get; } = new Item() { ID = 3103, Name = "StoneWall", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/wall-copper-icon"<para/>
//		/// PlacenmentId: 2004<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9011, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperWall { get; } = new Item() { ID = 3104, Name = "CopperWall", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/wall-iron-icon"<para/>
//		/// PlacenmentId: 2005<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronWall { get; } = new Item() { ID = 3105, Name = "IronWall", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/wall-silver-icon"<para/>
//		/// PlacenmentId: 2006<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverWall { get; } = new Item() { ID = 3106, Name = "SilverWall", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Golden Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/wall-gold-icon"<para/>
//		/// PlacenmentId: 2007<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldenWall { get; } = new Item() { ID = 3107, Name = "GoldenWall", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Diamond Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 2008<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DiamondWall { get; } = new Item() { ID = 3108, Name = "DiamondWall", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Glass Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/wall-glass-icon"<para/>
//		/// PlacenmentId: 2009<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9009, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GlassWall { get; } = new Item() { ID = 3109, Name = "GlassWall", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Snow Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/wall-snow-icon"<para/>
//		/// PlacenmentId: 2010<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SnowWall { get; } = new Item() { ID = 3110, Name = "SnowWall", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Ice Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/wall-ice-icon"<para/>
//		/// PlacenmentId: 2011<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IceWall0 { get; } = new Item() { ID = 3111, Name = "IceWall0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Fence"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 10<para/>
//		/// DropTexture: "Icon/fence-wood-icon"<para/>
//		/// PlacenmentId: 2012<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenFence { get; } = new Item() { ID = 3112, Name = "WoodenFence", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Log Fence"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 2013<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item LogFence { get; } = new Item() { ID = 3113, Name = "LogFence", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Fence"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/fence-copper-icon"<para/>
//		/// PlacenmentId: 2014<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9011, 1 ]<para/>
//		/// SmeltConsume: 5<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperFence { get; } = new Item() { ID = 3114, Name = "CopperFence", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Fence"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/fence-iron-icon"<para/>
//		/// PlacenmentId: 2015<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 1 ]<para/>
//		/// SmeltConsume: 5<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronFence { get; } = new Item() { ID = 3115, Name = "IronFence", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Fence"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/fence-silver-icon"<para/>
//		/// PlacenmentId: 2016<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 1 ]<para/>
//		/// SmeltConsume: 5<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverFence { get; } = new Item() { ID = 3116, Name = "SilverFence", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Golden Fence"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/fence-gold-icon"<para/>
//		/// PlacenmentId: 2017<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 1 ]<para/>
//		/// SmeltConsume: 5<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldenFence { get; } = new Item() { ID = 3117, Name = "GoldenFence", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Diamond Fence"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 2018<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DiamondFence { get; } = new Item() { ID = 3118, Name = "DiamondFence", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Bone Fence"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/fence-bones-icon"<para/>
//		/// PlacenmentId: 2076<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BoneFence { get; } = new Item() { ID = 3120, Name = "BoneFence", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Bone Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/hill-bones&earth-icon"<para/>
//		/// PlacenmentId: 2078<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BoneWall { get; } = new Item() { ID = 3121, Name = "BoneWall", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Town Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/wall-rampart-icon"<para/>
//		/// PlacenmentId: 2080<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item TownWall0 { get; } = new Item() { ID = 3122, Name = "TownWall0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Town Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/wall-rampart-icon"<para/>
//		/// PlacenmentId: 2081<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item TownWall1 { get; } = new Item() { ID = 3123, Name = "TownWall1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Parasytor Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/wall-meco1-icon"<para/>
//		/// PlacenmentId: 2082<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ParasytorWall1 { get; } = new Item() { ID = 3124, Name = "ParasytorWall1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Parasytor Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/wall-meco2-icon"<para/>
//		/// PlacenmentId: 2083<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ParasytorWall2 { get; } = new Item() { ID = 3125, Name = "ParasytorWall2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Parasytor Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/wall-meco3-icon"<para/>
//		/// PlacenmentId: 2084<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ParasytorWall3 { get; } = new Item() { ID = 3126, Name = "ParasytorWall3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Parasytor Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/wall-meco1-icon"<para/>
//		/// PlacenmentId: 2065<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ParasytorWall4 { get; } = new Item() { ID = 3127, Name = "ParasytorWall4", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Parasytor Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/wall-meco1-icon"<para/>
//		/// PlacenmentId: 2066<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ParasytorWall5 { get; } = new Item() { ID = 3128, Name = "ParasytorWall5", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Parasytor Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/wall-meco1-icon"<para/>
//		/// PlacenmentId: 2067<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ParasytorWall6 { get; } = new Item() { ID = 3129, Name = "ParasytorWall6", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Parasytor Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/wall-meco2-icon"<para/>
//		/// PlacenmentId: 2085<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ParasytorWall7 { get; } = new Item() { ID = 3130, Name = "ParasytorWall7", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Parasytor Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/wall-meco2-icon"<para/>
//		/// PlacenmentId: 2086<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ParasytorWall8 { get; } = new Item() { ID = 3131, Name = "ParasytorWall8", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Parasytor Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/wall-meco2-icon"<para/>
//		/// PlacenmentId: 2087<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ParasytorWall9 { get; } = new Item() { ID = 3132, Name = "ParasytorWall9", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Ice Wall"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 42<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/wall-sand&glass-icon"<para/>
//		/// PlacenmentId: 2088<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IceWall1 { get; } = new Item() { ID = 3133, Name = "IceWall1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Acorn"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 43<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/tree-seed01-icon"<para/>
//		/// PlacenmentId: 1<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 4 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Acorn { get; } = new Item() { ID = 3201, Name = "Acorn", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Pine Cone"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 43<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/tree-seed03-icon"<para/>
//		/// PlacenmentId: 11<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 4 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item PineCone { get; } = new Item() { ID = 3202, Name = "PineCone", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Apple Seed"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 43<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/tree-seed02-icon"<para/>
//		/// PlacenmentId: 21<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 4 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item AppleSeed { get; } = new Item() { ID = 3203, Name = "AppleSeed", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Berry Seeds"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 43<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/tree-seed04-icon"<para/>
//		/// PlacenmentId: 31<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 4 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BerrySeeds { get; } = new Item() { ID = 3204, Name = "BerrySeeds", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Cactus"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 43<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/cactus-seed01-icon"<para/>
//		/// PlacenmentId: 41<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 4 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Cactus { get; } = new Item() { ID = 3205, Name = "Cactus", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Fir Cone"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 43<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/tree-seed05-icon"<para/>
//		/// PlacenmentId: 61<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 4 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item FirCone { get; } = new Item() { ID = 3206, Name = "FirCone", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Larch Pine Cone"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 43<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/tree-seed06-icon"<para/>
//		/// PlacenmentId: 81<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 4 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item LarchPineCone { get; } = new Item() { ID = 3207, Name = "LarchPineCone", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Unused"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 43<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 6016<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 4 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Unused { get; } = new Item() { ID = 3208, Name = "Unused", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Flower"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 43<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/flower-01-icon"<para/>
//		/// PlacenmentId: 121<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Flower0 { get; } = new Item() { ID = 3209, Name = "Flower0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Flower"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 43<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/flower-02-icon"<para/>
//		/// PlacenmentId: 122<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Flower1 { get; } = new Item() { ID = 3210, Name = "Flower1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Flower"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 43<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/flower-03-icon"<para/>
//		/// PlacenmentId: 123<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Flower2 { get; } = new Item() { ID = 3211, Name = "Flower2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Flower"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 43<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/flower-04-icon"<para/>
//		/// PlacenmentId: 124<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Flower3 { get; } = new Item() { ID = 3212, Name = "Flower3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Flower"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 43<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/flower-05-icon"<para/>
//		/// PlacenmentId: 125<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Flower4 { get; } = new Item() { ID = 3213, Name = "Flower4", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Flower"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 43<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/flower-06-icon"<para/>
//		/// PlacenmentId: 126<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Flower5 { get; } = new Item() { ID = 3214, Name = "Flower5", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Flower"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 43<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/flower-07-icon"<para/>
//		/// PlacenmentId: 127<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Flower6 { get; } = new Item() { ID = 3215, Name = "Flower6", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Flower"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 43<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/flower-08-icon"<para/>
//		/// PlacenmentId: 128<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Flower7 { get; } = new Item() { ID = 3216, Name = "Flower7", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Flower"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 43<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/flower-09-icon"<para/>
//		/// PlacenmentId: 129<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Flower8 { get; } = new Item() { ID = 3217, Name = "Flower8", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Eye"<para/>
//		/// Description: "A mysterious glowing object."<para/>
//		/// Function: "A lighting placement that has a very high chance of preventing monsters from spawning around it."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 43<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/demon-seed-icon"<para/>
//		/// PlacenmentId: 221<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 4 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorEye { get; } = new Item() { ID = 3218, Name = "InsectorEye", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Nidus"<para/>
//		/// Description: "A place where insector eggs are produced."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 5<para/>
//		/// DropTexture: "Icon/demon-eye-icon"<para/>
//		/// PlacenmentId: 213<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorNidus { get; } = new Item() { ID = 3219, Name = "InsectorNidus", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Parasytor Primordium"<para/>
//		/// Description: "A material that can also be used to strengthen equipment in the Plating Pool."<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 1<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/mutants-seed-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ParasytorPrimordium { get; } = new Item() { ID = 3220, Name = "ParasytorPrimordium", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Grass Seed"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 47<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/grass-seed-icon"<para/>
//		/// PlacenmentId: 241<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 4, 6 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GrassSeed { get; } = new Item() { ID = 3221, Name = "GrassSeed", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Thorns Seed"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 43<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/fhorns-send-icon"<para/>
//		/// PlacenmentId: 251<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 4 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ThornsSeed { get; } = new Item() { ID = 3222, Name = "ThornsSeed", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Fluorescent Fern Seed"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 43<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/fluorescent-send-icon"<para/>
//		/// PlacenmentId: 271<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 4 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item FluorescentFernSeed { get; } = new Item() { ID = 3224, Name = "FluorescentFernSeed", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Amber Plant Seed"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 43<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/amberplant-seed-icon"<para/>
//		/// PlacenmentId: 281<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 4 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item AmberPlantSeed { get; } = new Item() { ID = 3225, Name = "AmberPlantSeed", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Parasytor Seed"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 47<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/mutants-seed2-icon"<para/>
//		/// PlacenmentId: 236<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 4 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ParasytorSeed { get; } = new Item() { ID = 3226, Name = "ParasytorSeed", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Torch"<para/>
//		/// Function: "A lighting placement that has a very high chance of preventing monsters from spawning around it."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 101<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 25<para/>
//		/// DropTexture: "Icon/torch-wood-icon"<para/>
//		/// PlacenmentId: 3001<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1, 6 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Torch { get; } = new Item() { ID = 3501, Name = "Torch", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Campfire"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 40<para/>
//		/// DropTexture: "Icon/campfire-wood-icon"<para/>
//		/// PlacenmentId: 3002<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Campfire { get; } = new Item() { ID = 3502, Name = "Campfire", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Tiki Torch"<para/>
//		/// Function: "A lighting placement that has a very high chance of preventing monsters from spawning around it."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 25<para/>
//		/// DropTexture: "Icon/torch-wood-tall-icon"<para/>
//		/// PlacenmentId: 3003<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenTikiTorch { get; } = new Item() { ID = 3503, Name = "WoodenTikiTorch", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin Tiki Torch"<para/>
//		/// Function: "A lighting placement that has a very high chance of preventing monsters from spawning around it."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/torch-bones-tall-icon"<para/>
//		/// PlacenmentId: 3004<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinTikiTorch { get; } = new Item() { ID = 3504, Name = "GoblinTikiTorch", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone Tiki Torch"<para/>
//		/// Function: "A lighting placement that has a very high chance of preventing monsters from spawning around it."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/torch-wood-tall-icon"<para/>
//		/// PlacenmentId: 3005<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneTikiTorch { get; } = new Item() { ID = 3505, Name = "StoneTikiTorch", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Tiki Torch"<para/>
//		/// Function: "A lighting placement that has a very high chance of preventing monsters from spawning around it."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/torch-copper-tall-icon"<para/>
//		/// PlacenmentId: 3006<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperTikiTorch { get; } = new Item() { ID = 3506, Name = "CopperTikiTorch", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Tiki Torch"<para/>
//		/// Function: "A lighting placement that has a very high chance of preventing monsters from spawning around it."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/torch-iron-tall-icon"<para/>
//		/// PlacenmentId: 3007<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronTikiTorch { get; } = new Item() { ID = 3507, Name = "IronTikiTorch", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Tiki Torch"<para/>
//		/// Function: "A lighting placement that has a very high chance of preventing monsters from spawning around it."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/torch-silver-tall-icon"<para/>
//		/// PlacenmentId: 3008<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverTikiTorch { get; } = new Item() { ID = 3508, Name = "SilverTikiTorch", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Golden Tiki Torch"<para/>
//		/// Function: "A lighting placement that has a very high chance of preventing monsters from spawning around it."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/torch-gold-tall-icon"<para/>
//		/// PlacenmentId: 3009<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldenTikiTorch { get; } = new Item() { ID = 3509, Name = "GoldenTikiTorch", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Simple Workbench"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 50<para/>
//		/// DropTexture: "Icon/workbench-wood-icon"<para/>
//		/// PlacenmentId: 3010<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenSimpleWorkbench { get; } = new Item() { ID = 3510, Name = "WoodenSimpleWorkbench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone Simple Workbench"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3011<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneSimpleWorkbench { get; } = new Item() { ID = 3511, Name = "StoneSimpleWorkbench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Simple Workbench"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/workbench-copper-icon"<para/>
//		/// PlacenmentId: 3012<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9011, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperSimpleWorkbench { get; } = new Item() { ID = 3512, Name = "CopperSimpleWorkbench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Simple Workbench"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/workbench-iron-icon"<para/>
//		/// PlacenmentId: 3013<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronSimpleWorkbench { get; } = new Item() { ID = 3513, Name = "IronSimpleWorkbench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Simple Workbench"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/workbench-silver-icon"<para/>
//		/// PlacenmentId: 3014<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverSimpleWorkbench { get; } = new Item() { ID = 3514, Name = "SilverSimpleWorkbench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Golden Simple Workbench"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/workbench-gold-icon"<para/>
//		/// PlacenmentId: 3015<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldenSimpleWorkbench { get; } = new Item() { ID = 3515, Name = "GoldenSimpleWorkbench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Diamond Simple Workbench"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3016<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DiamondSimpleWorkbench { get; } = new Item() { ID = 3516, Name = "DiamondSimpleWorkbench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone Stove"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/cookingbench-stone-icon"<para/>
//		/// PlacenmentId: 3017<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneStove { get; } = new Item() { ID = 3517, Name = "StoneStove", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Stove"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/cookingbench-copper-icon"<para/>
//		/// PlacenmentId: 3018<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9011, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperStove { get; } = new Item() { ID = 3518, Name = "CopperStove", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Stove"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/cookingbench-iron-icon"<para/>
//		/// PlacenmentId: 3019<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronStove { get; } = new Item() { ID = 3519, Name = "IronStove", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Stove"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/cookingbench-silver-icon"<para/>
//		/// PlacenmentId: 3020<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverStove { get; } = new Item() { ID = 3520, Name = "SilverStove", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Golden Stove"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/cookingbench-gold-icon"<para/>
//		/// PlacenmentId: 3021<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldenStove { get; } = new Item() { ID = 3521, Name = "GoldenStove", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Diamond Stove"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3022<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DiamondStove { get; } = new Item() { ID = 3522, Name = "DiamondStove", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Furnace"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/furnace-stone-icon"<para/>
//		/// PlacenmentId: 3023<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Furnace { get; } = new Item() { ID = 3523, Name = "Furnace", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Anvil"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/anvil-copper-icon"<para/>
//		/// PlacenmentId: 3024<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9011, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperAnvil { get; } = new Item() { ID = 3524, Name = "CopperAnvil", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Anvil"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/anvil-iron-icon"<para/>
//		/// PlacenmentId: 3025<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronAnvil { get; } = new Item() { ID = 3525, Name = "IronAnvil", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Anvil"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/anvil-silver-icon"<para/>
//		/// PlacenmentId: 3026<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverAnvil { get; } = new Item() { ID = 3526, Name = "SilverAnvil", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Golden Anvil"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/anvil-gold-icon"<para/>
//		/// PlacenmentId: 3027<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldenAnvil { get; } = new Item() { ID = 3527, Name = "GoldenAnvil", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Diamond Anvil"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3028<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DiamondAnvil { get; } = new Item() { ID = 3528, Name = "DiamondAnvil", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Brewery"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 50<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3029<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenBrewery { get; } = new Item() { ID = 3529, Name = "WoodenBrewery", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone Brewery"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3030<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneBrewery { get; } = new Item() { ID = 3530, Name = "StoneBrewery", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Brewery"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3031<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9011, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperBrewery { get; } = new Item() { ID = 3531, Name = "CopperBrewery", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Brewery"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3032<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronBrewery { get; } = new Item() { ID = 3532, Name = "IronBrewery", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Brewery"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3033<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverBrewery { get; } = new Item() { ID = 3533, Name = "SilverBrewery", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Golden Brewery"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3034<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldenBrewery { get; } = new Item() { ID = 3534, Name = "GoldenBrewery", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Diamond Brewery"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3035<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DiamondBrewery { get; } = new Item() { ID = 3535, Name = "DiamondBrewery", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Furniture Workbench"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 50<para/>
//		/// DropTexture: "Icon/furniturebench-wood-icon"<para/>
//		/// PlacenmentId: 3036<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenFurnitureWorkbench { get; } = new Item() { ID = 3536, Name = "WoodenFurnitureWorkbench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone Furniture Workbench"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3037<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneFurnitureWorkbench { get; } = new Item() { ID = 3537, Name = "StoneFurnitureWorkbench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Furniture Workbench"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/furniturebench-copper-icon"<para/>
//		/// PlacenmentId: 3038<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9011, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperFurnitureWorkbench { get; } = new Item() { ID = 3538, Name = "CopperFurnitureWorkbench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Furniture Workbench"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/furniturebench-iron-icon"<para/>
//		/// PlacenmentId: 3039<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronFurnitureWorkbench { get; } = new Item() { ID = 3539, Name = "IronFurnitureWorkbench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Furniture Workbench"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/furniturebench-silver-icon"<para/>
//		/// PlacenmentId: 3040<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverFurnitureWorkbench { get; } = new Item() { ID = 3540, Name = "SilverFurnitureWorkbench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Golden Furniture Workbench"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/furniturebench-gold-icon"<para/>
//		/// PlacenmentId: 3041<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldenFurnitureWorkbench { get; } = new Item() { ID = 3541, Name = "GoldenFurnitureWorkbench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Diamond Furniture Bench"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3042<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DiamondFurnitureBench { get; } = new Item() { ID = 3542, Name = "DiamondFurnitureBench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wood craft table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 50<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3043<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodCraftTable { get; } = new Item() { ID = 3543, Name = "WoodCraftTable", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone craft"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3044<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneCraft { get; } = new Item() { ID = 3544, Name = "StoneCraft", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper craft table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3045<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9011, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperCraftTable { get; } = new Item() { ID = 3545, Name = "CopperCraftTable", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron craft table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3046<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronCraftTable { get; } = new Item() { ID = 3546, Name = "IronCraftTable", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver craft table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3047<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverCraftTable { get; } = new Item() { ID = 3547, Name = "SilverCraftTable", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Gold craft table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3048<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldCraftTable { get; } = new Item() { ID = 3548, Name = "GoldCraftTable", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Diamond craft table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3049<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DiamondCraftTable { get; } = new Item() { ID = 3549, Name = "DiamondCraftTable", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Firearm Workbench"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 50<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3050<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenFirearmWorkbench { get; } = new Item() { ID = 3550, Name = "WoodenFirearmWorkbench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone Firearm Workbench"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3051<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneFirearmWorkbench { get; } = new Item() { ID = 3551, Name = "StoneFirearmWorkbench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Firearm Workbench"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/explosivebench-copper-icon"<para/>
//		/// PlacenmentId: 3052<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9011, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperFirearmWorkbench { get; } = new Item() { ID = 3552, Name = "CopperFirearmWorkbench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Firearm Workbench"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/explosivebench-iron-icon"<para/>
//		/// PlacenmentId: 3053<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronFirearmWorkbench { get; } = new Item() { ID = 3553, Name = "IronFirearmWorkbench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Firearm Workbench"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/explosivebench-silver-icon"<para/>
//		/// PlacenmentId: 3054<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverFirearmWorkbench { get; } = new Item() { ID = 3554, Name = "SilverFirearmWorkbench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Golden Firearm Workbench"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/explosivebench-gold-icon"<para/>
//		/// PlacenmentId: 3055<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldenFirearmWorkbench { get; } = new Item() { ID = 3555, Name = "GoldenFirearmWorkbench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Diamond Firearm Workbench"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3056<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DiamondFirearmWorkbench { get; } = new Item() { ID = 3556, Name = "DiamondFirearmWorkbench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone digester"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3057<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneDigester { get; } = new Item() { ID = 3557, Name = "StoneDigester", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper biogas tank"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3058<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9011, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperBiogasTank { get; } = new Item() { ID = 3558, Name = "CopperBiogasTank", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron digester"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3059<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronDigester { get; } = new Item() { ID = 3559, Name = "IronDigester", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver biogas pool"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3060<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverBiogasPool { get; } = new Item() { ID = 3560, Name = "SilverBiogasPool", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Gold biogas pool"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3061<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldBiogasPool { get; } = new Item() { ID = 3561, Name = "GoldBiogasPool", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Diamond biogas tank"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3062<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DiamondBiogasTank { get; } = new Item() { ID = 3562, Name = "DiamondBiogasTank", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin Workbench"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/workbench-bones-icon"<para/>
//		/// PlacenmentId: 3063<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinWorkbench { get; } = new Item() { ID = 3563, Name = "GoblinWorkbench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Fusion Pool"<para/>
//		/// Description: "A pool that is used for dissolving and reorganizing some materials and items."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/demon-evilbench-icon"<para/>
//		/// PlacenmentId: 3064<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item FusionPool { get; } = new Item() { ID = 3564, Name = "FusionPool", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Plating Pool"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/demon-platingpool-icon"<para/>
//		/// PlacenmentId: 3065<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item PlatingPool { get; } = new Item() { ID = 3565, Name = "PlatingPool", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Workbench Foundry"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-furnace2-icon"<para/>
//		/// PlacenmentId: 3066<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WorkbenchFoundry { get; } = new Item() { ID = 3566, Name = "WorkbenchFoundry", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco T-Furnace"<para/>
//		/// Description: "Can be used to make materials for making Meco items."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-furnace-icon"<para/>
//		/// PlacenmentId: 3067<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoTFurnace0 { get; } = new Item() { ID = 3567, Name = "MecoTFurnace0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Biotech Foundry"<para/>
//		/// Description: "Can be used to make Meco biotech items."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-printer-mecobiology-icon"<para/>
//		/// PlacenmentId: 3068<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoBiotechFoundry { get; } = new Item() { ID = 3568, Name = "MecoBiotechFoundry", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Grounder Workbench"<para/>
//		/// Description: "Can be used to make Meco biotech items."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/workbench-grounder-icon"<para/>
//		/// PlacenmentId: 3069<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GrounderWorkbench { get; } = new Item() { ID = 3569, Name = "GrounderWorkbench", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Tenergy Foundry"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3070<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoTenergyFoundry { get; } = new Item() { ID = 3570, Name = "MecoTenergyFoundry", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco D-Tech Foundry"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3071<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoDTechFoundry { get; } = new Item() { ID = 3571, Name = "MecoDTechFoundry", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco T-Furnace"<para/>
//		/// Description: "Can be used to make materials for making Meco items."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-furnace3-icon"<para/>
//		/// PlacenmentId: 3072<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoTFurnace1 { get; } = new Item() { ID = 3572, Name = "MecoTFurnace1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Door"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 15<para/>
//		/// DropTexture: "Icon/door-wood-icon"<para/>
//		/// PlacenmentId: 3101<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenDoor { get; } = new Item() { ID = 3601, Name = "WoodenDoor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone Door"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/door-stone-icon"<para/>
//		/// PlacenmentId: 3102<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneDoor { get; } = new Item() { ID = 3602, Name = "StoneDoor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Door"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/door-copper-icon"<para/>
//		/// PlacenmentId: 3103<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9011, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperDoor { get; } = new Item() { ID = 3603, Name = "CopperDoor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Door"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/door-iron-icon"<para/>
//		/// PlacenmentId: 3104<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronDoor { get; } = new Item() { ID = 3604, Name = "IronDoor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Door"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/door-silver-icon"<para/>
//		/// PlacenmentId: 3105<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverDoor { get; } = new Item() { ID = 3605, Name = "SilverDoor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Golden Door"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/door-gold-icon"<para/>
//		/// PlacenmentId: 3106<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldenDoor { get; } = new Item() { ID = 3606, Name = "GoldenDoor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Sand Door"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/door-sand-icon"<para/>
//		/// PlacenmentId: 3107<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SandDoor { get; } = new Item() { ID = 3607, Name = "SandDoor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Ice Door"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/door-ice-icon"<para/>
//		/// PlacenmentId: 3108<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IceDoor { get; } = new Item() { ID = 3608, Name = "IceDoor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Snow Door"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/door-snow-icon"<para/>
//		/// PlacenmentId: 3109<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SnowDoor { get; } = new Item() { ID = 3609, Name = "SnowDoor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Glass Door"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/door-glass-icon"<para/>
//		/// PlacenmentId: 3110<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GlassDoor { get; } = new Item() { ID = 3610, Name = "GlassDoor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Round Table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 15<para/>
//		/// DropTexture: "Icon/roundtable-wood-icon"<para/>
//		/// PlacenmentId: 3111<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenRoundTable { get; } = new Item() { ID = 3611, Name = "WoodenRoundTable", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone Round Table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/roundtable-stone-icon"<para/>
//		/// PlacenmentId: 3112<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneRoundTable { get; } = new Item() { ID = 3612, Name = "StoneRoundTable", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Round Table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/roundtable-copper-icon"<para/>
//		/// PlacenmentId: 3113<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9011, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperRoundTable { get; } = new Item() { ID = 3613, Name = "CopperRoundTable", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Round Table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/roundtable-iron-icon"<para/>
//		/// PlacenmentId: 3114<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronRoundTable { get; } = new Item() { ID = 3614, Name = "IronRoundTable", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Round Table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/roundtable-silver-icon"<para/>
//		/// PlacenmentId: 3115<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverRoundTable { get; } = new Item() { ID = 3615, Name = "SilverRoundTable", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Golden Round Table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/roundtable-gold-icon"<para/>
//		/// PlacenmentId: 3116<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldenRoundTable { get; } = new Item() { ID = 3616, Name = "GoldenRoundTable", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Dirt Round Table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/roundtable-earth-icon"<para/>
//		/// PlacenmentId: 3117<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DirtRoundTable { get; } = new Item() { ID = 3617, Name = "DirtRoundTable", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Snow Round Table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/roundtable-snow-icon"<para/>
//		/// PlacenmentId: 3118<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SnowRoundTable { get; } = new Item() { ID = 3618, Name = "SnowRoundTable", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Bone Round Table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/roundtable-bones&earth-icon"<para/>
//		/// PlacenmentId: 3119<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BoneRoundTable0 { get; } = new Item() { ID = 3619, Name = "BoneRoundTable0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Bone Round Table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/roundtable-meco-icon"<para/>
//		/// PlacenmentId: 3120<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BoneRoundTable1 { get; } = new Item() { ID = 3620, Name = "BoneRoundTable1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Chair"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 15<para/>
//		/// DropTexture: "Icon/chair-wood-icon"<para/>
//		/// PlacenmentId: 3121<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenChair { get; } = new Item() { ID = 3621, Name = "WoodenChair", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone Chair"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/chair-stone-icon"<para/>
//		/// PlacenmentId: 3122<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneChair { get; } = new Item() { ID = 3622, Name = "StoneChair", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Chair"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/chair-copper-icon"<para/>
//		/// PlacenmentId: 3123<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9011, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperChair { get; } = new Item() { ID = 3623, Name = "CopperChair", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Chair"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/chair-iron-icon"<para/>
//		/// PlacenmentId: 3124<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronChair { get; } = new Item() { ID = 3624, Name = "IronChair", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Chair"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/chair-silver-icon"<para/>
//		/// PlacenmentId: 3125<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverChair { get; } = new Item() { ID = 3625, Name = "SilverChair", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Golden Chair"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/chair-gold-icon"<para/>
//		/// PlacenmentId: 3126<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldenChair { get; } = new Item() { ID = 3626, Name = "GoldenChair", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Dirt Chair"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/chair-earth-icon"<para/>
//		/// PlacenmentId: 3127<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DirtChair { get; } = new Item() { ID = 3627, Name = "DirtChair", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Snow Chair"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/chair-snow-icon"<para/>
//		/// PlacenmentId: 3128<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SnowChair { get; } = new Item() { ID = 3628, Name = "SnowChair", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Bone Chair"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/chair-bones-icon"<para/>
//		/// PlacenmentId: 3129<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BoneChair0 { get; } = new Item() { ID = 3629, Name = "BoneChair0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Bone Chair"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/chair-meco-icon"<para/>
//		/// PlacenmentId: 3130<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BoneChair1 { get; } = new Item() { ID = 3630, Name = "BoneChair1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Chest"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 15<para/>
//		/// DropTexture: "Icon/chest-wood-icon"<para/>
//		/// PlacenmentId: 3131<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenChest { get; } = new Item() { ID = 3631, Name = "WoodenChest", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Chest"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/chest-copper-icon"<para/>
//		/// PlacenmentId: 3132<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9011, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperChest { get; } = new Item() { ID = 3632, Name = "CopperChest", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Chest"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/chest-iron-icon"<para/>
//		/// PlacenmentId: 3133<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronChest { get; } = new Item() { ID = 3633, Name = "IronChest", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Chest"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/chest-silver-icon"<para/>
//		/// PlacenmentId: 3134<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverChest { get; } = new Item() { ID = 3634, Name = "SilverChest", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Golden Chest"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/chest-gold-icon"<para/>
//		/// PlacenmentId: 3135<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldenChest { get; } = new Item() { ID = 3635, Name = "GoldenChest", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Vintage Copper Chest"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 15<para/>
//		/// DropTexture: "Icon/chest-wood&copper-icon"<para/>
//		/// PlacenmentId: 3136<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item VintageCopperChest { get; } = new Item() { ID = 3636, Name = "VintageCopperChest", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Vintage Iron Chest"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 15<para/>
//		/// DropTexture: "Icon/chest-wood&iron-icon"<para/>
//		/// PlacenmentId: 3137<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item VintageIronChest { get; } = new Item() { ID = 3637, Name = "VintageIronChest", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Vintage Silver Chest"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 15<para/>
//		/// DropTexture: "Icon/chest-wood&silver-icon"<para/>
//		/// PlacenmentId: 3138<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item VintageSilverChest { get; } = new Item() { ID = 3638, Name = "VintageSilverChest", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Blue Chest"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 15<para/>
//		/// DropTexture: "Icon/chest-silver&blue-icon"<para/>
//		/// PlacenmentId: 3139<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BlueChest { get; } = new Item() { ID = 3639, Name = "BlueChest", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Green Chest"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 15<para/>
//		/// DropTexture: "Icon/chest-silver&green-icon"<para/>
//		/// PlacenmentId: 3140<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GreenChest { get; } = new Item() { ID = 3640, Name = "GreenChest", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Purple Chest"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 15<para/>
//		/// DropTexture: "Icon/chest-silver&purple-icon"<para/>
//		/// PlacenmentId: 3141<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item PurpleChest { get; } = new Item() { ID = 3641, Name = "PurpleChest", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Red Chest"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 15<para/>
//		/// DropTexture: "Icon/chest-silver&red-icon"<para/>
//		/// PlacenmentId: 3142<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item RedChest { get; } = new Item() { ID = 3642, Name = "RedChest", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Vintage Gold Chest"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/chest-gold&silver-icon"<para/>
//		/// PlacenmentId: 3143<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item VintageGoldChest { get; } = new Item() { ID = 3643, Name = "VintageGoldChest", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Bone Chest"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/chest-bones-icon"<para/>
//		/// PlacenmentId: 3144<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BoneChest { get; } = new Item() { ID = 3644, Name = "BoneChest", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Damaged Safe"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/chest-titanium-icon"<para/>
//		/// PlacenmentId: 6059<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DamagedSafe { get; } = new Item() { ID = 3645, Name = "DamagedSafe", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Haworth"<para/>
//		/// Description: "A place to store your items."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/demon-chest-icon"<para/>
//		/// PlacenmentId: 3146<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorHaworth0 { get; } = new Item() { ID = 3646, Name = "InsectorHaworth0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Haworth"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/chest-sand&glass-icon"<para/>
//		/// PlacenmentId: 3147<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorHaworth1 { get; } = new Item() { ID = 3647, Name = "InsectorHaworth1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Bed"<para/>
//		/// Function: "A place where you can save as your respawn point."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 25<para/>
//		/// DropTexture: "Icon/bed-wood-icon"<para/>
//		/// PlacenmentId: 3151<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenBed { get; } = new Item() { ID = 3651, Name = "WoodenBed", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone Bed"<para/>
//		/// Function: "A place where you can save as your respawn point."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bed-stone-icon"<para/>
//		/// PlacenmentId: 3152<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneBed { get; } = new Item() { ID = 3652, Name = "StoneBed", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Bed"<para/>
//		/// Function: "A place where you can save as your respawn point."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bed-copper-icon"<para/>
//		/// PlacenmentId: 3153<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9011, 2 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperBed { get; } = new Item() { ID = 3653, Name = "CopperBed", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Bed"<para/>
//		/// Function: "A place where you can save as your respawn point."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bed-iron-icon"<para/>
//		/// PlacenmentId: 3154<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 2 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronBed { get; } = new Item() { ID = 3654, Name = "IronBed", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Bed"<para/>
//		/// Function: "A place where you can save as your respawn point."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bed-silver-icon"<para/>
//		/// PlacenmentId: 3155<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 2 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverBed { get; } = new Item() { ID = 3655, Name = "SilverBed", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Golden Bed"<para/>
//		/// Function: "A place where you can save as your respawn point."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bed-gold-icon"<para/>
//		/// PlacenmentId: 3156<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 2 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldenBed { get; } = new Item() { ID = 3656, Name = "GoldenBed", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Hibernation Pod"<para/>
//		/// Function: "A place where you can save as your respawn point."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3157<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item HibernationPod { get; } = new Item() { ID = 3657, Name = "HibernationPod", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Dirt Bed"<para/>
//		/// Function: "A place where you can save as your respawn point."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bed-earth-icon"<para/>
//		/// PlacenmentId: 3158<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DirtBed { get; } = new Item() { ID = 3658, Name = "DirtBed", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Snow Bed"<para/>
//		/// Function: "A place where you can save as your respawn point."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bed-snow-icon"<para/>
//		/// PlacenmentId: 3159<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SnowBed { get; } = new Item() { ID = 3659, Name = "SnowBed", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin Bed"<para/>
//		/// Function: "A place where you can save as your respawn point."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bed-earth&bones-icon"<para/>
//		/// PlacenmentId: 3160<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinBed { get; } = new Item() { ID = 3660, Name = "GoblinBed", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Vintage Copper Door"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 15<para/>
//		/// DropTexture: "Icon/door-wood&copper-icon"<para/>
//		/// PlacenmentId: 3161<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item VintageCopperDoor { get; } = new Item() { ID = 3661, Name = "VintageCopperDoor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Vintage Iron Door"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 15<para/>
//		/// DropTexture: "Icon/door-wood&iron-icon"<para/>
//		/// PlacenmentId: 3162<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item VintageIronDoor { get; } = new Item() { ID = 3662, Name = "VintageIronDoor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Vintage Silver Door"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 15<para/>
//		/// DropTexture: "Icon/door-wood&silver-icon"<para/>
//		/// PlacenmentId: 3163<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item VintageSilverDoor { get; } = new Item() { ID = 3663, Name = "VintageSilverDoor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Vintage Golden Door"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 15<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3164<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item VintageGoldenDoor { get; } = new Item() { ID = 3664, Name = "VintageGoldenDoor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Dirt Door"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/door-earth-icon"<para/>
//		/// PlacenmentId: 3165<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DirtDoor { get; } = new Item() { ID = 3665, Name = "DirtDoor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Titanium Door"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-door-icon"<para/>
//		/// PlacenmentId: 3168<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item TitaniumDoor { get; } = new Item() { ID = 3666, Name = "TitaniumDoor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Bone Door"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/door-bones-icon"<para/>
//		/// PlacenmentId: 3167<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BoneDoor0 { get; } = new Item() { ID = 3667, Name = "BoneDoor0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Bone Door"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/door-sand&glass-icon"<para/>
//		/// PlacenmentId: 3169<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BoneDoor1 { get; } = new Item() { ID = 3669, Name = "BoneDoor1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Snowman"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3201<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Snowman { get; } = new Item() { ID = 3701, Name = "Snowman", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clay Flower Pot"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/flowerpot-pottery"<para/>
//		/// PlacenmentId: 3211<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 3717, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ClayFlowerPot { get; } = new Item() { ID = 3711, Name = "ClayFlowerPot", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clay Bottle"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3212<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 3718, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ClayBottle { get; } = new Item() { ID = 3712, Name = "ClayBottle", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clay Jar"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3213<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 3719, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ClayJar { get; } = new Item() { ID = 3713, Name = "ClayJar", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Glass Flower Pot"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3214<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GlassFlowerPot { get; } = new Item() { ID = 3714, Name = "GlassFlowerPot", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Glass Bottle"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3215<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GlassBottle { get; } = new Item() { ID = 3715, Name = "GlassBottle", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Glass Jar"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3216<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GlassJar { get; } = new Item() { ID = 3716, Name = "GlassJar", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Ceramic Flower Pot"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3217<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CeramicFlowerPot { get; } = new Item() { ID = 3717, Name = "CeramicFlowerPot", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Ceramic Bottle"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3218<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CeramicBottle { get; } = new Item() { ID = 3718, Name = "CeramicBottle", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Ceramic Jar"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3219<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CeramicJar { get; } = new Item() { ID = 3719, Name = "CeramicJar", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clay Sculpture"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3220<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 3722, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ClaySculpture { get; } = new Item() { ID = 3720, Name = "ClaySculpture", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Glass Sculpture"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3221<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GlassSculpture { get; } = new Item() { ID = 3721, Name = "GlassSculpture", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Ceramic Sculpture"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3222<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CeramicSculpture { get; } = new Item() { ID = 3722, Name = "CeramicSculpture", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Flower Pot"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/flowerpot-earth"<para/>
//		/// PlacenmentId: 3223<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item FlowerPot { get; } = new Item() { ID = 3723, Name = "FlowerPot", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Bottle"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3224<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Bottle { get; } = new Item() { ID = 3724, Name = "Bottle", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Jar"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3225<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Jar { get; } = new Item() { ID = 3725, Name = "Jar", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Sculpture"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3226<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Sculpture { get; } = new Item() { ID = 3726, Name = "Sculpture", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Model"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/model-wood-icon"<para/>
//		/// PlacenmentId: 3231<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenModel0 { get; } = new Item() { ID = 3731, Name = "WoodenModel0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Bone Flower Pot"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/flowerpot-bones"<para/>
//		/// PlacenmentId: 3241<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BoneFlowerPot { get; } = new Item() { ID = 3741, Name = "BoneFlowerPot", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Barrel"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3251<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Barrel0 { get; } = new Item() { ID = 3751, Name = "Barrel0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Barrel"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3252<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Barrel1 { get; } = new Item() { ID = 3752, Name = "Barrel1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Barrel"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 25<para/>
//		/// DropTexture: "Icon/cask-wood-icon"<para/>
//		/// PlacenmentId: 3253<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Barrel2 { get; } = new Item() { ID = 3753, Name = "Barrel2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Table"<para/>
//		/// Description: "A table that can be combined with one another."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 25<para/>
//		/// DropTexture: "Icon/barcounter-wood-icon"<para/>
//		/// PlacenmentId: 3261<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenTable0 { get; } = new Item() { ID = 3761, Name = "WoodenTable0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone Table"<para/>
//		/// Description: "A table that can be combined with one another."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3262<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneTable { get; } = new Item() { ID = 3762, Name = "StoneTable", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Table"<para/>
//		/// Description: "A table that can be combined with one another."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/barcounter-copper-icon"<para/>
//		/// PlacenmentId: 3263<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9011, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperTable { get; } = new Item() { ID = 3763, Name = "CopperTable", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Table"<para/>
//		/// Description: "A table that can be combined with one another."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/barcounter-iron-icon"<para/>
//		/// PlacenmentId: 3264<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronTable { get; } = new Item() { ID = 3764, Name = "IronTable", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Table"<para/>
//		/// Description: "A table that can be combined with one another."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/barcounter-silver-icon"<para/>
//		/// PlacenmentId: 3265<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverTable { get; } = new Item() { ID = 3765, Name = "SilverTable", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Golden Table"<para/>
//		/// Description: "A table that can be combined with one another."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/barcounter-gold-icon"<para/>
//		/// PlacenmentId: 3266<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 1 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldenTable { get; } = new Item() { ID = 3766, Name = "GoldenTable", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Table"<para/>
//		/// Description: "A table that can be combined with one another."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/barcounter-meco-icon"<para/>
//		/// PlacenmentId: 3267<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoTable { get; } = new Item() { ID = 3767, Name = "MecoTable", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Explosive Barrel"<para/>
//		/// Function: "It will cause 40 damage in the area around once it is exploded."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 46<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/cask-powder-icon"<para/>
//		/// PlacenmentId: 3271<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ExplosiveBarrel { get; } = new Item() { ID = 3771, Name = "ExplosiveBarrel", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Feeding Trough"<para/>
//		/// Function: "A place to feed your animals. They will breed once they are full."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 50<para/>
//		/// DropTexture: "Icon/feedingtrough-wood-icon"<para/>
//		/// PlacenmentId: 3281<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenFeedingTrough { get; } = new Item() { ID = 3781, Name = "WoodenFeedingTrough", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone Feeding Trough"<para/>
//		/// Function: "A place to feed your animals. They will breed once they are full."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 3282<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo3"<para/>
//		/// MouseRight: "MouseRightClickInfo3"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneFeedingTrough { get; } = new Item() { ID = 3782, Name = "StoneFeedingTrough", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Feeding Trough"<para/>
//		/// Function: "A place to feed your animals. They will breed once they are full."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/feedingtrough-copper-icon"<para/>
//		/// PlacenmentId: 3283<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9011, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo4"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperFeedingTrough { get; } = new Item() { ID = 3783, Name = "CopperFeedingTrough", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Feeding Trough"<para/>
//		/// Function: "A place to feed your animals. They will breed once they are full."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/feedingtrough-iron-icon"<para/>
//		/// PlacenmentId: 3284<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9012, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo5"<para/>
//		/// MouseRight: "MouseRightClickInfo5"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronFeedingTrough { get; } = new Item() { ID = 3784, Name = "IronFeedingTrough", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Feeding Trough"<para/>
//		/// Function: "A place to feed your animals. They will breed once they are full."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/feedingtrough-silver-icon"<para/>
//		/// PlacenmentId: 3285<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo6"<para/>
//		/// MouseRight: "MouseRightClickInfo6"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverFeedingTrough { get; } = new Item() { ID = 3785, Name = "SilverFeedingTrough", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Golden Feeding Trough"<para/>
//		/// Function: "A place to feed your animals. They will breed once they are full."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/feedingtrough-gold-icon"<para/>
//		/// PlacenmentId: 3286<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 3 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo7"<para/>
//		/// MouseRight: "MouseRightClickInfo7"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldenFeedingTrough { get; } = new Item() { ID = 3786, Name = "GoldenFeedingTrough", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 25<para/>
//		/// DropTexture: "Icon/barcounter-wood-icon"<para/>
//		/// PlacenmentId: 3291<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenTable1 { get; } = new Item() { ID = 3791, Name = "WoodenTable1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Model"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 25<para/>
//		/// DropTexture: "Icon/model-wood-icon"<para/>
//		/// PlacenmentId: 3292<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenModel1 { get; } = new Item() { ID = 3792, Name = "WoodenModel1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 25<para/>
//		/// DropTexture: "Icon/barcounter-meco-icon"<para/>
//		/// PlacenmentId: 3293<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenTable2 { get; } = new Item() { ID = 3793, Name = "WoodenTable2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 25<para/>
//		/// DropTexture: "Icon/GoodsShelves1-icon"<para/>
//		/// PlacenmentId: 3294<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenTable3 { get; } = new Item() { ID = 3794, Name = "WoodenTable3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 25<para/>
//		/// DropTexture: "Icon/GoodsShelves1-icon"<para/>
//		/// PlacenmentId: 3295<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenTable4 { get; } = new Item() { ID = 3795, Name = "WoodenTable4", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 25<para/>
//		/// DropTexture: "Icon/GoodsShelves2-icon"<para/>
//		/// PlacenmentId: 3296<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenTable5 { get; } = new Item() { ID = 3796, Name = "WoodenTable5", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 25<para/>
//		/// DropTexture: "Icon/barcounter-wood-icon"<para/>
//		/// PlacenmentId: 3297<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenTable6 { get; } = new Item() { ID = 3797, Name = "WoodenTable6", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 25<para/>
//		/// DropTexture: "Icon/barcounter-wood-icon"<para/>
//		/// PlacenmentId: 3298<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenTable7 { get; } = new Item() { ID = 3798, Name = "WoodenTable7", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 25<para/>
//		/// DropTexture: "Icon/GoodsShelves2-icon"<para/>
//		/// PlacenmentId: 3299<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenTable8 { get; } = new Item() { ID = 3799, Name = "WoodenTable8", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 25<para/>
//		/// DropTexture: "Icon/GoodsShelves2-icon"<para/>
//		/// PlacenmentId: 3300<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenTable9 { get; } = new Item() { ID = 3800, Name = "WoodenTable9", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Hibernation Pot"<para/>
//		/// Function: "A place where you can save as your respawn point."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-hibernation-pod-icon"<para/>
//		/// PlacenmentId: 3301<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoHibernationPot { get; } = new Item() { ID = 3801, Name = "MecoHibernationPot", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Lamp"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-light-icon"<para/>
//		/// PlacenmentId: 3311<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoLamp { get; } = new Item() { ID = 3811, Name = "MecoLamp", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Portal"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-titaniumportal-icon"<para/>
//		/// PlacenmentId: 3321<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoPortal { get; } = new Item() { ID = 3821, Name = "MecoPortal", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Crystal sand bed"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bed-sand&glass-icon"<para/>
//		/// PlacenmentId: 3331<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CrystalSandBed { get; } = new Item() { ID = 3831, Name = "CrystalSandBed", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Grounder Tent"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bed-grounder-icon"<para/>
//		/// PlacenmentId: 3332<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 2 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GrounderTent { get; } = new Item() { ID = 3832, Name = "GrounderTent", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Crystal sand stool"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/chair-sand&glass-icon"<para/>
//		/// PlacenmentId: 3341<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CrystalSandStool { get; } = new Item() { ID = 3841, Name = "CrystalSandStool", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Crystal sand round table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/roundtable-sand&glass-icon"<para/>
//		/// PlacenmentId: 3351<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CrystalSandRoundTable { get; } = new Item() { ID = 3851, Name = "CrystalSandRoundTable", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Crystal sand base torch"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/torch-sand&glass-tall-icon"<para/>
//		/// PlacenmentId: 3361<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CrystalSandBaseTorch { get; } = new Item() { ID = 3861, Name = "CrystalSandBaseTorch", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Miner Simple Lift"<para/>
//		/// Function: "A device that allows you to quickly travel between the surface and the undergrounds."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/Elevator1-icon"<para/>
//		/// PlacenmentId: 3371<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MinerSimpleLift { get; } = new Item() { ID = 3871, Name = "MinerSimpleLift", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Miner Simple Lift Part"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/error-item"<para/>
//		/// PlacenmentId: 3372<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MinerSimpleLiftPart { get; } = new Item() { ID = 3872, Name = "MinerSimpleLiftPart", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Insector Harvester"<para/>
//		/// Function: "Use it to collect all the crops around,gathering speed increase by 100%."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/demon-harvester-copper-icon"<para/>
//		/// PlacenmentId: 3381<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperInsectorHarvester { get; } = new Item() { ID = 3881, Name = "CopperInsectorHarvester", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Insector Harvester"<para/>
//		/// Function: "Use it to collect all the crops around,gathering speed increase by 130%."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/demon-harvester-iron-icon"<para/>
//		/// PlacenmentId: 3382<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronInsectorHarvester { get; } = new Item() { ID = 3882, Name = "IronInsectorHarvester", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Insector Harvester"<para/>
//		/// Function: "Use it to collect all the crops around,gathering speed increase by 160%."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/demon-harvester-silver-icon"<para/>
//		/// PlacenmentId: 3383<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverInsectorHarvester { get; } = new Item() { ID = 3883, Name = "SilverInsectorHarvester", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Golden Insector Harvester"<para/>
//		/// Function: "Use it to collect all the crops around,gathering speed increase by 200%."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/demon-harvester-gold-icon"<para/>
//		/// PlacenmentId: 3384<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldenInsectorHarvester { get; } = new Item() { ID = 3884, Name = "GoldenInsectorHarvester", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Target Dummy"<para/>
//		/// Function: "Damage value will show up when the dummy is being attacked. Dummy can wear armor items."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/model-DamageTestDummy-icon1"<para/>
//		/// PlacenmentId: 3391<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item TargetDummy0 { get; } = new Item() { ID = 3891, Name = "TargetDummy0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Target Dummy"<para/>
//		/// Function: "Damage value will show up when the dummy is being attacked. Dummy can wear armor items."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/model-DamageTestDummy-icon2"<para/>
//		/// PlacenmentId: 3392<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item TargetDummy1 { get; } = new Item() { ID = 3892, Name = "TargetDummy1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Target Dummy"<para/>
//		/// Function: "Damage value will show up when the dummy is being attacked. Dummy can wear armor items."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/model-DamageTestDummy-icon3"<para/>
//		/// PlacenmentId: 3393<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item TargetDummy2 { get; } = new Item() { ID = 3893, Name = "TargetDummy2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 25<para/>
//		/// DropTexture: "Icon/GoodsShelves2-icon"<para/>
//		/// PlacenmentId: 3401<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenTable10 { get; } = new Item() { ID = 3901, Name = "WoodenTable10", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 25<para/>
//		/// DropTexture: "Icon/GoodsShelves2-icon"<para/>
//		/// PlacenmentId: 3402<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenTable11 { get; } = new Item() { ID = 3902, Name = "WoodenTable11", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Table"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 25<para/>
//		/// DropTexture: "Icon/barcounter-wood-icon"<para/>
//		/// PlacenmentId: 3403<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenTable12 { get; } = new Item() { ID = 3903, Name = "WoodenTable12", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "BeeHive"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/BeeHive-icon"<para/>
//		/// PlacenmentId: 3411<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Beehive { get; } = new Item() { ID = 3911, Name = "Beehive", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 10<para/>
//		/// DropTexture: "Icon/floor-wood1-icon"<para/>
//		/// PlacenmentId: 5001<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenFloor0 { get; } = new Item() { ID = 5001, Name = "WoodenFloor0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 10<para/>
//		/// DropTexture: "Icon/floor-wood2-icon"<para/>
//		/// PlacenmentId: 5002<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenFloor1 { get; } = new Item() { ID = 5002, Name = "WoodenFloor1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 10<para/>
//		/// DropTexture: "Icon/floor-wood3-icon"<para/>
//		/// PlacenmentId: 5003<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenFloor2 { get; } = new Item() { ID = 5003, Name = "WoodenFloor2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 10<para/>
//		/// DropTexture: "Icon/floor-wood4-icon"<para/>
//		/// PlacenmentId: 5004<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenFloor3 { get; } = new Item() { ID = 5004, Name = "WoodenFloor3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Dirt Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-earth1-icon"<para/>
//		/// PlacenmentId: 5005<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DirtFloor0 { get; } = new Item() { ID = 5005, Name = "DirtFloor0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Dirt Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-earth2-icon"<para/>
//		/// PlacenmentId: 5006<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DirtFloor1 { get; } = new Item() { ID = 5006, Name = "DirtFloor1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-stone1-icon"<para/>
//		/// PlacenmentId: 5007<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneFloor0 { get; } = new Item() { ID = 5007, Name = "StoneFloor0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-stone2-icon"<para/>
//		/// PlacenmentId: 5008<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneFloor1 { get; } = new Item() { ID = 5008, Name = "StoneFloor1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-stone3-icon"<para/>
//		/// PlacenmentId: 5009<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneFloor2 { get; } = new Item() { ID = 5009, Name = "StoneFloor2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-stone4-icon"<para/>
//		/// PlacenmentId: 5010<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneFloor3 { get; } = new Item() { ID = 5010, Name = "StoneFloor3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-stone5-icon"<para/>
//		/// PlacenmentId: 5011<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneFloor4 { get; } = new Item() { ID = 5011, Name = "StoneFloor4", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-copper1-icon"<para/>
//		/// PlacenmentId: 5012<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperFloor0 { get; } = new Item() { ID = 5012, Name = "CopperFloor0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-copper2-icon"<para/>
//		/// PlacenmentId: 5013<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperFloor1 { get; } = new Item() { ID = 5013, Name = "CopperFloor1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-iron1-icon"<para/>
//		/// PlacenmentId: 5014<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronFloor0 { get; } = new Item() { ID = 5014, Name = "IronFloor0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-iron2-icon"<para/>
//		/// PlacenmentId: 5015<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronFloor1 { get; } = new Item() { ID = 5015, Name = "IronFloor1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-iron3-icon"<para/>
//		/// PlacenmentId: 5016<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronFloor2 { get; } = new Item() { ID = 5016, Name = "IronFloor2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-iron4-icon"<para/>
//		/// PlacenmentId: 5017<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronFloor3 { get; } = new Item() { ID = 5017, Name = "IronFloor3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-silver1-icon"<para/>
//		/// PlacenmentId: 5018<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverFloor0 { get; } = new Item() { ID = 5018, Name = "SilverFloor0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-silver2-icon"<para/>
//		/// PlacenmentId: 5019<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverFloor1 { get; } = new Item() { ID = 5019, Name = "SilverFloor1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Gold Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-gold1-icon"<para/>
//		/// PlacenmentId: 5020<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldFloor0 { get; } = new Item() { ID = 5020, Name = "GoldFloor0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Gold Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-gold2-icon"<para/>
//		/// PlacenmentId: 5021<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldFloor1 { get; } = new Item() { ID = 5021, Name = "GoldFloor1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Gold Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-gold3-icon"<para/>
//		/// PlacenmentId: 5022<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldFloor2 { get; } = new Item() { ID = 5022, Name = "GoldFloor2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Gold Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-gold4-icon"<para/>
//		/// PlacenmentId: 5023<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldFloor3 { get; } = new Item() { ID = 5023, Name = "GoldFloor3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Glass Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-glass1-icon"<para/>
//		/// PlacenmentId: 5024<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GlassFloor { get; } = new Item() { ID = 5024, Name = "GlassFloor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Snow Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-snow1-icon"<para/>
//		/// PlacenmentId: 5025<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SnowFloor { get; } = new Item() { ID = 5025, Name = "SnowFloor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Ice Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-ice1-icon"<para/>
//		/// PlacenmentId: 5026<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IceFloor { get; } = new Item() { ID = 5026, Name = "IceFloor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Sand Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-sand1-icon"<para/>
//		/// PlacenmentId: 5027<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SandFloor { get; } = new Item() { ID = 5027, Name = "SandFloor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-stone7-icon"<para/>
//		/// PlacenmentId: 5028<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneFloor5 { get; } = new Item() { ID = 5028, Name = "StoneFloor5", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Stone Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-mecobiology1-icon"<para/>
//		/// PlacenmentId: 5029<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item StoneFloor6 { get; } = new Item() { ID = 5029, Name = "StoneFloor6", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Wooden Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-wood1-icon"<para/>
//		/// PlacenmentId: 5501<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldWoodenFloor0 { get; } = new Item() { ID = 5501, Name = "OldWoodenFloor0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Wooden Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-wood2-icon"<para/>
//		/// PlacenmentId: 5502<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldWoodenFloor1 { get; } = new Item() { ID = 5502, Name = "OldWoodenFloor1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Wooden Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-wood3-icon"<para/>
//		/// PlacenmentId: 5503<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldWoodenFloor2 { get; } = new Item() { ID = 5503, Name = "OldWoodenFloor2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Wooden Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-wood4-icon"<para/>
//		/// PlacenmentId: 5504<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldWoodenFloor3 { get; } = new Item() { ID = 5504, Name = "OldWoodenFloor3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Dirt Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-earth1-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldDirtFloor0 { get; } = new Item() { ID = 5505, Name = "OldDirtFloor0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Dirt Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-earth2-icon"<para/>
//		/// PlacenmentId: 5506<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldDirtFloor1 { get; } = new Item() { ID = 5506, Name = "OldDirtFloor1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Stone Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-stone1-icon"<para/>
//		/// PlacenmentId: 5507<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldStoneFloor0 { get; } = new Item() { ID = 5507, Name = "OldStoneFloor0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Stone Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-stone2-icon"<para/>
//		/// PlacenmentId: 5508<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldStoneFloor1 { get; } = new Item() { ID = 5508, Name = "OldStoneFloor1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Stone Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-stone3-icon"<para/>
//		/// PlacenmentId: 5509<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldStoneFloor2 { get; } = new Item() { ID = 5509, Name = "OldStoneFloor2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Stone Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-stone4-icon"<para/>
//		/// PlacenmentId: 5510<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldStoneFloor3 { get; } = new Item() { ID = 5510, Name = "OldStoneFloor3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Stone Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-stone5-icon"<para/>
//		/// PlacenmentId: 5511<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldStoneFloor4 { get; } = new Item() { ID = 5511, Name = "OldStoneFloor4", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Copper Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-copper1-icon"<para/>
//		/// PlacenmentId: 5512<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldCopperFloor0 { get; } = new Item() { ID = 5512, Name = "OldCopperFloor0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Copper Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-copper2-icon"<para/>
//		/// PlacenmentId: 5513<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldCopperFloor1 { get; } = new Item() { ID = 5513, Name = "OldCopperFloor1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Iron Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-iron1-icon"<para/>
//		/// PlacenmentId: 5514<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldIronFloor0 { get; } = new Item() { ID = 5514, Name = "OldIronFloor0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Iron Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-iron2-icon"<para/>
//		/// PlacenmentId: 5515<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldIronFloor1 { get; } = new Item() { ID = 5515, Name = "OldIronFloor1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Iron Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-iron3-icon"<para/>
//		/// PlacenmentId: 5516<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldIronFloor2 { get; } = new Item() { ID = 5516, Name = "OldIronFloor2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Iron Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-iron4-icon"<para/>
//		/// PlacenmentId: 5517<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldIronFloor3 { get; } = new Item() { ID = 5517, Name = "OldIronFloor3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Silver Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-silver1-icon"<para/>
//		/// PlacenmentId: 5518<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldSilverFloor0 { get; } = new Item() { ID = 5518, Name = "OldSilverFloor0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Silver Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-silver2-icon"<para/>
//		/// PlacenmentId: 5519<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldSilverFloor1 { get; } = new Item() { ID = 5519, Name = "OldSilverFloor1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Gold Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-gold1-icon"<para/>
//		/// PlacenmentId: 5520<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldGoldFloor0 { get; } = new Item() { ID = 5520, Name = "OldGoldFloor0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Gold Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-gold2-icon"<para/>
//		/// PlacenmentId: 5521<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldGoldFloor1 { get; } = new Item() { ID = 5521, Name = "OldGoldFloor1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Gold Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-gold3-icon"<para/>
//		/// PlacenmentId: 5522<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldGoldFloor2 { get; } = new Item() { ID = 5522, Name = "OldGoldFloor2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Gold Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-gold4-icon"<para/>
//		/// PlacenmentId: 5523<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldGoldFloor3 { get; } = new Item() { ID = 5523, Name = "OldGoldFloor3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Glass Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-glass1-icon"<para/>
//		/// PlacenmentId: 5524<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldGlassFloor { get; } = new Item() { ID = 5524, Name = "OldGlassFloor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Snow Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-snow1-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldSnowFloor { get; } = new Item() { ID = 5525, Name = "OldSnowFloor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Ice Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-ice1-icon"<para/>
//		/// PlacenmentId: 5526<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldIceFloor { get; } = new Item() { ID = 5526, Name = "OldIceFloor", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Sand Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-sand1-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldSandFloor0 { get; } = new Item() { ID = 5527, Name = "OldSandFloor0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Sand Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-mecobiology2-icon"<para/>
//		/// PlacenmentId: 5536<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldSandFloor1 { get; } = new Item() { ID = 5528, Name = "OldSandFloor1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Sand Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-mecobiology3-icon"<para/>
//		/// PlacenmentId: 5537<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldSandFloor2 { get; } = new Item() { ID = 5529, Name = "OldSandFloor2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Old Sand Floor"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 45<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/floor-mecobiology4-icon"<para/>
//		/// PlacenmentId: 5538<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item OldSandFloor3 { get; } = new Item() { ID = 5530, Name = "OldSandFloor3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Bone Cage"<para/>
//		/// Description: "An item used to capture animals and hostile creatures."<para/>
//		/// Type: 7<para/>
//		/// ItemType: 54<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bonecage-01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo6"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BoneCage0 { get; } = new Item() { ID = 6301, Name = "BoneCage0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Bone Cage"<para/>
//		/// Description: "A caged animal. Use it to release the animal."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 55<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bonecage-02-icon"<para/>
//		/// PlacenmentId: 6302<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BoneCage1 { get; } = new Item() { ID = 6302, Name = "BoneCage1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Bone Cage"<para/>
//		/// Description: "A caged hostile creature. Use it to release the hostile creature."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 55<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bonecage-03-icon"<para/>
//		/// PlacenmentId: 6302<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BoneCage2 { get; } = new Item() { ID = 6303, Name = "BoneCage2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Bone Cage"<para/>
//		/// Description: "A caged animal. Use it to release the animal."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 59<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bonecage-02-icon"<para/>
//		/// PlacenmentId: 6302<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BoneCage3 { get; } = new Item() { ID = 6304, Name = "BoneCage3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Nest"<para/>
//		/// Description: "A place for insectors to hatch out."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/demon-evilegg3-icon"<para/>
//		/// PlacenmentId: 7301<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorNest0 { get; } = new Item() { ID = 7301, Name = "InsectorNest0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Nest"<para/>
//		/// Description: "A place for insectors to hatch out."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bed-grounder-icon"<para/>
//		/// PlacenmentId: 7305<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorNest1 { get; } = new Item() { ID = 7305, Name = "InsectorNest1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Cross Laser Trap"<para/>
//		/// Description: "A place for insectors to hatch out."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-trap01-icon"<para/>
//		/// PlacenmentId: 7601<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoCrossLaserTrap { get; } = new Item() { ID = 7601, Name = "MecoCrossLaserTrap", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Spike Trap"<para/>
//		/// Description: "A place for insectors to hatch out."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-trap02-icon"<para/>
//		/// PlacenmentId: 7602<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoSpikeTrap { get; } = new Item() { ID = 7602, Name = "MecoSpikeTrap", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Spinning Blade Trap"<para/>
//		/// Description: "A place for insectors to hatch out."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-trap03-icon"<para/>
//		/// PlacenmentId: 7603<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoSpinningBladeTrap { get; } = new Item() { ID = 7603, Name = "MecoSpinningBladeTrap", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Wind Trap"<para/>
//		/// Description: "A place for insectors to hatch out."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-trap04-icon"<para/>
//		/// PlacenmentId: 7604<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoWindTrap { get; } = new Item() { ID = 7604, Name = "MecoWindTrap", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Mini Laser Turret"<para/>
//		/// Description: "A place for insectors to hatch out."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-trap05-icon"<para/>
//		/// PlacenmentId: 7605<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoMiniLaserTurret { get; } = new Item() { ID = 7605, Name = "MecoMiniLaserTurret", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Nest"<para/>
//		/// Description: "A place for insectors to hatch out."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-trap03-icon"<para/>
//		/// PlacenmentId: 7606<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorNest2 { get; } = new Item() { ID = 7606, Name = "InsectorNest2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Nest"<para/>
//		/// Description: "A place for insectors to hatch out."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-trap01-icon"<para/>
//		/// PlacenmentId: 7607<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorNest3 { get; } = new Item() { ID = 7607, Name = "InsectorNest3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Nest"<para/>
//		/// Description: "A place for insectors to hatch out."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-trap02-icon"<para/>
//		/// PlacenmentId: 7608<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorNest4 { get; } = new Item() { ID = 7608, Name = "InsectorNest4", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Nest"<para/>
//		/// Description: "A place for insectors to hatch out."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-trap03-icon"<para/>
//		/// PlacenmentId: 7609<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorNest5 { get; } = new Item() { ID = 7609, Name = "InsectorNest5", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Nest"<para/>
//		/// Description: "A place for insectors to hatch out."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-trap04-icon"<para/>
//		/// PlacenmentId: 7610<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorNest6 { get; } = new Item() { ID = 7610, Name = "InsectorNest6", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Nest"<para/>
//		/// Description: "A place for insectors to hatch out."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-trap05-icon"<para/>
//		/// PlacenmentId: 7611<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorNest7 { get; } = new Item() { ID = 7611, Name = "InsectorNest7", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Nest"<para/>
//		/// Description: "A place for insectors to hatch out."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-trap03-icon"<para/>
//		/// PlacenmentId: 7612<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorNest8 { get; } = new Item() { ID = 7612, Name = "InsectorNest8", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Nest"<para/>
//		/// Description: "A place for insectors to hatch out."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-trap01-icon"<para/>
//		/// PlacenmentId: 7613<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorNest9 { get; } = new Item() { ID = 7613, Name = "InsectorNest9", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Nest"<para/>
//		/// Description: "A place for insectors to hatch out."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-trap01-icon"<para/>
//		/// PlacenmentId: 7614<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorNest10 { get; } = new Item() { ID = 7614, Name = "InsectorNest10", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Nest"<para/>
//		/// Description: "A place for insectors to hatch out."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-trap03-icon"<para/>
//		/// PlacenmentId: 7615<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorNest11 { get; } = new Item() { ID = 7615, Name = "InsectorNest11", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Nest"<para/>
//		/// Description: "A place for insectors to hatch out."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-trap03-icon"<para/>
//		/// PlacenmentId: 7616<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo3"<para/>
//		/// MouseRight: "MouseRightClickInfo3"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorNest12 { get; } = new Item() { ID = 7616, Name = "InsectorNest12", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Nest"<para/>
//		/// Description: "A place for insectors to hatch out."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-trap03-icon"<para/>
//		/// PlacenmentId: 7617<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo4"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorNest13 { get; } = new Item() { ID = 7617, Name = "InsectorNest13", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Nest"<para/>
//		/// Description: "A place for insectors to hatch out."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-trap03-icon"<para/>
//		/// PlacenmentId: 7618<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo5"<para/>
//		/// MouseRight: "MouseRightClickInfo5"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorNest14 { get; } = new Item() { ID = 7618, Name = "InsectorNest14", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Nest"<para/>
//		/// Description: "A place for insectors to hatch out."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-trap03-icon"<para/>
//		/// PlacenmentId: 7619<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo6"<para/>
//		/// MouseRight: "MouseRightClickInfo6"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorNest15 { get; } = new Item() { ID = 7619, Name = "InsectorNest15", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Tenergy Station"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 88<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-generator-icon"<para/>
//		/// PlacenmentId: 7621<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoTenergyStation { get; } = new Item() { ID = 7621, Name = "MecoTenergyStation", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Punji Sticks"<para/>
//		/// Function: "It will cause a bleeding (losing 2 HP for every second, lasts for 5 seconds) and 8 damage to anyone who is passing through. This trap itself is very vulnerable."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/punjisticks-wood-icon"<para/>
//		/// PlacenmentId: 7631<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item PunjiSticks { get; } = new Item() { ID = 7631, Name = "PunjiSticks", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin Bear Trap"<para/>
//		/// Function: "It will trap, and cause a bleeding (losing 1 HP for every second, lasts for 5 seconds) and 3 damage to anyone who is passing through."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/gobin-bear-trap-icon"<para/>
//		/// PlacenmentId: 7632<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinBearTrap { get; } = new Item() { ID = 7632, Name = "GoblinBearTrap", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Poisonous Sac Trap"<para/>
//		/// Function: "It occasionally emits a poisonous gas that can cause a damage to anyone who touches it for up to 48 damage."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/demon-poisonous-sac-trap-icon"<para/>
//		/// PlacenmentId: 7633<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item PoisonousSacTrap { get; } = new Item() { ID = 7633, Name = "PoisonousSacTrap", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Grounder Landmine"<para/>
//		/// Function: "It will explode when someone is passing through, and cause 60 damage in the area around once it is exploded."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 62<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/grounder-landmine-icon"<para/>
//		/// PlacenmentId: 7634<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GrounderLandmine { get; } = new Item() { ID = 7634, Name = "GrounderLandmine", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin decoration"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6088<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinDecoration0 { get; } = new Item() { ID = 8001, Name = "GoblinDecoration0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin decoration"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6089<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinDecoration1 { get; } = new Item() { ID = 8002, Name = "GoblinDecoration1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin decoration"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6090<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinDecoration2 { get; } = new Item() { ID = 8003, Name = "GoblinDecoration2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin decoration"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6091<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinDecoration3 { get; } = new Item() { ID = 8004, Name = "GoblinDecoration3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin decoration"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6092<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinDecoration4 { get; } = new Item() { ID = 8005, Name = "GoblinDecoration4", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin decoration"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6093<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinDecoration5 { get; } = new Item() { ID = 8006, Name = "GoblinDecoration5", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin decoration"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6094<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinDecoration6 { get; } = new Item() { ID = 8007, Name = "GoblinDecoration6", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin decoration"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6095<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinDecoration7 { get; } = new Item() { ID = 8008, Name = "GoblinDecoration7", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin decoration"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6096<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinDecoration8 { get; } = new Item() { ID = 8009, Name = "GoblinDecoration8", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin decoration"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6097<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinDecoration9 { get; } = new Item() { ID = 8010, Name = "GoblinDecoration9", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Worm nest BOSS"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/InsectQueen-icon"<para/>
//		/// PlacenmentId: 8001<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WormNestBOSS { get; } = new Item() { ID = 8011, Name = "WormNestBOSS", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco structure computer"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-computer01-icon"<para/>
//		/// PlacenmentId: 8012<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoStructureComputer { get; } = new Item() { ID = 8012, Name = "MecoStructureComputer", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco structure computer oblique"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-computer02-icon"<para/>
//		/// PlacenmentId: 8013<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoStructureComputerOblique { get; } = new Item() { ID = 8013, Name = "MecoStructureComputerOblique", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Biological Research Sample"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-container-mecobiology1-icon"<para/>
//		/// PlacenmentId: 8014<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoBiologicalResearchSample { get; } = new Item() { ID = 8014, Name = "MecoBiologicalResearchSample", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco biological research sample broken"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-container-mecobiology2-icon"<para/>
//		/// PlacenmentId: 8015<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoBiologicalResearchSampleBroken { get; } = new Item() { ID = 8015, Name = "MecoBiologicalResearchSampleBroken", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Pipeline 1"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6138<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoPipeline1 { get; } = new Item() { ID = 8017, Name = "MecoPipeline1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Pipeline 2"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6139<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoPipeline2 { get; } = new Item() { ID = 8018, Name = "MecoPipeline2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Pipeline 3"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6140<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoPipeline3 { get; } = new Item() { ID = 8019, Name = "MecoPipeline3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Pipeline 4"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6141<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoPipeline4 { get; } = new Item() { ID = 8020, Name = "MecoPipeline4", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Pipeline 5"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6142<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoPipeline5 { get; } = new Item() { ID = 8021, Name = "MecoPipeline5", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Pipeline 6"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6143<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoPipeline6 { get; } = new Item() { ID = 8022, Name = "MecoPipeline6", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Pipeline 7"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6144<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoPipeline7 { get; } = new Item() { ID = 8023, Name = "MecoPipeline7", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Pipeline 8"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6145<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoPipeline8 { get; } = new Item() { ID = 8024, Name = "MecoPipeline8", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Pipeline 9"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6146<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoPipeline9 { get; } = new Item() { ID = 8025, Name = "MecoPipeline9", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Pipeline 10"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6147<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoPipeline10 { get; } = new Item() { ID = 8026, Name = "MecoPipeline10", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Pipeline 11"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6148<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoPipeline11 { get; } = new Item() { ID = 8027, Name = "MecoPipeline11", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Pipeline 12"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6149<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoPipeline12 { get; } = new Item() { ID = 8028, Name = "MecoPipeline12", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Pipeline 13"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6150<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoPipeline13 { get; } = new Item() { ID = 8029, Name = "MecoPipeline13", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Pipeline 14"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6151<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoPipeline14 { get; } = new Item() { ID = 8030, Name = "MecoPipeline14", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Pipeline 15"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6152<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoPipeline15 { get; } = new Item() { ID = 8031, Name = "MecoPipeline15", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Pipeline 16"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6153<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoPipeline16 { get; } = new Item() { ID = 8032, Name = "MecoPipeline16", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "server"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-generator-icon"<para/>
//		/// PlacenmentId: 8017<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Server { get; } = new Item() { ID = 8033, Name = "Server", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Server-stop"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-generator-icon"<para/>
//		/// PlacenmentId: 8018<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ServerStop { get; } = new Item() { ID = 8034, Name = "ServerStop", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Test tube 1"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-testtube-mecobiology1-icon"<para/>
//		/// PlacenmentId: 8019<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item TestTube1 { get; } = new Item() { ID = 8035, Name = "TestTube1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Test tube table 2"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-testtube-mecobiology2-icon"<para/>
//		/// PlacenmentId: 8020<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item TestTubeTable2 { get; } = new Item() { ID = 8036, Name = "TestTubeTable2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Host 1"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/Titanium-computer3-icon"<para/>
//		/// PlacenmentId: 8031<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoHost1 { get; } = new Item() { ID = 8037, Name = "MecoHost1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Host 2"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/Titanium-computer4-icon"<para/>
//		/// PlacenmentId: 8032<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoHost2 { get; } = new Item() { ID = 8038, Name = "MecoHost2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco host 3-off"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/Titanium-computer5-icon"<para/>
//		/// PlacenmentId: 8033<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoHost3Off { get; } = new Item() { ID = 8039, Name = "MecoHost3Off", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco host 3-open"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/Titanium-computer6-icon"<para/>
//		/// PlacenmentId: 8034<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoHost3Open { get; } = new Item() { ID = 8040, Name = "MecoHost3Open", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco host 1 - broken"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/Titanium-computer3-broken-icon"<para/>
//		/// PlacenmentId: 8035<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoHost1Broken { get; } = new Item() { ID = 8041, Name = "MecoHost1Broken", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco host 2 broken"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/Titanium-computer4-broken-icon"<para/>
//		/// PlacenmentId: 8036<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoHost2Broken { get; } = new Item() { ID = 8042, Name = "MecoHost2Broken", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco host 3 - broken"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/Titanium-computer5-broken-icon"<para/>
//		/// PlacenmentId: 8037<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoHost3Broken { get; } = new Item() { ID = 8043, Name = "MecoHost3Broken", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Infected Bio Meco Meat Pie 1"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6170<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InfectedBioMecoMeatPie1 { get; } = new Item() { ID = 8044, Name = "InfectedBioMecoMeatPie1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Infected Bio Meco Meat Pieces 2"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6171<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InfectedBioMecoMeatPieces2 { get; } = new Item() { ID = 8045, Name = "InfectedBioMecoMeatPieces2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Infected Bio Meco Meat Pieces 3"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6172<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InfectedBioMecoMeatPieces3 { get; } = new Item() { ID = 8046, Name = "InfectedBioMecoMeatPieces3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Infected Bio Meco Meat Pieces 4"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6173<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InfectedBioMecoMeatPieces4 { get; } = new Item() { ID = 8047, Name = "InfectedBioMecoMeatPieces4", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Infected Bio Meco Meat Pieces 5"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6174<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InfectedBioMecoMeatPieces5 { get; } = new Item() { ID = 8048, Name = "InfectedBioMecoMeatPieces5", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Infected Bio Meco Meat Pieces 6"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 6175<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InfectedBioMecoMeatPieces6 { get; } = new Item() { ID = 8049, Name = "InfectedBioMecoMeatPieces6", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Cabinet"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/cabinet1-icon"<para/>
//		/// PlacenmentId: 8101<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Cabinet0 { get; } = new Item() { ID = 8101, Name = "Cabinet0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Cabinet"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/cabinet2-icon"<para/>
//		/// PlacenmentId: 8102<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Cabinet1 { get; } = new Item() { ID = 8102, Name = "Cabinet1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Cabinet"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/cabinet3-icon"<para/>
//		/// PlacenmentId: 8103<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Cabinet2 { get; } = new Item() { ID = 8103, Name = "Cabinet2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Fireplace"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/fireplace-icon"<para/>
//		/// PlacenmentId: 8104<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Fireplace { get; } = new Item() { ID = 8104, Name = "Fireplace", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Medicine Cabinet"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/MedicineCabinet1-icon"<para/>
//		/// PlacenmentId: 8105<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MedicineCabinet { get; } = new Item() { ID = 8105, Name = "MedicineCabinet", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "First Aid Cabinet"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/MedicineCabinet2-icon"<para/>
//		/// PlacenmentId: 8106<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item FirstAidCabinet { get; } = new Item() { ID = 8106, Name = "FirstAidCabinet", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Two Seater Sofa"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/sofa1-icon"<para/>
//		/// PlacenmentId: 8201<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item TwoSeaterSofa0 { get; } = new Item() { ID = 8201, Name = "TwoSeaterSofa0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Single Seater Sofa"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/sofa2-icon"<para/>
//		/// PlacenmentId: 8202<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SingleSeaterSofa0 { get; } = new Item() { ID = 8202, Name = "SingleSeaterSofa0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Rocking Chair"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/RockingChair-icon"<para/>
//		/// PlacenmentId: 8203<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item RockingChair { get; } = new Item() { ID = 8203, Name = "RockingChair", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Two Seater Sofa"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/sofa3-icon"<para/>
//		/// PlacenmentId: 8204<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item TwoSeaterSofa1 { get; } = new Item() { ID = 8204, Name = "TwoSeaterSofa1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Single Seater Sofa"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/sofa4-icon"<para/>
//		/// PlacenmentId: 8205<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SingleSeaterSofa1 { get; } = new Item() { ID = 8205, Name = "SingleSeaterSofa1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Bear Skin Rug"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/carpet-bearblanket-icon"<para/>
//		/// PlacenmentId: 8251<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BearSkinRug { get; } = new Item() { ID = 8251, Name = "BearSkinRug", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goat Skin Rug"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/WoolCarpet-icon"<para/>
//		/// PlacenmentId: 8252<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoatSkinRug { get; } = new Item() { ID = 8252, Name = "GoatSkinRug", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Linen Rug"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/carpet-Linencarpet-icon"<para/>
//		/// PlacenmentId: 8253<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item LinenRug { get; } = new Item() { ID = 8253, Name = "LinenRug", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Shelf"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/GoodsShelves2-icon"<para/>
//		/// PlacenmentId: 8301<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronShelf { get; } = new Item() { ID = 8301, Name = "IronShelf", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Shelf"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/GoodsShelves1-icon"<para/>
//		/// PlacenmentId: 8302<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenShelf { get; } = new Item() { ID = 8302, Name = "WoodenShelf", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Square Flower Pot"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 15<para/>
//		/// DropTexture: "Icon/WoodenFlowerPot-icon"<para/>
//		/// PlacenmentId: 8303<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SquareFlowerPot { get; } = new Item() { ID = 8303, Name = "SquareFlowerPot", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Blacksmith Shop Signboard"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/sign-blacksmith-icon"<para/>
//		/// PlacenmentId: 8351<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BlacksmithShopSignboard { get; } = new Item() { ID = 8351, Name = "BlacksmithShopSignboard", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Farm Shop Signboard"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 303<para/>
//		/// DropTexture: "Icon/sign-farmer-icon"<para/>
//		/// PlacenmentId: 8352<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item FarmShopSignboard { get; } = new Item() { ID = 8352, Name = "FarmShopSignboard", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Restaurant Signboard"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/sign-restaurant-icon"<para/>
//		/// PlacenmentId: 8353<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item RestaurantSignboard { get; } = new Item() { ID = 8353, Name = "RestaurantSignboard", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Animal Store Signboard"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/sign-herdsman-icon"<para/>
//		/// PlacenmentId: 8354<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item AnimalStoreSignboard { get; } = new Item() { ID = 8354, Name = "AnimalStoreSignboard", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Furniture Store Signboard"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/sign-builder-icon"<para/>
//		/// PlacenmentId: 8355<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item FurnitureStoreSignboard { get; } = new Item() { ID = 8355, Name = "FurnitureStoreSignboard", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clinic Signboard"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/sign-clinic-icon"<para/>
//		/// PlacenmentId: 8356<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ClinicSignboard { get; } = new Item() { ID = 8356, Name = "ClinicSignboard", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Mining Shop Signboard"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/sign-mining-icon"<para/>
//		/// PlacenmentId: 8357<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MiningShopSignboard { get; } = new Item() { ID = 8357, Name = "MiningShopSignboard", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Haystack"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/Haystack1-icon"<para/>
//		/// PlacenmentId: 8401<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Haystack0 { get; } = new Item() { ID = 8401, Name = "Haystack0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Haystack"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/Haystack2-icon"<para/>
//		/// PlacenmentId: 8402<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Haystack1 { get; } = new Item() { ID = 8402, Name = "Haystack1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Haystack"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/Haystack3-icon"<para/>
//		/// PlacenmentId: 8403<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Haystack2 { get; } = new Item() { ID = 8403, Name = "Haystack2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Haystack"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/Haystack4-icon"<para/>
//		/// PlacenmentId: 8404<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Haystack3 { get; } = new Item() { ID = 8404, Name = "Haystack3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Haystack"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/Haystack5-icon"<para/>
//		/// PlacenmentId: 8405<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Haystack4 { get; } = new Item() { ID = 8405, Name = "Haystack4", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Haystack"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/Haystack6-icon"<para/>
//		/// PlacenmentId: 8406<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Haystack5 { get; } = new Item() { ID = 8406, Name = "Haystack5", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Simple Medical Bed"<para/>
//		/// Function: "A place where you can save as your respawn point."<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/bed-MedicalCare-icon"<para/>
//		/// PlacenmentId: 8451<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SimpleMedicalBed { get; } = new Item() { ID = 8451, Name = "SimpleMedicalBed", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Candle Holder"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/SideCupboard-icon"<para/>
//		/// PlacenmentId: 8601<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CandleHolder { get; } = new Item() { ID = 8601, Name = "CandleHolder", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Mining Rail"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/MineOrbit1-icon"<para/>
//		/// PlacenmentId: 8651<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MiningRail0 { get; } = new Item() { ID = 8651, Name = "MiningRail0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Mining Rail"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/MineOrbit2-icon"<para/>
//		/// PlacenmentId: 8652<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo3"<para/>
//		/// MouseRight: "MouseRightClickInfo3"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MiningRail1 { get; } = new Item() { ID = 8652, Name = "MiningRail1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Mining Rail"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/MineOrbit3-icon"<para/>
//		/// PlacenmentId: 8653<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo4"<para/>
//		/// MouseRight: "MouseRightClickInfo4"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MiningRail2 { get; } = new Item() { ID = 8653, Name = "MiningRail2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Mining Rail"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/MineOrbit4-icon"<para/>
//		/// PlacenmentId: 8654<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo5"<para/>
//		/// MouseRight: "MouseRightClickInfo5"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MiningRail3 { get; } = new Item() { ID = 8654, Name = "MiningRail3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Mining Rail"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/MineOrbit5-icon"<para/>
//		/// PlacenmentId: 8655<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo6"<para/>
//		/// MouseRight: "MouseRightClickInfo6"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MiningRail4 { get; } = new Item() { ID = 8655, Name = "MiningRail4", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Mining Rail"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/MineOrbit6-icon"<para/>
//		/// PlacenmentId: 8656<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo7"<para/>
//		/// MouseRight: "MouseRightClickInfo7"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MiningRail5 { get; } = new Item() { ID = 8656, Name = "MiningRail5", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Mining Rail"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/MineOrbit7-icon"<para/>
//		/// PlacenmentId: 8657<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo8"<para/>
//		/// MouseRight: "MouseRightClickInfo8"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MiningRail6 { get; } = new Item() { ID = 8657, Name = "MiningRail6", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Mining Rail"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/MineOrbit8-icon"<para/>
//		/// PlacenmentId: 8658<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo9"<para/>
//		/// MouseRight: "MouseRightClickInfo9"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MiningRail7 { get; } = new Item() { ID = 8658, Name = "MiningRail7", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Mining Rail"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/MineOrbit9-icon"<para/>
//		/// PlacenmentId: 8659<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo10"<para/>
//		/// MouseRight: "MouseRightClickInfo10"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MiningRail8 { get; } = new Item() { ID = 8659, Name = "MiningRail8", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Mining Rail"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/MineOrbit10-icon"<para/>
//		/// PlacenmentId: 8660<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo11"<para/>
//		/// MouseRight: "MouseRightClickInfo11"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MiningRail9 { get; } = new Item() { ID = 8660, Name = "MiningRail9", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Mine Cart"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/MineOrbit11-icon"<para/>
//		/// PlacenmentId: 8661<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo12"<para/>
//		/// MouseRight: "MouseRightClickInfo12"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MineCart0 { get; } = new Item() { ID = 8661, Name = "MineCart0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Mine Cart"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/MineOrbit12-icon"<para/>
//		/// PlacenmentId: 8662<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo13"<para/>
//		/// MouseRight: "MouseRightClickInfo13"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MineCart1 { get; } = new Item() { ID = 8662, Name = "MineCart1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Mine Cart"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/MineOrbit13-icon"<para/>
//		/// PlacenmentId: 8663<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo14"<para/>
//		/// MouseRight: "MouseRightClickInfo14"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MineCart2 { get; } = new Item() { ID = 8663, Name = "MineCart2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Mine Cart"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/MineOrbit14-icon"<para/>
//		/// PlacenmentId: 8664<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo15"<para/>
//		/// MouseRight: "MouseRightClickInfo15"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MineCart3 { get; } = new Item() { ID = 8664, Name = "MineCart3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Infusion Stand"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/InfusionStand-icon"<para/>
//		/// PlacenmentId: 8986<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InfusionStand { get; } = new Item() { ID = 8986, Name = "InfusionStand", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Sapling Pot"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 15<para/>
//		/// DropTexture: "Icon/SeedlingCulturePot2-icon"<para/>
//		/// PlacenmentId: 8987<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SaplingPot { get; } = new Item() { ID = 8987, Name = "SaplingPot", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Cart"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/Wheelbarrow-icon"<para/>
//		/// PlacenmentId: 8988<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Cart { get; } = new Item() { ID = 8988, Name = "Cart", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Drawing Storage Box"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/drawingbox-icon"<para/>
//		/// PlacenmentId: 8989<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DrawingStorageBox { get; } = new Item() { ID = 8989, Name = "DrawingStorageBox", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meat Drying Rack"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/MeatRack-icon"<para/>
//		/// PlacenmentId: 8990<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MeatDryingRack { get; } = new Item() { ID = 8990, Name = "MeatDryingRack", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Farm Tools Rack"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/GarmImplementsRack-icon"<para/>
//		/// PlacenmentId: 8991<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item FarmToolsRack { get; } = new Item() { ID = 8991, Name = "FarmToolsRack", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wooden Basket"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/FirewoodFrame-icon"<para/>
//		/// PlacenmentId: 8992<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodenBasket { get; } = new Item() { ID = 8992, Name = "WoodenBasket", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Fertilizers"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/fertilizer-icon"<para/>
//		/// PlacenmentId: 8993<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Fertilizers { get; } = new Item() { ID = 8993, Name = "Fertilizers", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Crate"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/VegetableBasket-icon"<para/>
//		/// PlacenmentId: 8994<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Crate0 { get; } = new Item() { ID = 8994, Name = "Crate0", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Crate"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/SundryDecoration4-icon"<para/>
//		/// PlacenmentId: 8995<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Crate1 { get; } = new Item() { ID = 8995, Name = "Crate1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Crate"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/SundryDecoration3-icon"<para/>
//		/// PlacenmentId: 8996<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Crate2 { get; } = new Item() { ID = 8996, Name = "Crate2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wood Pile"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/SundryDecoration2-icon"<para/>
//		/// PlacenmentId: 8997<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item WoodPile { get; } = new Item() { ID = 8997, Name = "WoodPile", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Crate"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/SundryDecoration1-icon"<para/>
//		/// PlacenmentId: 8998<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Crate3 { get; } = new Item() { ID = 8998, Name = "Crate3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Book Pile"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 30<para/>
//		/// DropTexture: "Icon/StackOfBooks-icon"<para/>
//		/// PlacenmentId: 8999<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item BookPile { get; } = new Item() { ID = 8999, Name = "BookPile", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wood"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 21<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 15<para/>
//		/// DropTexture: "Icon/tree-wood-icon"<para/>
//		/// PlacenmentId: 2013<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1, 6 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Wood { get; } = new Item() { ID = 9001, Name = "Wood", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Bone"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 26<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 1<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bones-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Bone { get; } = new Item() { ID = 9003, Name = "Bone", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Drug"<para/>
//		/// Type: 1<para/>
//		/// ItemType: 104<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "0"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Drug { get; } = new Item() { ID = 9005, Name = "Drug", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Feather"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/feather-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Feather { get; } = new Item() { ID = 9006, Name = "Feather", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Wool"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 15<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/goatshair-white-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Wool { get; } = new Item() { ID = 9007, Name = "Wool", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Leather"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 15<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/skin-cattle-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Leather { get; } = new Item() { ID = 9008, Name = "Leather", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Glass"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 1<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bar-glass-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Glass { get; } = new Item() { ID = 9009, Name = "Glass", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "String"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/wool-white-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item String { get; } = new Item() { ID = 9010, Name = "String", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Copper Bar"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 31<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 12<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bar-copper-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item CopperBar { get; } = new Item() { ID = 9011, Name = "CopperBar", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Iron Bar"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 31<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 20<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bar-iron-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item IronBar { get; } = new Item() { ID = 9012, Name = "IronBar", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Bar"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 31<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 35<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bar-silver-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverBar { get; } = new Item() { ID = 9013, Name = "SilverBar", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Gold Bar"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 31<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 60<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/bar-gold-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldBar { get; } = new Item() { ID = 9014, Name = "GoldBar", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Gunpowder"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 12<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/gunpowder-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Gunpowder { get; } = new Item() { ID = 9015, Name = "Gunpowder", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Silver Coin"<para/>
//		/// Description: "An item that is used as a medium of exchange. It can also be smelted into metal bars through a furnace."<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 999<para/>
//		/// Price: 4<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/coin-silver-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9013, 1 ]<para/>
//		/// SmeltConsume: 15<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item SilverCoin { get; } = new Item() { ID = 9016, Name = "SilverCoin", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Gold Coin"<para/>
//		/// Description: "An item that is used as a medium of exchange. It can also be smelted into metal bars through a furnace."<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 999<para/>
//		/// Price: 6<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/coin-gold-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 9014, 1 ]<para/>
//		/// SmeltConsume: 15<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoldCoin { get; } = new Item() { ID = 9017, Name = "GoldCoin", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Tenergy Shard"<para/>
//		/// Description: "Can be made into complete pieces of Tenergy in the T-Furnace."<para/>
//		/// Type: 0<para/>
//		/// ItemType: 105<para/>
//		/// MaxCount: 999<para/>
//		/// Price: 4<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/kepler-tenergy-shard-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item TenergyShard { get; } = new Item() { ID = 9018, Name = "TenergyShard", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Exoskeleton"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 2<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/demon-tentacle-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorExoskeleton { get; } = new Item() { ID = 9019, Name = "InsectorExoskeleton", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Mucus"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 2<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/demon-mucus-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Mucus { get; } = new Item() { ID = 9020, Name = "Mucus", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Egg"<para/>
//		/// Description: "Something inside is moving!"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 2<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/demon-egg-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorEgg { get; } = new Item() { ID = 9021, Name = "InsectorEgg", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Pet Collar"<para/>
//		/// Function: "An item used to tame a pet. (Success rate of taming a crueler creature is relatively lower)"<para/>
//		/// Type: 7<para/>
//		/// ItemType: 56<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 48<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/petcollar-01-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "MouseRightClickInfo6"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item PetCollar { get; } = new Item() { ID = 9022, Name = "PetCollar", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Monster Skin"<para/>
//		/// Description: "A material that needs to be processed before it can be used as leather."<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 1<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/skin-monster-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MonsterSkin { get; } = new Item() { ID = 9023, Name = "MonsterSkin", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Tenergy"<para/>
//		/// Description: "A core with huge amount of Tenergy."<para/>
//		/// Type: 0<para/>
//		/// ItemType: 105<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 30<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/kepler-tenergy-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Tenergy { get; } = new Item() { ID = 9024, Name = "Tenergy", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Alloy"<para/>
//		/// Description: "A common and tough material used in making Meco items."<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 80<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/alloy-meco-mecoalloy-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoAlloy { get; } = new Item() { ID = 9025, Name = "MecoAlloy", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Parasect Mass"<para/>
//		/// Description: "The Parasect cell inside seems not very stable!"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 10<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/meco-ParasectMass-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoParasectMass { get; } = new Item() { ID = 9026, Name = "MecoParasectMass", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Tenergy Shards"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 999<para/>
//		/// MaxCount: 999999999<para/>
//		/// Price: 0<para/>
//		/// AttTree: 0<para/>
//		/// AttWall: 0<para/>
//		/// AttBuild: 0<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/kepler-tenergy-shard-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item TenergyShards { get; } = new Item() { ID = 9027, Name = "TenergyShards", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Amber"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 5<para/>
//		/// AttTree: 0<para/>
//		/// AttWall: 0<para/>
//		/// AttBuild: 0<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/amber-grounder-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 6 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Amber { get; } = new Item() { ID = 9028, Name = "Amber", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Parasytor Gene Ball"<para/>
//		/// Function: "Can be sold or used to unlock the corresponding workbench in Schip's Lab."<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 40<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/icon50W&A-W-Icon-002"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item ParasytorGeneBall { get; } = new Item() { ID = 9029, Name = "ParasytorGeneBall", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin Gene Ball"<para/>
//		/// Function: "Can be sold or used to unlock the corresponding workbench in Schip's Lab."<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 100<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/icon50W&A-W-Icon-001"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinGeneBall { get; } = new Item() { ID = 9030, Name = "GoblinGeneBall", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Gene Ball"<para/>
//		/// Function: "Can be sold or used to unlock the corresponding workbench in Schip's Lab."<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 150<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/icon50W&A-W-Icon-003"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorGeneBall { get; } = new Item() { ID = 9031, Name = "InsectorGeneBall", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Grounder Gene Ball"<para/>
//		/// Function: "Can be sold or used to unlock the corresponding workbench in Schip's Lab."<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 200<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/icon50W&A-W-Icon-004"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GrounderGeneBall { get; } = new Item() { ID = 9032, Name = "GrounderGeneBall", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Divil Gene Ball"<para/>
//		/// Function: "Can be sold or used to unlock the corresponding workbench in Schip's Lab."<para/>
//		/// Type: 0<para/>
//		/// ItemType: 30<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 200<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/icon50W&A-W-Icon-006"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 0<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item DivilGeneBall { get; } = new Item() { ID = 9033, Name = "DivilGeneBall", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "My home"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 61<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 10<para/>
//		/// DropTexture: "Icon/guidancesystem-paper-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MyHome { get; } = new Item() { ID = 9501, Name = "MyHome", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Goblin Village"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 61<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 10<para/>
//		/// DropTexture: "Icon/guidancesystem-paper-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GoblinVillage { get; } = new Item() { ID = 9502, Name = "GoblinVillage", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Infected Village"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 61<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 10<para/>
//		/// DropTexture: "Icon/guidancesystem-paper-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InfectedVillage { get; } = new Item() { ID = 9503, Name = "InfectedVillage", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Human Village"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 61<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 10<para/>
//		/// DropTexture: "Icon/guidancesystem-paper-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item HumanVillage { get; } = new Item() { ID = 9504, Name = "HumanVillage", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Insector Nest"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 61<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 10<para/>
//		/// DropTexture: "Icon/guidancesystem-paper-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item InsectorNest16 { get; } = new Item() { ID = 9505, Name = "InsectorNest16", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Meco Biotech Research Institute"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 61<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 10<para/>
//		/// DropTexture: "Icon/guidancesystem-paper-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item MecoBiotechResearchInstitute { get; } = new Item() { ID = 9506, Name = "MecoBiotechResearchInstitute", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Grounder Base"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 61<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 10<para/>
//		/// DropTexture: "Icon/guidancesystem-paper-icon"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item GrounderBase { get; } = new Item() { ID = 9507, Name = "GrounderBase", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 1"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-10"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue1 { get; } = new Item() { ID = 12010, Name = "Clue1", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 2"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-20"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue2 { get; } = new Item() { ID = 12020, Name = "Clue2", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 3"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-30"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue3 { get; } = new Item() { ID = 12030, Name = "Clue3", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 4"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-40"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue4 { get; } = new Item() { ID = 12040, Name = "Clue4", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 5"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-50"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue5 { get; } = new Item() { ID = 12050, Name = "Clue5", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 6"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-60"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue6 { get; } = new Item() { ID = 12060, Name = "Clue6", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 7"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-70"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue7 { get; } = new Item() { ID = 12070, Name = "Clue7", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 8"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-80"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue8 { get; } = new Item() { ID = 12080, Name = "Clue8", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 9"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-90"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue9 { get; } = new Item() { ID = 12090, Name = "Clue9", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 10"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-100"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue10 { get; } = new Item() { ID = 12100, Name = "Clue10", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 11"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-110"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue11 { get; } = new Item() { ID = 12110, Name = "Clue11", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 12"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-120"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue12 { get; } = new Item() { ID = 12120, Name = "Clue12", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 13"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-130"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue13 { get; } = new Item() { ID = 12130, Name = "Clue13", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 14"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-140"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue14 { get; } = new Item() { ID = 12140, Name = "Clue14", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 15"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-150"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue15 { get; } = new Item() { ID = 12150, Name = "Clue15", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 16"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-160"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue16 { get; } = new Item() { ID = 12160, Name = "Clue16", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 17"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-170"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue17 { get; } = new Item() { ID = 12170, Name = "Clue17", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 18"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-180"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue18 { get; } = new Item() { ID = 12180, Name = "Clue18", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 19"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-190"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue19 { get; } = new Item() { ID = 12190, Name = "Clue19", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 20"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-200"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue20 { get; } = new Item() { ID = 12200, Name = "Clue20", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 21"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-210"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue21 { get; } = new Item() { ID = 12210, Name = "Clue21", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 22"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-220"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue22 { get; } = new Item() { ID = 12220, Name = "Clue22", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 23"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-230"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue23 { get; } = new Item() { ID = 12230, Name = "Clue23", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 24"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-240"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue24 { get; } = new Item() { ID = 12240, Name = "Clue24", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 25"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-250"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue25 { get; } = new Item() { ID = 12250, Name = "Clue25", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 26"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-260"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue26 { get; } = new Item() { ID = 12260, Name = "Clue26", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 27"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-270"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue27 { get; } = new Item() { ID = 12270, Name = "Clue27", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 28"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-280"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue28 { get; } = new Item() { ID = 12280, Name = "Clue28", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 29"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-290"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue29 { get; } = new Item() { ID = 12290, Name = "Clue29", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 30"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-300"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue30 { get; } = new Item() { ID = 12300, Name = "Clue30", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 31"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-310"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue31 { get; } = new Item() { ID = 12310, Name = "Clue31", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 32"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-320"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue32 { get; } = new Item() { ID = 12320, Name = "Clue32", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 33"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-330"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue33 { get; } = new Item() { ID = 12330, Name = "Clue33", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 34"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-340"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue34 { get; } = new Item() { ID = 12340, Name = "Clue34", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 35"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-350"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue35 { get; } = new Item() { ID = 12350, Name = "Clue35", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 36"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-360"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue36 { get; } = new Item() { ID = 12360, Name = "Clue36", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 37"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1000"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue37 { get; } = new Item() { ID = 13000, Name = "Clue37", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 38"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1001"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue38 { get; } = new Item() { ID = 13001, Name = "Clue38", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 39"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1002"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue39 { get; } = new Item() { ID = 13002, Name = "Clue39", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 40"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1003"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue40 { get; } = new Item() { ID = 13003, Name = "Clue40", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 41"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1004"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue41 { get; } = new Item() { ID = 13004, Name = "Clue41", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 42"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1005"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue42 { get; } = new Item() { ID = 13005, Name = "Clue42", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 43"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1006"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue43 { get; } = new Item() { ID = 13006, Name = "Clue43", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 44"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1007"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue44 { get; } = new Item() { ID = 13007, Name = "Clue44", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 45"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1008"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue45 { get; } = new Item() { ID = 13008, Name = "Clue45", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 46"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1009"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue46 { get; } = new Item() { ID = 13009, Name = "Clue46", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 47"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1010"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue47 { get; } = new Item() { ID = 13010, Name = "Clue47", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 48"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1011"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue48 { get; } = new Item() { ID = 13011, Name = "Clue48", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 49"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1012"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue49 { get; } = new Item() { ID = 13012, Name = "Clue49", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 50"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1013"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue50 { get; } = new Item() { ID = 13013, Name = "Clue50", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 51"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1014"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue51 { get; } = new Item() { ID = 13014, Name = "Clue51", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 52"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1015"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue52 { get; } = new Item() { ID = 13015, Name = "Clue52", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Clue 53"<para/>
//		/// Type: 0<para/>
//		/// ItemType: 998<para/>
//		/// MaxCount: 1<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1016"<para/>
//		/// PlacenmentId: 0<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 0 ]<para/>
//		/// MouseLeft: "0"<para/>
//		/// MouseRight: "0"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item Clue53 { get; } = new Item() { ID = 13016, Name = "Clue53", Assembly = "Keplerth" };
//		/// <summary>
//		/// Name: "Test lead placement"<para/>
//		/// Description: "Mine description"<para/>
//		/// Type: 4<para/>
//		/// ItemType: 44<para/>
//		/// MaxCount: 99<para/>
//		/// Price: 0<para/>
//		/// AttTree: 1<para/>
//		/// AttWall: 1<para/>
//		/// AttBuild: 1<para/>
//		/// Durability: 0<para/>
//		/// BurnTime: 0<para/>
//		/// DropTexture: "Icon/grounder-landmine-icon"<para/>
//		/// PlacenmentId: 6996<para/>
//		/// BbqResult: [ 0 ]<para/>
//		/// SmeltResult: [ 0 ]<para/>
//		/// SmeltConsume: 1<para/>
//		/// UsesInfo: [ 1 ]<para/>
//		/// MouseLeft: "MouseLeftClickInfo2"<para/>
//		/// MouseRight: "MouseRightClickInfo2"<para/>
//		/// Keyboard: "0"<para/>
//		/// KeyboardInfo: "0"<para/>
//		/// </summary>
//		public static Item TestLeadPlacement { get; } = new Item() { ID = 99999, Name = "TestLeadPlacement", Assembly = "Keplerth" };
//	}
//}
