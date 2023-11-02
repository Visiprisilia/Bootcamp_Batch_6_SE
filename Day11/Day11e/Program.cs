//Queue
class program
{
	static void Main()
	{
		Queue<int> myQueue = new();
		myQueue.Enqueue(3);
		myQueue.Enqueue(5);
		myQueue.Enqueue(7);
		myQueue.Enqueue(9);

		foreach (var e in myQueue)
		{
			Console.WriteLine(e);
		}
		var enumerator = myQueue.GetEnumerator();
		enumerator.MoveNext();
		Console.WriteLine("tess");
		Console.WriteLine(enumerator.Current);

		Console.WriteLine(myQueue.Dequeue());
		Console.WriteLine(myQueue.Dequeue());
		Console.WriteLine(myQueue.Peek());
		Console.WriteLine(myQueue.Peek());
		Console.WriteLine(myQueue.Dequeue());
		Console.WriteLine(myQueue.Dequeue());
		//myQueue.Pop().Dump(); //Exception, data habis
	}

}

