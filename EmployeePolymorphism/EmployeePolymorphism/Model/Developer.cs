using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePolymorphism.Model
{
    class Developer:Employee
    {
       
        public Developer(int empno, string name, double salary) : base(empno, name, salary)
        {

        }
        public override void CalculateSalary()
        {
            pa =base.Salary * 40 / 100;
            da = base.Salary * 30 / 100;
        }
    }
}
