using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101,"Arati",1000);
            Console.WriteLine(acc1.GetCount());

            Account acc2 = new Account(102, "Advit");
            Console.WriteLine(acc2.GetCount());

            Account acc3 = new Account(102, "Advit");
            Console.WriteLine(acc3.GetCount());


        }
    }
}
