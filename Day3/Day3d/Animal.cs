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

class Ant  //no inheritance

{
	public new void MakeSound()
	{
		Console.WriteLine("sssssss");
	}
}