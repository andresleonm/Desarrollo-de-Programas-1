using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class ProductWarehouse        
    {
        int id;
        String name;
        int product_id;
        int current_physical_stock;
        int max_capacity;
        int type_id;
        String state;
        int current_logical_stock;


        public ProductWarehouse(int id, string name, int product_id, int current_physical_stock, int max_capacity, int type_id, string state, int current_logical_stock)
        {
            this.Id = id;
            this.Name = name;
            this.Product_id = product_id;
            this.Current_physical_stock = current_physical_stock;
            this.Max_capacity = max_capacity;
            this.Type_id = type_id;
            this.State = state;
            this.Current_logical_stock = current_logical_stock;
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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Product_id
        {
            get
            {
                return product_id;
            }

            set
            {
                product_id = value;
            }
        }

        public int Current_physical_stock
        {
            get
            {
                return current_physical_stock;
            }

            set
            {
                current_physical_stock = value;
            }
        }

        public int Max_capacity
        {
            get
            {
                return max_capacity;
            }

            set
            {
                max_capacity = value;
            }
        }

        public int Type_id
        {
            get
            {
                return type_id;
            }

            set
            {
                type_id = value;
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

        public int Current_logical_stock
        {
            get
            {
                return current_logical_stock;
            }

            set
            {
                current_logical_stock = value;
            }
        }

    }
}
