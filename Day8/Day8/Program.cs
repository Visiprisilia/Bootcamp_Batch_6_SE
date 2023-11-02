//Action
class Program
{
	static void Main()

	{
		Action<string> act = null;
		act?.Invoke("Haiii"); //without ? will be expection

	}
	static void Printer(string message)
	{
		Console.WriteLine(message);
	}
	static void Update(string update)
	{
		Console.WriteLine(update);
	}

}