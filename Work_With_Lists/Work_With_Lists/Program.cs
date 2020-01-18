using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_With_Lists
{
	class Program
	{
		static void Main()
		{
			List<string> listOfStrings = new List<string>() {"cat", "baloon", "dog", "mother"};
			List<char> vovels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };

			for (int word = 0; word < listOfStrings.Count; word++)
			{
				List<string> listword = new List<string>() { listOfStrings[word] };


				for (int letter=0; letter < listword.Count; letter++)
				{
					Console.WriteLine(listword[letter]);
				}
			}
		}
	}
}
