using SetGeneric.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SetGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
           // CaseStudy();
            CaseStudy1();
        }
            private static void CaseStudy()
            {
                HashSet<int> nos = new HashSet<int>();
                nos.Add(10);
                nos.Add(200);
                nos.Add(5);
                nos.Add(5);
                nos.Add(300);
                Console.WriteLine("Count:" + nos.Count());
                //Console.WriteLine(nos.Count());
                foreach (int item in nos)
                {
                    Console.WriteLine(item);
                }
            }
        private static void CaseStudy1()
        {
            
            Student s1=new Student(101, "Arati", "Pune");
            Console.WriteLine(s1.GetHashCode());
            Student s2=new Student(101, "Arati", "Pune");
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s1.Equals(s2));
            HashSet<Student> students = new HashSet<Student>();
            students.Add(s1);
            students.Add(s2);
            Console.WriteLine("Count:" + students.Count());
           // Console.WriteLine(students.Count());
        }
        
    }
}
