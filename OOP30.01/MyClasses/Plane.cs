//

namespace Tests;



public class Plane : Transport, IFly

{



	public Plane(string name,int numberOfTransport) : base(name, numberOfTransport)

	{



	}



	public override void Move()

	{

	Console.WriteLine("Plane Move");

	}

	public void Vzlet()

	{

	Console.WriteLine($"{NumberOfTransport}Plane Vzlet{Name}");

	}

	public void Posadka()

	{

	Console.WriteLine($"{NumberOfTransport}Plane Posadka{Name}");

	}

}