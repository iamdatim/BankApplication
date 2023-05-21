using System;
using System.Collections.Generic;

namespace BankApp_Methods
{
    public  class Account
    {
        public Guid Id { get; set; }
        public string AccountNumber { get; set; }
        
        public string Email { get; set; }
        
        
        
        public string AccountType { get; set; }
        public string Occupation { get; set; }
        public Guid UserId { get; set; }


        public Account CreateAccount(List<Account> UsersBankAccount, User LoggedInUser, string firstname, string lastname, string middlename,
           string email, string address, string city, string state, int postalcode, string country,
           string nationality, string stateoforigin, string localgovernmentoforigin, string phonenumber, string accounttype, string ocuppation)
        {
            Account newBankAccount = new Account
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

            LoggedInUser.Accounts.Add(newBankAccount);
            return newBankAccount;

        }
    }
}
