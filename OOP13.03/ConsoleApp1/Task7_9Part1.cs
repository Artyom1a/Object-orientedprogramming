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

        public void Task9(int a, int b)
        {
            int nod = 1;

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            if (a == 0)
            {
                nod = b;
            }
            else if (b == 0)
            {
                nod = a;
            }

            Console.WriteLine($"NOD {nod}");
        }


    }
}
