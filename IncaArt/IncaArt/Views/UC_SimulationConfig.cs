﻿using System;
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

            int wkstation_qty = 0;
            Algorithm.Order order = new Algorithm.Order();

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
                    Models.Product aux_prod = products.Where(p => p.Id == ((Workstation)row.DataBoundItem).Product_id).ElementAt(0);
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
                    
                    Algorithm.Workstation wkst = new Algorithm.Workstation(
                        new Algorithm.Product(prod_name, 0, aux_prod.Unit_price,aux_prod.Name),
                        row.Cells[0].Value.ToString(), int.Parse(row.Cells[1].Value.ToString()),
                        ((Workstation)row.DataBoundItem).Break_cost);
                    wkst.id = ((Workstation)row.DataBoundItem).Id;
                    tabu_wkstations.Add(wkst);
                    wkstation_qty += wkst.quantity;   
                }
            }
            
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
            bool contains = false;
            foreach (DataGridViewRow row in products_grid.Rows)
            {
                if (int.Parse(row.Cells[1].Value.ToString()) > 0)
                {
                    foreach(Algorithm.OrderDetailLine l in detail.lines)
                    {
                        if (row.Cells[0].Value.ToString().ToLower().Contains(l.product.name.ToLower()))
                        {
                            l.quantity += int.Parse(row.Cells[1].Value.ToString());
                            contains = true;
                            break;
                        }
                    }
                    if (contains) continue;
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
                    line.product = new Algorithm.Product(prod_name, 0, aux_prod.Unit_price,aux_prod.Name);
                    line.quantity = int.Parse(row.Cells[1].Value.ToString());
                    detail.lines.Add(line);
                }                
            }           
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
                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
                // Close the AlertForm
                progress.Close();
            }
        }

        // This event handler is where the time-consuming work is done.
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            solution = ((Algorithm.TabuSearch)e.Argument).generateSolution(worker);                        
        }

        // This event handler updates the progress.
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Console.WriteLine(e.ProgressPercentage);
            progress.ProgressValue = e.ProgressPercentage;
        }

        // This event handler deals with the results of the background operation.
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
                products = (List<Product>)product_controller.getProducts().data;

                workers_grid.DataSource = workers;



                workstations_grid.DataSource = workstations;

                string[] rows = new string[2];
                products_grid.Rows.Clear();
                ((DataGridViewComboBoxColumn)products_grid.Columns[0]).Items.Clear();
                foreach (Product p in products)
                {                    
                    ((DataGridViewComboBoxColumn)products_grid.Columns[0]).Items.Add(p.Name);
                    rows[1] = "0";
                    products_grid.Rows.Add(rows);
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
