using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views.Purchase_Module
{
    public partial class PurchaseOrderLine : Form
    {
        public PurchaseOrderLine()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConfirmationDialog confirm_dialog = new ConfirmationDialog();            
            if (confirm_dialog.ShowDialog(this) == DialogResult.OK)
            {
                confirm_dialog.Dispose();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
