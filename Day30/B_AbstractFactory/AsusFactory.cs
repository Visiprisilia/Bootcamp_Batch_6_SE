namespace B_AbstractFactory;

public class AsusFactory: ILaptopFactory
{
    public ILaptop CreateGamingLaptop()
    {
        return new AsusRog();
    }

    public ILaptop CreateOfficeLaptop()
    {
        return new AsusVivobook();
    }
}