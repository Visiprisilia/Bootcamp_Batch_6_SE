using System.Text;
// using System.Diagnostic;
class Program  
{
	static void Main()
	{
		StringBuilder sb = new();
		int iteration = 10000;
		// Stopwatch stopwatch = new Stopwatch();
		// stopwatch.Start(); 		
		for(int i=0; i<iteration; i++)
		{
			sb.Append("a");
			sb.Append("b");
			sb.Append("c");
		}
		// stopwatch.Stop();
		// Console.WriteLine(stopwatch.ElapsedMillisecond);
		Console.WriteLine(sb);
	}
}
