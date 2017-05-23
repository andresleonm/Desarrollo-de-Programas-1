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
    public partial class UC_Worker : UserControl
    {
        int last_id;
        int cur_row;
        List<Models.Worker> worker_list;
        List<String> shift_list;
        public UC_Worker()
        {
            InitializeComponent();
        }

        private bool validate_data(String name, String paternal_last_name, String maternal_last_name, String dni, DateTime birthday, char gender, String address, String phone, String email, String shift)
        {
            bool isCorrect = true;
            String message = "";
            if (name == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el nombre del trabajador.\n";
            }
            if (paternal_last_name == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el apellido paterno del trabajador.\n";
            }
            if (maternal_last_name == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el apellido materno del trabajador.\n";
            }
            if (dni == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el dni del trabajador.\n";
            }
            if (gender == ' ')
            {
                isCorrect = false;
                message += "- Debe ingresar el género del trabajador.\n";
            }
            if (address == "")
            {
                isCorrect = false;
                message += "- Debe ingresar la dirección del trabajador.\n";
            }
            if (phone == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el teléfono del trabajador.\n";
            }
            if (email == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el email del trabajador.\n";
            }
            if (shift == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el turno del trabajador.\n";
            }

            if (!isCorrect)
            {
                MessageBox.Show(message, "Error al registrar trabajador", MessageBoxButtons.OK);
            }

            return isCorrect;
        }

        private void Worker_Load(object sender, EventArgs e)
        {
            worker_list = ((Dashboard)Parent).worker_list;
            shift_list = new List<string>();

            last_id = worker_list.Count();
            shift_list.Add("Turno 1");
            shift_list.Add("Turno 2");
            shift_list.Add("Turno 3");

            //Cargar Combobox
            foreach (var item in shift_list)
            {
                combobox_shift.Items.Add(item);
            }
            Load_DataGridView("", "", "", "");
        }

        private void Load_DataGridView(String name, String paternal, String maternal, String dni)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < worker_list.Count(); i++)
            {
                if ((name == "" || name.ToUpper() == worker_list[i].Person.Name.ToUpper()) && (paternal == "" || paternal.ToUpper() == worker_list[i].Person.Paternal_last_name.ToUpper()) &&
                    (maternal == "" || maternal.ToUpper() == worker_list[i].Person.Maternal_last_name.ToUpper()) && (dni == "" || dni == worker_list[i].Person.Dni) && worker_list[i].Status == 1)
                {
                    String[] row = new String[7];
                    row[0] = worker_list[i].Id.ToString();
                    row[1] = worker_list[i].Person.Dni;
                    row[2] = worker_list[i].Person.Name;
                    row[3] = worker_list[i].Person.Paternal_last_name;
                    row[4] = worker_list[i].Person.Maternal_last_name;
                    row[5] = worker_list[i].Shift;
                    this.dataGridView1.Rows.Add(row);

                }
            }
        }

        private void Clean()
        {
            textbox_address.Text = "";
            textbox_dni.Text = "";
            textbox_dni_s.Text = "";
            textbox_email.Text = "";
            textbox_maternal.Text = "";
            textbox_maternal_s.Text = "";
            textbox_name.Text = "";
            textbox_name_s.Text = "";
            textbox_paternal.Text = "";
            textbox_paternal_s.Text = "";
            textbox_phone.Text = "";
            combobox_shift.Text = "";
            datetimepicker_birthday.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        //Cancelar
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clean();
        }

        //Registrar
        private void btn_new_Click(object sender, EventArgs e)
        {
            String address = textbox_address.Text;
            String dni = textbox_dni.Text;
            String email = textbox_email.Text;
            String maternal_last_name = textbox_maternal.Text;
            String name = textbox_name.Text;
            String paternal_last_name = textbox_paternal.Text;
            String phone = textbox_phone.Text;
            String shift = combobox_shift.Text;
            DateTime birthday = datetimepicker_birthday.Value;

            char gender = ' ';
            if (radioButton1.Checked)
            {
                gender = 'M';
            }
            else if (radioButton2.Checked)
            {
                gender = 'F';
            }

            if (validate_data(name, paternal_last_name, maternal_last_name, dni, birthday, gender, address, phone, email, shift))
            {
                Models.Person person = new Models.Person(last_id, dni, name, paternal_last_name, maternal_last_name, phone, email, gender, address, birthday);

                Models.Worker worker = new Models.Worker();
                worker.Id = last_id;
                worker.Person = person;
                worker.Shift = shift;
                worker.Status = 1;
                worker_list.Add(worker);
                last_id++;
                Load_DataGridView("", "", "", "");
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
                int id = int.Parse(dataGridView1.Rows[cur_row].Cells[0].Value.ToString());
                foreach (var item in worker_list)
                {
                    if (item.Id == id)
                    {
                        textbox_name.Text = item.Person.Name;
                        textbox_paternal.Text = item.Person.Paternal_last_name;
                        textbox_maternal.Text = item.Person.Maternal_last_name;
                        textbox_dni.Text = item.Person.Dni;
                        datetimepicker_birthday.Value = item.Person.Birthday;
                        if (item.Person.Gender == 'M')
                        {
                            radioButton1.Checked = true;
                        }
                        else
                        {
                            radioButton2.Checked = true;
                        }
                        textbox_address.Text = item.Person.Address;
                        textbox_phone.Text = item.Person.Phone;
                        textbox_email.Text = item.Person.Email;
                        combobox_shift.Text = item.Shift;
                    }
                }
            }
        }

        //Modificar Datos
        private void btn_edit_Click(object sender, EventArgs e)
        {
            String address = textbox_address.Text;
            String dni = textbox_dni.Text;
            String email = textbox_email.Text;
            String maternal_last_name = textbox_maternal.Text;
            String name = textbox_name.Text;
            String paternal_last_name = textbox_paternal.Text;
            String phone = textbox_phone.Text;
            String shift = combobox_shift.Text;
            DateTime birthday = datetimepicker_birthday.Value;

            char gender = 'M';
            if (radioButton1.Checked)
            {
                gender = 'M';
            }
            else if (radioButton2.Checked)
            {
                gender = 'F';
            }

            if (validate_data(name, paternal_last_name, maternal_last_name, dni, birthday, gender, address, phone, email, shift))
            {
                Models.Person person = new Models.Person(last_id, dni, name, paternal_last_name, maternal_last_name, phone, email, gender, address, birthday);

                Models.Worker worker = new Models.Worker();
                worker.Id = int.Parse(dataGridView1.Rows[cur_row].Cells[0].Value.ToString());
                worker.Person = person;
                worker.Shift = shift;
                worker.Status = 1;

                for (int i = 0; i < worker_list.Count(); i++)
                {
                    if (worker_list[i].Id == worker.Id)
                    {
                        worker_list[i].Person = person;
                        worker_list[i].Shift = shift;
                        break;
                    }
                }

                Load_DataGridView("", "", "", "");
                Clean();
            }


        }

        //Buscar
        private void btn_search_Click(object sender, EventArgs e)
        {
            String dni = textbox_dni_s.Text;
            String maternal_last_name = textbox_maternal_s.Text;
            String name = textbox_name_s.Text;
            String paternal_last_name = textbox_paternal_s.Text;
            Load_DataGridView(name, paternal_last_name, maternal_last_name, dni);
        }

        //Eliminar
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[cur_row].Cells[0].Value.ToString());
            for (int i = 0; i < worker_list.Count(); i++)
            {
                if (id == worker_list[i].Id)
                {
                    worker_list.Remove(worker_list[i]);
                    break;
                }
            }
            btn_delete.Enabled = false;
            Load_DataGridView("", "", "", "");
        }

        private void UC_Worker_Leave(object sender, EventArgs e)
        {
            ((Dashboard)Parent).worker_list = worker_list;
        }
    }
}
