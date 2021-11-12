using CurdableApp.Model;
using System;

namespace CurdableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoDBoperations(new PremiumCustomerDB());
            DoDBoperations(new ProductDB());
            DoDBoperations(new OrderDB());
            Console.ReadLine();
            
        }
        private static void DoDBoperations(ICurdable obj )
        {
            Console.WriteLine("\nDoing all database operations,please____wait");
            obj.Create();
            obj.Update();
            obj.Read();
            obj.Delete();
        }
    }
}
