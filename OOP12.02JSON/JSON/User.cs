using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.JSON
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime LastUpdate { get; set; }
        public UserStatus Status { get; set; }

        public User(int id, string name, DateTime lastUpdate, UserStatus status) 
        {
            Id = id;
            Name = name;
            LastUpdate = lastUpdate;
            Status = status;
          
        }
        public override string ToString()
        {
            return $"#{Id} {Name} {Status} last update {LastUpdate}";
        }

        


    }
}
