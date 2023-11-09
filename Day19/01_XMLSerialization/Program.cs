﻿using System.IO;
using System.Xml.Serialization;

public class Pegawai
{
	public string? Name { get; set; }
	public int Id { get; set; }
}

class Program
{
	static void Main()
	{
		Pegawai pegawai = new Pegawai { Name = "Visi", Id = 710921 };
		Type type = typeof(Pegawai);
		XmlSerializer serializer = new XmlSerializer(type);
		using (StreamWriter writer = new StreamWriter("pegawai.xml"))
		{
			serializer.Serialize(writer, pegawai);
		}

		Pegawai deserializedPegawai;
		using (StreamReader reader = new StreamReader("pegawai.xml"))
		{
			deserializedPegawai = (Pegawai)serializer.Deserialize(reader);
		}

		Console.WriteLine($"Deserialized Pegawai: {deserializedPegawai?.Name}, {deserializedPegawai.Id}");
	}
}