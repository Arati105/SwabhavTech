using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayFunction
{
   public class Program
    {
       
       static void PrintLargest(int[] nos)
       {
           int max = nos[0];
           for (int i = 1; i < nos.Length; i++)
           {
               if (max < nos[i])
               {
                   max = nos[i];
               }
           }
           Console.WriteLine("Largset number:" + max);
       }
       static void Printsumof(int[] nos)
       {
           int sum = 0;
           for (int i = 0; i < nos.Length; i++)
           {
               sum += nos[i];
           }
           Console.WriteLine("Sum:" + sum);
       }
       static void Printaverage(int[] nos)
       {
           int avg = 0;
           int sum = 0;
           for (int i = 0; i < nos.Length; i++)
           {
               sum += nos[i];
           }
           avg = sum / nos.Length;
           Console.WriteLine("Average:" + avg);
       }
       static void Main(string[] args)
        {
            int[] nos = { 10, 20, 30, 41 };

            PrintLargest(nos);
            Printsumof(nos);
            Printaverage(nos);
        }
    }
}
