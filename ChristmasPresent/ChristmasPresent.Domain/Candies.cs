using System;

namespace ChristmasPresent.Domain
{
	// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
	// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator
	public abstract class Candies : ICandies
	{
        public string nameValue;
		public Candies(string name, int weight, string type)
		{
			Name = name;
			Weight = weight;
			Type = type;
		}
		public string Name 
        {
            get 
            { 
                return Name; 
            }
            set 
            {
                if (value.Length > 10)
                    throw new IncorrectValueException("The value should be less than 10 symbols");
            } 

        }
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
