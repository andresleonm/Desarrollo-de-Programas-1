﻿using System;
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
            Purchase_Module.Register frm_register_purchase = new Purchase_Module.Register();
            frm_register_purchase.MdiParent = this;
            frm_register_purchase.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_crud_worker_Click(object sender, EventArgs e)
        {
            CRUD.Worker frm_crud_worker = new CRUD.Worker();
            frm_crud_worker.MdiParent = this;
            frm_crud_worker.Show();
        }

        private void btn_crud_material_Click(object sender, EventArgs e)
        {
            CRUD.Material frm_crud_material = new CRUD.Material();
            frm_crud_material.MdiParent = this;
            frm_crud_material.Show();
        }

        private void btn_crud_user_Click(object sender, EventArgs e)
        {
            CRUD.User frm_crud_user = new CRUD.User();
            frm_crud_user.MdiParent = this;
            frm_crud_user.Show();
        }
    }
}
