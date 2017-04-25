using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Product
    {
        private string name { get; set; }
        private int stock { get; set; }
        private double unit_price { get; set; }

        public Product(string name,int stock,double unit_price)
        {
            this.name = name;
            this.stock = stock;
            this.unit_price = unit_price;
        }
    }
}
