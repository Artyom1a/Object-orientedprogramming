
//class TransportSystemCity

namespace Tests;



public class TransportSystemCity : IFly, IDrive, ISwim

{

	public Plane[] Planes;



    public Bus[] Buses;



	public Ship[] Ships;



    public TransportSystemCity()

    {

    Planes = new Plane(11)

    {

   	new Plane("Boing1", 1),

   	new Plane("Boing2", 2),

   	new Plane("Boing3", 3),

   	new Plane("Boing4", 4),

    };

	}

	public TransportSystemCity()

    {

    Buses = new Bus(11)

    {

   	new Bus("Renault1", 1),

   	new Bus("Renault2", 2),

   	new Bus("Renault2", 2),

   	new Bus("Renault3", 3),

   	new Bus("Renault4", 4),

    };

	}



	public TransportSystemCity()

    {

    Buses = new Bus(11)

    {

   	new Ship("Board1", 1),

   	new Ship("Board2", 2),

   	new Ship("Board3", 3),

   	new Ship("Board4", 4),

    };

	}



    public void SetInAirport(Plane plane)

    {

    int sum=0;

    for(int i =0; i<Planes.Length; i++)

    {

    sum+=Planes[i].NumberOfTransport;

    }

    if (sum>11 && sum<0)

    {

    Console.WrtiLine("Exception  no place");

    }

    else

    {
    
	void Posadka()

	{

	Console.WriteLine($"{NumberOfTransport}Plane Posadka{Name}");

    }

    }



	public void SetInBusStation(Bus bus)

	{

    int sum=0;

    for(int i =0; i<Buses.Length; i++)

    {

 

    sum+=Buses[i].NumberOfTransport;



    }

    if (sum>11 && sum<0)

    {

    Console.WrtiLine("Exception  no place");

    }

    else

    {



	public void Priezd()

	{

	Console.WriteLine($"{NumberOfTransport}Bus Priezd{Name}")

	}

    }







	public void SetInPort(Ship ship)

    {

    int sum=0;

    for(int i =0; i<Ships.Length; i++)

    {

 

    sum+=Ships[i].NumberOfTransport;



    }

    if (sum>11 && sum<0)

    {

    Console.WrtiLine("Exception no place");

    }

    else

    {



	public void Priplyv()

	{

	Console.WriteLine($"{NumberOfTransport}Ship Priplyv{Name}")

	}

    }











	public void GetFromAirport(int numberOfTransport)

    {



    for(int i =0; i<Planes.Length; i++)

    {

 

    if(Planes[i].PlaneNumberOfTransport==numberOfTransport)

    {

    Console.WriteLine(Planes[i])

    Planes[i].PlaneNumberOfTransport=0;

    Planes[i].PlaneName=null;

	

	public void Vzlet()

	{

	Console.WriteLine($"{NumberOfTransport}Plane Vzlet{Name}")

	}

    }



    else

    {



	Console.WriteLine("Exceptions no element")

 

    }











	public void GetFromBusStation(int numberOfTransport)

    {



    for(int i =0; i<Buses.Length; i++)

    {

 

    if(Buses[i].BusNumberOfTransport==numberOfTransport)

    {

    Console.WriteLine(Buses[i])

    Buses[i].NumberOfTransport=0;

    Buses[i].Name=null;

	

	public void Otezd()

	{

	Console.WriteLine($"{NumberOfTransport}Bus Otezd{Name}")

	}

    }



    else

    {



	Console.WriteLine("Exceptions no element")

 

    }







	public void GetFromPort(int numberOfTransport)

    {



    for(int i =0; i<Ships.Length; i++)

    {

 

    if(Ships[i].ShipNumberOfTransport==numberOfTransport)

    {

    Console.WriteLine(Ships[i])

    Ships[i].NumberOfTransport=0;

    Ships[i].Name=null;

	

	public void Otplyv()

	{

	Console.WriteLine($"{NumberOfTransport}Ship Otplyv{Name}");

	}

    }



    else

    {



	Console.WriteLine("Exceptions no element");

 

    }



    }



}







//string name,int numberOfTransport