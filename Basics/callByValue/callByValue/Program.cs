using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callByValue
{
    class Program
    {
        void Add(int i)
        {
            i = i + 10;
        }
        static void Main(string[] args)
        {
            int a = 10;

            Program p = new Program();
            Console.WriteLine("Before calling the method,the value in a is:" + a);
            p.Add(a);
            Console.WriteLine("After calling the method,the value in a is:" + a);

        }
    }
}
