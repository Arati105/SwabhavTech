using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePolymorphism.Model
{
    class Manager:Employee
    {
        
        public Manager(int empno, string name, double salary):base(empno,name,salary)
        {
           
        }
        public override void CalculateSalary()
        {
            Hra = base.Salary * 50 / 100;
            ta = base.Salary * 40 / 100;
            da = base.Salary * 30/ 100;
            
            
        }
       
    

        
       
    }
}
