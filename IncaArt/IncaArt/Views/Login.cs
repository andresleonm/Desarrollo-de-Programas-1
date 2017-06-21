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
        int failedAttempts;
        int prevUserId;
        const int MAX_FAILED_ATTEMPTS = 5;
        public Frm_Login()
        {
            failedAttempts = 0;
            prevUserId = 0;
            InitializeComponent();
            usersController = new UsersController("", "");
        }

        private void Btn_CancelLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartUserSession(User user)
        {
            this.Cursor = Cursors.WaitCursor;
            DataService.DatabaseService.updateConnection(user.Nickname, user.Password);

            Result logInResult = usersController.logIn(user);

            if (!logInResult.success)
            {
                MessageBox.Show(logInResult.message);
            }
            else
            {
                Dashboard main_form = new Dashboard(user);
                main_form.FormClosing += this.DashboardClosingHandler;
                this.Cursor = Cursors.Arrow;
                this.Visible = false;
                MessageBox.Show("Bienvenido " + user.Name);
                main_form.Show();
            }
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            Result userResult = usersController.getUserByNickname(textBoxNickname.Text);

            if (userResult.success)
            {
                User user = (User)userResult.data;

                if (user.State == "BLOCKED")
                {
                    this.Cursor = Cursors.Arrow;
                    MessageBox.Show("El usuario ha sido bloqueado por razones de seguridad. Puede recuperar su contraseña haciendo click en el boton ¿Has olvidado tu contraseña?");
                }
                else if (user.isPassword(this.textBoxPassword.Text))
                {
                    textBoxPassword.Text = "";
                    textBoxNickname.Text = "";
                    prevUserId = 0;
                    failedAttempts = 0;

                    if (user.State == "PENDING")
                    {
                        ChangePassword change = new ChangePassword(user);
                        this.Cursor = Cursors.Arrow;
                        change.ShowDialog(this);
                    }
                    //else if (user.State == "LOGGED")
                    //{
                    //    this.Cursor = Cursors.Arrow;
                    //    MessageBox.Show("El usuario ingresado ya tiene una sesion abierta");
                    //}
                    else
                    {
                        StartUserSession(user);
                    }
                }
                else
                {
                    this.Cursor = Cursors.Arrow;
                    if (prevUserId == user.Id)
                    {
                        failedAttempts++;
                    }
                    else
                    {
                        failedAttempts = 1;
                    }

                    prevUserId = user.Id;

                    string msg = "La contraseña es incorrecta";

                    if (failedAttempts == MAX_FAILED_ATTEMPTS)
                    {
                        msg += " y hemos bloqueado tu cuenta razones de seguridad";
                        usersController.block(user);
                    }
                    else if (failedAttempts >= (MAX_FAILED_ATTEMPTS - 2))
                    {
                        msg += ". Hemos detectado " + failedAttempts + " intento fallidos, al quinto intento fallido la cuenta sera bloqueada";
                    }

                    MessageBox.Show(msg);
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

        private void DashboardClosingHandler(object o, EventArgs e)
        {
            Dashboard d = (Dashboard)o;
            usersController.logOut(d.sessionUser);
            this.Visible = true;
        }
    }
}
