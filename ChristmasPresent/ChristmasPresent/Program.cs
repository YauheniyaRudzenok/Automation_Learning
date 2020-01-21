using System;
using System.Linq;
using System.Collections.Generic;

namespace ChristmasPresent
{
	class CandiesList
	{
		static void Main()
		{
			ChocolateCandies candy1 = new ChocolateCandies();
			candy1.Name = "Taddy";
			candy1.Weight = 56;

			ChocolateCandies candy2 = new ChocolateCandies();
			candy2.Name = "New Chocolade Explosure";
			candy2.Weight = 78;

			ChocolateCandiesWithFilling candy3 = new ChocolateCandiesWithFilling();
			candy3.Name = "Chocolate with berries";
			candy3.Weight = 90;
			candy3.Filling = "Berries jam";

			ChocolateCandiesWithFilling candy4 = new ChocolateCandiesWithFilling();
			candy1.Name = "Taddy";
			candy1.Weight = 90;

			Box box1 = new Box();
			box1.AddCandy(candy1);
			box1.AddCandy(candy3);
			box1.DefineWeight();
			box1.SortCandies();
			box1.ExtendetSearchCandy("Taddy", "", 90);
			box1.RestrictedSearchCandy("Taddy", "", 90);
		}
	}
}
