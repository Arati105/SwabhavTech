using CollectionApp.Model;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionApp
{
    class Program
    {


        static void Main(string[] args)
        {
            // CaseStudy1();
            CaseStudy2();
        }
        private static void CaseStudy1()
        { 
            ArrayList basket = new ArrayList();
            basket.Add(new LineItem("earphone", 150, 2));
            basket.Add(new LineItem("kids toys", 500, 3));
            basket.Add(new LineItem("Mobile", 560, 1));
            
            foreach(LineItem item in basket)
            {
                Console.WriteLine("\nProduct Name:"+item.ProductName);
                Console.WriteLine("\nProduct Price:"+item.Price);
                Console.WriteLine("\nProduct Quantity:"+item.Quantity);
                Console.WriteLine("\nProduct Price:"+item.TotalPrice());
            }
            Console.ReadLine();
        }
        private static void CaseStudy2()
        {
            List<LineItem> basket = new List<LineItem>();
            basket.Add(new LineItem("earphone", 150, 2));
            basket.Add(new LineItem("kids toys", 500, 3));
            double totalcost = 0;
            foreach(LineItem item in basket)
            {
                Console.WriteLine("\nProduct Name:" + item.ProductName);
                Console.WriteLine("\nProduct Price:" + item.Price);
                Console.WriteLine("\nProduct Quantity:" + item.Quantity);
                Console.WriteLine("\nProduct Price:" + item.TotalPrice());
                totalcost += item.TotalPrice();
            }
            Console.WriteLine("\nTotal cost:{0}", totalcost);
        }
     }
}
