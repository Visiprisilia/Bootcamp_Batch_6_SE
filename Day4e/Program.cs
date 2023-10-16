//Interface = Interface + Interface
class Program
{
	static void Main()
	{
		HumanSudahMenikah2 human = new();
		human.Kerja();
		human.Kuliah();
		human.Nikah();
		Console.WriteLine(human.SudahNikah(1));
		human.MainGame();

		IPermintaanOrtu permintaan = human;
		permintaan.Kerja();
		permintaan.Kuliah();
		permintaan.Nikah();
		Console.WriteLine(permintaan.SudahNikah(1));
		//permintaan.MainGame(); Error

		IPermintaanAnak permintaanAnak = human;
		permintaanAnak.Jajan();

	}
	public interface IPermintaanOrtu
	{
		void Kuliah();
		void Kerja();
		void Nikah();
		bool SudahNikah(int istri);
	}
	public interface IPermintaanRT
	{
		void BayarIuran();
	}
	public interface IPermintaanIstri
	{
		void IPhone();
		void PulangCepat();
	}
	public interface IPermintaanAnak
	{
		void Jajan();
	}
	public interface ISudahMenikah : IPermintaanOrtu, IPermintaanAnak, IPermintaanIstri, IPermintaanRT
	{

	}
	class Bapak { }
	class HumanSudahMenikah : Bapak, ISudahMenikah
	{
		public void Kerja()
		{
			Console.WriteLine("Kerja di Formulatrix");
		}

		public void Kuliah()
		{
			Console.WriteLine("Kuliah BSI aja");
		}

		public void Nikah()
		{
			Console.WriteLine("Nikah ok");

		}

		public bool SudahNikah(int istri)
		{
			if (istri > 0)
			{
				return true;
			}
			return false;
		}
		public void MainGame()
		{
			Console.WriteLine("Game");

		}

		public void Jajan()
		{
			Console.WriteLine("mcd");

		}

		public void IPhone()
		{
			Console.WriteLine("IPhone nanti dulu");

		}

		public void PulangCepat()
		{
			Console.WriteLine("PulangCepat ok");

		}

		public void BayarIuran()
		{
			Console.WriteLine("Bayar 100 Ribu");

		}
	}
	class HumanSudahMenikah2 : ISudahMenikah
	{
		public void Kerja()
		{
			Console.WriteLine("Kerja di DragonShip");

		}

		public void Kuliah()
		{
			Console.WriteLine("Kuliah UGM aja");
		}

		public void Nikah()
		{
			Console.WriteLine("Nikah belum");
		}

		public bool SudahNikah(int istri)
		{
			if (istri > 1)
			{
				return true;
			}
			return false;
		}
		public void MainGame()
		{
			Console.WriteLine("Tidak");
		}

		public void Jajan()
		{
			Console.WriteLine("Pecel");
		}

		public void IPhone()
		{
			Console.WriteLine("IPhone ok bapak beliin");
		}

		public void PulangCepat()
		{
			Console.WriteLine("PulangCepat tidak perlu");
		}

		public void BayarIuran()
		{
			Console.WriteLine("Bayar secukupnya");
		}
	}
}