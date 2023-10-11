namespace LivingBeing;

public class Dog : Animal
{
	public Dog(string name, int age) : base(name, age)
	{
		Console.WriteLine("Dog instance created");
	}
	public void Run() 
	{
		Console.WriteLine("Run doggy");
	}
	public void Bark() 
	{
		Console.WriteLine("Bark");
	}
}
