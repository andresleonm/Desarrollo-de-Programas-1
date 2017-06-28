using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1.Views
{
    public partial class Supplier : MetroFramework.Controls.MetroUserControl
    {
        int cur_row;
        bool name_flag;
        bool doi_flag;
        bool phone_flag;
        bool address_flag;
        bool email_flag;


        List<Models.Supplier> supplier_list;
        Controller.SupplierController supplierController;
        Controller.Result result;

        ProgressBarForm progressform;
        Models.Supplier curSupplier;
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            string user = "dp1admin";
            string password = "dp1admin";
            supplierController = new Controller.SupplierController(user, password);
            supplier_list = new List<Models.Supplier>();
            progressform = new ProgressBarForm();
            //Unidades
            Load_Data();
            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
        }

        private void Load_Data()
        {
            supplier_list = new List<Models.Supplier>();
            result = supplierController.getSuppliers();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar proveedores", MessageBoxButtons.OK);
            else supplier_list = (List<Models.Supplier>)result.data;
        }

        private void Load_DataGridView()
        {
            metroGrid1.Rows.Clear();
            for (int i = 0; i < supplier_list.Count(); i++)
            {
                String[] row = new String[7];
                row[0] = supplier_list[i].Id.ToString();
                row[1] = i.ToString();
                row[2] = supplier_list[i].Doi.ToString();
                row[3] = supplier_list[i].Name.ToString();
                row[4] = supplier_list[i].Address.ToString();
                row[5] = supplier_list[i].Phone.ToString();
                row[6] = supplier_list[i].Email.ToString();

                this.metroGrid1.Rows.Add(row);
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

        private Models.Supplier CreateSupplier(int operacion)
        {
            if (!Validate_Data())
            {
                MessageBox.Show("Hay campos inválidos", "Error", MessageBoxButtons.OK);
                return null;
            }
            String name, doi, address, phone, email, state;
            int id = 0;
            name = textbox_name.Text;
            doi = textbox_doi.Text;
            phone = textbox_phone.Text;
            address = textbox_address.Text;
            email = textbox_email.Text;
            state = "ACTIVE";

            Models.Supplier supplier = new Models.Supplier();

            if (operacion == 1) //UPDATE
            {
                id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            }
            supplier = new Models.Supplier(id, name, address, doi, phone, email, state);

            return supplier;
        }


        
        private void register_Click(object sender, EventArgs e)
        {
            Models.Supplier supplier;
            string message = " ";

            if (curSupplier != null)
            {
                supplier = CreateSupplier(1);
                result = supplierController.updateSupplier(supplier);
                message = "Proveedor editado correctamente";
            }
            else
            {
                supplier = CreateSupplier(0);
                result = supplierController.insertSupplier(supplier);
                message = "Proveedor agregado correctamente";
            }

            if (result.success)
            {
                MessageBox.Show(message, "Registro", MessageBoxButtons.OK);
                Set_Flag_All(false);
                Clean();
                Load_Data();
                Load_DataGridView();
                metroTabControl1.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(result.message, "Error en la transacción", MessageBoxButtons.OK);
            }
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (metroGrid1.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    cur_row = e.RowIndex;
                    delete.Enabled = true;
                }
            }
        }

        //
        private void tabIndex_Enter(object sender, EventArgs e)
        {
            Clean();
            register.Text = "Guardar";
            curSupplier = null;
        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                cur_row = e.RowIndex;
                if (metroGrid1.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
                    curSupplier = supplier_list[index];
                    textbox_doi.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    textbox_name.Text = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    textbox_address.Text = metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    textbox_phone.Text = metroGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    textbox_email.Text = metroGrid1.Rows[e.RowIndex].Cells[6].Value.ToString();

                    metroTabControl1.SelectedIndex = 1;
                    register.Text = "Editar";
                    Set_Flag_All(true);
                }
            }
        }


        private void search_Click(object sender, EventArgs e)
        {
            Models.Supplier supplier = new Models.Supplier();
            supplier.Name = textbox_name_s.Text;
            supplier.Doi = textbox_doi_s.Text;
            result = supplierController.getSuppliers(supplier);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al buscar proveedor con filtros", MessageBoxButtons.OK);
            }
            else
            {
                supplier_list = (List<Models.Supplier>)result.data;
                Load_DataGridView();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
            result = supplierController.deleteSupplier(supplier_list[index]);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al eliminar proveedor", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Proveedor eliminado correctamente", "Eliminar proveedor", MessageBoxButtons.OK);
                Load_Data();
            }
            delete.Enabled = false;
            Load_DataGridView();
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Clean();
            Load_Data();
            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
        }

        private bool Validate_Data()
        {
            if (name_flag && doi_flag && phone_flag && email_flag)
            {
                return true;
            }
            return false;
        }

        private void Set_Flag_All(bool value)
        {
            name_flag = value;
            doi_flag = value;
            phone_flag = value;
            address_flag = value;
            email_flag = value;
        }

        private void Set_Flag(string name, bool value)
        {
            switch (name)
            {
                case "textbox_name":
                    name_flag = value;
                    break;
                case "textbox_doi":
                    doi_flag = value;
                    break;
                case "textbox_phone":
                    phone_flag = value;
                    break;
                case "textbox_address":
                    address_flag = value;
                    break;
                case "textbox_email":
                    email_flag = value;
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


        private void textbox_ValidatingEmail(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textbox = (MetroFramework.Controls.MetroTextBox)sender;
            string text = textbox.Text;

            if (!isEmailCorrect(text))
            {
                //e.Cancel = true;
                Set_Flag(textbox.Name, false);
                errorProvider.SetError(textbox, "Debe ingresar correo :ejemplo@gmail.com");

            }
            else
            {
                //e.Cancel = false;
                Set_Flag(textbox.Name, true);
                errorProvider.SetError(textbox, null);
            }
        }

        private void textbox_ValidatingPhone(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textbox = (MetroFramework.Controls.MetroTextBox)sender;
            string text = textbox.Text;

            if (!isPhoneCorrect(text))
            {
                //e.Cancel = true;
                Set_Flag(textbox.Name, false);
                errorProvider.SetError(textbox, "Debe ingresar un teléfono válido");

            }
            else
            {
                //e.Cancel = false;
                Set_Flag(textbox.Name, true);
                errorProvider.SetError(textbox, null);
            }
        }


        private Boolean isPhoneCorrect(String phone)
        {
            String expresion;
            if (phone.Length > 11) return false;
            expresion = "^[+-]?\\d+(\\.\\d+)?$";
            if (Regex.IsMatch(phone, expresion))
            {
                if (Regex.Replace(phone, expresion, String.Empty).Length == 0)
                {
                    phone_flag = true;
                    return true;
                }
                else
                {
                    phone_flag = false;
                    return false;
                }
            }
            else
            {
                phone_flag = false;
                return false;
            }
        }


        private Boolean isEmailCorrect(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    email_flag = true;
                    return true;
                }
                else
                {
                    email_flag = false;
                    return false;
                }
            }
            else
            {
                email_flag = false;
                return false;
            }
        }

        private void combobox_Validating(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroComboBox combobox = (MetroFramework.Controls.MetroComboBox)sender;
            int unit_id = ((KeyValuePair<int, string>)combobox.SelectedItem).Key;

            if (unit_id == 0)
            {
                Set_Flag(combobox.Name, false);
                errorProvider.SetError(combobox, combobox.Name);

            }
            else
            {
                Set_Flag(combobox.Name, true);
                errorProvider.SetError(combobox, null);
            }
        }


        // Excel - Import 
        private partial class SupplierrError //Clase temporal para manejo de Excel con filas con errores
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
                string name = "", doi = "", address = "", phone = "", email = "";
                double number;
                bool error; //error individual
                bool found;
                List<string> error_list, string_list; //para hacer control de cada error de fila
                Models.Supplier supplier;
                int success_lines = 0, error_lines = 0;
                List<SupplierrError> supplier_error_list = new List<SupplierrError>(); //Lista de materiales para el Excel con error
                Controller.Result temp;
                progressform.SetupValues(0, row_count, 0);
                progressform.Show();
                //En Interop Excel el indice comienza en 1
                for (int i = 3; i <= row_count; i++) //Fila 3 comienza las filas de materiales
                {
                    error = false;
                    SupplierrError supplier_error = new SupplierrError();
                    error_list = new List<string>();
                    string_list = new List<string>();
                    //Nombre
                    datarange = (Range)ws.Cells[i, 1];
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

                    //DNI
                    datarange = (Range)ws.Cells[i, 2];
                    string_list.Add((string)datarange.Text);
                    if (datarange.Value2 == null || !double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
                        error_list.Add("dni");
                    }
                    else
                    {
                        doi = ((double)datarange.Value2).ToString();
                    }
                    //Dirección
                    datarange = (Range)ws.Cells[i, 3];
                    string_list.Add((string)datarange.Text);
                    if (datarange.Value2 == null || double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
                        error_list.Add("address");
                    }
                    else
                    {
                        address = ((string)datarange.Value2).ToString();
                    }

                    //Teléfono
                    datarange = (Range)ws.Cells[i, 4];
                    string_list.Add((string)datarange.Text);
                    if (datarange.Value2 == null || !isPhoneCorrect((string)datarange.Text))
                    {
                        error = true;
                        error_list.Add("phone");
                    }
                    else
                    {
                        phone = ((double)datarange.Value2).ToString();
                    }

                    //Correo
                    datarange = (Range)ws.Cells[i, 5];
                    string_list.Add((string)datarange.Text);
                    if (datarange.Value2 == null || !isEmailCorrect((string)datarange.Text))
                    {
                        error = true;
                        error_list.Add("email");
                    }
                    else
                    {
                        email = ((string)datarange.Value2).ToString();
                    }
                    

                    if (error)//Si hay error entonces, se agrega a la lista de material error
                    {
                        supplier_error.error_list = error_list;
                        supplier_error.string_list = string_list;
                        supplier_error_list.Add(supplier_error);
                        error_lines++;
                    }
                    else
                    {
                        supplier = new Models.Supplier();
                        supplier.Name = name;
                        supplier.Doi = doi;
                        supplier.Email = email;
                        supplier.Phone = phone;
                        supplier.Address = address;

                        temp = supplierController.insertSupplier(supplier);
                        if (!temp.success)
                        {
                            error = true;
                            error_list.Add(temp.message);
                            supplier_error.error_list = error_list;
                            supplier_error.string_list = string_list;
                            supplier_error_list.Add(supplier_error);
                            error_lines++;
                        }
                        else
                        {
                            success_lines++;
                        }
                        progressform.IncrementProgress(1);
                    }
                }
                MessageBox.Show("Lineas correctas: " + success_lines + "\n" + "Lineas inccorrectas: " + error_lines, "Resultado de importación desde Excel", MessageBoxButtons.OK);
                if (supplier_error_list.Count > 0) //Hubo por lo menos una fila con error
                {
                    CreateExcelError(supplier_error_list);
                }
                excel.Quit();
                excel = null;
                wb = null;


            }
            progressform.Hide();
            openDialog.Dispose();
            Load_Data();
            Load_DataGridView();

        }

        private void CreateExcelError(List<SupplierrError> list)
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
            ws.Name = "Clientes";
            if (ws == null)
            {
                Console.WriteLine("Worksheet could not be created. Check that your office installation and project references are correct.");
            }

            ws.Range["A1"].Value2 = "Lista de Proveedores con Error";
            ws.Range["A1"].Font.Size = 15;
            ws.Range["A1"].Font.Bold = true;
            ws.Range["A2"].Value2 = "Nombre";
            ws.Range["B2"].Value2 = "DNI";
            ws.Range["C2"].Value2 = "Dirección";
            ws.Range["D2"].Value2 = "Teléfono";
            ws.Range["E2"].Value2 = "Correo";

            string observation;
            SupplierrError supplier_error;
            for (int i = 0; i < list.Count(); i++)
            {
                observation = "";
                supplier_error = list[i];
                for (int j = 0; j < list[i].string_list.Count(); j++)//Se pone los datos del material escrito
                {
                    ((Range)ws.Cells[i + 3, j + 1]).Value2 = supplier_error.string_list[j];
                }
                foreach (var item in supplier_error.error_list)
                {
                    switch (item)
                    {
                        case "name":
                            observation += "Nombre inválido. ";
                            break;
                        case "dni":
                            observation += "DNI inválido. ";
                            break;
                        case "address":
                            observation += "Dirección inválido. ";
                            break;
                        case "phone":
                            observation += "Teléfono inválido. ";
                            break;
                        case "email":
                            observation += "Correo inválido. ";
                            break;
                        case "register":
                            observation += "Error en registro";
                            break;
                        default:
                            observation += item;
                            break;
                    }
                }
                ((Range)ws.Cells[i + 3, 8]).Value2 = observation;
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
            ws.Name = "Proveedores";
            if (ws == null)
            {
                Console.WriteLine("Worksheet could not be created. Check that your office installation and project references are correct.");
            }
            ws.Range["A1"].Value2 = "Lista de Proveedores";
            ws.Range["A1"].Font.Size = 15;
            ws.Range["A1"].Font.Bold = true;
            ws.Range["A2"].Value2 = "Nombre";
            ws.Range["B2"].Value2 = "RUC";
            ws.Range["C2"].Value2 = "Dirección";
            ws.Range["D2"].Value2 = "Teléfono";
            ws.Range["E2"].Value2 = "Correo";
            ws.Columns.AutoFit();
        }
    }
}
