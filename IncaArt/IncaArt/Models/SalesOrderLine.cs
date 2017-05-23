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

        public string Description { get => description; set => description = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Unit_price { get => unit_price; set => unit_price = value; }
        internal Product Product { get => product; set => product = value; }


        public SalesOrderLine(Product product, string description, int quantity, double price)
        {
            this.Product = product;
            this.Description = description;
            this.Quantity = quantity;
            this.Unit_price = price;
        }

        
    }
}
