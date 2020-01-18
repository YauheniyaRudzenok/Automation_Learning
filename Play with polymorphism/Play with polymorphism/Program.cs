using PlayWithPolymorphism.Domain;

namespace Play_with_polymorphism
{
	class Program
	{
		static void Main(string[] args)
		{
			Hotel HolydayInn = new Hotel();

			Cat cat1 = new Cat(20, "black", true, true);
			Cat cat2 = new Cat(5, "white", false, false);

			//HolydayInn.Room1Filling(cat1);
			//HolydayInn.Room1Filling(cat2);
			//HolydayInn.Room1Statistic();

			//Console.WriteLine(cat.GetInfo());
			//Animal someAnimal = new Cat();
			Dog dog1 = new Dog(10, "brawn", true);
			Dog dog2 = new Dog(25, "orange", false);
			//Console.WriteLine(dog.GetInfo());

			//HolydayInn.Room2Filling(dog1);
			//HolydayInn.Room2Filling(dog2);
			//HolydayInn.Room2Statistic();

			HolydayInn.Room3Filling(dog1);
			HolydayInn.Room3Filling(dog2);
			HolydayInn.Room3Filling(cat1);
			HolydayInn.Room3Filling(cat2);
			HolydayInn.Room3Statistic();
		}
	}
}
