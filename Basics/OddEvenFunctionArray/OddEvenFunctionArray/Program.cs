using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenFunctionArray
{
    class Program
    {
        
        static void GetEvenNumber(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {

                    Console.WriteLine("Enter Even number:" + arr);
                    Console.ReadLine();

                }
                
            }



        }
        static void GetOddNumber(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.WriteLine("Enter the odd Number:" + arr);
                    Console.ReadLine();
                }
               
            }
        }
        

        static void Main(string[] args)
        {
            int[] arr = new int[] { };
        
            GetEvenNumber(arr);
            GetOddNumber(arr);

            Console.WriteLine("Enter the Number:");
           Console.ReadLine();




        }
    }
}
