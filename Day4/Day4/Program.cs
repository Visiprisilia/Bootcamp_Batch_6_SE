//Inheritance OK and Overriding and Method Hiding
class Program
{
	static void Main()
	{
	Engine general = new DieselEngine();
	//Engine e = new Engine();
	//DieselEngine diesel = new DieselEngine();
	//e = diesel;

	DieselEngine diesel = new();
	ElectricEngine electric = new();
	
	Car car = new Car(diesel);
	car.EngineStart();
}
class Car
{
	private Engine _engine;
	public Car(Engine e)
	{
		_engine = e;
	}
	public void EngineStart()
	{
		_engine.Run();
		_engine.WarmUp();
	}
}
class Engine {
	public virtual void Run() {
		
		Console.WriteLine("Engine Run");
	}
	public void WarmUp() {
	}
}
class DieselEngine : Engine
{
	public override void Run()
	{
		Console.WriteLine("Diesel Engine Run");
	}
	public void WarmUp() {
		Console.WriteLine("Diesel Engine Warm Up");
	}
}
class ElectricEngine : Engine
{
	public void Run()
	{
		Console.WriteLine("Electric Engine Run");
	}
}}