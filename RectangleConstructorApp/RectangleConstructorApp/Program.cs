using RectangleConstructorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r;
            r=new Rectangle(10,5);
            r.SetWeight(10);
            r.SetHeight(5);
            
            Console.WriteLine("area of annonymous object is:" + new Rectangle(8,5).CalculateArea());
            displayInfo(new Rectangle(10, 5));
        }
        public static void displayInfo(Rectangle r)
        {
            Console.WriteLine("Weight:" + r.GetWeight());
            Console.WriteLine("Height:" + r.GetHeight());
            Console.WriteLine("Area is:" + r.CalculateArea());
        }
    }
}
