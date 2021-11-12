using System;


namespace DisplayName
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the firstName:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the middleName:");
            string middleName = Console.ReadLine();
            Console.WriteLine("Enter the lastName:");
            string lastName = Console.ReadLine();

            Console.Write(" " +firstName + " " +middleName + " " +lastName);
           
        }
    }
}
