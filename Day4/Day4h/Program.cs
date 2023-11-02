
class Program

{
	
static void Main()
{
	Parent p = new Child();
	Child c = (Child)new Parent();
	Console.WriteLine(c.x);
}

class Parent { }
class Child : Parent { public int x = 3; }
}