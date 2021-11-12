using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraySum
{
    class Program
    {
       
        static void Main(string[] args)
        {
           
            int[] arr = new int[5];
            for (int i = 0; i < args.Length; i++)
            {
                arr[i] = Convert.ToInt32(args[i]);
            }
            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }
            int sum = 0;
            for (int i = 0; i < args.Length; i++)
            {
                sum = sum + arr[i];
            }
            
            Console.WriteLine("Sum of array:" + sum);
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = sum;
                break;
            }
            Console.WriteLine("Sum of array:" + sum);
           }
    }
}
