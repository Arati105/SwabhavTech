using RectangleEncapsulationApp.Model;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Rectangle r1;
           r1= new Rectangle();
            r1.SetWidth(100);
            Console.WriteLine("Width:"+r1.GetWidth());
           

            r1.SetHeight(20);
            Console.WriteLine("Height:"+r1.GetHeight());
            Console.ReadLine();*/

            Rectangle r1;
            r1 = new Rectangle();
            r1.SetWidth(101);
            Console.WriteLine(r1.GetWidth());

            r1.SetHeight(30);
            Console.WriteLine(r1.GetHeight());
        }
    }
}
