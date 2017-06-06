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
    public partial class UC_Worker : MetroFramework.Controls.MetroUserControl
    {
        bool name_flag;
        bool paternal_flag;
        bool maternal_flag;
        bool doi_flag;
        bool birthday_flag;
        bool shift_flag;
        bool salary_flag;
        bool currency_flag;
        int cur_row;
        List<Models.Shift> shift_list;
        List<Models.Worker> worker_list;
        List<Models.Currency> currency_list;
        Controller.WorkerController workerController;
        Controller.ShiftsController shiftController;
        Controller.CurrencyController currencyController;
        Controller.Result result;
        public UC_Worker()
        {
            InitializeComponent();
        }

        private void UC_Worker_Load(object sender, EventArgs e)
        {
            Set_Flag_All(false);
            string user = "dp1admin";
            string password = "dp1admin";
            workerController = new Controller.WorkerController(user, password);
            shiftController = new Controller.ShiftsController(user, password);
            currencyController = new Controller.CurrencyController(user, password);
            Load_Data();
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

            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
        }

        private void Load_Data()
        {
            result = currencyController.getCurrencies();
            currency_list = (List<Models.Currency>)result.data;
            result = shiftController.getShifts();
            if (result.data == null) MessageBox.Show(result.message, "Error al listar turnos", MessageBoxButtons.OK);
            else shift_list = (List<Models.Shift>)result.data;

            result = workerController.getWokers();
            if (result.data==null) MessageBox.Show(result.message, "Error al listar trabajadores", MessageBoxButtons.OK);
            else worker_list = (List<Models.Worker>)result.data;
        }

        private void Load_DataGridView()
        {
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
            if (radiobutton_m.Checked)
            {
                worker.Gender = 'M';
            }else if (radiobutton_f.Checked)
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
                        combobox_shift.SelectedIndex = i+1;
                        break;
                    }
                }
                for (int i = 0; i < currency_list.Count(); i++)
                {
                    if (currency_list[i].Id ==worker.Currency_id)
                    {
                        combobox_currency.SelectedIndex = i+1;
                        break;
                    }
                }
                textbox_name.Text = worker.Name;
                textbox_paternal.Text = worker.Paternal_name;
                textbox_maternal.Text = worker.Maternal_name;
                textbox_doi.Text = worker.Doi;
                datetime_birthday.Value = worker.Birthday;
                metroTabControl1.SelectedIndex = 1;
                if (worker.Gender == 'M')
                {
                    radiobutton_m.Checked = true;
                }else if (worker.Gender == 'F')
                {
                    radiobutton_f.Checked = true;
                }
                textbox_telephone.Text = worker.Telephone;
                textbox_phone.Text = worker.Phone;
                textbox_email.Text = worker.Email;
                textbox_address.Text = worker.Address;
                textbox_salary.Text = worker.Salary.ToString();
                Set_Flag_All(true);
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
            worker.Doi = textbox_paternal_s.Text;
            worker.Shift_id= ((KeyValuePair<int, string>)combobox_shift_s.SelectedItem).Key;
            result = workerController.getWokers(worker);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al buscar producto con filtro", MessageBoxButtons.OK);
            }
            else
            {
                worker_list = (List<Models.Worker>)result.data;
                Load_DataGridView();
            }
        }

        private void textbox_Validating(object sender, CancelEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textbox = (MetroFramework.Controls.MetroTextBox)sender;
            string text = textbox.Text;

            if (String.IsNullOrEmpty(text))
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

            if (String.IsNullOrEmpty(text))
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
            if (datetimepicker.Text==null)
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
            if (name_flag && paternal_flag && maternal_flag && doi_flag && birthday_flag && shift_flag && salary_flag && currency_flag)
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
            }
        }
    }
}

