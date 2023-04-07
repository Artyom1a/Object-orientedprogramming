


using System;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            //Найти все числа в массиве, которые больше 5 ( linq

            //List<int> array = new List<int>{ 7, 3, 3, 4, 5, 11, 1, 8, };
            //Console.WriteLine(String.Join(',',array.Where(x => x > 5)));

            //2.Найти все строки в массиве, содержащие слово "apple“ (linq)

            //string[] array2 = { "xvb", "fdfappleasf", "asapple", "fsdf" };
            //var result = array2.Where(x => x.ToLower().Contains("apple"));

            //Console.WriteLine(string.Join(",", result));
            //            3.Найти количество элементов в массиве, которые равны нулю. (linq)
            //List<int> array = new List<int> { 7, 3, 3, 4, 5, 11, 1, 8,0, 0 };
            //int x = 0;
            //for(int i =0; i< array.Count;i++)
            //{
            //    if (array[i]==0)
            //    {
            //        x++;
            //    }
            //}
            //Console.WriteLine(x);

            //+++++++++++
            //List<int> array = new List<int> { 7, 3, 3, 4, 5, 11, 1, 8, 0, 0 };
            //Console.WriteLine(array.Count(x=>x==0));
            //  4.Найти первый элемент массива, который больше 10. (linq)

            //List<int> array = new List<int> { 7, 3, 3, 4, 5, 11, 1, 8, 0, 0 };
            //for (int i = 0; i < array.Count; i++)
            //{
            //    if (array[i] > 10)
            //    {
            //        Console.WriteLine(array[i]);
            //        break;
            //    }
            //}

            //List<int> array = new List<int> { 7, 3, 3, 4, 5, 11, 1, 8, 0, 0 };
            //Console.WriteLine(array.Where(x => x > 10).ElementAt(0));


            //5 Найти среднее значение всех элементов в массиве. (linq)

            //List<int> array = new List<int> { 7, 3, 3, 4, 5, 11, 1, 8, 0, 0 };

            //Console.WriteLine(array.Average());
            //Console.WriteLine(moneys.Average(m=>m.Size)); - среднее значение для поля объекта

            //    6.
            //Найти все четные числа в массиве и отсортировать их по возрастанию linq
            //List<int> array = new List<int> { 7, 3, 3, 4, 5, 11, 1, 8, 0, 0 };
            //var result = array.Where(x=>x%2==0).OrderBy(x=>x).ToList();
            //int i = 0;
            //while(i<result.Count)
            //{
            //    Console.WriteLine(result[i++].ToString());
            //}

            //            7.Найти все уникальные элементы в массиве. (linq)
            //List<int> array = new List<int> { 7, 3, 3, 4, 5, 11, 1, 8, 0, 0 };

            //Console.WriteLine(string.Join(",", array.GroupBy(x=>x).Where(x=>x.Count()==1).Select(x=>x.Key)));


            //8.Найти все элементы в массиве, которые встречаются более одного раза. (linq)
            //List<int> array = new List<int> { 7, 3, 3, 4, 5, 11, 1, 8, 0, 0 };

            //Console.WriteLine(string.Join(",", array.GroupBy(x=>x).Where(x=>x.Count()>1).SelectMany(x=>x)));


            //            9.Найти наибольшее и наименьшее значение в массиве. (linq)

            //List<int> array = new List<int> { 7, 3, 3, 4, 5, 11, 1, 8, 0, 0 };
            //int i = array.Min(x=>x);
            //Console.WriteLine(i);
            //i = array.Max(x => x);
            //Console.WriteLine(i);
            ////10.Найти сумму всех элементов в массиве. (linq)

            //i = array.Sum(x => x);
            //Console.WriteLine(i);

            //11.Объединить два массива и удалить все дубликаты. (linq)

            //List<int> array = new List<int> { 7, 3, 3, 4, 5, 11, 1, 8, 0, 0 };
            //List<int> array1 = new List<int> { 7, 3, 3, 4, 5, 11, 1, 8, 0, 33 };

            //Console.WriteLine(string.Join(",", array.Union(array1)));


            string text = "//11.Объeeeeeeeeeдинить два массива и удалить все дубликаты. (linq)";
            var textCharArrays= text.ToLower().ToCharArray();
            var groupsCharArrays = textCharArrays.GroupBy(x => x);
            var orderGroupChars = groupsCharArrays.OrderByDescending(x => x.Count());
            var firstGroupChar = orderGroupChars.FirstOrDefault();
            Console.WriteLine(firstGroupChar.Key);


        }
    }
}