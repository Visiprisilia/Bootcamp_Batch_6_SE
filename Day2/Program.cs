using Transportation;

class Program

{
	static void Main(string[] args)
	{
		// Car toyota = new Car("Pink",4,"honda");
		// toyota.brand="Hondaa";
		// Console.WriteLine(toyota.brand);
		Car toyota = new Car();
		toyota.brand="Mitsubishi";
		Console.WriteLine(toyota.brand); //membaca yang terakhir di declarate
		Console.WriteLine(toyota.door);
		Console.WriteLine(toyota.colour);
		
		
	}

}