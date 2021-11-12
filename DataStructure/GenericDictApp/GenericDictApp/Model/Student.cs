using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictApp.Model
{
    class Student
    {
        int _rollno;
        private int s;
        string _name;
        string _location;

        public Student(int rollno, int s,string name, string location)
        {
            this._rollno = rollno;
            this.s = s;
            this._name = name;
            this._location = location;
        }
        public override int GetHashCode()
        {
            string hashCode = Convert.ToString(_rollno) + Convert.ToString(s);
            return int.Parse(hashCode);
        }
        public override bool Equals(object obj)
        {
            Student studentObj = (Student)obj;
            if (this._rollno == studentObj._rollno && this.s == studentObj.s) return true;
            return false;
        }
    }
}
