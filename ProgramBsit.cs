using System;

namespace InventorySystem
{
    class ProgramBsit
    {
        static void Main(string[] args)
        {
            //variables (data type, variablename)
            string productCode = "00711";
            string productName = "Ballpen";
            string productCategory = "School Supplies";
            string productBrand = "Panda";
            string productDescription  = "A very useful tool";
            DateTime productDateAdded = new DateTime(2021, 04, 06);
            int stockLimit = 500;
            DateTime expirationDate;
            int productQuantity = 500;

            Console.WriteLine("Welcome to Inventory System");
            Console.WriteLine("Available Product: " + productName);

            Console.WriteLine();
            Console.WriteLine("Please type:");
            Console.WriteLine("\'q\' if you want to view " + productName + "'s quantity.");
            Console.WriteLine("\'b\' if you want to buy " + productName + ".");
            Console.WriteLine("\'i\' if you want to view information about product " + productName + ".");
            Console.WriteLine("\'e\' if you want to exit the program.");
            Console.Write("INPUT: ");
            string optionSelected = Console.ReadLine().ToLower();
            Console.WriteLine();

            for (; optionSelected != "e";)
            {
                if (optionSelected.Equals("q"))
                {
                    Console.WriteLine("Available Quantity: " + productQuantity);
                    Console.WriteLine("-----------------------------------------");
                }
                else if (optionSelected.Equals("b"))
                {
                    Console.Write("How many would you like to buy?: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    productQuantity -= quantity;
                    Console.WriteLine("-----------------------------------------");
                    //productQuantity = productQuantity - quantity
                }
                else if (optionSelected.Equals("i"))
                {
                    Console.WriteLine("***PRODUCT INFORMATION***");
                    Console.WriteLine("Code: " + productCode);
                    Console.WriteLine("Name: " + productName);
                    Console.WriteLine("Brand: " + productBrand);
                    Console.WriteLine("Description: " + productDescription);
                    Console.WriteLine("Category: " + productCategory);
                    Console.WriteLine("Date Added: " + productDateAdded.ToShortDateString());
                    Console.WriteLine("-----------------------------------------");
                }
                else
                {
                    Console.WriteLine("Error: Invalid selection.");
                    Console.WriteLine("-----------------------------------------");
                }

                Console.WriteLine("Please type: \'q\' if you want to view quantity. b if you want to buy: ");
                Console.WriteLine("\'q\' if you want to view " + productName + "'s quantity.");
                Console.WriteLine("\'b\' if you want to buy " + productName + ".");
                Console.WriteLine("\'e\' if you want to exit the program.");
                Console.Write("INPUT: ");
                optionSelected = Console.ReadLine().ToLower();
                Console.WriteLine();
            }

            Console.WriteLine("Program Exiting..");
        }
    }
}
