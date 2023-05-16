using BankApp_Methods;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    internal class BankAccountRegistrationPage
    {
        public static void BankAccountRegistration(List<BankAccount> UsersBankAccount, User LoggedInUser)
        {

            BankAccount userBankAccount = new BankAccount();
            Header.HeaderDisplay("Bank Account Registration Page");

            userBankAccount.UserId = LoggedInUser.Id;

            MenuMessage.DisplayActionMessage("Please enter your First Name: ");
            string firstname = Console.ReadLine();

            MenuMessage.DisplayActionMessage("Please enter your Last Name: ");
            string lastname = Console.ReadLine();

            MenuMessage.DisplayActionMessage("Please enter your Middle Name: ");
            string middlename = Console.ReadLine();

            MenuMessage.DisplayActionMessage("Please enter your Email Address: ");
            string email = Console.ReadLine();

            MenuMessage.DisplayActionMessage("Please enter your Home Address: ");
            string address = Console.ReadLine();

            MenuMessage.DisplayActionMessage("Please enter your City: ");
            string city = Console.ReadLine();

            MenuMessage.DisplayActionMessage("Please enter your State: ");
            string state = Console.ReadLine();

            MenuMessage.DisplayActionMessage("Please enter your Postal Code: ");
            int postalcode = int.Parse(Console.ReadLine());

            MenuMessage.DisplayActionMessage("Please enter your Country: ");
            string country = Console.ReadLine();

            MenuMessage.DisplayActionMessage("Please enter your Nationality: ");
            string nationality = Console.ReadLine();

            MenuMessage.DisplayActionMessage("Please enter your State of Origin: ");
            string stateoforigin = Console.ReadLine();

            MenuMessage.DisplayActionMessage("Please enter your Local Government of Origin: ");
            string localgovernmentoforigin = Console.ReadLine();

            MenuMessage.DisplayActionMessage("Please enter your Phone Number: ");
            string phonenumber = Console.ReadLine();

            MenuMessage.DisplayActionMessage("Please enter your Occupation: ");
            string ocuppation = Console.ReadLine();

            MenuMessage.DisplayActionMessage("Please enter Account Type e.g (Savings, Current, Credit): ");
            string accounttype = Console.ReadLine();

            BankAccount newUserBankAccount = userBankAccount.CreateAccount(UsersBankAccount, firstname, lastname, middlename, email, address, city, state, postalcode, country, nationality, stateoforigin, localgovernmentoforigin, phonenumber, ocuppation, accounttype);

            MenuMessage.DisplaySucessMessage(" Bank Account Registration Sucessful");
        }
    }
}
