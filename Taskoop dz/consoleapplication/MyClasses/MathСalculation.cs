//1. Реализуйте класс Singer, который будет иметь следующие свойства: name,
// surname. Также класс должен иметь метод GetАutograph (), который будет
// выводить "{Name} {Surname}, с наилучшими пожеланиями”.
// 2. Реализуйте класс WordString+, который будет иметь следующие методы: +метод
// ReverseString (), переворачивающий строку, метод UpperFirst (), возвращающий
// строку, где первая буква заглавная и метод UpperEvery (), который делает
// заглавной первую букву каждого слова этой строки.
// 3.У вас есть класс MathСalculation. Создать в нем функцию для подсчета всех
// положительных чисел. Проверки.


namespace consoleapplication.MyClasses
{
    public class MathСalculation
    {
        int perem;
        public MathСalculation()
        {
            System.Console.WriteLine("Class MathCalculation");
        }
        public static int Get(params int[] perem)
        {
            int x = 0;
            for (int i = 0; i < perem.Length; i++)
            {
                if (perem[i] > 0)
                {
                    x += perem[i];
                }
            }
            return x;
        }
    }
}