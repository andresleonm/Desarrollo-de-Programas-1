using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class SalesOrderLine
    {
        private Product product;
        private string description;
        private int quantity;
        private double unit_price;

        public Product Product
        {
            get { return product; }
            set { product = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int Quantity
        {
            get{ return quantity; }
            set{ quantity = value; }
        }

        public double Unit_price
        {
            get{ return unit_price; }
            set{ unit_price = value; }
        }

        public SalesOrderLine(Product product, string description, int quantity, double price)
        {
            this.product = product;
            this.description = description;
            this.quantity = quantity;
            this.unit_price = price;
        }

    }
}
