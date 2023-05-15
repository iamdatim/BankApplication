using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace BankApp_Methods
{
    public class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string AccountNumber { get; set; }
        public List<BankAccountDetails> AccDetails { get; set; } = new List<BankAccountDetails>();

       
        public User Register(List<User> Users, string username, string email, string password)
        {
            User newUser = new User { UserName = username, Email = email, Password = password };
            Users.Add(newUser);
            return newUser;
        }
    }
}
