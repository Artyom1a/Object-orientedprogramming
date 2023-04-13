using System;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            1.
            //Напишите программу, которая создает 10 задач и запускает их параллельно.
            //Каждая задача должна выводить в консоль свой порядковый номер.

            for (int i = 0; i < 10; i++)
            {
                tasks.Add(TaskMethod(i));

            }
            Task.WaitAll(tasks.ToArray());



        }
        static async Task TaskMethod(int number)
        {
            Console.WriteLine($"Method  {number} stating...");
            await Task.Delay(100);
            Console.WriteLine($"Method  {number} finished...");
        }

    }
}