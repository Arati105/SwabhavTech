using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ArrayImplement
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = new int[5];   
            for (int i= 0;i<args.Length;i++)
            {
                // Console.WriteLine("{0}",args[i]);
               // int number = Convert.ToInt32(args[i]);
               arr[i] = Convert.ToInt32(args[i]);
            }
            int sum=0;
            int average = 0;
            int max=0;
            int p = Convert.ToInt32(args[0]);
            for (int i=0;i<args.Length;i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of elements:" + sum);
            average =sum / arr.Length;
            Console.WriteLine("Average of array:" + average);
            for(int i=0;i<args.Length;i++)
            {
                if(arr[i]>max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Maximum Value:" + max);
            }
    }
}
