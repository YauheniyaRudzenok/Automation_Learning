﻿namespace ChristmasPresent.Domain
{
	public class ChocolateCandies : Candies
	{
		public ChocolateCandies(string name, int weight)
			:base(name, weight, "Chocolate")
		{
			Filling = "None";
		}
	}
}
