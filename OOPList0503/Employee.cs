using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee : Person
    {
        public string Company { get; set; }

        public Employee(string company, string name) : base(name)
        {
            Company = company;

        }
        public sealed override void Print()  //new
        {
            Console.WriteLine($"{Name}{Company}");
        }
    }

}

