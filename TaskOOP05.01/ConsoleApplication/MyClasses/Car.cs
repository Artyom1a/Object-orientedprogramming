namespace MyClasses.Cars;

public class Car : MyClasses.Transport.Transport
{
    public int Type { get; set; }

    public Car(double spead, string name, int type) : base(spead, name)
    {
        Type = type;
    }
    public Car(string name, int type) : base(name)
    {
        Type = type;
    }


    public void Drift()
    {
        System.Console.WriteLine($"{Name} is breaken");
    }

    // public override string ToString()
    // {
    //     return $"{Name},{Spead}:{Type}";

    // }
}