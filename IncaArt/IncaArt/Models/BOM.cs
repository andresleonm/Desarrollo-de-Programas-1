using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class BOM
    {
        Product product;
        Material material;
        int quantity;
        int id;

        internal Product Product
        {
            get
            {
                return product;
            }

            set
            {
                product = value;
            }
        }

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

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public BOM(int id, Material material, Product product, int quantity)
        {
            this.id = id;
            this.material = material;
            this.product = product;
            this.quantity = quantity;
        }
    }
}
