
namespace Tests;



public abstract class Transport

{

	public string Name

	{

	get;

	set;

	}



	public int NumberOfTransport

	{

	get;

	set;

	}



	public Transport(string name,int numberOfTransport)

	{

	Name=name;

	NumberOfTransport= numberOfTransport;

	}



	public abstract void Move();

}

