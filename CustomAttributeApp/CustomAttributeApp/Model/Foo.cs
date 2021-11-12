using System;
using System.Collections.Generic;
using System.Text;

namespace CustomAttributeApp.Model
{
    class Foo
    {
       [NeedToRefactor(Name ="m1")]
        public void M1()
        {
            Console.WriteLine("method 1");
        }
        public void M2()
        {
            Console.WriteLine("method 2");
        }
        [NeedToRefactor(Name ="m3")]
        public void M3()
        {
            Console.WriteLine("method 3");
        }
        [NeedToRefactor(Name ="m4")]
        public void M4()
        {
            Console.WriteLine("method 4");
        }
        public void M5()
        {
            Console.WriteLine("method 5");
        }
        [NeedToRefactor(Name ="m6")]
        public void M6()
        {
            Console.WriteLine("method 6");
        }
    }
}
