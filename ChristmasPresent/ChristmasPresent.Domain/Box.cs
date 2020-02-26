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
 
                if (candyItem == null)
                {
                    throw new ArgumentNullException("ERROR: The object is empty. Please specify candy parameters");
                }

            insideBox.Add(candyItem);
        }

		public int DefineWeight()
		{
            if (insideBox.Count == 0)
            {
                throw new Exception("The box is empty. Please add some value before defining the weight");
            }
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
                if (result.Count==0) 
                { 
                    throw new ArgumentNullException ("No searched items are found in the box"); 
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
                throw new NoResultException("Please input a search query.");
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
            if (insideBox.Count==0)
            {
                throw new Exception("ERROR: is it impossible to sort items in empty box");
            }
            return insideBox.OrderBy(u => u.Name).ToList();
        }

        public void DeleteCandy(Candies candyItem)
        {
                if (insideBox.Count == 0)
                {
                throw new Exception("It is impossible to remove item from the box. The box is empty");
                }
                if (insideBox.Contains(candyItem))
                {
                    insideBox.Remove(candyItem);
                }
                else
                {
                    throw new ArgumentException("ERROR: Item is absent in the box");
                }
        }
    }
}