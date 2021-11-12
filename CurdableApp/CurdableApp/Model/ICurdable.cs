using System;
using System.Collections.Generic;
using System.Text;

namespace CurdableApp.Model
{
    public interface ICurdable
    {
        public void Create()
        {
            Console.WriteLine("Created..");
        }
        public void Read()
        {
            Console.WriteLine("Read..");
        }
        public void Update()
        {
            Console.WriteLine("Update..");
        }
        public void Delete()
        {
            Console.WriteLine("Delete..");
        }
    }
}
