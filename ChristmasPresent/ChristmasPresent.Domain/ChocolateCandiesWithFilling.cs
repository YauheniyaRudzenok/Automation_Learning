namespace ChristmasPresent.Domain
{
	public class ChocolateCandiesWithFilling : Candies
	{
		private string type;
		public ChocolateCandiesWithFilling(string name, int weight, string filling)
			: base(name, weight)
		{
			Type = "Chocolate";
		}
	}
}
