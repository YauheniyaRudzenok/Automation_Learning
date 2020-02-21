using System;

namespace ChristmasPresent.Domain
{
	public abstract class Candies : ICandies
	{
        public string nameValue;
		public Candies(string name, int weight, string type)
		{
            Name = name ?? throw new IncorrectValueException("ERROR: The value should not be NULL");
            Weight = weight > 0 ? weight : throw new IncorrectValueException("ERROR: The value can not be less then 0");
			Type = type ?? throw new IncorrectValueException("ERROR: The value should not be NULL");
		}
		public string Name 
        {
            get { return nameValue; }
            set { if (value.Length > 225)
                    throw new ValueLengthException("the name cannot be more than 225 symbols");
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
