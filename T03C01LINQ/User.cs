using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03C01LINQ
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public User(int id, string name, string surname)
        {
            ID = id;
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return string.Format("ID={0}: {1} {2}", ID, Name, Surname);
        }
    }
}
