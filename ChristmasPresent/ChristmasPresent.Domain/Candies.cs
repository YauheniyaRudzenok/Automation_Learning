using System;

namespace ChristmasPresent.Domain
{
	public abstract class Candies : ICandies
	{
		public Candies(string name, int weight)
		{
			Name = name;
			Weight = weight;
		}
		public string Name { get; set; }
		public int Weight { get; set; }
		public string Type { get; set; }
		public string Filling { get; set; }

		public void GetInfo()
		{
			Console.WriteLine($"The name is {Name}, weight is equal to {Weight}, " +
				$"the candy is related to type {Type} candies.");
		}
	}
}
