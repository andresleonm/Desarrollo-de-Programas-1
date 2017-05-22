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
            button3.BackColor = Color.RoyalBlue;
            button3.ForeColor = Color.White;
            button4.BackColor = Color.RoyalBlue;
            button4.ForeColor = Color.White;
            button5.BackColor = Color.RoyalBlue;
            button5.ForeColor = Color.White;
            button6.BackColor = Color.RoyalBlue;
            button6.ForeColor = Color.White;            

            ((Button)sender).BackColor = Color.White;
            ((Button)sender).ForeColor = Color.RoyalBlue;
            ((Button)sender).ImageIndex = 0;
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
        
    }
}
