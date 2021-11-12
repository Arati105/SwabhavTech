using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionArrayApp
{
    class Program
    {
        static void UpdateMarkToZero(int pmark)
        {
           
            pmark = 0;
        }
        static void UpdateAllMarksToZero(int[] pmarks)
        {
            /*int temp = 0;
            for(int i=0;i<marks.Length;i++)
            {
                temp = marks[i] + 5;
                marks[i] = temp;
            }*/
            Console.WriteLine(pmarks.GetHashCode());
            for(int i=0;i<pmarks.Length;i++)
            {
                pmarks[i] = 0;
            }
           
          


        }
        static void Main(string[] args)
        {
            int mark = 100;
            
            UpdateMarkToZero(mark);
            Console.WriteLine("mark:"+mark);
            int[] marks = { 10, 20, 30, 40, 50 };
            Console.WriteLine(marks.GetHashCode());
            UpdateAllMarksToZero(marks);
            foreach (int temp in marks)
            {

                Console.WriteLine(temp);

            }

        }
    }
}

