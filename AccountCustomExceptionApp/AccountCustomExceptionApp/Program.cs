using AccountCustomExceptionApp.Model;
using System;

namespace AccountCustomExceptionApp
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Account acc1 = new Account(101, "Arati", 5000);
            /* try
             {

                 acc1.Withdrow(4501);
             }
             catch(Exception e)
             {
                 Console.ForegroundColor = ConsoleColor.Red;
                 Console.WriteLine(e.Message);
             }
             finally
             {
                 Console.ForegroundColor = ConsoleColor.Green;
                 Console.WriteLine("executes not matter exception or not");
                 PrintDetails(acc1);
             }*/
            try
            {

                acc1.Withdrow(4501);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
              
                Console.WriteLine(e.Message);
            }
            
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("executes not matter exception or not");
                PrintDetails(acc1);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("End of Main");

        }
        private static void PrintDetails(Account account)
        {
            Console.WriteLine("\naccount number: " + account.GetAccNo());
            Console.WriteLine("account name: " + account.GetName());
            Console.WriteLine("account balance:" + account.GetBalance());
        }
    }
}
