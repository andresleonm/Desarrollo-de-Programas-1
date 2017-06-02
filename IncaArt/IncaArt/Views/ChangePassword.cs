using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1.Views
{
    public partial class ChangePassword : Form
    {
        User user;
        UsersController user_controller;
        bool should_close;
        public ChangePassword(User user)
        {
            InitializeComponent();
            this.user = user;
            user_controller = new UsersController("", "");
            should_close = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string pass = text_box_password.Text;
            string confirm = text_box_confirmation.Text;
            

            if (pass == confirm)
            {
                user.setPassword(pass);
                user.State = "ACTIVE";
                user_controller.updateUser(user);
                should_close = true;
                Close();
            }
            else
            {
                MessageBox.Show("Las contraseñas ingresadas no son iguales.");
            }
        }

        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !should_close;
        }
    }
}
