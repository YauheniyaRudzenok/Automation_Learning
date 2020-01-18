using System;
using System.Collections.Generic;

namespace PlayWithPolymorphism.Domain
{
	public class Hotel
	{
		List<Cat> room1 = new List<Cat>();
		List<Dog> room2 = new List<Dog>();
		List<Animal> room3 = new List<Animal>();

		public void Room1Filling(Cat cat)
		{
			room1.Add(cat);
		}
		
		public void Room2Filling(Dog dog)
		{
			room2.Add(dog);
		}
		
		public void Room3Filling(Animal animal)
		{
			room3.Add(animal);
		}
		
		public void Room1Statistic()
		{
			int Room1Animals = room1.Count;
			Console.WriteLine($"Number of Animals in Room1: {Room1Animals}");
			for (int i = 0; i < room1.Count; i++)
			{
				Console.WriteLine($"Cat {i} has following parameters:");
				Console.WriteLine(room1[i].GetInfo());
			}
		}
		
		public void Room2Statistic()
		{
			int Room2Animals = room2.Count;
			Console.WriteLine($"Number of Animals in Room 2: {Room2Animals}");
			for (int i = 0; i < room2.Count; i++)
			{
				Console.WriteLine($"Dog {i} has following parameters:");
				Console.WriteLine(room2[i].GetInfo());
			}
		}
		
		public void Room3Statistic()
		{
			int Room3Animals = room3.Count;
			for (int i = 0; i < room3.Count; i++)
			{
				Console.WriteLine($"Animal {i} has following parameters:");
				Console.WriteLine(room3[i].GetInfo());
			}
		}
	}
}
