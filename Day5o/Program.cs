﻿//Generic Collector
class Program 
{
static void Main()
{
{
	GenericCollection<int> collection = new();
	collection.Add(3);
	collection.Add(4);
	collection.Add(5);
	int result = collection.Get(1);
	// result.Dump();
	Console.WriteLine(result);

	GenericCollection<bool> collectionOfBool = new();
	collectionOfBool.Add(true);
	collectionOfBool.Add(false);
	bool resultOfBool = collectionOfBool.myCollection[0];
	// resultOfBool.Dump();
	Console.WriteLine(resultOfBool);
}}
class GenericCollection<T>
{
	public T[] myCollection = new T[100];
	public int counter = 0;

	public bool Add(T input)
	{
		myCollection[counter] = input;
		counter++;
		return true;
	}
	public T Get(int x) {
		return myCollection[x];
	}
}}