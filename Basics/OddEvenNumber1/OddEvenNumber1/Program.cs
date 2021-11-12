using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenNumber1
{
    class Program
    {
        
        static String GetEvenNumber(String[] array)
        {
            Console.WriteLine("Enter the number:");
            Console.ReadLine();
            if (array.Length >= 1)
            {
                if (array.Length % 2 == 0)
                {
                    Console.WriteLine("Enter the even number:");
                    Console.ReadLine();
                    return array[array.Length / 2];
                    
                }
            }
            return " ";
            
        }
        static String  GetOddNumber(String[] array)
        {
            if (array.Length >= 1)
            {
                if (array.Length %2 != 0)
                {
                    Console.WriteLine("Enter the odd number:");
                    return array[array.Length / 2];
                }
            }
            return " ";

            
        }
        static void Main(string[] args)
        {
            
            Program q = new Program();
            int[] array = new int[] { };
            q.GetEvenNumber(array);
            q.GetOddNumber(array)
          
            
        }
    }
}
