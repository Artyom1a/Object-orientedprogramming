namespace MyClasses.Transport;
public class Transport
{

    public double Spead;
    public virtual string? Name { get; set; }

    public Transport()
    {

    }

    public Transport(double spead, string name) : this(name)
    {
        Spead = spead;
    }
    public Transport(string name)
    {
        Name = name;
    }

    public virtual void Moving()
    {
        System.Console.WriteLine($"Transport {Name} is moving");
    }

    public void Stopping()
    {
        System.Console.WriteLine($"{Name} is stopping");
    }

    public override string ToString()
    {
        return $"{Name},{Spead}";

    }
}