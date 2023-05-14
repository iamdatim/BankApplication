using System;
using System.Collections.Generic;
using System.Text;
using BankApp_Methods;

namespace BankApp
{
    internal class RegistrationPage
    {
        public static void Registration(List<User> Users)
        {

            User user = new User();
            Header.HeaderDisplay("Registration Page");


            MenuMessage.DisplayActionMessage("Please enter your username: ");
            string username = Console.ReadLine();
            int value;
            while (Validation.EmptyString(username) || !Validation.TryParseInt(username, out value))
            {
                if (Validation.EmptyString(username))
                {
                    //Header.HeaderDisplay();
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

            Header.HeaderDisplay("Registration Page");
            MenuMessage.DisplayActionMessage("Please enter your Email: ");
            string email = Console.ReadLine();
            while (Validation.EmptyString(email) || !Validation.IsValidEmail(email))
            {
                if (Validation.EmptyString(email))
                {
                    MenuMessage.DisplayErrorMessage("email Shouldn't not be empty", "Please enter a valid email:");
                    email = Console.ReadLine();
                }

                else if (!Validation.IsValidEmail(email))
                {
                    MenuMessage.DisplayErrorMessage("Not a valid email format", "Please enter a valid email:");
                    email = Console.ReadLine();
                }
            }
            Console.Clear();

            Header.HeaderDisplay("Registration Page");
            MenuMessage.DisplayActionMessage("Please enter your Password: ");
            string password = Console.ReadLine();
            while (Validation.EmptyString(password) || !Validation.IsValidPassword(password))
            {
                if (Validation.EmptyString(password))
                {
                    MenuMessage.DisplayErrorMessage("Password Shouldn't not be empty", "Please enter a valid password:");
                    password = Console.ReadLine();
                }

                else if (!Validation.IsValidPassword(password))
                {
                    MenuMessage.DisplayErrorMessage("Password Requiremnet not met, Your Password must contain \nat least 1 Uppercase, Lowercase and Number", "Please enter a valid password:");
                    password = Console.ReadLine();
                }
            }

            Header.HeaderDisplay("Registration Page");
            MenuMessage.DisplayActionMessage("Please confirm your Password: ");
            string ConfirmPassword = Console.ReadLine();
            while (ConfirmPassword != password)
            {
                MenuMessage.DisplayErrorMessage("Password does not match", "Please enter the correct password:");
                ConfirmPassword = Console.ReadLine();
            }

            User newUser = user.Register(Users, username, email, password);
            Users.Add(newUser);

            MenuMessage.DisplaySucessMessage("Registration Sucessful");

            if (Validation.UserExists(Users, user))
            {
                Console.WriteLine("User already exists!");
            }
            //else
            //{
            //    Console.WriteLine("User does not exist.");
            //}
        }
    }
}
