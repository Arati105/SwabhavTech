using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceApp.Model
{
    class Man
    {
        public void Walk()
        {
            Console.WriteLine("Walking");
        }
        public virtual void Play()
        {
            Console.WriteLine("Playing");
        }
        public void Read()
        {
            Console.WriteLine("reading");
        }
        public virtual void jump()
        {

        }


    }
}
