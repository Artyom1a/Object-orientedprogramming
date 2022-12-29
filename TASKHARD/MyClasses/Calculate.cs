
using System;

namespace TaskHard // Note: actual namespace depends on the project name.
{
    public class Calculate
    {
        private double Result;

        public Calculate()
        {

        }
        public Calculate(double number)
        {
            Result = number;
        }
        private void Sum(double number)
        {
            Console.Write($"{Result} + {number} = ");
            Result += number;
            System.Console.WriteLine(Result);

            // Result += number;
            // System.Console.WriteLine($"{Result}+{number}={Result + number}");
            // return Result;
        }
        private void Defination(double number)
        {
            Console.Write($"{Result} - {number} = ");
            Result -= number;
            System.Console.WriteLine(Result);

            // Result -= number;
            // System.Console.WriteLine($"{Result}-{number}={Result - number}");
            // return Result;
        }
        private void Multiplication(double number)
        {
            Console.Write($"{Result} * {number} = ");
            Result *= number;
            System.Console.WriteLine(Result);

            // Result *= number;
            // System.Console.WriteLine($"{Result}*{number}={Result * number}");
            // return Result;
        }
        private void Division(double number)
        {
            Console.Write($"{Result} / {number} = ");
            Result /= number;
            System.Console.WriteLine(Result);

            // Result /= number;
            // System.Console.WriteLine($"{Result}/{number}={Result / number}");
            // return Result;
        }
        public void Search(string symbol, double number)
        {
            // if (symbol == "+")
            // {
            //     return Sum(number);
            // }
            // if (symbol == "-")
            // {
            //     return Defination(number);
            // }
            // if (symbol == "*")
            // {
            //     return Multiplication(number);
            // }
            // if (symbol == "/")
            // {
            //     return Division(number);
            // }
            // return Result;

            switch (symbol)
            {
                case "+":
                    Sum(number);
                    break;
                case "-":
                    Defination(number);
                    break;
                case "*":
                    Multiplication(number);
                    break;
                case "/" when number != 0:
                    Division(number);
                    break;
                default:
                    System.Console.WriteLine("Incoccect operation");
                    break;
            }

            // return symbol switch
            // {
            //     "+" => Sum(number),
            //     "-" => Defination(number),
            //     "*" => Multiplication(number),
            //     "/" when number != 0 => Division(number),
            //     _ => Result

            // };
        }
        // public void Print()
        // {

        // }
    }
}


