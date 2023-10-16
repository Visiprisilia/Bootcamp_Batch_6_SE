//Overloading = method sama parameter yg berbeda
class Perhitungan {
	public void Add() {
		Console.WriteLine("Tidak ada");
	}
	public void Add(int a, int b) {
		Console.WriteLine($"Hasil Perkalian a*b adalah {a*b}");
	}
	public void Add(int a, int b, int c) {
		Console.WriteLine($"Hasil Perhitungan a*b+c adalah {a*b+c}");
	}
	public string Add(string a, string b) {
		return a+b;
	}
	public string Add(string a, string b, string c) {
		return a+b;
	}
}