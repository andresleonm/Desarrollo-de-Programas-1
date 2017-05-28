﻿using System;
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
        int cur_row;
        int cur_row_detail;
        List<Models.Recipe> recipe_list;
        List<Models.RecipeDetail> detail_list;
        List<Models.Material> material_list;
        List<Models.Product> product_list;
        Controller.MaterialsController materialController;
        Controller.ProductsController productController;
        Controller.RecipesController recipeController;
        Controller.UnitController unitController;
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
            unitController = new Controller.UnitController(user, password);
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
            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
        }

        private void Load_Data()
        {

            result = materialController.getMaterials();
            material_list = (List<Models.Material>)result.data;
            result = productController.getProducts();
            product_list = (List<Models.Product>)result.data;

            result = recipeController.getRecipes();
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al listar recetas", MessageBoxButtons.OK);
            }
            else
            {
                recipe_list = (List<Models.Recipe>)result.data;
            }
        }

        private void Load_DataDetail(int id)
        {
            result = recipeController.getRecipeDetails(id);
            detail_list = new List<Models.RecipeDetail>();
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al listar detalle receta", MessageBoxButtons.OK);
            }
            else
            {
                detail_list = (List<Models.RecipeDetail>)result.data;
            }

        }

        private void Load_DataGridView()
        {
            metroGrid1.Rows.Clear();
            for (int i = 0; i < recipe_list.Count(); i++)
            {
                Models.Product product = new Models.Product();
                result = productController.getProduct(recipe_list[i].Product_id);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al buscar producto", MessageBoxButtons.OK);
                }
                else
                {
                    product = (Models.Product)result.data;
                    String[] row = new String[4];
                    row[0] = recipe_list[i].Id.ToString();
                    row[1] = i.ToString();
                    row[2] = recipe_list[i].Name;
                    row[3] = product.Name;
                    this.metroGrid1.Rows.Add(row);
                }

            }
        }

        private void Load_DataGridViewDetail()
        {
            metroGrid2.Rows.Clear();
            for (int i = 0; i < detail_list.Count(); i++)
            {
                Models.Material material = new Models.Material();
                result = materialController.getMaterial(detail_list[i].Material_id);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al buscar material", MessageBoxButtons.OK);
                }
                else
                {
                    material = (Models.Material)result.data;
                    Controller.Result unit_result = unitController.getUnit(material.Unit_id);
                    if (result.data != null)
                    {
                        Models.UnitOfMeasure unit = (Models.UnitOfMeasure)unit_result.data;
                    }
                    String[] row = new String[6];
                    row[0] = detail_list[i].Recipe_id.ToString();
                    row[1] = i.ToString();
                    row[2] = detail_list[i].Operation.ToString();
                    row[3] = material.Name;
                    row[4] = unit.Name;
                    row[5] = detail_list[i].Quantity.ToString();
                    this.metroGrid2.Rows.Add(row);
                }

            }
        }

        private void Clean()
        {
            ClearTextBoxes(this);
        }

        private void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }


                if (c is CheckBox)
                {

                    ((CheckBox)c).Checked = false;
                }

                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
            }
        }

        private void btn_clean_s_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private Models.Recipe CreateRecipe(int operation)
        {
            string name, description;
            int product_id = ((KeyValuePair<int, string>)combobox_product.SelectedItem).Key;
            name = textbox_name.Text;
            description = textbox_description.Text;
            int id = 0;
            if (operation == 1)//UPDATE
            {
                id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            }
            Models.Recipe recipe = new Models.Recipe(id, product_id, name, description);
            return recipe;
        }

        //Registro Receta
        private void btn_new_Click(object sender, EventArgs e)
        {
            Models.Recipe recipe = CreateRecipe(0);
            result = recipeController.insertRecipe(recipe);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al registrar receta", MessageBoxButtons.OK);
            }
            else
            {
                Load_Data();
            }

            Load_DataGridView();
            Clean();
            metroTabControl1.SelectedIndex = 0;
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                cur_row = e.RowIndex;
                //btn_delete.Enabled = true;
            }
        }

        //Mostrar Datos Receta
        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                int id = int.Parse(metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString());
                result = recipeController.getRecipe(id);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al obtener receta", MessageBoxButtons.OK);
                }
                else
                {
                    Models.Recipe recipe = (Models.Recipe)result.data;
                    textbox_name.Text = recipe.Name;
                    for (int i = 0; i < product_list.Count(); i++)
                    {
                        if (product_list[i].Id == recipe.Product_id)
                        {
                            combobox_product.SelectedIndex = i;
                            break;
                        }
                    }
                    textbox_description.Text = recipe.Description;
                    Load_DataDetail(id);
                    Load_DataGridViewDetail();
                    metroTabControl1.SelectedIndex = 1;
                }

            }
        }

        //Modificar Receta
        private void btn_edit_Click(object sender, EventArgs e)
        {
            Models.Recipe recipe = CreateRecipe(1);
            result = recipeController.updateRecipe(recipe);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al modificar receta", MessageBoxButtons.OK);
            }
            else
            {
                int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
                recipe_list[index] = recipe;
                Load_Data();
            }

            Load_DataGridView();
            Clean();
            metroTabControl1.SelectedIndex = 0;
        }

        //Eliminar Receta
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
            result = recipeController.deleteRecipe(recipe_list[index]);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al eliminar receta", MessageBoxButtons.OK);
            }
            else
            {
                recipe_list.Remove(recipe_list[index]);
            }
            //btn_delete.Enabled = false;
            Load_DataGridView();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clean();
            metroGrid2.Rows.Clear();
            metroTabControl1.SelectedIndex = 0;
        }

        private Models.RecipeDetail CreateRecipeDetail(int operation)
        {
            int material_id = ((KeyValuePair<int, string>)combobox_material.SelectedItem).Key;
            int quantity = Int32.Parse(textbox_quantity.Text);
            int id = 0;
            char op = 'C';
            if (operation == 1)//UPDATE
            {
                id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
                op = 'U';
                
            } else if (operation ==2) //DELETE
            {
                op = 'D';
            }
            int recipe_id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            Models.RecipeDetail detail = new Models.RecipeDetail(recipe_id, material_id, quantity);
            detail.Operation = op;
            return detail;
        }

        //Agregar detalle
        private void btn_mat_add_Click(object sender, EventArgs e)
        {
            Models.RecipeDetail detail = CreateRecipeDetail(0);
            detail_list.Add(detail);
            Load_DataGridViewDetail();
        }

        //Editar detalle
        private void btn_mat_edit_Click(object sender, EventArgs e)
        {
            Models.RecipeDetail detail = CreateRecipeDetail(1);
            int index = int.Parse(metroGrid1.Rows[cur_row_detail].Cells[1].Value.ToString());
            detail_list[index] = detail;
            Load_DataGridViewDetail();
        }

        //Eliminar detalle
        private void btn_mat_delete_Click(object sender, EventArgs e)
        {
            Models.RecipeDetail detail = CreateRecipeDetail(2);
            int index = int.Parse(metroGrid1.Rows[cur_row_detail].Cells[1].Value.ToString());
            detail_list[index] = detail;
            Load_DataGridViewDetail();
        }

        private void metroGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid2.Rows[e.RowIndex].Cells[1].Value != null)
            {
                cur_row_detail = e.RowIndex;
                //btn_delete.Enabled = true;
            }
        }

        //Mostrar detalle
        private void metroGrid2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid2.Rows[cur_row_detail].Cells[1].Value != null)
            {
                int material_id = 0;
                string material_name = metroGrid2.Rows[cur_row_detail].Cells[3].Value.ToString();
                for (int i = 0; i < material_list.Count(); i++)
                {
                    if (material_list[i].Name == material_name)
                    {
                        combobox_material.SelectedIndex = i;
                        material_id = material_list[i].Id;
                        textbox_quantity.Text = metroGrid2.Rows[cur_row_detail].Cells[5].Value.ToString();
                        break;
                    }
                }

            }
        }

    }
}