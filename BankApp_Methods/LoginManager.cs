using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApp_Methods
{
    public class LoginManager
    {
        public List<User> Users = new List<User>();

        public User Login(string loginusername, string loginpassword)
        {
            foreach(User user in Users)
            {
                if(user.UserName == loginusername && user.Password == loginpassword)
                {
                    return user;
                }
            }

            return  Users.FirstOrDefault(u => u.UserName == loginusername && u.Password == loginpassword);
        }
    }
}
