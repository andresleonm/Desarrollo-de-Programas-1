using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class ProductionOrder
    {
        private int id;
        private string description;
        private string observation;
        private DateTime begin;
        private DateTime end;
        private string status;
        private List<ProductionOrderProductLine> productLines;
        private List<ProductionOrderWorkLine> workLines;
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

        internal List<ProductionOrderProductLine> ProductLines
        {
            get
            {
                return productLines;
            }

            set
            {
                productLines = value;
            }
        }

        internal List<ProductionOrderWorkLine> WorkLines
        {
            get
            {
                return workLines;
            }

            set
            {
                workLines = value;
            }
        }

        public ProductionOrder()
        {

        }

        public ProductionOrder(string description, string observation, DateTime begin, DateTime end, string status)
        {
            this.description = description;
            this.observation = observation;
            this.begin = begin;
            this.end = end;
            this.status = status;
         }
    
    }
}
