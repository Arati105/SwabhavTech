using System;

namespace StringImmutable
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello World";
            string s2 = s1;
            s2 = "Programming World";
            if(object.ReferenceEquals(s1,s2))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
}
