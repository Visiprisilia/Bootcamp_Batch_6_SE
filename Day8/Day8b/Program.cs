//null

class Program
{
	static void Main()

	{
	Car car = new Car();
	// car.x.Dump();
	Console.WriteLine(car.x);
	//car.engine.Test();
	Console.WriteLine(car.y.Length);
	// car.y.Length.Dump();
}

class Car {
	public Engine engine;
	public string? y;
	public int x;
}
class Engine
{
	public void Test() {
		// "test".Dump();
		Console.WriteLine("Test");
	}
}
}
