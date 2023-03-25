using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Task22_24Part1
    {

        public int Task22(string a)
        {
            List<char> list = new List<char>();
            int x = 0;
            int z = 0;
            while(x<a.Length)
            {
                list.Add(a[x++]);
                if (
                list.Contains('a') ||
                list.Contains('e') ||
                list.Contains('y') ||
                list.Contains('u') ||
                list.Contains('i') ||
                list.Contains('a') ||
                list.Contains('o')
                )
                {
                    z += 1;
                }
            }

            return z;
        }
        public int Task23(string a)
        {
            a = a.Trim();
            return a.Split(' ').Length;
        }
        public int Task24(string a)
        {
            a = a.Trim();
            string[] array= a.Split(' ');
            int x=0;
            for(int i=0; i<array.Length; i++) 
            {
                // [dg] [eew]
                if (x < array[i].Length)
                {
                    x = array[i].Length;
                }
            }
            return x;
        }


    }
}
