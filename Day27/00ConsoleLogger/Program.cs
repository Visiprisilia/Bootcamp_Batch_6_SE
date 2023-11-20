using System;

namespace LoggingIntroduction
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Starting the program...");

			int x = 3;
			int y = 5;
			
			Console.WriteLine($"x: {x}, y: {y}");

			int sum = x + y;

			Console.WriteLine($"The sum of x and y is: {sum}");

			Console.WriteLine("Program completed.");
		}
	}
}