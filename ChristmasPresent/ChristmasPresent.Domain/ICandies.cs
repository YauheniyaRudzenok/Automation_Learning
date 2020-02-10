namespace ChristmasPresent.Domain
{
	interface ICandies
	{
		string Name { get; set; }
		int Weight { get; }
		string Type { get; }
		string Filling { get; set; }
	}
}
