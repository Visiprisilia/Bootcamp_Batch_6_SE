﻿//EventHandler<EventData>
class Program
{
	static void Main()
	{
		Publisher pub = new Publisher("Visiii");
		Subscriber sub = new Subscriber();
		pub.eventHandler += sub.Notification;
		pub.SendNotification();
	}
	class Publisher
	{
		private string _name;
		public EventHandler<EventData> eventHandler;
		public Publisher(string name) { _name = name; }
		public void SendNotification()
		{
			eventHandler?.Invoke(this, new EventData()
			{
				name = "Visiii",
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
		public void Notification(object sender, EventData e)
		{
			// $"Called by {e.name} {e.price}".Dump();
			Console.WriteLine($"Called by {e.name} {e.age}");
		}
	}
	class EventData : EventArgs
	{
		public string name;
		public int age;
		public void Printer(string message)
		{
			Console.WriteLine(message);
		}
	}
}