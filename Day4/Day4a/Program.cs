//Inheritanceclass Program
class Program
{
	static void Main()
	{
	DieselEngine diesel = new();
	ElectricEngine electric = new();
	
	Car car = new Car(diesel);
	//Car car = new Car(engine); -> Beda bahan
	car.EngineStart();
}
class Car {
	private DieselEngine _engine;
	public Car(DieselEngine e) {
		_engine = e;
	}
	public void EngineStart() {
		_engine.Run();
	}
}
class DieselEngine {
	public void Run() {
		Console.WriteLine("Diesel Engine Run");
	}
}
class ElectricEngine
{
	public void Run()
	{
		Console.WriteLine("Electric Engine Run");
	}
}}