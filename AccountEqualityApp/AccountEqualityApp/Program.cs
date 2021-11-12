using AccountPropertyApp.Model;
using System;

namespace AccountEqualityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy();
            CaseStudy1();
            
        }
        private static void CaseStudy()
        {
            Account a = new Account(101, "Pooja", 25000);
            Console.WriteLine(a);
            Console.WriteLine(a.ToString());
        }
        private static void CaseStudy1()
        {
            Account acc1 = new Account(101, "Pooja", 52000);
            Account acc2 = new Account(101, "Pooja", 52000);
            Console.WriteLine(acc1.GetHashCode());
            Console.WriteLine(acc2.GetHashCode());
            Console.WriteLine(acc1 == acc2);
            Console.WriteLine(acc1.Equals(acc2));
        }
       

         
    }
}
