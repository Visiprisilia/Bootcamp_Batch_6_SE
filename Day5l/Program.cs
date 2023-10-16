//List Collection / Generic with Abstraction

class Program 
{
static void Main()
{
{
	List<ITransport> myList = new List<ITransport>();
	myList.Add(new Car());
	myList.Add(new Truck());
	myList.Add(new Plane());
	//myList.Add(new Sayur()); Error
}
public interface ITransport { }
class Car : ITransport{ }
class Truck : ITransport { }
class Plane : ITransport { }
class Sayur { }
}}