namespace MyClasses.Cars;

public class Van : Car
{


    public Van(string name) : base(name)
    {
      
    }


    public override void Moving()
    {
        base.Moving();
        System.Console.WriteLine($"Car {Name} is moving");
    }



}