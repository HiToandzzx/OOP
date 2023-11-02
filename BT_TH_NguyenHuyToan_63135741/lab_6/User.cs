using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    class User
    {
        string name;
        string pass;
        public User(string n = "", string p = "")
        {
            name = n; 
            pass = p;
        }

        public string Pass { get => pass; set => pass = value; }
        public string Name { get => name; set => name = value; }

    }
}
