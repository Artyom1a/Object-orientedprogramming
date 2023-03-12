using ConsoleApp1;
using System;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part1
            // 1. Напишите программу, которая вычисляет сумму двух чисел, введенных
            //пользователем.
            //Console.WriteLine("Task1");
            //string a = Console.ReadLine();
            //string f = Console.ReadLine();
            //bool b = int.TryParse(a, out int c);
            //bool d = int.TryParse(f, out int e);
            //if(b && d && c != null && e != null )
            //{
            //    Console.WriteLine(c+e);
            //}

            //2.Напишите программу, которая определяет, является ли введенное число четным
            //или нечетным.

            //Console.WriteLine("Task2");
            //Task1_3Part1 task1_3Part1 = new Task1_3Part1();
            //string a = Console.ReadLine();
            //bool b = int.TryParse(a, out int c);
            //if (b  && c != null )
            //{
            //    task1_3Part1.Task2(c);
            //}

            //3. Напишите программу, которая находит среднее арифметическое двух чисел,
            //введенных пользователем.
            //Console.WriteLine("Task3");
            //Task1_3Part1 task1_3Part1 = new Task1_3Part1();
            //string a = Console.ReadLine();
            //string f = Console.ReadLine();
            //bool b = int.TryParse(a, out int c);
            //bool d = int.TryParse(f, out int e);
            //if (b && d && c != null && e != null)
            //{
            //task1_3Part1.Task3(c, e);
            //}
            //4. ПЕРЕПУТАЛ они в другой очередности Напишите программу, которая проверяет, является ли введенная строка
            //палиндромом(слово или фраза, которые читаются одинаково слева направо и
            //справа налево).
            //Console.WriteLine("Task4"); 

            //Task4_6Part1 task4_6Part1 = new Task4_6Part1();
            //string a = Console.ReadLine();
            //if (string.IsNullOrEmpty(a))
            //{
            //    task4_6Part1.Task4(a);
            //}
            //5. ПЕРЕПУТАЛ они в другой очередности Напишите программу, которая запрашивает у пользователя длину и ширину
            //прямоугольника, а затем выводит его площадь.
            //Console.WriteLine("Task5");

            //Task4_6Part1 task4_6Part1 = new Task4_6Part1();
            //string a = Console.ReadLine();
            //string f = Console.ReadLine();
            //bool b = int.TryParse(a, out int c);
            //bool d = int.TryParse(f, out int e);

            //if (b && d && c != null && e != null)
            //{
            //    Console.WriteLine(task4_6Part1.Task5(c,e));
            //}

            //6. Напишите программу, которая запрашивает у пользователя три числа и выводит
            //на экран наименьшее из них.
            //Console.WriteLine("Task6");

            //Task4_6Part1 task4_6Part1 = new Task4_6Part1();
            //string a = Console.ReadLine();
            //string f = Console.ReadLine();
            //string g = Console.ReadLine();
            //bool b = int.TryParse(a, out int c);
            //bool d = int.TryParse(f, out int e);
            //bool i = int.TryParse(g, out int k);

            //if (b && d && c != null && e != null)
            //{
            //    Console.WriteLine(task4_6Part1.Task6(c, e,k));
            //}
            //7. Напишите программу, которая запрашивает у пользователя строку и выводит на
            //экран количество гласных букв в этой строке.

            //Console.WriteLine("Task7");

            //Task7_9Part1 task7_9Part1 = new Task7_9Part1();
            //string a = Console.ReadLine();


            //if (a != null )
            //{
            //    Console.WriteLine(task7_9Part1.Task7(a));
            //}


            //8. Напишите программу, которая запрашивает у пользователя год рождения и
            //выводит его возраст на текущую дату.
            //Console.WriteLine("Task8");

            //Task7_9Part1 task7_9Part1 = new Task7_9Part1();

            //string a = Console.ReadLine();
            //bool b = int.TryParse(a, out int c);

            //if (b && c != null)
            //{
            //    task7_9Part1.Task8(c);
            //}

            //9. Напишите программу, которая запрашивает у пользователя два числа и находит
            //их наибольший общий делитель
            //Console.WriteLine("Task9");
            //Task7_9Part1 task7_9Part1 = new Task7_9Part1();

            //string a = Console.ReadLine();
            //bool b = int.TryParse(a, out int c);
            //string f = Console.ReadLine();
            //bool d = int.TryParse(f, out int e);

            //if  (b && d && c != null && e != null)
            //{
            //    task7_9Part1.Task9(c,e);
            //}

            //10. Напишите программу, которая генерирует случайное число от 1 до 100 и
            // предлагает пользователю угадать это число, давая подсказки(больше/ меньше),
            //если введенное число не совпадает с загаданным
            Console.WriteLine("Task10");
            Task10_12Part1 task10_12Part1 = new Task10_12Part1();
            
            task10_12Part1.Task10();
            

        }
    }
}
