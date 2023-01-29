
namespace Tests;
public class Ship : Transport, ISwim

{



	public Ship(string name,int numberOfTransport) : base(name, numberOfTransport)

	{



	}



	public override void Move()

	{

	Console.WriteLine("Ship Move");

	}



	public void Otplyv()

	{

	Console.WriteLine($"{NumberOfTransport}Ship Otplyv{Name}");

	}



	public void Priplyv()

	{

	Console.WriteLine($"{NumberOfTransport}Ship Priplyv{Name}");

	}

}
