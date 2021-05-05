using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.BL
{
    public class Product
    {
        static int numberOfProduct;

        public Product() //default constructor ng isang class
        {
            numberOfProduct++;
            this._productID = "PRD-" + numberOfProduct;
        }
        private string _productID;

        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public ProductUnitType UnitType { get; set; }

        public string ProductID
        {
            get
            {
                return _productID;
            }
        }
    }
}
