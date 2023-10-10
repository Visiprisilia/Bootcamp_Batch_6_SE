using LivingBeing;

class Program 
{
	static void Main() 
	{
		Cat cat = new Cat("oyen",4);
		Dog dog = new Dog("dogi",5);
		Console.WriteLine(cat.name);
		Console.WriteLine(dog.name);
		Console.WriteLine(dog.age);
		Console.WriteLine(cat.age);
	}
}