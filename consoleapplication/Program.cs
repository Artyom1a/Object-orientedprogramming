﻿using consoleapplication.MyClasses;

namespace OOPdayli1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            CustomArray arrayObj = new CustomArray(5);
            arrayObj.InicilizationArray();
            arrayObj.Print();
            arrayObj.AddItem(random.Next(-100, 100), random.Next(-5, 5));
            arrayObj.Print();
            Console.WriteLine(arrayObj.AddItem(random.Next(-100, 100))); // => (1 значения в массив values)
            arrayObj.AddItem(new int[2] { 1, 2 });
            Console.WriteLine(arrayObj.AddItem(random.Next(-100, 100), random.Next(-100, 100), random.Next(-100, 100))); // => (3 значения в массив values)
            arrayObj.Print();
            System.Console.WriteLine(arrayObj.Length);
            System.Console.WriteLine(arrayObj.GetItem(random.Next(-5,arrayObj.Length)));
            System.Console.WriteLine(arrayObj);
            System.Console.WriteLine(arrayObj.ToString());
            CustomArray.Information();
            CustomCalculator fjrj = new CustomCalculator();
            // System.Console.WriteLine(fjrj.SumNumbers(random.Next(-100, 100), random.Next(-100, 100)));
            // System.Console.WriteLine(fjrj.SumNumbers(5.0, 7.5));
            // DateRange dateRange = new DateRange(DateTime.Now.AddDays(-5), DateTime.Now.AddDays(5));
            // System.Console.WriteLine(dateRange);
            // DateRange dateRange1 = new DateRange(dateRange); // Если происто dataRange то перепишет значения в оригинале. DataRange(dataRange) оставит старое значение.
            // dateRange1.StartDate = DateTime.Now;
            // System.Console.WriteLine(dateRange);
            // System.Console.WriteLine(dateRange1);
            fjrj.SetE(5);
            System.Console.WriteLine(fjrj.GetE());
            fjrj.B = 10;
            int b = fjrj.B;
            System.Console.WriteLine(b);
            fjrj.R =35;
            int r = fjrj.R;
            System.Console.WriteLine(fjrj.Proverka());
            // дописать метод суммы и метод разность массива
        }
    }
}

// consoleapplication.MyClasses