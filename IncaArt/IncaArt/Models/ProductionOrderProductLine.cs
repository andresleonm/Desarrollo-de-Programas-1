using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class ProductionOrderProductLine
    {
        private int order_Id;
        private int id;
        private Product product;
        private int quantity;
        private int produced_quantity;
        private string state;
        private Recipe recipe;
        private int quantity_warehouse;
        private ProductWarehouse warehouse;

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

        public Product Product
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

        public int Produced_quantity
        {
            get
            {
                return Produced_quantity1;
            }

            set
            {
                Produced_quantity1 = value;
            }
        }


        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public int Produced_quantity1
        {
            get
            {
                return produced_quantity;
            }

            set
            {
                produced_quantity = value;
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

        public int Quantity_warehouse
        {
            get
            {
                return quantity_warehouse;
            }

            set
            {
                quantity_warehouse = value;
            }
        }

        public ProductWarehouse Warehouse
        {
            get
            {
                return warehouse;
            }

            set
            {
                warehouse = value;
            }
        }

        public ProductionOrderProductLine()
        {

        }

    }
}
