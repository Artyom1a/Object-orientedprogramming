using System;
using System.Threading;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            1.
            //Напишите программу, которая создает 10 задач и запускает их параллельно.
            //Каждая задача должна выводить в консоль свой порядковый номер.

            List<Task> tasks = new List<Task>();


            for (int i = 0; i < 10; i++)
            {
                tasks.Add(TaskMethod(i));

            }
            Task.WaitAll(tasks.ToArray());
            //            Напишите программу, которая создает 5 потоков и запускает их параллельно.
            //Каждый поток должен выводить в консоль свой порядковый номер

            List<Task> tasks1 = new List<Task>();
            tasks1.Add(TaskMethod(1));
            tasks1.Add(TaskMethod(2));
            tasks1.Add(TaskMethod(3));
            tasks1.Add(TaskMethod(4));
            tasks1.Add(TaskMethod(5));

            //            3.
            //Напишите программу, которая создает задачу, которая выполняет длительную
            //операцию, и запускает ее в фоновом режиме. Пока задача выполняется,
            //программа должна выводить точки на экран.



        }
        static async Task TaskMethod(int number)
        {
            Console.WriteLine($"Method  {number} stating...");
            await Task.Delay(100);
            Console.WriteLine($"Method  {number} finished...");
        }



    }
}