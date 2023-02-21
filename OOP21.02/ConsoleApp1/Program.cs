using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variant1
            //int[] array = { 1, 2, 3 };
            //int sum = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    sum += array[i];

            //}
            //variant2
            //int sum1 = 0;
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            //for (int i = 0; i < list.Count; i++)
            //{
            //    sum1 += list[i];
            //}
            //Console.WriteLine(sum1);


            ////    //variant3
            //int sum2 = 0;
            //List<int> list1 = new List<int>();
            //Random random = new Random();
            ////list1.Add(random.Next(-100, -10));
            ////list1.Add(random.Next(-100, -10));
            ////list1.Add(random.Next(-100, -10));

            //for (int i = 0; i < list1.Count; i++)
            //{
            //    Console.WriteLine(list1[i]);
            //    sum2 += list1[i];
            //}
            //Console.WriteLine(sum2);

            //Console.WriteLine("Maxvalue");
            //Console.WriteLine(Maxvalue(list1));
            //Console.WriteLine("Minvalue");
            //Console.WriteLine(Minvalue(list1));
            //MaxMinvalue(list1);


            //Напишите программу, которая считывает строку с консоли и определяет, 
            //    является ли она палиндромом (т.е. читается одинаково слева направо и справа налево)

            //    string x = Console.ReadLine();
            //    // "grerg"
            //    //0 1 2 3 4
            //    List<int> list = new List<int>();

            //    for (int i = 0; i < x.Length; i++)
            //    {
            //        list.Add(x[i]);
            //    }
            //    int j = list.Count - 1;
            //    int mudlechar = list.Count/2;
            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        if (list.Count % 2 == 0)
            //        {
            //            if (list[i].Equals(list[j]))
            //            {
            //                j--;
            //                continue;
            //            }
            //            Console.WriteLine("Palindrom");
            //            if (!list[i].Equals(list[j]))
            //            {
            //                Console.WriteLine("Ne palindrom");
            //                break;
            //            }
            //        }
            //        if (list.Count % 2 != 0)
            //        {

            //            if (j != mudlechar)
            //            {
            //                if (list[i].Equals(list[j]))
            //                {
            //                    j--;
            //                    continue;

            //                }
            //                Console.WriteLine("Palindrom");
            //                if (!list[i].Equals(list[j]))
            //                {
            //                    Console.WriteLine("Ne palindrom");
            //                    break;
            //                }
            //            }
            //            else
            //            {

            //            }
            //        }


            //    }

            //}
            //public static int Maxvalue(List<int> list1)
            //{
            //    int max = 0;
            //    for (int i = 0; i < list1.Count; i++)
            //    {
            //        Console.WriteLine(list1[i]);
            //        if (list1[i] > max)
            //        {
            //            max = list1[i];
            //        }
            //    }
            //    return max;
            //}
            //public static int Minvalue(List<int> list1)
            //{
            //    int min = 0;
            //    for (int i = 0; i < list1.Count; i++)
            //    {
            //        Console.WriteLine(list1[i]);
            //        min = list1[i];
            //        if (min > list1[i])
            //        {
            //            min = list1[i];
            //        }
            //    }
            //    return min;

            //}

            //public static void MaxMinvalue(List<int> list1)
            //{
            //    try
            //    {
            //        int max = list1[0];
            //        int min = list1[0];
            //        for (int i = 0; i < list1.Count; i++)
            //        {

            //            if (list1[i] > max)
            //            {
            //                max = list1[i];
            //            }
            //            if (min > list1[i])
            //            {
            //                min = list1[i];
            //            }
            //        }
            //        Console.WriteLine($"max-{max}  min-{min}");
            //    }
            //    catch(Exception e) 
            //    {
            //    Console.WriteLine (e);
            //    }
            //}




            //string x = Console.ReadLine();
            //string y = string.Join("", x.Reverse());
            //Console.WriteLine(x==y);

            
        }
    }
}


//Напишите программу, которая находит сумму всех 
//    элементов массива целых чисел.


//Напишите программу, которая находит наибольший и наименьший элементы массива целых чисел.

//Напишите программу, которая считывает строку с консоли и определяет, 
//    является ли она палиндромом (т.е. читается одинаково слева направо и справа налево)