using HumanEnumApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanEnumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Human h = new Human("Arati", 150 ,50,GenderType.FEMALE);
            printDetail(h);
            h.Eat();
            h.Workout();
            printDetail(h);
            Console.ReadLine();
        }
        static void printDetail(Human h)
        {
            Console.WriteLine("Name:"+h.GetName());
            Console.WriteLine("height:"+h.GetHeight());
            Console.WriteLine("Weight:"+h.GetWeight());
            Console.WriteLine("Gender:"+h.GetGender());
            Console.WriteLine();
          
         }
    }
}
