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
            DateTime addedDate = new DateTime(2021, 04, 06);
            int stockLimit = 500;
            DateTime expirationDate;
            int productQuantity = 500;

            Console.WriteLine("Welcome to Inventory System");
            Console.WriteLine("Available Product: " + productName);

            Console.Write("Type q if you want to view quantity or b if you want to buy: ");
            string optionSelected = Console.ReadLine().ToLower();
 
            if (optionSelected.Equals("q"))
            {
                Console.WriteLine(productQuantity);
            }
            else if(optionSelected.Equals("b")){
                Console.WriteLine("How many would you like to buy?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                productQuantity -= quantity;
                //productQuantity = productQuantity - quantity
            } else
            {
                Console.WriteLine("Error: Invalid option");
            }
        }
    }
}
