//ReadOnly
class Program {
	static void Main(){
		Car car = new Car(1000);
		Console.WriteLine(car.price);

		//car.price = 3; readonly
	}
}
class Car {
	public readonly int price;
	public Car(int price) {
		this.price = price;
	}
	
	//public void SetPrice(int num) {
	//	price = num;
	//}
}