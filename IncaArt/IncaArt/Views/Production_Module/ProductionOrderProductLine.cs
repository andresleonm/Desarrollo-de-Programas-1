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

namespace WindowsFormsApp1.Views
{
    public partial class ProductionOrderProductLine : Form
    {
        private Models.ProductionOrderProductLine line=new Models.ProductionOrderProductLine();
        private bool isRegistered=false;
        private bool editing = false;
        List<Product> products;
        List<Warehouse_Module.ProductWarehouseM> product_warehouses;
        List<Recipe> recipes;
        string user = "dp1admin";
        string password = "dp1admin";
        ProductsController product_controller;
        ProductWarehouseController product_warehouse_controller;
        ProductMovementDetailController product_movement_controller;
        RecipesController recipe_controller;
        UnitController unit_controller;
        public ProductionOrderProductLine()
        {
            InitializeComponent();
            product_controller = new ProductsController(user, password);
            product_warehouse_controller=new ProductWarehouseController(user,password);
            product_movement_controller = new ProductMovementDetailController(user, password);
            recipe_controller = new RecipesController(user, password);
            unit_controller = new UnitController(user, password);
        }


        internal Models.ProductionOrderProductLine Line
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

        private bool validate_data()
        {
            return true;
        }
        private void button_Register_Click(object sender, EventArgs e)
        {
            if (validate_data()) {
                IsRegistered = true;

                int selectedIndex = comboBox_Product.SelectedIndex;
                Product product_selected= products[selectedIndex];
                line.Product_id = product_selected.Id;
                line.Product_name = product_selected.Name;
             
                Result result = unit_controller.getUnit(product_selected.Unit_id);
                UnitOfMeasure unit= (UnitOfMeasure)result.data;
                line.Unit_id = unit.Id;
                line.Unit_name = unit.Name;

                line.Quantity = Int32.Parse(metroTextBox_Quantity.Text);
                Line.Produced_quantity = Int32.Parse(metroTextBox_quantity_produced.Text);
                Line.State = "Registrado";


                selectedIndex = comboBox_Recipe.SelectedIndex;
                Recipe recipe = recipes[selectedIndex];
                line.Recipe_id = recipe.Id;
                line.Recipe_name = recipe.Name;

                selectedIndex = comboBox_Warehouse.SelectedIndex;
                ProductWarehouse warehouse = product_warehouses[selectedIndex];
                line.Warehouse_id = warehouse.Id;
                line.Warehouse_name = warehouse.Name;

                this.Close();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductionOrderProductLine_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            Result result = product_controller.getProducts();
            this.products = (List<Product>)result.data;

            result = product_movement_controller.getWarehouses(products[0].Id);
            this.product_warehouses = (List<Warehouse_Module.ProductWarehouseM>)result.data;

            result = recipe_controller.getRecipes();
            this.recipes=(List<Recipe>)result.data;

            comboBox_Product.DataSource = products;
            comboBox_Product.DisplayMember = "name";
            comboBox_Warehouse.DataSource = product_warehouses;
            comboBox_Warehouse.DisplayMember = "name";
            comboBox_Recipe.DataSource =recipes;
            comboBox_Recipe.DisplayMember = "name";

            metroTextBox_quantity_produced.Text = "0";

            if (Editing)
            {
                comboBox_Product.Text = line.Product_name;
                metroTextBox_Quantity.Text = line.Quantity.ToString();
                metroTextBox_quantity_produced.Text = line.Produced_quantity.ToString();                
                comboBox_Recipe.Text = line.Recipe_name;
                comboBox_Warehouse.Text = line.Warehouse_name;
                this.Text = "Edición de producto";
            }
        }

        private void comboBox_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product_id = ((Product)comboBox_Product.SelectedItem).Id;

            Result result = product_movement_controller.getWarehouses(product_id);
            this.product_warehouses = (List<Warehouse_Module.ProductWarehouseM>)result.data;

            Recipe recipe = new Recipe();
            recipe.Product_id = product_id;
            result = recipe_controller.getRecipes(recipe);
            this.recipes = (List<Recipe>)result.data;

            comboBox_Warehouse.SelectedIndex = -1;
            comboBox_Warehouse.DataSource = product_warehouses;
            comboBox_Warehouse.DisplayMember = "name";
            comboBox_Recipe.SelectedIndex = -1;
            comboBox_Recipe.DataSource = recipes;
            comboBox_Recipe.DisplayMember = "name";

        }
    }
}
