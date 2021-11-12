using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteAppend
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamWriter w = File.AppendText("E:/demo.txt"))
                {
                    w.WriteLine("This is new line in text file");
                    w.WriteLine("This is the end line");
                    Console.WriteLine("Append works");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.Read();
        }
    }
}
