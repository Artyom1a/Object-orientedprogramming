using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    class Person2 : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person2(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
