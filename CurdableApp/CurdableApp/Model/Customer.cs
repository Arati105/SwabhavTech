using System;
using System.Collections.Generic;
using System.Text;

namespace CurdableApp.Model
{
    abstract class Customer:ICurdable
    {
        public void Create()
        {
            Console.WriteLine("Customer Created..");
        }
        public abstract void Delete();
        public void Read()
        {
            Console.WriteLine("Customer Read..");
        }
        public abstract void Update();
    }
}
