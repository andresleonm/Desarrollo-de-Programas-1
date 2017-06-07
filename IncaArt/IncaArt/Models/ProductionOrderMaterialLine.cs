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
        private int material_id;
        private string material_name;
        private int quantity_required;
        private int quantity_taken_real;
        private int unit_id;
        private string unit_name;
        private string state;
        private int warehouse_id;
        private string warehouse_name;

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

        public int Material_id
        {
            get
            {
                return material_id;
            }

            set
            {
                material_id = value;
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

        public string Material_name
        {
            get
            {
                return material_name;
            }

            set
            {
                material_name = value;
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

        public ProductionOrderMaterialLine(int id, int order_id, int material_id, string material_name, int unit_of_measure,string unit_of_measure_name,
           int quantity_required, int quantity_taken_real, int warehouse_id, string warehouse_name, string state)
        {
            this.id = id;
            this.order_Id = order_id;
            this.Material_id = material_id;
            this.Material_name = material_name;
            this.Unit_id = unit_of_measure;
            this.Unit_name = unit_of_measure_name;
            this.quantity_required = quantity_required;
            this.quantity_taken_real = quantity_taken_real;
            this.Warehouse_id = warehouse_id;
            this.Warehouse_name = warehouse_name;
            this.state = state;       
        }
    }
}
