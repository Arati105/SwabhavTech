using InheritanceApp.Model;
using System;

namespace InheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            //CaseStudy4();
            CaseStudy5();
        }
        private static void CaseStudy1()
        {
            Console.WriteLine("CS1");
            Man x = new Man();
            x.Read();
            x.Walk();
            x.Play();
        }
        private static void CaseStudy2()
        {
            Console.WriteLine("CS2");
            Boy y = new Boy();
            y.Play();
            y.jump();
            


        }
        private static void CaseStudy3()
        {
            Console.WriteLine("CS3");
            Man x;
            x=new Boy();
            x.Read();
            x.Play();
            x.Walk();

        }
        private static void CaseStudy4()
        {
            AtThePark(new Man());
            AtThePark(new Kid());
            AtThePark(new Infant());
            AtThePark(new Boy());
        }
        

        private static void AtThePark(Man x)
        {
            Console.WriteLine("At the Park");
            x.Play();
            throw new NotImplementedException();
        }

        private static void CaseStudy5()
        {
            Object x;
            x = 10;
            Console.WriteLine(x.GetType());
            x = "Hello World";
            Console.WriteLine(x.GetType());
            x = 10.55f;
            Console.WriteLine(x.GetType());
            x = new Man();
            Console.WriteLine(x.GetType());
        }

        
    }
}
