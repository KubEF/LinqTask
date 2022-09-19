using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTask
{
    internal class User
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public User(int id, String name, String surname)
        {
            ID = id;
            Name = name;
            Surname = surname;
        }
        public override string ToString()
        {
            return string.Format($"ID={ID}: {Name} {Surname}");
        }
    }
}
