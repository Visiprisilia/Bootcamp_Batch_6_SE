class program 
{
	static void Main()
	{
	Dictionary<int, string> myDict = new(); //int for key, string for value
	myDict.Add(3,"foo");
	myDict.Add(5,"bar");
	//key must be unique
	myDict.Add(7,"bar");
	//value bebas 
	
	foreach(KeyValuePair<int,string> e in myDict)
	{
		Console.WriteLine($"{e.Key}{e.Value}");
	}
	string myValue = myDict[3];
	Console.WriteLine(myValue);
	
	string valueForSearch = "foo";
	int keyResult = 0;
	foreach(var e in myDict)
	{
		if(e.Value == valueForSearch)
		{
			keyResult = e.Key;
			// break;
			
		}
	}
	Console.WriteLine(keyResult);
	// Contains -> KeyValuePair
	// ContainsKey()-> Value key
	// ContainsValue() -> value of value
	KeyValuePair<int,string> keysValue = new KeyValuePair<int, string>(3, "foo");
	bool checkKey = myDict.Contains(keysValue);
	Console.WriteLine(checkKey);
	
	myDict[3] = "buzzz"; //change value
	
	int keyAdd = 3;
	string valueAdd = "visiii";
	myDict.TryAdd(1,"Visi"); //TryAdd
	
	foreach (KeyValuePair<int, string> e in myDict)
	{
		Console.WriteLine($"{e.Key}{e.Value}");
	}	
	}
}