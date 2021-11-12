using RectangleConstructorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Rectangle r1 = new Rectangle(26, 48);
            Console.WriteLine(r1.GetCount());

            Rectangle r2 = new Rectangle(56, 75);
            Console.WriteLine(r2.GetCount());

            Rectangle r3 = new Rectangle(65, 75);
            Console.WriteLine(r3.GetCount());
        }
    }
}
