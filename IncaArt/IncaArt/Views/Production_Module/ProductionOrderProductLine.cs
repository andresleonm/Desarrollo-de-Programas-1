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

        //validaciones
        bool flag_product = false;
        bool flag_quantity = false;
        bool flag_quantity_produced = false;
        bool flag_recipe= true;
        bool flag_warehouse = true;

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
            bool isCorrect = true;
            validate_comboBox(comboBox_Product);
            validate_comboBox(comboBox_Recipe);
            validate_comboBox(comboBox_Warehouse);
            validate_textbox(metroTextBox_Quantity);
            validate_textbox(metroTextBox_quantity_produced);

            if (!flag_product || !flag_quantity || !flag_quantity_produced|| !flag_recipe || !flag_warehouse)
            {
                MessageBox.Show("Hay campos inválidos en los datos del detalle de producto.", "Error en el registro", MessageBoxButtons.OK);
                isCorrect = false;
            }
            return isCorrect;
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
            Result result = product_controller.getProducts_withWarehouses();
            this.products = (List<Product>)result.data;
            comboBox_Product.DataSource = products;
            comboBox_Product.DisplayMember = "name";

            /*result = product_movement_controller.getWarehouses(products[0].Id);
            this.product_warehouses = (List<Warehouse_Module.ProductWarehouseM>)result.data;
            comboBox_Warehouse.DataSource = product_warehouses;
            comboBox_Warehouse.DisplayMember = "name";
            comboBox_Warehouse.SelectedIndex = -1;

            result = recipe_controller.getRecipes();
            this.recipes=(List<Recipe>)result.data;
            comboBox_Recipe.DataSource =recipes;
            comboBox_Recipe.DisplayMember = "name";
            comboBox_Recipe.SelectedIndex = -1;*/

            metroTextBox_quantity_produced.Text = "0";

            if (Editing)
            {
                flag_product = true;
                flag_quantity = true;
                flag_quantity_produced= true;
                flag_recipe = true;
                flag_warehouse = true;
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
            if (comboBox_Product.SelectedIndex != -1)
            {
                int product_id = ((Product)comboBox_Product.SelectedItem).Id;

                Result result = product_movement_controller.getWarehouses(product_id);
                this.product_warehouses = (List<Warehouse_Module.ProductWarehouseM>)result.data;
                comboBox_Warehouse.DataSource = null;
                comboBox_Warehouse.DataSource = product_warehouses;
                comboBox_Warehouse.DisplayMember = "name";
                validate_comboBox(comboBox_Warehouse);

                Recipe recipe = new Recipe();
                recipe.Product_id = product_id;
                result = recipe_controller.getRecipes(recipe);
                this.recipes = (List<Recipe>)result.data;
                comboBox_Recipe.DataSource=null;
                comboBox_Recipe.DataSource = recipes;
                comboBox_Recipe.DisplayMember = "name";
                validate_comboBox(comboBox_Recipe);
            }
          
        }
        //Validaciones

        private void setFlag(string name,bool value)
        {
            switch (name)
            {
                case "comboBox_Product":
                    flag_product = value;
                    break;
                case "metroTextBox_Quantity":
                    flag_quantity = value;
                    break;
                case "metroTextBox_quantity_produced":
                    flag_quantity_produced = value;
                    break;
                case "comboBox_Recipe":
                    flag_recipe = value;
                    break;
                case "comboBox_Warehouse":
                    flag_warehouse = value;
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
                if(num==0 && textbox.Name == "metroTextBox_quantity_produced")
                {
                    setFlag(textbox.Name, true);
                    errorProvider.SetError(textbox, null);
                }else{
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

        private void metroTextBox_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
        }

        private void metroTextBox_quantity_produced_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
        }
    }
}
