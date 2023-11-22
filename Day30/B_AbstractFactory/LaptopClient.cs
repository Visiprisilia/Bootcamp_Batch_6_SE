namespace B_AbstractFactory;

public class LaptopClient
{
	private ILaptopFactory laptopFactory;
	
	public LaptopClient (ILaptopFactory factory)
	{
		laptopFactory = factory;
	}
	public void OrderGamingLaptop()
	{
		ILaptop gamingLaptop = laptopFactory.CreateGamingLaptop();
		Console.WriteLine(gamingLaptop.GetName());
	}
	public void OrderOfficeLaptop()
	{
		ILaptop officeLaptop = laptopFactory.CreateOfficeLaptop();
		Console.WriteLine(officeLaptop.GetName());
	}
}
