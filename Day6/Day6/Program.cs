// // Static
// class Program 
// {
// static void Main()
// {
// 	int a = 2;
// 	int b = 3;
// 	Calculator myCalc = new();
// 	int result = myCalc.NonStaticAdder(a,b);
// 	// result.Dump();
// 	Console.WriteLine(result);
// }
// class Calculator {
// 	public static int Add(int left, int right) {
// 		return left+right;
// 	}
// 	public int NonStaticAdder(int left, int right) {
// 		return left+right;
// 	}
// 	//all must be static
// }}



//Constant is static global
// class Program 
// {
// static void Main()
// {
// 	MyMath math = new MyMath();
// 	//math.phi.Dump(); cant call static variable from instance
	
// 	// MyMath.phi.Dump();
// 	Console.WriteLine(MyMath.phi);
// }
// class MyMath {
// 	public const float phi = 3.14f; //Const is static
// }}




// // //Static
class Program 
{
static void Main()
{
	Car carA = new Car();
	Car carB = new Car();
	carB.PriceHandler(10);
	carA.PriceHandler(11);
	
	// carA.GetPrice().Dump();
	Console.WriteLine(carA.GetPrice());
	Console.WriteLine(carB.GetPrice());
	Console.WriteLine(Car.StaticPrice);
}

class Car {
	public static int StaticPrice;
	
	public void PriceHandler(int price) {
		StaticPrice = price;
	}
	public int GetPrice()
	{
		return StaticPrice;
	}
}}