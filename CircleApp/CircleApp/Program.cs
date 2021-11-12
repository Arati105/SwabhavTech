using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle cir;
            cir = new Circle();
            cir.radius = 7;
            cir.color = "Blue";
            

            double areaOfcircle= cir.CircleArea();
            double areaOfperimeter = cir.CirclePerimeter();

            Console.WriteLine("Radius of circle:" + cir.radius);
            Console.WriteLine("Circle color:" + cir.color);
            Console.WriteLine("Area of circle:" + areaOfcircle);
            Console.WriteLine("Area of perimeter:" + areaOfperimeter);
        }
    }
}
