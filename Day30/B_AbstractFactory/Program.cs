using B_AbstractFactory;

class Program
{
	static void Main()
	{
		Console.Write("Enter laptop brand (Asus/Dell): ");
		string brand = Console.ReadLine().ToLower();
		
		ILaptopFactory factory = null;
		if (brand == "asus")
		{
			factory = new AsusFactory();
		}
		else if (brand == "dell")
		{
			factory = new DellFactory();			
		}
		else
		{
			Console.WriteLine("Error, Invalid Input");
			return;
		}
		LaptopClient client = new LaptopClient(factory);
		Console.WriteLine("Ordering Gaming Laptop: ");
		client.OrderGamingLaptop();
		
		Console.WriteLine("Ordering Office Laptop: ");
		client.OrderOfficeLaptop();
		 
	}
}