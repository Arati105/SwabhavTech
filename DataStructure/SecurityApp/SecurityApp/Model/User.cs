using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityApp.Model
{
   public class User
    {
        private string _id;
        private string _firstName, _lastName, _email;
        protected string _password;

        public User(string id,string firstname,string lastname,string email,string password)
        {
            this._id = id;
            this._firstName = firstname;
            this._lastName = lastname;
            this._email = email;
            this._password = password;
        }
        public string Id
        {
            get
            {
                return _id;
            }
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
        }
    }
}
