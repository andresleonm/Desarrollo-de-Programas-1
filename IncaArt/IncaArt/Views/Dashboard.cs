using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, MouseEventArgs e)
        {
            highlightButtons(sender);
        }

        private void highlightButtons(object sender)
        {
            btn_config.BackColor = Color.RoyalBlue;
            btn_config.ForeColor = Color.White;
            btn_config.ImageIndex = 1;
            btn_warehouse.BackColor = Color.RoyalBlue;
            btn_warehouse.ForeColor = Color.White;
            btn_warehouse.ImageIndex = 1;
            btn_sales.BackColor = Color.RoyalBlue;
            btn_sales.ForeColor = Color.White;
            btn_sales.ImageIndex = 1;
            btn_purchase.BackColor = Color.RoyalBlue;
            btn_purchase.ForeColor = Color.White;
            btn_purchase.ImageIndex = 1;

            ((Button)sender).BackColor = Color.White;
            ((Button)sender).ForeColor = Color.RoyalBlue;
            ((Button)sender).ImageIndex = Math.Abs(((Button)sender).ImageIndex - 1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.RoyalBlue;
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.LightSteelBlue;
        }

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            mainDashboard1.Visible = true;
        }

        private void btn_logo_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            mainDashboard1.Visible = true;
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            uC_PurchaseOrder1.Visible = true;
        }

        private void hide_UserControls()
        {
            foreach (UserControl uc in this.Controls.OfType<UserControl>()){
                uc.Visible = false;
            }
        }
    }
}
