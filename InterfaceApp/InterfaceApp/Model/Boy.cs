using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp.Model
{
    class Boy:IManner,IEmotion
    {
        public void Wish()
        {
            Console.WriteLine("Wishing..");
        }
        public void Depart()
        {
            Console.WriteLine("Depart..");
        }
        public void Cry()
        {
            Console.WriteLine("Cry..");
        }
        public void Laught()
        {
            Console.WriteLine("Laught..");
        }
    }
}
