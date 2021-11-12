using System;


namespace CommandLineArgsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(valuesPassed.Length);
           Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " +name);
        }
    }
}
