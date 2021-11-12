using OCPViolationApp.Model;
using System;

namespace OCPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fd1 = new FixedDeposit("Arati", 10000, 5, FestivalType.DIWALI);
            Console.WriteLine("Simple Interest:{0}", fd1.SimpleInterest());
            Console.ReadKey();
        }
    }
}
