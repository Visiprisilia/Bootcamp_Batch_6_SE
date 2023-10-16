// int float double
class Program

{
static void Main()
{

	int a = 1;
	int b = 2;
	int c = 3;
	// (a+b == c).Dump(); // True
	Console.WriteLine(a+b==c);
	
	float fa = 1.0f;
	float fb = 2.0f;
	float fresult = 1.0f + 2.0f;
	float fc = 3.0f;
	// (fresult == fc).Dump(); // True
	Console.WriteLine(fresult==fc);

	double da = 0.1;
	double db = 0.2;
	double result = a + b;
	Console.WriteLine(a + b == 0.3); //False
	Console.WriteLine(result);

	decimal DA = 1.0M;
	decimal DB = 2.0M;
	decimal DC = 3.0M;
	// (DA+DB == DC).Dump(); // True
	Console.WriteLine(DA+DB == DC);
}
}

// You can define other methods, fields, classes and namespaces here