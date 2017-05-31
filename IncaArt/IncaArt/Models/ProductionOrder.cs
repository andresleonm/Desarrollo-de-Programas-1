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
        private string state;
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

        public ProductionOrder()
        {

        }

        public ProductionOrder(string description, string observation, DateTime begin, DateTime end, string state)
        {
            this.description = description;
            this.observation = observation;
            this.begin = begin;
            this.end = end;
            this.state = state;
         }
       
        public ProductionOrder(int id,string description, string observation,DateTime begin,string state,DateTime end)
        {
            this.id = id;
            this.description = description;
            this.observation = observation;
            this.begin = begin;
            this.state=state;
            this.end = end;
        }
    
    }
}
