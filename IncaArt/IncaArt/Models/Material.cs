using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Material
    {
        int id;
        UnitOfMeasure unit;
        int unit_id;
        string name;
        int max_stock;
        int min_stock;
        int status;
        double average_cost;
        int current_logical_stock;
        int current_physical_stock;
        string description;

        public Material()
        {
        }

        public Material(int id, int unit_id,string name, int min_stock, int max_stock)
        {
            this.id = id;
            this.unit_id = unit_id;
            this.name = name;
            this.max_stock = max_stock;
            this.min_stock = min_stock;
        }

        public Material(int id, string name, int min_stock, int max_stock)
        {
            this.id = id;
            this.name = name;
            this.max_stock = max_stock;
            this.min_stock = min_stock;
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

        public int Max_stock
        {
            get
            {
                return max_stock;
            }

            set
            {
                max_stock = value;
            }
        }

        public int Min_stock
        {
            get
            {
                return min_stock;
            }

            set
            {
                min_stock = value;
            }
        }

        public int Status
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

        public double Average_cost
        {
            get
            {
                return average_cost;
            }

            set
            {
                average_cost = value;
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

        public UnitOfMeasure Unit
        {
            get
            {
                return unit;
            }

            set
            {
                unit = value;
            }
        }
    }
}
