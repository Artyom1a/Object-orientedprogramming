
using NewCalculator;
using Server;
using Server1;
using Server2;
using Server3;
using Server4;
using NewConversion;

namespace NewCalculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ServerGetAll result = new ServerGetAll();
            // // result.Controller();
            // // ServerByld result1 = new ServerByld(); 
            // // result1.Controller(3);
            // // ServerPost result2 = new ServerPost();
            // // result2.Controller(4, "Svetlana", 20);
            // // ServerPut result3 = new ServerPut();
            // // result3.Controller(4, "Dmitry", 25);
            // ServerDelete result4 = new ServerDelete();
            // result4.Controller(8);
            Conversion result5 = new Conversion();
            System.Console.WriteLine(result5.ToBinaryNumber(5));
            System.Console.WriteLine(result5.ToHexadecimalNumber(19));

        }
    }
}