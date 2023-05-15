using System;

namespace BankApp_Methods
{
    public class AccountRegistrationDetails
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public string Nationality { get; set; }
        public int PhoneNumber { get; set; }
        public string AccountType { get; set; }
        public string Occupation { get; set; }
    }
}
