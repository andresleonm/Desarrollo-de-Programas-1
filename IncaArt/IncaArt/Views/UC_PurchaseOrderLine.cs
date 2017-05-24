using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class UC_PurchaseOrderLine : UserControl
    {
        Models.PurchaseOrderLine line;
        public UC_PurchaseOrderLine()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.RoyalBlue;
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.LightSteelBlue;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_quantity.Text) || String.IsNullOrWhiteSpace(txt_unit_price.Text))
            {
                MessageBox.Show(this, "Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show(this, "¿Está seguro que desea realizar esta operación?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Models.Material material = new Models.Material();
                    int quantity = int.Parse(this.txt_quantity.Text);
                    line = new Models.PurchaseOrderLine(material, 1, 1);
                }
            }
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            Models.Material material = new Models.Material(); // se tiene que sacar el material de la lista para rellenar los campos bloqueados
            this.txt_measure_unit.Text = material.Unit.Name;
            this.txt_description.Text = material.Description;

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        
    }
}
