//using System;
//using ConsoleApp1;

//namespace MyApp // Note: actual namespace depends on the project name.
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            List<User> users = new List<User>();
//            users.Add(new User("Vitya", 1, "32736"));
//            users.Add(new User("GEvk", 2, "32736"));
//            users.Add(new User("Vitya", 3, "32736"));
//            users.Add(new User("GEvk", 4, "32736"));
//            users.Add(new User("rgEK", 5, "32736"));
//            users.Add(new User("Vitya", 6, "32736"));
//            users.Add(new User("GEvk ", 7, "32736"));
//            users.Add(new User("rgEK", 8, "32736"));
//            users.Add(new User("Vitya", 9, "32736"));
//            users.Add(new User("GEvk", 10, "32736"));



//            var groupbyCollection = users.GroupBy(user => user.Name).ToDictionary(x=>x.Key,x=>x.ToList());

//            Console.ReadKey();

//            //Task1 var1
//            //Dictionary<string,List<User>> map = new Dictionary<string,List<User>>();
//            //for(int i=0;i<users.Count;i++) 
//            //{
//            //    User user = users[i];
//            //    if (map.ContainsKey(user.Name))
//            //    {
//            //        map[user.Name].Add(user);
//            //    }
//            //    else
//            //    {
//            //        List<User> temp = new List<User>();
//            //        temp.Add(user);
//            //        map.Add(user.Name, temp);
//            //    }
//            //}
//            //foreach(var item in map)
//            //{
//            //    Console.WriteLine(item);
//            //}

//            //Task1 var2
//            //Dictionary<string, List<User>> map = new Dictionary<string, List<User>>();
//            //for (int i = 0; i < users.Count; i++)
//            //{
//            //    User user = users[i];
//            //    if (!map.TryGetValue(user.Name, out _) {
//            //        map.Add(user.Name, new List<User>());
//            //    }
//            //    map[user.Name].Add(user);

//            //}
//            //**********************
//            //Task1 var3
//            //Dictionary<string, List<User>> map = new Dictionary<string, List<User>>();
//            //for (int i = 0; i < users.Count; i++)
//            //{
//            //    User user = users[i];
//            //    if (!map.TryGetValue(user.Name, out List<User> values))
//            //    {
//            //        values = new List<User>();
//            //        map.Add(user.Name, values);
//            //    }
//            //    values.Add(user);
//            //}
//            //foreach(var key in map.Keys) 
//            //{ 
//            //string text = map[key].Join("; ", map[key]);
//            //    Console.WriteLine(text);
//            //}
//        }
//    }
//}




using System;
using ConsoleApp1;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Matrix part = new Matrix(4, 3);
            //part.Zapolnenie();
            //part.Reverse();
            int num = 125;
            Console.WriteLine(num.ToRaz(0));
            Console.WriteLine(num.ToBinary());
            Console.WriteLine(num.ToRaz(1));
            Console.WriteLine(num.ToOctal());
            Console.WriteLine(num.ToRaz(2));
            Console.WriteLine(num.ToHex());
            string num1 = "10101";
            Console.WriteLine(num1.ToDecimalFromBinary());
           




        }
    }
}