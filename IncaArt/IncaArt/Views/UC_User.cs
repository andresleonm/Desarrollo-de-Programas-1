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
    public partial class UC_User : UserControl
    {
        int last_id;
        int cur_row;
        List<Models.User> user_list;
        List<String> profile_list;
        public UC_User()
        {
            InitializeComponent();
        }

        private bool validate_data(String name, String paternal_last_name, String maternal_last_name,char gender, String phone, String email, String username,String password,String profile)
        {
            bool isCorrect = true;
            String message = "";
            if (name == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el nombre del usuario.\n";
            }
            if (paternal_last_name == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el apellido paterno del usuario.\n";
            }
            if (maternal_last_name == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el apellido materno del usuario.\n";
            }
           
            if (gender == ' ')
            {
                isCorrect = false;
                message += "- Debe ingresar el género del usuario.\n";
            }
            
            if (phone == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el teléfono del usuario.\n";
            }
            if (email == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el email del usuario.\n";
            }

            if (username == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el nombre de usuario del usuario.\n";
            }

            if (password == "")
            {
                isCorrect = false;
                message += "- Debe ingresar la contraseña del usuario.\n";
            }

            if (profile == "")
            {
                isCorrect = false;
                message += "- Debe ingresar el perfil del usuario.\n";
            }

            if (!isCorrect)
            {
                MessageBox.Show(message, "Error al registrar usuario", MessageBoxButtons.OK);
            }

            return isCorrect;
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
            Load_DataGridView("","","","","");
        }

        private void Load_DataGridView(String name, String paternal, String maternal,String username,String profile)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < user_list.Count(); i++)
            {
                if ((name == "" || name.ToUpper() == user_list[i].Name.ToUpper()) && (paternal == "" || paternal.ToUpper() == user_list[i].Paternal_last_name.ToUpper()) &&
                    (maternal == "" || maternal.ToUpper() == user_list[i].Maternal_last_name.ToUpper()) && (username == "" || username.ToUpper() == user_list[i].Username.ToUpper()) &&
                    (name == "" || profile.ToUpper() == user_list[i].Profile.ToUpper()) && user_list[i].Status == 1)
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
            Load_DataGridView("", "", "", "", "");
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
