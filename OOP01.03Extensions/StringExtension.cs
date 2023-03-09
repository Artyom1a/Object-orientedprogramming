using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class StringExtension
    {
        public static string DecoratorSymbolAfterDigit(this string str, char symbol)
        {
            StringBuilder sb = new StringBuilder();
            foreach(char ch in str)
            {
                sb.Append(ch);
                if (char.IsDigit(ch)) ;
                {
                    sb.Append(symbol);
                }
            }
            return sb.ToString();
        }
    }
}
