using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Views;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Frm_Login : Form
    {
        UsersController usersController;
        public Frm_Login()
        {
            InitializeComponent();
            usersController = new UsersController("", "");
        }

        private void Btn_CancelLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Result userResult = usersController.getUserByNickname(textBoxNickname.Text);

            if (userResult.success)
            {
                User user = (User)userResult.data;

                if (user.isPassword(this.textBoxPassword.Text))
                {
                    Dashboard main_form = new Dashboard();
                    MessageBox.Show("Bienvenido " + user.Name);
                    main_form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta");
                }
            }
            else
            {
                MessageBox.Show(userResult.message);
            }
        }
    }
}
