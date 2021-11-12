using PropertySyntaxApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySyntaxApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Foo f = new Foo();
            f.Bar = 100;
            Console.WriteLine(100);
           // f.SetBar(100);
            //Console.WriteLine(" " + f.GetBar());
        }
    }
}
