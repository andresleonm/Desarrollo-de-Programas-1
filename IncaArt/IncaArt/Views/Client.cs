using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1.Views
{
    public partial class Client : MetroFramework.Controls.MetroUserControl
    {
        int cur_row;
        bool name_flag;
        bool doi_flag;
        bool phone_flag;
        bool address_flag;
        bool email_flag;
        bool type_flag;
        bool priority_flag;

        List<Models.Customer> customer_list;
        Controller.CustomerController customerController;
        Controller.Result result;
        int priority_list = 10;
        Dictionary<int, string> combo_priority;
        Dictionary<int, string> combo_type;

        Models.Customer curCustomer;
        ProgressBarForm progressform;
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            string user = "dp1admin";
            string password = "dp1admin";
            customerController = new Controller.CustomerController(user, password);
            customer_list = new List<Models.Customer>();
            combo_priority = new Dictionary<int, string>();
            combo_type= new Dictionary<int, string>();

            combo_priority.Add(0, "Seleccionar");
            for (int i =1; i<=priority_list;i++)
            combo_priority.Add(i,i.ToString());

            combo_type.Add(0, "Seleccionar");
            combo_type.Add(1, "Nacional");
            combo_type.Add(2, "Extranjero");


            combobox_type.DataSource = new BindingSource(combo_type, null);
            combobox_type.DisplayMember = "Value";
            combobox_type.ValueMember = "Key";

            combobox_type_s.DataSource = new BindingSource(combo_type, null);
            combobox_type_s.DisplayMember = "Value";
            combobox_type_s.ValueMember = "Key";

            combobox_priority.DataSource = new BindingSource(combo_priority, null);
            combobox_priority.DisplayMember = "Value";
            combobox_priority.ValueMember = "Key";

            combobox_priority_s.DataSource = new BindingSource(combo_priority, null);
            combobox_priority_s.DisplayMember = "Value";
            combobox_priority_s.ValueMember = "Key";

            Load_Data();    
            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;

            progressform = new ProgressBarForm();
        }


        private void Load_Data()
        {
            customer_list = new List<Models.Customer>();
            result = customerController.getCustomers();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar clientes", MessageBoxButtons.OK);
            else customer_list = (List<Models.Customer>)result.data;
        }

        private void Load_DataGridView()
        {
            metroGrid1.Rows.Clear();
            for (int i = 0; i < customer_list.Count(); i++)
            {
                String[] row = new String[9];
                row[0] = customer_list[i].Id.ToString();
                row[1] = i.ToString();
                row[2] = customer_list[i].Doi.ToString();
                row[3] = customer_list[i].Name.ToString();
                row[4] = customer_list[i].Address.ToString();
                row[5] = customer_list[i].Phone.ToString();
                row[6] = customer_list[i].Email.ToString();
                row[7] = customer_list[i].Type.ToString();
                row[8] = customer_list[i].Priority.ToString();
                this.metroGrid1.Rows.Add(row);
            }
        }

        private void Clean()
        {
            ClearTextBoxes(this);
            combobox_priority.SelectedIndex = 0;
            combobox_priority_s.SelectedIndex = 0;
            combobox_type.SelectedIndex = 0;
            combobox_type_s.SelectedIndex = 0;
            errorProvider.Clear();

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


        private Models.Customer CreateCustomer(int operacion)
        {
            if (!Validate_Data())
            {
                MessageBox.Show("Hay campos inválidos", "Error", MessageBoxButtons.OK);
                return null;
            }
            String name,doi,address,phone,email,type,state;
            int id=0,priority;
            name = textbox_name.Text;
            doi = textbox_doi.Text;
            phone = textbox_phone.Text;
            address = textbox_address.Text;
            email = textbox_email.Text;
            state = "ACTIVE";
            type = ((KeyValuePair<int, string>)combobox_type.SelectedItem).Value.ToUpper();
            priority = Int32.Parse(((KeyValuePair<int, string>)combobox_priority.SelectedItem).Value);

            Models.Customer customer = new Models.Customer();

            if (operacion == 1) //UPDATE
            {
                id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            }
            customer = new Models.Customer(id,name,address,doi,phone,email,type,priority,state);
            return customer;
        }

        private void tabIndex_Enter(object sender, EventArgs e)
        {
            Clean();               
            curCustomer = null;
            register.Text = "Guardar";
        }
        private void focus()
        {
            textbox_name.Focus();
            textbox_doi.Focus();
            textbox_phone.Focus();
            textbox_address.Focus();
            combobox_priority.Focus();
            combobox_type.Focus();
            //register.Focus();
        }
        private void register_Click(object sender, EventArgs e)
        {
   
            Models.Customer customer;
            string message = " ";
            Focus();
            if (curCustomer != null)
            {

                customer = CreateCustomer(1);
                if (customer != null)
                {
                    result = customerController.updateCustomer(customer);
                    message = "Cliente editado correctamente";
                }
            }
            else {
                customer = CreateCustomer(0);
                if (customer != null)
                {
                    result = customerController.insertCustomer(customer);
                    message = "Cliente agregado correctamente";
                }
            }

            if (customer != null)
            {
                if (result.success && result.data != null)
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
        }

        /*
                   Models.Customer customer = CreateCustomer(0);
                   if (customer != null)
                   {
                       result = customerController.insertCustomer(customer);
                       if (result.data == null)
                       {
                           MessageBox.Show(result.message, "Error al registrar cliente", MessageBoxButtons.OK);
                       }
                       else
                       {
                           MessageBox.Show("Cliente agregado correctamente", "Registrar Cliente", MessageBoxButtons.OK);
                           Load_Data();
                       }
                       Set_Flag_All(false);
                       Load_DataGridView();
                       Clean();
                       metroTabControl1.SelectedIndex = 0;
                   }


                   Models.Customer customer = CreateCustomer(1);
                   if (customer != null)
                   {
                       result = customerController.updateCustomer(customer);
                       if (result.data == null)
                       {
                           MessageBox.Show(result.message, "Error al modificar cliente", MessageBoxButtons.OK);
                       }
                       else
                       {
                           MessageBox.Show("Cliente editado correctamente", "Editar Cliente", MessageBoxButtons.OK);
                           Load_Data();
                       }
                       Set_Flag_All(false);
                       Load_DataGridView();
                       Clean();
                       metroTabControl1.SelectedIndex = 0;
                   }*/



        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) { 
            if (metroGrid1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                cur_row = e.RowIndex;
                delete.Enabled = true;
            }
        }
        }


        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                cur_row = e.RowIndex;
                if (metroGrid1.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
                    curCustomer = customer_list[index];

                    textbox_doi.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    textbox_name.Text = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    textbox_address.Text = metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    textbox_phone.Text = metroGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    textbox_email.Text = metroGrid1.Rows[e.RowIndex].Cells[6].Value.ToString();

                    //Tipo 
                    for (int i = 0; i < combo_type.Count(); i++)
                    {
                        if (combo_type[i] == metroGrid1.Rows[e.RowIndex].Cells[7].Value.ToString())
                        {
                            combobox_type.SelectedIndex = i;
                            break;
                        }
                    }

                    //Tipo 
                    for (int i = 0; i < combo_priority.Count(); i++)
                    {
                        if (combo_priority[i] == metroGrid1.Rows[e.RowIndex].Cells[8].Value.ToString())
                        {
                            combobox_priority.SelectedIndex = i;
                            break;
                        }
                    }

                    register.Text = "Editar";
                    metroTabControl1.SelectedIndex = 1;
                    // Focus();
                    Set_Flag_All(true);
                    errorProvider.Clear();

                }
            }
        }


        private void search_Click(object sender, EventArgs e)
        {
            Models.Customer customer = new Models.Customer();
            customer.Name = textbox_name_s.Text;
            customer.Doi = textbox_doi_s.Text;
            customer.Type = ((KeyValuePair<int, string>)combobox_type_s.SelectedItem).Value;
            customer.Priority= ((KeyValuePair<int, string>)combobox_priority_s.SelectedItem).Key;
            if (customer.Type == "Seleccionar")
            {
                customer.Type = "";
            }

            result = customerController.getCustomers(customer);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al buscar cliente con filtros", MessageBoxButtons.OK);
            }
            else
            {
                customer_list = (List<Models.Customer>)result.data;
                Load_DataGridView();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
            result = customerController.deleteCustomer(customer_list[index]);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al eliminar cliente", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Cliente eliminado correctamente", "Eliminar cliente", MessageBoxButtons.OK);
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
            if (name_flag && doi_flag && phone_flag  && email_flag && priority_flag)
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
            type_flag = value;
            priority_flag = value;
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
                case "combobox_type":
                    type_flag = value;
                    break;
                case "combobox_priority":
                    priority_flag = value;
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
                errorProvider.SetError(combobox, "Debe seleccionar una opción válida");

            }
            else
            {
                Set_Flag(combobox.Name, true);
                errorProvider.SetError(combobox, null);
            }
        }


        // Excel - Import 
        private partial class CustomerError //Clase temporal para manejo de Excel con filas con errores
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
                int column_count = range.Columns.Count,priority=-1;
                Range datarange;
                string name = "", doi = "",address ="", phone = "", email = "",type="";
                double  number;
                bool error; //error individual
                bool found;
                List<string> error_list, string_list; //para hacer control de cada error de fila
                Models.Customer customer;
                int  success_lines = 0, error_lines = 0;
                List<CustomerError> customer_error_list = new List<CustomerError>(); //Lista de materiales para el Excel con error
                Controller.Result temp;
                progressform.SetupValues(0, row_count, 0);
                progressform.Show();
                //En Interop Excel el indice comienza en 1
                for (int i = 3; i <= row_count; i++) //Fila 3 comienza las filas de materiales
                {
                    error = false;
                    CustomerError customer_error = new CustomerError();
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

                    //Type
                    datarange = (Range)ws.Cells[i, 6];
                    string_list.Add((string)datarange.Text);
                    if (string.IsNullOrWhiteSpace((string)datarange.Text) || double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
                        error_list.Add("type");
                    }
                    else
                    {
                        type = (string)datarange.Value2;
                        found = false;
                        foreach (var item in combo_type)
                        {
                            if (item.Value.ToUpper().Equals(type.ToUpper()))
                            {
                                type = item.Value.ToUpper();
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            error = true;
                            error_list.Add("type_find");
                        }
                    }

                    //Priority
                    datarange = (Range)ws.Cells[i, 7];
                    string_list.Add((string)datarange.Text);
                    if (string.IsNullOrWhiteSpace((string)datarange.Text) || !double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
                        error_list.Add("priority");
                    }
                    else
                    {
                        priority = (int)datarange.Value2;
                        found = false;
                        foreach (var item in combo_priority)
                        {
                            if (item.Key.Equals(priority))
                            {
                                priority = item.Key;
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            error = true;
                            error_list.Add("priority_find");
                        }
                    }
                    

                    if (error)//Si hay error entonces, se agrega a la lista de material error
                    {
                        customer_error.error_list = error_list;
                        customer_error.string_list = string_list;
                        customer_error_list.Add(customer_error);
                        error_lines++;
                    }
                    else
                    {
                        customer = new Models.Customer();
                        customer.Name = name;
                        customer.Doi = doi;
                        customer.Email = email;
                        customer.Phone = phone;
                        customer.Address = address;
                        customer.Priority = priority;
                        customer.Type = type;
                        temp = customerController.insertCustomer(customer);
                        if (!temp.success)
                        {
                            error = true;
                            error_list.Add(temp.message);
                            customer_error.error_list = error_list;
                            customer_error.string_list = string_list;
                            customer_error_list.Add(customer_error);
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
                if (customer_error_list.Count > 0) //Hubo por lo menos una fila con error
                {
                    CreateExcelError(customer_error_list);
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

        private void CreateExcelError(List<CustomerError> list)
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

            ws.Range["A1"].Value2 = "Lista de Clientes con Error";
            ws.Range["A1"].Font.Size = 15;
            ws.Range["A1"].Font.Bold = true;
            ws.Range["A2"].Value2 = "Nombre";
            ws.Range["B2"].Value2 = "DNI";
            ws.Range["C2"].Value2 = "Dirección";
            ws.Range["D2"].Value2 = "Teléfono";
            ws.Range["E2"].Value2 = "Correo";
            ws.Range["F2"].Value2 = "Tipo";
            ws.Range["G2"].Value2 = "Prioridad";

            string observation;
            CustomerError customer_error;
            for (int i = 0; i < list.Count(); i++)
            {
                observation = "";
                customer_error = list[i];
                for (int j = 0; j < list[i].string_list.Count(); j++)//Se pone los datos del material escrito
                {
                    ((Range)ws.Cells[i + 3, j + 1]).Value2 = customer_error.string_list[j];
                }
                foreach (var item in customer_error.error_list)
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
                        case "type_find":
                            observation += "Tipo no encontrado. ";
                            break;
                        case "priority_find":
                            observation += "Prioridad no encontrado. ";
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
            ws.Name = "Clientes";
            if (ws == null)
            {
                Console.WriteLine("Worksheet could not be created. Check that your office installation and project references are correct.");
            }
            ws.Range["A1"].Value2 = "Lista de Clientes";
            ws.Range["A1"].Font.Size = 15;
            ws.Range["A1"].Font.Bold = true;
            ws.Range["A2"].Value2 = "Nombre";
            ws.Range["B2"].Value2 = "DNI";
            ws.Range["C2"].Value2 = "Dirección";
            ws.Range["D2"].Value2 = "Teléfono";
            ws.Range["E2"].Value2 = "Correo";
            ws.Range["F2"].Value2 = "Tipo";
            ws.Range["G2"].Value2 = "Prioridad";
            ws.Columns.AutoFit();
        }

    }
 }
