using RectangleEncapSolutionApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RectangleApp r1 = new RectangleApp();
           // r1.SetWeight();
            Console.WriteLine(r1.GetWeight());

            Console.WriteLine("area of annonymuos object is:" + new RectangleApp().CalculateArea());
            displyInfo(new RectangleApp());
            displyInfo(new RectangleApp());


        }
            public static void displyInfo(RectangleApp r)
            {
                Console.WriteLine("Weight is:" + r.GetWeight());
                Console.WriteLine("Height is:" + r.GetHeight());
                Console.WriteLine("Area is:" + r.CalculateArea());
                
            }
            







            /*RectangleApp r1;
            r1 = new RectangleApp();
            r1.SetHeight(50);
            r1.SetWeight(40);
            displyInfo(r1);

            RectangleApp r2;
            r2 = new RectangleApp();
            r2.SetWeight(5);
            r2.SetHeight(7);
            displyInfo(r2);

            RectangleApp r3 = r2;
            r3.SetWeight(50);
            Console.WriteLine(r3.GetHeight());
            Console.WriteLine(r2.GetHeight());

            r1.SetHeight(r1.GetHeight() + 10);
            Console.WriteLine("Get height:"+r1.GetHeight());
        }

        public  static void displyInfo(RectangleApp r)
        {
            Console.WriteLine("Weight is:"+r.GetWeight());
            Console.WriteLine("Height is:"+r.GetHeight());
            Console.WriteLine("Area is:"+r.CalculateArea());
            Console.WriteLine("HashCode is:" + r.GetHashCode());
        }*/

        
    }
}
