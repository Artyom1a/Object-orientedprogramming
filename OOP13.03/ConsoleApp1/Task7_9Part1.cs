using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Task7_9Part1
    {

        public int Task7(string a)
        {
            int result = 0;
            a = a.ToLower();
            List<char> aList = new List<char>();


            for (int i = 0; i < a.Length; i++)
            {
                aList.Add(a[i]);
            }

            for (int j = 0; j < aList.Count; j++)
            {

                if (aList[j] == 'a' || aList[j] == 'e' ||
                    aList[j] == 'i' || aList[j] == 'o' ||
                    aList[j] == 'u' || aList[j] == 'y')
                {
                    result++;
                }
               
            }
            return result;
        }

        public void Task8(int a)
        {
            DateTime date1 = new DateTime(2023, 3, 13, 16, 32, 23); // 13.03.2023 16:32:23
            date1= date1.AddYears(-a); 
            Console.WriteLine(date1.Year);
        }
    }
}
