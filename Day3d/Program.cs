class Program

{
	static void Main()
	{
		Cat cat = new Cat(); //Overriding
		cat.MakeSound();
		Animal parent = cat;
		parent.MakeSound();
		
		Dog dog = new Dog();
		dog.MakeSound();
		Animal parent2 = dog;
		parent.MakeSound();
		
		Bird bird = new Bird();
		bird.MakeSound();
		Animal parent3 = bird;
		parent.MakeSound();
		
		Ant ant = new Ant();
		ant.MakeSound();
		Animal parent4 = ant;
		parent.MakeSound();
		
	}
}

class Animal //parent
{
	public virtual void MakeSound()
	{
		Console.WriteLine("Make Sound");
	} 
}

class Dog : Animal //ngikut bapake

{

}
 
class Cat : Animal //Overriding

{
	public override void MakeSound()
	{
		Console.WriteLine("Meowwwww saya laparrr");
	}
}

class Bird : Animal //Method hidding

{
	public new void MakeSound()
	{
		Console.WriteLine("Hihihihihi");
	}
}

class Ant : Animal //no inheritance

{
	public new void MakeSound()
	{
		Console.WriteLine("sssssss");
	}
}