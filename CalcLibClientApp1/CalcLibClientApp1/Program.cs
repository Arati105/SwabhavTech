using AdvaitCalcLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcLibClientApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.CubeEvenNumber(4);
            Console.WriteLine("Even number:" + c.CubeEvenNumber(2));
            Console.ReadLine();

        }
    }
}
