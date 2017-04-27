using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class OrderDetailLine
    {
        internal Product product { get; set; }
        internal int quantity { get; set; }

        public OrderDetailLine(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
    }
}
