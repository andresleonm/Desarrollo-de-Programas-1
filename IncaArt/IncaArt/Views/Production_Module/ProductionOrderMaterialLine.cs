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
            return true;
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
            Result result = material_controller.getMaterials();
            this.materials = (List<Material>)result.data;

            result = material_warehouse_controller.getWarehouses(materials[0].Id);
            this.warehouses = (List<Warehouse_Module.MaterialWarehouseM>)result.data;

            comboBox_Material.DataSource = materials;
            comboBox_Material.DisplayMember = "name";

            comboBox_Warehouse.DataSource = warehouses;
            comboBox_Warehouse.DisplayMember = "name";

            if (editing)
            {
                comboBox_Material.Text = line.Material_name;
                comboBox_Warehouse.Text = line.Warehouse_name;
                metroTextBox_Quantity.Text = line.Quantity_required.ToString();
                this.Text = "Edición de material";
            }
        }

        private void comboBox_Warehouse_SelectedIndexChanged(object sender, EventArgs e)
        {

                       
        }

        private void comboBox_Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            int material_id = ((Material)comboBox_Material.SelectedItem).Id;

            Result result = material_warehouse_controller.getWarehouses(material_id);
            this.warehouses = (List<Warehouse_Module.MaterialWarehouseM>)result.data;

            comboBox_Warehouse.DataSource = warehouses;
            comboBox_Warehouse.DisplayMember = "name";
            comboBox_Warehouse.SelectedIndex = -1;
        }
    }
}
