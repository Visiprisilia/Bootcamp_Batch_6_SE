public delegate void MyDelegate();

class Program 
{
	static void Main()
	{
		 MyDelegate Mydel = Fotocopy;
		 Mydel += Printer;
		 
		 Mydel();
		 
		
	}
	static void Fotocopy()
	{
		Console.WriteLine("Fotocopyyy");
	}
	static void Printer()
	
	{
		Console.WriteLine("Printer");
	}
}