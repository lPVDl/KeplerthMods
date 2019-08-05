namespace ChassisMod.KeplerDatabase
{
	public static class ItemDB
	{
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 0<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 0<para/>
		/// AttWall: 0<para/>
		/// AttBuild: 0<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/error-item"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ErrorItem { get; } = new Item("ErrorItem", -99);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 2<para/>
		/// MaxCount: 99<para/>
		/// Price: 4<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/tree-fruits-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Apple { get; } = new Item("Apple", 1);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 2<para/>
		/// MaxCount: 99<para/>
		/// Price: 4<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/tree-berries-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Berries { get; } = new Item("Berries", 2);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 6<para/>
		/// MaxCount: 99<para/>
		/// Price: 5<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/packedfood-02-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CompressedCookie { get; } = new Item("CompressedCookie", 3);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 7<para/>
		/// MaxCount: 99<para/>
		/// Price: 12<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/flower-10-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6, 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Nectar { get; } = new Item("Nectar", 4);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 8<para/>
		/// MaxCount: 99<para/>
		/// Price: 5<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meat-boar-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 10007, 1 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6, 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MonsterMeat { get; } = new Item("MonsterMeat", 5);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 1<para/>
		/// MaxCount: 99<para/>
		/// Price: 20<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meat-chicken-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 10001, 1 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6, 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ChickenMeat { get; } = new Item("ChickenMeat", 6);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 1<para/>
		/// MaxCount: 99<para/>
		/// Price: 20<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meat-dog-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 10002, 1 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6, 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DogMeat { get; } = new Item("DogMeat", 7);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 1<para/>
		/// MaxCount: 99<para/>
		/// Price: 20<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meat-goat-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 10003, 1 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6, 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Lamb { get; } = new Item("Lamb", 8);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 1<para/>
		/// MaxCount: 99<para/>
		/// Price: 20<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meat-pig-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 10004, 1 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6, 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Pork { get; } = new Item("Pork", 9);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 1<para/>
		/// MaxCount: 99<para/>
		/// Price: 20<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meat-cattle-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 10005, 1 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6, 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Beef { get; } = new Item("Beef", 10);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 3<para/>
		/// MaxCount: 99<para/>
		/// Price: 6<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/chicken-egg-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 10006, 1 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Egg { get; } = new Item("Egg", 11);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 8<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item VenomSac { get; } = new Item("VenomSac", 12);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 8<para/>
		/// MaxCount: 99<para/>
		/// Price: 5<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meat-worm-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 10008, 1 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DisgustingOrgans { get; } = new Item("DisgustingOrgans", 13);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 1<para/>
		/// MaxCount: 99<para/>
		/// Price: 5<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meat-ribs-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Jerky { get; } = new Item("Jerky", 17);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 6<para/>
		/// MaxCount: 99<para/>
		/// Price: 100<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wildboarglands-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WildBoarGlands { get; } = new Item("WildBoarGlands", 18);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/pheromones-chicken-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item PheromonesChicken { get; } = new Item("PheromonesChicken", 19);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/pheromones-goat-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item PheromonesGoat { get; } = new Item("PheromonesGoat", 20);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/pheromones-pig-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item PheromonesPig { get; } = new Item("PheromonesPig", 21);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/pheromones-cow-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item PheromonesCow { get; } = new Item("PheromonesCow", 22);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/pheromones-horse-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item PheromonesHorse { get; } = new Item("PheromonesHorse", 23);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 1<para/>
		/// MaxCount: 99<para/>
		/// Price: 20<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meat-horse-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 10010, 1 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6, 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item HorseMeat { get; } = new Item("HorseMeat", 24);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 24<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Bud { get; } = new Item("Bud", 501);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 48<para/>
		/// MaxCount: 99<para/>
		/// Price: 1<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/mushroom-icon"<para/>
		/// PlacenmentId: 101<para/>
		/// BbqResult: [ 10009, 1 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 4, 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item RedMushroom { get; } = new Item("RedMushroom", 502);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 24<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item503 { get; } = new Item("Item503", 503);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 24<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item504 { get; } = new Item("Item504", 504);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 24<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item505 { get; } = new Item("Item505", 505);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 24<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Mint { get; } = new Item("Mint", 506);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 24<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item507 { get; } = new Item("Item507", 507);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 16<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-hp-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Bandage { get; } = new Item("Bandage", 601);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 31<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-hp-02-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item PainKiller { get; } = new Item("PainKiller", 602);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 62<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-hp-03-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item FirstAidKit { get; } = new Item("FirstAidKit", 603);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 123<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-hp-04-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item NanoCapsule { get; } = new Item("NanoCapsule", 604);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item605 { get; } = new Item("Item605", 605);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item606 { get; } = new Item("Item606", 606);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item607 { get; } = new Item("Item607", 607);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item608 { get; } = new Item("Item608", 608);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item609 { get; } = new Item("Item609", 609);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item610 { get; } = new Item("Item610", 610);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item611 { get; } = new Item("Item611", 611);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item612 { get; } = new Item("Item612", 612);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item613 { get; } = new Item("Item613", 613);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item614 { get; } = new Item("Item614", 614);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item615 { get; } = new Item("Item615", 615);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 40<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-analeptic-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StimulantsI { get; } = new Item("StimulantsI", 616);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 160<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-analeptic-02-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StimulantsII { get; } = new Item("StimulantsII", 617);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 640<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-analeptic-03-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StimulantsIII { get; } = new Item("StimulantsIII", 618);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item619 { get; } = new Item("Item619", 619);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item620 { get; } = new Item("Item620", 620);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item621 { get; } = new Item("Item621", 621);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item622 { get; } = new Item("Item622", 622);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item623 { get; } = new Item("Item623", 623);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item624 { get; } = new Item("Item624", 624);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item625 { get; } = new Item("Item625", 625);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 10<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-atk&def-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DamagedATKCapsule { get; } = new Item("DamagedATKCapsule", 626);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 20<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-atk&def-02-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ExpiredATKCapsule { get; } = new Item("ExpiredATKCapsule", 627);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 53<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-atk&def-03-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ATKCapsule { get; } = new Item("ATKCapsule", 628);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 212<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-atk&def-04-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ATKCapsuleExtra { get; } = new Item("ATKCapsuleExtra", 629);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 848<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-atk&def-05-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ATKCapsuleExtraAdvance { get; } = new Item("ATKCapsuleExtraAdvance", 630);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 10<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-atk&def-16-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DamagedDEFCapsule { get; } = new Item("DamagedDEFCapsule", 631);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 20<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-atk&def-17-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ExpiredDEFCapsule { get; } = new Item("ExpiredDEFCapsule", 632);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 53<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-atk&def-18-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DEFCapsule { get; } = new Item("DEFCapsule", 633);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 212<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-atk&def-19-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DEFCapsuleExtra { get; } = new Item("DEFCapsuleExtra", 634);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 848<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-atk&def-20-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DEFCapsuleExtraAdvance { get; } = new Item("DEFCapsuleExtraAdvance", 635);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 10<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-movespeed-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DamagedAGLPotion { get; } = new Item("DamagedAGLPotion", 636);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 20<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-movespeed-02-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ExpiredAGLPotion { get; } = new Item("ExpiredAGLPotion", 637);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 53<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-movespeed-03-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item AGLPotion { get; } = new Item("AGLPotion", 638);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 212<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-movespeed-04-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item AGLPotionExtra { get; } = new Item("AGLPotionExtra", 639);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 848<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-movespeed-05-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item AGLPotionExtraAdvance { get; } = new Item("AGLPotionExtraAdvance", 640);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 10<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-attackspeed-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoJoyfulI { get; } = new Item("MecoJoyfulI", 641);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 20<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-attackspeed-02-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoJoyfulII { get; } = new Item("MecoJoyfulII", 642);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 53<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-attackspeed-03-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoJoyfulIII { get; } = new Item("MecoJoyfulIII", 643);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 212<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-attackspeed-04-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoJoyfulIV { get; } = new Item("MecoJoyfulIV", 644);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 30<para/>
		/// Price: 848<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drug-attackspeed-05-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoJoyfulV { get; } = new Item("MecoJoyfulV", 645);
		/// <summary>
		/// Type: 6<para/>
		/// ItemType: 0<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/rifter-stone-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo7"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item RifterStone { get; } = new Item("RifterStone", 901);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 6<para/>
		/// MaxCount: 99<para/>
		/// Price: 200<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/coocoo-jell-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo7"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CoocooJelly { get; } = new Item("CoocooJelly", 902);
		/// <summary>
		/// Type: 6<para/>
		/// ItemType: 0<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/doll-coocoo-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo7"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DollCoocoo { get; } = new Item("DollCoocoo", 903);
		/// <summary>
		/// Type: 8<para/>
		/// ItemType: 0<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/coocoo-ball-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo7"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CoocooBomb { get; } = new Item("CoocooBomb", 904);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 11<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 300<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/sword-wood-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenSword { get; } = new Item("WoodenSword", 1001);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 11<para/>
		/// MaxCount: 1<para/>
		/// Price: 1<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 400<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/sword-stone-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneClub { get; } = new Item("StoneClub", 1002);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 11<para/>
		/// MaxCount: 1<para/>
		/// Price: 34<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 750<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/sword-copper-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperSword { get; } = new Item("CopperSword", 1003);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 11<para/>
		/// MaxCount: 1<para/>
		/// Price: 57<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 800<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/sword-iron-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronSword { get; } = new Item("IronSword", 1004);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 11<para/>
		/// MaxCount: 1<para/>
		/// Price: 101<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 850<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/sword-silver-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverSword { get; } = new Item("SilverSword", 1005);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 11<para/>
		/// MaxCount: 1<para/>
		/// Price: 173<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 850<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/sword-gold-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenSword { get; } = new Item("GoldenSword", 1006);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 11<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 1500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DiamondSword { get; } = new Item("DiamondSword", 1007);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 11<para/>
		/// MaxCount: 1<para/>
		/// Price: 51<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 400<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/sword-bone-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinBoneSword { get; } = new Item("GoblinBoneSword", 1008);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 11<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 400<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinBoneSwordMonster { get; } = new Item("GoblinBoneSwordMonster", 1009);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 11<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 400<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinBoneSword2Monster { get; } = new Item("GoblinBoneSword2Monster", 1010);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 11<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 400<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WarMonster { get; } = new Item("WarMonster", 1011);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 11<para/>
		/// MaxCount: 1<para/>
		/// Price: 63<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 800<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/sword-demon-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorSickle { get; } = new Item("InsectorSickle", 1012);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 11<para/>
		/// MaxCount: 1<para/>
		/// Price: 84<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 800<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/sword-mutants-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasectSickle { get; } = new Item("ParasectSickle", 1013);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 11<para/>
		/// MaxCount: 1<para/>
		/// Price: 75<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 700<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/sword-bone2-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item War { get; } = new Item("War", 1014);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 11<para/>
		/// MaxCount: 1<para/>
		/// Price: 144<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 850<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/grounder-sword-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderSamuraiSword { get; } = new Item("GrounderSamuraiSword", 1015);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 11<para/>
		/// MaxCount: 1<para/>
		/// Price: 63<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 800<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorSickleMonster { get; } = new Item("InsectorSickleMonster", 1016);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 11<para/>
		/// MaxCount: 1<para/>
		/// Price: 84<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 800<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasectSickleMonster { get; } = new Item("ParasectSickleMonster", 1017);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 11<para/>
		/// MaxCount: 1<para/>
		/// Price: 144<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 850<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderSamuraiSwordMonster { get; } = new Item("GrounderSamuraiSwordMonster", 1018);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 14<para/>
		/// MaxCount: 1<para/>
		/// Price: 1<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 200<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/bow-wood-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenBow { get; } = new Item("WoodenBow", 1101);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 14<para/>
		/// MaxCount: 1<para/>
		/// Price: 26<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 350<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bow-copper-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperBow { get; } = new Item("CopperBow", 1102);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 14<para/>
		/// MaxCount: 1<para/>
		/// Price: 43<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 400<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bow-iron-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronBow { get; } = new Item("IronBow", 1103);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 14<para/>
		/// MaxCount: 1<para/>
		/// Price: 75<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 450<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bow-silver-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverBow { get; } = new Item("SilverBow", 1104);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 14<para/>
		/// MaxCount: 1<para/>
		/// Price: 129<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 450<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bow-gold-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenBow { get; } = new Item("GoldenBow", 1105);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 14<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 350<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DiamondBow { get; } = new Item("DiamondBow", 1106);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 14<para/>
		/// MaxCount: 1<para/>
		/// Price: 18<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 250<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bow-bone-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinBoneBow { get; } = new Item("GoblinBoneBow", 1107);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 14<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 175<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SplitMonster { get; } = new Item("SplitMonster", 1108);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 14<para/>
		/// MaxCount: 1<para/>
		/// Price: 60<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 400<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bow-bone2-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Split { get; } = new Item("Split", 1109);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 14<para/>
		/// MaxCount: 1<para/>
		/// Price: 18<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 250<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bow-bone-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinBoneBowMonster { get; } = new Item("GoblinBoneBowMonster", 1110);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 15<para/>
		/// MaxCount: 1<para/>
		/// Price: 35<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 350<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/gun-shotgun-copper-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperMusket { get; } = new Item("CopperMusket", 1201);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 15<para/>
		/// MaxCount: 1<para/>
		/// Price: 58<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 400<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/gun-shotgun-iron-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronMusket { get; } = new Item("IronMusket", 1202);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 15<para/>
		/// MaxCount: 1<para/>
		/// Price: 101<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 450<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/gun-shotgun-silver-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverMusket { get; } = new Item("SilverMusket", 1203);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 15<para/>
		/// MaxCount: 1<para/>
		/// Price: 173<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 450<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/gun-shotgun-gold-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenMusket { get; } = new Item("GoldenMusket", 1204);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 15<para/>
		/// MaxCount: 1<para/>
		/// Price: 35<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 350<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/gun-musket-copper-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperShotgun { get; } = new Item("CopperShotgun", 1211);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 15<para/>
		/// MaxCount: 1<para/>
		/// Price: 58<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 400<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/gun-musket-iron-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronShotgun { get; } = new Item("IronShotgun", 1212);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 15<para/>
		/// MaxCount: 1<para/>
		/// Price: 101<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 450<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/gun-musket-silver-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverShotgun { get; } = new Item("SilverShotgun", 1213);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 15<para/>
		/// MaxCount: 1<para/>
		/// Price: 173<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 450<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/gun-musket-gold-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenShotgun { get; } = new Item("GoldenShotgun", 1214);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 15<para/>
		/// MaxCount: 1<para/>
		/// Price: 50<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 300<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/electricarc01-gun-meco-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoP7 { get; } = new Item("MecoP7", 1221);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 15<para/>
		/// MaxCount: 1<para/>
		/// Price: 241<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 450<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/electricarc01-gun-meco-02-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoP7B { get; } = new Item("MecoP7B", 1222);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 15<para/>
		/// MaxCount: 1<para/>
		/// Price: 187<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 450<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/grounder-gun-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderSniperRifle { get; } = new Item("GrounderSniperRifle", 1223);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 15<para/>
		/// MaxCount: 1<para/>
		/// Price: 187<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 450<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/grounder-gun-02-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderAssaultRifle { get; } = new Item("GrounderAssaultRifle", 1224);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 15<para/>
		/// MaxCount: 1<para/>
		/// Price: 270<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 3000<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/grounder-gun-03-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderGatlingGun { get; } = new Item("GrounderGatlingGun", 1225);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 10<para/>
		/// MaxCount: 1<para/>
		/// Price: 72<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 300<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/electricarc01-gun-titanium-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoEA6C { get; } = new Item("MecoEA6C", 1301);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 10<para/>
		/// MaxCount: 1<para/>
		/// Price: 473<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 550<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/electricarc01-gun-divil-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Nemesis { get; } = new Item("Nemesis", 1302);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 10<para/>
		/// MaxCount: 1<para/>
		/// Price: 315<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 400<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/electricarc01-gun-MecoBiology-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoLP8B { get; } = new Item("MecoLP8B", 1303);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 10<para/>
		/// MaxCount: 1<para/>
		/// Price: 445<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 400<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/electricarc01-gun-MecoBiolopy01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoLG6B { get; } = new Item("MecoLG6B", 1304);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 10<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 100<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1351 { get; } = new Item("Item1351", 1351);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 10<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 100<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1352 { get; } = new Item("Item1352", 1352);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 10<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 100<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1353 { get; } = new Item("Item1353", 1353);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 10<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 100<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1354 { get; } = new Item("Item1354", 1354);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 10<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 100<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/electricarc01-gun-titanium-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoEA6CMonster { get; } = new Item("MecoEA6CMonster", 1355);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 10<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 225<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/electricarc01-gun-MecoBiology-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoLP8BMonster { get; } = new Item("MecoLP8BMonster", 1356);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 10<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 225<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/electricarc01-gun-MecoBiolopy01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoLG6BMonster { get; } = new Item("MecoLG6BMonster", 1357);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 12<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 400<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/spear-stone-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenSpear { get; } = new Item("WoodenSpear", 1401);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 12<para/>
		/// MaxCount: 1<para/>
		/// Price: 43<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 550<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/spear-copper-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperSpear { get; } = new Item("CopperSpear", 1402);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 12<para/>
		/// MaxCount: 1<para/>
		/// Price: 72<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 600<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/spear-iorn-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronSpear { get; } = new Item("IronSpear", 1403);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 12<para/>
		/// MaxCount: 1<para/>
		/// Price: 126<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 700<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/spear-silver-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverSpear { get; } = new Item("SilverSpear", 1404);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 12<para/>
		/// MaxCount: 1<para/>
		/// Price: 216<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 700<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/spear-gold-icon"<para/>
		/// PlacenmentId: 1<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenSpear { get; } = new Item("GoldenSpear", 1405);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 12<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 1500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DiamondSpear { get; } = new Item("DiamondSpear", 1406);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 12<para/>
		/// MaxCount: 1<para/>
		/// Price: 84<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 550<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/spear-demon-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorSpear { get; } = new Item("InsectorSpear", 1407);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 12<para/>
		/// MaxCount: 1<para/>
		/// Price: 106<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 550<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/spear-mutants-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasectSpear { get; } = new Item("ParasectSpear", 1408);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 12<para/>
		/// MaxCount: 1<para/>
		/// Price: 84<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 550<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorSpearMonster { get; } = new Item("InsectorSpearMonster", 1409);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 12<para/>
		/// MaxCount: 1<para/>
		/// Price: 106<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 550<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasectSpearMonster { get; } = new Item("ParasectSpearMonster", 1410);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 13<para/>
		/// MaxCount: 1<para/>
		/// Price: 34<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 850<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/dagger-copper-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperDagger { get; } = new Item("CopperDagger", 1501);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 13<para/>
		/// MaxCount: 1<para/>
		/// Price: 57<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 950<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/dagger-iron-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronDagger { get; } = new Item("IronDagger", 1502);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 13<para/>
		/// MaxCount: 1<para/>
		/// Price: 101<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 1050<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/dagger-silver-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverDagger { get; } = new Item("SilverDagger", 1503);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 13<para/>
		/// MaxCount: 1<para/>
		/// Price: 173<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 1050<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/dagger-gold-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenDagger { get; } = new Item("GoldenDagger", 1504);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 13<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 1500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DiamondDagger { get; } = new Item("DiamondDagger", 1505);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 13<para/>
		/// MaxCount: 1<para/>
		/// Price: 18<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 350<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/dagger-bone-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinBoneDagger { get; } = new Item("GoblinBoneDagger", 1506);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 13<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 350<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/dagger-bone-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinBoneDagger2 { get; } = new Item("GoblinBoneDagger2", 1507);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 13<para/>
		/// MaxCount: 1<para/>
		/// Price: 288<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 1100<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/dagger-divil-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Reaper { get; } = new Item("Reaper", 1508);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 13<para/>
		/// MaxCount: 1<para/>
		/// Price: 144<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 950<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/grounder-dagger-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderDagger { get; } = new Item("GrounderDagger", 1509);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 13<para/>
		/// MaxCount: 1<para/>
		/// Price: 288<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 1100<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ReaperMonster { get; } = new Item("ReaperMonster", 1510);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 13<para/>
		/// MaxCount: 1<para/>
		/// Price: 144<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 950<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderDaggerMonster { get; } = new Item("GrounderDaggerMonster", 1511);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 102<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/arrow-wood-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo5"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenArrow { get; } = new Item("WoodenArrow", 1601);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 102<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/arrow-stone-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo5"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneArrow { get; } = new Item("StoneArrow", 1602);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 102<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/arrow-copper-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo5"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperArrow { get; } = new Item("CopperArrow", 1603);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 102<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/arrow-iron-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo5"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronArrow { get; } = new Item("IronArrow", 1604);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 102<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/arrow-silver-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo5"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverArrow { get; } = new Item("SilverArrow", 1605);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 102<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/arrow-gold-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo5"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenArrow { get; } = new Item("GoldenArrow", 1606);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 102<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo5"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1607 { get; } = new Item("Item1607", 1607);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 102<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/arrow-stone-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo5"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneArrowMonster { get; } = new Item("StoneArrowMonster", 1608);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 102<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/arrow-wood-p-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo5"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ExplosiveWoodenArrow { get; } = new Item("ExplosiveWoodenArrow", 1611);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 102<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/arrow-stone-p-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo5"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ExplosiveStoneArrow { get; } = new Item("ExplosiveStoneArrow", 1612);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 102<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/arrow-copper-p-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo5"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ExplosiveCopperArrow { get; } = new Item("ExplosiveCopperArrow", 1613);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 102<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/arrow-iron-p-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo5"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ExplosiveIronArrow { get; } = new Item("ExplosiveIronArrow", 1614);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 102<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/arrow-silver-p-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo5"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ExplosiveSilverArrow { get; } = new Item("ExplosiveSilverArrow", 1615);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 102<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/arrow-gold-p-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo5"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ExplosiveGoldenArrow { get; } = new Item("ExplosiveGoldenArrow", 1616);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 102<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo5"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1617 { get; } = new Item("Item1617", 1617);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 103<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/arrow-shotgun-copper-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo5"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperBullet { get; } = new Item("CopperBullet", 1651);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 103<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/arrow-shotgun-iron-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo5"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronBullet { get; } = new Item("IronBullet", 1652);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 103<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/arrow-shotgun-silver-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo5"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverBullet { get; } = new Item("SilverBullet", 1653);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 103<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/arrow-shotgun-gold-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo5"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenBullet { get; } = new Item("GoldenBullet", 1654);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 20<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 2<para/>
		/// AttWall: 2<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item TenergyBullet { get; } = new Item("TenergyBullet", 1655);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 20<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1656 { get; } = new Item("Item1656", 1656);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 20<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1657 { get; } = new Item("Item1657", 1657);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 20<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1658 { get; } = new Item("Item1658", 1658);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 20<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1659 { get; } = new Item("Item1659", 1659);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 20<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 2<para/>
		/// AttWall: 2<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1660 { get; } = new Item("Item1660", 1660);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 20<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 0<para/>
		/// AttWall: 0<para/>
		/// AttBuild: 0<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1661 { get; } = new Item("Item1661", 1661);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 20<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1662 { get; } = new Item("Item1662", 1662);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 103<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/arrow-shotgun-meco1-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoBullet { get; } = new Item("MecoBullet", 1663);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 20<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 0<para/>
		/// AttWall: 0<para/>
		/// AttBuild: 0<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1664 { get; } = new Item("Item1664", 1664);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 103<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/arrow-shotgun-meco2-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoBiotechBullet { get; } = new Item("MecoBiotechBullet", 1665);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 103<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 3<para/>
		/// AttWall: 3<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1666 { get; } = new Item("Item1666", 1666);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 20<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 3<para/>
		/// AttWall: 3<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1667 { get; } = new Item("Item1667", 1667);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 20<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 2<para/>
		/// AttWall: 2<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1668 { get; } = new Item("Item1668", 1668);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 103<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/arrow-shotgun-meco1-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1669 { get; } = new Item("Item1669", 1669);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 103<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/arrow-shotgun-meco2-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1670 { get; } = new Item("Item1670", 1670);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 20<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 0<para/>
		/// AttWall: 0<para/>
		/// AttBuild: 0<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1671 { get; } = new Item("Item1671", 1671);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 20<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 0<para/>
		/// AttWall: 0<para/>
		/// AttBuild: 0<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1672 { get; } = new Item("Item1672", 1672);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 20<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 0<para/>
		/// AttWall: 0<para/>
		/// AttBuild: 0<para/>
		/// Durability: 1<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Snowball { get; } = new Item("Snowball", 1701);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 20<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 1<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Gravel { get; } = new Item("Gravel", 1702);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 20<para/>
		/// MaxCount: 999<para/>
		/// Price: 1<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 1<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/missile-cactus-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item LargeCactus { get; } = new Item("LargeCactus", 1703);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 20<para/>
		/// MaxCount: 999<para/>
		/// Price: 2<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 1<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/missile-bones&earth-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BonyBall { get; } = new Item("BonyBall", 1704);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 20<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 1<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item FlysMucus { get; } = new Item("FlysMucus", 1705);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 20<para/>
		/// MaxCount: 999<para/>
		/// Price: 3<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 1<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/missile-mutants01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasytorPox { get; } = new Item("ParasytorPox", 1706);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 20<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 1<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WeakParasytorPox { get; } = new Item("WeakParasytorPox", 1707);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 20<para/>
		/// MaxCount: 999<para/>
		/// Price: 6<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 1<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/missile-grounder-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderGrenade { get; } = new Item("GrounderGrenade", 1708);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 20<para/>
		/// MaxCount: 999<para/>
		/// Price: 6<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 1<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderGrenadeBoss { get; } = new Item("GrounderGrenadeBoss", 1709);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 0<para/>
		/// AttWall: 0<para/>
		/// AttBuild: 0<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1801 { get; } = new Item("Item1801", 1801);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1802 { get; } = new Item("Item1802", 1802);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1803 { get; } = new Item("Item1803", 1803);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1804 { get; } = new Item("Item1804", 1804);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1805 { get; } = new Item("Item1805", 1805);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1806 { get; } = new Item("Item1806", 1806);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1807 { get; } = new Item("Item1807", 1807);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1808 { get; } = new Item("Item1808", 1808);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 999<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item1809 { get; } = new Item("Item1809", 1809);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 58<para/>
		/// MaxCount: 1<para/>
		/// Price: 60<para/>
		/// AttTree: 2<para/>
		/// AttWall: 2<para/>
		/// AttBuild: 2<para/>
		/// Durability: 3800<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/gun-mutants01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasectPlasmaGun0 { get; } = new Item("ParasectPlasmaGun0", 1901);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 100<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/armor-wood-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenArmor { get; } = new Item("WoodenArmor", 2001);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 21<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 250<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-leather-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item LeatherArmor { get; } = new Item("LeatherArmor", 2002);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 42<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 400<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-copper-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperArmor { get; } = new Item("CopperArmor", 2003);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 65<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 450<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-iron-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronArmor { get; } = new Item("IronArmor", 2004);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 108<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-silver-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverArmor { get; } = new Item("SilverArmor", 2005);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 180<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-gold-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenPlate { get; } = new Item("GoldenPlate", 2006);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 1000<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DiamondPlate { get; } = new Item("DiamondPlate", 2007);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 32<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 250<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-goblin01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item AssassinLeatherArmor { get; } = new Item("AssassinLeatherArmor", 2008);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 32<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 250<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-goblin02-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ScaleArmour { get; } = new Item("ScaleArmour", 2009);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 24<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 220<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-goblin09-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WarriorLeatherArmor { get; } = new Item("WarriorLeatherArmor", 2010);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 24<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 220<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-goblin06-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ArcherLeatherArmor { get; } = new Item("ArcherLeatherArmor", 2011);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 12<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 200<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-goblin08-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WarriorOutfit { get; } = new Item("WarriorOutfit", 2012);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 12<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 200<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-goblin05-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ArcherOutfit { get; } = new Item("ArcherOutfit", 2013);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 6<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 150<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-goblin07-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BasicGoblinOutfit0 { get; } = new Item("BasicGoblinOutfit0", 2014);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 6<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 150<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-goblin04-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BasicGoblinOutfit1 { get; } = new Item("BasicGoblinOutfit1", 2015);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 6<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 150<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-goblin10-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinOutfit0 { get; } = new Item("GoblinOutfit0", 2016);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 6<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 150<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-goblin11-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinOutfit1 { get; } = new Item("GoblinOutfit1", 2017);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 48<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 300<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-goblin12-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinPlate0 { get; } = new Item("GoblinPlate0", 2018);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 48<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 300<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-goblin13-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinLightweightArmor0 { get; } = new Item("GoblinLightweightArmor0", 2019);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 400<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-titanium-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoBattleRhino { get; } = new Item("MecoBattleRhino", 2020);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 66<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 350<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-goblin03-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinSteelArmor { get; } = new Item("GoblinSteelArmor", 2021);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 48<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 300<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-goblin12-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinPlate1 { get; } = new Item("GoblinPlate1", 2024);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 48<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 300<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-goblin13-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinLightweightArmor1 { get; } = new Item("GoblinLightweightArmor1", 2025);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 87<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 450<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-28-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasectOutfit { get; } = new Item("ParasectOutfit", 2026);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 273<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/MecoBiology-1-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoParasectArmor { get; } = new Item("MecoParasectArmor", 2027);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/MecoBiology-1-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item2028 { get; } = new Item("Item2028", 2028);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 320<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-33-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DivilsOutfit { get; } = new Item("DivilsOutfit", 2029);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 320<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-36-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item VsOutfit { get; } = new Item("VsOutfit", 2030);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 320<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-315-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item2031 { get; } = new Item("Item2031", 2031);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 320<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-314-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item2032 { get; } = new Item("Item2032", 2032);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 108<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-grounder01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderLightweightOutfit0 { get; } = new Item("GrounderLightweightOutfit0", 2033);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 108<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-grounder02-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderOutfit0 { get; } = new Item("GrounderOutfit0", 2034);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 129<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-grounder03-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderCombatOutfit0 { get; } = new Item("GrounderCombatOutfit0", 2035);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 129<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-grounder04-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderHunterOutfit0 { get; } = new Item("GrounderHunterOutfit0", 2036);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 150<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-grounder05-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderAntiMecoArmor0 { get; } = new Item("GrounderAntiMecoArmor0", 2037);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 176<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-grounder06-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderAntiMecoPlate0 { get; } = new Item("GrounderAntiMecoPlate0", 2038);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 176<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderLightweightOutfit1 { get; } = new Item("GrounderLightweightOutfit1", 2039);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 176<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderOutfit1 { get; } = new Item("GrounderOutfit1", 2040);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 176<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderCombatOutfit1 { get; } = new Item("GrounderCombatOutfit1", 2041);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 176<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderHunterOutfit1 { get; } = new Item("GrounderHunterOutfit1", 2042);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 176<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderAntiMecoArmor1 { get; } = new Item("GrounderAntiMecoArmor1", 2043);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 176<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderAntiMecoPlate1 { get; } = new Item("GrounderAntiMecoPlate1", 2044);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 2000<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-313-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item PapaArmor { get; } = new Item("PapaArmor", 2099);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 17<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 100<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenGloves { get; } = new Item("WoodenGloves", 2101);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 17<para/>
		/// MaxCount: 1<para/>
		/// Price: 14<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 250<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/gloves-leather-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item LeatherGloves { get; } = new Item("LeatherGloves", 2102);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 17<para/>
		/// MaxCount: 1<para/>
		/// Price: 29<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 400<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/gloves-copper-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperGloves { get; } = new Item("CopperGloves", 2103);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 17<para/>
		/// MaxCount: 1<para/>
		/// Price: 47<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 450<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/gloves-iron-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronGloves { get; } = new Item("IronGloves", 2104);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 17<para/>
		/// MaxCount: 1<para/>
		/// Price: 79<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/gloves-silver-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverGloves { get; } = new Item("SilverGloves", 2105);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 17<para/>
		/// MaxCount: 1<para/>
		/// Price: 133<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/gloves-gold-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenGloves { get; } = new Item("GoldenGloves", 2106);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 17<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 100<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DiamondGloves { get; } = new Item("DiamondGloves", 2107);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 17<para/>
		/// MaxCount: 1<para/>
		/// Price: 66<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 450<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/gloves-28-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasectGloves { get; } = new Item("ParasectGloves", 2108);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 17<para/>
		/// MaxCount: 1<para/>
		/// Price: 198<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/gloves-MecoBiology1-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoParasectGloves { get; } = new Item("MecoParasectGloves", 2109);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 17<para/>
		/// MaxCount: 1<para/>
		/// Price: 97<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/gloves-grounder-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrenaderGloves { get; } = new Item("GrenaderGloves", 2110);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 18<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 100<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenShoes { get; } = new Item("WoodenShoes", 2201);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 18<para/>
		/// MaxCount: 1<para/>
		/// Price: 14<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 250<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/shoes-leather-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item LeatherShoes { get; } = new Item("LeatherShoes", 2202);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 18<para/>
		/// MaxCount: 1<para/>
		/// Price: 29<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 400<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/shoes-copper-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperShoes { get; } = new Item("CopperShoes", 2203);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 18<para/>
		/// MaxCount: 1<para/>
		/// Price: 47<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 450<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/shoes-iron-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronShoes { get; } = new Item("IronShoes", 2204);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 18<para/>
		/// MaxCount: 1<para/>
		/// Price: 79<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/shoes-silver-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverShoes { get; } = new Item("SilverShoes", 2205);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 18<para/>
		/// MaxCount: 1<para/>
		/// Price: 133<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/shoes-gold-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenShoes { get; } = new Item("GoldenShoes", 2206);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 18<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 100<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DiamondShoes { get; } = new Item("DiamondShoes", 2207);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 18<para/>
		/// MaxCount: 1<para/>
		/// Price: 66<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 450<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/shoes-28-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasectShoes { get; } = new Item("ParasectShoes", 2208);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 18<para/>
		/// MaxCount: 1<para/>
		/// Price: 198<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/shoes-MecoBiology1-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoParasectShoes { get; } = new Item("MecoParasectShoes", 2209);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 18<para/>
		/// MaxCount: 1<para/>
		/// Price: 97<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/shoes-grounder-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderShoes { get; } = new Item("GrounderShoes", 2210);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 70<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-0001-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinKingsNecklace { get; } = new Item("GoblinKingsNecklace", 2301);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 70<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-0002-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Cecil { get; } = new Item("Cecil", 2302);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 50<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-skin-bulldrome-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ThickLeather { get; } = new Item("ThickLeather", 2303);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 50<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-life-support-device-b-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DamagedLifeSupportDevice { get; } = new Item("DamagedLifeSupportDevice", 2304);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 50<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-skin-mutants-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasytorMucosa { get; } = new Item("ParasytorMucosa", 2305);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 70<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-agricultural-manual-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item AgriculturalManual { get; } = new Item("AgriculturalManual", 2306);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 70<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-toolbox-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OrdToolbox { get; } = new Item("OrdToolbox", 2307);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 120<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-0004-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasectStone { get; } = new Item("ParasectStone", 2308);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 120<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-0005-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item PoisonSpore { get; } = new Item("PoisonSpore", 2309);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 190<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-flashlight-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Flashlight { get; } = new Item("Flashlight", 2310);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 190<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-metaldetector-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MetalDetector { get; } = new Item("MetalDetector", 2311);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 50<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-0015-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasytorSymbioticWorm { get; } = new Item("ParasytorSymbioticWorm", 2312);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 70<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-0014-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinFork { get; } = new Item("GoblinFork", 2313);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 70<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-0013-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinBracelet { get; } = new Item("GoblinBracelet", 2314);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 70<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-0003-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinShield { get; } = new Item("GoblinShield", 2315);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 120<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-0012-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorElytronShield { get; } = new Item("InsectorElytronShield", 2316);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 120<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-0011-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorWings { get; } = new Item("InsectorWings", 2317);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 120<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-0006-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasectThorn { get; } = new Item("ParasectThorn", 2318);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 190<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-life-support-device-a-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoLifeSupportDevice { get; } = new Item("MecoLifeSupportDevice", 2319);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 190<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-0010-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoShield { get; } = new Item("MecoShield", 2320);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 190<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-0007-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoElectricSpoon { get; } = new Item("MecoElectricSpoon", 2321);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 190<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-0008-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoPoweredExoskeletonArm { get; } = new Item("MecoPoweredExoskeletonArm", 2322);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 190<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-0009-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoBiotechPoweredExoskeletonArm { get; } = new Item("MecoBiotechPoweredExoskeletonArm", 2323);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 175<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-amber-shield-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item AmberShield { get; } = new Item("AmberShield", 2324);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 19<para/>
		/// MaxCount: 1<para/>
		/// Price: 175<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/accessories-detector-custom-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ModifiedDetector { get; } = new Item("ModifiedDetector", 2325);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-100-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item FurOutfit { get; } = new Item("FurOutfit", 2401);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-101-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item HunterLightweightOutfit { get; } = new Item("HunterLightweightOutfit", 2402);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-102-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DesertLightweightOutfit { get; } = new Item("DesertLightweightOutfit", 2403);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-103-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MeowTeasSilkCloak { get; } = new Item("MeowTeasSilkCloak", 2404);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-104-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item RainforestGrassSkirt { get; } = new Item("RainforestGrassSkirt", 2405);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-105-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item HalfElfLightweightArmor { get; } = new Item("HalfElfLightweightArmor", 2406);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-106-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OrcSoftArmor { get; } = new Item("OrcSoftArmor", 2407);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-107-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DarkElfSoftArmor { get; } = new Item("DarkElfSoftArmor", 2408);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-108-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ElfLightweightArmor { get; } = new Item("ElfLightweightArmor", 2409);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-109-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WorkBib { get; } = new Item("WorkBib", 2410);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-110-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item JungleSoftArmor { get; } = new Item("JungleSoftArmor", 2411);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-111-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BarbarianOutfit { get; } = new Item("BarbarianOutfit", 2412);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-112-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BoarmanPlate { get; } = new Item("BoarmanPlate", 2413);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-200-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item FurLightweightArmor { get; } = new Item("FurLightweightArmor", 2501);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-201-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item HunterOutfit { get; } = new Item("HunterOutfit", 2502);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-202-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DesertLeatherSkirt { get; } = new Item("DesertLeatherSkirt", 2503);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-203-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MeowTeasShortCloak { get; } = new Item("MeowTeasShortCloak", 2504);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-204-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item RainforestOutfit { get; } = new Item("RainforestOutfit", 2505);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-205-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item HalfElfOutfit { get; } = new Item("HalfElfOutfit", 2506);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-206-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OrcLightweightArmor { get; } = new Item("OrcLightweightArmor", 2507);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-207-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DarkElfOutfit { get; } = new Item("DarkElfOutfit", 2508);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-208-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ElfShortCloak { get; } = new Item("ElfShortCloak", 2509);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-209-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoResearcherOutfit0 { get; } = new Item("MecoResearcherOutfit0", 2510);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-210-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item JungleOutfit { get; } = new Item("JungleOutfit", 2511);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-211-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BarbarianPlate { get; } = new Item("BarbarianPlate", 2512);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-212-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BoarmanOutfit { get; } = new Item("BoarmanOutfit", 2513);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-300-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item FurPlate { get; } = new Item("FurPlate", 2601);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-301-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item HunterCloak { get; } = new Item("HunterCloak", 2602);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-302-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DesertLeatherVest { get; } = new Item("DesertLeatherVest", 2603);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-303-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MeowTeasShawlish { get; } = new Item("MeowTeasShawlish", 2604);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-304-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item RainforestCloak { get; } = new Item("RainforestCloak", 2605);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-305-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item HalfElfPlate { get; } = new Item("HalfElfPlate", 2606);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-306-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OrcPlate { get; } = new Item("OrcPlate", 2607);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-307-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DarkElfLightweightOutfit { get; } = new Item("DarkElfLightweightOutfit", 2608);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-308-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ElfPlate { get; } = new Item("ElfPlate", 2609);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-309-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CombatOutfit { get; } = new Item("CombatOutfit", 2610);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-310-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item JungleCombatOutfit { get; } = new Item("JungleCombatOutfit", 2611);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-311-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BarbarianLightweightArmor { get; } = new Item("BarbarianLightweightArmor", 2612);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 375<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-312-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BoarmanLightweightArmor { get; } = new Item("BoarmanLightweightArmor", 2613);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-29-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoResearcherOutfit1 { get; } = new Item("MecoResearcherOutfit1", 2701);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-30-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoResearcherOutfit2 { get; } = new Item("MecoResearcherOutfit2", 2702);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-31-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoResearcherOutfit3 { get; } = new Item("MecoResearcherOutfit3", 2703);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-32-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoResearcherOutfit4 { get; } = new Item("MecoResearcherOutfit4", 2704);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-NPC-cook-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoResearcherOutfit5 { get; } = new Item("MecoResearcherOutfit5", 2705);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-NPC-ArchitecturalBusinessman-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoResearcherOutfit6 { get; } = new Item("MecoResearcherOutfit6", 2706);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-NPC-miner-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoResearcherOutfit7 { get; } = new Item("MecoResearcherOutfit7", 2707);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-NPC-herdsman-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoResearcherOutfit8 { get; } = new Item("MecoResearcherOutfit8", 2708);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-NPC-farmer-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoResearcherOutfit9 { get; } = new Item("MecoResearcherOutfit9", 2709);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-NPC-blacksmith-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoResearcherOutfit10 { get; } = new Item("MecoResearcherOutfit10", 2710);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-NPC-doctor-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoResearcherOutfit11 { get; } = new Item("MecoResearcherOutfit11", 2711);
		/// <summary>
		/// Type: 5<para/>
		/// ItemType: 16<para/>
		/// MaxCount: 1<para/>
		/// Price: 37<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/armor-Rifter-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item RifterOutfit { get; } = new Item("RifterOutfit", 2712);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 41<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/hill-earth-icon"<para/>
		/// PlacenmentId: 1001<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1, 6 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DirtBlock { get; } = new Item("DirtBlock", 3001);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 41<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 1002<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item FrozenSoilBlock { get; } = new Item("FrozenSoilBlock", 3002);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 41<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/hill-sand-icon"<para/>
		/// PlacenmentId: 1003<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9009, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SandBlock { get; } = new Item("SandBlock", 3003);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 41<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/hill-stone-icon"<para/>
		/// PlacenmentId: 1004<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1, 6 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneBlock { get; } = new Item("StoneBlock", 3004);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 22<para/>
		/// MaxCount: 99<para/>
		/// Price: 12<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/hill-copper-icon"<para/>
		/// PlacenmentId: 1005<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperOre { get; } = new Item("CopperOre", 3005);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 22<para/>
		/// MaxCount: 99<para/>
		/// Price: 20<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/hill-iron-icon"<para/>
		/// PlacenmentId: 1006<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronOre { get; } = new Item("IronOre", 3006);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 22<para/>
		/// MaxCount: 99<para/>
		/// Price: 35<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/hill-silver-icon"<para/>
		/// PlacenmentId: 1007<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverOre { get; } = new Item("SilverOre", 3007);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 22<para/>
		/// MaxCount: 99<para/>
		/// Price: 60<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/hill-gold-icon"<para/>
		/// PlacenmentId: 1008<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldOre { get; } = new Item("GoldOre", 3008);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 27<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/hill-diamond-icon"<para/>
		/// PlacenmentId: 1009<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Diamond { get; } = new Item("Diamond", 3009);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 41<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/hill-snow-icon"<para/>
		/// PlacenmentId: 1010<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1, 6 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SnowBlock { get; } = new Item("SnowBlock", 3010);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 41<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/hill-ice-icon"<para/>
		/// PlacenmentId: 1011<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1, 6 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IceBlock { get; } = new Item("IceBlock", 3011);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 99<para/>
		/// Price: 4<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 25<para/>
		/// DropTexture: "Icon/hill-coal-icon"<para/>
		/// PlacenmentId: 1012<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CoalOre { get; } = new Item("CoalOre", 3012);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Clay { get; } = new Item("Clay", 3013);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 99<para/>
		/// Price: 10<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/hill-sulphur-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SulfurOre { get; } = new Item("SulfurOre", 3014);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/hill-saltpeter-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SaltpeterOre { get; } = new Item("SaltpeterOre", 3015);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/hill-mutants&demon-icon"<para/>
		/// PlacenmentId: 1016<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorWall { get; } = new Item("InsectorWall", 3016);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/hill-mutants-icon"<para/>
		/// PlacenmentId: 1017<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasytorWall0 { get; } = new Item("ParasytorWall0", 3017);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 25<para/>
		/// DropTexture: "Icon/wall-wood-icon"<para/>
		/// PlacenmentId: 2001<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodWall { get; } = new Item("WoodWall", 3101);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wall-earth-icon"<para/>
		/// PlacenmentId: 2002<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DirtWall { get; } = new Item("DirtWall", 3102);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wall-stone-icon"<para/>
		/// PlacenmentId: 2003<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneWall { get; } = new Item("StoneWall", 3103);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wall-copper-icon"<para/>
		/// PlacenmentId: 2004<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperWall { get; } = new Item("CopperWall", 3104);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wall-iron-icon"<para/>
		/// PlacenmentId: 2005<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronWall { get; } = new Item("IronWall", 3105);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wall-silver-icon"<para/>
		/// PlacenmentId: 2006<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverWall { get; } = new Item("SilverWall", 3106);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wall-gold-icon"<para/>
		/// PlacenmentId: 2007<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenWall { get; } = new Item("GoldenWall", 3107);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 2008<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DiamondWall { get; } = new Item("DiamondWall", 3108);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wall-glass-icon"<para/>
		/// PlacenmentId: 2009<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9009, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GlassWall { get; } = new Item("GlassWall", 3109);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wall-snow-icon"<para/>
		/// PlacenmentId: 2010<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SnowWall { get; } = new Item("SnowWall", 3110);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wall-ice-icon"<para/>
		/// PlacenmentId: 2011<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IceWall0 { get; } = new Item("IceWall0", 3111);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 10<para/>
		/// DropTexture: "Icon/fence-wood-icon"<para/>
		/// PlacenmentId: 2012<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenFence { get; } = new Item("WoodenFence", 3112);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 2013<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item LogFence { get; } = new Item("LogFence", 3113);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/fence-copper-icon"<para/>
		/// PlacenmentId: 2014<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 1 ]<para/>
		/// SmeltConsume: 5<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperFence { get; } = new Item("CopperFence", 3114);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/fence-iron-icon"<para/>
		/// PlacenmentId: 2015<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 1 ]<para/>
		/// SmeltConsume: 5<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronFence { get; } = new Item("IronFence", 3115);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/fence-silver-icon"<para/>
		/// PlacenmentId: 2016<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 1 ]<para/>
		/// SmeltConsume: 5<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverFence { get; } = new Item("SilverFence", 3116);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/fence-gold-icon"<para/>
		/// PlacenmentId: 2017<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 1 ]<para/>
		/// SmeltConsume: 5<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenFence { get; } = new Item("GoldenFence", 3117);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 2018<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DiamondFence { get; } = new Item("DiamondFence", 3118);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/fence-bones-icon"<para/>
		/// PlacenmentId: 2076<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BoneFence { get; } = new Item("BoneFence", 3120);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/hill-bones&earth-icon"<para/>
		/// PlacenmentId: 2078<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BoneWall { get; } = new Item("BoneWall", 3121);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wall-rampart-icon"<para/>
		/// PlacenmentId: 2080<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item TownWall0 { get; } = new Item("TownWall0", 3122);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wall-rampart-icon"<para/>
		/// PlacenmentId: 2081<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item TownWall1 { get; } = new Item("TownWall1", 3123);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wall-meco1-icon"<para/>
		/// PlacenmentId: 2082<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasytorWall1 { get; } = new Item("ParasytorWall1", 3124);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wall-meco2-icon"<para/>
		/// PlacenmentId: 2083<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasytorWall2 { get; } = new Item("ParasytorWall2", 3125);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wall-meco3-icon"<para/>
		/// PlacenmentId: 2084<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasytorWall3 { get; } = new Item("ParasytorWall3", 3126);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wall-meco1-icon"<para/>
		/// PlacenmentId: 2065<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasytorWall4 { get; } = new Item("ParasytorWall4", 3127);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wall-meco1-icon"<para/>
		/// PlacenmentId: 2066<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasytorWall5 { get; } = new Item("ParasytorWall5", 3128);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wall-meco1-icon"<para/>
		/// PlacenmentId: 2067<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasytorWall6 { get; } = new Item("ParasytorWall6", 3129);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wall-meco2-icon"<para/>
		/// PlacenmentId: 2085<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasytorWall7 { get; } = new Item("ParasytorWall7", 3130);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wall-meco2-icon"<para/>
		/// PlacenmentId: 2086<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasytorWall8 { get; } = new Item("ParasytorWall8", 3131);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wall-meco2-icon"<para/>
		/// PlacenmentId: 2087<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasytorWall9 { get; } = new Item("ParasytorWall9", 3132);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 42<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wall-sand&glass-icon"<para/>
		/// PlacenmentId: 2088<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IceWall1 { get; } = new Item("IceWall1", 3133);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 43<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/tree-seed01-icon"<para/>
		/// PlacenmentId: 1<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 4 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Acorn { get; } = new Item("Acorn", 3201);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 43<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/tree-seed03-icon"<para/>
		/// PlacenmentId: 11<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 4 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item PineCone { get; } = new Item("PineCone", 3202);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 43<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/tree-seed02-icon"<para/>
		/// PlacenmentId: 21<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 4 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item AppleSeed { get; } = new Item("AppleSeed", 3203);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 43<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/tree-seed04-icon"<para/>
		/// PlacenmentId: 31<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 4 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BerrySeeds { get; } = new Item("BerrySeeds", 3204);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 43<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/cactus-seed01-icon"<para/>
		/// PlacenmentId: 41<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 4 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Cactus { get; } = new Item("Cactus", 3205);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 43<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/tree-seed05-icon"<para/>
		/// PlacenmentId: 61<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 4 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item FirCone { get; } = new Item("FirCone", 3206);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 43<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/tree-seed06-icon"<para/>
		/// PlacenmentId: 81<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 4 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item LarchPineCone { get; } = new Item("LarchPineCone", 3207);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 43<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 6016<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 4 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item3208 { get; } = new Item("Item3208", 3208);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 43<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/flower-01-icon"<para/>
		/// PlacenmentId: 121<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Flower0 { get; } = new Item("Flower0", 3209);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 43<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/flower-02-icon"<para/>
		/// PlacenmentId: 122<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Flower1 { get; } = new Item("Flower1", 3210);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 43<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/flower-03-icon"<para/>
		/// PlacenmentId: 123<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Flower2 { get; } = new Item("Flower2", 3211);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 43<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/flower-04-icon"<para/>
		/// PlacenmentId: 124<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Flower3 { get; } = new Item("Flower3", 3212);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 43<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/flower-05-icon"<para/>
		/// PlacenmentId: 125<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Flower4 { get; } = new Item("Flower4", 3213);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 43<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/flower-06-icon"<para/>
		/// PlacenmentId: 126<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Flower5 { get; } = new Item("Flower5", 3214);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 43<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/flower-07-icon"<para/>
		/// PlacenmentId: 127<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Flower6 { get; } = new Item("Flower6", 3215);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 43<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/flower-08-icon"<para/>
		/// PlacenmentId: 128<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Flower7 { get; } = new Item("Flower7", 3216);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 43<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/flower-09-icon"<para/>
		/// PlacenmentId: 129<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Flower8 { get; } = new Item("Flower8", 3217);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 43<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/demon-seed-icon"<para/>
		/// PlacenmentId: 221<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 4 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorEye { get; } = new Item("InsectorEye", 3218);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 5<para/>
		/// DropTexture: "Icon/demon-eye-icon"<para/>
		/// PlacenmentId: 213<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorNidus { get; } = new Item("InsectorNidus", 3219);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 99<para/>
		/// Price: 1<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/mutants-seed-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasytorPrimordium { get; } = new Item("ParasytorPrimordium", 3220);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 47<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/grass-seed-icon"<para/>
		/// PlacenmentId: 241<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 4, 6 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrassSeed { get; } = new Item("GrassSeed", 3221);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 43<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/fhorns-send-icon"<para/>
		/// PlacenmentId: 251<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 4 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ThornsSeed { get; } = new Item("ThornsSeed", 3222);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 48<para/>
		/// MaxCount: 99<para/>
		/// Price: 1<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bloodmushroom-send-icon"<para/>
		/// PlacenmentId: 261<para/>
		/// BbqResult: [ 10011, 1 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 4, 7 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BloodMushroom { get; } = new Item("BloodMushroom", 3223);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 43<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/fluorescent-send-icon"<para/>
		/// PlacenmentId: 271<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 4 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item FluorescentFernSeed { get; } = new Item("FluorescentFernSeed", 3224);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 43<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/amberplant-seed-icon"<para/>
		/// PlacenmentId: 281<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 4 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item AmberPlantSeed { get; } = new Item("AmberPlantSeed", 3225);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 47<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/mutants-seed2-icon"<para/>
		/// PlacenmentId: 236<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 4 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasytorSeed { get; } = new Item("ParasytorSeed", 3226);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 101<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 25<para/>
		/// DropTexture: "Icon/torch-wood-icon"<para/>
		/// PlacenmentId: 3001<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1, 6 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Torch { get; } = new Item("Torch", 3501);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 40<para/>
		/// DropTexture: "Icon/campfire-wood-icon"<para/>
		/// PlacenmentId: 3002<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Campfire { get; } = new Item("Campfire", 3502);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 25<para/>
		/// DropTexture: "Icon/torch-wood-tall-icon"<para/>
		/// PlacenmentId: 3003<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenTikiTorch { get; } = new Item("WoodenTikiTorch", 3503);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/torch-bones-tall-icon"<para/>
		/// PlacenmentId: 3004<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinTikiTorch { get; } = new Item("GoblinTikiTorch", 3504);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/torch-wood-tall-icon"<para/>
		/// PlacenmentId: 3005<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneTikiTorch { get; } = new Item("StoneTikiTorch", 3505);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/torch-copper-tall-icon"<para/>
		/// PlacenmentId: 3006<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperTikiTorch { get; } = new Item("CopperTikiTorch", 3506);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/torch-iron-tall-icon"<para/>
		/// PlacenmentId: 3007<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronTikiTorch { get; } = new Item("IronTikiTorch", 3507);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/torch-silver-tall-icon"<para/>
		/// PlacenmentId: 3008<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverTikiTorch { get; } = new Item("SilverTikiTorch", 3508);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/torch-gold-tall-icon"<para/>
		/// PlacenmentId: 3009<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenTikiTorch { get; } = new Item("GoldenTikiTorch", 3509);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 50<para/>
		/// DropTexture: "Icon/workbench-wood-icon"<para/>
		/// PlacenmentId: 3010<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenSimpleWorkbench { get; } = new Item("WoodenSimpleWorkbench", 3510);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3011<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneSimpleWorkbench { get; } = new Item("StoneSimpleWorkbench", 3511);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/workbench-copper-icon"<para/>
		/// PlacenmentId: 3012<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperSimpleWorkbench { get; } = new Item("CopperSimpleWorkbench", 3512);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/workbench-iron-icon"<para/>
		/// PlacenmentId: 3013<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronSimpleWorkbench { get; } = new Item("IronSimpleWorkbench", 3513);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/workbench-silver-icon"<para/>
		/// PlacenmentId: 3014<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverSimpleWorkbench { get; } = new Item("SilverSimpleWorkbench", 3514);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/workbench-gold-icon"<para/>
		/// PlacenmentId: 3015<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenSimpleWorkbench { get; } = new Item("GoldenSimpleWorkbench", 3515);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3016<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DiamondSimpleWorkbench { get; } = new Item("DiamondSimpleWorkbench", 3516);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/cookingbench-stone-icon"<para/>
		/// PlacenmentId: 3017<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneStove { get; } = new Item("StoneStove", 3517);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/cookingbench-copper-icon"<para/>
		/// PlacenmentId: 3018<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperStove { get; } = new Item("CopperStove", 3518);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/cookingbench-iron-icon"<para/>
		/// PlacenmentId: 3019<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronStove { get; } = new Item("IronStove", 3519);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/cookingbench-silver-icon"<para/>
		/// PlacenmentId: 3020<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverStove { get; } = new Item("SilverStove", 3520);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/cookingbench-gold-icon"<para/>
		/// PlacenmentId: 3021<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenStove { get; } = new Item("GoldenStove", 3521);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3022<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DiamondStove { get; } = new Item("DiamondStove", 3522);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/furnace-stone-icon"<para/>
		/// PlacenmentId: 3023<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Furnace { get; } = new Item("Furnace", 3523);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/anvil-copper-icon"<para/>
		/// PlacenmentId: 3024<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperAnvil { get; } = new Item("CopperAnvil", 3524);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/anvil-iron-icon"<para/>
		/// PlacenmentId: 3025<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronAnvil { get; } = new Item("IronAnvil", 3525);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/anvil-silver-icon"<para/>
		/// PlacenmentId: 3026<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverAnvil { get; } = new Item("SilverAnvil", 3526);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/anvil-gold-icon"<para/>
		/// PlacenmentId: 3027<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenAnvil { get; } = new Item("GoldenAnvil", 3527);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3028<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DiamondAnvil { get; } = new Item("DiamondAnvil", 3528);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 50<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3029<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenBrewery { get; } = new Item("WoodenBrewery", 3529);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3030<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneBrewery { get; } = new Item("StoneBrewery", 3530);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3031<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperBrewery { get; } = new Item("CopperBrewery", 3531);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3032<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronBrewery { get; } = new Item("IronBrewery", 3532);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3033<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverBrewery { get; } = new Item("SilverBrewery", 3533);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3034<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenBrewery { get; } = new Item("GoldenBrewery", 3534);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3035<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DiamondBrewery { get; } = new Item("DiamondBrewery", 3535);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 50<para/>
		/// DropTexture: "Icon/furniturebench-wood-icon"<para/>
		/// PlacenmentId: 3036<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenFurnitureWorkbench { get; } = new Item("WoodenFurnitureWorkbench", 3536);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3037<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneFurnitureWorkbench { get; } = new Item("StoneFurnitureWorkbench", 3537);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/furniturebench-copper-icon"<para/>
		/// PlacenmentId: 3038<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperFurnitureWorkbench { get; } = new Item("CopperFurnitureWorkbench", 3538);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/furniturebench-iron-icon"<para/>
		/// PlacenmentId: 3039<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronFurnitureWorkbench { get; } = new Item("IronFurnitureWorkbench", 3539);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/furniturebench-silver-icon"<para/>
		/// PlacenmentId: 3040<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverFurnitureWorkbench { get; } = new Item("SilverFurnitureWorkbench", 3540);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/furniturebench-gold-icon"<para/>
		/// PlacenmentId: 3041<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenFurnitureWorkbench { get; } = new Item("GoldenFurnitureWorkbench", 3541);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3042<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DiamondFurnitureBench { get; } = new Item("DiamondFurnitureBench", 3542);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 50<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3043<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item3543 { get; } = new Item("Item3543", 3543);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3044<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item3544 { get; } = new Item("Item3544", 3544);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3045<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item3545 { get; } = new Item("Item3545", 3545);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3046<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item3546 { get; } = new Item("Item3546", 3546);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3047<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item3547 { get; } = new Item("Item3547", 3547);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3048<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item3548 { get; } = new Item("Item3548", 3548);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3049<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item3549 { get; } = new Item("Item3549", 3549);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 50<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3050<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenFirearmWorkbench { get; } = new Item("WoodenFirearmWorkbench", 3550);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3051<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneFirearmWorkbench { get; } = new Item("StoneFirearmWorkbench", 3551);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/explosivebench-copper-icon"<para/>
		/// PlacenmentId: 3052<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperFirearmWorkbench { get; } = new Item("CopperFirearmWorkbench", 3552);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/explosivebench-iron-icon"<para/>
		/// PlacenmentId: 3053<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronFirearmWorkbench { get; } = new Item("IronFirearmWorkbench", 3553);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/explosivebench-silver-icon"<para/>
		/// PlacenmentId: 3054<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverFirearmWorkbench { get; } = new Item("SilverFirearmWorkbench", 3554);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/explosivebench-gold-icon"<para/>
		/// PlacenmentId: 3055<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenFirearmWorkbench { get; } = new Item("GoldenFirearmWorkbench", 3555);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3056<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DiamondFirearmWorkbench { get; } = new Item("DiamondFirearmWorkbench", 3556);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3057<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item3557 { get; } = new Item("Item3557", 3557);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3058<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item3558 { get; } = new Item("Item3558", 3558);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3059<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item3559 { get; } = new Item("Item3559", 3559);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3060<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item3560 { get; } = new Item("Item3560", 3560);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3061<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item3561 { get; } = new Item("Item3561", 3561);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3062<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item3562 { get; } = new Item("Item3562", 3562);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/workbench-bones-icon"<para/>
		/// PlacenmentId: 3063<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinWorkbench { get; } = new Item("GoblinWorkbench", 3563);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/demon-evilbench-icon"<para/>
		/// PlacenmentId: 3064<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item FusionPool { get; } = new Item("FusionPool", 3564);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/demon-platingpool-icon"<para/>
		/// PlacenmentId: 3065<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item PlatingPool { get; } = new Item("PlatingPool", 3565);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-furnace2-icon"<para/>
		/// PlacenmentId: 3066<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WorkbenchFoundry { get; } = new Item("WorkbenchFoundry", 3566);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-furnace-icon"<para/>
		/// PlacenmentId: 3067<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoTFurnace0 { get; } = new Item("MecoTFurnace0", 3567);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-printer-mecobiology-icon"<para/>
		/// PlacenmentId: 3068<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoBiotechFoundry { get; } = new Item("MecoBiotechFoundry", 3568);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/workbench-grounder-icon"<para/>
		/// PlacenmentId: 3069<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderWorkbench { get; } = new Item("GrounderWorkbench", 3569);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3070<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoTenergyFoundry { get; } = new Item("MecoTenergyFoundry", 3570);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3071<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoDTechFoundry { get; } = new Item("MecoDTechFoundry", 3571);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-furnace3-icon"<para/>
		/// PlacenmentId: 3072<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoTFurnace1 { get; } = new Item("MecoTFurnace1", 3572);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/door-wood-icon"<para/>
		/// PlacenmentId: 3101<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenDoor { get; } = new Item("WoodenDoor", 3601);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/door-stone-icon"<para/>
		/// PlacenmentId: 3102<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneDoor { get; } = new Item("StoneDoor", 3602);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/door-copper-icon"<para/>
		/// PlacenmentId: 3103<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperDoor { get; } = new Item("CopperDoor", 3603);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/door-iron-icon"<para/>
		/// PlacenmentId: 3104<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronDoor { get; } = new Item("IronDoor", 3604);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/door-silver-icon"<para/>
		/// PlacenmentId: 3105<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverDoor { get; } = new Item("SilverDoor", 3605);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/door-gold-icon"<para/>
		/// PlacenmentId: 3106<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenDoor { get; } = new Item("GoldenDoor", 3606);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/door-sand-icon"<para/>
		/// PlacenmentId: 3107<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SandDoor { get; } = new Item("SandDoor", 3607);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/door-ice-icon"<para/>
		/// PlacenmentId: 3108<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IceDoor { get; } = new Item("IceDoor", 3608);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/door-snow-icon"<para/>
		/// PlacenmentId: 3109<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SnowDoor { get; } = new Item("SnowDoor", 3609);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/door-glass-icon"<para/>
		/// PlacenmentId: 3110<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GlassDoor { get; } = new Item("GlassDoor", 3610);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/roundtable-wood-icon"<para/>
		/// PlacenmentId: 3111<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenRoundTable { get; } = new Item("WoodenRoundTable", 3611);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/roundtable-stone-icon"<para/>
		/// PlacenmentId: 3112<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneRoundTable { get; } = new Item("StoneRoundTable", 3612);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/roundtable-copper-icon"<para/>
		/// PlacenmentId: 3113<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperRoundTable { get; } = new Item("CopperRoundTable", 3613);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/roundtable-iron-icon"<para/>
		/// PlacenmentId: 3114<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronRoundTable { get; } = new Item("IronRoundTable", 3614);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/roundtable-silver-icon"<para/>
		/// PlacenmentId: 3115<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverRoundTable { get; } = new Item("SilverRoundTable", 3615);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/roundtable-gold-icon"<para/>
		/// PlacenmentId: 3116<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenRoundTable { get; } = new Item("GoldenRoundTable", 3616);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/roundtable-earth-icon"<para/>
		/// PlacenmentId: 3117<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DirtRoundTable { get; } = new Item("DirtRoundTable", 3617);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/roundtable-snow-icon"<para/>
		/// PlacenmentId: 3118<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SnowRoundTable { get; } = new Item("SnowRoundTable", 3618);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/roundtable-bones&earth-icon"<para/>
		/// PlacenmentId: 3119<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BoneRoundTable0 { get; } = new Item("BoneRoundTable0", 3619);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/roundtable-meco-icon"<para/>
		/// PlacenmentId: 3120<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BoneRoundTable1 { get; } = new Item("BoneRoundTable1", 3620);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/chair-wood-icon"<para/>
		/// PlacenmentId: 3121<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenChair { get; } = new Item("WoodenChair", 3621);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/chair-stone-icon"<para/>
		/// PlacenmentId: 3122<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneChair { get; } = new Item("StoneChair", 3622);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/chair-copper-icon"<para/>
		/// PlacenmentId: 3123<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperChair { get; } = new Item("CopperChair", 3623);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/chair-iron-icon"<para/>
		/// PlacenmentId: 3124<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronChair { get; } = new Item("IronChair", 3624);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/chair-silver-icon"<para/>
		/// PlacenmentId: 3125<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverChair { get; } = new Item("SilverChair", 3625);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/chair-gold-icon"<para/>
		/// PlacenmentId: 3126<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenChair { get; } = new Item("GoldenChair", 3626);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/chair-earth-icon"<para/>
		/// PlacenmentId: 3127<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DirtChair { get; } = new Item("DirtChair", 3627);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/chair-snow-icon"<para/>
		/// PlacenmentId: 3128<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SnowChair { get; } = new Item("SnowChair", 3628);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/chair-bones-icon"<para/>
		/// PlacenmentId: 3129<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BoneChair0 { get; } = new Item("BoneChair0", 3629);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/chair-meco-icon"<para/>
		/// PlacenmentId: 3130<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BoneChair1 { get; } = new Item("BoneChair1", 3630);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/chest-wood-icon"<para/>
		/// PlacenmentId: 3131<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenChest { get; } = new Item("WoodenChest", 3631);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/chest-copper-icon"<para/>
		/// PlacenmentId: 3132<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperChest { get; } = new Item("CopperChest", 3632);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/chest-iron-icon"<para/>
		/// PlacenmentId: 3133<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronChest { get; } = new Item("IronChest", 3633);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/chest-silver-icon"<para/>
		/// PlacenmentId: 3134<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverChest { get; } = new Item("SilverChest", 3634);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/chest-gold-icon"<para/>
		/// PlacenmentId: 3135<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenChest { get; } = new Item("GoldenChest", 3635);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/chest-wood&copper-icon"<para/>
		/// PlacenmentId: 3136<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item VintageCopperChest { get; } = new Item("VintageCopperChest", 3636);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/chest-wood&iron-icon"<para/>
		/// PlacenmentId: 3137<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item VintageIronChest { get; } = new Item("VintageIronChest", 3637);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/chest-wood&silver-icon"<para/>
		/// PlacenmentId: 3138<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item VintageSilverChest { get; } = new Item("VintageSilverChest", 3638);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/chest-silver&blue-icon"<para/>
		/// PlacenmentId: 3139<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BlueChest { get; } = new Item("BlueChest", 3639);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/chest-silver&green-icon"<para/>
		/// PlacenmentId: 3140<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GreenChest { get; } = new Item("GreenChest", 3640);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/chest-silver&purple-icon"<para/>
		/// PlacenmentId: 3141<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item PurpleChest { get; } = new Item("PurpleChest", 3641);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/chest-silver&red-icon"<para/>
		/// PlacenmentId: 3142<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item RedChest { get; } = new Item("RedChest", 3642);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/chest-gold&silver-icon"<para/>
		/// PlacenmentId: 3143<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item VintageGoldChest { get; } = new Item("VintageGoldChest", 3643);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/chest-bones-icon"<para/>
		/// PlacenmentId: 3144<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BoneChest { get; } = new Item("BoneChest", 3644);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/chest-titanium-icon"<para/>
		/// PlacenmentId: 6059<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DamagedSafe { get; } = new Item("DamagedSafe", 3645);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/demon-chest-icon"<para/>
		/// PlacenmentId: 3146<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorHaworth0 { get; } = new Item("InsectorHaworth0", 3646);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/chest-sand&glass-icon"<para/>
		/// PlacenmentId: 3147<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorHaworth1 { get; } = new Item("InsectorHaworth1", 3647);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 25<para/>
		/// DropTexture: "Icon/bed-wood-icon"<para/>
		/// PlacenmentId: 3151<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenBed { get; } = new Item("WoodenBed", 3651);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bed-stone-icon"<para/>
		/// PlacenmentId: 3152<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneBed { get; } = new Item("StoneBed", 3652);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bed-copper-icon"<para/>
		/// PlacenmentId: 3153<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperBed { get; } = new Item("CopperBed", 3653);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bed-iron-icon"<para/>
		/// PlacenmentId: 3154<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronBed { get; } = new Item("IronBed", 3654);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bed-silver-icon"<para/>
		/// PlacenmentId: 3155<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverBed { get; } = new Item("SilverBed", 3655);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bed-gold-icon"<para/>
		/// PlacenmentId: 3156<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenBed { get; } = new Item("GoldenBed", 3656);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3157<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item HibernationPod { get; } = new Item("HibernationPod", 3657);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bed-earth-icon"<para/>
		/// PlacenmentId: 3158<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DirtBed { get; } = new Item("DirtBed", 3658);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bed-snow-icon"<para/>
		/// PlacenmentId: 3159<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SnowBed { get; } = new Item("SnowBed", 3659);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bed-earth&bones-icon"<para/>
		/// PlacenmentId: 3160<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinBed { get; } = new Item("GoblinBed", 3660);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/door-wood&copper-icon"<para/>
		/// PlacenmentId: 3161<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item VintageCopperDoor { get; } = new Item("VintageCopperDoor", 3661);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/door-wood&iron-icon"<para/>
		/// PlacenmentId: 3162<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item VintageIronDoor { get; } = new Item("VintageIronDoor", 3662);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/door-wood&silver-icon"<para/>
		/// PlacenmentId: 3163<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item VintageSilverDoor { get; } = new Item("VintageSilverDoor", 3663);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3164<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item VintageGoldenDoor { get; } = new Item("VintageGoldenDoor", 3664);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/door-earth-icon"<para/>
		/// PlacenmentId: 3165<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DirtDoor { get; } = new Item("DirtDoor", 3665);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-door-icon"<para/>
		/// PlacenmentId: 3168<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item TitaniumDoor { get; } = new Item("TitaniumDoor", 3666);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/door-bones-icon"<para/>
		/// PlacenmentId: 3167<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BoneDoor0 { get; } = new Item("BoneDoor0", 3667);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/door-sand&glass-icon"<para/>
		/// PlacenmentId: 3169<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BoneDoor1 { get; } = new Item("BoneDoor1", 3669);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3201<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Snowman { get; } = new Item("Snowman", 3701);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/flowerpot-pottery"<para/>
		/// PlacenmentId: 3211<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 3717, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ClayFlowerPot { get; } = new Item("ClayFlowerPot", 3711);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3212<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 3718, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ClayBottle { get; } = new Item("ClayBottle", 3712);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3213<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 3719, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ClayJar { get; } = new Item("ClayJar", 3713);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3214<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GlassFlowerPot { get; } = new Item("GlassFlowerPot", 3714);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3215<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GlassBottle { get; } = new Item("GlassBottle", 3715);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3216<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GlassJar { get; } = new Item("GlassJar", 3716);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3217<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CeramicFlowerPot { get; } = new Item("CeramicFlowerPot", 3717);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3218<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CeramicBottle { get; } = new Item("CeramicBottle", 3718);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3219<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CeramicJar { get; } = new Item("CeramicJar", 3719);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3220<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 3722, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ClaySculpture { get; } = new Item("ClaySculpture", 3720);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3221<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GlassSculpture { get; } = new Item("GlassSculpture", 3721);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3222<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CeramicSculpture { get; } = new Item("CeramicSculpture", 3722);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/flowerpot-earth"<para/>
		/// PlacenmentId: 3223<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item FlowerPot { get; } = new Item("FlowerPot", 3723);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3224<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Bottle { get; } = new Item("Bottle", 3724);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3225<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Jar { get; } = new Item("Jar", 3725);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3226<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Sculpture { get; } = new Item("Sculpture", 3726);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/model-wood-icon"<para/>
		/// PlacenmentId: 3231<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenModel0 { get; } = new Item("WoodenModel0", 3731);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/flowerpot-bones"<para/>
		/// PlacenmentId: 3241<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BoneFlowerPot { get; } = new Item("BoneFlowerPot", 3741);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3251<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Barrel0 { get; } = new Item("Barrel0", 3751);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3252<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Barrel1 { get; } = new Item("Barrel1", 3752);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 25<para/>
		/// DropTexture: "Icon/cask-wood-icon"<para/>
		/// PlacenmentId: 3253<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Barrel2 { get; } = new Item("Barrel2", 3753);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 25<para/>
		/// DropTexture: "Icon/barcounter-wood-icon"<para/>
		/// PlacenmentId: 3261<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenTable0 { get; } = new Item("WoodenTable0", 3761);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3262<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneTable { get; } = new Item("StoneTable", 3762);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/barcounter-copper-icon"<para/>
		/// PlacenmentId: 3263<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperTable { get; } = new Item("CopperTable", 3763);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/barcounter-iron-icon"<para/>
		/// PlacenmentId: 3264<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronTable { get; } = new Item("IronTable", 3764);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/barcounter-silver-icon"<para/>
		/// PlacenmentId: 3265<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverTable { get; } = new Item("SilverTable", 3765);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/barcounter-gold-icon"<para/>
		/// PlacenmentId: 3266<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenTable { get; } = new Item("GoldenTable", 3766);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/barcounter-meco-icon"<para/>
		/// PlacenmentId: 3267<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoTable { get; } = new Item("MecoTable", 3767);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 46<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/cask-powder-icon"<para/>
		/// PlacenmentId: 3271<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ExplosiveBarrel { get; } = new Item("ExplosiveBarrel", 3771);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 50<para/>
		/// DropTexture: "Icon/feedingtrough-wood-icon"<para/>
		/// PlacenmentId: 3281<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenFeedingTrough { get; } = new Item("WoodenFeedingTrough", 3781);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 3282<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo3"<para/>
		/// MouseRight: "MouseRightClickInfo3"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneFeedingTrough { get; } = new Item("StoneFeedingTrough", 3782);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/feedingtrough-copper-icon"<para/>
		/// PlacenmentId: 3283<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo4"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperFeedingTrough { get; } = new Item("CopperFeedingTrough", 3783);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/feedingtrough-iron-icon"<para/>
		/// PlacenmentId: 3284<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo5"<para/>
		/// MouseRight: "MouseRightClickInfo5"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronFeedingTrough { get; } = new Item("IronFeedingTrough", 3784);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/feedingtrough-silver-icon"<para/>
		/// PlacenmentId: 3285<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo6"<para/>
		/// MouseRight: "MouseRightClickInfo6"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverFeedingTrough { get; } = new Item("SilverFeedingTrough", 3785);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/feedingtrough-gold-icon"<para/>
		/// PlacenmentId: 3286<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 3 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo7"<para/>
		/// MouseRight: "MouseRightClickInfo7"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenFeedingTrough { get; } = new Item("GoldenFeedingTrough", 3786);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 25<para/>
		/// DropTexture: "Icon/barcounter-wood-icon"<para/>
		/// PlacenmentId: 3291<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenTable1 { get; } = new Item("WoodenTable1", 3791);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 25<para/>
		/// DropTexture: "Icon/model-wood-icon"<para/>
		/// PlacenmentId: 3292<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenModel1 { get; } = new Item("WoodenModel1", 3792);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 25<para/>
		/// DropTexture: "Icon/barcounter-meco-icon"<para/>
		/// PlacenmentId: 3293<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenTable2 { get; } = new Item("WoodenTable2", 3793);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 25<para/>
		/// DropTexture: "Icon/GoodsShelves1-icon"<para/>
		/// PlacenmentId: 3294<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenTable3 { get; } = new Item("WoodenTable3", 3794);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 25<para/>
		/// DropTexture: "Icon/GoodsShelves1-icon"<para/>
		/// PlacenmentId: 3295<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenTable4 { get; } = new Item("WoodenTable4", 3795);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 25<para/>
		/// DropTexture: "Icon/GoodsShelves2-icon"<para/>
		/// PlacenmentId: 3296<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenTable5 { get; } = new Item("WoodenTable5", 3796);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 25<para/>
		/// DropTexture: "Icon/barcounter-wood-icon"<para/>
		/// PlacenmentId: 3297<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenTable6 { get; } = new Item("WoodenTable6", 3797);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 25<para/>
		/// DropTexture: "Icon/barcounter-wood-icon"<para/>
		/// PlacenmentId: 3298<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenTable7 { get; } = new Item("WoodenTable7", 3798);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 25<para/>
		/// DropTexture: "Icon/GoodsShelves2-icon"<para/>
		/// PlacenmentId: 3299<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenTable8 { get; } = new Item("WoodenTable8", 3799);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 25<para/>
		/// DropTexture: "Icon/GoodsShelves2-icon"<para/>
		/// PlacenmentId: 3300<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenTable9 { get; } = new Item("WoodenTable9", 3800);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-hibernation-pod-icon"<para/>
		/// PlacenmentId: 3301<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoHibernationPot { get; } = new Item("MecoHibernationPot", 3801);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-light-icon"<para/>
		/// PlacenmentId: 3311<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoLamp { get; } = new Item("MecoLamp", 3811);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-titaniumportal-icon"<para/>
		/// PlacenmentId: 3321<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoPortal { get; } = new Item("MecoPortal", 3821);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bed-sand&glass-icon"<para/>
		/// PlacenmentId: 3331<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item3831 { get; } = new Item("Item3831", 3831);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bed-grounder-icon"<para/>
		/// PlacenmentId: 3332<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 2 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderTent { get; } = new Item("GrounderTent", 3832);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/chair-sand&glass-icon"<para/>
		/// PlacenmentId: 3341<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item3841 { get; } = new Item("Item3841", 3841);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/roundtable-sand&glass-icon"<para/>
		/// PlacenmentId: 3351<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item3851 { get; } = new Item("Item3851", 3851);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/torch-sand&glass-tall-icon"<para/>
		/// PlacenmentId: 3361<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item3861 { get; } = new Item("Item3861", 3861);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/Elevator1-icon"<para/>
		/// PlacenmentId: 3371<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MinerSimpleLift { get; } = new Item("MinerSimpleLift", 3871);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/error-item"<para/>
		/// PlacenmentId: 3372<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MinerSimpleLiftPart { get; } = new Item("MinerSimpleLiftPart", 3872);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/demon-harvester-copper-icon"<para/>
		/// PlacenmentId: 3381<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperInsectorHarvester { get; } = new Item("CopperInsectorHarvester", 3881);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/demon-harvester-iron-icon"<para/>
		/// PlacenmentId: 3382<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronInsectorHarvester { get; } = new Item("IronInsectorHarvester", 3882);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/demon-harvester-silver-icon"<para/>
		/// PlacenmentId: 3383<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverInsectorHarvester { get; } = new Item("SilverInsectorHarvester", 3883);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/demon-harvester-gold-icon"<para/>
		/// PlacenmentId: 3384<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldenInsectorHarvester { get; } = new Item("GoldenInsectorHarvester", 3884);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/model-DamageTestDummy-icon1"<para/>
		/// PlacenmentId: 3391<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item TargetDummy0 { get; } = new Item("TargetDummy0", 3891);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/model-DamageTestDummy-icon2"<para/>
		/// PlacenmentId: 3392<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item TargetDummy1 { get; } = new Item("TargetDummy1", 3892);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/model-DamageTestDummy-icon3"<para/>
		/// PlacenmentId: 3393<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item TargetDummy2 { get; } = new Item("TargetDummy2", 3893);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 25<para/>
		/// DropTexture: "Icon/GoodsShelves2-icon"<para/>
		/// PlacenmentId: 3401<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenTable10 { get; } = new Item("WoodenTable10", 3901);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 25<para/>
		/// DropTexture: "Icon/GoodsShelves2-icon"<para/>
		/// PlacenmentId: 3402<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenTable11 { get; } = new Item("WoodenTable11", 3902);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 25<para/>
		/// DropTexture: "Icon/barcounter-wood-icon"<para/>
		/// PlacenmentId: 3403<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenTable12 { get; } = new Item("WoodenTable12", 3903);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/BeeHive-icon"<para/>
		/// PlacenmentId: 3411<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Beehive { get; } = new Item("Beehive", 3911);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 10<para/>
		/// DropTexture: "Icon/floor-wood1-icon"<para/>
		/// PlacenmentId: 5001<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenFloor0 { get; } = new Item("WoodenFloor0", 5001);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 10<para/>
		/// DropTexture: "Icon/floor-wood2-icon"<para/>
		/// PlacenmentId: 5002<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenFloor1 { get; } = new Item("WoodenFloor1", 5002);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 10<para/>
		/// DropTexture: "Icon/floor-wood3-icon"<para/>
		/// PlacenmentId: 5003<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenFloor2 { get; } = new Item("WoodenFloor2", 5003);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 10<para/>
		/// DropTexture: "Icon/floor-wood4-icon"<para/>
		/// PlacenmentId: 5004<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenFloor3 { get; } = new Item("WoodenFloor3", 5004);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-earth1-icon"<para/>
		/// PlacenmentId: 5005<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DirtFloor0 { get; } = new Item("DirtFloor0", 5005);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-earth2-icon"<para/>
		/// PlacenmentId: 5006<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DirtFloor1 { get; } = new Item("DirtFloor1", 5006);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-stone1-icon"<para/>
		/// PlacenmentId: 5007<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneFloor0 { get; } = new Item("StoneFloor0", 5007);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-stone2-icon"<para/>
		/// PlacenmentId: 5008<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneFloor1 { get; } = new Item("StoneFloor1", 5008);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-stone3-icon"<para/>
		/// PlacenmentId: 5009<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneFloor2 { get; } = new Item("StoneFloor2", 5009);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-stone4-icon"<para/>
		/// PlacenmentId: 5010<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneFloor3 { get; } = new Item("StoneFloor3", 5010);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-stone5-icon"<para/>
		/// PlacenmentId: 5011<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneFloor4 { get; } = new Item("StoneFloor4", 5011);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-copper1-icon"<para/>
		/// PlacenmentId: 5012<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperFloor0 { get; } = new Item("CopperFloor0", 5012);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-copper2-icon"<para/>
		/// PlacenmentId: 5013<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperFloor1 { get; } = new Item("CopperFloor1", 5013);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-iron1-icon"<para/>
		/// PlacenmentId: 5014<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronFloor0 { get; } = new Item("IronFloor0", 5014);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-iron2-icon"<para/>
		/// PlacenmentId: 5015<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronFloor1 { get; } = new Item("IronFloor1", 5015);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-iron3-icon"<para/>
		/// PlacenmentId: 5016<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronFloor2 { get; } = new Item("IronFloor2", 5016);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-iron4-icon"<para/>
		/// PlacenmentId: 5017<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronFloor3 { get; } = new Item("IronFloor3", 5017);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-silver1-icon"<para/>
		/// PlacenmentId: 5018<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverFloor0 { get; } = new Item("SilverFloor0", 5018);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-silver2-icon"<para/>
		/// PlacenmentId: 5019<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverFloor1 { get; } = new Item("SilverFloor1", 5019);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-gold1-icon"<para/>
		/// PlacenmentId: 5020<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldFloor0 { get; } = new Item("GoldFloor0", 5020);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-gold2-icon"<para/>
		/// PlacenmentId: 5021<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldFloor1 { get; } = new Item("GoldFloor1", 5021);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-gold3-icon"<para/>
		/// PlacenmentId: 5022<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldFloor2 { get; } = new Item("GoldFloor2", 5022);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-gold4-icon"<para/>
		/// PlacenmentId: 5023<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldFloor3 { get; } = new Item("GoldFloor3", 5023);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-glass1-icon"<para/>
		/// PlacenmentId: 5024<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GlassFloor { get; } = new Item("GlassFloor", 5024);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-snow1-icon"<para/>
		/// PlacenmentId: 5025<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SnowFloor { get; } = new Item("SnowFloor", 5025);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-ice1-icon"<para/>
		/// PlacenmentId: 5026<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IceFloor { get; } = new Item("IceFloor", 5026);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-sand1-icon"<para/>
		/// PlacenmentId: 5027<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SandFloor { get; } = new Item("SandFloor", 5027);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-stone7-icon"<para/>
		/// PlacenmentId: 5028<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneFloor5 { get; } = new Item("StoneFloor5", 5028);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-mecobiology1-icon"<para/>
		/// PlacenmentId: 5029<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneFloor6 { get; } = new Item("StoneFloor6", 5029);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-wood1-icon"<para/>
		/// PlacenmentId: 5501<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldWoodenFloor0 { get; } = new Item("OldWoodenFloor0", 5501);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-wood2-icon"<para/>
		/// PlacenmentId: 5502<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldWoodenFloor1 { get; } = new Item("OldWoodenFloor1", 5502);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-wood3-icon"<para/>
		/// PlacenmentId: 5503<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldWoodenFloor2 { get; } = new Item("OldWoodenFloor2", 5503);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-wood4-icon"<para/>
		/// PlacenmentId: 5504<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldWoodenFloor3 { get; } = new Item("OldWoodenFloor3", 5504);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-earth1-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldDirtFloor0 { get; } = new Item("OldDirtFloor0", 5505);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-earth2-icon"<para/>
		/// PlacenmentId: 5506<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldDirtFloor1 { get; } = new Item("OldDirtFloor1", 5506);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-stone1-icon"<para/>
		/// PlacenmentId: 5507<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldStoneFloor0 { get; } = new Item("OldStoneFloor0", 5507);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-stone2-icon"<para/>
		/// PlacenmentId: 5508<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldStoneFloor1 { get; } = new Item("OldStoneFloor1", 5508);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-stone3-icon"<para/>
		/// PlacenmentId: 5509<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldStoneFloor2 { get; } = new Item("OldStoneFloor2", 5509);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-stone4-icon"<para/>
		/// PlacenmentId: 5510<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldStoneFloor3 { get; } = new Item("OldStoneFloor3", 5510);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-stone5-icon"<para/>
		/// PlacenmentId: 5511<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldStoneFloor4 { get; } = new Item("OldStoneFloor4", 5511);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-copper1-icon"<para/>
		/// PlacenmentId: 5512<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldCopperFloor0 { get; } = new Item("OldCopperFloor0", 5512);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-copper2-icon"<para/>
		/// PlacenmentId: 5513<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldCopperFloor1 { get; } = new Item("OldCopperFloor1", 5513);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-iron1-icon"<para/>
		/// PlacenmentId: 5514<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldIronFloor0 { get; } = new Item("OldIronFloor0", 5514);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-iron2-icon"<para/>
		/// PlacenmentId: 5515<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldIronFloor1 { get; } = new Item("OldIronFloor1", 5515);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-iron3-icon"<para/>
		/// PlacenmentId: 5516<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldIronFloor2 { get; } = new Item("OldIronFloor2", 5516);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-iron4-icon"<para/>
		/// PlacenmentId: 5517<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldIronFloor3 { get; } = new Item("OldIronFloor3", 5517);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-silver1-icon"<para/>
		/// PlacenmentId: 5518<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldSilverFloor0 { get; } = new Item("OldSilverFloor0", 5518);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-silver2-icon"<para/>
		/// PlacenmentId: 5519<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldSilverFloor1 { get; } = new Item("OldSilverFloor1", 5519);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-gold1-icon"<para/>
		/// PlacenmentId: 5520<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldGoldFloor0 { get; } = new Item("OldGoldFloor0", 5520);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-gold2-icon"<para/>
		/// PlacenmentId: 5521<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldGoldFloor1 { get; } = new Item("OldGoldFloor1", 5521);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-gold3-icon"<para/>
		/// PlacenmentId: 5522<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldGoldFloor2 { get; } = new Item("OldGoldFloor2", 5522);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-gold4-icon"<para/>
		/// PlacenmentId: 5523<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldGoldFloor3 { get; } = new Item("OldGoldFloor3", 5523);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-glass1-icon"<para/>
		/// PlacenmentId: 5524<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldGlassFloor { get; } = new Item("OldGlassFloor", 5524);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-snow1-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldSnowFloor { get; } = new Item("OldSnowFloor", 5525);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-ice1-icon"<para/>
		/// PlacenmentId: 5526<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldIceFloor { get; } = new Item("OldIceFloor", 5526);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-sand1-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldSandFloor0 { get; } = new Item("OldSandFloor0", 5527);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-mecobiology2-icon"<para/>
		/// PlacenmentId: 5536<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldSandFloor1 { get; } = new Item("OldSandFloor1", 5528);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-mecobiology3-icon"<para/>
		/// PlacenmentId: 5537<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldSandFloor2 { get; } = new Item("OldSandFloor2", 5529);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 45<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/floor-mecobiology4-icon"<para/>
		/// PlacenmentId: 5538<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item OldSandFloor3 { get; } = new Item("OldSandFloor3", 5530);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 51<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 2<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 5<para/>
		/// Durability: 200<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/axe-wood-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodAxe { get; } = new Item("WoodAxe", 6001);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 51<para/>
		/// MaxCount: 1<para/>
		/// Price: 1<para/>
		/// AttTree: 3<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 5<para/>
		/// Durability: 400<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/axe-stone-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneAxe { get; } = new Item("StoneAxe", 6002);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 51<para/>
		/// MaxCount: 1<para/>
		/// Price: 26<para/>
		/// AttTree: 4<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 5<para/>
		/// Durability: 650<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/axe-copper-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperAxe { get; } = new Item("CopperAxe", 6003);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 51<para/>
		/// MaxCount: 1<para/>
		/// Price: 43<para/>
		/// AttTree: 5<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 5<para/>
		/// Durability: 750<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/axe-iron-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronAxe { get; } = new Item("IronAxe", 6004);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 51<para/>
		/// MaxCount: 1<para/>
		/// Price: 75<para/>
		/// AttTree: 7<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 5<para/>
		/// Durability: 800<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/axe-silver-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverAxe { get; } = new Item("SilverAxe", 6005);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 51<para/>
		/// MaxCount: 1<para/>
		/// Price: 129<para/>
		/// AttTree: 9<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 5<para/>
		/// Durability: 850<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/axe-gold-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldAxe { get; } = new Item("GoldAxe", 6006);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 51<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 12<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 5<para/>
		/// Durability: 900<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item6007 { get; } = new Item("Item6007", 6007);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 51<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 0<para/>
		/// AttWall: 0<para/>
		/// AttBuild: 0<para/>
		/// Durability: 350<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/axe-stone-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item6008 { get; } = new Item("Item6008", 6008);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 52<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 2<para/>
		/// AttBuild: 5<para/>
		/// Durability: 350<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/pickaxe-wood-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodPickaxe { get; } = new Item("WoodPickaxe", 6101);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 52<para/>
		/// MaxCount: 1<para/>
		/// Price: 1<para/>
		/// AttTree: 1<para/>
		/// AttWall: 3<para/>
		/// AttBuild: 5<para/>
		/// Durability: 500<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/pickaxe-stone-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StonePickaxe { get; } = new Item("StonePickaxe", 6102);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 52<para/>
		/// MaxCount: 1<para/>
		/// Price: 26<para/>
		/// AttTree: 1<para/>
		/// AttWall: 4<para/>
		/// AttBuild: 5<para/>
		/// Durability: 750<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/pickaxe-copper-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperPickaxe { get; } = new Item("CopperPickaxe", 6103);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 52<para/>
		/// MaxCount: 1<para/>
		/// Price: 43<para/>
		/// AttTree: 1<para/>
		/// AttWall: 5<para/>
		/// AttBuild: 5<para/>
		/// Durability: 850<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/pickaxe-iron-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronPickaxe { get; } = new Item("IronPickaxe", 6104);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 52<para/>
		/// MaxCount: 1<para/>
		/// Price: 75<para/>
		/// AttTree: 1<para/>
		/// AttWall: 7<para/>
		/// AttBuild: 5<para/>
		/// Durability: 900<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/pickaxe-silver-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverPickaxe { get; } = new Item("SilverPickaxe", 6105);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 52<para/>
		/// MaxCount: 1<para/>
		/// Price: 129<para/>
		/// AttTree: 1<para/>
		/// AttWall: 9<para/>
		/// AttBuild: 5<para/>
		/// Durability: 950<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/pickaxe-gold-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldPickaxe0 { get; } = new Item("GoldPickaxe0", 6106);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 52<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 8<para/>
		/// AttBuild: 5<para/>
		/// Durability: 2000<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item6107 { get; } = new Item("Item6107", 6107);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 52<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 0<para/>
		/// AttWall: 0<para/>
		/// AttBuild: 0<para/>
		/// Durability: 700<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/pickaxe-stone-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item6108 { get; } = new Item("Item6108", 6108);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 52<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 99<para/>
		/// AttWall: 99<para/>
		/// AttBuild: 99<para/>
		/// Durability: 9999<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/999ton-hammer-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldPickaxe1 { get; } = new Item("GoldPickaxe1", 6109);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 58<para/>
		/// MaxCount: 1<para/>
		/// Price: 60<para/>
		/// AttTree: 990<para/>
		/// AttWall: 990<para/>
		/// AttBuild: 990<para/>
		/// Durability: 99999<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/gun-mutants01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasectPlasmaGun1 { get; } = new Item("ParasectPlasmaGun1", 6110);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 53<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 100<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/shovel-iron-icon"<para/>
		/// PlacenmentId: 3171<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo3"<para/>
		/// MouseRight: "MouseRightClickInfo3"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenShovel { get; } = new Item("WoodenShovel", 6201);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 53<para/>
		/// MaxCount: 1<para/>
		/// Price: 1<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 100<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/shovel-iron-icon"<para/>
		/// PlacenmentId: 3172<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo3"<para/>
		/// MouseRight: "MouseRightClickInfo3"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item StoneShovel { get; } = new Item("StoneShovel", 6202);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 53<para/>
		/// MaxCount: 1<para/>
		/// Price: 26<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 100<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/shovel-copper-icon"<para/>
		/// PlacenmentId: 3173<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9011, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo3"<para/>
		/// MouseRight: "MouseRightClickInfo3"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperShovel { get; } = new Item("CopperShovel", 6203);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 53<para/>
		/// MaxCount: 1<para/>
		/// Price: 43<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 100<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/shovel-iron-icon"<para/>
		/// PlacenmentId: 3174<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9012, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo3"<para/>
		/// MouseRight: "MouseRightClickInfo3"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronShovel { get; } = new Item("IronShovel", 6204);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 53<para/>
		/// MaxCount: 1<para/>
		/// Price: 75<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 100<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/shovel-silver-icon"<para/>
		/// PlacenmentId: 3175<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo3"<para/>
		/// MouseRight: "MouseRightClickInfo3"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverShovel { get; } = new Item("SilverShovel", 6205);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 53<para/>
		/// MaxCount: 1<para/>
		/// Price: 129<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 100<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/shovel-gold-icon"<para/>
		/// PlacenmentId: 3176<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 1 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo3"<para/>
		/// MouseRight: "MouseRightClickInfo3"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldShovel { get; } = new Item("GoldShovel", 6206);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 53<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 100<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/shovel-iron-icon"<para/>
		/// PlacenmentId: 3177<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo3"<para/>
		/// MouseRight: "MouseRightClickInfo3"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item6207 { get; } = new Item("Item6207", 6207);
		/// <summary>
		/// Type: 7<para/>
		/// ItemType: 54<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bonecage-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo6"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BoneCage0 { get; } = new Item("BoneCage0", 6301);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 55<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bonecage-02-icon"<para/>
		/// PlacenmentId: 6302<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BoneCage1 { get; } = new Item("BoneCage1", 6302);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 55<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bonecage-03-icon"<para/>
		/// PlacenmentId: 6302<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BoneCage2 { get; } = new Item("BoneCage2", 6303);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 59<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bonecage-02-icon"<para/>
		/// PlacenmentId: 6302<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BoneCage3 { get; } = new Item("BoneCage3", 6304);
		/// <summary>
		/// Type: 2<para/>
		/// ItemType: 57<para/>
		/// MaxCount: 1<para/>
		/// Price: 49<para/>
		/// AttTree: 1<para/>
		/// AttWall: 2<para/>
		/// AttBuild: 2<para/>
		/// Durability: 1800<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/drill-mutants-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo1"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorDrill { get; } = new Item("InsectorDrill", 6401);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/demon-evilegg3-icon"<para/>
		/// PlacenmentId: 7301<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorNest0 { get; } = new Item("InsectorNest0", 7301);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bed-grounder-icon"<para/>
		/// PlacenmentId: 7305<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorNest1 { get; } = new Item("InsectorNest1", 7305);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-trap01-icon"<para/>
		/// PlacenmentId: 7601<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoCrossLaserTrap { get; } = new Item("MecoCrossLaserTrap", 7601);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-trap02-icon"<para/>
		/// PlacenmentId: 7602<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoSpikeTrap { get; } = new Item("MecoSpikeTrap", 7602);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-trap03-icon"<para/>
		/// PlacenmentId: 7603<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoSpinningBladeTrap { get; } = new Item("MecoSpinningBladeTrap", 7603);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-trap04-icon"<para/>
		/// PlacenmentId: 7604<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoWindTrap { get; } = new Item("MecoWindTrap", 7604);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-trap05-icon"<para/>
		/// PlacenmentId: 7605<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoMiniLaserTurret { get; } = new Item("MecoMiniLaserTurret", 7605);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-trap03-icon"<para/>
		/// PlacenmentId: 7606<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorNest2 { get; } = new Item("InsectorNest2", 7606);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-trap01-icon"<para/>
		/// PlacenmentId: 7607<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorNest3 { get; } = new Item("InsectorNest3", 7607);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-trap02-icon"<para/>
		/// PlacenmentId: 7608<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorNest4 { get; } = new Item("InsectorNest4", 7608);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-trap03-icon"<para/>
		/// PlacenmentId: 7609<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorNest5 { get; } = new Item("InsectorNest5", 7609);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-trap04-icon"<para/>
		/// PlacenmentId: 7610<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorNest6 { get; } = new Item("InsectorNest6", 7610);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-trap05-icon"<para/>
		/// PlacenmentId: 7611<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorNest7 { get; } = new Item("InsectorNest7", 7611);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-trap03-icon"<para/>
		/// PlacenmentId: 7612<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorNest8 { get; } = new Item("InsectorNest8", 7612);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-trap01-icon"<para/>
		/// PlacenmentId: 7613<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorNest9 { get; } = new Item("InsectorNest9", 7613);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-trap01-icon"<para/>
		/// PlacenmentId: 7614<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorNest10 { get; } = new Item("InsectorNest10", 7614);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-trap03-icon"<para/>
		/// PlacenmentId: 7615<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorNest11 { get; } = new Item("InsectorNest11", 7615);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-trap03-icon"<para/>
		/// PlacenmentId: 7616<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo3"<para/>
		/// MouseRight: "MouseRightClickInfo3"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorNest12 { get; } = new Item("InsectorNest12", 7616);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-trap03-icon"<para/>
		/// PlacenmentId: 7617<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo4"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorNest13 { get; } = new Item("InsectorNest13", 7617);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-trap03-icon"<para/>
		/// PlacenmentId: 7618<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo5"<para/>
		/// MouseRight: "MouseRightClickInfo5"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorNest14 { get; } = new Item("InsectorNest14", 7618);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-trap03-icon"<para/>
		/// PlacenmentId: 7619<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo6"<para/>
		/// MouseRight: "MouseRightClickInfo6"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorNest15 { get; } = new Item("InsectorNest15", 7619);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 88<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-generator-icon"<para/>
		/// PlacenmentId: 7621<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoTenergyStation { get; } = new Item("MecoTenergyStation", 7621);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/punjisticks-wood-icon"<para/>
		/// PlacenmentId: 7631<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item PunjiSticks { get; } = new Item("PunjiSticks", 7631);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/gobin-bear-trap-icon"<para/>
		/// PlacenmentId: 7632<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinBearTrap { get; } = new Item("GoblinBearTrap", 7632);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/demon-poisonous-sac-trap-icon"<para/>
		/// PlacenmentId: 7633<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item PoisonousSacTrap { get; } = new Item("PoisonousSacTrap", 7633);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 62<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/grounder-landmine-icon"<para/>
		/// PlacenmentId: 7634<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderLandmine { get; } = new Item("GrounderLandmine", 7634);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6088<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8001 { get; } = new Item("Item8001", 8001);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6089<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8002 { get; } = new Item("Item8002", 8002);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6090<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8003 { get; } = new Item("Item8003", 8003);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6091<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8004 { get; } = new Item("Item8004", 8004);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6092<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8005 { get; } = new Item("Item8005", 8005);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6093<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8006 { get; } = new Item("Item8006", 8006);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6094<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8007 { get; } = new Item("Item8007", 8007);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6095<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8008 { get; } = new Item("Item8008", 8008);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6096<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8009 { get; } = new Item("Item8009", 8009);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6097<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8010 { get; } = new Item("Item8010", 8010);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/InsectQueen-icon"<para/>
		/// PlacenmentId: 8001<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8011 { get; } = new Item("Item8011", 8011);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-computer01-icon"<para/>
		/// PlacenmentId: 8012<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8012 { get; } = new Item("Item8012", 8012);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-computer02-icon"<para/>
		/// PlacenmentId: 8013<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8013 { get; } = new Item("Item8013", 8013);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-container-mecobiology1-icon"<para/>
		/// PlacenmentId: 8014<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8014 { get; } = new Item("Item8014", 8014);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-container-mecobiology2-icon"<para/>
		/// PlacenmentId: 8015<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8015 { get; } = new Item("Item8015", 8015);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6138<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8017 { get; } = new Item("Item8017", 8017);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6139<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8018 { get; } = new Item("Item8018", 8018);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6140<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8019 { get; } = new Item("Item8019", 8019);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6141<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8020 { get; } = new Item("Item8020", 8020);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6142<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8021 { get; } = new Item("Item8021", 8021);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6143<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8022 { get; } = new Item("Item8022", 8022);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6144<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8023 { get; } = new Item("Item8023", 8023);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6145<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8024 { get; } = new Item("Item8024", 8024);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6146<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8025 { get; } = new Item("Item8025", 8025);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6147<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8026 { get; } = new Item("Item8026", 8026);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6148<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8027 { get; } = new Item("Item8027", 8027);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6149<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8028 { get; } = new Item("Item8028", 8028);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6150<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8029 { get; } = new Item("Item8029", 8029);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6151<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8030 { get; } = new Item("Item8030", 8030);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6152<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8031 { get; } = new Item("Item8031", 8031);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6153<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8032 { get; } = new Item("Item8032", 8032);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-generator-icon"<para/>
		/// PlacenmentId: 8017<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8033 { get; } = new Item("Item8033", 8033);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-generator-icon"<para/>
		/// PlacenmentId: 8018<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8034 { get; } = new Item("Item8034", 8034);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-testtube-mecobiology1-icon"<para/>
		/// PlacenmentId: 8019<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8035 { get; } = new Item("Item8035", 8035);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-testtube-mecobiology2-icon"<para/>
		/// PlacenmentId: 8020<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8036 { get; } = new Item("Item8036", 8036);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/Titanium-computer3-icon"<para/>
		/// PlacenmentId: 8031<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8037 { get; } = new Item("Item8037", 8037);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/Titanium-computer4-icon"<para/>
		/// PlacenmentId: 8032<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8038 { get; } = new Item("Item8038", 8038);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/Titanium-computer5-icon"<para/>
		/// PlacenmentId: 8033<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8039 { get; } = new Item("Item8039", 8039);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/Titanium-computer6-icon"<para/>
		/// PlacenmentId: 8034<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8040 { get; } = new Item("Item8040", 8040);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/Titanium-computer3-broken-icon"<para/>
		/// PlacenmentId: 8035<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8041 { get; } = new Item("Item8041", 8041);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/Titanium-computer4-broken-icon"<para/>
		/// PlacenmentId: 8036<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8042 { get; } = new Item("Item8042", 8042);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/Titanium-computer5-broken-icon"<para/>
		/// PlacenmentId: 8037<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8043 { get; } = new Item("Item8043", 8043);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6170<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8044 { get; } = new Item("Item8044", 8044);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6171<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8045 { get; } = new Item("Item8045", 8045);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6172<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8046 { get; } = new Item("Item8046", 8046);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6173<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8047 { get; } = new Item("Item8047", 8047);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6174<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8048 { get; } = new Item("Item8048", 8048);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 6175<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item8049 { get; } = new Item("Item8049", 8049);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/cabinet1-icon"<para/>
		/// PlacenmentId: 8101<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Cabinet0 { get; } = new Item("Cabinet0", 8101);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/cabinet2-icon"<para/>
		/// PlacenmentId: 8102<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Cabinet1 { get; } = new Item("Cabinet1", 8102);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/cabinet3-icon"<para/>
		/// PlacenmentId: 8103<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Cabinet2 { get; } = new Item("Cabinet2", 8103);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/fireplace-icon"<para/>
		/// PlacenmentId: 8104<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Fireplace { get; } = new Item("Fireplace", 8104);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/MedicineCabinet1-icon"<para/>
		/// PlacenmentId: 8105<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MedicineCabinet { get; } = new Item("MedicineCabinet", 8105);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/MedicineCabinet2-icon"<para/>
		/// PlacenmentId: 8106<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item FirstAidCabinet { get; } = new Item("FirstAidCabinet", 8106);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/sofa1-icon"<para/>
		/// PlacenmentId: 8201<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item TwoSeaterSofa0 { get; } = new Item("TwoSeaterSofa0", 8201);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/sofa2-icon"<para/>
		/// PlacenmentId: 8202<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SingleSeaterSofa0 { get; } = new Item("SingleSeaterSofa0", 8202);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/RockingChair-icon"<para/>
		/// PlacenmentId: 8203<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item RockingChair { get; } = new Item("RockingChair", 8203);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/sofa3-icon"<para/>
		/// PlacenmentId: 8204<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item TwoSeaterSofa1 { get; } = new Item("TwoSeaterSofa1", 8204);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/sofa4-icon"<para/>
		/// PlacenmentId: 8205<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SingleSeaterSofa1 { get; } = new Item("SingleSeaterSofa1", 8205);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/carpet-bearblanket-icon"<para/>
		/// PlacenmentId: 8251<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BearSkinRug { get; } = new Item("BearSkinRug", 8251);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/WoolCarpet-icon"<para/>
		/// PlacenmentId: 8252<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoatSkinRug { get; } = new Item("GoatSkinRug", 8252);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/carpet-Linencarpet-icon"<para/>
		/// PlacenmentId: 8253<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item LinenRug { get; } = new Item("LinenRug", 8253);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/GoodsShelves2-icon"<para/>
		/// PlacenmentId: 8301<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronShelf { get; } = new Item("IronShelf", 8301);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/GoodsShelves1-icon"<para/>
		/// PlacenmentId: 8302<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenShelf { get; } = new Item("WoodenShelf", 8302);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/WoodenFlowerPot-icon"<para/>
		/// PlacenmentId: 8303<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SquareFlowerPot { get; } = new Item("SquareFlowerPot", 8303);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/sign-blacksmith-icon"<para/>
		/// PlacenmentId: 8351<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BlacksmithShopSignboard { get; } = new Item("BlacksmithShopSignboard", 8351);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 303<para/>
		/// DropTexture: "Icon/sign-farmer-icon"<para/>
		/// PlacenmentId: 8352<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item FarmShopSignboard { get; } = new Item("FarmShopSignboard", 8352);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/sign-restaurant-icon"<para/>
		/// PlacenmentId: 8353<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item RestaurantSignboard { get; } = new Item("RestaurantSignboard", 8353);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/sign-herdsman-icon"<para/>
		/// PlacenmentId: 8354<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item AnimalStoreSignboard { get; } = new Item("AnimalStoreSignboard", 8354);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/sign-builder-icon"<para/>
		/// PlacenmentId: 8355<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item FurnitureStoreSignboard { get; } = new Item("FurnitureStoreSignboard", 8355);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/sign-clinic-icon"<para/>
		/// PlacenmentId: 8356<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ClinicSignboard { get; } = new Item("ClinicSignboard", 8356);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/sign-mining-icon"<para/>
		/// PlacenmentId: 8357<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MiningShopSignboard { get; } = new Item("MiningShopSignboard", 8357);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/Haystack1-icon"<para/>
		/// PlacenmentId: 8401<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Haystack0 { get; } = new Item("Haystack0", 8401);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/Haystack2-icon"<para/>
		/// PlacenmentId: 8402<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Haystack1 { get; } = new Item("Haystack1", 8402);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/Haystack3-icon"<para/>
		/// PlacenmentId: 8403<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Haystack2 { get; } = new Item("Haystack2", 8403);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/Haystack4-icon"<para/>
		/// PlacenmentId: 8404<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Haystack3 { get; } = new Item("Haystack3", 8404);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/Haystack5-icon"<para/>
		/// PlacenmentId: 8405<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Haystack4 { get; } = new Item("Haystack4", 8405);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/Haystack6-icon"<para/>
		/// PlacenmentId: 8406<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Haystack5 { get; } = new Item("Haystack5", 8406);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/bed-MedicalCare-icon"<para/>
		/// PlacenmentId: 8451<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SimpleMedicalBed { get; } = new Item("SimpleMedicalBed", 8451);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/SideCupboard-icon"<para/>
		/// PlacenmentId: 8601<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CandleHolder { get; } = new Item("CandleHolder", 8601);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/MineOrbit1-icon"<para/>
		/// PlacenmentId: 8651<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MiningRail0 { get; } = new Item("MiningRail0", 8651);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/MineOrbit2-icon"<para/>
		/// PlacenmentId: 8652<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo3"<para/>
		/// MouseRight: "MouseRightClickInfo3"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MiningRail1 { get; } = new Item("MiningRail1", 8652);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/MineOrbit3-icon"<para/>
		/// PlacenmentId: 8653<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo4"<para/>
		/// MouseRight: "MouseRightClickInfo4"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MiningRail2 { get; } = new Item("MiningRail2", 8653);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/MineOrbit4-icon"<para/>
		/// PlacenmentId: 8654<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo5"<para/>
		/// MouseRight: "MouseRightClickInfo5"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MiningRail3 { get; } = new Item("MiningRail3", 8654);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/MineOrbit5-icon"<para/>
		/// PlacenmentId: 8655<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo6"<para/>
		/// MouseRight: "MouseRightClickInfo6"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MiningRail4 { get; } = new Item("MiningRail4", 8655);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/MineOrbit6-icon"<para/>
		/// PlacenmentId: 8656<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo7"<para/>
		/// MouseRight: "MouseRightClickInfo7"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MiningRail5 { get; } = new Item("MiningRail5", 8656);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/MineOrbit7-icon"<para/>
		/// PlacenmentId: 8657<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo8"<para/>
		/// MouseRight: "MouseRightClickInfo8"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MiningRail6 { get; } = new Item("MiningRail6", 8657);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/MineOrbit8-icon"<para/>
		/// PlacenmentId: 8658<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo9"<para/>
		/// MouseRight: "MouseRightClickInfo9"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MiningRail7 { get; } = new Item("MiningRail7", 8658);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/MineOrbit9-icon"<para/>
		/// PlacenmentId: 8659<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo10"<para/>
		/// MouseRight: "MouseRightClickInfo10"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MiningRail8 { get; } = new Item("MiningRail8", 8659);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/MineOrbit10-icon"<para/>
		/// PlacenmentId: 8660<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo11"<para/>
		/// MouseRight: "MouseRightClickInfo11"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MiningRail9 { get; } = new Item("MiningRail9", 8660);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/MineOrbit11-icon"<para/>
		/// PlacenmentId: 8661<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo12"<para/>
		/// MouseRight: "MouseRightClickInfo12"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MineCart0 { get; } = new Item("MineCart0", 8661);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/MineOrbit12-icon"<para/>
		/// PlacenmentId: 8662<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo13"<para/>
		/// MouseRight: "MouseRightClickInfo13"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MineCart1 { get; } = new Item("MineCart1", 8662);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/MineOrbit13-icon"<para/>
		/// PlacenmentId: 8663<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo14"<para/>
		/// MouseRight: "MouseRightClickInfo14"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MineCart2 { get; } = new Item("MineCart2", 8663);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/MineOrbit14-icon"<para/>
		/// PlacenmentId: 8664<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo15"<para/>
		/// MouseRight: "MouseRightClickInfo15"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MineCart3 { get; } = new Item("MineCart3", 8664);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/InfusionStand-icon"<para/>
		/// PlacenmentId: 8986<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InfusionStand { get; } = new Item("InfusionStand", 8986);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/SeedlingCulturePot2-icon"<para/>
		/// PlacenmentId: 8987<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SaplingPot { get; } = new Item("SaplingPot", 8987);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/Wheelbarrow-icon"<para/>
		/// PlacenmentId: 8988<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Cart { get; } = new Item("Cart", 8988);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/drawingbox-icon"<para/>
		/// PlacenmentId: 8989<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DrawingStorageBox { get; } = new Item("DrawingStorageBox", 8989);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/MeatRack-icon"<para/>
		/// PlacenmentId: 8990<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MeatDryingRack { get; } = new Item("MeatDryingRack", 8990);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/GarmImplementsRack-icon"<para/>
		/// PlacenmentId: 8991<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item FarmToolsRack { get; } = new Item("FarmToolsRack", 8991);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/FirewoodFrame-icon"<para/>
		/// PlacenmentId: 8992<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodenBasket { get; } = new Item("WoodenBasket", 8992);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/fertilizer-icon"<para/>
		/// PlacenmentId: 8993<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Fertilizers { get; } = new Item("Fertilizers", 8993);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/VegetableBasket-icon"<para/>
		/// PlacenmentId: 8994<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Crate0 { get; } = new Item("Crate0", 8994);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/SundryDecoration4-icon"<para/>
		/// PlacenmentId: 8995<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Crate1 { get; } = new Item("Crate1", 8995);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/SundryDecoration3-icon"<para/>
		/// PlacenmentId: 8996<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Crate2 { get; } = new Item("Crate2", 8996);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/SundryDecoration2-icon"<para/>
		/// PlacenmentId: 8997<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WoodPile { get; } = new Item("WoodPile", 8997);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/SundryDecoration1-icon"<para/>
		/// PlacenmentId: 8998<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Crate3 { get; } = new Item("Crate3", 8998);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 30<para/>
		/// DropTexture: "Icon/StackOfBooks-icon"<para/>
		/// PlacenmentId: 8999<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BookPile { get; } = new Item("BookPile", 8999);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 21<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 15<para/>
		/// DropTexture: "Icon/tree-wood-icon"<para/>
		/// PlacenmentId: 2013<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1, 6 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Wood { get; } = new Item("Wood", 9001);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 25<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 5<para/>
		/// DropTexture: "Icon/grass-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Grass { get; } = new Item("Grass", 9002);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 26<para/>
		/// MaxCount: 99<para/>
		/// Price: 1<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bones-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Bone { get; } = new Item("Bone", 9003);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 104<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "0"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Drug { get; } = new Item("Drug", 9005);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/feather-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Feather { get; } = new Item("Feather", 9006);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 99<para/>
		/// Price: 15<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/goatshair-white-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Wool { get; } = new Item("Wool", 9007);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 99<para/>
		/// Price: 15<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/skin-cattle-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Leather { get; } = new Item("Leather", 9008);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 99<para/>
		/// Price: 1<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bar-glass-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Glass { get; } = new Item("Glass", 9009);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/wool-white-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item String { get; } = new Item("String", 9010);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 31<para/>
		/// MaxCount: 99<para/>
		/// Price: 12<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bar-copper-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item CopperBar { get; } = new Item("CopperBar", 9011);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 31<para/>
		/// MaxCount: 99<para/>
		/// Price: 20<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bar-iron-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item IronBar { get; } = new Item("IronBar", 9012);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 31<para/>
		/// MaxCount: 99<para/>
		/// Price: 35<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bar-silver-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverBar { get; } = new Item("SilverBar", 9013);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 31<para/>
		/// MaxCount: 99<para/>
		/// Price: 60<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bar-gold-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldBar { get; } = new Item("GoldBar", 9014);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 99<para/>
		/// Price: 12<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/gunpowder-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Gunpowder { get; } = new Item("Gunpowder", 9015);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 999<para/>
		/// Price: 4<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/coin-silver-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9013, 1 ]<para/>
		/// SmeltConsume: 15<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SilverCoin { get; } = new Item("SilverCoin", 9016);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 999<para/>
		/// Price: 6<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/coin-gold-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 9014, 1 ]<para/>
		/// SmeltConsume: 15<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoldCoin { get; } = new Item("GoldCoin", 9017);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 105<para/>
		/// MaxCount: 999<para/>
		/// Price: 4<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/kepler-tenergy-shard-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item TenergyShard { get; } = new Item("TenergyShard", 9018);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 99<para/>
		/// Price: 2<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/demon-tentacle-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorExoskeleton { get; } = new Item("InsectorExoskeleton", 9019);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 99<para/>
		/// Price: 2<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/demon-mucus-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Mucus { get; } = new Item("Mucus", 9020);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 99<para/>
		/// Price: 2<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/demon-egg-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorEgg { get; } = new Item("InsectorEgg", 9021);
		/// <summary>
		/// Type: 7<para/>
		/// ItemType: 56<para/>
		/// MaxCount: 99<para/>
		/// Price: 48<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/petcollar-01-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo6"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item PetCollar { get; } = new Item("PetCollar", 9022);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 99<para/>
		/// Price: 1<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/skin-monster-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MonsterSkin { get; } = new Item("MonsterSkin", 9023);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 105<para/>
		/// MaxCount: 99<para/>
		/// Price: 30<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/kepler-tenergy-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Tenergy { get; } = new Item("Tenergy", 9024);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 99<para/>
		/// Price: 80<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/alloy-meco-mecoalloy-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoAlloy { get; } = new Item("MecoAlloy", 9025);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 99<para/>
		/// Price: 10<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meco-ParasectMass-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoParasectMass { get; } = new Item("MecoParasectMass", 9026);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 999<para/>
		/// MaxCount: 999999999<para/>
		/// Price: 0<para/>
		/// AttTree: 0<para/>
		/// AttWall: 0<para/>
		/// AttBuild: 0<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/kepler-tenergy-shard-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item TenergyShards { get; } = new Item("TenergyShards", 9027);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 99<para/>
		/// Price: 5<para/>
		/// AttTree: 0<para/>
		/// AttWall: 0<para/>
		/// AttBuild: 0<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/amber-grounder-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 6 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Amber { get; } = new Item("Amber", 9028);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 1<para/>
		/// Price: 40<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/icon50W&A-W-Icon-002"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ParasytorGeneBall { get; } = new Item("ParasytorGeneBall", 9029);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 1<para/>
		/// Price: 100<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/icon50W&A-W-Icon-001"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinGeneBall { get; } = new Item("GoblinGeneBall", 9030);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 1<para/>
		/// Price: 150<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/icon50W&A-W-Icon-003"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorGeneBall { get; } = new Item("InsectorGeneBall", 9031);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 1<para/>
		/// Price: 200<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/icon50W&A-W-Icon-004"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderGeneBall { get; } = new Item("GrounderGeneBall", 9032);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 30<para/>
		/// MaxCount: 1<para/>
		/// Price: 200<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/icon50W&A-W-Icon-006"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 0<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item DivilGeneBall { get; } = new Item("DivilGeneBall", 9033);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 61<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 10<para/>
		/// DropTexture: "Icon/guidancesystem-paper-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item9501 { get; } = new Item("Item9501", 9501);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 61<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 10<para/>
		/// DropTexture: "Icon/guidancesystem-paper-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GoblinVillage { get; } = new Item("GoblinVillage", 9502);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 61<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 10<para/>
		/// DropTexture: "Icon/guidancesystem-paper-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InfectedVillage { get; } = new Item("InfectedVillage", 9503);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 61<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 10<para/>
		/// DropTexture: "Icon/guidancesystem-paper-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item HumanVillage { get; } = new Item("HumanVillage", 9504);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 61<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 10<para/>
		/// DropTexture: "Icon/guidancesystem-paper-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item InsectorNest16 { get; } = new Item("InsectorNest16", 9505);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 61<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 10<para/>
		/// DropTexture: "Icon/guidancesystem-paper-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MecoBiotechResearchInstitute { get; } = new Item("MecoBiotechResearchInstitute", 9506);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 61<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 10<para/>
		/// DropTexture: "Icon/guidancesystem-paper-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item GrounderBase { get; } = new Item("GrounderBase", 9507);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 1<para/>
		/// MaxCount: 99<para/>
		/// Price: 20<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meat-chicken-icon-cooked"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6, 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item RoastedChicken { get; } = new Item("RoastedChicken", 10001);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 1<para/>
		/// MaxCount: 99<para/>
		/// Price: 20<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meat-dog-icon-cooked"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6, 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item RoastedDogMeat { get; } = new Item("RoastedDogMeat", 10002);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 1<para/>
		/// MaxCount: 99<para/>
		/// Price: 20<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meat-goat-icon-cooked"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6, 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item RoastedLamb { get; } = new Item("RoastedLamb", 10003);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 1<para/>
		/// MaxCount: 99<para/>
		/// Price: 20<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meat-pig-icon-cooked"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6, 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item RoastedPork { get; } = new Item("RoastedPork", 10004);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 1<para/>
		/// MaxCount: 99<para/>
		/// Price: 20<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meat-cattle-icon-cooked"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6, 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item RoastedBeef { get; } = new Item("RoastedBeef", 10005);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 3<para/>
		/// MaxCount: 99<para/>
		/// Price: 6<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/chicken-egg-icon-cooked"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item RoastedEgg { get; } = new Item("RoastedEgg", 10006);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 8<para/>
		/// MaxCount: 99<para/>
		/// Price: 5<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meat-boar-icon-cooked"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item RoastedMonsterMeat { get; } = new Item("RoastedMonsterMeat", 10007);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 8<para/>
		/// MaxCount: 99<para/>
		/// Price: 5<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meat-worm-icon-cooked"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item RoastedDisgustingOrgans { get; } = new Item("RoastedDisgustingOrgans", 10008);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 4<para/>
		/// MaxCount: 99<para/>
		/// Price: 1<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/mushroom-icon-cooked"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item RoastedMushroom { get; } = new Item("RoastedMushroom", 10009);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 1<para/>
		/// MaxCount: 99<para/>
		/// Price: 20<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/meat-horse-icon-cooked"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 6, 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item RoastedHorseMeat { get; } = new Item("RoastedHorseMeat", 10010);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 4<para/>
		/// MaxCount: 99<para/>
		/// Price: 1<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/bloodmushroom-icon-cooked"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 7 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item RoastedBloodMushroom { get; } = new Item("RoastedBloodMushroom", 10011);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 5<para/>
		/// MaxCount: 99<para/>
		/// Price: 25<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/cooking-a-bigfeast-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item BigFeast { get; } = new Item("BigFeast", 11001);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 5<para/>
		/// MaxCount: 99<para/>
		/// Price: 72<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/cooking-a-allmeat-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item AllMeat { get; } = new Item("AllMeat", 11002);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 5<para/>
		/// MaxCount: 99<para/>
		/// Price: 38<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/cooking-a-meatballs-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Meatballs { get; } = new Item("Meatballs", 11003);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 5<para/>
		/// MaxCount: 99<para/>
		/// Price: 22<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/cooking-a-scrambledeggs-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item ScrambledEggs { get; } = new Item("ScrambledEggs", 11004);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 5<para/>
		/// MaxCount: 99<para/>
		/// Price: 53<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/cooking-a-sweetham-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SweetHam { get; } = new Item("SweetHam", 11005);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 5<para/>
		/// MaxCount: 99<para/>
		/// Price: 15<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/cooking-a-fruitjam-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item FruitJam { get; } = new Item("FruitJam", 11006);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 5<para/>
		/// MaxCount: 99<para/>
		/// Price: 25<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/cooking-a-fruitsalad-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item FruitSalad { get; } = new Item("FruitSalad", 11007);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 5<para/>
		/// MaxCount: 99<para/>
		/// Price: 36<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/cooking-a-sandwich-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Sandwich { get; } = new Item("Sandwich", 11008);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 5<para/>
		/// MaxCount: 99<para/>
		/// Price: 17<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/cooking-a-pie-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Pie { get; } = new Item("Pie", 11009);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 5<para/>
		/// MaxCount: 99<para/>
		/// Price: 43<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/cooking-a-sweetsoup-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item SweetSoup { get; } = new Item("SweetSoup", 11010);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 5<para/>
		/// MaxCount: 99<para/>
		/// Price: 4<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/cooking-a-MushroomSoup-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item MushroomSoup { get; } = new Item("MushroomSoup", 11011);
		/// <summary>
		/// Type: 1<para/>
		/// ItemType: 5<para/>
		/// MaxCount: 99<para/>
		/// Price: 9<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/cooking-a-MonsterMeat-icon"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "MouseRightClickInfo1"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item WeirdFood { get; } = new Item("WeirdFood", 11012);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-10"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12010 { get; } = new Item("Item12010", 12010);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-20"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12020 { get; } = new Item("Item12020", 12020);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-30"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12030 { get; } = new Item("Item12030", 12030);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-40"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12040 { get; } = new Item("Item12040", 12040);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-50"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12050 { get; } = new Item("Item12050", 12050);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-60"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12060 { get; } = new Item("Item12060", 12060);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-70"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12070 { get; } = new Item("Item12070", 12070);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-80"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12080 { get; } = new Item("Item12080", 12080);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-90"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12090 { get; } = new Item("Item12090", 12090);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-100"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12100 { get; } = new Item("Item12100", 12100);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-110"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12110 { get; } = new Item("Item12110", 12110);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-120"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12120 { get; } = new Item("Item12120", 12120);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-130"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12130 { get; } = new Item("Item12130", 12130);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-140"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12140 { get; } = new Item("Item12140", 12140);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-150"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12150 { get; } = new Item("Item12150", 12150);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-160"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12160 { get; } = new Item("Item12160", 12160);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-170"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12170 { get; } = new Item("Item12170", 12170);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-180"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12180 { get; } = new Item("Item12180", 12180);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-190"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12190 { get; } = new Item("Item12190", 12190);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-200"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12200 { get; } = new Item("Item12200", 12200);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-210"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12210 { get; } = new Item("Item12210", 12210);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-220"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12220 { get; } = new Item("Item12220", 12220);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-230"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12230 { get; } = new Item("Item12230", 12230);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-240"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12240 { get; } = new Item("Item12240", 12240);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-250"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12250 { get; } = new Item("Item12250", 12250);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-260"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12260 { get; } = new Item("Item12260", 12260);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-270"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12270 { get; } = new Item("Item12270", 12270);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-280"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12280 { get; } = new Item("Item12280", 12280);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-290"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12290 { get; } = new Item("Item12290", 12290);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-300"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12300 { get; } = new Item("Item12300", 12300);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-310"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12310 { get; } = new Item("Item12310", 12310);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-320"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12320 { get; } = new Item("Item12320", 12320);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-330"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12330 { get; } = new Item("Item12330", 12330);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-340"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12340 { get; } = new Item("Item12340", 12340);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-350"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12350 { get; } = new Item("Item12350", 12350);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-360"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item12360 { get; } = new Item("Item12360", 12360);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1000"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item13000 { get; } = new Item("Item13000", 13000);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1001"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item13001 { get; } = new Item("Item13001", 13001);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1002"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item13002 { get; } = new Item("Item13002", 13002);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1003"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item13003 { get; } = new Item("Item13003", 13003);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1004"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item13004 { get; } = new Item("Item13004", 13004);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1005"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item13005 { get; } = new Item("Item13005", 13005);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1006"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item13006 { get; } = new Item("Item13006", 13006);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1007"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item13007 { get; } = new Item("Item13007", 13007);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1008"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item13008 { get; } = new Item("Item13008", 13008);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1009"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item13009 { get; } = new Item("Item13009", 13009);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1010"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item13010 { get; } = new Item("Item13010", 13010);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1011"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item13011 { get; } = new Item("Item13011", 13011);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1012"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item13012 { get; } = new Item("Item13012", 13012);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1013"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item13013 { get; } = new Item("Item13013", 13013);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1014"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item13014 { get; } = new Item("Item13014", 13014);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1015"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item13015 { get; } = new Item("Item13015", 13015);
		/// <summary>
		/// Type: 0<para/>
		/// ItemType: 998<para/>
		/// MaxCount: 1<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "World&Achievement/World-Plots&Stories/W&A-W-Icon/W&A-W-Icon-1016"<para/>
		/// PlacenmentId: 0<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 0 ]<para/>
		/// MouseLeft: "0"<para/>
		/// MouseRight: "0"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item13016 { get; } = new Item("Item13016", 13016);
		/// <summary>
		/// Type: 4<para/>
		/// ItemType: 44<para/>
		/// MaxCount: 99<para/>
		/// Price: 0<para/>
		/// AttTree: 1<para/>
		/// AttWall: 1<para/>
		/// AttBuild: 1<para/>
		/// Durability: 0<para/>
		/// BurnTime: 0<para/>
		/// DropTexture: "Icon/grounder-landmine-icon"<para/>
		/// PlacenmentId: 6996<para/>
		/// BbqResult: [ 0 ]<para/>
		/// SmeltResult: [ 0 ]<para/>
		/// SmeltConsume: 1<para/>
		/// UsesInfo: [ 1 ]<para/>
		/// MouseLeft: "MouseLeftClickInfo2"<para/>
		/// MouseRight: "MouseRightClickInfo2"<para/>
		/// Keyboard: "0"<para/>
		/// KeyboardInfo: "0"<para/>
		/// </summary>
		public static Item Item99999 { get; } = new Item("Item99999", 99999);
	}
}
