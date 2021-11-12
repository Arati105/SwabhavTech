using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle1 small;
            small = new Rectangle1();

            small.weight = 20;
            small.height = 5;

            int area = small.CalculateArea();
            Console.WriteLine("Width of small rectangle:" + small.weight);
            Console.WriteLine("height of small rectangle:" + small.height);
            Console.WriteLine("Area of rectangle:" + area);

            
        }
    }
}
