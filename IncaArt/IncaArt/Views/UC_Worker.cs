using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using Microsoft.Office.Interop.Excel;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class UC_Worker : ICheckPermissions
    {
        bool name_flag;
        bool paternal_flag;
        bool maternal_flag;
        bool doi_flag;
        bool birthday_flag;
        bool shift_flag;
        bool salary_flag;
        bool currency_flag;
        bool email_flag;
        int cur_row;
        int operation_value;// 0 para Create, 1 para Update
        List<Models.Shift> shift_list;
        List<Models.Worker> worker_list;
        List<Models.Currency> currency_list;
        Controller.WorkerController workerController;
        Controller.ShiftsController shiftController;
        Controller.CurrencyController currencyController;
        Controller.Result result;
        Models.User sessionUser;
        ProgressBarForm progressform;
        public UC_Worker()
        {
            InitializeComponent();
        }

        private void UC_Worker_VisibleChanged(object sender, EventArgs e)
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

        private void UC_Worker_Load(object sender, EventArgs e)
        {
            string user = "";
            string password = "";
            workerController = new Controller.WorkerController(user, password);
            shiftController = new Controller.ShiftsController(user, password);
            currencyController = new Controller.CurrencyController(user, password);
            progressform = new ProgressBarForm();
        }

        private void Load_Combobox()
        {
            //Cargar los combobox

            //Turno
            Dictionary<int, string> combo_data = new Dictionary<int, string>();
            combo_data.Add(0, "Seleccionar");
            foreach (var item in shift_list)
            {
                combo_data.Add(item.Id, item.Description);

            }
            combobox_shift.DataSource = new BindingSource(combo_data, null);
            combobox_shift.DisplayMember = "Value";
            combobox_shift.ValueMember = "Key";
            combobox_shift_s.DataSource = new BindingSource(combo_data, null);
            combobox_shift_s.DisplayMember = "Value";
            combobox_shift_s.ValueMember = "Key";

            //Moneda
            combo_data = new Dictionary<int, string>();
            combo_data.Add(0, "-");
            foreach (var item in currency_list)
            {
                combo_data.Add(item.Id, item.Symbol);

            }
            combobox_currency.DataSource = new BindingSource(combo_data, null);
            combobox_currency.DisplayMember = "Value";
            combobox_currency.ValueMember = "Key";
        }

        private void Load_Data()
        {
            progressform.SetupValues(0, 30, 0);
            progressform.Show();
            result = currencyController.getCurrencies();
            currency_list = (List<Models.Currency>)result.data;
            progressform.IncrementProgress(10);
            result = shiftController.getShifts();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar turnos", MessageBoxButtons.OK);
            else shift_list = (List<Models.Shift>)result.data;
            progressform.IncrementProgress(10);
            result = workerController.getWokers();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar trabajadores", MessageBoxButtons.OK);
            else worker_list = (List<Models.Worker>)result.data;
            progressform.IncrementProgress(10);
            Load_Combobox();
        }

        private void Load_DataGridView()
        {
            progressform.SetupValues(30, 30 + worker_list.Count(), 30);
            metroGrid1.Rows.Clear();
            for (int i = 0; i < worker_list.Count(); i++)
            {
                Models.Shift shift = new Models.Shift();
                result = shiftController.getShift(worker_list[i].Shift_id);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al buscar turno", MessageBoxButtons.OK);
                }
                else
                {
                    shift = (Models.Shift)result.data;
                    String[] row = new String[7];
                    row[0] = worker_list[i].Id.ToString();
                    row[1] = i.ToString();
                    row[2] = worker_list[i].Doi;
                    row[3] = worker_list[i].Name;
                    row[4] = worker_list[i].Paternal_name;
                    row[5] = worker_list[i].Maternal_name;
                    row[6] = shift.Description;
                    this.metroGrid1.Rows.Add(row);
                }
                progressform.IncrementProgress(1);
            }
            progressform.Hide();
        }

        private void Clean()
        {
            ClearTextBoxes(this);
            combobox_currency.SelectedIndex = 0;
            combobox_shift.SelectedIndex = 0;
            combobox_shift_s.SelectedIndex = 0;
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

        private Models.Worker CreateWorker(int operacion)
        {
            if (!Validate_Data())
            {
                MessageBox.Show("Hay campos inválidos", "Error", MessageBoxButtons.OK);
                return null;
            }
            Models.Worker worker = new Models.Worker();
            worker.Name = textbox_name.Text;
            worker.Paternal_name = textbox_paternal.Text;
            worker.Maternal_name = textbox_maternal.Text;
            worker.Doi = textbox_doi.Text;
            worker.Birthday = datetime_birthday.Value.Date;
            worker.Gender = 'M';
            if (radiobutton_m.Checked)
            {
                worker.Gender = 'M';
            }
            else if (radiobutton_f.Checked)
            {
                worker.Gender = 'F';
            }
            worker.Telephone = textbox_telephone.Text;
            worker.Phone = textbox_phone.Text;
            worker.Email = textbox_email.Text;
            worker.Address = textbox_address.Text;
            worker.Salary = double.Parse(textbox_salary.Text);
            worker.Shift_id = ((KeyValuePair<int, string>)combobox_shift.SelectedItem).Key;
            worker.Currency_id = ((KeyValuePair<int, string>)combobox_currency.SelectedItem).Key;
            int id = 0;
            if (operacion == 1) //UPDATE
            {
                id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
            }
            worker.Id = id;

            return worker;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Models.Worker worker = CreateWorker(0);
            if (worker != null)
            {
                result = workerController.insertWorker(worker);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al registrar trabajador", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Trabajador registrado correctamente", "Registrar trabajador", MessageBoxButtons.OK);
                    Load_Data();
                }
                Set_Flag_All(false);
                Load_DataGridView();
                Clean();
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

        //mostrar Datos
        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.Rows[cur_row].Cells[1].Value != null)
            {
                int id = int.Parse(metroGrid1.Rows[cur_row].Cells[0].Value.ToString());
                Models.Worker worker;
                result = workerController.getWorker(id);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al buscar trabajador", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    worker = (Models.Worker)result.data;
                }
                for (int i = 0; i < shift_list.Count(); i++)
                {
                    if (shift_list[i].Description == metroGrid1.Rows[cur_row].Cells[6].Value.ToString())
                    {
                        combobox_shift.SelectedIndex = i + 1;
                        break;
                    }
                }
                for (int i = 0; i < currency_list.Count(); i++)
                {
                    if (currency_list[i].Id == worker.Currency_id)
                    {
                        combobox_currency.SelectedIndex = i + 1;
                        break;
                    }
                }
                textbox_name.Text = worker.Name;
                textbox_paternal.Text = worker.Paternal_name;
                textbox_maternal.Text = worker.Maternal_name;
                textbox_doi.Text = worker.Doi;
                string birthday_string = worker.Birthday.ToShortDateString();
                if (birthday_string.Equals("01/01/0001"))
                {
                    datetime_birthday.Value = new DateTime(1900,01,01);
                }
                else
                {
                    datetime_birthday.Value = worker.Birthday;
                }
                metroTabControl1.SelectedIndex = 1;
                if (worker.Gender == 'M')
                {
                    radiobutton_m.Checked = true;
                }
                else if (worker.Gender == 'F')
                {
                    radiobutton_f.Checked = true;
                }
                textbox_telephone.Text = worker.Telephone;
                textbox_phone.Text = worker.Phone;
                textbox_email.Text = worker.Email;
                textbox_address.Text = worker.Address;
                textbox_salary.Text = worker.Salary.ToString();
                Set_Flag_All(true);
                operation_value = 1;
            }
        }

        //Editar
        private void btn_edit_Click(object sender, EventArgs e)
        {
            Models.Worker worker = CreateWorker(1);
            if (worker != null)
            {
                result = workerController.updateWorker(worker);
                if (result.data == null)
                {
                    MessageBox.Show(result.message, "Error al editar trabajador", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Trabajador editado correctamente", "Editar trabajador", MessageBoxButtons.OK);
                    Load_Data();
                }
                Set_Flag_All(false);
                Load_DataGridView();
                Clean();
                metroTabControl1.SelectedIndex = 0;
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
            result = workerController.deleteWorker(worker_list[index]);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al eliminar trabajador", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Trabajador eliminado correctamente", "Eliminar trabajador", MessageBoxButtons.OK);
                Load_Data();
            }
            //btn_delete.Enabled = false;
            Load_DataGridView();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clean();
            metroTabControl1.SelectedIndex = 0;
            operation_value = 0;
        }

        private void btn_clean_s_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Models.Worker worker = new Models.Worker();
            worker.Name = textbox_name_s.Text;
            worker.Paternal_name = textbox_paternal_s.Text;
            worker.Maternal_name = textbox_maternal_s.Text;
            worker.Doi = textbox_doi_s.Text;
            worker.Shift_id = ((KeyValuePair<int, string>)combobox_shift_s.SelectedItem).Key;
            progressform.SetupValues(0, 30, 0);
            progressform.Show();
            result = workerController.getWokers(worker);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al buscar producto con filtro", MessageBoxButtons.OK);
                progressform.Hide();
            }
            else
            {
                progressform.IncrementProgress(30);
                worker_list = (List<Models.Worker>)result.data;
                Load_DataGridView();
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
            if (textbox.Name == "textbox_salary")
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

        private void textbox_email_Validating(object sender, CancelEventArgs e)
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
                var validation = new EmailAddressAttribute();
                if (validation.IsValid(text))
                {
                    Set_Flag(textbox.Name, true);
                    errorProvider.SetError(textbox, null);
                }
                else
                {
                    Set_Flag(textbox.Name, false);
                    errorProvider.SetError(textbox, "Correo inválido");
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
                double number;
                if (!Double.TryParse(text, out number))
                {
                    Set_Flag(textbox.Name, false);
                    errorProvider.SetError(textbox, "Campo debe ser número");
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

        private void datetimepicker_Validating(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroDateTime datetimepicker = (MetroFramework.Controls.MetroDateTime)sender;
            if (datetimepicker.Text == null)
            {
                Set_Flag(datetimepicker.Name, false);
                errorProvider.SetError(datetimepicker, "Se debe seleccionar");

            }
            else
            {
                Set_Flag(datetimepicker.Name, true);
                errorProvider.SetError(datetimepicker, null);
            }
        }

        private bool Validate_Data()
        {
            if (name_flag && paternal_flag && maternal_flag && doi_flag && shift_flag && salary_flag && currency_flag && email_flag)
            {
                return true;
            }
            return false;
        }

        private void Set_Flag_All(bool value)
        {
            name_flag = value;
            paternal_flag = value;
            maternal_flag = value;
            doi_flag = value;
            birthday_flag = value;
            shift_flag = value;
            salary_flag = value;
            currency_flag = value;
            email_flag = value;
        }

        private void Set_Flag(string name, bool value)
        {
            switch (name)
            {
                case "textbox_name":
                    name_flag = value;
                    break;
                case "textbox_paternal":
                    paternal_flag = value;
                    break;
                case "textbox_maternal":
                    maternal_flag = value;
                    break;
                case "textbox_doi":
                    doi_flag = value;
                    break;
                case "datetime_birthday":
                    birthday_flag = value;
                    break;
                case "combobox_shift":
                    shift_flag = value;
                    break;
                case "textbox_salary":
                    salary_flag = value;
                    break;
                case "combobox_currency":
                    currency_flag = value;
                    break;
                case "textbox_email":
                    email_flag = value;
                    break;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Models.Worker worker = CreateWorker(operation_value);
            if (worker != null)
            {
                if (worker.Id == 0)
                {
                    result = workerController.insertWorker(worker);
                    if (result.data == null)
                    {
                        MessageBox.Show(result.message, "Error al registrar trabajador", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Trabajador registrado correctamente", "Registrar trabajador", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    result = workerController.updateWorker(worker);
                    if (result.data == null)
                    {
                        MessageBox.Show(result.message, "Error al editar trabajador", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Trabajador editado correctamente", "Editar trabajador", MessageBoxButtons.OK);
                    }
                }
                Load_Data();
                Set_Flag_All(false);
                Load_DataGridView();
                Clean();
                metroTabControl1.SelectedIndex = 0;
            }
            operation_value = 0;
        }

        private partial class WorkerError //Clase temporal para manejo de Excel con filas con errores
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
                string name = "", paternal = "", maternal = "", dni = "", shift = "", currency = "";
                double salary = -1, number;
                bool error; //error individual
                bool found;
                List<string> error_list, string_list; //para hacer control de cada error de fila
                Models.Worker worker;
                int currency_id = 0, shift_id = 0, success_lines = 0, error_lines = 0;
                List<WorkerError> worker_error_list = new List<WorkerError>(); //Lista de materiales para el Excel con error
                Controller.Result temp;
                progressform.SetupValues(0, row_count, 0);
                progressform.Show();
                //En Interop Excel el indice comienza en 1
                for (int i = 3; i <= row_count; i++) //Fila 3 comienza las filas de materiales
                {
                    error = false;
                    WorkerError worker_error = new WorkerError();
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
                    //A. Paterno
                    datarange = (Range)ws.Cells[i, 2];
                    string_list.Add((string)datarange.Text);
                    if (string.IsNullOrWhiteSpace((string)datarange.Text) || double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
                        error_list.Add("paternal");
                    }
                    else
                    {
                        paternal = (string)datarange.Value2;
                    }
                    //A. Materno
                    datarange = (Range)ws.Cells[i, 3];
                    string_list.Add((string)datarange.Text);
                    if (string.IsNullOrWhiteSpace((string)datarange.Text) || double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
                        error_list.Add("maternal");
                    }
                    else
                    {
                        maternal = (string)datarange.Value2;
                    }
                    //DNI
                    datarange = (Range)ws.Cells[i, 4];
                    string_list.Add((string)datarange.Text);
                    if (datarange.Value2 == null || !double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
                        error_list.Add("dni");
                    }
                    else
                    {
                        dni = ((double)datarange.Value2).ToString();
                    }
                    //Turno
                    datarange = (Range)ws.Cells[i, 5];
                    string_list.Add((string)datarange.Text);
                    if (string.IsNullOrWhiteSpace((string)datarange.Text) || double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
                        error_list.Add("shift");
                    }
                    else
                    {
                        shift = (string)datarange.Value2;
                        found = false;
                        foreach (var item in shift_list)
                        {
                            if (item.Description.ToUpper().Equals(shift.ToUpper()))
                            {
                                shift_id = item.Id;
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            error = true;
                            error_list.Add("shift_find");
                        }
                    }
                    //Salario
                    datarange = (Range)ws.Cells[i, 6];
                    string_list.Add((string)datarange.Text);
                    if (datarange.Value2 == null || !double.TryParse((string)datarange.Text, out number))
                    {
                        error = true;
                        error_list.Add("dni");
                    }
                    else
                    {
                        salary = ((double)datarange.Value2);
                    }
                    //Moneda
                    datarange = (Range)ws.Cells[i, 7];
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
                        worker_error.error_list = error_list;
                        worker_error.string_list = string_list;
                        worker_error_list.Add(worker_error);
                        error_lines++;
                    }
                    else
                    {
                        worker = new Models.Worker();
                        worker.Name = name;
                        worker.Paternal_name = paternal;
                        worker.Maternal_name = maternal;
                        worker.Doi = dni;
                        worker.Salary = salary;
                        worker.Shift_id = shift_id;
                        worker.Currency_id = currency_id;
                        worker.Phone = " ";
                        worker.Email = " ";
                        worker.Telephone = " ";
                        worker.Address = " ";
                        worker.Gender = ' ';
                        temp=workerController.insertWorker(worker);
                        if (!temp.success)
                        {
                            error = true;
                            error_list.Add(temp.message);
                            worker_error.error_list = error_list;
                            worker_error.string_list = string_list;
                            worker_error_list.Add(worker_error);
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
                if (worker_error_list.Count > 0) //Hubo por lo menos una fila con error
                {
                    CreateExcelError(worker_error_list);
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

        private void CreateExcelError(List<WorkerError> list)
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
            ws.Name = "Trabajadores";
            if (ws == null)
            {
                Console.WriteLine("Worksheet could not be created. Check that your office installation and project references are correct.");
            }

            ws.Range["A1"].Value2 = "Lista de Trabajadores con Error";
            ws.Range["A1"].Font.Size = 15;
            ws.Range["A1"].Font.Bold = true;
            ws.Range["A2"].Value2 = "Nombre";
            ws.Range["B2"].Value2 = "Apellido Paterno";
            ws.Range["C2"].Value2 = "Apellido Materno";
            ws.Range["D2"].Value2 = "DNI";
            ws.Range["E2"].Value2 = "Turno";
            ws.Range["F2"].Value2 = "Salario";
            ws.Range["G2"].Value2 = "Moneda";
            ws.Range["H2"].Value2 = "Observaciones";
            string observation;
            WorkerError worker_error;
            for (int i = 0; i < list.Count(); i++)
            {
                observation = "";
                worker_error = list[i];
                for (int j = 0; j < list[i].string_list.Count(); j++)//Se pone los datos del material escrito
                {
                    ((Range)ws.Cells[i + 3, j + 1]).Value2 = worker_error.string_list[j];
                }
                foreach (var item in worker_error.error_list)
                {
                    switch (item)
                    {
                        case "name":
                            observation += "Nombre inválido. ";
                            break;
                        case "paternal":
                            observation += "Apellido Paterno inválido. ";
                            break;
                        case "maternal":
                            observation += "Apellido Materno inválido. ";
                            break;
                        case "dni":
                            observation += "DNI inválido. ";
                            break;
                        case "shift":
                            observation += "Turno inválido. ";
                            break;
                        case "shift_find":
                            observation += "Turno no encontrado. ";
                            break;
                        case "salary":
                            observation += "Salario inválido. ";
                            break;
                        case "currency":
                            observation += "Moneda inválida. ";
                            break;
                        case "currency_id":
                            observation += "Moneda no encontrada. ";
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
            ws.Name = "Trabajadores";
            if (ws == null)
            {
                Console.WriteLine("Worksheet could not be created. Check that your office installation and project references are correct.");
            }
            ws.Range["A1"].Value2 = "Lista de Trabajadores";
            ws.Range["A1"].Font.Size = 15;
            ws.Range["A1"].Font.Bold = true;
            ws.Range["A2"].Value2 = "Nombre";
            ws.Range["B2"].Value2 = "Apellido Paterno";
            ws.Range["C2"].Value2 = "Apellido Materno";
            ws.Range["D2"].Value2 = "DNI";
            ws.Range["E2"].Value2 = "Turno";
            ws.Range["F2"].Value2 = "Salario";
            ws.Range["G2"].Value2 = "Moneda";
            ws.Columns.AutoFit();
        }

        public override void CheckPermissions(User u)
        {
            sessionUser = u;
            Permissions();
        }

        private void Permissions()
        {
            if (!sessionUser.Profile.HasFunctionality("CREATE WORKERS") && !sessionUser.Profile.HasFunctionality("EDIT WORKERS"))
            {
                this.metroTabControl1.TabPages.Remove(tabRegister);
            }
            if (!sessionUser.Profile.HasFunctionality("DELETE WORKERS"))
            {
                btn_delete.Visible = false;
            }

        }
    }
}

