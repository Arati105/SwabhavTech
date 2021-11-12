using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = Convert.ToInt32(args[0]);
            for (int i=0;i<p;i++)
            {
                if (i % 2 == 0)
                {

                    Console.WriteLine(i);
                }
            }


            }
           
            
        }
    }


