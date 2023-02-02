using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Classes;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        var collection = new List<Product>();

        for (var i = 0; i < 10; i++)
        {
            var product = new Product()
            {
                Name = "Product" + i,
                Energy = rnd.Next(10, 15)
            };
            collection.Add(product);
        }

        var result = from item in collection
                     where item.Energy < 200
                     select item;
        Console.WriteLine(result);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        var result2 = collection.Where(item => item.Energy > 200);
        //.Where(item => item % 2 == 0)
        //.OrderByDescending(item => item).ThenByDescending(item => item)
        //.Select(item => item).Single();
        Console.WriteLine(result2);
        foreach (var item in result2)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        //foreach (var item in result2)
        //{
        //    Console.WriteLine(item);
        //}
        //Select
        Console.WriteLine("Select");
        var selectCollection = collection.Select(product => product.Energy);
        foreach (var item in selectCollection)
        {
            Console.WriteLine(item);
        }
        //OrderBy 
        //+ OrderByDescending 
        Console.WriteLine("OrderByDescending");
        var orderbycollection = collection.OrderBy(product => product.Energy).ThenBy(product => product.Name);
        foreach (var item in orderbycollection)
        {
            Console.WriteLine(item);
        }

        var groupbyCollection = collection.GroupBy(product => product.Energy);
        foreach (var group in groupbyCollection)
        {
            Console.WriteLine($"key: {group.Key}");
            foreach (var item in group)
            {
                Console.WriteLine($"{item}");
            }
        }
        //+ Reverse 
        Console.WriteLine("Reverse");
        collection.Reverse();
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }
        //+ All //+ Any 
        Console.WriteLine("All (Any) ");
        Console.WriteLine(collection.All(item => item.Energy == 12));
        Console.WriteLine(collection.Any(item => item.Energy == 10));
        //Contains
        Console.WriteLine("Contains");
        Console.WriteLine(collection.Contains(collection[3]));
        //Union
        Console.WriteLine("Union");
        var array = new int[] { 1, 2, 3, 4 };
        var array1 = new int[] { 4, 3, 6, 6 };
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Unionarray");
        var union = array.Union(array1);
        foreach (var item in union)
        {
            Console.WriteLine(item);
        }
        //Intersect
        Console.WriteLine("Intersect");
        var array2 = array.Intersect(array1);
        foreach (var item in array2)
        {
            Console.WriteLine(item);
        }
        //Except
        Console.WriteLine("Except");
        var array3 = array.Except(array1);
        foreach (var item in array3)
        {
            Console.WriteLine(item);
        }
        //Concat
        Console.WriteLine("Concat");
        var array4 = array.Concat(array1);
        foreach (var item in array4)
        {
            Console.WriteLine(item);
        }
        //Sum
        Console.WriteLine("Sum");
        Console.WriteLine(array.Sum());
        //Aggregate
        Console.WriteLine("Aggregate");
        var aggregate = array.Aggregate((x, y) => x * y);
        Console.WriteLine(aggregate);

        array1 = new int[] { 4, 3, 6, 6 };
        //Skip Take
        Console.WriteLine("Skip / Take");
        Console.WriteLine(array1.Skip(1).Take(2).Sum());

        ////Join
        //Console.WriteLine("Join");
        //var array6 = array.Join(array1, array.Skip(1), array1.Skip(1),array, array1);



        //Zip
        Console.WriteLine("Zip");
        var array5 = array.Zip(array1);
        foreach (var item in array4)
        {
            Console.WriteLine(item);
        }
        //Distinct
        Console.WriteLine("Distinct");
        

    }
}


//+Select - определяет проекцию выбранных значений
//+ Where - определяет фильтр выборки
//+ OrderBy - упорядочивает элементы по возрастанию
//+ OrderByDescending - упорядочивает элементы по убыванию
//+ ThenBy - задает дополнительные критерии для упорядочивания элементов возрастанию
//+ ThenByDescending - задает дополнительные критерии для упорядочивания элементов по
//убыванию
//+ Join - соединяет две коллекции по определенному признаку
//+ Aggregate - применяет к элементам последовательности агрегатную функцию, которая
//сводит их к одному объекту
//+ GroupBy - группирует элементы по ключу
//Список методов расширения LINQ
//• ToLookup - группирует элементы по ключу, при этом все элементы добавляются в словарь
//• GroupJoin - выполняет одновременно соединение коллекций и группировку элементов по
//ключу
//+ Reverse - располагает элементы в обратном порядке
//+ All - определяет, все ли элементы коллекции удовлятворяют определенному условию
//+ Any - определяет, удовлетворяет хотя бы один элемент коллекции определенному условию
//+ Contains - определяет, содержит ли коллекция определенный элемент
//+ Distinct - удаляет дублирующиеся элементы из коллекции
//+ Except - возвращает разность двух коллекцию, то есть те элементы, которые создаются только
//в одной коллекции
//+ Union - объединяет две однородные коллекции
//Список методов расширения LINQ
//+ Intersect - возвращает пересечение двух коллекций, то есть те элементы, которые встречаются
//в обоих коллекциях
//+ Count - подсчитывает количество элементов коллекции, которые удовлетворяют
//определенному условию
//+ Sum - подсчитывает сумму числовых значений в коллекции
//+ Average - подсчитывает cреднее значение числовых значений в коллекции
//+ Min - находит минимальное значение
//+ Max - находит максимальное значение
//+ Take - выбирает определенное количество элементов
//+ Skip - пропускает определенное количество элементов
//+ Concat - объединяет две коллекции
//Список методов расширения LINQ
//+ TakeWhile - возвращает цепочку элементов последовательности, до тех пор, пока условие
//истинно
//+ SkipWhile - пропускает элементы в последовательности, пока они удовлетворяют заданному
//условию, и затем возвращает оставшиеся элементы
//+ Zip - объединяет две коллекции в соответствии с определенным условием
//+ First - выбирает первый элемент коллекции
//+ FirstOrDefault - выбирает первый элемент коллекции или возвращает значение по
//умолчанию
//+ Single - выбирает единственный элемент коллекции, если коллекция содержит больше или
//меньше одного элемента, то генерируется исключение
//+ ElementAt - выбирает элемент последовательности по определенному индексу
//Список методов расширения LINQ
//+ SingleOrDefault - выбирает единственный элемент коллекции.Если коллекция пуста,
//возвращает значение по умолчанию. Если в коллекции больше одного элемента, генерирует
//исключение
//+ ElementAt - выбирает элемент последовательности по определенному индексу
//+ ElementAtOrDefault - выбирает элемент коллекции по определенному индексу или
//возвращает значение по умолчанию, если индекс вне допустимого диапазона
//+ Last - выбирает последний элемент коллекции
//+ LastOrDefault - выбирает последний элемент коллекции или возвращает значение по
//умолчанию