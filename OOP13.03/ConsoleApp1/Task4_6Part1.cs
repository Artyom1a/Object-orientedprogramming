using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Task4_6Part1
    {
        public void Task4(string a)
        {
            string b="";
            for (int i=a.Length-1; i>=0; i++) 
            {
                b += a[i];
            }

        if(a==b)
            {
                Console.WriteLine("This is polindrom");
            }
        else
            { Console.WriteLine("This is not polindrom"); }
        }
    }
}
