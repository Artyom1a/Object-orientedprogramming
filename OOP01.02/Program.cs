using ConsoleApp2.Classes;
namespace ConsoleApp1.Classes;

class Program
{
    static void Main(string[] args)
    {
        //Trapezoid<long> trapezoid = new Trapezoid<long>(7,4,1);
        //Console.WriteLine(trapezoid.Area());

        //TheCordinatePlane<double> theCordinatePlane = new TheCordinatePlane<double>(1,2,3,4);
        //theCordinatePlane.Print("Hello");

        //DoubleTypes<int, object> doubleTypes = new DoubleTypes<int, object>(5, "eg32r");
        //doubleTypes.Print();

        //for class Person
        //var tom = new Person("Tom", 23);
        //var bob = tom;
        //bob.Name = "Bob";
        //Console.WriteLine(tom.Name); // Bob

        var tom = new Person1("Tom", 23);
        var bob = (Person1)tom.Clone();
        bob.Name = "Bob";
        Console.WriteLine(tom.Name); // Tom
    }
}
