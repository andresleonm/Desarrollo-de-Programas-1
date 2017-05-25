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
        int last_id;
        int cur_row;
        List<Models.Material> material_list;
        List<Models.UnitOfMeasure> unit_list;
        Controller.MaterialsController materialController;
        public UC_Material()
        {
            InitializeComponent();
        }

        private void Material_Load(object sender, EventArgs e)
        {
            unit_list = ((Dashboard)Parent).unit_list;
            material_list = ((Dashboard)Parent).material_list;
            last_id = material_list.Count();

            Models.UnitOfMeasure unit = new Models.UnitOfMeasure();
            unit.Name = "Kilogramos";
            unit.Symbol = "1";
            unit_list.Add(unit);
            unit = new Models.UnitOfMeasure();
            unit.Name = "Gramos";
            unit.Symbol = "2";
            unit_list.Add(unit);
            unit = new Models.UnitOfMeasure();
            unit.Name = "Listones";
            unit.Symbol = "3";
            unit_list.Add(unit);

            //Cargar los combobox
            foreach (var item in unit_list)
            {
                combobox_unit.Items.Add(item.Symbol);
                combobox_unit_s.Items.Add(item.Symbol);
            }
            Load_DataGridView("", "");
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

        int Search_condition(String name, String unit)
        {
            if (name == "" && unit == "")
            {
                return 1;
            }
            else if (name == "" && unit != "")
            {
                return 2;
            }
            else if (name != "" && unit == "")
            {
                return 3;
            }
            return 4;
        }

        private void Load_DataGridView(String name, String unit)
        {
            dataGridView1.Rows.Clear();
            int condition = Search_condition(name, unit);
            for (int i = 0; i < material_list.Count(); i++)
            {
                if (material_list[i].Status == 1)
                {
                    Boolean found = false;
                    switch (condition)
                    {
                        case 1:
                            found = true;
                            break;
                        case 2:
                            if (unit == material_list[i].Unit.Symbol) found = true;
                            break;
                        case 3:
                            if (name == material_list[i].Name) found = true;
                            break;
                        case 4:
                            if (name == material_list[i].Name && unit == material_list[i].Unit.Symbol) found = true;
                            break;
                    }

                    if (found)
                    {
                        String[] row = new String[5];
                        row[0] = material_list[i].Id.ToString();
                        row[1] = material_list[i].Name;
                        row[2] = material_list[i].Unit.Symbol;
                        row[3] = material_list[i].Min_stock.ToString();
                        row[4] = material_list[i].Max_stock.ToString();
                        this.dataGridView1.Rows.Add(row);
                    }

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
            unit = combobox_unit.Text;
            if (validate_data(name, unit, textbox_max_stock.Text, textbox_min_stock.Text))
            {
                int min_stock, max_stock;
                min_stock = int.Parse(textbox_min_stock.Text);
                max_stock = int.Parse(textbox_max_stock.Text);

                Models.Material mat = new Models.Material();
                mat.Id = last_id;
                last_id++;
                mat.Name = name;
                foreach (var item in unit_list)
                {
                    if (unit == item.Symbol)
                    {
                        mat.Unit = item;
                        break;
                    }
                }
                mat.Min_stock = min_stock;
                mat.Max_stock = max_stock;
                mat.Status = 1;

                material_list.Add(mat);
                Load_DataGridView("", "");
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
                mat.Min_stock = min_stock;
                mat.Max_stock = max_stock;

                for (int i = 0; i < material_list.Count(); i++)
                {
                    if (mat.Id == material_list[i].Id)
                    {
                        material_list[i].Name = mat.Name;
                        material_list[i].Max_stock = mat.Max_stock;
                        material_list[i].Min_stock = mat.Min_stock;
                        material_list[i].Unit = mat.Unit;
                        break;
                    }
                }
                Load_DataGridView("", "");
                Clean();
            }


        }

        //Buscar
        private void btn_search_Click(object sender, EventArgs e)
        {
            String name = textbox_name_s.Text, unit = combobox_unit_s.Text;
            Load_DataGridView(name, unit);
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
            Load_DataGridView("", "");
        }
    }
}
