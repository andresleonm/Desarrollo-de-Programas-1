using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class OrderDetail
    {
        private List<Product> products { get; set; }
        private List<int> quantities { get; set; }

        public OrderDetail(List<Product> products, List<int> quantities)
        {
            this.products = products;
            this.quantities = quantities;
        }
    }
}
