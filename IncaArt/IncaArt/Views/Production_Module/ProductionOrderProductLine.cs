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

namespace WindowsFormsApp1.Views
{
    public partial class ProductionOrderProductLine : Form
    {
        private Models.ProductionOrderProductLine line=new Models.ProductionOrderProductLine();
        private bool isRegistered=false;

        List<Product> products;
        List<ProductWarehouse> product_warehouses;
        List<Recipe> recipes;
        public ProductionOrderProductLine()
        {
            InitializeComponent();
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

        private bool validate_data()
        {
            return true;
        }
        private void button_Register_Click(object sender, EventArgs e)
        {
            if (validate_data()) {
                IsRegistered = true;
                int selectedIndex = comboBox_Product.SelectedIndex-1;
                line.Product = products[selectedIndex];
                line.Quantity = Int32.Parse(metroTextBox_Quantity.Text);
                selectedIndex = comboBox_Recipe.SelectedIndex-1;
                line.Recipe = recipes[selectedIndex];
                selectedIndex = comboBox_Warehouse.SelectedIndex-1;
                line.Warehouse = product_warehouses[selectedIndex];
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
            string user = "dp1admin";
            string password = "dp1admin";

            // ComboBox
            ProductsController product_controller = new ProductsController(user, password);
            ProductWarehouseController product_warehouse_controller = new ProductWarehouseController(user, password);
            RecipesController recipe_controller = new RecipesController(user, password);
            Result result = product_controller.getProducts();
            this.products = (List<Product>)result.data;

            result = product_warehouse_controller.getProductWarehouses();
            this.product_warehouses = (List<ProductWarehouse>)result.data;

            result = recipe_controller.getRecipes();
            this.recipes=(List<Recipe>)result.data;
            foreach (Product prod in products)
            {
                this.comboBox_Product.Items.Add(prod.Name);
            }                   

            foreach (ProductWarehouse prod_ware in product_warehouses)
            {
                this.comboBox_Warehouse.Items.Add(prod_ware.Name);
            }

            foreach (Recipe recipe in recipes)
            {
                this.comboBox_Recipe.Items.Add(recipe.Name);
            }

        }
    }
}
