using CarComponent;

namespace Transportation;

public class Car
{
	public Engine mesin;
	public Tire ban;
	public Lamp lamp;
	
	public Car(Engine engine, Tire tire, Lamp lamp) 
	{
		mesin = engine;
		ban = tire;
		this.lamp = lamp;
		
		Console.WriteLine("sudah menerima engine, ban, lampu");
		// Console.WriteLine("Car have a " + Engine + " now");
	}
	public void EngineCheck()
	{
	}
	public void TireCheck() 
	{
	}
}
