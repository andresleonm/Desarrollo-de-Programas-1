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
        internal double break_cost { get; set; }

        public Workstation(Product product, string name, int quantity,int id,double break_cost)
        {
            this.product = product;
            this.name = name;
            this.quantity = quantity;
            this.id = id;
            this.break_cost = break_cost;
        }     
        
        public Workstation(Product product, string name)
        {
            this.product = product;
            this.name = name;
        }   
    }
}
