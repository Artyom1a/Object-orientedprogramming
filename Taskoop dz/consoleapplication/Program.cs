//1. Реализуйте класс Singer, который будет иметь следующие свойства: name,
// surname. Также класс должен иметь метод GetАutograph (), который будет
// выводить "{Name} {Surname}, с наилучшими пожеланиями”.
// 2. Реализуйте класс WordString+, который будет иметь следующие методы: +метод
// ReverseString (), переворачивающий строку, метод UpperFirst (), возвращающий
// строку, где первая буква заглавная и метод UpperEvery (), который делает
// заглавной первую букву каждого слова этой строки.
// 3.У вас есть класс MathСalculation. Создать в нем функцию для подсчета всех
// положительных чисел. Проверки.
//4. У вас есть класс Fibonacci. Создать в нем функцию для вывода ряда фибоначчи.
// Необходимо добавить проверки
//5.Реализуйте класс Validator. У него будет метод IsEmail параметром принимает
// строку и проверяет, является ли она корректным емейлом или нет. Если является
// - возвращает true, если не является - то false.
//6.Дополнить 5 задание. Добавить метод IsURL для проверки на url.
//7. Дополнить 5 задание. Добавить метод IsDate для проверки на дату.
//8. Дополнить 5 задание. Добавить метод IsPhone для проверки на номер телефона



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
            Vlidator itog3 = new Vlidator();
            System.Console.WriteLine(itog3.IsEmail());
            System.Console.WriteLine(itog3.IsUrl());
        }
    }
}

