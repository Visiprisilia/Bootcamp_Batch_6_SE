//Overloading = method sama parameter yg berbeda
class Program {
	static void Main() {
		Perhitungan hitung = new();
		hitung.Add();
		hitung.Add(5,4);
		hitung.Add(1,2,3);
		hitung.Add("1","2");
		Console.WriteLine(hitung.Add("1","2"));
		Console.WriteLine(hitung.Add("1","2","3"));
	}
}
