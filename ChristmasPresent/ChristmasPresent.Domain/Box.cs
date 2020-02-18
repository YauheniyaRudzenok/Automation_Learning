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
            try
            {
                if (candyItem == null)
                {
                    throw new Exception("ERROR: The object is empty. Please specify candys parameters");
                }
                else
                {
                    insideBox.Add(candyItem);
                }
            }
            catch(Exception emptyItem)
            {
                Console.WriteLine(emptyItem.Message);
            }
        }

		public int DefineWeight()
		{
            int boxWeight = 0;

            foreach (Candies item in insideBox)
            {
                boxWeight += item.Weight;
            }

			return boxWeight;
		}

		public List<Candies> ExtendedSearchCandy(string name = "", string type = "", int weight = 0)
		{
            List<Candies> result = new List<Candies>();
            foreach (Candies item in insideBox)
			{
				if (item.Name == name || 
					item.Type == type || 
					item.Weight == weight)
				{
                    result.Add(item);
				}
			}
            return result;
        }

		public List <Candies> RestrictedSearchCandy(string name = "", string type = "", int weight = 0)
		{
            List<Candies> result = new List<Candies>();
			// Where();
			if (string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(type) && weight == 0)
			{
				return result;
			}

			foreach (Candies item in insideBox)
			{
				if (string.IsNullOrWhiteSpace(name))
				{
					if ((item.Type == type && item.Weight == weight) ||
						(weight == 0 && item.Type == type) ||
						(item.Weight == weight && type == ""))
					{
						result.Add(item);
					}
				}
				else if (string.IsNullOrWhiteSpace(type))
				{
					if ((item.Name == name && item.Weight == weight) ||
						(weight == 0 && item.Name == name))
					{
						result.Add(item);
					}
				}
				else if (weight == 0)
				{
					if (item.Name == name && item.Type == type)
					{
						result.Add(item);
					}
				}
				else
				{
					if (item.Name == name && item.Type == type && item.Weight == weight)
					{
						result.Add(item);
					}
				}
			}

			return result;
        }

		public List<Candies> SortCandies()
		{
			return insideBox.OrderBy(u => u.Name).ToList();
		}

        public void DeleteCandy(Candies candyItem)
        {
            try
            {
                if (insideBox.Contains(candyItem))
                {
                    insideBox.Remove(candyItem);
                }
                else
                {
                    throw new Exception("Item is absent in the box");
                }
            }
            catch (Exception absentItem)
            {
                Console.WriteLine($"ERROR:{absentItem.Message}");
            }

        }
    }
}