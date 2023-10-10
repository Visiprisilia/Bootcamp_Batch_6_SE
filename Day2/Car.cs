namespace Transportation;
class Car

{
	//variable
	public string colour;
	public int door;
	public string brand;
	//constructionobjek/instance
	public Car(string colour, int door, string brand)
	{
		this.brand = brand;
		this.colour = colour;
		this.door = door;
	}
	//method/function	
	public void EngineRun()
	{

	}

	// public void Move(String direction)
	// {
	// 	Console.WriteLine(direction);
	// 	Console.WriteLine("Car move"+direction+"now");
	// 	Console.WriteLine($"Car move{direction}now");
	// 	Console.WriteLine($"\t Car move \n to{direction}now");

	// }


}