namespace MyClasses.Cars;

public class Car : MyClasses.Transport.Transport
{
    private string _name;
    public override string Name
    {
        get { return !string.IsNullOrEmpty(_name) ? _name : "Our Car"; }
        set { _name = value; }

    }

    public int Type { get; set; }
    public      Car()
    {

    }

    public Car(double spead, string name, int type) : base(spead, name)
    {
        Type = type;
    }
    public Car(string name, int type) : base(name)
    {
        Type = type;
    }

    public Car(string name) : base(name)
    {

    }


    public void Drift()
    {
        System.Console.WriteLine($"{Name} is breaken");
    }

    public override void Moving()
    {
        base.Moving();
        System.Console.WriteLine($"Car {Name} is moving");
    }



}