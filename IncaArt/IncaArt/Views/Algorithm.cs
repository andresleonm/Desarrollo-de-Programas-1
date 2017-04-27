using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Views
{
    public partial class Algorithm : Form
    {
        public Random rnd = new Random();
        public Algorithm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            initializeParameters();
        }

        public void initializeParameters()
        {
            List<Assignment> initial_s = new List<Assignment>(); // solución inicial
            List<Worker> workers = new List<Worker>(); // lista de trabajadores
            List<Workstation> workstations = new List<Workstation>(); // lista de puestos de trabajo
            //-------------------------------------------------- HARDCODED!!
            Product product1 = new Product("Retablo", 0, 2.5);
            Product product2 = new Product("Ceramico", 0, 3.0);
            Product product3 = new Product("Piedra", 0, 5.0);
            OrderDetailLine line1 = new OrderDetailLine(product1, 10);
            OrderDetailLine line2 = new OrderDetailLine(product2, 20);
            OrderDetailLine line3 = new OrderDetailLine(product3, 15);
            List<OrderDetailLine> lines = new List<OrderDetailLine>();
            lines.Add(line1);
            lines.Add(line2);
            lines.Add(line3);
            OrderDetail order_detail = new OrderDetail(lines);
            Order order = new Order(order_detail,new DateTime(2017,4,26));
            //-------------------------------------------------- HARDCODED!!

            initial_s = generateSolution(workers,workstations,order);
        }

        public List<Assignment> generateSolution(List<Worker> workers,List<Workstation> workstations,Order order)
        {
            List<Workstation> admissible_workstations = new List<Workstation>();
            List<ProductLineAssignment> solution = new List<ProductLineAssignment>();
            List<Tuple<int, string>> products_quantities;            
            
            int retablo_sets = 0;
            int piedra_sets = 0;
            int ceramico_sets = 0;

            foreach (Workstation workstation in workstations)
            {
                foreach (OrderDetailLine line in order.order_detail.lines)
                {
                    if (workstation.product.Equals(line.product))
                    {
                        admissible_workstations.Add(workstation);
                        if (workstation.name == "MoldeadoR") retablo_sets = workstation.quantity;
                        else if (workstation.name == "Tallado") piedra_sets = workstation.quantity;
                        else if (workstation.name == "MoldeadoC") ceramico_sets = workstation.quantity;                        
                    }
                }
            }            

            products_quantities = new List<Tuple<int, string>>(order.order_detail.lines.Count());
            for(int l =1; l < products_quantities.Count(); l++)
            {
                products_quantities.Add(Tuple.Create(order.order_detail.lines.ElementAt(l).quantity,order.order_detail.lines.ElementAt(l).product.name));
            }            

            if (workers.Count() >= (retablo_sets*3 + piedra_sets + ceramico_sets*3) // si hay más trabajadores que puestos de trabajo
            { 
                foreach(OrderDetailLine order_line in order.order_detail.lines)
                {
                    switch (order_line.product.name)
                    {
                        case "Retablo":
                            {

                                break;
                            }
                    }
                }
            }
            else // si hay más puestos de trabajo que trabajadores
            {

            }
            workers.ElementAt(rnd.Next(1, workers.Count()));
            
        }
    
    }
}
