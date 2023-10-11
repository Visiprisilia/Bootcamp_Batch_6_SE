using LivingBeing;

class Program 
{
	static void Main(){
		Cat cat = new Cat("oyen",4);
		Console.WriteLine(cat.name);
		Console.WriteLine(cat.age);
		// Console.WriteLine(cat.GetAge());
		cat.SetAge(4);
		
	}
}
	