using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionEvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Array Size:");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.Write("array elements:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array elements:");
                array[i] = int.Parse(Console.ReadLine());
            }

            GetEvenNumber(array);
            GetOddNumber(array);
        }
        static void GetEvenNumber(int[] array)
        {
            int evenCount = 0;
            for(int i=0;i<array.Length;i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine("{0} is even number", array[i]);
                    evenCount++;

                }
                
            }
            
           
        }
        static void GetOddNumber(int[] array)
        {
            int oddCount = 0;
            for(int i=0;i<array.Length;i++)
            {
                if(array[i]%2!=0)
                {
                    Console.WriteLine("{0} is odd number", array[i]);
                    oddCount++;
                    
                }
               
            }
        }

           

        
    }
}
