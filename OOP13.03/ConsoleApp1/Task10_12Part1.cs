﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Task10_12Part1
    {
        public void Task10()
        {
            int a = new Random().Next(1, 100);
            Console.WriteLine($"random number a= {a}");
            Console.WriteLine("Write number b:");
            int b = Convert.ToInt32(Console.ReadLine());
            while (a != b)
            {
                if (a > b)
                {
                    Console.WriteLine("random number >your number");
                    b = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("random number <your number");
                    b = Convert.ToInt32(Console.ReadLine());
                }
            }
            if (a == b)
            {
                Console.WriteLine("random number ==your number");
            }
        }

        public bool Task11(int a)
        {
            if (a == 1) return false;

            int b = (int)Math.Floor(Math.Sqrt(a));

           for(int i =2; i<= b;i++)
            {
                if (a % i == 0) return false;
            }
            return true;

        }


        

        }







    }