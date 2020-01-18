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
			List<string> listOfStrings = new List<string>() { "cat", "baloon", "dog", "mother", "lorem ipsum sit dolor", "", "dfgdfgd" };
			List<char> vovels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
			int[] relationship= new int[listOfStrings.Count];
			//List<int> indexes = new List<int>();
			List<string> sortedListOfWords = new List<string>();

			for (int word = 0; word < listOfStrings.Count; word++)
			{
				string listword = listOfStrings[word];
				int vovelsNumber = 0;

				for (int letter = 0; letter < listword.Length; letter++)
				{
					char letterValue=listword[letter];
					if (vovels.Contains(letterValue))
					{
						vovelsNumber++;
					}
				}
				relationship[word] = vovelsNumber;
			}

			for (int index = 0; index < relationship.Length; index++)
			{
				int smallest = index;

				for (int secondIndex = 0; secondIndex < relationship.Length; secondIndex++)
				{
					if(relationship[smallest] > relationship[secondIndex])
					{
						smallest = secondIndex;
					}
				}
				sortedListOfWords.Add(listOfStrings[smallest]);
				relationship[smallest] = 1000;
			}

			//for (int index = 0; index < relationship.Length; index++)
			//{
			//	int smallest = index;
			//	for (int indexCompared = 0; indexCompared < relationship.Length; indexCompared++)
			//	{
			//		if (relationship[index] < relationship[indexCompared] && relationship[index] <relationship[smallest])
			//		{
			//			smallest = index;
			//		}
			//		if (relationship[indexCompared] < relationship[index] && relationship[indexCompared] < relationship[smallest])
			//		{
			//			smallest = indexCompared;
			//		}
			//	}
			//	sortedListOfWords.Add(listOfStrings[smallest]);
			//	relationship[smallest] = 1000;
			//}

			for (int i = 0; i < sortedListOfWords.Count; i++)
			{
				Console.WriteLine(sortedListOfWords[i]);
			}
		}
	}
}
