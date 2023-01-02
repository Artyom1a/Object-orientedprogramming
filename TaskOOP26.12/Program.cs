
using NewCalculator;
using Server;
using Server1;

namespace NewCalculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ServerGetAll result = new ServerGetAll();
            // result.Controller();
            ServerByld result1 = new ServerByld(); 
            result1.Controller(3);
        }
    }
}