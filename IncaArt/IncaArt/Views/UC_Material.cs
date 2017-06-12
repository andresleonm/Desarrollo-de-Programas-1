using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace WindowsFormsApp1.Views
{
    public partial class UC_Material : MetroFramework.Controls.MetroUserControl
    {
        bool name_flag;
        bool unit_flag;
        bool max_flag;
        bool min_flag;
        int cur_row;
        int operation_value;// 0 para Create, 1 para Update
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
            Set_Flag_All(false);
            operation_value = 0;
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
                if (c is System.Windows.Forms.TextBox)
                {
                    ((System.Windows.Forms.TextBox)c).Clear();
                }

                if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }



                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
            }
        }

        private Models.Material CreateMaterial(int operacion)
        {
            if (!Validate_Data())
            {
                MessageBox.Show("Hay campos inválidos", "Error", MessageBoxButtons.OK);
                return null;
            }
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
                    MessageBox.Show("material agregado correctamente", "Registrar material", MessageBoxButtons.OK);
                    Load_Data();
                }
                Set_Flag_All(false);
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
                        combobox_unit.SelectedIndex = i + 1;
                        break;
                    }
                }
                textbox_stock_min.Text = metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textbox_stock_max.Text = metroGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();
                metroTabControl1.SelectedIndex = 1;
                Set_Flag_All(true);
                operation_value = 1;
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
                    MessageBox.Show("material editado correctamente", "Editar material", MessageBoxButtons.OK);
                    Load_Data();
                }
                Set_Flag_All(false);
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
                MessageBox.Show("material eliminado correctamente", "Eliminar material", MessageBoxButtons.OK);
                Load_Data();
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
            Clean();
            metroTabControl1.SelectedIndex = 0;
        }

        private bool Validate_Data()
        {
            if (name_flag && unit_flag && max_flag && min_flag)
            {
                return true;
            }
            return false;
        }

        private void Set_Flag_All(bool value)
        {
            name_flag = value;
            min_flag = value;
            max_flag = value;
            unit_flag = value;
        }

        private void Set_Flag(string name, bool value)
        {
            switch (name)
            {
                case "textbox_name":
                    name_flag = value;
                    break;
                case "textbox_stock_min":
                    min_flag = value;
                    break;
                case "textbox_stock_max":
                    max_flag = value;
                    break;
                case "combobox_unit":
                    unit_flag = value;
                    break;
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
                if (!Int32.TryParse(text, out number))
                {
                    Set_Flag(textbox.Name, false);
                    errorProvider.SetError(textbox, "Stock debe ser número");
                }
                else
                {
                    errorProvider.SetError(textbox, null);
                }
                int max, min;
                if (Int32.TryParse(textbox_stock_max.Text, out max) && Int32.TryParse(textbox_stock_min.Text, out min))
                {
                    if (max < min)
                    {
                        Set_Flag(textbox.Name, false);
                        errorProvider.SetError(textbox, "El Stock Máximo debe ser Mayor que el stock mínimo");
                    }
                    else
                    {
                        Set_Flag(textbox.Name, true);
                        errorProvider.SetError(textbox, null);
                    }

                }

            }
        }

        private void combobox_Validating(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroComboBox combobox = (MetroFramework.Controls.MetroComboBox)sender;
            int unit_id = ((KeyValuePair<int, string>)combobox.SelectedItem).Key;

            if (unit_id == 0)
            {
                Set_Flag(combobox.Name, false);
                errorProvider.SetError(combobox_unit, combobox_unit.Name);

            }
            else
            {
                Set_Flag(combobox.Name, true);
                errorProvider.SetError(combobox_unit, null);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Models.Material mat = CreateMaterial(operation_value);
            if (mat != null)
            {
                if (mat.Id == 0)//Registrar
                {
                    result = materialController.insertMaterial(mat);
                    if (result.data == null)
                    {
                        MessageBox.Show(result.message, "Error al registrar material", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("material agregado correctamente", "Registrar material", MessageBoxButtons.OK);
                        Load_Data();
                    }
                }
                else //Editar
                {
                    result = materialController.updateMaterial(mat);
                    if (result.data == null)
                    {
                        MessageBox.Show(result.message, "Error al modificar material", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("material editado correctamente", "Editar material", MessageBoxButtons.OK);
                        Load_Data();
                    }
                }
                Set_Flag_All(false);
                Load_DataGridView();
                Clean();
                metroTabControl1.SelectedIndex = 0;
                operation_value = 0;
            }
        }

        private partial class MaterialError //Clase temporal para manejo de Excel con filas con errores
        {
            public List<string> error_list;
            public List<string> string_list;
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Excel |*.xlsx;*.xls";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(openDialog.FileName, "Ventana", MessageBoxButtons.OK);
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                if (excel == null)
                {
                    Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.");
                    return;
                }
                Workbook wb = excel.Workbooks.Open(openDialog.FileName);
                Worksheet ws = (Worksheet)wb.Worksheets[1];
                Range range = ws.UsedRange;
                int row_count = range.Rows.Count;
                int column_count = range.Columns.Count;
                Range datarange;
                string name = "", unit = "";
                double max = -1, min = -1, number;
                bool name_error, unit_error, min_error, max_error; //error individual
                List<string> error_list, string_list; //para hacer control de cada error de fila
                Models.Material material;
                int unit_id;
                List<MaterialError> material_error_list = new List<MaterialError>(); //Lista de materiales para el Excel con error
                //En Interop Excel el indice comienza en 1
                for (int i = 2; i <= row_count; i++) //Fila 2 comienza las filas de materiales
                {
                    name_error = false;
                    unit_error = false;
                    min_error = false;
                    max_error = false;
                    MaterialError material_error = new MaterialError();
                    error_list = new List<string>();
                    string_list = new List<string>();
                    unit_id = -1;
                    datarange = (Range)ws.Cells[i, 1];//Nombre
                    string_list.Add((string)datarange.Text);
                    if (string.IsNullOrWhiteSpace((string)datarange.Value2))
                    {
                        name_error = true;
                        error_list.Add("name");
                    }
                    else
                    {
                        name = (string)datarange.Value2;
                    }
                    datarange = (Range)ws.Cells[i, 2];//Unidad
                    string_list.Add((string)datarange.Text);
                    if (string.IsNullOrWhiteSpace((string)datarange.Value2))
                    {
                        unit_error = true;
                        error_list.Add("unit");
                    }
                    else
                    {
                        unit = (string)datarange.Value2;
                        foreach (var item in unit_list)
                        {
                            if (item.Symbol.Equals(unit))
                            {
                                unit_id = item.Id;
                                break;
                            }
                        }
                        if (unit_id == -1)
                        {
                            unit_error = true;
                            error_list.Add("unit_find");
                        }
                    }
                    datarange = (Range)ws.Cells[i, 3];//Stock minimo
                    string_list.Add((string)datarange.Text);
                    if (datarange.Value2 == null || !double.TryParse((string)datarange.Text, out number))
                    {
                        min_error = true;
                        error_list.Add("min");
                    }
                    else
                    {
                        min = (double)datarange.Value2;
                    }
                    datarange = (Range)ws.Cells[i, 4];//Stock maximo
                    string_list.Add((string)datarange.Text);
                    if (datarange.Value2 == null || !double.TryParse((string)datarange.Text, out number))
                    {
                        max_error = true;
                        error_list.Add("max");
                    }
                    else
                    {
                        max = (double)datarange.Value2;
                    }
                    if (name_error || unit_error || min_error || max_error)//Si hay error entonces, se agrega a la lista de material error
                    {
                        material_error.error_list = error_list;
                        material_error.string_list = string_list;
                        material_error_list.Add(material_error);
                    }
                    else
                    {
                        material = new Models.Material();
                        material.Name = name;
                        material.Stock_max = Convert.ToInt32(max);
                        material.Stock_min = Convert.ToInt32(min);
                        material.Unit_id = unit_id;
                        materialController.insertMaterial(material);
                        if (result.data == null)
                        {
                            MessageBox.Show("Error en registro material");
                        }
                    }
                }
                if (material_error_list.Count>0) //Hubo por lo menos una fila con error
                {
                    CreateExcelError(material_error_list);
                }
            }
            openDialog.Dispose();
        }

        private void CreateExcelError(List<MaterialError> list)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            if (excel == null)
            {
                Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.");
                return;
            }
            excel.Visible = true;

            Workbook wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            ws.Name = "Materiales";
            if (ws == null)
            {
                Console.WriteLine("Worksheet could not be created. Check that your office installation and project references are correct.");
            }

            ws.Range["A1"].Value2 = "Nombre";
            ws.Range["B1"].Value2 = "Unidad";
            ws.Range["C1"].Value2 = "Stock minimo";
            ws.Range["D1"].Value2 = "Stock maximo";
            ws.Range["E1"].Value2 = "Observaciones";
            string observation;
            MaterialError material_error;
            for (int i = 0; i < list.Count(); i++)
            {
                observation = "";
                material_error = list[i];
                for (int j = 0; j < list[i].string_list.Count(); j++)//Se pone los datos del material escrito
                {
                    ((Range)ws.Cells[i + 2, j+1]).Value2= material_error.string_list[j];
                    //ws.Cells[i+2,j]= material_error.string_list[j];

                }
                foreach (var item in material_error.error_list)
                {
                    switch (item)
                    {
                        case "name":
                            observation += "Nombre vacío. ";
                            break;
                        case "unit":
                            observation += "Unidad vacía. ";
                            break;
                        case "unit_find":
                            observation += "Unidad inválida. ";
                            break;
                        case "min":
                            observation += "Stock mínimo inválido. ";
                            break;
                        case "max":
                            observation += "Stock máximo inválido. ";
                            break;
                        default:
                            break;
                    }
                }
                ((Range)ws.Cells[i + 2, 5]).Value2 = observation;
                //ws.Cells[i + 2, 5] = observation;
            }
        }

        private void btn_template_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            if (excel == null)
            {
                Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.");
                return;
            }
            excel.Visible = true;

            Workbook wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            ws.Name = "Materiales";
            if (ws == null)
            {
                Console.WriteLine("Worksheet could not be created. Check that your office installation and project references are correct.");
            }

            ws.Range["A1"].Value2 = "Nombre";
            ws.Range["B1"].Value2 = "Unidad";
            ws.Range["C1"].Value2 = "Stock minimo";
            ws.Range["D1"].Value2 = "Stock maximo";
        }
    }
}
