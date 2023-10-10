namespace LivingBeing;

public class Cat : Animal
{
	public Cat(string name, int age) : base(name, age)
	{
		Console.WriteLine("Cat instance created");
	}
	public void Jump() 
	{
		Console.WriteLine("Jump");
	}
	public void Meow() 
	{
		Console.WriteLine("Meow");
	}
}
