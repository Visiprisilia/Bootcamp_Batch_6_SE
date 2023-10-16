class Program

{
static void Main()
{
	Child c = new Child();
	Parent p = c;
	Child result = (Child)p;
	Console.WriteLine(result.x);
}
}
class Parent { }
class Child : Parent { public int x = 3; }