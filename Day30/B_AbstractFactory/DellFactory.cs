namespace B_AbstractFactory;

public class DellFactory: ILaptopFactory
{
    public ILaptop CreateGamingLaptop()
    {
        return new DellAlienware();
    }

    public ILaptop CreateOfficeLaptop()
    {
        return new DellLatitude();
    }
}
