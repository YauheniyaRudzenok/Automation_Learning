using System;
using System.Collections.Generic;

using ChristmasPresent.Domain;

namespace ChristmasPresent
{
	/// <summary>
	/// NiceToHave: ограничить присвоение некорректных данных для переменных типа Candies
	/// </summary>
	public class CandiesList
	{
		static void Main()
		{
            Box box1 = new Box();
            Caramel candy1 = new Caramel("Taddy", 56);
            ChocolateCandiesWithFilling candy3 =
                new ChocolateCandiesWithFilling("Chocolate with berries", 90, "Berries jam");
            ChocolateCandies candy2 = new ChocolateCandies("New Chocolade Explosure", 78);
           

			LollyPops candy4 = new LollyPops("Chupa-chups", 15);

			
			box1.AddCandy(candy1);
			box1.AddCandy(candy2);
            box1.AddCandy(candy4);
            try
            {
                LollyPops candy5 = null;
                box1.AddCandy(candy5);
                box1.DeleteCandy(candy3);
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.WriteLine($"The weight of the box is {box1.DefineWeight()}");
			List<Candies> sortedCandies = box1.SortCandies();

            Console.WriteLine("Items sorted by Name:");
            foreach (Candies item in sortedCandies)
            {
                Console.WriteLine(item.Name);
            }

            List<Candies> restrictedSearchResult = box1.RestrictedSearchCandy("Taddy", "", 56);
            Console.Write("Search result is:");
            foreach (Candies item in restrictedSearchResult)
            {
                Console.WriteLine(item.Name);
            }

            List<Candies> extendedSearchResult= box1.ExtendedSearchCandy("Taddy", "", 90); ;
            Console.Write("Search result of extended search is:");
            foreach (Candies item in extendedSearchResult)
            {
                Console.WriteLine(item.Name);
            };
        }
	}
}
