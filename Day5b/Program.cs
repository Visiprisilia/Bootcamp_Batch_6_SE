﻿//String is Reference, but?
class Program

{
static void Main()
{
	string a = "3";
	string b = a;
	b = "5";
	
	Console.WriteLine(a);
	Console.WriteLine(b);
	
	string myString = "hello";
	myString = "World";
	myString += "!";
	//myString = myString + "!";
	
}

}