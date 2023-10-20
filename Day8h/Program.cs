//Anonymous Delegate (Lambda Expression)
class Program
{
	static void Main()

	{
		// (parameter) => (return);
		var method = (int x, int y) =>
		{
			return x + y;
		};

		var printer = (object x) => x.Dump();
		var nggangapa2in = () => "diam".Dump();

		printer(30);
		int result = method(3, 4);
		result.Dump();
	}

	int Add(int x, int y)
	{
		return x + y;
	}

	int Add2(int x, int y) => x + y;
}