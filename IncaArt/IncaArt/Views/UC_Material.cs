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
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class UC_Material : ICheckPermissions
    {
        bool name_flag;
        bool unit_flag;
        bool max_flag;
        bool min_flag;
        bool currency_flag;
        bool cost_flag;
        int cur_row;
        int operation_value;// 0 para Create, 1 para Update
        List<Models.Material> material_list;
        List<Models.UnitOfMeasure> unit_list;
        List<Models.Currency> currency_list;
        Controller.MaterialsController materialController;
        Controller.UnitController unitController;
        Controller.Result result;
        Controller.CurrencyController currencyController;
        Models.User sessionUser;
        public UC_Material()
        {
            InitializeComponent();
        }

        private void UC_Material_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 0;
            string user = "";
            string password = "";
            materialController = new Controller.MaterialsController(user, password);
            unitController = new Controller.UnitController(user, password);
            currencyController = new Controller.CurrencyController(user, password);
            material_list = new List<Models.Material>();
            currency_list = new List<Currency>();
        }

        private void UC_Material_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                Set_Flag_All(false);
                operation_value = 0;
                Load_Data();
                Load_DataGridView();
                metroTabControl1.SelectedIndex = 0;
            }
        }

        private void Load_Data()
        {
            result = unitController.getUnits();
            if (result.success)
            {
                unit_list = (List<Models.UnitOfMeasure>)result.data;
            }
            else
            {
                MessageBox.Show(result.message, "Error al listar unidades", MessageBoxButtons.OK);
            }

            result = materialController.getMaterials();
            if (result.success)
            {
                material_list = (List<Material>)result.data;
            }
            else
            {
                MessageBox.Show(result.message, "Error al listar material", MessageBoxButtons.OK);
            }

            result = currencyController.getCurrencies();
            if (result.success)
            {
                currency_list = (List<Currency>)result.data;
            }
            Load_Combobox();
        }

        private void Load_Combobox()
        {
            //Cargar los combobox
            Dictionary<int, string> combo_data = new Dictionary<int, string>();
            //Monedas
            combo_data.Add(0, "Seleccionar");
            foreach (var item in currency_list)
            {
                combo_data.Add(item.Id, item.Symbol);

            }
            combobox_currency.DataSource = new BindingSource(combo_data, null);
            combobox_currency.DisplayMember = "Value";
            combobox_currency.ValueMember = "Key";

            //Cargar los combobox
            combo_data = new Dictionary<int, string>();
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
        }

        private void Load_DataGridView()
        {
            metroGrid1.Rows.Clear();
            for (int i = 0; i < material_list.Count(); i++)
            {
                Models.UnitOfMeasure unit = new Models.UnitOfMeasure();
                result = unitController.getUnit(material_list[i].Unit_id);
                if (result.success)
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
                else
                {
                    MessageBox.Show(result.message, "Error al buscar unit", MessageBoxButtons.OK);
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
            String name;
            name = textbox_name.Text;

            int min_stock, max_stock, id = 0;
            min_stock = int.Parse(textbox_stock_min.Text);
            max_stock = int.Parse(textbox_stock_max.Text);
            int unit_id = ((KeyValuePair<int, string>)combobox_unit.SelectedItem).Key;
            int currency_id = ((KeyValuePair<int, string>)combobox_currency.SelectedItem).Key;
            double cost = double.Parse(textbox_cost.Text);
            Models.Material mat = new Models.Material();

            if (operacion == 1) //UPDATE
            {
                id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            }
            mat = new Models.Material(id, unit_id, name, min_stock, max_stock);
            mat.Currency_id = currency_id;
            mat.Average_cost = cost;
            return mat;
        }

        //Registrar
        private void btn_new_Click(object sender, EventArgs e)
        {

            Models.Material mat = CreateMaterial(0);
            if (mat != null)
            {
                result = materialController.insertMaterial(mat);
                if (result.success)
                {
                    MessageBox.Show("material agregado correctamente", "Registrar material", MessageBoxButtons.OK);
                    Load_Data();
                    Set_Flag_All(false);
                    Load_DataGridView();
                    Clean();
                    metroTabControl1.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show(result.message, "Error al registrar material", MessageBoxButtons.OK);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex < material_list.Count())
            {
                cur_row = e.RowIndex;
                btn_delete.Enabled = true;
            }
        }

        //Mostrar Datos
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cur_row != -1)
            {
                Models.Material material;
                result = materialController.getMaterial(Int32.Parse(metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                if (result.success)
                {
                    material = (Models.Material)result.data;
                    textbox_name.Text = material.Name;
                    textbox_stock_min.Text = material.Stock_min.ToString();
                    textbox_stock_max.Text = material.Stock_max.ToString();
                    textbox_cost.Text = material.Average_cost.ToString();
                    for (int i = 0; i < unit_list.Count(); i++)
                    {
                        if (unit_list[i].Id == material.Unit_id)
                        {
                            combobox_unit.SelectedIndex = i + 1;
                            break;
                        }
                    }
                    for (int i = 0; i < currency_list.Count(); i++)
                    {
                        if (currency_list[i].Id == material.Currency_id)
                        {
                            combobox_currency.SelectedIndex = i + 1;
                            break;
                        }
                    }
                    metroTabControl1.SelectedIndex = 1;
                    Set_Flag_All(true);
                    operation_value = 1;
                }
                else
                {
                    MessageBox.Show(result.message, "Error al buscar material", MessageBoxButtons.OK);
                }
            }
        }

        //Modificar Datos
        private void btn_edit_Click(object sender, EventArgs e)
        {
            Models.Material mat = CreateMaterial(1);
            if (mat != null)
            {
                result = materialController.updateMaterial(mat);
                if (result.success)
                {
                    MessageBox.Show("material editado correctamente", "Editar material", MessageBoxButtons.OK);
                    Load_Data();
                    Set_Flag_All(false);
                    Load_DataGridView();
                    Clean();
                    metroTabControl1.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show(result.message, "Error al modificar material", MessageBoxButtons.OK);
                }
            }


        }

        //Buscar
        private void btn_search_Click(object sender, EventArgs e)
        {
            Models.Material material = new Models.Material();
            material.Name = textbox_name_s.Text;
            material.Unit_id = ((KeyValuePair<int, string>)combobox_unit_s.SelectedItem).Key;
            result = materialController.getMaterials(material);
            if (result.success)
            {
                material_list = (List<Models.Material>)result.data;
                Load_DataGridView();
            }
            else
            {
                MessageBox.Show(result.message, "Error al buscar material con filtros", MessageBoxButtons.OK);
            }
        }

        //Eliminar
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
            result = materialController.deleteMaterial(material_list[index]);
            if (result.success)
            {
                MessageBox.Show("material eliminado correctamente", "Eliminar material", MessageBoxButtons.OK);
                Load_Data();
                btn_delete.Enabled = false;
                Load_DataGridView();
            }
            else
            {
                MessageBox.Show(result.message, "Error al eliminar material", MessageBoxButtons.OK);
            }

        }

        private void btn_clean_s_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clean();
            combobox_currency.SelectedIndex = 0;
            combobox_unit.SelectedIndex = 0;
            metroTabControl1.SelectedIndex = 0;
        }

        private bool Validate_Data()
        {
            if (name_flag && unit_flag && max_flag && min_flag && cost_flag && currency_flag)
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
            cost_flag = value;
            currency_flag = value;
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
                case "textbox_cost":
                    cost_flag = value;
                    break;
                case "combobox_currency":
                    currency_flag = value;
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
            if (textbox.Name == "textbox_cost")
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = false;
                }
                if ((e.KeyChar == '.') && (textbox.Text.IndexOf('.') > -1))
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
                        Set_Flag("textbox_stock_min", true);
                        Set_Flag("textbox_stock_max", true);
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
                errorProvider.SetError(combobox, "Debe seleccionar campo");

            }
            else
            {
                Set_Flag(combobox.Name, true);
                errorProvider.SetError(combobox, null);
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
                    if (result.success)
                    {
                        MessageBox.Show("material agregado correctamente", "Registrar material", MessageBoxButtons.OK);
                        Load_Data();
                    }
                    else
                    {
                        MessageBox.Show(result.message, "Error al registrar material", MessageBoxButtons.OK);
                    }
                }
                else //Editar
                {
                    result = materialController.updateMaterial(mat);
                    if (result.success)
                    {
                        MessageBox.Show("material editado correctamente", "Editar material", MessageBoxButtons.OK);
                        Load_Data();
                    }
                    else
                    {
                        MessageBox.Show(result.message, "Error al modificar material", MessageBoxButtons.OK);
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
                string name = "", unit = "",currency;
                double max = -1, min = -1, number,cost=-1;
                bool found,error; //error individual
                List<string> error_list, string_list; //para hacer control de cada error de fila
                Models.Material material;
                int unit_id, currency_id=0,success_lines = 0, error_lines = 0;
                List<MaterialError> material_error_list = new List<MaterialError>(); //Lista de materiales para el Excel con error
                //En Interop Excel el indice comienza en 1
                for (int i = 3; i <= row_count; i++) //Fila 3 comienza las filas de materiales
                {
                    error = false;
                    MaterialError material_error = new MaterialError();
                    error_list = new List<string>();
                    string_list = new List<string>();
                    unit_id = -1;
                    datarange = (Range)ws.Cells[i, 1];//Nombre
                    string_list.Add((string)datarange.Text);
                    if (string.IsNullOrWhiteSpace((string)datarange.Text) || double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
                        error_list.Add("name");
                    }
                    else
                    {
                        name = (string)datarange.Value2;
                    }
                    datarange = (Range)ws.Cells[i, 2];//Unidad
                    string_list.Add((string)datarange.Text);
                    if (string.IsNullOrWhiteSpace((string)datarange.Text) || double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
                        error_list.Add("unit");
                    }
                    else
                    {
                        unit = (string)datarange.Value2;
                        foreach (var item in unit_list)
                        {
                            if (item.Symbol.ToUpper().Equals(unit.ToUpper()))
                            {
                                unit_id = item.Id;
                                break;
                            }
                        }
                        if (unit_id == -1)
                        {
                            error = true;
                            error_list.Add("unit_find");
                        }
                    }
                    datarange = (Range)ws.Cells[i, 3];//Stock minimo
                    string_list.Add((string)datarange.Text);
                    if (datarange.Value2 == null || !double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
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
                        error = true;
                        error_list.Add("max");
                    }
                    else
                    {
                        max = (double)datarange.Value2;
                    }
                    datarange = (Range)ws.Cells[i, 5];//Costo
                    string_list.Add((string)datarange.Text);
                    if (datarange.Value2 == null || !double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
                        error_list.Add("cost");
                    }
                    else
                    {
                        cost = (double)datarange.Value2;
                    }

                    datarange = (Range)ws.Cells[i, 6];
                    found = false;
                    string_list.Add((string)datarange.Text);
                    if (string.IsNullOrWhiteSpace((string)datarange.Text) || double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
                        error_list.Add("currency");
                    }
                    else
                    {
                        currency = (string)datarange.Value2;
                        foreach (var item in currency_list)
                        {
                            if (item.Name.ToUpper().Equals(currency.ToUpper()))
                            {
                                currency_id = item.Id;
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            error = true;
                            error_list.Add("currency_find");
                        }
                    }

                    if (error)//Si hay error entonces, se agrega a la lista de material error
                    {
                        material_error.error_list = error_list;
                        material_error.string_list = string_list;
                        material_error_list.Add(material_error);
                        error_lines++;
                    }
                    else
                    {
                        material = new Models.Material();
                        material.Name = name;
                        material.Stock_max = Convert.ToInt32(max);
                        material.Stock_min = Convert.ToInt32(min);
                        material.Unit_id = unit_id;
                        material.Average_cost = cost;
                        material.Currency_id = currency_id;
                        materialController.insertMaterial(material);
                        if (result.success)
                        {
                            success_lines++;
                        }
                        else
                        {
                            MessageBox.Show("Error en registro material");
                            error = true;
                            error_list.Add("register");
                            error_lines++;
                        }

                    }
                }
                MessageBox.Show("Lineas correctas: " + success_lines + "\n" + "Lineas inccorrectas: " + error_lines, "Resultado de importación desde Excel", MessageBoxButtons.OK);
                if (material_error_list.Count > 0) //Hubo por lo menos una fila con error
                {
                    CreateExcelError(material_error_list);
                }
            }
            openDialog.Dispose();
            Load_Data();
            Load_DataGridView();
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

            ws.Range["A1"].Value2 = "Lista de Materiales con Error";
            ws.Range["A1"].Font.Size = 15;
            ws.Range["A1"].Font.Bold = true;
            ws.Range["A2"].Value2 = "Nombre";
            ws.Range["B2"].Value2 = "Unidad";
            ws.Range["C2"].Value2 = "Stock minimo";
            ws.Range["D2"].Value2 = "Stock maximo";
            ws.Range["E2"].Value2 = "Costo";
            ws.Range["F2"].Value2 = "Moneda";
            ws.Range["G2"].Value2 = "Observaciones";
            string observation;
            MaterialError material_error;
            for (int i = 0; i < list.Count(); i++)
            {
                observation = "";
                material_error = list[i];
                for (int j = 0; j < list[i].string_list.Count(); j++)//Se pone los datos del material escrito
                {
                    ((Range)ws.Cells[i + 3, j + 1]).Value2 = material_error.string_list[j];
                }
                foreach (var item in material_error.error_list)
                {
                    switch (item)
                    {
                        case "name":
                            observation += "Nombre inválido. ";
                            break;
                        case "unit":
                            observation += "Unidad inválida. ";
                            break;
                        case "unit_find":
                            observation += "Unidad no encontrada. ";
                            break;
                        case "min":
                            observation += "Stock mínimo inválido. ";
                            break;
                        case "max":
                            observation += "Stock máximo inválido. ";
                            break;
                        default:
                        case "register":
                            observation += "Error en registro";
                            break;
                        case "cost":
                            observation += "Error en el costo";
                            break;
                        case "currency":
                            observation += "Moneda inválida. ";
                            break;
                        case "currency_find":
                            observation += "Moneda no encontrada. ";
                            break;
                    }
                }
                ((Range)ws.Cells[i + 3, 7]).Value2 = observation;
            }
            ws.Columns.AutoFit();
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
            ws.Range["A1"].Value2 = "Lista de Materiales";
            ws.Range["A1"].Font.Size = 15;
            ws.Range["A1"].Font.Bold = true;
            ws.Range["A2"].Value2 = "Nombre";
            ws.Range["B2"].Value2 = "Unidad";
            ws.Range["C2"].Value2 = "Stock minimo";
            ws.Range["D2"].Value2 = "Stock maximo";
            ws.Range["E2"].Value2 = "Costo";
            ws.Range["F2"].Value2 = "Moneda";
            ws.Columns.AutoFit();
        }

        public override void CheckPermissions(User u)
        {
            sessionUser = u;
            Permissions();
        }

        private void Permissions()
        {
            if (!sessionUser.Profile.HasFunctionality("CREATE MATERIAL") && !sessionUser.Profile.HasFunctionality("EDIT MATERIAL"))
            {
                this.metroTabControl1.TabPages.Remove(tabRegister);
            }
            if (!sessionUser.Profile.HasFunctionality("DELETE MATERIAL"))
            {
                btn_delete.Visible = false;
            }

        }

        
    }
}
