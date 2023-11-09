﻿using System.Text.Json;

public class Pegawai
{
	public string Name { get; set; }
	public int Id { get; set; }
}

class Program
{
	static void Main()
	{
		List<Pegawai> people = new List<Pegawai>
		{
			new Pegawai { Name = "Visi", Id = 7102 },
			new Pegawai { Name = "Misi", Id = 7103 }
		};
		string jsonString = JsonSerializer.Serialize(people);
		using (StreamWriter writer = new StreamWriter("pegawai.json"))
		{
			writer.Write(jsonString);
		}

		string jsonFromFile;
		using (StreamReader reader = new StreamReader("pegawai.json"))
		{
			jsonFromFile = reader.ReadToEnd();
		}
		
		List<Pegawai> deserializedPeople = JsonSerializer.Deserialize<List<Pegawai>>(jsonFromFile);
		foreach (var pegawai in deserializedPeople)
		{
			Console.WriteLine($"Deserialized Pegawai: {pegawai.Name}, {pegawai.Id}");
		}
	}
}