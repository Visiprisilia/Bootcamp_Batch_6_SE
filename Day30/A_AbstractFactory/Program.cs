using A_AbstractFactroy;
class Program
{
	static void Main()
	{
		try
		{
			Console.Write("Enter laptop brand (Asus/Dell): ");
			string brand = Console.ReadLine();

			Console.Write("Enter laptop type (Gaming/Office): ");
			string type = Console.ReadLine();

			if (type.ToLower() == "gaming")
			{
				GamingLaptop gamingLaptop = LaptopStore.GetGamingLaptop(brand);
				Console.WriteLine($"Brand: {gamingLaptop.brand}, Graphic Card: {gamingLaptop.graphicCard}, Keyboard: {gamingLaptop.keyboard}");
			}
			else if (type.ToLower() == "office")
			{
				OfficeLaptop officeLaptop = LaptopStore.GetOfficeLaptop(brand);
				Console.WriteLine($"Brand: {officeLaptop.brand}, Graphic Card: {officeLaptop.graphicCard}, Keyboard: {officeLaptop.keyboard}");
			}
			else
			{
				throw new ArgumentException("Invalid laptop type. Please specify 'gaming' or 'office'.");
			}
		}
		catch (ArgumentException ex)
		{
			Console.WriteLine($"Error: {ex.Message}");
		}
	}
}
