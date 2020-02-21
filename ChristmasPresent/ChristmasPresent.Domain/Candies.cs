using System;

namespace ChristmasPresent.Domain
{
	public abstract class Candies : ICandies
	{

		public Candies(string name, int weight, string type)
		{
            Name = name ?? throw new IncorrectValueException("ERROR: The value should not be NULL");
            if (Name.Length > 225)
            {
                throw new ValueLengthException("ERROR: The value length should not be bigger than 225 symbols");
            }

            Weight = weight > 0 ? weight : throw new IncorrectValueException("ERROR: The value can not be less then 0");
			Type = type ?? throw new IncorrectValueException("ERROR: The value should not be NULL");
            if (Type.Length > 225)
            {
                throw new ValueLengthException("ERROR: The value length should not be bigger than 225 symbols");
            }
        }
		public string Name { get; set; }
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
