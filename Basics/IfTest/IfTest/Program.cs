using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            if (x == 3)
            {
                Console.WriteLine("x must be 3");
            }
            Console.WriteLine("This runs no matter what");
        }
    }
}
