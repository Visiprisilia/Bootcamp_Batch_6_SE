﻿//Generic Method Collector
class Program 
{
static void Main()
{
	GenericCollection<int> generic = new();
	generic.Add(3, "hello");
	generic.Add(4, "true");
}
class GenericCollection<T>
{
	public T[] myCollection = new T[100];
	public int counter = 0;

	public T2 Add<T2>(T input, T2 input2)
	{
		myCollection[counter] = input;
		counter++;
		return input2;
	}
}}