//Array
// class Program 
// {
// static void Main()
// {
// 	int[] myArray = {1,2,4};
// 	char[] myChar = new char[4];
// 	string[] myStrings = new string[] {"1","2","3"};

// 	int result = myArray[2]; 
// 	myArray[2] = 6;

// 	int length = myArray.Length;
// }
// }



// Reference Type, why dont need Ref

class Program
{
	static void Main()
	{
		Car car = new Car(2000); //Reference Type
		MultiplyByTwoCar(car);
		Console.WriteLine(car); // 4000
	}

	void MultiplyByTwoCar(Car input)
	{
		input.price = input.price * 2;
	}

	class Car
	{
		public int price;
		public Car(int value)
		{
			price = value;
		}
	}
}


// //String
// class Program
// {
// 	 void Main()
// 	{
// 		string myString = "Hello";
// 		StringAppender(ref myString);
// 		Console.WriteLine(myString);
// 	}

// 	 void StringAppender(ref string input)
// 	{
// 		input = input + "!!!!";
// 	}
// }



// //Ref, Out, In
// class Program
// {
// 	static void Main()
// 	{
// 	//Ref
// 	int myInt = 2;
// 	MultiplyByTwoRef(ref myInt);
// 	Console.WriteLine(myInt);

// 	//Out
// 	MultiplyByTwoOut(out int myIntOut);
// 	Console.WriteLine(myIntOut);
// 	//In
// 	int myIntIn = 4;
// 	MultiplyByTwoIn(in myIntIn);
// }

// //Ref = pass reference, harus diassign sebelum method
// void  MultiplyByTwoRef(ref int input) {
// 	input = 4;
// 	input *= 2;
// }

// //Out = pass reference, harus diassign didalam method sebelum methodnya exit
// void MultiplyByTwoOut(out int input)
// {
// 	input = 4; //proses assign
// 	input = input * 2;
// }

// //In = pass reference, harus diassign, tapi readonly
// void MultiplyByTwoIn(in int input)
// {
// 	//input = 4 tidak bisa karena ini readonly
// 	int result = input * 4;
// }
// }






// //Object -> Generic
// class Program
// {
// 	static void Main()
// {
// 	MyCollection<string> myStringCollection = new();
// 	myStringCollection.SetValue(0, "hello");
// 	myStringCollection.SetValue(1, "world");

// 	// myStringCollection.GetValue(0).Dump();
// 	Console.WriteLine(myStringCollection.GetValue(0));
// }

// class MyCollection<T>
// {
// 	private T[] collection = new T[100];
// 	public T GetValue(int index) {
// 		if(index < collection.Length-1) {
// 			return collection[index];
// 		}
// 		throw new IndexOutOfRangeException("Not found data");
// 	}
// 	public bool SetValue(int index, T data) {
// 		collection[index] = data;
// 		return true;
// 	}
// }
// }







// //Parsing with TryParse
// class Program 
// {
// static void Main()
// {
// 	string myString = "351";
// 	bool statusParsing = int.TryParse(myString, out int result);
// 	// result.Dump();
// 	Console.WriteLine(result);
// 	Console.WriteLine(statusParsing);
// }}