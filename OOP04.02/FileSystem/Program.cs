//
using System.Text;
using TestLibrary;

namespace FileSystems;

internal class Program
{
    private static void Main(string[] args)
    {
        //StreamWriter sw1 = null;
        //try
        //{
        //    sw1 = new StreamWriter("C:\\Code Main\\FileSystem1.txt",true);
        //    sw1.Write("人人 都 爱 喝可乐");
        //    sw1.WriteLine("From class");

        //    using StreamWriter sw2 = new StreamWriter("C:\\Code Main\\FileSystem2.txt",false);
        //    sw2.Write("Люба раздавай экран))))");
        //    sw2.WriteLine("From class");
        //    sw2.Close();
        //}
        //catch (Exception e) 
        //{
        //Console.WriteLine("Exception: " + e.Message);
        //}
        //finally
        //{
        //    sw1?.Close();
        //    Console.WriteLine("Executing finally block.");
        //}



        //StreamReader sr1 = null;

        //try
        //{
        //    StringBuilder stringBuilder = new StringBuilder();
        //    sr1 = new StreamReader("C:\\Code Main\\FileSystem1.txt");
        //    string line = sr1.ReadLine();

        //    while (line != null)
        //    {
        //        stringBuilder.Append(line);
        //        line = sr1.ReadLine();
        //    }
        //    sr1.Close();
        //    Console.WriteLine(stringBuilder.ToString());

        //    using StreamReader sr2 = new StreamReader("C:\\Code Main\\FileSystem2.txt");
        //    string result = sr2.ReadToEnd();
        //    Console.WriteLine(result);
        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine("Exception" + e.Message);
        //}
        //finally
        //{
        //    sr1?.Close();
        //    Console.WriteLine("Executing finally block.");
        //}


        //string filepath = @"C:\Code Main\FileSystem3.txt\";
        //try
        //{
        //    string json = " .........";
        //    Console.WriteLine(Path.GetDirectoryName(filepath));
        //    if (!Directory.Exists(Path.GetDirectoryName(filepath)))
        //    {
        //        Console.WriteLine("need create directory");
        //        Directory.CreateDirectory(Path.GetDirectoryName(filepath));
        //    }
        //    File.WriteAllText(filepath, json);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex);
        //}
        //if (File.Exists(filepath))
        //{
        //    try
        //    {
        //        var json = File.ReadAllText(filepath);
        //        Console.WriteLine(json);
        //    }
        //    catch (Exception ex) 
        //    {
        //    File.Delete(filepath);
        //        Console.WriteLine(ex);
        //    }
        //}

        User user = new User();
        user.Name = "Test";
        user.Id= 10;
        Console.WriteLine(user);


    }
}