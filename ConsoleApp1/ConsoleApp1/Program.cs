using ConsoleApp1.Model;
using System;
using static ConsoleApp1.Model.Shape;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle();
            Console.WriteLine("Area :" + circle.Area());

            Shape square = new Square();
            Console.WriteLine("Area :" + square.Area());

            Shape rectangle = new Rectangle();
            Console.WriteLine("Area :" + rectangle.Area());


        }
    }
}
