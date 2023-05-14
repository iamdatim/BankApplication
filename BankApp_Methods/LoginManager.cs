using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApp_Methods
{
    public class LoginManager
    {
       // private List<User> Users = new List<User>();

        public User Login(List<User> Users, string username, string password)
        {
            foreach(var user in Users)
            {
                if(user.UserName == username && user.Password == password)
                {
                    return user;
                }

                else
                {
                    return null;
                }
            }

            return  Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
        }
    }
}
