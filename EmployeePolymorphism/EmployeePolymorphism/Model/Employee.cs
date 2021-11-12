using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePolymorphism.Model
{
   abstract class Employee
    {
         int _empno;
         string _name;
         double _basicsalary;
        public double Hra;
        public double ta;
        public double da;
        public double pa;
        public double perks;

        public Employee(int empno,string name,double salary)
        {
            this._empno = empno;
            this._name = name;
            this._basicsalary = salary;
        }
        public abstract void CalculateSalary();
        public int Empno
        {
            get
            {
                return _empno;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double Salary
        {
            get
            {
                return _basicsalary;
            }
        }
    }
}
