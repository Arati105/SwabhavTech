using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceConstructorApp.Model
{
    class Child:Parent
    {
        public Child():base()
        {
            Console.WriteLine("Child Created");
        }
    }
}
