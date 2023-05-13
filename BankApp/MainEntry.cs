using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;
using BankApp_Methods;

namespace BankApp
{
    internal class MainEntry
    {
       
        public static void Entry()
        {
            //Header.HeaderDisplay("Datim Bank Plc");
            while (true)
            {
                Header.HeaderDisplay("Datim Bank Plc");
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
                        RegistrationPage.Registration();
                        break;

                    case "2":
                        //Login.LoginMethod(users, TodoList);
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
