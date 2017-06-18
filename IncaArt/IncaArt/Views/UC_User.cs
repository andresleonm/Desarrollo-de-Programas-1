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
    public partial class UC_User : ICheckPermissions
    {
        List<User> user_list;
        List<Profile> profile_list;
        ProfileController profile_controller;
        UsersController user_controller;
        User selectedUser;
        User sessionUser;

        public UC_User()
        {
            InitializeComponent();
            this.metroTabControl1.SelectedIndex = 0;
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
        
        private void Load_DataGridView()
        {
            metroGrid1.Rows.Clear();

            foreach (User u in user_list)
            {
                string[] row = new string[10];
                row[0] = u.Id.ToString();
                row[1] = u.Name;
                row[2] = u.Middlename;
                row[3] = u.Lastname;
                row[4] = u.Nickname;
                row[5] = u.Profile.Description;
                row[6] = u.Email;
                row[7] = u.Phone;
                row[8] = u.Address;
                row[9] = u.Gender.ToString();

                metroGrid1.Rows.Add(row);
            }
        }

        private void Load_Data()
        {
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

            combobox_profile.Items.Clear();

            foreach (Profile profile in this.profile_list)
            {
                combobox_profile.Items.Add(profile.Description);
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
            metroTabControl1.SelectedIndex = 0;
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
                Result transaction_result =  null;
                string message = " ";


                if (selectedUser != null)
                {
                    User user_to_update = new User(0, profile, name, paternal, maternal, phone, email, gender, address, username, password, "", false);
                    user_to_update.Id = selectedUser.Id;
                    user_to_update.State = selectedUser.State;
                    transaction_result = user_controller.updateUser(user_to_update);
                    message = "Usuario editado correctamente.";
                }
                else
                {
                    User user_to_add = new User(0, profile, name, paternal, maternal, phone, email, gender, address, username, password, "PENDING");
                    transaction_result = user_controller.insertUser(user_to_add);
                    message = "Usuario ingresado correctamente.";
                }

                if (transaction_result.success)
                {
                    MessageBox.Show(message);
                    Clean();
                    Load_Data();
                    Load_DataGridView();
                    metroTabControl1.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show(transaction_result.message);
                }
            }

        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];

            if (row.Cells[0].Value != null)
            {
                selectedUser = user_list.Find(u => u.Id == Int32.Parse(row.Cells[0].Value.ToString()));
                textbox_email.Text = selectedUser.Email;
                textbox_maternal.Text = selectedUser.Lastname;
                textbox_name.Text = selectedUser.Name;
                textbox_paternal.Text = selectedUser.Middlename;
                textbox_phone.Text = selectedUser.Phone;
                textbox_password.Text = selectedUser.Password;
                textbox_address.Text = selectedUser.Address;
                textbox_username.Text = selectedUser.Nickname;
                combobox_profile.Text = selectedUser.Profile.Description;

                if (selectedUser.Gender == 'M')
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }

                metroTabControl1.SelectedIndex = 1;
                btn_new.Text = "Editar";
                btn_new.Visible = true;
                textbox_password.Enabled = false;

                if (!sessionUser.Profile.HasFunctionality("EDIT USERS"))
                {
                    btn_new.Visible = false;
                }
            }
        }

        private void tabIndex_Enter(object sender, EventArgs e)
        {
            Clean();
            btn_new.Text = "Guardar";
            btn_new.Visible = true;
            textbox_password.Enabled = true;
            selectedUser = null;

            if (!sessionUser.Profile.HasFunctionality("CREATE USERS"))
            {
                btn_new.Visible = false;
            }
        }

        private void UC_User_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                this.profile_controller = new ProfileController("", "");
                this.user_controller = new UsersController("", "");
                
                Load_Data();
                Load_DataGridView();
            }
            else if (!Visible)
            {
                metroTabControl1.SelectedIndex = 0;
            }
        }

        private void metroButtonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el usuario " + metroGrid1.CurrentRow.Cells[4].Value + " (" + metroGrid1.CurrentRow.Cells[1].Value + " " + metroGrid1.CurrentRow.Cells[2].Value + ")?", "Eliminar Usuario", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                User user_to_delete = user_list.Find(u => u.Id == Int32.Parse(metroGrid1.CurrentRow.Cells[0].Value.ToString()));

                if (sessionUser.Id == user_to_delete.Id)
                {
                    MessageBox.Show("¡No puedes eliminar la sesión actual!");
                }
                else
                {
                    Result deleteResult = user_controller.deleteUser(user_to_delete);

                    if (deleteResult.success)
                    {
                        MessageBox.Show("Usuario eliminado correctamente");
                        Clean();
                        Load_Data();
                        Load_DataGridView();
                    }
                    else
                    {
                        MessageBox.Show(deleteResult.message);
                    }
                }
            }
        }

        private void UC_User_Load()
        {
            if (!sessionUser.Profile.HasFunctionality("DELETE USERS"))
            {
                metroButtonEliminar.Visible = false;
            }

            if (!sessionUser.Profile.HasFunctionality("CREATE USERS") && !sessionUser.Profile.HasFunctionality("EDIT USERS"))
            {
                this.metroTabControl1.TabPages.Remove(tabRegister);
            }
        }

        public override void CheckPermissions(User user)
        {
            sessionUser = user;
            UC_User_Load();
        }
    }
}
