﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Task19_21Part1
    {

        public bool Task19(string a)
        {
            List<char> lista = new List<char>();
            for (int i = a.Length - 1; i >= 0; i--)
            {
                lista.Add(a[i]);
            }

            List<char> listb = new List<char>();
            for (int j = 0; j < a.Length; j++)
            {
                listb.Add(a[j]);
            }

            return lista.SequenceEqual(listb);
        }

        public void Task20(string a)
        {
            a = a.Replace(" ", "");
            Console.WriteLine("String without probels: " + a);
        }

        public void Task21(string a)
        {
            a = a.Replace(" ", "_");
            Console.WriteLine("String without probels and with _: " + a);
        }
    }
}
