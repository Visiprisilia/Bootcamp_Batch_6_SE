namespace foobar;
class Foobar
{
	public static void foobar(int angka)
	{
		for (var n = 1; n <= angka; n++)
		{
			if (n % 3 == 0 && n % 5 == 0)
			{
				Console.Write("foobar");
			}
			else if (n % 3 == 0)
			{
				Console.Write("foo");
			}
			else if (n % 5 == 0)
			{
				Console.Write("bar");
			}
			else
			{
				Console.Write(n);
			}
			Console.Write("\n ");
		}
	}

}