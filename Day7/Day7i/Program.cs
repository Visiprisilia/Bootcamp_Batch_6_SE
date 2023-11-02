//EventHandler

class Program
{
	static void Main()
	{
		Tiktok pub = new Tiktok("Visiiiii");
		Follower sub = new Follower();
		pub.eventHandler = sub.Notification;
		pub.SendNotification();
	}
	class Tiktok
	{
		private string _name;
		public EventHandler eventHandler;
		public Tiktok(string name) { _name = name; }
		public void SendNotification()
		{
			eventHandler?.Invoke(this, EventArgs.Empty);
		}
		public override string ToString()
		{
			return _name;
		}
	}
	class Publisher
	{
		private string _name;
		public EventHandler eventHandler;
		public Publisher(string name) { _name = name; }
		public void SendNotification()
		{
			eventHandler?.Invoke(this, EventArgs.Empty);
		}
		public override string ToString()//tidak wajib override
		{
			return _name;
		}
	}
	class Follower
	{
		public void Notification(object sender, EventArgs e)
		{
			Console.WriteLine($"Called by {sender}");
		}
	}
}