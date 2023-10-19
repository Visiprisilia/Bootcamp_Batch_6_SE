//EventHandler

class Program

{
	static void main()
	{

	}
	class Publisher
	{
		private string _name;
		public EventHandler<EvenData> eventHandler;
		public Publisher(string name) { _name = name; }
		public void SendNotification()
		{
			eventHandler?.Invoke(this, new EventData()
			{
				name = "Visi",
				age = 23


			});
		}
		public override string ToString()
		{
			return _name;
		}
	}
	class Subscriber
	{
		public void Notification(object sender, EvenData e)
		{
			Console.WriteLine($"Called by {e.name} {e.age}");
		}
	}
	class EvenData : EventArgs
	{
		public string name;
		public int age;
		public void Printer(string message)
		{
			Console.WriteLine(message);
		}


	}
}