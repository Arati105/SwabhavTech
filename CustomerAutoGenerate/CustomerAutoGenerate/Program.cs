using CustomerAutoGenerate.Model;
using System;

namespace CustomerAutoGenerate
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Arati",1000);
            Details(c1);
            Customer c2 = new Customer("Seema", 45000);
            Details(c2);
            Customer c3 = new Customer("Komal", 56000);
            Details(c3);
            Console.WriteLine(c1._id);
           
            Console.WriteLine(c2._id);
           
            Console.WriteLine(c3._id);
         
            Console.ReadKey();

        }
        private static void Details(Customer c)
        {
            Console.WriteLine("Id:" + c._id);
            Console.WriteLine("Name:" +c.Name);
            Console.WriteLine("Salary:" + c.Salary);
        }
    }
}
