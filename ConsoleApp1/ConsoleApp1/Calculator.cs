using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Calculator
	{
		static void Main()
		{
			Console.WriteLine("Calculator is started");

			string a, b;

			a = Console.ReadLine();
			decimal firstNumber=Convert.ToDecimal(a);

			string action = Console.ReadLine();

			b = Console.ReadLine();
			decimal secondNumber=Convert.ToDecimal(b);

			decimal result=0;
			switch(action)
			{
				case "+":
					result = firstNumber + secondNumber;
					break;
				case "-":
					result = firstNumber - secondNumber;
					break;
				case "*":
					result = firstNumber * secondNumber;
					break;
				case "/":
					result = firstNumber / secondNumber;
					break;
			}
			Console.WriteLine(result);
		}
	}
}
