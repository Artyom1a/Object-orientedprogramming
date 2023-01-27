using Task;
using Excepts;
namespace ProgramSpace;

internal class Program
{
    static void Main(string[] args)
    {
        Except test = new Except(4, 2);
        System.Console.WriteLine(test.Raschet());


        // Obobschenyu<int, string, int> test1 = new Obobschenyu<int, string, int>(2, "555", 5);
        // System.Console.WriteLine(test1.Converter());
        // Console.ReadKey();
        // List<int> array = new List<int>(20);
        // System.Console.WriteLine($"Capacity={array.Capacity} countItem={array.Count}");
        // array.Add(1);
        // System.Console.WriteLine($"Capacity={array.Capacity} countItem={array.Count}");
        // array.Add(1);
        // array.Add(1);
        // array.Add(77);
        // array.Add(1);
        // array.Add(1);
        // System.Console.WriteLine($"Capacity={array.Capacity} countItem={array.Count}");
        // array.Add(1);
        // array.Add(1);
        // array.Add(8);
        // array.Add(1);
        // array.Add(1);
        // array.Add(5);
        // array.Add(1);
        // array.Add(23);
        // array.Add(1);
        // array.Add(45);
        // array.Add(1);
        // array.Add(13);
        // array.Add(4);
        // array.Add(1);
        // array.Add(1);
        // System.Console.WriteLine($"Capacity={array.Capacity} countItem={array.Count}");
        // Console.WriteLine(array.FirstOrDefault(x => x > 1));
        // Console.WriteLine(array.FindIndex(x => x ==5));
        // for(int i=0;i<array.Count;i++)
        // {
        //     if (array[i]==5)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }
        // Console.WriteLine(string.Join(";",array));
        // array.Sort();
        // Console.WriteLine(string.Join(";", array));
    }
}

