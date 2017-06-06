using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class ProductionOrderWorkLine
    {
        private int order_Id;
        private int id;
        private int worker_id;
        private string worker_name;
        private int workstation_id;
        private string workstation_name;
        private int quantity_required;
        private int quantity_produced;
        private int quantity_broken;
        private double production_time;
        private int product_id;
        private string product_name;
        private int unit_id;
        private string unit_name;
        private string observation;
        private string state;

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

        public int Quantity_produced
        {
            get
            {
                return quantity_produced;
            }

            set
            {
                quantity_produced = value;
            }
        }

        public int Quantity_broken
        {
            get
            {
                return quantity_broken;
            }

            set
            {
                quantity_broken = value;
            }
        }

        public double Production_time
        {
            get
            {
                return production_time;
            }

            set
            {
                production_time = value;
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

        public int Worker_id
        {
            get
            {
                return worker_id;
            }

            set
            {
                worker_id = value;
            }
        }

        public string Worker_name
        {
            get
            {
                return worker_name;
            }

            set
            {
                worker_name = value;
            }
        }

        public int Workstation_id
        {
            get
            {
                return workstation_id;
            }

            set
            {
                workstation_id = value;
            }
        }

        public string Workstation_name
        {
            get
            {
                return workstation_name;
            }

            set
            {
                workstation_name = value;
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

        public ProductionOrderWorkLine() {
        }

        public ProductionOrderWorkLine(int id, int order_id, int worker_id,string worker_name, string worker_paternal_name,string worker_maternal_name,
            int work_station_id,string work_station_name, int quantity_required,int quantity_produced,int quantity_broken,double production_time,
            int product_id, string product_name,int unit_of_measure,string unit_of_measure_name, string observation,string state)
        {
            this.Id = id;
            this.order_Id = order_id;
            this.worker_id = worker_id;
            this.worker_name = worker_name+" "+ worker_paternal_name+" "+ worker_maternal_name;         
            this.workstation_id = work_station_id;
            this.workstation_name = work_station_name;
            this.quantity_required = quantity_required;
            this.quantity_produced = quantity_produced;
            this.quantity_broken = quantity_broken;
            this.production_time = production_time;
            this.product_id = product_id;
            this.product_name = product_name;
            this.Unit_id = unit_of_measure;
            this.Unit_name= unit_of_measure_name;
            this.observation = observation;
            this.state = state;

        }
    }
}
