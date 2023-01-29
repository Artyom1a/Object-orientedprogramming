namespace Tests;



public class Bus : Transport, IDrive

{



	public Bus(string name,int numberOfTransport) : base(name, numberOfTransport)

	{



	}



	public override void Move()

	{

	Console.WriteLine("Bus Move");

	}



	public void Otezd()

	{

	Console.WriteLine($"{NumberOfTransport}Bus Otezd{Name}");

	}



	public void Priezd()

	{

	Console.WriteLine($"{NumberOfTransport}Bus Priezd{Name}");

	}

}
