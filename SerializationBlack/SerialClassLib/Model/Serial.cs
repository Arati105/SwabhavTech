using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serialization.Model
{
     [Serializable]
   public  class Serial
    {
        private int _id;
        private string _name;
        private string _address;
       

        public Serial(int EmpId,string Empname,string EmpAddress)
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
