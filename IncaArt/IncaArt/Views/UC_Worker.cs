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
        int cur_row;
        List<Models.Shift> shift_list;
        List<Models.Worker> worker_list;
        Controller.WorkerController workerController;
        Controller.ShiftsController shiftController;
        Controller.Result result;
        public UC_Worker()
        {
            InitializeComponent();
        }

        private void UC_Worker_Load(object sender, EventArgs e)
        {
            string user = "dp1admin";
            string password = "dp1admin";
            workerController = new Controller.WorkerController(user, password);
            shiftController = new Controller.ShiftsController(user, password);
            Load_Data();
            //Cargar los combobox
            Dictionary<int, string> combo_data = new Dictionary<int, string>();
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

            Load_DataGridView();
            metroTabControl1.SelectedIndex = 0;
        }

        private void Load_Data()
        {
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
            result = workerController.insertWorker(worker);
            if (result.data == null)
            {
                MessageBox.Show(result.message, "Error al registrar trabajador", MessageBoxButtons.OK);
            }
            else
            {
                Load_Data();
            }

            Load_DataGridView();
            Clean();
            metroTabControl1.SelectedIndex = 0;
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
                int index = int.Parse(metroGrid1.Rows[cur_row].Cells[1].Value.ToString());
                Models.Worker worker = worker_list[index];
                for (int i = 0; i < shift_list.Count(); i++)
                {
                    if (shift_list[i].Description == metroGrid1.Rows[cur_row].Cells[6].Value.ToString())
                    {
                        combobox_shift.SelectedIndex = i;
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
            }
        }
    }
}
