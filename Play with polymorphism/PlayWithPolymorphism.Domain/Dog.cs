using System;
using System.Collections.Generic;
using System.Text;

namespace PlayWithPolymorphism.Domain
{
	public class Dog : Animal
	{
		public Dog(int weight, string color, bool predator) : base(weight, color, predator)
		{

		}

		public override string GetInfo()
		{
			return $" Dog's weight: {Weight}, Color:{Color},Predator: {Predator}";
		}
	}
}
