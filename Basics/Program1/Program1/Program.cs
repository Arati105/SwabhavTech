using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInfo("Arati");
            PrintInfo(100);
            PrintInfo(10.5);
            PrintInfo(10.5f);
            PrintInfo(true);
            PrintInfo('#');
            

        }
        static void PrintInfo(string content)
        {
            Console.WriteLine("overload1 (string)");
            Console.WriteLine(content);
            int nameLength = content.Length;
            Console.WriteLine("Name Length : "+ nameLength);
        }
        static void PrintInfo(int content1)
        {
            Console.WriteLine("Overload2 (Integer)");
            Console.WriteLine(content1);
        }
        static void PrintInfo(double content2)
        {
            Console.WriteLine("Overload3 (double)");
            Console.WriteLine(content2);
        }
        static void PrintInfo(float content3)
        {
            Console.WriteLine("Overload4 (float)");
            Console.WriteLine(content3);
        }
        static void PrintInfo(Boolean content4)
        {
            Console.WriteLine("overload5 (boolean)");
            Console.WriteLine(content4);
        }
        static void PrintInfo(char content5)
        {
            Console.WriteLine("overload6 (character)");
            Console.WriteLine(content5);
        }
    }
}
