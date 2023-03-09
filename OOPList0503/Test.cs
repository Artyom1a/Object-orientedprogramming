using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Test
    {
        //объект List типизируется типом string. 
        public string Name;
        public Test(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
