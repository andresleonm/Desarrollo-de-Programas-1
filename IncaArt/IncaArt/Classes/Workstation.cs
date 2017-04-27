using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Workstation
    {
        internal Product product { get; set; }
        internal string name { get; set; }
        internal int quantity { get; set; }
        internal int id;

        public Workstation(Product product, string name, int quantity,int id)
        {
            this.product = product;
            this.name = name;
            this.quantity = quantity;
            this.id = id;
        }

        public Workstation(Product product, string name) // Constructor para ProductLineAssignment
        {
            this.product = product;
            this.name = name;
        }
    }
}
