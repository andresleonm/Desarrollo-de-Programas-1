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
        bool name_flag;
        bool description_flag;
        bool product_flag;
        bool material_flag;
        bool quantity_flag;
        int cur_row;
        int cur_row_detail;
        int operation_value;// 0 para Create, 1 para Update
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

        private void UC_Recipe_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                Set_Flag_All(false);
                operation_value = 0;
                Load_Data();
                Load_DataGridView();
                metroTabControl1.SelectedIndex = 0;
                detail_list = new List<Models.RecipeDetail>();
            }
        }

        private void UC_Recipe_Load(object sender, EventArgs e)
        {

            string user = "";
            string password = "";
            operation_value = 0;
            materialController = new Controller.MaterialsController(user, password);
            productController = new Controller.ProductsController(user, password);
            recipeController = new Controller.RecipesController(user, password);
            unitController = new Controller.UnitController(user, password);
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
            Load_Combobox();
        }

        private void Load_Combobox()
        {
            //Cargar los combobox

            Dictionary<int, string> combo_data = new Dictionary<int, string>();
            combo_data.Add(0, "Seleccionar");
            foreach (var item in material_list)
            {
                combo_data.Add(item.Id, item.Name);

            }
            combobox_material.DataSource = new BindingSource(combo_data, null);
            combobox_material.DisplayMember = "Value";
            combobox_material.ValueMember = "Key";
            combobox_material.DataSource = new BindingSource(combo_data, null);

            combo_data = new Dictionary<int, string>();
            combo_data.Add(0, "Seleccionar");
            foreach (var item in product_list)
            {
                combo_data.Add(item.Id, item.Name);

            }
            combobox_product.DisplayMember = "Value";
            combobox_product.ValueMember = "Key";
            combobox_product.DataSource = new BindingSource(combo_data, null);

            combobox_product_s.DisplayMember = "Value";
            combobox_product_s.ValueMember = "Key";
            combobox_product_s.DataSource = new BindingSource(combo_data, null);
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
            Controller.Result unit_result;
            Models.UnitOfMeasure unit = new Models.UnitOfMeasure();
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
                    unit_result = unitController.getUnit(material.Unit_id);
                    if (result.data != null)
                    {
                        unit = (Models.UnitOfMeasure)unit_result.data;
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
            combobox_material.SelectedIndex = 0;
            combobox_product.SelectedIndex = 0;
            combobox_product_s.SelectedIndex = 0;
            combobox_product.Enabled = true;
        }

        private void Clean_Material()
        {
            textbox_quantity.Text = "";
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
            if (!Validate_Data(true))
            {
                MessageBox.Show("Hay campos inválidos", "Error", MessageBoxButtons.OK);
                return null;
            }
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
            if (recipe != null)
            {
                result = recipeController.insertRecipe(recipe);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al registrar receta", MessageBoxButtons.OK);
                }
                else
                {
                    Load_Data();
                    int id = recipe_list[recipe_list.Count - 1].Id;
                    foreach (var item in detail_list)
                    {
                        
                    }
                    Detail_Operation();
                    MessageBox.Show("Receta registrada correctamente", "Registrar receta", MessageBoxButtons.OK);
                    Set_Flag_All(false);
                    metroGrid2.Rows.Clear();
                }

                Load_DataGridView();
                Clean();
                detail_list = new List<Models.RecipeDetail>();
                metroTabControl1.SelectedIndex = 0;
            }
            
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
                            combobox_product.SelectedIndex = i+1;
                            break;
                        }
                    }
                    textbox_description.Text = recipe.Description;
                    Load_DataDetail(id);
                    Load_DataGridViewDetail();
                    metroTabControl1.SelectedIndex = 1;
                    Set_Flag_All(true);
                    operation_value = 1;
                    combobox_product.Enabled = false;
                }

            }
        }

        //Modificar Receta
        private void btn_edit_Click(object sender, EventArgs e)
        {
            Models.Recipe recipe = CreateRecipe(1);
            if (recipe != null)
            {
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
                    Detail_Operation();
                    metroGrid2.Rows.Clear();
                }
                Load_DataGridView();
                Clean();
                detail_list = new List<Models.RecipeDetail>();
                metroTabControl1.SelectedIndex = 0;
                Set_Flag_All(false);
                MessageBox.Show("Receta editado correctamente", "Editar receta", MessageBoxButtons.OK);
            }
            
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
                MessageBox.Show("Receta eliminado correctamente", "Eliminar receta", MessageBoxButtons.OK);
                Load_Data();
            }
            //btn_delete.Enabled = false;
            detail_list = new List<Models.RecipeDetail>();
            Load_DataGridView();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clean();
            metroGrid2.Rows.Clear();
            detail_list = new List<Models.RecipeDetail>();
            metroTabControl1.SelectedIndex = 0;
            operation_value = 0;
        }

        private Models.RecipeDetail CreateRecipeDetail(int operation)
        {
            if (!Validate_Data(false))
            {
                return null;
            }
            int material_id = ((KeyValuePair<int, string>)combobox_material.SelectedItem).Key;
            int quantity = Int32.Parse(textbox_quantity.Text);
            int recipe_id = 0;
            if (operation_value!=0)recipe_id= int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            char antOp = 'N', op = 'C';
            
            if (operation != 0)
            {
                int index = Int32.Parse(metroGrid1.Rows[cur_row_detail].Cells[1].Value.ToString());
                antOp = detail_list[index].Operation;
            }
            if (operation == 1)//UPDATE
            {
                if (antOp != 'C')
                {
                    op = 'U';
                }

            }
            else if (operation == 2) //DELETE
            {
                if (antOp != 'C') op = 'D';
                else op = 'E';
            }
            Models.RecipeDetail detail = new Models.RecipeDetail(recipe_id, material_id, quantity);
            detail.Operation = op;
            return detail;
        }

        //Agregar detalle
        private void btn_mat_add_Click(object sender, EventArgs e)
        {
            Models.RecipeDetail detail = CreateRecipeDetail(0);
            if (detail != null)
            {
                foreach (var item in detail_list)
                {
                    if (item.Material_id == detail.Material_id)
                    {
                        MessageBox.Show("Material existente en la receta", "Error", MessageBoxButtons.OK);
                        return;
                    }
                }
                detail_list.Add(detail);
                Clean_Material();
                Load_DataGridViewDetail();
                quantity_flag = false;
                material_flag = false;
            }
        }

        //Editar detalle
        private void btn_mat_edit_Click(object sender, EventArgs e)
        {
            Models.RecipeDetail detail = CreateRecipeDetail(1);
            if (detail != null)
            {
                int index = int.Parse(metroGrid1.Rows[cur_row_detail].Cells[1].Value.ToString());
                if (detail.Operation == 'C')
                {
                    detail_list[index].Quantity = detail.Quantity;
                }else
                {
                    detail_list[index] = detail;
                }
                
                Clean_Material();
                Load_DataGridViewDetail();
                quantity_flag = false;
                material_flag = false;
            }
            
        }

        //Eliminar detalle
        private void btn_mat_delete_Click(object sender, EventArgs e)
        {
            Models.RecipeDetail detail = CreateRecipeDetail(2);
            int index = int.Parse(metroGrid1.Rows[cur_row_detail].Cells[1].Value.ToString());
            if (detail.Operation == 'E')
            {
                detail_list.RemoveAt(index);
            }
            else
            {
                detail_list[index] = detail;
            }
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
                        combobox_material.SelectedIndex = i+1;
                        material_id = material_list[i].Id;
                        textbox_quantity.Text = metroGrid2.Rows[cur_row_detail].Cells[5].Value.ToString();
                        quantity_flag = true;
                        material_flag = true;
                        break;
                    }
                }

            }
        }

        private void Detail_Operation()
        {
            foreach (var item in detail_list)
            {
                switch (item.Operation)
                {
                    case 'C':
                        result = recipeController.insertRecipeDetail(item);
                        if (result.data == null)
                        {
                            MessageBox.Show(result.message, "Error al registrar detalle receta", MessageBoxButtons.OK);
                        }
                        break;
                    case 'U':
                        result = recipeController.updateRecipeDetail(item);
                        if (result.data == null)
                        {
                            MessageBox.Show(result.message, "Error al modificar detalle receta", MessageBoxButtons.OK);
                        }
                        break;
                    case 'D':
                        result = recipeController.deleteRecipeDetail(item);
                        if (result.data == null)
                        {
                            MessageBox.Show(result.message, "Error al eliminar detalle receta", MessageBoxButtons.OK);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Models.Recipe recipe = new Models.Recipe();
            recipe.Name = textbox_name_s.Text;
            recipe.Product_id = ((KeyValuePair<int, string>)combobox_product_s.SelectedItem).Key;
            result = recipeController.getRecipes(recipe);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al buscar receta con filtros", MessageBoxButtons.OK);
            }
            else
            {
                recipe_list = (List<Models.Recipe>)result.data;
                Load_DataGridView();
            }
        }

        private void textbox_Validating(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textbox = (MetroFramework.Controls.MetroTextBox)sender;
            string text = textbox.Text;

            if (String.IsNullOrWhiteSpace(text))
            {
                //e.Cancel = true;
                Set_Flag(textbox.Name, false);
                errorProvider.SetError(textbox, "Campo requerido");

            }
            else
            {
                //e.Cancel = false;
                Set_Flag(textbox.Name, true);
                errorProvider.SetError(textbox, null);
            }
        }

        private void textbox_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textbox = (MetroFramework.Controls.MetroTextBox)sender;
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != 8)//Manejo de Backspace
                {
                    e.Handled = true;
                }
            }
        }

        private void textbox_number_Validating(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textbox = (MetroFramework.Controls.MetroTextBox)sender;
            string text = textbox.Text;

            if (String.IsNullOrWhiteSpace(text))
            {
                Set_Flag(textbox.Name, false);
                errorProvider.SetError(textbox, "Campo requerido");

            }
            else
            {
                errorProvider.SetError(textbox, null);
                int number;
                if (!int.TryParse(text, out number))
                {
                    Set_Flag(textbox.Name, false);
                    errorProvider.SetError(textbox, "Cantidad debe ser número");
                }
                else
                {
                    Set_Flag(textbox.Name, true);
                }
            }
        }

        private void combobox_Validating(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroComboBox combobox = (MetroFramework.Controls.MetroComboBox)sender;
            int id = ((KeyValuePair<int, string>)combobox.SelectedItem).Key;
            if (id == 0)
            {
                Set_Flag(combobox.Name, false);
                errorProvider.SetError(combobox, "Se debe seleccionar");

            }
            else
            {
                Set_Flag(combobox.Name, true);
                errorProvider.SetError(combobox, null);
            }
        }

        private bool Validate_Data(bool recipe)
        {
            if (recipe) //Receta
            {
                if (name_flag && description_flag && product_flag)
                {
                    return true;
                }
                return false;
            }
            else //Detalle
            {
                if (material_flag && quantity_flag)
                {
                    return true;
                }
                return false;
            }
        }

        private void Set_Flag_All(bool value)
        {
            name_flag = value;
            description_flag = value;
            product_flag = value;
            material_flag = value;
            quantity_flag = value;
        }

        private void Set_Flag(string name, bool value)
        {
            switch (name)
            {
                case "textbox_name":
                    name_flag = value;
                    break;
                case "textbox_description":
                    description_flag = value;
                    break;
                case "combobox_product":
                    product_flag = value;
                    break;
                case "combobox_material":
                    material_flag = value;
                    break;
                case "textbox_quantity":
                    quantity_flag = value;
                    break;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Models.Recipe recipe = CreateRecipe(operation_value);
            if (recipe != null)
            {
                if (recipe.Id == 0)
                {
                    result = recipeController.insertRecipe(recipe);
                    if (result.data == null)
                    {
                        MessageBox.Show(result.message, "Error al registrar receta", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Receta registrada correctamente", "Registrar receta", MessageBoxButtons.OK);
                    }
                }else
                {
                    result = recipeController.updateRecipe(recipe);
                    if (result.data == null)
                    {
                        MessageBox.Show(result.message, "Error al modificar receta", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Receta editado correctamente", "Editar receta", MessageBoxButtons.OK);

                    }
                    
                }
                Load_Data();
                if (recipe.Id == 0)
                {
                    int id = recipe_list[recipe_list.Count - 1].Id;
                    foreach (var item in detail_list)
                    {
                        item.Recipe_id = id;
                    }
                }
                Detail_Operation();
                metroGrid2.Rows.Clear();
                Load_DataGridView();
                Clean();
                detail_list = new List<Models.RecipeDetail>();
                metroTabControl1.SelectedIndex = 0;
                Set_Flag_All(false);
                operation_value = 0;
                combobox_product.Enabled = true;
            }
        }

    }
}