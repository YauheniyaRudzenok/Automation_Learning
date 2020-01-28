namespace ChristmasPresent.Domain
{
	public class ChocolateCandies : Candies
	{
		public ChocolateCandies(string name, int weight)
			:base(name, weight)
		{
			Filling = "None";
			Type = "Chocolate";
		}
	}
}
