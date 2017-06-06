using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class UC_SimulationConfig : UserControl
    {
        List<Worker> workers;
        List<Workstation> workstations;
        List<Product> products;
        List<Algorithm.ProductLineAssignment> solution;

        public UC_SimulationConfig()
        {
            InitializeComponent();
        }

        private void UC_SimulationConfig_Load(object sender, EventArgs e)
        {
            Controller.WorkerController worker_controller = new Controller.WorkerController("dp1admin", "dp1admin");
            Controller.WorkstationsController workstation_controller = new Controller.WorkstationsController("dp1admin", "dp1admin");
            Controller.ProductsController product_controller = new Controller.ProductsController("dp1admin", "dp1admin");

            workers = (List<Worker>)worker_controller.getWokers().data;
            workstations = (List<Workstation>)workstation_controller.getWorkstations().data;
            products = (List<Product>)product_controller.getProducts().data;

            workers_grid.DataSource = workers;

            string[] rows = new string[2];
            foreach (Workstation wk in workstations)
            {
                rows[0] = wk.Name;
                rows[1] = "0";
                workstations_grid.Rows.Add(rows);
            }

            rows = new string[2];
            foreach (Product p in products)
            {
                rows[0] = p.Name;
                rows[1] = "0";
                products_grid.Rows.Add(rows);
            }

            // Cambiar por los productos reales cuando tengan data consistente
            ((DataGridViewComboBoxColumn)products_grid.Columns[0]).Items.Add("Retablo");
            ((DataGridViewComboBoxColumn)products_grid.Columns[0]).Items.Add("Ceramico");
            ((DataGridViewComboBoxColumn)products_grid.Columns[0]).Items.Add("Piedra");
        }

        private void execute_algorithm(object sender, EventArgs e)
        {
            List<Algorithm.Worker> tabu_workers = new List<Algorithm.Worker>();
            List<Algorithm.Workstation> tabu_wkstations = new List<Algorithm.Workstation>();
            Algorithm.Order order = new Algorithm.Order();

            foreach(DataGridViewRow row in workers_grid.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    Models.Worker worker = (Models.Worker)row.DataBoundItem;
                    tabu_workers.Add(new Algorithm.Worker(worker.Name,worker.Paternal_name));
                }
            }

            foreach (DataGridViewRow row in workstations_grid.Rows)
            {
                if (int.Parse(row.Cells[1].Value.ToString()) >= 1)
                {
                    Models.Product aux_prod = products.Where(p => p.Id == (workstations.Where(w => w.Name == row.Cells[0].Value.ToString()).ElementAt(0).Product_id)).ElementAt(0);
                    string prod_name ="";
                    if(aux_prod.Name.ToLower().Contains("ceramico") || aux_prod.Name.ToLower().Contains("cerámico"))
                    {
                        prod_name = "ceramico";
                    }
                    else if (aux_prod.Name.ToLower().Contains("piedra"))
                    {
                        prod_name = "piedra";
                    }
                    else if (aux_prod.Name.ToLower().Contains("retablo"))
                    {
                        prod_name = "retablo";
                    }

                    tabu_wkstations.Add(new Algorithm.Workstation(
                        new Algorithm.Product(prod_name, 0,aux_prod.Unit_price),                        
                        row.Cells[0].Value.ToString(), int.Parse(row.Cells[1].Value.ToString()),
                        workstations.Where(w => w.Name == row.Cells[0].Value.ToString()).ElementAt(0).Break_cost));
                }
            }

            Algorithm.OrderDetail detail = new Algorithm.OrderDetail();

            foreach (DataGridViewRow row in products_grid.Rows)
            {
                Algorithm.OrderDetailLine line = new Algorithm.OrderDetailLine();
                Models.Product aux_prod = products.Where(p => p.Name == row.Cells[0].Value.ToString()).ElementAt(0);
                string prod_name = "";
                if (aux_prod.Name.ToLower().Contains("ceramico") || aux_prod.Name.ToLower().Contains("cerámico"))
                {
                    prod_name = "ceramico";
                }
                else if (aux_prod.Name.ToLower().Contains("piedra"))
                {
                    prod_name = "piedra";
                }
                else if (aux_prod.Name.ToLower().Contains("retablo"))
                {
                    prod_name = "retablo";
                }
                line.product = new Algorithm.Product(prod_name, 0, aux_prod.Unit_price);
                line.quantity = int.Parse(row.Cells[1].Value.ToString());
                detail.lines.Add(line);
            }

            Algorithm.TabuSearch tabu = new Algorithm.TabuSearch(order, tabu_workers, tabu_wkstations);
            solution =  tabu.generateSolution();            
        }
    }
}
