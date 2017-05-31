﻿using System;
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
        Models.PurchaseOrderLine line;
        List<Models.Material> materials;
        List<Models.MaterialWarehouse> warehouses;
        public PurchaseOrderLine(ref Models.PurchaseOrderLine line)
        {
            InitializeComponent();
            this.line = line;
            materials = new List<Models.Material>();
            warehouses = new List<Models.MaterialWarehouse>();
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
                DialogResult result = MessageBox.Show(this,"¿Está seguro que desea realizar esta operación?","Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Models.Material material = new Models.Material();
                    int quantity = int.Parse(this.txt_quantity.Text);
                    //line.Material = material;
                    line.Quantity = quantity;
                    line.Price = quantity * material.Average_cost;
                    this.Close();
                    //line = new Models.PurchaseOrderLine(material, 1, 1);
                }
            }
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            Models.Material material = new Models.Material(); // se tiene que sacar el material de la lista para rellenar los campos bloqueados
            this.txt_measure_unit.Text = material.Unit.Name;                    

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

        private void PurchaseOrderLine_Load(object sender, EventArgs e)
        {
            string user = "dp1admin";
            string password = "dp1admin";
            Controller.MaterialsController material_controller = new Controller.MaterialsController(user,password);
            Controller.MaterialWarehouseController warehouse_controller = new Controller.MaterialWarehouseController("dp1admin","dp1admin");

            Controller.Result result = material_controller.getMaterials();
            this.materials = (List<Models.Material>)result.data;

            if (((List<Models.Material>)result.data).Count != 0)
            {
                foreach (Models.Material m in materials)
                {
                    this.combo_material.Items.Add(m.Name);
                }
                this.combo_material.SelectedItem = this.combo_material.Items[0];
            }

            result = warehouse_controller.getMaterialWarehouses();
            if (((List<Models.MaterialWarehouse>)result.data).Count != 0)
            {
                this.warehouses = (List<Models.MaterialWarehouse>)result.data;

                foreach (Models.MaterialWarehouse w in warehouses)
                {
                    this.combo_warehouse.Items.Add(w.Name);
                }
                this.combo_warehouse.SelectedItem = this.combo_warehouse.Items[0];
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
            
        }
    }
}
