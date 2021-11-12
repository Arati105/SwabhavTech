using HumanEnumApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("Arati", 150, 50);
            Console.WriteLine(h1.GetCount());

            Human h2 = new Human("pooja", 152, 60);
            Console.WriteLine(h2.GetCount());

            Human h3 = new Human("komal", 162, 40);
            Console.WriteLine(h3.GetCount());


        }
    }
}
