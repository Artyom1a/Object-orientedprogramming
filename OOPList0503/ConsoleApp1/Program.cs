using System;
using ConsoleApp1;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>();
            //List<string> list1 = new List<string>(5) { "V", "R", "E", "T", "F" };
            //list1.Add("A");
            //;
            //foreach (string s in list1)
            //{
            //    Console.WriteLine(s);
            //}
            // ------------------------------------
            // void Clear(): удаляет из списка все элементы
            //list1.Clear();

            // ------------------------------------
            //void AddRange(IEnumerable<T> collection): добавление в список коллекции или массива
            //list1.AddRange(list1);
            //list1.Sort();
            // ------------------------------------
            //int BinarySearch(T item): бинарный поиск элемента в списке. Если элемент найден,
            //int a;
            //то метод возвращает индекс этого элемента в коллекции. При этом список должен быть отсортирован.
            //a = list1.BinarySearch("R");


            //Console.WriteLine(a);
            //foreach (string s in list1)
            //{
            //    Console.WriteLine(s);
            //}
            // ------------------------------------

            //void CopyTo(T[] array): копирует список в массив array
            //string[] array = new string[20];
            //list1.CopyTo(array);
            //foreach (string s in array)
            //{
            //    Console.WriteLine(s);
            //}

            // ------------------------------------
            //void CopyTo(int index, T[] array, int arrayIndex, int count):
            //копирует из списка начиная с индекса index элементы,
            //количество которых равно count, и вставляет их в массив array начиная с индекса arrayIndex
            //string[] array = new string[20];
            //list1.CopyTo(3,array,5,7);
            //foreach (string s in array)
            //{
            //    Console.WriteLine(s);
            //}

            // ------------------------------------
            //bool Contains(T item): возвращает true, если элемент item есть в списке
            //bool b;
            //b = list1.Contains("A");
            //Console.WriteLine(b);




            // ------------------------------------
            //List<string> list2 = new List<string>(list1) { "T" };

            //List<Test> test = new List<Test>()
            //{
            //new Test("V"),
            //new Test("R"),
            //new Test("E"),
            //new Test("T"),
            //new Test("F")
            //          };
            //foreach (Test s in test)
            //{
            //    Console.WriteLine(s.ToString());
            //}

            //Console.WriteLine(list1[0]="S");
            //-------------------------------
            Employee employee = new Employee("Apple", "Sergey");
            employee.Print();
            Person employee1 = new Employee("Apple1", "Sergey1");
            employee1.Print();

        }
    }
}