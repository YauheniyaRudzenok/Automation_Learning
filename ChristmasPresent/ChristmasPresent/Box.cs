using System;
using System.Collections.Generic;
using System.Linq;

namespace ChristmasPresent
{
	class Box
	{
		List<Candies> insideBox = new List<Candies>();
		List<Candies> sortedItems = new List<Candies>();
		private int boxWeight;

		public void AddCandy(Candies candyItem)
		{
			insideBox.Add(candyItem);
		}

		// rewrite
		public int DefineWeight()
		{
			for (int i = 0; i < insideBox.Count; i++)
			{
				boxWeight = boxWeight + insideBox[i].Weight;
				//boxWeight += insideBox[i].Weight;
			}

			return boxWeight;
		}

		public void ExtendetSearchCandy(string name = "", string type = "", int weight = 0)
		{
			for (int i = 0; i < insideBox.Count; i++)
			{
				// 1 if
				if (insideBox[i].Name == name)
				{
					insideBox[i].GetInfo();
				}
				else if (insideBox[i].Type == type)
				{
					insideBox[i].GetInfo();
				}
				else if (insideBox[i].Weight == weight)
				{
					insideBox[i].GetInfo();
				}
			}
		}

		public void RestrictedSearchCandy(string name = "", string type = "", int weight = 0)
		{
			// Where();
			for (int i = 0; i < insideBox.Count; i++)
			{
				if (name == "")
				{
					// if
					if (insideBox[i].Type == type && insideBox[i].Weight == weight)
					{
						insideBox[i].GetInfo();
					}
					else if (weight == 0 && insideBox[i].Type == type)
					{
						insideBox[i].GetInfo();
					}
					else if (insideBox[i].Weight == weight && type == "")
					{
						insideBox[i].GetInfo();
					}
				}
				else if (type == "")
				{
					if (insideBox[i].Name == name && insideBox[i].Weight == weight)
					{
						insideBox[i].GetInfo();
					}
					else if (weight == 0 && insideBox[i].Name == name)
					{
						insideBox[i].GetInfo();
					}
				}
				else if (weight == 0)
				{
					if (insideBox[i].Name == name && insideBox[i].Type == type)
					{
						insideBox[i].GetInfo();
					}
				}
				else if (name == "" && type == "" && weight == 0)
				{
					Console.WriteLine("No search parameters are inputted");
				}
				else
				{
					if (insideBox[i].Name == name && insideBox[i].Type == type && insideBox[i].Weight == weight)
					{
						insideBox[i].GetInfo();
					}
				}
			}
		}

		public void SortCandies()
		{
			sortedItems=insideBox.OrderBy(u => u.Name).ToList();

			for (int i = 0; i < insideBox.Count; i++)
			{
				Console.WriteLine(sortedItems[i].Name);
			}
		}
	}
}
