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

namespace WindowsFormsApp1
{
    public partial class Frm_Login : Form
    {

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Btn_CancelLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Frm_MainMenu frm_MainMenu = new Frm_MainMenu();
            frm_MainMenu.Show();
            this.Hide();

        }
    }
}
