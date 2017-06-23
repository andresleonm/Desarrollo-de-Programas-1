using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class ProductionOrder
    {
        private int id;
        private string description;
        private string observation;
        private DateTime begin;
        private DateTime end;
        private string state;
        private int product_id;
        private string product_name;
        private int unit_id;
        private string unit_name;
        private int quantity;
        private int produced_quantity;
        private int recipe_id;
        private string recipe_name;
        private int quantity_warehouse;
        private int warehouse_id;
        private string warehouse_name;
        private int estimate_id;
        private int estimate_line;

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

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public string Observation
        {
            get
            {
                return observation;
            }

            set
            {
                observation = value;
            }
        }

        public DateTime Begin
        {
            get
            {
                return begin;
            }

            set
            {
                begin = value;
            }
        }

        public DateTime End
        {
            get
            {
                return end;
            }

            set
            {
                end = value;
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
                return produced_quantity;
            }

            set
            {
                produced_quantity = value;
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

        public string Product_name
        {
            get
            {
                return product_name;
            }

            set
            {
                product_name = value;
            }
        }

        public int Unit_id
        {
            get
            {
                return unit_id;
            }

            set
            {
                unit_id = value;
            }
        }

        public string Unit_name
        {
            get
            {
                return unit_name;
            }

            set
            {
                unit_name = value;
            }
        }

        public int Recipe_id
        {
            get
            {
                return recipe_id;
            }

            set
            {
                recipe_id = value;
            }
        }

        public string Recipe_name
        {
            get
            {
                return recipe_name;
            }

            set
            {
                recipe_name = value;
            }
        }

        public int Warehouse_id
        {
            get
            {
                return warehouse_id;
            }

            set
            {
                warehouse_id = value;
            }
        }

        public string Warehouse_name
        {
            get
            {
                return warehouse_name;
            }

            set
            {
                warehouse_name = value;
            }
        }

        public int Estimate_id
        {
            get
            {
                return estimate_id;
            }

            set
            {
                estimate_id = value;
            }
        }

        public int Estimate_line
        {
            get
            {
                return estimate_line;
            }

            set
            {
                estimate_line = value;
            }
        }

        public ProductionOrder()
        {

        }


     
        public ProductionOrder(string description, string observation, DateTime begin, DateTime end, string state,
            int product_id, string product_name, int unit_of_measure,
            string unit_of_measure_name, int quantity, int produced_quantity, int warehouse_id, string warehouse_name,
            int recipe_id, string recipe_name, int quantity_warehouse, int estimate_id, int estimate_line)
        {
            this.description = description;
            this.observation = observation;
            this.begin = begin;
            this.end = end;
            this.state = state;
            this.Product_id = product_id;
            this.Product_name = product_name;
            this.Unit_id = unit_of_measure;
            this.Unit_name = unit_of_measure_name;
            this.quantity = quantity;
            this.produced_quantity = produced_quantity;
            this.Warehouse_id = warehouse_id;
            this.Warehouse_name = warehouse_name;
            this.Recipe_id = recipe_id;
            this.Recipe_name = recipe_name;
            this.quantity_warehouse = quantity_warehouse;
            this.estimate_id = estimate_id;
            this.estimate_line = estimate_line;
        }
   
        public ProductionOrder(int id,string description, string observation,DateTime begin,string state,DateTime end, int product_id, string product_name, int unit_of_measure,
            string unit_of_measure_name, int quantity, int produced_quantity, int warehouse_id, string warehouse_name, 
            int recipe_id, string recipe_name, int quantity_warehouse,int estimate_id,int estimate_line)
        {
            this.id = id;
            this.description = description;
            this.observation = observation;
            this.begin = begin;
            this.state=state;
            this.end = end;
            this.Product_id = product_id;
            this.Product_name = product_name;
            this.Unit_id = unit_of_measure;
            this.Unit_name = unit_of_measure_name;
            this.quantity = quantity;
            this.produced_quantity = produced_quantity;
            this.Warehouse_id = warehouse_id;
            this.Warehouse_name = warehouse_name;
            this.Recipe_id = recipe_id;
            this.Recipe_name = recipe_name;
            this.quantity_warehouse = quantity_warehouse;
            this.estimate_id = estimate_id;
            this.estimate_line = estimate_line;
        }
    
    }
}
