namespace PlayWithPolymorphism.Domain
{
	public abstract class Animal
	{
		public Animal(int weight, string color, bool predator)
		{
			Weight = weight;
			Color = color;
			Predator = predator;
		}

		public int Weight { get; set; }
		public string Color { get; }
		public bool Predator { get; set; }

		public abstract string GetInfo();
	}
}
