using System;
using System.Collections.Generic;

using ChristmasPresent.Domain;

namespace ChristmasPresent
{
	/// <summary>
	/// for заменить на foreach
	/// переменная для результата метода должна называться result
	/// string.IsNullOrWhitespace
	/// NiceToHave: ограничить присвоение некорректных данных для переменных типа Candies
	/// </summary>
	public class CandiesList
	{
		static void Main()
		{
			Caramel candy1 = new Caramel("Taddy", 56);

			ChocolateCandies candy2 = new ChocolateCandies("New Chocolade Explosure", 78);

			ChocolateCandiesWithFilling candy3 = 
				new ChocolateCandiesWithFilling("Chocolate with berries", 90, "Berries jam");

			LollyPops candy4 = new LollyPops("Chupa-chups", 15);

			Box box1 = new Box();
			box1.AddCandy(candy1);
			box1.AddCandy(candy2);
			box1.AddCandy(candy3);
			box1.AddCandy(candy4);

			Console.WriteLine($"The weight of the box is {box1.DefineWeight()}");
			List<Candies> sortedCandies = box1.SortCandies();

			for (int i = 0; i < sortedCandies.Count; i++)
            {
                Console.WriteLine($"Items sorted by Name: {i}:{sortedCandies[i].Name}");
            }

            List<Candies> restrictedSearchResult = box1.RestrictedSearchCandy("Taddy", "", 56);
            Console.Write("Search result is:");
            for (int i = 0; i < restrictedSearchResult.Count; i++)
            {
                Console.WriteLine(restrictedSearchResult[i].Name);
            }

            List<Candies> extendedSearchResult= box1.ExtendedSearchCandy("Taddy", "", 90); ;
            Console.Write("Search result of extended search is:");
            for (int i = 0; i < extendedSearchResult.Count; i++)
            {
                Console.WriteLine(extendedSearchResult[i].Name);
            }
        }
	}
}
