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
    public partial class ProductionOrderMaterialLine : Form
    {
        private Models.ProductionOrderMaterialLine line=new Models.ProductionOrderMaterialLine();
        private bool isRegistered = false;
        private bool editing = false;

        List<Material> materials;
        List<Warehouse_Module.MaterialWarehouseM> warehouses;
        string user = "dp1admin";
        string password = "dp1admin";

        MaterialsController material_controller;
        MaterialMovementDetailController material_warehouse_controller;
        UnitController unit_controller;
       

        //validate
        bool flag_material=false;
        bool flag_warehouse=true;
        bool flag_quantity=false;

        internal Models.ProductionOrderMaterialLine Line
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

        public ProductionOrderMaterialLine()
        {
            InitializeComponent();
            material_controller = new MaterialsController(user, password);
            material_warehouse_controller = new MaterialMovementDetailController(user, password);
            unit_controller = new UnitController(user, password);          
        }

        private bool validate_data()
        {
            bool isCorrect = true;
            validate_comboBox(comboBox_Material);
            validate_comboBox(comboBox_Warehouse);
            validate_textbox(metroTextBox_Quantity);
        
            if (!flag_material || !flag_quantity || !flag_warehouse)
            {
                MessageBox.Show("Hay campos inválidos en los datos del detalle de material.", "Error en el registro", MessageBoxButtons.OK);
                isCorrect = false;
            }
            return isCorrect;
        }
        private void button_Register_Click(object sender, EventArgs e)
        {
            if (validate_data())
            {
                IsRegistered = true;
                Material material= materials[comboBox_Material.SelectedIndex];
                Line.Material_id = material.Id;
                Line.Material_name = material.Name;
               
                Result result = unit_controller.getUnit(material.Unit_id);
                UnitOfMeasure unit = (UnitOfMeasure)result.data;
                Line.Unit_id = unit.Id;
                Line.Unit_name = unit.Name;

                Line.Quantity_required = Int32.Parse(metroTextBox_Quantity.Text);
                Line.State = "Registrado";
                MaterialWarehouse warehouse = warehouses[comboBox_Warehouse.SelectedIndex];
                Line.Warehouse_id = warehouse.Id;
                Line.Warehouse_name = warehouse.Name;

                this.Close();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductionOrderMaterialLine_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            // ComboBox         
            Result result = material_controller.getMaterials_withWarehouses();
            this.materials = (List<Material>)result.data;

            comboBox_Material.DataSource = materials;
            comboBox_Material.DisplayMember = "name";

            /*comboBox_Material.SelectedIndex = -1;

            result = material_warehouse_controller.getWarehouses(materials[0].Id);
            this.warehouses = (List<Warehouse_Module.MaterialWarehouseM>)result.data;

            comboBox_Warehouse.DataSource = warehouses;
            comboBox_Warehouse.DisplayMember = "name";
            comboBox_Warehouse.SelectedIndex = -1;*/

            metroTextBox_Quantity.Text = "0";
            if (editing)
            {
                flag_material = true;
                flag_quantity = true;
                flag_warehouse = true;
                comboBox_Material.Text = line.Material_name;
                comboBox_Warehouse.Text = line.Warehouse_name;
                metroTextBox_Quantity.Text = line.Quantity_required.ToString();
                this.Text = "Edición de material";
            }
        }

        private void comboBox_Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Material.SelectedIndex != -1)
            {
                int material_id = ((Material)comboBox_Material.SelectedItem).Id;

                Result result = material_warehouse_controller.getWarehouses(material_id);
                if (result.success)
                {
                    this.warehouses = (List<Warehouse_Module.MaterialWarehouseM>)result.data;
                    comboBox_Warehouse.DataSource = null;
                    comboBox_Warehouse.DataSource = warehouses;
                    comboBox_Warehouse.DisplayMember = "name";
                    validate_comboBox(comboBox_Warehouse);
                }              
            }           
        }
        //Validaciones
        private void validate_comboBox(System.Windows.Forms.ComboBox combobox)
        {
            int index = combobox.SelectedIndex;
            if (index == -1)
            {
                flag_material = false;
                errorProvider.SetError(combobox, "Campo requerido");

            }
            else
            {
                flag_material = true;
                errorProvider.SetError(combobox, null);
            }
        }

        private void validate_textbox(MetroFramework.Controls.MetroTextBox textbox)
        {
            string text = textbox.Text;
            int num;
            if (String.IsNullOrWhiteSpace(text))
            {
                flag_quantity = false;
                errorProvider.SetError(textbox, "Campo requerido");
            }
            else if (!Int32.TryParse(text, out num) || num <= 0)
            {
                flag_quantity = false;
                errorProvider.SetError(textbox, "La cantidad debe ser mayor que cero.");
            }
            else
            {
                
                    flag_quantity = true;
                    errorProvider.SetError(textbox, null);

            }
        }

        private void comboBox_Material_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.ComboBox combobox = (System.Windows.Forms.ComboBox)sender;
            validate_comboBox(combobox);        
        }

        private void metroTextBox_Quantity_Validating(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textbox = (MetroFramework.Controls.MetroTextBox)sender;
            validate_textbox(metroTextBox_Quantity);
        }

        private void comboBox_Warehouse_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.ComboBox combobox = (System.Windows.Forms.ComboBox)sender;
            validate_comboBox(combobox);
        }

        private void metroTextBox_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;                     
        }
    }
}
