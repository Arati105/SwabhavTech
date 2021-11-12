using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGeneric.Model
{
    class Student
    {
        int _rollno;
        string _name;
        string _location;

        public Student(int rollno,string name,string location)
        {
            this._rollno = rollno;
            this._name = name;
            this._location = location;
        }

        public override int GetHashCode()
        {
            return _rollno;
        }
        public override bool Equals(object obj)
        {
            Student studentobj = (Student)obj;
            if (this._rollno == studentobj._rollno) return true;
            return false;
        }
    }
}
