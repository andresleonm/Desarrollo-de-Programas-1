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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ts_almacen.Visible = false;
            this.ts_compras.Visible = false;
            this.ts_mant.Visible = false;
            this.ts_ventas.Visible = false;
        }

        private void btn_Mant_Click(object sender, EventArgs e)
        {
            this.ts_almacen.Visible = false;
            this.ts_compras.Visible = false;            
            this.ts_ventas.Visible = false;
            this.ts_mant.Visible = true;
            this.btn_Mant.BackColor = SystemColors.Highlight;
            this.btn_Almacen.BackColor = SystemColors.Control;
            this.btn_Compras.BackColor = SystemColors.Control;
            this.btn_Ventas.BackColor = SystemColors.Control; 
        }

        private void btn_Almacen_Click(object sender, EventArgs e)
        {            
            this.ts_compras.Visible = false;
            this.ts_mant.Visible = false;
            this.ts_ventas.Visible = false;
            this.ts_almacen.Visible = true;
            this.btn_Mant.BackColor = SystemColors.Control;
            this.btn_Almacen.BackColor = SystemColors.Highlight;
            this.btn_Compras.BackColor = SystemColors.Control;
            this.btn_Ventas.BackColor = SystemColors.Control;
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            this.ts_almacen.Visible = false;
            this.ts_compras.Visible = false;
            this.ts_mant.Visible = false;
            this.ts_ventas.Visible = true;
            this.btn_Mant.BackColor = SystemColors.Control;
            this.btn_Almacen.BackColor = SystemColors.Control;
            this.btn_Compras.BackColor = SystemColors.Control;
            this.btn_Ventas.BackColor = SystemColors.Highlight;
        }

        private void btn_Compras_Click(object sender, EventArgs e)
        {
            this.ts_almacen.Visible = false;            
            this.ts_mant.Visible = false;
            this.ts_ventas.Visible = false;
            this.ts_compras.Visible = true;
            this.btn_Mant.BackColor = SystemColors.Control;
            this.btn_Almacen.BackColor = SystemColors.Control;
            this.btn_Compras.BackColor = SystemColors.Highlight;
            this.btn_Ventas.BackColor = SystemColors.Control;
        }

        private void btn_register_purchase_Click(object sender, EventArgs e)
        {
            Purchase_Module.PurchaseOrder frm_register_purchase = new Purchase_Module.PurchaseOrder();
            frm_register_purchase.MdiParent = this;            
            frm_register_purchase.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ts_compras_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Cliente frm_client = new Cliente();
            frm_client.MdiParent = this;
            frm_client.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            BOM frm_bom = new BOM();
            frm_bom.MdiParent = this;
            frm_bom.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Workstation frm_workstation = new Workstation();
            frm_workstation.MdiParent = this;
            frm_workstation.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            CRUD.User frm_user = new CRUD.User();
            frm_user.MdiParent = this;
            frm_user.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CRUD.Worker frm_worker = new CRUD.Worker();
            frm_worker.MdiParent = this;
            frm_worker.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            CRUD.Material frm_material = new CRUD.Material();
            frm_material.MdiParent = this;
            frm_material.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            WarehouseMovementP frm_material = new WarehouseMovementP();
            frm_material.MdiParent = this;
            frm_material.Show();

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            WarehouseMovementM frm_material = new WarehouseMovementM();
            frm_material.MdiParent = this;
            frm_material.Show();

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Product frm_Product = new Product();
            frm_Product.MdiParent = this;
            frm_Product.Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Profile frm_Profile = new Profile();
            frm_Profile.MdiParent = this;
            frm_Profile.Show();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            Shift frm_Shift = new Shift();
            frm_Shift.MdiParent = this;
            frm_Shift.Show();
        }
    }
}
