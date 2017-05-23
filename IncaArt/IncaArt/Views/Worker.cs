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
    public partial class Worker : UserControl
    {
        int last_id;
        int cur_row;
        List<Models.Worker> worker_list;
        List<String> shift_list;
        public Worker()
        {
            InitializeComponent();
        }

        private bool validate_data(String name, String paternal_last_name, String maternal_last_name, String dni, String birthday,char gender,String address,String phone,String email,String shift)
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
                    message += "-El stock mínimo debe ser menor al stock máximo\n";
                }
            }

            MessageBox.Show(message, "Error al registrar un nuevo almacén", MessageBoxButtons.OK);
            return isCorrect;
        }

        private void Worker_Load(object sender, EventArgs e)
        {
            worker_list = new List<Models.Worker>();
            shift_list = new List<string>();

            last_id = worker_list.Count();
            shift_list.Add("Turno 1");
            shift_list.Add("Turno 2");
            shift_list.Add("Turno 3");

            Models.Worker worker = new Models.Worker();
            Models.Person person = new Models.Person();
            person.Name = "Juan";
            person.Paternal_last_name = "Castillo";
            person.Maternal_last_name = "Perez";
            person.Dni = "12345678";

            worker.Id = last_id;
            last_id++;
            worker.Person = person;
            worker.Shift = "Turno 1";
            worker.Status = 1;
            worker_list.Add(worker);

            //Cargar Combobox
            foreach (var item in shift_list)
            {
                combobox_shift.Items.Add(item);
            }
            Load_DataGridView();
        }

        private void Load_DataGridView()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < worker_list.Count(); i++)
            {
                if (worker_list[i].Status == 1)
                {
                    String[] row = new String[6];
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
            char gender = 'M';
            if (radioButton1.Checked)
            {
                gender = 'M';
            }
            else if (radioButton2.Checked)
            {
                gender = 'F';
            }
            Models.Person person = new Models.Person(
                last_id, dni, name, paternal_last_name, maternal_last_name, phone, email, gender, address, birthday);

            Models.Worker worker = new Models.Worker();
            worker.Id = last_id;
            worker.Person = person;
            worker.Shift = shift;
            worker.Status = 1;
            worker_list.Add(worker);
            last_id++;
            Load_DataGridView();
            Clean();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cur_row = e.RowIndex;
            if (dataGridView1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                btn_delete.Enabled = true;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cur_row = e.RowIndex;
            if (dataGridView1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                int id = int.Parse(dataGridView1.Rows[cur_row].Cells[0].Value.ToString());
            }
        }
    }
}
