//Foreach
class program
{
	static void Main()
{
	int[] myArray = {23,24,25,26,27};
	foreach(int age in myArray) {
		Console.WriteLine(age);
	}
	
	List<string> myList = new List<string>() {"visi","prisilia","pananginan"};
	foreach(string name in myList) {
		Console.WriteLine(name);
	}
	
	List<Motor> myMotor = new List<Motor>() {
		new Motor("Yamaha"),
		new Motor("Suzuki"),
		new Motor("Honda")
	};
	foreach(Motor motor in myMotor) {
		Console.WriteLine(motor.brand);
	}
}



class Motor { 
	public string brand;
	public Motor(string brand) 
	{
		this.brand = brand;
	}
}
}