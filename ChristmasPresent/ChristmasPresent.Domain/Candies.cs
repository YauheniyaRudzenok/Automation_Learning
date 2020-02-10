using System;

namespace ChristmasPresent.Domain
{
	public abstract class Candies : ICandies
	{
		public Candies(string name, int weight, string type)
		{
			Name = name;
			Weight = weight;
			Type = type;
		}
		public string Name { get; set; }
		public int Weight { get; private set; }
		public string Type { get; private set; }
		public string Filling { get; set; }

		public void GetInfo()
		{
			Console.WriteLine($"The name is {Name}, weight is equal to {Weight}, " +
				$"the candy is related to type {Type} candies.");
		}
	}
}
