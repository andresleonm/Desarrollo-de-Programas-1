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
            this.Cursor = Cursors.WaitCursor;

            Result userResult = usersController.getUserByNickname(textBoxNickname.Text);

            if (userResult.success)
            {
                User user = (User)userResult.data;

                if (user.isPassword(this.textBoxPassword.Text))
                {
                    if (user.State == "PENDING")
                    {
                        ChangePassword change = new ChangePassword(user);
                        this.Cursor = Cursors.Arrow;
                        change.ShowDialog(this);
                    }

                    this.Cursor = Cursors.WaitCursor;
                    DataService.DatabaseService.updateConnection(user.Nickname, user.Password);
                    Dashboard main_form = new Dashboard(user);
                    this.Cursor = Cursors.Arrow;
                    MessageBox.Show("Bienvenido " + user.Name);
                    main_form.Show();
                    Hide();
                }
                else
                {
                    this.Cursor = Cursors.Arrow;
                    MessageBox.Show("La contraseña es incorrecta");
                }
            }
            else
            {
                this.Cursor = Cursors.Arrow;
                MessageBox.Show(userResult.message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgot = new ForgotPassword();
            forgot.ShowDialog();
        }
    }
}
