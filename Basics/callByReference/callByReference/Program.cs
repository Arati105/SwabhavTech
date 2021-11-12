using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callByReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("Variable value before calling the method:{0}", x);
            Multiplication(ref x);
            Console.WriteLine("Variable value After calling the method:{0}", x);
        }
            public static void Multiplication(ref int a)
            {
                a *= a;
                Console.WriteLine("Variable value Inside the method:{0}", a);
            }
        }
    }
