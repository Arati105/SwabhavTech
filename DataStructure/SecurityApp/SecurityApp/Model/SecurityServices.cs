using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityApp.Model
{
    class SecurityServices
    {
        Dictionary<string, User> userDictionary;
        User user;
        public SecurityServices()
        {
            userDictionary = new Dictionary<string, User>();
        }
        public void AddUser(string id, string firstname, string lastname, string email, string password)
        {
            user = new User(id, firstname, lastname, email, password);
            userDictionary.Add(id, user);
        }
        public User Login(string id,string password)
        {
            foreach(KeyValuePair<string,User> iterateUser in userDictionary)
            {
                if(id == iterateUser.Key && password == iterateUser.Value.Password)
                {
                    Console.WriteLine("Login Successfully");
                    return user;
                }
            }
            throw new Exception("Invalid credentials");
            return null;
        }
    }
}
