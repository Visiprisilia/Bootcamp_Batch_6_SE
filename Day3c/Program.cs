﻿//Overloading + Inheritance
class Program {
	static void Main() {
		Child c = new Child();
		Console.WriteLine(c.name);
	}
}

class Parent {
	private string _name;
	public Parent() {
		_name = "papa";
	}
	public Parent(string name) {
		_name = name;
	}
	
}
class Child:Parent {
	public Child(string name) 
	{
		
	}
	public Child() : base("parent") {
		
	}
	//public Child() { parameter sama dengan yang diatas
	//	
	//}
}