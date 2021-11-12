using StudentEncapsulationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEncapsulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s;
            s = new Student();
            s.SetId(101);
            Console.WriteLine("Student Id:" + s.GetId());
            s.SetName("Arati");
            Console.WriteLine("Student Name:" + s.GetName());
            s.SetCgpa(8.5);
            Console.WriteLine("Student Cgpa:" + s.GetCgpa());
            Console.WriteLine("Student Percentage:" + s.CalculatePercentage());
            Console.WriteLine("Grade:" + s.GetGrade());
          


        }
       
       
    }
}
