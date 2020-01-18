using System;
using System.Linq;
using System.Collections.Generic;

namespace ChristmasPresent
{
	class Box
	{
		List<Candies> insideBox = new List<Candies>();
		int boxWeight;

		public void AddCandy(Candies candyItem)
		{
			insideBox.Add(candyItem);
		}

		public int DefineWeight()
		{
			for (int i = 0; i<insideBox.Count; i++)
			{
				boxWeight = boxWeight + insideBox[i].Weight;
			}
			return boxWeight;
		}

		public void SearchCandy(string name="none", string type="none", int weight=0)
		{
			for (int i = 0; i < insideBox.Count; i++)
			{
				if (insideBox[i].Name == name)
				{
					insideBox[i].GetInfo();
				}
				else if (insideBox[i].Type == type)
				{
					insideBox[i].GetInfo();
				}
				else if (insideBox[i].Weight == weight)
				{
					insideBox[i].GetInfo();
				}
			}
		}

		public void SortCandies()
		{
			Console.WriteLine(insideBox.OrderBy(u => insideBox[u].Name));
		}
	}
	interface ICandies
	{
		string Name { get; set; }
		int Weight { get; set; }
		string Type { get; set; }
		string Filling { get; set; }
	}

	abstract class Candies:ICandies
	{
		public string Name { get; set;}
		public int Weight { get; set;}
		public string Type { get; set;}
		public string Filling { get; set;}

		public void GetInfo()
		{
			Console.WriteLine($"The name is {Name}, weight is equal to {Weight}, " +
				$"the candy is related to type {Type} candies.");
		}
	}


	class ChocolateCandies : Candies
	{
		public ChocolateCandies()
		{
			Filling = "None";
			Type = "Chocolate";
		}
	}
	class ChocolateCandiesWithFilling:Candies
	{
		public ChocolateCandiesWithFilling()
		{
			Type = "Chocolate";
		}
	}
	class LollyPops: Candies
	{
		public LollyPops()
		{
			Type = "Lolly-Pop";
		}
	}
	class Caramel: Candies
	{
		public Caramel()
		{
			Type = "Caramel";
			Filling = "Jam";
		}
	}
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

			Box box1 = new Box();
			box1.AddCandy(candy1);
			box1.AddCandy(candy3);
			box1.DefineWeight();
			box1.SortCandies();
			//box1.SearchCandy("Taddy", "", 90);
		}
	}
}
