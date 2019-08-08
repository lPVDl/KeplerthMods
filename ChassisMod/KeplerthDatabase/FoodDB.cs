namespace ChassisMod.KeplerthDatabase
{
	public static class FoodDB
	{
		/// <summary>
		/// EffectHp: 400<para/>
		/// EffectHunger: 2520<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 4<para/>
		/// PetEatHp: 1200<para/>
		/// PetEatHunger: 1260<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Apple { get; } = new Food("Apple", 1);
		/// <summary>
		/// EffectHp: 600<para/>
		/// EffectHunger: 1800<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 4<para/>
		/// PetEatHp: 1800<para/>
		/// PetEatHunger: 900<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Berries { get; } = new Food("Berries", 2);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 3600<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 6<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 1800<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food CompressedCookie { get; } = new Food("CompressedCookie", 3);
		/// <summary>
		/// Use: restore 1 HP for every second, lasts for 10 seconds.<para/>
		/// EffectHp: 1000<para/>
		/// EffectHunger: 360<para/>
		/// Buff: [ 1 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 5<para/>
		/// PetEatHp: 6000<para/>
		/// PetEatHunger: 180<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Nectar { get; } = new Food("Nectar", 4);
		/// <summary>
		/// Use: Get one of the mutated effects.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 3600<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 115, 116, 117 ]<para/>
		/// RandomTimes: 1<para/>
		/// FeedAnimalHunger: 10<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 1800<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food MonsterMeat { get; } = new Food("MonsterMeat", 5);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 4320<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 15<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 2160<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food ChickenMeat { get; } = new Food("ChickenMeat", 6);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 4320<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 15<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 2160<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food DogMeat { get; } = new Food("DogMeat", 7);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 4320<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 15<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 2160<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Lamb { get; } = new Food("Lamb", 8);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 4320<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 15<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 2160<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Pork { get; } = new Food("Pork", 9);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 4320<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 15<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 2160<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Beef { get; } = new Food("Beef", 10);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 2160<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 6<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 1080<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Egg { get; } = new Food("Egg", 11);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 1080<para/>
		/// Buff: [ 109 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 540<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food VenomSac { get; } = new Food("VenomSac", 12);
		/// <summary>
		/// Use: walking speed decrease by 25%, lasts for 1 minitue<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 3600<para/>
		/// Buff: [ 4 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 7<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 1800<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food DisgustingOrgans { get; } = new Food("DisgustingOrgans", 13);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 3600<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 10<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 1800<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Jerky { get; } = new Food("Jerky", 17);
		/// <summary>
		/// Use: after using this,the stinky smell on you will attract the Boar King!<para/>
		/// EffectHp: 1000<para/>
		/// EffectHunger: 1800<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 20<para/>
		/// PetEatHp: 3000<para/>
		/// PetEatHunger: 900<para/>
		/// ExEffect: 1<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food WildBoarGlands { get; } = new Food("WildBoarGlands", 18);
		/// <summary>
		/// Use: attract chickens around you, lasts for 30 seconds.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 130 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 1<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food PheromonesChicken { get; } = new Food("PheromonesChicken", 19);
		/// <summary>
		/// Use: attract goats around you, lasts for 30 seconds.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 131 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 1<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food PheromonesGoat { get; } = new Food("PheromonesGoat", 20);
		/// <summary>
		/// Use: attract pigs around you, lasts for 30 seconds.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 132 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 1<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food PheromonesPig { get; } = new Food("PheromonesPig", 21);
		/// <summary>
		/// Use: attract cows around you, lasts for 30 seconds.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 133 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 1<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food PheromonesCow { get; } = new Food("PheromonesCow", 22);
		/// <summary>
		/// Use: attract horses around you, lasts for 30 seconds.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 134 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 1<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food PheromonesHorse { get; } = new Food("PheromonesHorse", 23);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 4320<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 15<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 2160<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food HorseMeat { get; } = new Food("HorseMeat", 24);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 2<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food RedMushroom { get; } = new Food("RedMushroom", 502);
		/// <summary>
		/// EffectHp: 3500<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 10000<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Bandage { get; } = new Food("Bandage", 601);
		/// <summary>
		/// EffectHp: 5000<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 10000<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food PainKiller { get; } = new Food("PainKiller", 602);
		/// <summary>
		/// EffectHp: 7500<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 10000<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food FirstAidKit { get; } = new Food("FirstAidKit", 603);
		/// <summary>
		/// EffectHp: 10000<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 10000<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food NanoCapsule { get; } = new Food("NanoCapsule", 604);
		/// <summary>
		/// EffectHp: 10000<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 10000<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Food605 { get; } = new Food("Food605", 605);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 51 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Food606 { get; } = new Food("Food606", 606);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 52 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Food607 { get; } = new Food("Food607", 607);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 53 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Food608 { get; } = new Food("Food608", 608);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 54 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Food609 { get; } = new Food("Food609", 609);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 55 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Food610 { get; } = new Food("Food610", 610);
		/// <summary>
		/// EffectHp: 2000<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 51 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 6000<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Food611 { get; } = new Food("Food611", 611);
		/// <summary>
		/// EffectHp: 3000<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 52 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 9000<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Food612 { get; } = new Food("Food612", 612);
		/// <summary>
		/// EffectHp: 4000<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 53 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 10000<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Food613 { get; } = new Food("Food613", 613);
		/// <summary>
		/// EffectHp: 5000<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 54 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 10000<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Food614 { get; } = new Food("Food614", 614);
		/// <summary>
		/// EffectHp: 6000<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 55 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 10000<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Food615 { get; } = new Food("Food615", 615);
		/// <summary>
		/// Use: increase attack speed and walking speed by 20%, hunger speed will also be increased. Lasts for 1 minitue.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 76 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food StimulantsI { get; } = new Food("StimulantsI", 616);
		/// <summary>
		/// Use: increase attack speed and walking speed by 40% , hunger speed will also be substantially increased. Lasts for 1 minute.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 77 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food StimulantsII { get; } = new Food("StimulantsII", 617);
		/// <summary>
		/// Use: increase attack speed and walking speed by 60%, lasts for 1 minute. Satiety will be decreased to 0 once the effect is over.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 78 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food StimulantsIII { get; } = new Food("StimulantsIII", 618);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 5 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Food619 { get; } = new Food("Food619", 619);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 5 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Food620 { get; } = new Food("Food620", 620);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 8 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Food621 { get; } = new Food("Food621", 621);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 9 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Food622 { get; } = new Food("Food622", 622);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 10 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Food623 { get; } = new Food("Food623", 623);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Food624 { get; } = new Food("Food624", 624);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Food625 { get; } = new Food("Food625", 625);
		/// <summary>
		/// Use: increase attack by 2 points, lasts for 10 minutes.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 11 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food DamagedATKCapsule { get; } = new Food("DamagedATKCapsule", 626);
		/// <summary>
		/// Use: increase attack by 3 points, lasts for 10 minutes.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 12 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food ExpiredATKCapsule { get; } = new Food("ExpiredATKCapsule", 627);
		/// <summary>
		/// Use: increase attack by 4 points, lasts for 10 minutes.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 13 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food ATKCapsule { get; } = new Food("ATKCapsule", 628);
		/// <summary>
		/// Use: increase attack by 6 points, lasts for 10 minutes.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 14 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food ATKCapsuleExtra { get; } = new Food("ATKCapsuleExtra", 629);
		/// <summary>
		/// Use: increase attack by 9 points, lasts for 10 minutes.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 15 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food ATKCapsuleExtraAdvance { get; } = new Food("ATKCapsuleExtraAdvance", 630);
		/// <summary>
		/// Use: increase defense by 3 points, lasts for 10 minutes.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 21 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food DamagedDEFCapsule { get; } = new Food("DamagedDEFCapsule", 631);
		/// <summary>
		/// Use: increase defense by 5 points, lasts for 10 minutes.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 22 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food ExpiredDEFCapsule { get; } = new Food("ExpiredDEFCapsule", 632);
		/// <summary>
		/// Use: increase defense by 8 points, lasts for 10 minutes.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 23 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food DEFCapsule { get; } = new Food("DEFCapsule", 633);
		/// <summary>
		/// Use: increase defense by 12 points, lasts for 10 minutes.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 24 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food DEFCapsuleExtra { get; } = new Food("DEFCapsuleExtra", 634);
		/// <summary>
		/// Use: increase defense by 19 points, lasts for 10 minutes.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 25 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food DEFCapsuleExtraAdvance { get; } = new Food("DEFCapsuleExtraAdvance", 635);
		/// <summary>
		/// Use: increase walking speed by 10%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 56 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food DamagedAGLPotion { get; } = new Food("DamagedAGLPotion", 636);
		/// <summary>
		/// Use: increase walking speed by 15%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 57 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food ExpiredAGLPotion { get; } = new Food("ExpiredAGLPotion", 637);
		/// <summary>
		/// Use: increase walking speed by 20%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 58 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food AGLPotion { get; } = new Food("AGLPotion", 638);
		/// <summary>
		/// Use: increase walking speed by 25%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 59 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food AGLPotionExtra { get; } = new Food("AGLPotionExtra", 639);
		/// <summary>
		/// Use: increase walking speed by 30%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 60 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food AGLPotionExtraAdvance { get; } = new Food("AGLPotionExtraAdvance", 640);
		/// <summary>
		/// Use: increase attack speed by 10%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 66 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food MecoJoyfulI { get; } = new Food("MecoJoyfulI", 641);
		/// <summary>
		/// Use: increase attack speed by 15%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 67 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food MecoJoyfulII { get; } = new Food("MecoJoyfulII", 642);
		/// <summary>
		/// Use: increase attack speed by 20%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 68 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food MecoJoyfulIII { get; } = new Food("MecoJoyfulIII", 643);
		/// <summary>
		/// Use: increase attack speed by 25%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 69 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food MecoJoyfulIV { get; } = new Food("MecoJoyfulIV", 644);
		/// <summary>
		/// Use: increase attack speed by 30%, lasts for 10 minutes. Its efficacy will be lost if stimulant is taken.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 70 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food MecoJoyfulV { get; } = new Food("MecoJoyfulV", 645);
		/// <summary>
		/// Press the button! It will take you back home through the rift.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 2<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food RifterStone { get; } = new Food("RifterStone", 901);
		/// <summary>
		/// Use: after using this, you will attract an angry Coopapa!<para/>
		/// EffectHp: 1000<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 3000<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 3<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food CoocooJelly { get; } = new Food("CoocooJelly", 902);
		/// <summary>
		/// Summon a friendly Coocoo, but the Coocoo will vanish after 2 minutes.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 4<para/>
		/// UseCD: 300<para/>
		/// </summary>
		public static Food DollCoocoo { get; } = new Food("DollCoocoo", 903);
		/// <summary>
		/// Use: place a coocoo bomb. It will explode after 8 seconds and cause 40 damage.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 0<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 5<para/>
		/// UseCD: 15<para/>
		/// </summary>
		public static Food CoocooBomb { get; } = new Food("CoocooBomb", 904);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 2<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food BloodMushroom { get; } = new Food("BloodMushroom", 3223);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 0<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 2<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 0<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Grass { get; } = new Food("Grass", 9002);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 5400<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 15<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 2700<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food RoastedChicken { get; } = new Food("RoastedChicken", 10001);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 5400<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 15<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 2700<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food RoastedDogMeat { get; } = new Food("RoastedDogMeat", 10002);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 5400<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 15<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 2700<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food RoastedLamb { get; } = new Food("RoastedLamb", 10003);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 5400<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 15<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 2700<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food RoastedPork { get; } = new Food("RoastedPork", 10004);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 5400<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 15<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 2700<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food RoastedBeef { get; } = new Food("RoastedBeef", 10005);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 2520<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 7<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 1260<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food RoastedEgg { get; } = new Food("RoastedEgg", 10006);
		/// <summary>
		/// Use: Get one of the mutated effects.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 4320<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 115, 116, 117 ]<para/>
		/// RandomTimes: 1<para/>
		/// FeedAnimalHunger: 10<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 2160<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food RoastedMonsterMeat { get; } = new Food("RoastedMonsterMeat", 10007);
		/// <summary>
		/// Use: walking speed decrease by 25%, lasts for 1 minutes.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 4320<para/>
		/// Buff: [ 4 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 7<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 2160<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food RoastedDisgustingOrgans { get; } = new Food("RoastedDisgustingOrgans", 10008);
		/// <summary>
		/// Use: Get one of the mushroom toxin effects.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 400<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 121, 122, 123, 124, 126, 127 ]<para/>
		/// RandomTimes: 1<para/>
		/// FeedAnimalHunger: 2<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 200<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food RoastedMushroom { get; } = new Food("RoastedMushroom", 10009);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 5400<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 15<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 2700<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food RoastedHorseMeat { get; } = new Food("RoastedHorseMeat", 10010);
		/// <summary>
		/// Use: Get one of the mushroom toxin effects.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 400<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 121, 122, 123, 124, 126, 127 ]<para/>
		/// RandomTimes: 1<para/>
		/// FeedAnimalHunger: 2<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 200<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food RoastedBloodMushroom { get; } = new Food("RoastedBloodMushroom", 10011);
		/// <summary>
		/// EffectHp: 0<para/>
		/// EffectHunger: 9000<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 15<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 4500<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food BigFeast { get; } = new Food("BigFeast", 11001);
		/// <summary>
		/// Use: feeling satisfied with a delicious meal. Hunger speed decrease by 35%,lasts for 1 minutes.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 18000<para/>
		/// Buff: [ 103 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 40<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 6000<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food AllMeat { get; } = new Food("AllMeat", 11002);
		/// <summary>
		/// Use: feeling satisfied with a delicious meal. Hunger speed decrease by 35%,lasts for 1 minutes.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 11520<para/>
		/// Buff: [ 103 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 35<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 5760<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Meatballs { get; } = new Food("Meatballs", 11003);
		/// <summary>
		/// Use: feeling satisfied with a delicious meal. Hunger speed decrease by 35%,lasts for 1 minutes.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 7560<para/>
		/// Buff: [ 103 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 20<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 3780<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food ScrambledEggs { get; } = new Food("ScrambledEggs", 11004);
		/// <summary>
		/// Use: restore 1 HP for every second, lasts for 20 seconds.<para/>
		/// EffectHp: 1000<para/>
		/// EffectHunger: 9000<para/>
		/// Buff: [ 128 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 30<para/>
		/// PetEatHp: 9000<para/>
		/// PetEatHunger: 4500<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food SweetHam { get; } = new Food("SweetHam", 11005);
		/// <summary>
		/// EffectHp: 2000<para/>
		/// EffectHunger: 3600<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 15<para/>
		/// PetEatHp: 6000<para/>
		/// PetEatHunger: 1800<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food FruitJam { get; } = new Food("FruitJam", 11006);
		/// <summary>
		/// Use: restore 1 HP for every second, lasts for 20 seconds.<para/>
		/// EffectHp: 1500<para/>
		/// EffectHunger: 1800<para/>
		/// Buff: [ 128 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 15<para/>
		/// PetEatHp: 10000<para/>
		/// PetEatHunger: 900<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food FruitSalad { get; } = new Food("FruitSalad", 11007);
		/// <summary>
		/// Use： feeling satisfied with a delicious meal. Hunger speed decrease by 35%,lasts for 1 minutes.<para/>
		/// EffectHp: 1000<para/>
		/// EffectHunger: 10800<para/>
		/// Buff: [ 103 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 20<para/>
		/// PetEatHp: 3000<para/>
		/// PetEatHunger: 5400<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Sandwich { get; } = new Food("Sandwich", 11008);
		/// <summary>
		/// EffectHp: 1500<para/>
		/// EffectHunger: 7200<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 15<para/>
		/// PetEatHp: 4500<para/>
		/// PetEatHunger: 3600<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food Pie { get; } = new Food("Pie", 11009);
		/// <summary>
		/// Use: restore 2 HP for every second, lasts for 40 seconds.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 720<para/>
		/// Buff: [ 129 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 15<para/>
		/// PetEatHp: 10000<para/>
		/// PetEatHunger: 360<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food SweetSoup { get; } = new Food("SweetSoup", 11010);
		/// <summary>
		/// Use: Get one or two of the mushroom toxin effects.<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 1080<para/>
		/// Buff: [ 0 ]<para/>
		/// BuffRandomOne: [ 121, 122, 123, 124, 126, 127 ]<para/>
		/// RandomTimes: 2<para/>
		/// FeedAnimalHunger: 5<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 540<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food MushroomSoup { get; } = new Food("MushroomSoup", 11011);
		/// <summary>
		/// Use: walking speed decrease by 25%, lasts for 1 minitue<para/>
		/// EffectHp: 0<para/>
		/// EffectHunger: 9000<para/>
		/// Buff: [ 4 ]<para/>
		/// BuffRandomOne: [ 0 ]<para/>
		/// RandomTimes: 0<para/>
		/// FeedAnimalHunger: 20<para/>
		/// PetEatHp: 0<para/>
		/// PetEatHunger: 4500<para/>
		/// ExEffect: 0<para/>
		/// UseCD: 0<para/>
		/// </summary>
		public static Food WeirdFood { get; } = new Food("WeirdFood", 11012);
	}
}
