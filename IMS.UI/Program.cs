using IMS.BL;
using System;

namespace IMS.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nag oorder
            Order myFirstOrder = new Order();
            myFirstOrder.OrderID = "ORDER111";
            myFirstOrder.Address = "Carmona Branch";
            myFirstOrder.OrderedDate = DateTime.Now;

            Product coffee = new Product();
            coffee.Description = "Kopiko Brown";
            coffee.Quantity = 12;
            coffee.UnitType = ProductUnitType.Sachet;
            coffee.Price = 6;

            Product bread = new Product();
            bread.Description = "Gardenia Loaf Bread";
            bread.Quantity = 5;
            bread.UnitType = ProductUnitType.Pack;
            bread.Price = 60;

            myFirstOrder.AddOrderItem(coffee);
            myFirstOrder.AddOrderItem(bread);

            Console.WriteLine("Here are your order details");
            Console.WriteLine($"ORDER Number: {myFirstOrder.OrderID}");
            Console.WriteLine($"ORDER Date: {myFirstOrder.OrderedDate}");
            Console.WriteLine($"ORDER Address: {myFirstOrder.Address}");

            Console.WriteLine("\nItems ordered...");
            foreach (var item in myFirstOrder.GetOrderItems())
            {
                Console.WriteLine($"ITEM ID: {item.ProductID}");
                Console.WriteLine($"ITEM Description: {item.Description}");
                Console.WriteLine($"ITEM Unit Type: {item.UnitType}");
                Console.WriteLine($"ITEM Quantity: {item.Quantity}");
                Console.WriteLine($"ITEM Price: {item.Price}");
                Console.WriteLine();
            }

            Console.WriteLine($"TOTAL Quality: {myFirstOrder.TotalQuantity}");
            Console.WriteLine($"TOTAL Price: {myFirstOrder.TotalPrice}");


            Console.WriteLine("Ready to received the ordered items...");
            myFirstOrder.ReceiveOrder();

            Console.WriteLine("ALL Products in Inventory");

            foreach (var item in Inventory.GetAllInventoryItems())
            {
                Console.WriteLine($"Inventory Item: {item.Description}");
            }
        }
    }
}
