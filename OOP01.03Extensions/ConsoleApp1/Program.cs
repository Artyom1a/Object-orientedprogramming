using System;
using ConsoleApp1;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "3f4435kjdbl56g65grdvlkb6hbry";
            string newText = text.DecoratorSymbolAfterDigit('$');
            Console.WriteLine(newText);
        }
    }
}





