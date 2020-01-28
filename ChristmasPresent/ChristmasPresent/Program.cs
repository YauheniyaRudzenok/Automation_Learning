using System;
using System.Linq;
using System.Collections.Generic;
using ChristmasPresent.Domain;

namespace ChristmasPresent
{
	public class CandiesList
	{
		static void Main()
		{
			// параметризованный конструктор
			Caramel candy1 = new Caramel("Taddy",56);

			ChocolateCandies candy2 = new ChocolateCandies("New Chocolade Explosure", 78);

			ChocolateCandiesWithFilling candy3 = 
				new ChocolateCandiesWithFilling("Chocolate with berries",90, "Berries jam");

			LollyPops candy4 = new LollyPops("Chupa-chups", 15);

			Box box1 = new Box();
			box1.AddCandy(candy1);
			box1.AddCandy(candy2);
			box1.AddCandy(candy3);
			box1.AddCandy(candy4);

			Console.WriteLine($"The weight of the box is {box1.DefineWeight()}");
            box1.ExtendetSearchCandy("Taddy", "", 90);
			box1.RestrictedSearchCandy("Taddy", "", 90);

			List<Candies> sortedCandies = box1.SortCandies();

			for (int i = 0; i < sortedCandies.Count; i++)
            {
                Console.WriteLine($"Items sorted by Name: {i}:{sortedCandies[i].Name}");
            }
		}
	}
}
