using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp.Model
{
    class Man:IManner
    {
        public void Wish()
        {
            Console.WriteLine("Wishing...");
        }
        public void Depart()
        {
            Console.WriteLine("Depart..");
        }
    }
}
