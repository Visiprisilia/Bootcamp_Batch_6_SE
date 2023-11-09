﻿using System.Text.Json;

public class Pegawai
{
	public string Name { get; set; }
	public int Id { get; set; }
}

class Program
{
	static void Main(string[] args)
	{
		//Serialize
		Pegawai pegawai = new Pegawai { Name = "Visi", Id = 23 };
		
		string jsonString = JsonSerializer.Serialize(pegawai);
		using (StreamWriter writer = new StreamWriter("pegawai.json"))
		{
			writer.Write(jsonString);
		}


		//Deserialize
		string jsonFromFile;
		using (StreamReader reader = new StreamReader("pegawai.json"))
		{
			jsonFromFile = reader.ReadToEnd();
		}
		Pegawai? deserializedPegawai = JsonSerializer.Deserialize<Pegawai>(jsonFromFile);

		Console.WriteLine($"Deserialized Pegawai: {deserializedPegawai.Name}, {deserializedPegawai.Id}");
	}
}