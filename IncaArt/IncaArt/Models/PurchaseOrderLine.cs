using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class PurchaseOrderLine
    {        
        Material material;
        int quantity;
        double price;

        public PurchaseOrderLine(Material material, int quantity, double price)
        {            
            this.material = material;
            this.quantity = quantity;
            this.price = price;            
        }
    }
}
