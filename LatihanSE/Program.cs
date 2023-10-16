class Program

{
	static void Main()
	{
		 Console.WriteLine("Tulis angka :");

 		string i = Console.ReadLine();
		{
			for(int i = 1; i <= n; i++)
			{
				if(i % 3 == 0)
				{
					if(i % 5 == 0)
					{
						Console.WriteLine("FooBar");
					}
					else
					{
						Console.WriteLine("Foo");
					}
				}
				else if(i % 5 == 0)
				{
					Console.WriteLine("Foo");
				}
				else
				{
					Console.WriteLine(i);
				}
			}
		}}}