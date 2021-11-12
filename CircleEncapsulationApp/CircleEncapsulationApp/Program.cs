using CircleEncapsulationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleEncapsulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle cir;
            cir = new Circle();

            cir.SetRadius(10);
            Console.WriteLine("Circle Radius:" + cir.GetRadius());

            cir.SetColor("green");
            Console.WriteLine("Circle color:" + cir.GetColor());
            Console.ReadLine();

           
        }
    }
}
