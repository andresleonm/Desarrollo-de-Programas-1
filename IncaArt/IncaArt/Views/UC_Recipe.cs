using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class UC_Recipe : MetroFramework.Controls.MetroUserControl
    {
        Boolean first;
        int cur_row;
        List<Models.Recipe> recipe_list;
        List<Models.RecipeDetail> detail_list;
        List<Models.Material> material_list;
        List<Models.Product> product_list;
        Controller.MaterialsController materialController;
        Controller.ProductsController productController;
        Controller.RecipesController recipeController;
        Controller.Result result;
        public UC_Recipe()
        {
            InitializeComponent();
        }

        private void UC_Recipe_Load(object sender, EventArgs e)
        {
            string user = "dp1admin";
            string password = "dp1admin";
            materialController = new Controller.MaterialsController(user, password);
            productController = new Controller.ProductsController(user, password);
            recipeController = new Controller.RecipesController(user, password);
            first = true;
            Load_Data();
            //Cargar los combobox
            Dictionary<int, string> combo_data = new Dictionary<int, string>();
            foreach (var item in material_list)
            {
                combo_data.Add(item.Id, item.Name);

            }
            combobox_material.DataSource = new BindingSource(combo_data, null);
            combobox_material.DisplayMember = "Value";
            combobox_material.ValueMember = "Key";
            combobox_material.DataSource = new BindingSource(combo_data, null);
            combo_data = new Dictionary<int, string>();
            foreach (var item in product_list)
            {
                combo_data.Add(item.Id, item.Name);

            }
            combobox_product.DisplayMember = "Value";
            combobox_product.ValueMember = "Key";
            combobox_product.DataSource = new BindingSource(combo_data, null);
            //Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
        }

        private void Load_Data()
        {
            if (first)
            {
                first = false;
                result = materialController.getMaterials();
                material_list = (List<Models.Material>)result.data;
                result = productController.getProducts();
                product_list = (List<Models.Product>)result.data;
            }
            result = recipeController.getRecipes();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar recetas", MessageBoxButtons.OK);
            else recipe_list = (List<Models.Recipe>)result.data;
        }
    }
}