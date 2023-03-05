﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            this.Name = name;
        }
        public virtual void Print()
        {
            Console.WriteLine($"{Name}");
        }
    }
}
