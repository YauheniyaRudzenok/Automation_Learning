using System;
using System.Collections.Generic;
using System.Linq;

namespace ChristmasPresent.Domain
{
	public class Box
	{
		private List<Candies> insideBox = new List<Candies>();

        public void AddCandy(Candies candyItem)
		{
			insideBox.Add(candyItem);
        }

		public int DefineWeight()
		{
            int boxWeight = 0;

			// foreach

			for (int i = 0; i < insideBox.Count; i++)
			{
				boxWeight = boxWeight + insideBox[i].Weight;
				//boxWeight += insideBox[i].Weight;
			}

			return boxWeight;
		}

		// вернуть список
		public void ExtendetSearchCandy(string name = "", string type = "", int weight = 0)
		{
			for (int i = 0; i < insideBox.Count; i++)
			{
				if (insideBox[i].Name == name || 
					insideBox[i].Type == type || 
					insideBox[i].Weight == weight)
				{
					insideBox[i].GetInfo();
				}
			}
		}

		public List <Candies> RestrictedSearchCandy(string name = "", string type = "", int weight = 0)
		{
            List<Candies> restrictedSearchResult = new List<Candies>();
            // Where();
            for (int i = 0; i < insideBox.Count; i++)
			{
                 if (name == "" && type == "" && weight == 0)
                {
                    Console.WriteLine("Please specify your search query");
                }
                else if (string.IsNullOrWhiteSpace(name))
				{
					if ((insideBox[i].Type == type && insideBox[i].Weight == weight) ||
                        (weight == 0 && insideBox[i].Type == type) ||
                        (insideBox[i].Weight == weight && type == ""))
					{
                        restrictedSearchResult.Add(insideBox[i]);
                    }
				}
				else if (string.IsNullOrWhiteSpace(type))
				{
					if ((insideBox[i].Name == name && insideBox[i].Weight == weight)||
                        (weight == 0 && insideBox[i].Name == name))
					{
                        restrictedSearchResult.Add(insideBox[i]);
                    }
				}
				else if (weight == 0)
				{
					if (insideBox[i].Name == name && insideBox[i].Type == type)
					{
                        restrictedSearchResult.Add(insideBox[i]);
                    }
				}
				else
				{
					if (insideBox[i].Name == name && insideBox[i].Type == type && insideBox[i].Weight == weight)
					{
                        restrictedSearchResult.Add(insideBox[i]);
                    }
				}

            }
            return restrictedSearchResult;
        }

		public List<Candies> SortCandies()
		{
			return insideBox.OrderBy(u => u.Name).ToList();
		}
	}
}