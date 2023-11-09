using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml.Serialization;
[DataContract]
class Player
{
	[DataMember]
	public string username;
	[DataMember]
	public int pass;
}
[DataContract]
class Card 
{
	[DataMember]
	public int id;
}
class Program 
{
	static void Main() 
	{
		Player player = new Player() { username = "Visi",pass =  213};
		Player player2 = new Player() { username = "Misi",pass =  231};
		Player player3 = new Player() { username = "Sali",pass =  123};
		Card c = new Card() { id = 5 };

		Dictionary<Player, Card> playerCard = new();
		playerCard.Add(player, c);
		playerCard.Add(player2, c);
		playerCard.Add(player3, c);

		DataContractJsonSerializer serialize = new(typeof(Dictionary<Player, Card>));
		using (FileStream sw = new FileStream("MyFileXML.json",FileMode.Create))
		{
			using(var writer = JsonReaderWriterFactory.CreateJsonWriter(sw,Encoding.UTF8,true,true," ")) 
			{
				serialize.WriteObject(writer, playerCard);
			}
		}
	}
}