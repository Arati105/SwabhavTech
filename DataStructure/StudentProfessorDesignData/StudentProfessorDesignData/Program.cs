using StudentProfessorDesignData.Model;
using System;

namespace StudentProfessorDesignData
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor p = new Professor(101, "Pune", "12/04/2021", 40000);
            Professor p1 = new Professor(102, "Mumbai", "15/06/2022", 50000);
            Student s = new Student(103, "kolhapur", "15/08/2023", "CSE");
            Student s2 = new Student(104, "UK", "18/07/2024", "Mech");
            PrintDetails(p);
            PrintDetails(p1);
            PrintDetails(s);
            PrintDetails(s2);
        }
        public static void PrintDetails(Person p)
        {
            Console.WriteLine("\nId:" + p.Id);
            Console.WriteLine("Name:" + p.Address);
            Console.WriteLine("Data of Birth:" + p.DateOfBirth);
            Console.WriteLine("Basic Salary:" + p.Basicsalary);
        }
        public static void PrintDetails(Student s)
        {
            Console.WriteLine("\nId:" + s.Id);
            Console.WriteLine("Address:" + s.Address);
            Console.WriteLine("Date of birth:" + s.DateOfBirth);
            Console.WriteLine("Branch:" + s.Branch);
        }
    }
}
