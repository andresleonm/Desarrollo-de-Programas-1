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

    public partial class UC_Material : UserControl
    {
        Boolean first;
        int cur_row;
        List<Models.Material> material_list;
        List<Models.UnitOfMeasure> unit_list;
        Controller.MaterialsController materialController;
        Controller.UnitController unitController;
        public UC_Material()
        {
            InitializeComponent();
        }

        private void Material_Load(object sender, EventArgs e)
        {
            string user = "dp1admin";
            string password = "dp1admin";
            first = true;
            materialController = new Controller.MaterialsController(user, password);
            unitController = new Controller.UnitController(user, password);
            material_list = new List<Models.Material>();
            Load_Data();

            //Cargar los combobox
            Dictionary<int, string> combo_data = new Dictionary<int, string>();
            foreach (var item in unit_list)
            {
                combo_data.Add(item.Id, item.Symbol);

            }
            combobox_unit.DataSource = new BindingSource(combo_data, null);
            combobox_unit.DisplayMember = "Value";
            combobox_unit.ValueMember = "Key";
            Load_DataGridView();
        }

        private bool validate_data(String name, String unit, String max_stock, String min_stock)
        {
            bool isCorrect = true;
            int max, min;
            String message = "";
            if (name == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el nombre del material.\n";
            }
            if (unit == "")
            {
                isCorrect = false;
                message += "- Debe seleccionar la unidad del material. \n";
            }

            if (max_stock == "")
            {
                isCorrect = false;
                message += "- Debe ingresar stock máximo. \n";
            }

            if (min_stock == "")
            {
                isCorrect = false;
                message += "- Debe ingresar stock mínimo. \n";
            }

            if (max_stock != "" && min_stock != "")
            {
                max = int.Parse(max_stock);
                min = int.Parse(min_stock);
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

        private void Load_Data()
        {
            Controller.Result result;
            if (first)
            {
                first = false;
                result = unitController.getUnits();
                unit_list = (List<Models.UnitOfMeasure>)result.data;
            }

            material_list = new List<Models.Material>();
            result = materialController.getMaterials();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar material", MessageBoxButtons.OK);
            else material_list = (List<Models.Material>)result.data;
        }

        private void Load_DataGridView()
        {
            Load_Data();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < material_list.Count(); i++)
            {
                Models.UnitOfMeasure unit = new Models.UnitOfMeasure();
                Controller.Result result = unitController.getUnit(material_list[i].Unit_id);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al buscar unit", MessageBoxButtons.OK);
                }
                else
                {
                    unit = (Models.UnitOfMeasure)result.data;
                    String[] row = new String[5];
                    row[0] = material_list[i].Id.ToString();
                    row[1] = material_list[i].Name;
                    row[2] = unit.Name;
                    row[3] = material_list[i].Stock_min.ToString();
                    row[4] = material_list[i].Stock_max.ToString();
                    this.dataGridView1.Rows.Add(row);
                }

            }
        }

        private void Clean()
        {
            textbox_name.Text = "";
            combobox_unit.Text = "";
            textbox_min_stock.Text = "";
            textbox_max_stock.Text = "";
            textbox_name_s.Text = "";
            combobox_unit_s.Text = "";
        }

        //Cancelar
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clean();
        }


        //Registrar
        private void btn_new_Click(object sender, EventArgs e)
        {
            String name, unit;
            name = textbox_name.Text;
            unit = ((KeyValuePair<int, string>)combobox_unit.SelectedItem).Value;
            if (validate_data(name, unit, textbox_max_stock.Text, textbox_min_stock.Text))
            {
                int min_stock, max_stock;
                min_stock = int.Parse(textbox_min_stock.Text);
                max_stock = int.Parse(textbox_max_stock.Text);

                Models.Material mat = new Models.Material();

                int unit_id = ((KeyValuePair<int, string>)combobox_unit.SelectedItem).Key;
                mat = new Models.Material(0, unit_id, name, min_stock, max_stock);
                Controller.Result result = materialController.insertMaterial(mat);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al registrar material", MessageBoxButtons.OK);
                }

                Load_DataGridView();
                Clean();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cur_row = e.RowIndex;
            if (dataGridView1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                btn_delete.Enabled = true;
            }
        }

        //Mostrar Datos
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cur_row = e.RowIndex;
            if (dataGridView1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                textbox_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                combobox_unit.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textbox_min_stock.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textbox_max_stock.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        //Modificar Datos
        private void btn_edit_Click(object sender, EventArgs e)
        {
            String name, unit;
            unit = combobox_unit.Text;

            name = textbox_name.Text;
            unit = combobox_unit.Text;
            if (validate_data(name, unit, textbox_max_stock.Text, textbox_min_stock.Text))
            {
                int min_stock = int.Parse(textbox_min_stock.Text);
                int max_stock = int.Parse(textbox_max_stock.Text);

                Models.Material mat = new Models.Material();
                mat.Id = int.Parse(dataGridView1.Rows[cur_row].Cells[0].Value.ToString());
                mat.Name = name;
                foreach (var item in unit_list)
                {
                    if (unit == item.Symbol)
                    {
                        mat.Unit = item;
                        break;
                    }
                }
                mat.Stock_min = min_stock;
                mat.Stock_max = max_stock;

                for (int i = 0; i < material_list.Count(); i++)
                {
                    if (mat.Id == material_list[i].Id)
                    {
                        material_list[i].Name = mat.Name;
                        material_list[i].Stock_max = mat.Stock_max;
                        material_list[i].Stock_min = mat.Stock_min;
                        material_list[i].Unit = mat.Unit;
                        break;
                    }
                }
                Load_DataGridView();
                Clean();
            }


        }

        //Buscar
        private void btn_search_Click(object sender, EventArgs e)
        {
            String name = textbox_name_s.Text, unit = combobox_unit_s.Text;
            Load_DataGridView();
        }

        //Eliminar
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[cur_row].Cells[0].Value.ToString());
            for (int i = 0; i < material_list.Count(); i++)
            {
                if (id == material_list[i].Id)
                {
                    material_list.Remove(material_list[i]);
                    break;
                }
            }
            btn_delete.Enabled = false;
            Load_DataGridView();
        }
    }
}
