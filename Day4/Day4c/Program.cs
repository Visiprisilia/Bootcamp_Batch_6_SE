//Interface
class Program
{
	static void Main()
	{
	Human human = new Human();
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
}

public interface IPermintaanOrtu{
	void Kuliah();
	void Kerja();
	void Nikah();
	bool SudahNikah(int istri);
}
class Human : IPermintaanOrtu
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
	public void MainGame() {
		Console.WriteLine("Game");
	}
}}