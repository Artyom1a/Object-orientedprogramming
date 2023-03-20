using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Task16_18Part1
    {









        public List<char> Task18(string a)
        {
            List<char> result = new List<char>();
            for(int i= a.Length-1; i>=0;i--)
            {
                result.Add(a[i]);
            }

            return result; 
        }
    }
}
