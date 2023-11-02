using Engine;
//Car with interface
class Car {
	public IEngine engine;
	public Car(IEngine e) {
		engine = e;
	}
	public void Move() {
		engine.Run();
	}
}
public interface IEngine { 
	void Run();
}
class ElectricEngine : IEngine {
	public void Run() {
		Console.WriteLine("Electric Engine Run");
	}
}
class HydrogenEngine : IEngine
{
	public void Run()
	{
		Console.WriteLine("Hydrogen Engine Run");
	}
}
static void Main() {
	Car car = new Car(new IEngine());
	car.Move();
}