using AccountPolymorphsmApp.Model;
using System;

namespace AccountPolymorphsmApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount acc1 = new SavingAccount(101, "Seema", 5000);
            PrintDetails(acc1);
            CurrentAccount acc2 = new CurrentAccount(102, "Arati", 9000);
            PrintDetails(acc2);
            acc1.Withdraw(3000);
            PrintDetails(acc1);
            acc2.Withdraw(6000);
            PrintDetails(acc2);

            Console.ReadLine();
        }

        

        private static void PrintDetails(Account account)
        {
            Console.WriteLine("\naccount number: " + account.accno);
            Console.WriteLine("account name: " + account.accname);
            Console.WriteLine("account balance:" + account.balance);
        }
    }
}
