using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class ProductionOrderMaterialLine
    {
        private int order_Id;
        private int id;
        private Material material;
        private int quantity_required;
        private int quantity_taken_real;
        private string status;
        private Recipe recipe;

        public ProductionOrderMaterialLine()
        {

        }

        public int Order_Id
        {
            get
            {
                return order_Id;
            }

            set
            {
                order_Id = value;
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

        public int Quantity_required
        {
            get
            {
                return quantity_required;
            }

            set
            {
                quantity_required = value;
            }
        }

        public int Quantity_taken_real
        {
            get
            {
                return quantity_taken_real;
            }

            set
            {
                quantity_taken_real = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        internal Recipe Recipe
        {
            get
            {
                return recipe;
            }

            set
            {
                recipe = value;
            }
        }
    }
}
