
using AppTransaction.Core;

namespace AppTransaction // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ApplicationTransaction applicationTransaction = new ApplicationTransaction();
            applicationTransaction.SignIn();
        }
    }
}