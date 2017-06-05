using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Services;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class ForgotPassword : Form
    {
        UsersController user_controller;
        MailService mail_service;
        HashService hash_service;

        public ForgotPassword()
        {
            InitializeComponent();
            user_controller = new UsersController("", "");
            mail_service = new MailService();
            hash_service = new HashService();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string nickname = text_box_nickname.Text;
            Result result = user_controller.getUserByNickname(nickname);

            if (result.success)
            {
                User user = (User)result.data;
                string new_pass = hash_service.HashText(DateTime.Now.ToString());
                user.setPassword(new_pass);
                user.State = "PENDING";
                result = user_controller.updateUser(user);

                if (result.success)
                {
                    Result mail_sent = mail_service.sendMail(user.Name + " " + user.Middlename + "<" + user.Email + ">", "Tu nueva contraseña es: " + new_pass, "[IncaArt] Nueva Contraseña");

                    if (mail_sent.success)
                    {
                        MessageBox.Show("Hemos enviado un email con tu nueva contraseña con la que podrás acceder al sistema");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un problema al enviar el email, verifica tu conexión a internet e inténtalo de nuevo\n" + mail_sent.message);
                    }
                }
                else
                {
                    MessageBox.Show(result.message);
                }
            }
            else
            {
                MessageBox.Show(result.message);
            }

        }
    }
}
