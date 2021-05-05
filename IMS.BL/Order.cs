using System;
using System.Collections.Generic;

namespace IMS.BL
{
    public class Order
    {
        private List<Product> _orderedItems = new List<Product>();
        private DateTime _receivedDate;

        public DateTime ReceivedDate
        {
            get
            {
                return _receivedDate;
            }
        }

        public void ReceiveOrder()
        {
            if (_orderedItems.Count > 0)
            {
                Inventory.AddItems(_orderedItems);
                this._receivedDate = DateTime.Now;
            }
        }

        //public DateTime ReceivedDate { get; set; }
        public DateTime OrderedDate { get; set; }

        public string OrderID { get; set; }

        private int _totalQuantity;
        public int TotalQuantity
        {
            get { return GetAllQuantity(); }
        }

        private double _totalPrice;
        public double TotalPrice
        {
            get { return GetTotalPrice(); }
        }

        private string _address;
        public string Address
        {
            get
            {
                return !string.IsNullOrEmpty(_address) ? _address : "Main Branch";
            }
            set
            {
                _address = !string.IsNullOrEmpty(value) ? value : "Main Branch";
            }
        }

        public void AddOrderItem(Product product)
        {
            if (product.Quantity > 0)
            {
                _orderedItems.Add(product);
            }
        }
        private int GetAllQuantity()
        {
            var totalQuantity = 0;
            foreach (var item in _orderedItems)
            {
                totalQuantity += item.Quantity;
            }
            return totalQuantity;
        }

          private double GetTotalPrice()
        {
            var totalPrice = 0.0;
            foreach (var item in _orderedItems)
            {
                totalPrice += (item.Quantity * item.Price);
            }
            return totalPrice;
        }

        public List<Product> GetOrderItems()
        {
            return _orderedItems;
        }
        
    }
}
