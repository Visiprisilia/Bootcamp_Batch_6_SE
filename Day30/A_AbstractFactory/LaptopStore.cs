namespace A_AbstractFactroy;

public class LaptopStore
{
	public static GamingLaptop GetGamingLaptop(string brand)
	{
		switch (brand.ToLower())
		{
			case "asus":
			return new GamingLaptop
			{
				brand = "Asus",
				graphicCard = "Nvidia",
				keyboard = "RGB"				
			};
			case "dell":
			return new GamingLaptop
			{
				brand = "Dell",
				graphicCard = "Nvidia",
				keyboard = "RGB"				
			};
			default:
			 throw new ArgumentException("Invalid brand. Please choose Asus or Dell.");        
			
		}
	}
	public static OfficeLaptop GetOfficeLaptop(string brand)
	{
		switch (brand.ToLower())
		{
			case "asus":
			return new OfficeLaptop
			{
				brand = "Asus",
				graphicCard = "Intel",
				keyboard = "Standard"
			};
			case "dell":
			return new OfficeLaptop
			{
				brand = "Dell",
				graphicCard = "Intel",
				keyboard = "Standard"
			};		
			default:
			 throw new ArgumentException("Invalid brand. Please choose Asus or Dell.");        							 
		}
	}
}
