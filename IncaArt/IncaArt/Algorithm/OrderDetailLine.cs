using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Algorithm
{
    class OrderDetailLine
    {

        public Product product { get; set; }
        public int quantity { get; set; }

        public OrderDetailLine()
        {

        }

        public OrderDetailLine(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }

    }
}
