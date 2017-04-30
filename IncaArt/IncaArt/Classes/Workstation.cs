using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Genetic;

namespace WindowsFormsApp1.Classes
{
    class Workstation
    {
        public string name { get; set; }
        public int quantity { get; set; }
        public double break_cost { get; set; }
        public int id { get; set; }
        public Product product { get; set; }



        public Workstation(Product product, string name, int quantity, int id, double break_cost)

        {
            this.product = product;
            this.name = name;
            this.quantity = quantity;
            this.break_cost = break_cost;
            this.id = id;
        }



        public Workstation()
        {

        }

        public Workstation(Product product, string name, int quantity,double break_cost)

        {
            this.product = product;
            this.name = name;
            this.quantity = quantity;            
            this.break_cost = break_cost;
        }

        public Workstation(string name, int quantity, double break_cost)
        {            
            this.name = name;
            this.quantity = quantity;
            this.break_cost = break_cost;
        }

        public Workstation(Product product, string name)
        {
            this.product = product;
            this.name = name;
        }

        public List<Workstation> Getworkstations() {
            List<Workstation> ws = new List<Workstation>();
            for (int i = 0; i < quantity; i++)
                ws.Add(new Workstation(product, name, 1,id, break_cost));
            return ws;
        }

    }
}
