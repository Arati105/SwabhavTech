using EmployeePolymorphism.Model;
using System;

namespace EmployeePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager(101, "Arati", 52000);
            m.CalculateSalary();
            displaySalarySlip(m);
            Developer d = new Developer(102, "Komal", 85000);
            d.CalculateSalary();
            displaySalarySlip(d);
            Accountant a = new Accountant(103, "Seema", 60000);
            d.CalculateSalary();
            displaySalarySlip(a);
            Console.ReadLine();
        }
        private static void displaySalarySlip(Employee e)
        {
            Console.WriteLine("\n**********Employee Details*************");
            Console.WriteLine("Id of employee:" + e.Empno);
            Console.WriteLine("Name of employee:" + e.Name);
            Console.WriteLine("basic Salary of employee:" + e.Salary);
            Console.WriteLine("employee hra:" + e.Hra);
            Console.WriteLine("employee da:" + e.da);
            Console.WriteLine("employee ta:" + e.ta);
            Console.WriteLine("employee perks:" + e.perks);
            
        }
    }
}
