using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Extencions;

//Написать метод обобщения, которыйм производит фильтрацию данныхю В качестве
//входжных параметров коллекция(данных обобщенного типа и делигат, по котолрому
//будет производиться фильтрация данных.




namespace ConsoleApp1
{

    internal static class Extencions
    {
       
        public delegate bool Filter<T>(T item);
        public static List<T> FilterList<T>(this List<T> data, Filter<T> method)
        {
            List<T> list = new List<T>();
            for (int i = 0; i < data.Count; i++)
            {
                if (method(data[i]))
                {
                    list.Add(data[i]);
                }
            }
            return list;
        }




    }
}
