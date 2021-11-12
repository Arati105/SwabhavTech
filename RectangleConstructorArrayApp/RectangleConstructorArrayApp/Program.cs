using RectangleConstructorArrayApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle r;
            r = new Rectangle(10, 5);
            r.SetWeight(10);
            r.SetHeight(5);

            Console.WriteLine("area of annonymous object is:" + new Rectangle(8, 5).CalculateArea());
            displayInfo(new Rectangle(10, 5));
            Rectangle[] rectangles = new Rectangle[4];
            Console.WriteLine();
            Console.WriteLine("\n ***Zero Array****");
            rectangles[0] = new Rectangle(10, 2);
            displayInfo(rectangles[0]);
            Console.WriteLine("\n ***FIrst Array***");
            rectangles[1] = new Rectangle(20, 6);
            displayInfo(rectangles[1]);
            Console.WriteLine("\n ***Second Array***");
            rectangles[2] = new Rectangle(15,3);
            displayInfo(rectangles[2]);
            Console.WriteLine("\n ***Third Array***");
            rectangles[3] = new Rectangle(8,5);
            displayInfo(rectangles[3]);
        }

        public static void displayInfo(Rectangle r)
        {
            Console.WriteLine("Weight:" + r.GetWeight());
            Console.WriteLine("Height:" + r.GetHeight());
            Console.WriteLine("Area is:" + r.CalculateArea());
       
        }
    }
    }

