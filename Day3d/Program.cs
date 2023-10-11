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
		
		
	}
}
