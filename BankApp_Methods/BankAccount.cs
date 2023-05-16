using System;
using System.Collections.Generic;

namespace BankApp_Methods
{
    public class BankAccount
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string StateOfOrigin { get; set; }
        public string LocalGovernmentOfOrigin { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public string Nationality { get; set; }
        public string PhoneNumber { get; set; }
        public string AccountType { get; set; }
        public string Occupation { get; set; }
        public Guid UserId { get; set; }


        public BankAccount CreateAccount(List<BankAccount> UsersBankAccount, string firstname, string lastname, string middlename,
           string email, string address, string city, string state, int postalcode, string country,
           string nationality, string stateoforigin, string localgovernmentoforigin, string phonenumber, string accounttype, string ocuppation)
        {
            BankAccount newBankAccount = new BankAccount
            {
                FirstName = firstname,
                LastName = lastname,
                MiddleName = middlename,
                Email = email,
                Address = address,
                City = city,
                State = state,
                PostalCode = postalcode,
                Country = country,
                Nationality = nationality,
                StateOfOrigin = stateoforigin,
                LocalGovernmentOfOrigin = localgovernmentoforigin,
                PhoneNumber = phonenumber,
                AccountType = accounttype,
                Occupation = ocuppation
            };

            UsersBankAccount.Add(newBankAccount);
            return newBankAccount;

        }
    }
}
