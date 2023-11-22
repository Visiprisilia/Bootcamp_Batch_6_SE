namespace B_AbstractFactory;

public interface ILaptopFactory
{
	ILaptop CreateGamingLaptop();
	ILaptop CreateOfficeLaptop();
}
