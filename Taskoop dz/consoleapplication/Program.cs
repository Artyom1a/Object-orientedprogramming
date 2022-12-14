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
            
        }
    }
}

