using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    class Person3 : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Company Work { get; set; }
        public Person3(string name, int age, Company company)
        {
            Name = name;
            Age = age;
            Work = company;
        }
        public object Clone() => new Person3(Name, Age, new Company(Work.Name));
    }
    class Company
    {
        public string Name { get; set; }
        public Company(string name) => Name = name;
    }
}
