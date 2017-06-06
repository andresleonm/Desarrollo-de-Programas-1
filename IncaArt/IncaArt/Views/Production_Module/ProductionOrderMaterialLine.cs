﻿using System;
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

        List<Material> materials;
        List<MaterialWarehouse> warehouses;
        string user = "dp1admin";
        string password = "dp1admin";

        MaterialsController material_controller;
        MaterialWarehouseController material_warehouse_controller;
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

        public ProductionOrderMaterialLine()
        {
            InitializeComponent();
            material_controller = new MaterialsController(user, password);
            material_warehouse_controller = new MaterialWarehouseController(user, password);
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
                Line.Quantity_taken_real = 0;
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

            result = material_warehouse_controller.getMaterialWarehouses();
            this.warehouses = (List<MaterialWarehouse>)result.data;

            comboBox_Material.DataSource = materials;
            comboBox_Material.DisplayMember = "name";

            comboBox_Warehouse.DataSource = warehouses;
            comboBox_Warehouse.DisplayMember = "name";
        }
    }
}
