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
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1.Views
{
    public partial class UC_User : UserControl
    {
        List<User> user_list;
        List<Profile> profile_list;
        ProfileController profile_controller;
        UsersController user_controller;

        public UC_User()
        {
            InitializeComponent();
            //profile_list = new List<Profile>();

        }

        private bool validate_data(String name, String paternal_last_name, String maternal_last_name,char gender, String phone, String email, String address, String username,String password,String profile)
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
            if (!Regex.IsMatch(phone, @"^\d+$"))
            {
                isCorrect = false;
                message += "- Debe ingresar un teléfono válido (solamente con digitos).\n";
            }
            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"))
            {
                isCorrect = false;
                message += "- Debe ingresar un email válido.\n";
            }
            if (address == "")
            {
                isCorrect = false;
                message += "- Debe ingresar la direccion del usuario.\n";
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
            this.profile_controller = new ProfileController("", "");
            this.user_controller = new UsersController("", "");

            Result profiles_result = profile_controller.getProfiles();
            Result users_result = user_controller.getUsers();

            if (profiles_result.success)
            {
                this.profile_list = (List<Profile>)profiles_result.data;
            }
            else
            {
                MessageBox.Show(profiles_result.message);
            }

            if (users_result.success)
            {
                this.user_list = (List<User>)users_result.data;
            }
            else
            {
                MessageBox.Show(users_result.message);
            }


            foreach (Profile profile in this.profile_list)
            {
                combobox_profile.Items.Add(profile.Description);
            }

            Load_DataGridView();
        }
        
        private void Load_DataGridView()
        {
            metroGrid1.Rows.Clear();

            foreach (User u in user_list)
            {
                string[] row = new string[10];
                row[0] = u.Name;
                row[1] = u.Middlename;
                row[2] = u.Lastname;
                row[3] = u.Nickname;
                row[4] = u.Profile.Description;
                row[5] = u.Email;
                row[6] = u.Phone;
                row[7] = u.Address;
                row[8] = u.Gender.ToString();

                metroGrid1.Rows.Add(row);
            }
        }

        private void Clean()
        {
            textbox_email.Text = "";
            textbox_maternal.Text = "";
            textbox_name.Text = "";
            textbox_paternal.Text = "";
            textbox_phone.Text = "";
            textbox_password.Text = "";
            textbox_address.Text = "";
            textbox_username.Text = "";
            combobox_profile.Text = "";
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
            String profile_name = combobox_profile.Text;
            String username = textbox_username.Text;
            String address = textbox_address.Text;
            char gender = ' ';
            if (radioButton1.Checked)
            {
                gender = 'M';
            }
            else if (radioButton2.Checked)
            {
                gender = 'F';
            }

            if (validate_data(name, paternal, maternal, gender, phone, email, address, username, password, profile_name))
            {
                Profile profile = profile_list.Find(p => p.Description == profile_name);
                User user = new User(0, profile, name, paternal, maternal, phone, email, gender, address, username, password, "");
                Result insert_result = user_controller.insertUser(user);

                if (insert_result.success)
                {
                    Clean();
                    MessageBox.Show("Usuario ingresado correctamente.");
                }
                else
                {
                    MessageBox.Show(insert_result.message);
                }
            }

        }

        private void UC_User_Leave(object sender, EventArgs e)
        {
            ((Dashboard)Parent).user_list = user_list;
        }
    }
}
