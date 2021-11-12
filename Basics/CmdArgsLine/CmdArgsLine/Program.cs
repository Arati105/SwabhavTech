using System;

namespace CmdArgsLine
{
    class Program
    {
        static void Main(string[] args)
        {


            if (args.Length > 0)
            {
                Console.WriteLine("Arguments Passed");

                //for(int i=0;i<args.Length;i++)
                foreach (string ch in args)
                {
                    Console.WriteLine(ch);
                }
            }
            else
            {
                Console.WriteLine("No arguments Passed");
            }
            


        }
    }

}
