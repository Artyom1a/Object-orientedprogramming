using consoleapplication.MyClasses;

namespace OOPdayli1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            CustomArray arrayObj = new CustomArray(5);
            arrayObj.InicilizationArray();
            arrayObj.Print();
            arrayObj.AddItem(random.Next(-100, 100), random.Next(-5, 5));
            arrayObj.Print();
            Console.WriteLine(arrayObj.AddItem(random.Next(-100, 100))); // => (1 значения в массив values)
            arrayObj.AddItem(new int[2] { 1, 2 });
            Console.WriteLine(arrayObj.AddItem(random.Next(-100, 100), random.Next(-100, 100), random.Next(-100, 100))); // => (3 значения в массив values)
            arrayObj.Print();
            System.Console.WriteLine(arrayObj.Length);
            System.Console.WriteLine(arrayObj.GetItem(random.Next(-5,arrayObj.Length)));
            System.Console.WriteLine(arrayObj);
            System.Console.WriteLine(arrayObj.ToString());
            CustomArray.Information();
            // дописать метод суммы и метод разность массива
        }
    }
}

// consoleapplication.MyClasses