using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePolymorphism.Model
{
    class Accountant:Employee
    {

        public Accountant(int empno, string name, double salary) : base(empno, name, salary)
        {

        }
        public override void CalculateSalary()
        {
            perks =base.Salary * 30 / 100;
        }
    }
}
