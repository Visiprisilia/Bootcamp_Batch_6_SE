//class instantiate
class Program {
	static void Main() {
		Cat cat = new Cat();
		Cat cat1 = new();
		var cat2 = new Cat();
		//var cat3 = new(); <- Error
	}
}

class Cat {
	public string name;
	private int age;
	
	public void Jump() {
		Console.WriteLine("Jump");
	}
	protected void Eat() {
		Console.WriteLine("Eat");
	}
}