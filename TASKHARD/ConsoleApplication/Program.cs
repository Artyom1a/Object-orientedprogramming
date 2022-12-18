
using System;

namespace TaskHard // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Vvedity number ");
            double.TryParse(Console.ReadLine(), out double number1);
            // System.Console.WriteLine("Vvedity number 2");
            // double.TryParse(Console.ReadLine(), out double number2);
            double result = number1;

            // static double Sum(double number1, double number2)
            // {
            //     return number1 + number2;
            // }
            // string text = "";
            // object num = 5;
            // Random random = new Random();
            Calculate calculate1 = new Calculate(number1);
            while (true)
            {
                string? symbol = Console.ReadLine();
                if (string.IsNullOrEmpty(symbol) || symbol.Equals("="))
                {
                    break;
                }
                System.Console.WriteLine("Vvedity number ");
                double.TryParse(Console.ReadLine(), out number1);
                calculate1.Search(symbol,number1);
            }
            // System.Console.WriteLine(calculate1.Sum(2.3, 2.9));
            // object[] array = new[] { text, num, random, calculate1 };
            // System.Console.WriteLine(calculate1.ToString());
            // string[] resultString = text.Split(",");
            // string[] resultChar = text.Split("w");
            // calculate1.Search("+",number2);
            // calculate1.Search("-",number2);
            // calculate1.Search("/",number2);
            // calculate1.Search("*",number2);
        }
    }
}
