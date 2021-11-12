using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationSolutionApp.Model
{
    [Serializable]
    class Employee
    {
        private int _id;
        private string _name;
        private string _address;

        public Employee(int EmpId,string Empname,string EmpAddress)
        {
            this._id = EmpId;
            this._name = Empname;
            this._address = EmpAddress;
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
        }

    }
}
