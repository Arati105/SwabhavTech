using InheritanceConstructorApp2.Model;
using System;

namespace InheritanceConstructorApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Child c1 = new Child();
            Console.WriteLine(c1.GetFoo());

            Child c2 = new Child();
            Console.WriteLine(c2.GetFoo());

            Child c3 = new Child(300);
            Console.WriteLine(c3.GetFoo());
        }
    }
}
