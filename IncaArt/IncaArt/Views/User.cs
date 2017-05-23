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
    public partial class User : UserControl
    {
        int last_id;
        int cur_row;
        List<Models.User> user_list;
        List<String> profile_list;
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            user_list = new List<Models.User>();
            profile_list = new List<string>();

            last_id = user_list.Count();

            profile_list.Add("SuperAdmin");
            profile_list.Add("Admin");
            profile_list.Add("Usuario");

            Models.User user = new Models.User();

            user.Id = last_id;
            user.Name = "Jose";
            user.Paternal_last_name = "Castillo";
            user.Maternal_last_name = "Perez";
            user.Profile = "Admin";
            user.Status = 1;

            last_id++;

            user_list.Add(user);

            //Cargar Combobox
            foreach (var item in profile_list)
            {
                combobox_profile.Items.Add(item);
                combobox_profile_s.Items.Add(item);
            }
            Load_DataGridView();
        }

        private void Load_DataGridView()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < user_list.Count(); i++)
            {
                if (user_list[i].Status == 1)
                {
                    String[] row = new String[5];
                    row[0] = user_list[i].Id.ToString();
                    row[1] = user_list[i].Name;
                    row[2] = user_list[i].Paternal_last_name;
                    row[3] = user_list[i].Maternal_last_name;
                    row[4] = user_list[i].Profile;
                    this.dataGridView1.Rows.Add(row);

                }
            }
        }

        private void Clean()
        {
            textbox_email.Text = "";
            textbox_maternal.Text = "";
            textbox_maternal_s.Text = "";
            textbox_name.Text = "";
            textbox_name_s.Text = "";
            textbox_paternal.Text = "";
            textbox_paternal_s.Text = "";
            textbox_phone.Text = "";
            textbox_password.Text = "";
            combobox_profile.Text = "";
            combobox_profile_s.Text = "";
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
            String email = textbox_email.Text;
            String maternal = textbox_maternal.Text;
            String name = textbox_name.Text;
            String paternal = textbox_paternal.Text;
            String phone = textbox_phone.Text;
            String password = textbox_password.Text;
            String profile = combobox_profile.Text;
            char gender = 'M';
            if (radioButton1.Checked)
            {
                gender = 'M';
            }
            else if (radioButton2.Checked)
            {
                gender = 'F';
            }
            Models.User user = new Models.User();
            user.Id = last_id;
            user.Name = name;
            user.Paternal_last_name = paternal;
            user.Maternal_last_name = maternal;
            user.Gender = gender;
            user.Phone = phone;
            user.Profile = profile;
            user.Email = email;
            user.Password = password;
            user.Status = 1;

            last_id++;
            user_list.Add(user);
            Clean();
            Load_DataGridView();
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
