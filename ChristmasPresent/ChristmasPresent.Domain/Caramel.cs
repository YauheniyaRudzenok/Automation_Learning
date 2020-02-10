namespace ChristmasPresent.Domain
{
	public class Caramel : Candies
	{
		public Caramel(string name, int weight)
			: base(name, weight, "Caramel")
		{
			Filling = "Jam";
		}
	}
}