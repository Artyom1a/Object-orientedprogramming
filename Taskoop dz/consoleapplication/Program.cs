//1. Реализуйте класс Singer, который будет иметь следующие свойства: name,
// surname. Также класс должен иметь метод GetАutograph (), который будет
// выводить "{Name} {Surname}, с наилучшими пожеланиями”.
// 2. Реализуйте класс WordString+, который будет иметь следующие методы: +метод
// ReverseString (), переворачивающий строку, метод UpperFirst (), возвращающий
// строку, где первая буква заглавная и метод UpperEvery (), который делает
// заглавной первую букву каждого слова этой строки.
// 3.У вас есть класс MathСalculation. Создать в нем функцию для подсчета всех
// положительных чисел. Проверки.


using consoleapplication.MyClasses;

namespace consoleapplication // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singer result = new Singer();
            result.GetАutograph();
            WordString itog = new WordString();
            System.Console.WriteLine(itog.ReverseString());
            System.Console.WriteLine(itog.UpperFirst());
            System.Console.WriteLine(itog.UpperEvery());
            MathСalculation itog1 = new MathСalculation();
            System.Console.WriteLine(MathСalculation.Get(5, 5, -18, 12));
            Fibonacci itog2 = new Fibonacci();
            System.Console.WriteLine(Fibonacci.ResultFibonacci(3, 5));
        }
    }
}

