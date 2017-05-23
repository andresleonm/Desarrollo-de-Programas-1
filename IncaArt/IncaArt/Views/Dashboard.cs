﻿using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class Dashboard : Form
    {
        public List<PurchaseOrder> purchase_order_list;        
        public List<Models.Material> material_list;
        public List<Models.Supplier> supplier_list;
        public List<Models.Warehouse> warehouse_list;
        public List<Models.User> user_list;
        public Dashboard()
        {
            InitializeComponent();
            hide_UserControls();            
            mainDashboard1.Visible = true;
            this.mainDashboard1.Controls.Find("metroTile11", false)[0].Click += btn_supplier_Click;
            this.mainDashboard1.Controls.Find("metroTile10", false)[0].Click += btn_warehouse_Click;
            this.mainDashboard1.Controls.Find("metroTile11", false)[0].Click += btn_supplier_Click;
            this.mainDashboard1.Controls.Find("metroTile2", false)[0].Click += btn_client_Click;
            this.mainDashboard1.Controls.Find("metroTile5", false)[0].Click += btn_bom_Click;
            this.mainDashboard1.Controls.Find("metroTile8", false)[0].Click += btn_workstation_Click;
            this.mainDashboard1.Controls.Find("metroTile9", false)[0].Click += btn_parameters_Click;
            this.mainDashboard1.Controls.Find("metroTile1", false)[0].Click += btn_user_Click;
            this.mainDashboard1.Controls.Find("metroTile3", false)[0].Click += btn_worker_Click;
            this.mainDashboard1.Controls.Find("metroTile7", false)[0].Click += btn_material_Click;
            this.mainDashboard1.Controls.Find("metroTile4", false)[0].Click += btn_profile_Click;
            this.mainDashboard1.Controls.Find("metroTile6", false)[0].Click += btn_product_Click;
            this.mainDashboard1.Controls.Find("metroTile12", false)[0].Click += btn_shift_Click;            
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


        private void btn_supplier_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            supplier1.Visible = true;
        }

        private void btn_warehouse_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            warehouse1.Visible = true;
        }


        private void btn_parameters_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            parameters1.Visible = true;
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
            uC_PurchasesMenu1.Visible = true;
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            client1.Visible = true;
        }

        private void btn_bom_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            bom1.Visible = true;
        }

        private void btn_workstation_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            workstation1.Visible = true;
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            user.Visible = true;
        }

        private void btn_worker_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            worker.Visible = true;
        }

        private void btn_material_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            material.Visible = true;
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            profile.Visible = true;
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            product.Visible = true;
        }

        private void btn_shift_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            shift.Visible = true;
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            uC_SalesMain1.Visible = true;
        }

        private void hide_UserControls()
        {
            foreach (UserControl uc in this.Controls.OfType<UserControl>()){
                uc.Visible = false;
            }
        }
        
    }
}
