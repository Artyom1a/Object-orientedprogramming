using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User
    {
        public User(int id, string name) => (ID, Name)=(id, name);
  
        public int ID { get; set; }
        public string Name { get; set; }
       
    }
}
