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
        public List<Algorithm.ProductLineAssignment> solution;
        bool workers_checked = true;
        public int iterations, tabu_size, neighborhood_size, combinations;        
        Algorithm.TabuSearch tabu;
        ProgressForm progress;        
        public UC_SimulationConfig()
        {
            this.iterations = 8000;
            this.tabu_size = 10;
            this.neighborhood_size = 50;
            this.combinations = 100;
            InitializeComponent();
        }

        private void execute_algorithm(object sender, EventArgs e)
        {
            List<Algorithm.Worker> tabu_workers = new List<Algorithm.Worker>();
            List<Algorithm.Workstation> tabu_wkstations = new List<Algorithm.Workstation>();
            Controller.RatioController ratio_controller = new Controller.RatioController("dp1admin", "dp1admin");
            Controller.ProductsController product_controller = new Controller.ProductsController("dp1admin", "dp1admin");

            int wkstation_qty = 0;
            Algorithm.Order order = new Algorithm.Order();

            #region Workstations
            foreach (DataGridViewRow row in workstations_grid.Rows)
            {
                if (row.Cells[1].Value == null || int.Parse(row.Cells[1].Value.ToString()) == 0)
                {
                    MessageBox.Show("Debe haber por lo menos un puesto de trabajo de cada tipo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    row.Cells[1].Value = 1;
                    return;
                }
                if (row.Cells[1].Value!=null && int.Parse(row.Cells[1].Value.ToString()) >= 1)
                {
                    Models.Product aux_prod = (Models.Product)product_controller.getProduct(((Workstation)row.DataBoundItem).Product_id).data;                    
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

                    Algorithm.Product p = new Algorithm.Product(prod_name, 0, aux_prod.Unit_price, aux_prod.Name);                    
                    Algorithm.Workstation wkst = new Algorithm.Workstation(p,
                        ((Workstation)row.DataBoundItem).Name, int.Parse(row.Cells[1].Value.ToString()),
                        ((Workstation)row.DataBoundItem).Break_cost);
                    wkst.complete_name = ((Workstation)row.DataBoundItem).complete_name;
                    wkst.id = ((Workstation)row.DataBoundItem).Id;
                    wkst.complete_name = ((Workstation)row.DataBoundItem).complete_name;
                    tabu_wkstations.Add(wkst);
                    wkstation_qty += wkst.quantity;   
                }
            }

            #endregion

            #region Workers
            foreach (DataGridViewRow row in workers_grid.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    Models.Worker worker = (Models.Worker)row.DataBoundItem;
                    Algorithm.Worker tabu_worker = new Algorithm.Worker(worker.Name, worker.Paternal_name);
                    List<Ratio> ratios = (List<Ratio>)ratio_controller.getRatios(worker.Id.ToString()).data;
                    List<Algorithm.Ratio> tabu_ratios = new List<Algorithm.Ratio>();
                    foreach(Ratio r in ratios)
                    {
                        string ratio_t = "";
                        if (r.ratio_type == 1) ratio_t = "Efficiency";
                        else if (r.ratio_type == 2) ratio_t = "Time";
                        tabu_ratios.Add(new Algorithm.Ratio(r.value,ratio_t,
                            tabu_wkstations.Where(wkstation => wkstation.id == r.workstation_id).ElementAt(0),r.produced_quantity,r.broken_quantity));
                    }
                    tabu_worker.ratios = tabu_ratios;
                    tabu_workers.Add(tabu_worker);
                }
            }
            #endregion

            if(tabu_workers.Count < 6)
            {
                MessageBox.Show("Debe haber al menos un trabajador para cada puesto de trabajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(wkstation_qty > tabu_workers.Count)
            {
                MessageBox.Show("No puede haber más puestos de trabajos que trabajadores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Algorithm.OrderDetail detail = new Algorithm.OrderDetail();

            #region Products
            bool contains = false;
            foreach (DataGridViewRow row in products_grid.Rows)
            {
                if (int.Parse(row.Cells[2].Value.ToString()) > 0)
                {
                    foreach(Algorithm.OrderDetailLine l in detail.lines)
                    {
                        if (row.Cells[0].Value.ToString().ToLower().Contains(l.product.name.ToLower()))
                        {
                            l.quantity += int.Parse(row.Cells[2].Value.ToString());
                            contains = true;
                            break;
                        }
                    }
                    if (contains) continue;
                    Algorithm.OrderDetailLine line = new Algorithm.OrderDetailLine();
                    Models.Product aux_prod = products.Where(p => p.Name == row.Cells[1].Value.ToString()).ElementAt(0);
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
                    line.product = new Algorithm.Product(prod_name, 0, aux_prod.Unit_price,aux_prod.Name);
                    line.quantity = int.Parse(row.Cells[2].Value.ToString());
                    detail.lines.Add(line);
                }                
            }

            #endregion
            order.order_detail = detail;            
            tabu = new Algorithm.TabuSearch(order, tabu_workers, tabu_wkstations, iterations, tabu_size, neighborhood_size, combinations);
            progress = new ProgressForm();
            progress.Canceled += new EventHandler<EventArgs>(buttonCancel_Click);
            progress.Show();            
            backgroundWorker1.RunWorkerAsync(tabu);            
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();

                progress.Close();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            solution = ((Algorithm.TabuSearch)e.Argument).generateSolution(worker);                        
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
  
            progress.ProgressValue = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //if (e.Cancelled == true)
            //{
            //    labelResult.Text = "Canceled!";
            //}
            //else if (e.Error != null)
            //{
            //    labelResult.Text = "Error: " + e.Error.Message;
            //}
            //else
            //{
            //    labelResult.Text = "Done!";
            //}
            // Close the AlertForm
            MessageBox.Show("Simulación finalizada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Visible = false;
            this.Parent.Parent.Controls.Find("UC_SimulationExecution1", true)[0].Visible = true;
            progress.Close();
        }


        private void workers_grid_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                foreach(DataGridViewRow row in workers_grid.Rows)
                {
                    ((DataGridViewCheckBoxCell)row.Cells[3]).Value = workers_checked;
                }
                workers_checked = !workers_checked;
            }
        }

        private void btn_execution_worker_Click(object sender, EventArgs e)
        {
            this.metroTabControl1.SelectTab(this.metroTabControl1.SelectedIndex + 1);
        }

        private void products_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.metroTabControl1.SelectTab(this.metroTabControl1.SelectedIndex -1);
        }

        private void UC_SimulationConfig_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == true)
            {
                Controller.WorkerController worker_controller = new Controller.WorkerController("dp1admin", "dp1admin");
                Controller.WorkstationsController workstation_controller = new Controller.WorkstationsController("dp1admin", "dp1admin");
                Controller.ProductsController product_controller = new Controller.ProductsController("dp1admin", "dp1admin");

                workers = (List<Worker>)worker_controller.getWokers().data;
                workstations = (List<Workstation>)workstation_controller.getWorkstations().data;
                foreach(Workstation wokst in workstations)
                {
                    switch (wokst.Name)
                    {
                        case "Horneado":
                            {
                                wokst.complete_name = "Horneado de Cerámico";
                                break;
                            }
                        case "MoldeadoC":
                            {
                                wokst.complete_name = "Moldeado de Cerámico";
                                break;
                            }
                        case "PintadoC":
                            {
                                wokst.complete_name = "Pintado de Cerámico";
                                break;
                            }
                        case "MoldeadoR":
                            {
                                wokst.complete_name = "Moldeado de Retablo";
                                break;
                            }
                        case "PintadoR":
                            {
                                wokst.complete_name = "Pintado de Retablo";
                                break;
                            }
                        case "Tallado":
                            {
                                wokst.complete_name = "Tallado de Piedra";
                                break;
                            }
                    }
                }
                products = (List<Product>)product_controller.getProducts().data;

                workers_grid.DataSource = workers;

                workstations_grid.DataSource = workstations;
                for(int i=0; i<6; i++)
                {                                       
                    workstations_grid.Rows[i].Cells[1].Value = "1";
                }

                string[] rows = new string[3];
                products_grid.Rows.Clear();

                rows[0] = "Cerámico";
                rows[1] = "";
                rows[2] = "1";
                products_grid.Rows.Add(rows);
                rows[0] = "Retablo";
                rows[1] = "";
                rows[2] = "1";
                products_grid.Rows.Add(rows);
                rows[0] = "Piedra";
                rows[1] = "";
                rows[2] = "1";
                products_grid.Rows.Add(rows);

                for (int i = 0; i < 3; i++)
                {
                    ((DataGridViewComboBoxCell)products_grid.Rows[i].Cells[1]).Items.Clear();
                    switch (products_grid.Rows[i].Cells[0].Value.ToString().ToLower())
                    {
                        case "ceramico":
                            {
                                foreach (Product p in products)
                                {
                                    if (p.Product_type.ToLower() == "ceramico")
                                    {
                                        ((DataGridViewComboBoxCell)products_grid.Rows[i].Cells[1]).Items.Add(p.Name);
                                    }
                                }
                                break;
                            }
                        case "cerámico":
                            {
                                foreach (Product p in products)
                                {
                                    if (p.Product_type.ToLower() == "ceramico")
                                    {
                                        ((DataGridViewComboBoxCell)products_grid.Rows[i].Cells[1]).Items.Add(p.Name);
                                    }
                                }
                                break;
                            }
                        case "piedra":
                            {
                                foreach (Product p in products)
                                {
                                    if (p.Product_type.ToLower() == "piedra")
                                    {
                                        ((DataGridViewComboBoxCell)products_grid.Rows[i].Cells[1]).Items.Add(p.Name);
                                    }
                                }
                                break;
                            }
                        case "retablo":
                            {
                                foreach (Product p in products)
                                {
                                    if (p.Product_type.ToLower() == "retablo")
                                    {
                                        ((DataGridViewComboBoxCell)products_grid.Rows[i].Cells[1]).Items.Add(p.Name);
                                    }
                                }
                                break;
                            }
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            Frm_AdvancedSimulationConfig advncd = new Frm_AdvancedSimulationConfig();
            DialogResult result = advncd.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                this.iterations = 8000;
                this.tabu_size = 10;
                this.neighborhood_size = 50;
                this.combinations = 100;
            }
            else if (result == DialogResult.OK) {
                this.iterations = advncd.iterations;
                this.tabu_size = advncd.tabu_size;
                this.neighborhood_size = advncd.neighborhood_size;
                this.combinations = advncd.combinations;
            } 
                                    
        }
    }
}
