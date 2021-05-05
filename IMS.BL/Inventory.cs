using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.BL
{
    public class Inventory
    {
        static private List<Product> _inventoryItems = new List<Product>();
        static public void AddItem(Product item)
        {
            _inventoryItems.Add(item);
        }

        static public void AddItems(List<Product> items)
        {
            _inventoryItems.AddRange(items);
        }

        static public List<Product> GetAllInventoryItems()
        {
            return _inventoryItems;
        }
    }
}
