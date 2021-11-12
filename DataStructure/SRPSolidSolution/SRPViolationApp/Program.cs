using SRPViolationApp.Model;
using System;

namespace SRPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice i = new Invoice(101, "A Timesheet invoice", 10000, 10, 5);
            Print(i);
            Console.ReadLine();

        }
        private static void Print(Invoice i)
        {
            Console.WriteLine("========Invoice Details=========");
            Console.WriteLine("Id:" + i.Id);
            Console.WriteLine("AMount:" + i.Amount);
            Console.WriteLine("Description:" + i.Description);
            Console.WriteLine("tax:" + i.Tax + "%");
            Console.WriteLine("Discount:" + i.Discount + "%");
            Console.WriteLine("Tax Amount:" + i.CalculateTax());
            Console.WriteLine("Discount Amount:" + i.CalculateDiscount());
            Console.WriteLine("Total Amount:" + i.CalculateFinalAmount());

        }
    }
}
