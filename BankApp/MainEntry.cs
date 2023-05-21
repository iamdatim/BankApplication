using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;
using BankApp_Methods;

namespace BankApp
{
    internal class MainEntry
    {
       // public static List<BankAccount> UsersBankAccount { get; private set; }

        public static void Entry()
        {
            List<User> Users = new List<User>();
            List<Account> Accounts = null;
           // List<BankAccount> UsersBankAccount = new List<BankAccount>();

            Header.HeaderDisplay("Datim Bank Plc");
            while (true)
            {
               // Header.HeaderDisplay("Datim Bank Plc");
                Console.WriteLine(MenuMessage.MainEntryMenu);

                string choice = Console.ReadLine();
                Console.Clear();

                int value;
                while (Validation.TryParseInt(choice, out value))
                {
                    Header.HeaderDisplay();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{choice} {MenuMessage.IntErrorMessage}");
                    Console.ResetColor();
                    Console.WriteLine($"{MenuMessage.ValidOptionMessage}");
                    Console.WriteLine(MenuMessage.MainEntryMenu);
                    //Console.WriteLine(MenuMessage.EnterOption);
                    choice = Console.ReadLine();
                }


                Console.Clear();

                switch (choice)
                {
                    case "1":
                        RegistrationPage.Registration(Users);
                        break;

                    case "2":
                        LoginPage loginpage = new LoginPage();
                        loginpage.UserLogin(Users, Accounts);
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
    
    }
}
