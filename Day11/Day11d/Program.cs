//Stack
class program
{
	static void Main()
	{
	Stack<int> myStack = new();
	myStack.Push(3);
	myStack.Push(5);
	myStack.Push(7);
	myStack.Push(9);
	
	//foreach(var e in myStack) {
	//	e.Dump();
	//}
	//var enumerator = myStack.GetEnumerator();
	//enumerator.MoveNext();
	//"test".Dump();
	//enumerator.Current.Dump();
	
	Console.WriteLine(myStack.Pop());
	Console.WriteLine(myStack.Pop());
	Console.WriteLine(myStack.Peek());
	Console.WriteLine(myStack.Peek());
	Console.WriteLine(myStack.Pop());
	Console.WriteLine(myStack.Pop());
	//myStack.Pop().Dump(); //Exception, data habis
	}
}