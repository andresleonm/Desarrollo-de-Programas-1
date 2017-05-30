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
        private Worker worker;
        private Workstation workstation;
        private int quantity_required;
        private int quantity_produced;
        private int quantity_broken;
        private double production_time;
        private Product product;
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

        public Worker Worker
        {
            get
            {
                return worker;
            }

            set
            {
                worker = value;
            }
        }

        internal Workstation Workstation
        {
            get
            {
                return workstation;
            }

            set
            {
                workstation = value;
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

        public ProductionOrderWorkLine() {
        }
    }
}
