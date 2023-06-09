﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    internal class MenuMessage
    {
        public static readonly string MainEntryMenu = "Please select an option:\n \n1. Register\n2. Login\n3. Exit\n \nYour Option: ";
        public static readonly string LoginEntryMenu = "Please select an option:\n \n1. Create A Bank Account\n2. Buy Airtime\n3. Transfer Money\n \nYour Option: ";
        public static readonly string IntErrorMessage = "is an Invalid Input, your option should not contain alphabet, character.";
        public static readonly string ValidOptionMessage = "Please enter a valid option. eg 1,2,3\n";
        public static readonly string EnterOption = "\nYour Option: ";

        public static void DisplayActionMessage(string message)
        {
            Console.WriteLine($"{message}");
        }

        public static void DisplayErrorMessage(string message, string retryMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: {message}");
            Console.ResetColor();
            Console.WriteLine(retryMessage);
        }

        public static void DisplaySucessMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{message}");
            Console.ResetColor();
        }
    }
}
