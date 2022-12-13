// Реализуйте класс Singer, который будет иметь следующие свойства: name,
// surname. Также класс должен иметь метод GetАutograph (), который будет
// выводить "{Name} {Surname}, с наилучшими пожеланиями”.

using consoleapplication.MyClasses;

namespace OOPdz // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singer result = new Singer("Artyom","Shevchik");

            result.GetАutograph("Artyom","Shevchik");

        }
    }
}

