//Overloading
class Program {
	static void Main() {
		Perhitungan hitung = new();
		hitung.Add();
		hitung.Add(5,4);
		hitung.Add(1,2,3);
		hitung.Add("1","2");
		Console.WriteLine(hitung.Add("1","2"));
	}
}
class Perhitungan {
	public void Add() {
		Console.WriteLine("Tidak ada");
	}
	public void Add(int a, int b) {
		Console.WriteLine($"Hasil Perkalian {a*b}");
	}
	public void Add(int a, int b, int c) {
		Console.WriteLine($"Hasil Perhitungan {a*b+c}");
	}
	public string Add(string a, string b) {
		return a+b;
	}
}