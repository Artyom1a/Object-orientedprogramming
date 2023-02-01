using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classes
{
    class Person1 : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person1(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public object Clone()
        {
            return new Person1(Name, Age);
        }
    }
}
