using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankApp_Methods;

namespace BankApp
{
    internal class LoginPage
    {
        private LoginManager loginManager = new LoginManager();
        public void UserLogin()
        {
            Header.HeaderDisplay("Login Page");

            MenuMessage.DisplayActionMessage("Please enter your username: ");
            string loginusername = Console.ReadLine();
            int value;
            while (Validation.EmptyString(loginusername) || !Validation.TryParseInt(loginusername, out value))
            {
                if (Validation.EmptyString(loginusername))
                {
                    Header.HeaderDisplay();
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not be empty", "Please enter a valid username:");
                    loginusername = Console.ReadLine();
                }

                else if (!Validation.TryParseInt(loginusername, out value))
                {
                    Header.HeaderDisplay();
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not contain number", "Please enter a valid username:");
                    loginusername = Console.ReadLine();
                }
            }
            Console.Clear();

            Header.HeaderDisplay("Login Page");
            MenuMessage.DisplayActionMessage("Please enter your Password: ");
            string loginpassword = Console.ReadLine();
            while (Validation.EmptyString(loginpassword) || !Validation.IsValidPassword(loginpassword))
            {
                if (Validation.EmptyString(loginpassword))
                {
                    MenuMessage.DisplayErrorMessage("Password Shouldn't not be empty", "Please enter a valid password:");
                    loginpassword = Console.ReadLine();
                }

                else if (!Validation.IsValidEmail(loginpassword))
                {
                    MenuMessage.DisplayErrorMessage("Password Requiremnet not met, Your Password must contain \nat least 1 Uppercase, Lowercase and Number", "Please enter a valid password:");
                    loginpassword = Console.ReadLine();
                }
            }

            User LoggedInUser = loginManager.Login(loginusername, loginpassword);

            Header.HeaderDisplay("Login Page");
            if (LoggedInUser != null)
            {
                MenuMessage.DisplaySucessMessage("Login Sucessful");
            }

            else
            {
                MenuMessage.DisplayErrorMessage("User Does not exist", "Kindly register an account to be able to login");
            }
        }
    }
}