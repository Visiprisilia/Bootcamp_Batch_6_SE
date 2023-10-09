using Animal;
class Program

{
	 static void Main(string[] args)

	{
		
	Cat oyen = new Cat();
	
	oyen.name = "Oyen";
	oyen.colour = "Orange";
	oyen.leg = 4;
	oyen.istaillong = true;
	oyen.height = 50;
	oyen.weight = 20;
	
	Console.WriteLine(oyen.name);	
	Console.WriteLine(oyen.colour);	
	Console.WriteLine(oyen.leg);	
	Console.WriteLine(oyen.istaillong);	
	Console.WriteLine(oyen.weight);	
	Console.WriteLine(oyen.height);	
	
	oyen.Jump();
	
	Console.WriteLine();
	
	Cat bambang = new Cat();
	
	bambang.name = "Bambang";
	bambang.colour = "Black";
	bambang.leg = 4;
	bambang.istaillong = true;
	bambang.height = 40;
	bambang.weight = 30;
	
	Console.WriteLine(bambang.name);	
	Console.WriteLine(bambang.colour);	
	Console.WriteLine(bambang.leg);	
	Console.WriteLine(bambang.istaillong);	
	Console.WriteLine(bambang.weight);	
	Console.WriteLine(bambang.height);	
	
		
	}
}
