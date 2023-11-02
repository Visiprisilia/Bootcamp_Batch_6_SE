////GetInvocationList (return string)
public delegate string MyDelegate();

class Program
{
	static void Main()
	{
		MyDelegate mydel = Message;
		mydel += Pesan;
		mydel += Email;
		mydel += Masuk;

		List<string> result = new();
		Delegate[] delegateList = mydel.GetInvocationList();
		foreach (MyDelegate d in delegateList)
		{
			result.Add(d.Invoke());
		}
		foreach (var str in result)
		{
			Console.WriteLine(str);
		}

	}
	static string Message()
	{
		return "Messageeee";
	}
	static string Pesan()
	{
		return "Pesannn";
	}
	static string Email()
	{
		return "Emailll";
	}
	static string Masuk()
	{
		return "Masukkk";
	}
}
