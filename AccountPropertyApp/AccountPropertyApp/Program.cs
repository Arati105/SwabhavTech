using AccountPropertyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPropertyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(12345, "Amol", 1500);
            acc1.Withdrow(1000);
            printDetails(acc1);

            Account acc2 = new Account(15634, "Komal");
            // printDetails(acc2);
            acc2.Deposit(5000);
            printDetails(acc2);
        }
        static void printDetails(Account acc1)
        {
            Console.WriteLine("\nAccount no:" + acc1.AccNo);
            Console.WriteLine("\nName:" + acc1.Name);
            Console.WriteLine("\nBalance:" + acc1.Balance);
        }
    }
    }

