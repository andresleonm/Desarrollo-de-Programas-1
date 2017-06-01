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
    public partial class UC_Material : MetroFramework.Controls.MetroUserControl
    {
        int cur_row;
        List<Models.Material> material_list;
        List<Models.UnitOfMeasure> unit_list;
        Controller.MaterialsController materialController;
        Controller.UnitController unitController;
        Controller.Result result;
        public UC_Material()
        {
            InitializeComponent();
        }

        private void UC_Material_Load(object sender, EventArgs e)
        {
            string user = "dp1admin";
            string password = "dp1admin";
            materialController = new Controller.MaterialsController(user, password);
            unitController = new Controller.UnitController(user, password);
            material_list = new List<Models.Material>();
            Load_Data();

            //Cargar los combobox
            Dictionary<int, string> combo_data = new Dictionary<int, string>();
            //Unidades
            combo_data.Add(0, "Seleccionar");
            foreach (var item in unit_list)
            {
                combo_data.Add(item.Id, item.Symbol);

            }
            combobox_unit.DataSource = new BindingSource(combo_data, null);
            combobox_unit.DisplayMember = "Value";
            combobox_unit.ValueMember = "Key";

            combobox_unit_s.DataSource = new BindingSource(combo_data, null);
            combobox_unit_s.DisplayMember = "Value";
            combobox_unit_s.ValueMember = "Key";
            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
        }

        private void Load_Data()
        {
            result = unitController.getUnits();
            unit_list = (List<Models.UnitOfMeasure>)result.data;
            material_list = new List<Models.Material>();
            result = materialController.getMaterials();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar material", MessageBoxButtons.OK);
            else material_list = (List<Models.Material>)result.data;
        }

        private bool validate_data()
        {
            bool isCorrect = true;
            int unit_id = ((KeyValuePair<int, string>)combobox_unit.SelectedItem).Key;
            int max, min;
            string name = textbox_name.Text;
            string stock_min = textbox_stock_min.Text;
            string stock_max = textbox_stock_max.Text;
            String message = "";
            if (name == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el nombre del material.\n";
            }
            if (unit_id == 0)
            {
                isCorrect = false;
                message += "- Debe seleccionar la unidad del material. \n";
            }

            if (stock_min == "")
            {
                isCorrect = false;
                message += "- Debe ingresar stock mínimo. \n";
            }
            else if (!Int32.TryParse(stock_min, out min))
            {
                isCorrect = false;
                message += "- stock mínimo debe ser número. \n";
            }

            if (stock_max == "")
            {
                isCorrect = false;
                message += "- Debe ingresar stock máximo. \n";
            }
            else if (!Int32.TryParse(stock_max, out max))
            {
                isCorrect = false;
                message += "- stock máximo debe ser número. \n";
            }

            if (Int32.TryParse(stock_max, out max) && Int32.TryParse(stock_min, out min))
            {
                if (max < min)
                {
                    isCorrect = false;
                    message += "- El stock mínimo debe ser menor al stock máximo\n";
                }
            }

            if (!isCorrect)
            {
                MessageBox.Show(message, "Error al registrar material", MessageBoxButtons.OK);
            }
            return isCorrect;
        }

        private void Load_DataGridView()
        {
            metroGrid1.Rows.Clear();
            for (int i = 0; i < material_list.Count(); i++)
            {
                Models.UnitOfMeasure unit = new Models.UnitOfMeasure();
                result = unitController.getUnit(material_list[i].Unit_id);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al buscar unit", MessageBoxButtons.OK);
                }
                else
                {
                    unit = (Models.UnitOfMeasure)result.data;
                    String[] row = new String[6];
                    row[0] = material_list[i].Id.ToString();
                    row[1] = i.ToString();
                    row[2] = material_list[i].Name;
                    row[3] = unit.Name;
                    row[4] = material_list[i].Stock_min.ToString();
                    row[5] = material_list[i].Stock_max.ToString();
                    this.metroGrid1.Rows.Add(row);
                }

            }
        }

        private void Clean()
        {
            ClearTextBoxes(this);
            combobox_unit.SelectedIndex = 0;
            combobox_unit_s.SelectedIndex = 0;
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

        private Models.Material CreateMaterial(int operacion)
        {
            //if (!validate_data())
            //{
            //    return null;
            //}
            String name, unit;
            name = textbox_name.Text;
            unit = ((KeyValuePair<int, string>)combobox_unit.SelectedItem).Value;

            int min_stock, max_stock, id = 0;
            min_stock = int.Parse(textbox_stock_min.Text);
            max_stock = int.Parse(textbox_stock_max.Text);
            int unit_id = ((KeyValuePair<int, string>)combobox_unit.SelectedItem).Key;
            Models.Material mat = new Models.Material();

            if (operacion == 1) //UPDATE
            {
                id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            }
            mat = new Models.Material(id, unit_id, name, min_stock, max_stock);

            return mat;
        }

        //Registrar
        private void btn_new_Click(object sender, EventArgs e)
        {

            Models.Material mat = CreateMaterial(0);
            if (mat != null)
            {
                result = materialController.insertMaterial(mat);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al registrar material", MessageBoxButtons.OK);
                }
                else
                {
                    Load_Data();
                }

                Load_DataGridView();
                Clean();
                metroTabControl1.SelectedIndex = 0;
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                cur_row = e.RowIndex;
                btn_delete.Enabled = true;
            }
        }

        //Mostrar Datos
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cur_row = e.RowIndex;
            if (metroGrid1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                textbox_name.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
                for (int i = 0; i < unit_list.Count(); i++)
                {
                    if (unit_list[i].Name == metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString())
                    {
                        combobox_unit.SelectedIndex = i;
                        break;
                    }
                }
                textbox_stock_min.Text = metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textbox_stock_max.Text = metroGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();
                metroTabControl1.SelectedIndex = 1;
            }
        }

        //Modificar Datos
        private void btn_edit_Click(object sender, EventArgs e)
        {
            Models.Material mat = CreateMaterial(1);
            if (mat != null)
            {
                result = materialController.updateMaterial(mat);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al modificar material", MessageBoxButtons.OK);
                }
                else
                {
                    int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
                    material_list[index] = mat;
                }

                Load_DataGridView();
                Clean();
                metroTabControl1.SelectedIndex = 0;
            }


        }

        //Buscar
        private void btn_search_Click(object sender, EventArgs e)
        {
            Models.Material material = new Models.Material();
            material.Name = textbox_name_s.Text;
            material.Unit_id = ((KeyValuePair<int, string>)combobox_unit_s.SelectedItem).Key;
            result = materialController.getMaterials(material);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al buscar material con filtros", MessageBoxButtons.OK);
            }
            else
            {
                material_list = (List<Models.Material>)result.data;
                Load_DataGridView();
            }
        }

        //Eliminar
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
            result = materialController.deleteMaterial(material_list[index]);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al eliminar material", MessageBoxButtons.OK);
            }
            else
            {
                material_list.Remove(material_list[index]);
            }
            btn_delete.Enabled = false;
            Load_DataGridView();
        }

        private void btn_clean_s_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Ya2", "Ya", MessageBoxButtons.OK);
            }
            Clean();
            metroTabControl1.SelectedIndex = 0;
        }

        private bool Validate_Data()
        {
            string nameText = textbox_name.Text;

            if (String.IsNullOrEmpty(nameText))
            {
                errorProvider.SetError(textbox_name, "Nombre plz");
                return false;
            }
            errorProvider.SetError(textbox_name, null);
            return true;
        }

        private void textbox_name_Validating(object sender, CancelEventArgs e)
        {
            string nameText = ((MetroFramework.Controls.MetroTextBox)sender).Text;
            
            if (String.IsNullOrEmpty(nameText))
            {
                //e.Cancel = true;
                errorProvider.SetError((MetroFramework.Controls.MetroTextBox)sender, ((MetroFramework.Controls.MetroTextBox)sender).Name);

            }
            else
            {
                //e.Cancel = false;
                errorProvider.SetError(textbox_name, null);
            }
            
            
        }

        private void combobox_unit_Validating(object sender, CancelEventArgs e)
        {
            int unit_id = ((KeyValuePair<int, string>)combobox_unit.SelectedItem).Key;

            if (unit_id==0)
            {
                //e.Cancel = true;
                errorProvider.SetError(combobox_unit, "combo plz");

            }
            else
            {
                //e.Cancel = false;
                errorProvider.SetError(combobox_unit, null);
            }
        }
    }
}
