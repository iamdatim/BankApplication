using System;
using System.Collections.Generic;

namespace BankApp_Methods
{
    public abstract class Account
    {
        public Guid Id { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; protected set; }
        public User Owner { get; set; }
        public Guid UserId { get; set; }
    }
}
