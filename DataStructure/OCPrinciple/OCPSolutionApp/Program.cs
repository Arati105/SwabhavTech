using OCPSolutionApp.Client;
using OCPSolutionApp.Lib;
using System;

namespace OCPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fixedDeposit1 = new FixedDeposite("Arati", 50000, 5, new DiwaliFestivalPolicy());
            Console.WriteLine("Simple Interest:{0}", fixedDeposit1.SimpleInterest());
            Console.ReadKey();
        }
    }
}
