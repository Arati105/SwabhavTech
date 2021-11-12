using PatternAppStrategy.Model;
using System;

namespace PatternAppStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateClient client = new CalculateClient(new Minus());
            Console.WriteLine("Minus:" + client.Calculate(7, 1).ToString());

            CalculateClient plusClient = new CalculateClient(new Plus());
            Console.WriteLine("Plus:" + plusClient.Calculate(7, 1).ToString());
            Console.ReadKey();
        }
    }
}
