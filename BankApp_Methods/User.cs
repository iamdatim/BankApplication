using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace BankApp_Methods
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Password { get; set; }
        public List<Account> Accounts { get; set; } = new List<Account>();
        public List<ContactDetails> Contact { get; set; } = new List<ContactDetails>();

       
        public User Register(List<User> Users, string username, string email, string password)
        {
            User newUser = new User { UserName = username, Email = email, Password = password };
            Users.Add(newUser);
            return newUser;
        }
    }
}
