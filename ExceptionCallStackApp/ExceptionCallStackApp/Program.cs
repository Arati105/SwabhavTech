using System;

namespace ExceptionCallStackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                M1();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("End of Main");
           
        }
        
        private static void  M1()
        {
            Console.WriteLine("Inside m1");
            M2();
        }
        private static void  M2()
        {
            Console.WriteLine("\nInside M2");
            M3();
        }
        private static void M3()
        {
            Console.WriteLine("\nInside M3");
            throw new Exception("\nSome thing went worn in M3");
        }
       
    }
}
