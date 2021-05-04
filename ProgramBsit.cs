using System;
using System.Collections.Generic;

namespace InventorySystem
{
    class ProgramBsit
    {
        private static List<string> logs = new List<string>();
        private static List<string> actionsDescription = new List<string>()
                { "'q' view product quantity",
                  "'b' buy product",
                  "'i' view product information",
                  "'e' exit application",
                  "'l' to show logs"};
        private static List<char> actions = new List<char>() { 'q', 'b', 'i', 'e', 'l' };

        static void Main(string[] args)
        {
            //variables(data type, variablename)
            string productCode = "00711";
            string productName = "Ballpen";
            string productCategory = "School Supplies";
            string productBrand = "Panda";
            string productDescription = "A very useful tool";
            DateTime productDateAdded = new DateTime(2021, 04, 06);
            int stockLimit = 500;
            DateTime expirationDate;
            int productQuantity = 500;


            Console.WriteLine("WELCOME TO INVENTORY SYSTEM");
            Console.WriteLine($"(only) Available Product (for now): {productName} \n");

            for (var userInput = GetUserInputIndexValue();
                userInput != actions.IndexOf('e');
                userInput = GetUserInputIndexValue())
            {
                var message = string.Empty;
                if (userInput.Equals(actions.IndexOf('q')))
                {
                    message = "Available Quantity: " + productQuantity;
                    Console.WriteLine($"OUTPUT: \n\t{message}\n");
                    AddResultLog(message);
                }
                else if (userInput.Equals(actions.IndexOf('b')))
                {
                    productQuantity = BuyAProduct(productQuantity);
                    message = $"Succes! Remaining Available quantity: {productQuantity}";
                    Console.WriteLine($"OUTPUT: \n\t{message}\n");
                    AddResultLog(message);
                }
                else if (userInput.Equals(actions.IndexOf('i')))
                {
                    //We will not refactor this portion for now...
                    Console.WriteLine("***PRODUCT INFORMATION***");
                    Console.WriteLine("Code: " + productCode);
                    Console.WriteLine("Name: " + productName);
                    Console.WriteLine("Brand: " + productBrand);
                    Console.WriteLine("Description: " + productDescription);
                    Console.WriteLine("Category: " + productCategory);
                    Console.WriteLine("Date Added: " + productDateAdded.ToShortDateString());
                }
                else if (userInput.Equals(actions.IndexOf('l')))
                {
                    ShowLogs();
                }
            }

            Console.WriteLine("Program Exiting..");
        }

        static void ShowUserOptions()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("USER OPTIONS: PLEASE INPUT ANY OF THE FOLLOWING OPTIONS..");

            foreach (var decription in actionsDescription)
            {
                Console.WriteLine(decription);
            }
        }

        static int GetUserInputIndexValue()
        {
            ShowUserOptions();
            Console.Write("INPUT: ");
            var action = (Convert.ToChar(Console.ReadLine().ToLower()));
            var actionIndex = actions.IndexOf(action);

            if (actionIndex != -1)
            {
                AddActionLog(action);
                return actionIndex;
            }
            else
            {
                AddActionLog(action.ToString());
                var message = "INVALID INPUT. Please try again.";
                Console.WriteLine(message);
                AddResultLog(message);
                return GetUserInputIndexValue();
            }
        }

        static int BuyAProduct(int available)
        {
            var remaining = available;
            Console.Write("quantity to buy: ");
            var buyQty = Convert.ToInt32(Console.ReadLine());
            AddActionLog($"Buy Qty: {buyQty}. ");

            if (buyQty < available)
            {
                remaining -= buyQty;
                return remaining;
            }
            else
            {
                var message = $"Not enough available quantity. Only {available} is available. Please try again.";
                Console.Write(message);
                AddResultLog(message);
                return BuyAProduct(available);
            }
        }

        static void AddActionLog(char action)
        {
            AddLog($"USER ACTION: {actionsDescription[actions.IndexOf(action)]}");
        }

        static void AddActionLog(string message)
        {
            AddLog($"USER ACTION: {message}");
        }

        static void AddResultLog(string result)
        {
            AddLog($"RESULT: {result}");
        }

        static void AddLog(string message)
        {
            logs.Add($"[{DateTime.Now.ToString()}]: {message}");
        }

        static void ShowLogs()
        {
            foreach (var log in logs)
            {
                Console.WriteLine($"\t{log}");
            }
        }
    }
}
