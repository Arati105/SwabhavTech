using ProductApp.Model;
using System;

namespace ProductApp
{
    class Program
    {
        static void Main(string[] args)
        {
           CaseStudy1();
            CaseStudy2();

            Console.WriteLine("Total number:{0}", Product.Occurances);
        }
        private static void CaseStudy2()
        {
            Product p1 = new Product(101, "Head First Java", 500.0);
            Console.WriteLine(p1.InstanceCount);
            Product p2 = new Product(102, "Head First c#", 200.0, 10);
            Console.WriteLine(p2.InstanceCount);
            Product p3 = new Product(103, "Head First Java", 400.1, 0.8);
            Console.WriteLine(p3.InstanceCount);
           Console.ReadLine();
        }
        private static void CaseStudy1()
        {
            Product p1 = new Product(101, "HeadFirst Java", 500.0,2.5);
            PrintDetails(p1);
            Console.WriteLine();
            Product p2 = new Product(102, "HeadFirst c#", 500,0.30);
            PrintDetails(p2);
            Console.ReadLine();
        }
        private static void PrintDetails(Product product)
        {
            Console.WriteLine("Product Id:" +product.Id);
            Console.WriteLine("Product Name:" +product.Name);
            Console.WriteLine("Product Price:" + product.Price);
            Console.WriteLine("Product Discount:" +product.Discount);
            Console.WriteLine ("final Price:"+product.CalculatePrice());
        }
           
        
    }
}
