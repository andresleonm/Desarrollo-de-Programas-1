using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class PurchaseOrderLine
    {        
        Material material;
        int quantity;
        double price;

        public Material Material
        {
            get
            {
                return material;
            }

            set
            {
                material = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public PurchaseOrderLine()
        {

        }
        public PurchaseOrderLine(Material material, int quantity, double price)
        {            
            this.material = material;
            this.quantity = quantity;
            this.price = price;            
        }
    }
}
