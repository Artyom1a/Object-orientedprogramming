using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class ConvertException
    {
        public static string ToBinary(this int number)
        {
            List<object> result = new List<object>();

            object[] numbers = { 0, 1 };
            int basesystem = numbers.Length;
            while (number > 0)
            {
                result.Add(numbers[number % basesystem]);
                number /= basesystem;
            }
            result.Reverse();
            return string.Join("", result);

        }


        public static string ToOctal(this int number)
        {
            List<object> result = new List<object>();

            object[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int basesystem = numbers.Length;
            while (number > 0)
            {
                result.Add(numbers[number % basesystem]);
                number /= basesystem;
            }
            result.Reverse();
            return string.Join("", result);
        }

        public static string ToHex(this int number)
        {
            List<object> result = new List<object>();

            object[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, "A", "B", "C", "D", "E", "F" };
            int basesystem = numbers.Length;
            while (number > 0)
            {
                result.Add(numbers[number % basesystem]);
                number /= basesystem;
            }
            result.Reverse();
            return string.Join("", result);
        }


        public static string ToRaz(this int number, int system)
        {
            List<object> result = new List<object>();

            object[] numbers = { 0, 1 };
            object[] numbers1 = { 0, 1, 2, 3, 4, 5, 6, 7 };
            object[] numbers2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, "A", "B", "C", "D", "E", "F" };
            switch (system)
            {
                case 0:
                    int basesystem = numbers.Length;
                    while (number > 0)
                    {
                        result.Add(numbers[number % basesystem]);
                        number /= basesystem;
                    }
                    break;
                case 1:
                    int basesystem1 = numbers1.Length;
                    while (number > 0)
                    {
                        result.Add(numbers1[number % basesystem1]);
                        number /= basesystem1;
                    }
                    break;

                case 2:
                    int basesystem2 = numbers2.Length;
                    while (number > 0)
                    {
                        result.Add(numbers2[number % basesystem2]);
                        number /= basesystem2;
                    }
                    break;

            }
            result.Reverse();
            return string.Join("", result);

        }

        //1010
        public static int ToDecimalFromBinary(this string number)
        {
            int result = 0;
            int count = 0;
            for (int i = number.Length-1; i > -1; i--)
            {
                if (!int.TryParse(number[i].ToString(), out int num))
                {
                    throw new Exception("Exception");
                }
                result += num * (int)Math.Pow(2, count++);
            }
            return result;
        }

    }
}
