using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceApp.Model
{
    class Boy:Man
    {
        public void Play()
        {
            Console.WriteLine("Jumping");
        }
        public override void jump()
        {
            Console.WriteLine("Playing");
        }
        public void Walk()
        {
            Console.WriteLine("Boy");
        }
        public void Read()
        {
            Console.WriteLine("Reading");
        }
       
    }
}
