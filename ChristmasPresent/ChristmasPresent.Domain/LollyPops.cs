namespace ChristmasPresent.Domain
{
	public class LollyPops : Candies
	{
		public LollyPops(string name, int weight)
			: base(name, weight)
		{
			Type = "Lolly-Pop";
		}
	}
}
