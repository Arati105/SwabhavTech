using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAutoGenerate.Model
{
   public class Customer
    {
        public string _id;
         String _name;
         int _salary;
         static int count = 1000;

       

        public Customer(string name,int salary)
        {
            //this._id = id;
            this._name = name;
            this._salary = salary;
            _id = "c" + count.ToString();
            count++;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public int Salary
        {
            get
            {
                return _salary;
            }
        }

        
        
      


        
    }
}
