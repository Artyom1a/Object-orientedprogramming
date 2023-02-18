using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Phone { get; set; }

        public User(string name, int id, string phone) => (Name,Id, Phone)=(name,id,phone);
        //{
        //    Name = name;
        //    Id = id;
        //    Phone = phone;
        //}
    }
}
