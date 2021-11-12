using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleAurionProMathCalculator
{
    class Program
    {
        private static IEnumerable<int> evenArray;
       // private static ModelAss m1;
        //private static ModelAss m2;
        //private static ModelAss m3;
        static void Main(string[] args)
        {
            ModelAss m = new ModelAss();
            CaseStudy1(m1);
            CaseStudy2(m2);
            CaseStudy3(m3);

        }
        private static void CaseStudy1(ModelAss m1)
        {
            if (m1.CheckPrimeNo(23) == true)
            {
                Console.WriteLine("The number is prime");
            }
            else
            {
                Console.WriteLine("The number is not prime");
            }
        }
        private static void CaseStudy2(ModelAss m2)
        {
            int limit = 45;
            int[] evenArray = m2.GenerateEvenNo(limit);
            Console.WriteLine("Even no till {0}",limit);
            foreach (int i in evenArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");
        }
        private static void CaseStudy3(ModelAss m3)
        {
            int limit = 50;
            int[] primeArray = m3.GeneratePrimeNo(limit);
            Console.WriteLine("prime no till {0}", limit);
            foreach (int i in primeArray)
            {
                if (i == 0)
                {
                    break;
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine(" ");
        }
    }
}
