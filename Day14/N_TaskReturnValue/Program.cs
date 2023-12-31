﻿using System.Threading.Tasks;

class Program
{
	static void Main()
	{
		int x = 3;
		int y = 4;
		Task<int> task = Task.Run(()=>Add(x,y)); //using lambda expression //generik untuk memanggil valuenya (int)
		// task.Wait();
		int result = task.Result; //panggil hasil
		Console.WriteLine($"Result: {result}");
	}
	
	static int Add(int a, int b)
	{
		// task.Delay(200) //taskdsz
		// askTask.Delay();
		// task.Sleep(200) //thread
		return a + b;
	}
}