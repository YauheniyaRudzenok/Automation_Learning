namespace PlayWithPolymorphism.Domain
{
	public class Cat : Animal
	{
		private bool pooring;

		public Cat(int weight, string color, bool predator, bool pooring) 
			: base(weight, color, predator)
		{
			this.pooring = pooring;
		}

		public override string GetInfo()
		{
			return $"Cat's weight: {Weight}, Color: {Color}, Predater:{Predator}." +
				$" Is that cat pooring? - {pooring}";
		}
	}
}
