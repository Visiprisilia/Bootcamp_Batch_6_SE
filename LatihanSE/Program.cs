using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using foobar;


class Program
{
	static void Main()
	{
		Console.Write("Masukkan angka yang akan ditampilkan: ");
		bool warning = int.TryParse(Console.ReadLine(), out int num);

		if (warning == false)
		{
			Console.WriteLine("Masukkan Harus Berupa Angka");
		}
		else
		{
			Foobar.foobar(num);
		}
	}


}