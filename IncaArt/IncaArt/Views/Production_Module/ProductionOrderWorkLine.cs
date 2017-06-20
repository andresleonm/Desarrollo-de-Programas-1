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

        List<Workstation> workstations;
        List<Worker> workers;
        string user = "dp1admin";
        string password = "dp1admin";

        Product product;

        WorkstationsController workstation_controller;
        WorkerController worker_controller;
        UnitController unit_controller;

        //validate
        bool flag_worker = true;
        bool flag_workstation = true;
        bool flag_quantity_required = false;
        bool flag_quantity_produced = false;
        bool flag_quantity_broken = false;
        bool flag_time = false;

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

        public Product Product
        {
            get
            {
                return product;
            }

            set
            {
                product = value;
            }
        }

        public ProductionOrderWorkLine()
        {
            InitializeComponent();
            unit_controller = new UnitController(user, password);
            worker_controller = new WorkerController(user, password);
            workstation_controller = new WorkstationsController(user, password);
            
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool validate_data()
        {
            bool isCorrect = true;

            validate_comboBox(comboBox_Worker);
            validate_comboBox(comboBox_Workstation);
            validate_textbox(metroTextBox_quantity_required);
            validate_textbox(metroTextBox_quantity_produced);
            validate_textbox(metroTextBox_quantity_broken);
            validate_numericUpDown();

            if (!flag_worker || !flag_workstation || !flag_quantity_required ||
                !flag_quantity_broken || !flag_quantity_produced||!flag_time)
            {
                MessageBox.Show("Hay campos inválidos en la notificación de trabajo.", "Error en el registro", MessageBoxButtons.OK);
                isCorrect = false;
            }
            return isCorrect;
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
                
                line.Product_id = Product.Id;
                line.Product_name = Product.Name;

                Result result = unit_controller.getUnit(Product.Unit_id);
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
       
        private void ProductionOrderWorkLine_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            Workstation workstation = new Workstation();
            workstation.Product_id = Product.Id;
            Result result = workstation_controller.getWorkstations(workstation);
            this.workstations = (List<Workstation>)result.data;

            comboBox_Workstation.DataSource = workstations;
            comboBox_Workstation.DisplayMember = "name";
            comboBox_Workstation.SelectedIndex = -1;

            result = worker_controller.getWokers();
            this.workers = (List<Worker>)result.data;
            
            for(int i = 0; i < workers.Count; i++) {
                comboBox_Worker.Items.Add(workers[i].Name+" "+ workers[i].Paternal_name+" "+ workers[i].Maternal_name);
            }

            if (Editing)
            {
                flag_quantity_broken = true;
                flag_quantity_produced = true;
                flag_quantity_required = true;
                flag_time = true;
            
                comboBox_Workstation.Text = line.Workstation_name;
                comboBox_Worker.Text = line.Worker_name;
                metroTextBox_observations.Text = line.Observation;
                metroTextBox_quantity_required.Text = line.Quantity_required.ToString();
                metroTextBox_quantity_produced.Text = line.Quantity_produced.ToString();
                metroTextBox_quantity_broken.Text = line.Quantity_broken.ToString();
                numericUpDown_Minute.Value = (int)(line.Production_time) % 60;
                numericUpDown_Hours.Value= (int)(line.Production_time) / 60;

                this.Text = "Edición de notificación de trabajo";
            }
        }

        private void metroTextBox_quantity_required_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
        }

        private void metroTextBox_quantity_broken_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
        }

        private void metroTextBox_quantity_produced_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
        }

        private void setFlag(string name, bool value)
        {
            switch (name)
            {
                case "comboBox_Worker":
                    flag_worker = value;
                    break;                
                case "comboBox_Workstation":
                    flag_workstation = value;
                    break;
                case "metroTextBox_quantity_required":
                    flag_quantity_required = value;
                    break;
                case "metroTextBox_quantity_produced":
                    flag_quantity_produced = value;
                    break;
                case "metroTextBox_quantity_broken":
                    flag_quantity_broken = value;
                    break;
                case "numericUpDown_Minute":
                    flag_time = value;
                    break;
            }
        }

        private void validate_comboBox(System.Windows.Forms.ComboBox combobox)
        {
            int index = combobox.SelectedIndex;
            if (index == -1)
            {
                setFlag(combobox.Name, false);
                errorProvider.SetError(combobox, "Campo requerido");

            }
            else
            {
                setFlag(combobox.Name, true);
                errorProvider.SetError(combobox, null);
            }
        }

        private void validate_textbox(MetroFramework.Controls.MetroTextBox textbox)
        {
            string text = textbox.Text;
            int num;
            if (String.IsNullOrWhiteSpace(text))
            {
                setFlag(textbox.Name, false);
                errorProvider.SetError(textbox, "Campo requerido");
            }
            else if (!Int32.TryParse(text, out num) || num <= 0)
            {
                if (num == 0 && textbox.Name == "metroTextBox_quantity_broken")
                {
                    setFlag(textbox.Name, true);
                    errorProvider.SetError(textbox, null);
                }
                else
                {
                    setFlag(textbox.Name, false);
                    errorProvider.SetError(textbox, "La cantidad debe ser mayor que cero.");
                }
            }
            else
            {
                setFlag(textbox.Name, true);
                errorProvider.SetError(textbox, null);
            }
        }

        private void validate_numericUpDown()
        {
            NumericUpDown numeric_minute = numericUpDown_Minute;

            int hour = (int)numericUpDown_Hours.Value;
            int minute = (int)numeric_minute.Value;
            if (hour == 0 && minute == 0)
            {
                setFlag(numeric_minute.Name, false);
                errorProvider.SetError(numeric_minute, "Campo requerido");
            }
            else
            {
                setFlag(numeric_minute.Name, true);
                errorProvider.SetError(numeric_minute, null);
            }
        }
        private void comboBox_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.ComboBox combobox = (System.Windows.Forms.ComboBox)sender;
            validate_comboBox(combobox);
        }

        private void metroTextBox_Validating(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textbox = (MetroFramework.Controls.MetroTextBox)sender;
            validate_textbox(textbox);
        }

        private void numericUpDown_Minute_Validating(object sender, CancelEventArgs e)
        {
            validate_numericUpDown();
        }

        private void numericUpDown_Hours_Validating(object sender, CancelEventArgs e)
        {
            validate_numericUpDown();
        }
    }
}
