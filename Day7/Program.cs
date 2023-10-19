public delegate void MyDelegate(); //wadah dari method

class Program {
	static void Main() {
		MyDelegate myDelegate = Printer;
		myDelegate += Layangan;
		myDelegate += Printer2;
		myDelegate += Layangan2;
		
		myDelegate(); //Invoke
	}
	static void Printer() {
		Console.WriteLine("Printerrr");
	}
	static void Layangan() {
		Console.WriteLine("Layangann");
	}
	static void Printer2()
	{
		Console.WriteLine("Printerrs");
	}
	static void Layangan2()
	{
		Console.WriteLine("Layanganns");
	}
}