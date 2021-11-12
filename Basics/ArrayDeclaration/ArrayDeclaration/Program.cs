using System;

namespace ArrayDeclaration
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int i, sum = 0;
            int average = 0;
            int size,max,min;
            Console.WriteLine("Enter the elemenet:");
            for(i=0;i<5;i++)
            {
                Console.Write("{0} ", i);
                arr[i] = int.Parse(Console.ReadLine());

            }
            for(i=0;i<arr.Length;i++)
            {
                sum += arr[i];
            }
            average = sum / arr.Length;
            Console.WriteLine("Average of array:" + average);
            

            Console.WriteLine("Sum of all elements : {0}\n\n", sum);
            max = arr[0];
            for (i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }


            }
            Console.Write("Maximum element is : {0}\n", max);
           



        }
    }
}

