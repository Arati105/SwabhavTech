using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionApp
{
    class Program
    {
           static int Printlargest(int[] nos,int larger)
            {
                 return nos.Max()
;            }
           
          void Printsumof(int[] nos)
           {
               for (int i = 3; i < nos.Length; i++)
               {
                   int sum = nos.Sum();
                   Console.WriteLine("Sum:" + sum);

               }
           }
          void Printaverage(int[] nos)
           {
               int sum = 0;
                 int avg = 0;
                   for(int i=0;i<nos.Length;i++)
            {
                sum += nos[i];
            }
            avg = sum / nos.Length;
            Console.WriteLine("Average:" + avg);
               
           }
        static void Main(string[] args)
        {
            int[] nos = { 10, 20, 30, 41 };
            int larger = nos.Length;
            Program p = new Program();
            Console.WriteLine(Printlargest(nos, larger));
            p.Printsumof(nos);
            p.Printaverage(nos);

        }
    }
}
