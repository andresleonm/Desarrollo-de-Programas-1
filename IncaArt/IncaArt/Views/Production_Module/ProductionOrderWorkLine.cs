using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1.Views.Production_Module
{
    public partial class ProductionOrderWorkLine : Form
    {
        private Models.ProductionOrderWorkLine line = new Models.ProductionOrderWorkLine();
        private bool isRegistered = false;
        private bool editing = false;

        List<Product> products;
        List<Workstation> workstations;
        List<Worker> workers;
        string user = "dp1admin";
        string password = "dp1admin";

        ProductsController product_controller;
        WorkstationsController workstation_controller;
        WorkerController worker_controller;
        UnitController unit_controller;

        public bool IsRegistered
        {
            get
            {
                return isRegistered;
            }

            set
            {
                isRegistered = value;
            }
        }

        internal Models.ProductionOrderWorkLine Line
        {
            get
            {
                return line;
            }

            set
            {
                line = value;
            }
        }

        public bool Editing
        {
            get
            {
                return editing;
            }

            set
            {
                editing = value;
            }
        }

        public ProductionOrderWorkLine()
        {
            InitializeComponent();
            unit_controller = new UnitController(user, password);
            product_controller = new ProductsController(user, password);
            worker_controller = new WorkerController(user, password);
            workstation_controller = new WorkstationsController(user, password);
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool validate_data()
        {
            return true;
        }
        private void button_Register_Click(object sender, EventArgs e)
        {
            if (validate_data())
            {
                isRegistered = true;
                Worker worker=workers[comboBox_Worker.SelectedIndex];
                line.Worker_id = worker.Id;
                line.Worker_name = worker.Name+" "+worker.Paternal_name+" "+worker.Maternal_name;

                Workstation workstation_selected=workstations[comboBox_Workstation.SelectedIndex];
                line.Workstation_id = workstation_selected.Id;
                line.Workstation_name = workstation_selected.Name;

                Product product_selected=products[comboBox_Product.SelectedIndex];
                line.Product_id = product_selected.Id;
                line.Product_name = product_selected.Name;
                line.Unit_id = product_selected.Unit_id;

                
                Result result = unit_controller.getUnit(product_selected.Unit_id);
                UnitOfMeasure unit = (UnitOfMeasure)result.data;
                line.Unit_id = unit.Id;
                line.Unit_name = unit.Name;

                line.Quantity_required=Int32.Parse(metroTextBox_quantity_required.Text);
                line.Quantity_produced=Int32.Parse(metroTextBox_quantity_produced.Text);
                line.Quantity_broken=Int32.Parse(metroTextBox_quantity_broken.Text);
                line.Production_time=(double)(numericUpDown_Hours.Value*60+numericUpDown_Minute.Value);
                line.Observation=metroTextBox_observations.Text;
                line.State = "Registrado";

                this.Close();
            }
        }

        private void comboBox_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product_id = ((Product)comboBox_Product.SelectedItem).Id;
            Workstation workstation = new Workstation();
            workstation.Product_id = product_id;
            workstations = (List<Workstation>)workstation_controller.getWorkstations(workstation).data;

            comboBox_Workstation.DataSource = workstations;
            comboBox_Workstation.DisplayMember = "name";
            comboBox_Workstation.SelectedIndex = -1;
        
        }

        private void ProductionOrderWorkLine_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            Result result = product_controller.getProducts();
            this.products = (List<Product>)result.data;

            result = workstation_controller.getWorkstations();
            this.workstations = (List<Workstation>)result.data;

            result = worker_controller.getWokers();
            this.workers = (List<Worker>)result.data;

            comboBox_Product.DataSource = products;
            comboBox_Product.DisplayMember = "name";
            comboBox_Workstation.DataSource = workstations;
            comboBox_Workstation.DisplayMember = "name";
            
            for(int i = 0; i < workers.Count; i++) {
                comboBox_Worker.Items.Add(workers[i].Name+" "+ workers[i].Paternal_name+" "+ workers[i].Maternal_name);
            }

            if (Editing)
            {
                comboBox_Product.Text = line.Product_name;
                comboBox_Workstation.Text = line.Workstation_name;
                comboBox_Worker.Text = line.Worker_name;
                metroTextBox_observations.Text = line.Observation;
                metroTextBox_quantity_required.Text = line.Quantity_required.ToString();
                metroTextBox_quantity_produced.Text = line.Quantity_produced.ToString();
                metroTextBox_quantity_broken.Text = line.Quantity_broken.ToString();
                //metroTextBox_production_time.Text = line.Production_time.ToString();
                numericUpDown_Minute.Value = (int)(line.Production_time) % 60;
                numericUpDown_Hours.Value= (int)(line.Production_time) / 60;

                this.Text = "Edición de notificación de trabajo";
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
