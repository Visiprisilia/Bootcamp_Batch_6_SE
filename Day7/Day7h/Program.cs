//Duplicate Delegate
public delegate void Publish(string x); //tipe data publish

class Program {
	static void Main() {
		Publisher pub = new();
		Subscriber sub = new();
		pub.AddSubscriber(sub.Notify);//passing ke method 
		pub.AddSubscriber(sub.Notify);// duplicate delegate 
		pub.SentNotification();
		
		pub.RemoveSubscriber(sub.Notify);
		pub.SentNotification();
	}
}
class Publisher {
	private event Publish _subscriber;
	public void SentNotification() {
		if(_subscriber != null) 
			_subscriber.Invoke("subssss");
	}
	public bool AddSubscriber(Publish sub) {
		if(_subscriber is null || !_subscriber.GetInvocationList().Contains(sub))
		{
		 	_subscriber += sub;
			return true;
		}
		return false;
	}
	public void RemoveSubscriber(Publish sub) {
		_subscriber -= sub;
	}
}
class Subscriber {
	public void Notify(string message) {
		// message.Dump();
		Console.WriteLine(message);
	}
}