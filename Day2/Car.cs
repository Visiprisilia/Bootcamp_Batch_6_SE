namespace Transportation;
class Car

{
	//variable
	public string colour;
	public int door;
	public string brand;

	// public Car(string colour, int door, string brand)
	// {
	// 	this.brand = brand; // 
	// 	this.colour = colour;
	// 	this.door = door;
	// }

	// public string colours;
	// public int doors;
	// public string brands;
	
	//construction objek/instance
	
	// public Car(string colour, int door, string brand)//tidak pakai this (nama variable berbeda dengan nama baru)
	// {
	// 	brands = brand; // 
	// 	colours = colour;
	// 	doors = door;
	// }
	public Car()
	{
		brand = "Honda";
		door = 4;
		colour = "pink";
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