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
        public void UserLogin(List<User> Users, List<BankAccount> UsersBankAccount)
        {
            Header.HeaderDisplay("Login Page");

            MenuMessage.DisplayActionMessage("Please enter your username: ");
            string username = Console.ReadLine();
            int value;
            while (Validation.EmptyString(username) || !Validation.TryParseInt(username, out value))
            {
                if (Validation.EmptyString(username))
                {
                    Header.HeaderDisplay();
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not be empty", "Please enter a valid username:");
                    username = Console.ReadLine();
                }

                else if (!Validation.TryParseInt(username, out value))
                {
                    Header.HeaderDisplay();
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not contain number", "Please enter a valid username:");
                    username = Console.ReadLine();
                }
            }
            Console.Clear();

            Header.HeaderDisplay("Login Page");
            MenuMessage.DisplayActionMessage("Please enter your Password: ");
            string password = Console.ReadLine();
            while (Validation.EmptyString(password) || !Validation.IsValidPassword(password))
            {
                if (Validation.EmptyString(password))
                {
                    MenuMessage.DisplayErrorMessage("Password Shouldn't not be empty", "Please enter a valid password:");
                    password = Console.ReadLine();
                }

                else if (!Validation.IsValidEmail(password))
                {
                    MenuMessage.DisplayErrorMessage("Password Requiremnet not met, Your Password must contain \nat least 1 Uppercase, Lowercase and Number", "Please enter a valid password:");
                    password = Console.ReadLine();
                }
            }

           // User currentUser = users.FirstOrDefault(x => x.Username == loginUsername && x.Password == loginPassword);
            User LoggedInUser = loginManager.Login(Users, username, password);

           // Header.HeaderDisplay("Login Page");
            if (LoggedInUser != null)
            {
                Animation.LoginLoading();
                Header.HeaderDisplay("Datim Bank Plc");
                //MenuMessage.DisplaySucessMessage("Login Sucessful");
                while (true)
                {
                    // Header.HeaderDisplay("Datim Bank Plc");
                    Console.WriteLine(MenuMessage.LoginEntryMenu);

                    string choice = Console.ReadLine();
                    Console.Clear();

                    int type;
                    while (Validation.TryParseInt(choice, out type))
                    {
                        Header.HeaderDisplay();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{choice} {MenuMessage.IntErrorMessage}");
                        Console.ResetColor();
                        Console.WriteLine($"{MenuMessage.ValidOptionMessage}");
                        Console.WriteLine(MenuMessage.LoginEntryMenu);
                        //Console.WriteLine(MenuMessage.EnterOption);
                        choice = Console.ReadLine();
                    }


                   // Console.Clear();

                    switch (choice)
                    {
                        case "1":
                            BankAccountRegistrationPage.BankAccountRegistration(UsersBankAccount, LoggedInUser);
                            break;

                        case "2":
                            LoginPage loginpage = new LoginPage();
                            loginpage.UserLogin(Users, UsersBankAccount);
                            break;

                        case "3":
                            Environment.Exit(0);
                            break;

                        default:
                            Header.HeaderDisplay();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{choice} {MenuMessage.IntErrorMessage}");
                            Console.ResetColor();
                            break;
                    }
                }
            }

            else
            {
                MenuMessage.DisplayErrorMessage("User Does not exist", "Kindly register an account to be able to login");
            }

            
        }
    }
}