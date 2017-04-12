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
    public partial class Frm_MainMenu : Form
    {
        public Frm_MainMenu()
        {
            InitializeComponent();
        }

        private void Frm_MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e) // Ventas
        {
            this.toolStrip3.Visible = false;
            this.btn_Almacen.BackColor = SystemColors.Control;

            this.toolStrip2.Visible = true;
            this.btn_Ventas.BackColor = SystemColors.ActiveCaption;            
        }

        private void toolStripButton1_Click(object sender, EventArgs e) // Almacen
        {
            this.toolStrip2.Visible = false;
            this.btn_Ventas.BackColor = SystemColors.Control;

            this.toolStrip3.Visible = true;
            this.btn_Almacen.BackColor = SystemColors.ActiveCaption;
            
        }

        private void Frm_MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
