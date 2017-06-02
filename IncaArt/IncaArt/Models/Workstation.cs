using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Workstation
    {
        int id;
        int product_id;
        string name;        
        int next_workstation;
        int previous_workstation;
        int quantity;

        public Workstation(int product_id, string name)
        {
            this.product_id = product_id;
            this.name = name;
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

        public int Next_workstation
        {
            get
            {
                return next_workstation;
            }

            set
            {
                next_workstation = value;
            }
        }

        public int Previous_workstation
        {
            get
            {
                return previous_workstation;
            }

            set
            {
                previous_workstation = value;
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
    }
}
