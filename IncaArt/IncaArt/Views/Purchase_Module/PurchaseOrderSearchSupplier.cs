﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1.Views.Purchase_Module
{
    public partial class PurchaseOrderSearchSupplier : Form
    {   
        private List<Models.Supplier> customers;
        public List<Models.Supplier> clientList;
        private SupplierController customer_controller;
        private string customer_type;


        public PurchaseOrderSearchSupplier( ref List<Models.Supplier> client, string user, string password)
        {
            InitializeComponent();
            clientList = client;

            customer_controller = new SupplierController(user, password);
            Result result = customer_controller.getSuppliers();
            
            customers = (List<Models.Supplier>)result.data;
            fill_GridView(customers);                      
        }

        private void SalesOrderSearchClient_Load(object sender, EventArgs e)
        {
            txt_name.Select();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                grid_clients.DataSource = customers;
                AdjustColumnOrder();
            }
            else
            {
                string text = "%" + (txt_name.Text).ToLower() + "%";
                Result result = customer_controller.getSupplier_by_text(text);
                List<Models.Supplier> customers_found = new List<Models.Supplier>();
                customers_found = (List<Models.Supplier>)result.data;
                fill_GridView(customers_found);               
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int selectedRowCount = grid_clients.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount <= 0)
            {
                MessageBox.Show(this, "Primero debe seleccionar una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (selectedRowCount > 1)
            {
                MessageBox.Show(this, "Solo debe seleccionar una fila para poder ver el detalle", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (selectedRowCount == 1)
            {
                Models.Supplier client_found = (Models.Supplier)grid_clients.CurrentRow.DataBoundItem;
                clientList.Add(client_found);
                this.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_Search.PerformClick();
        }
        
        private void AdjustColumnOrder()
        {
            grid_clients.Columns["name"].DisplayIndex = 0;
            grid_clients.Columns["type"].DisplayIndex = 1;
            grid_clients.Columns["address"].DisplayIndex = 2;
            grid_clients.Columns["doi"].DisplayIndex = 3;
            grid_clients.Columns["phone"].DisplayIndex = 4;
            grid_clients.Columns["email"].DisplayIndex = 5;
            grid_clients.Columns["priority"].DisplayIndex = 6;
            
        }

        private void fill_GridView(List<Models.Supplier> list)
        {
            grid_clients.DataSource = new List<Supplier>();
            grid_clients.DataSource = list;
            AdjustColumnOrder();
        }

        private void grid_clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Models.Supplier client_found = (Models.Supplier)grid_clients.CurrentRow.DataBoundItem;
            clientList.Add(client_found);
            this.Close();
        }
    }
}
