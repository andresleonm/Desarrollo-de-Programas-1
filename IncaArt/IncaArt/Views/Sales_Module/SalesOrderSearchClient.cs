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
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1.Views.Sales_Module
{
    public partial class SalesOrderSearchClient : Form
    {   
        private List<Customer> customers;
        public List<Customer> clientList;
        private CustomerController customer_controller;
        private string customer_type;

        public SalesOrderSearchClient( ref List<Customer> client, string user, string password, char type)
        {
            InitializeComponent();
            clientList = client;

            customer_controller = new CustomerController(user, password);
            Result result;
            if (type == 'E')
            { 
                result = customer_controller.getCustomers_foreign();
                customer_type = "Extranjero";
            }
            else { 
                result = customer_controller.getCustomers();
                customer_type = "";
            }
            customers = (List<Customer>)result.data;
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
                Result result;
                if (customer_type.Equals("Extranjero"))
                    result = customer_controller.getCustomer_by_text_foreign(text, customer_type);
                else
                    result = customer_controller.getCustomer_by_text(text);
                List<Customer> customers_found = new List<Customer>();
                customers_found = (List<Customer>)result.data;
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
                Customer client_found = (Customer)grid_clients.CurrentRow.DataBoundItem;
                clientList.Add(client_found);
                this.Close();
            }
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_Search.PerformClick();
        }


        private void AdjustColumnOrder()
        {
            grid_clients.Columns["name"].DisplayIndex = 0;
            grid_clients.Columns["address"].DisplayIndex = 1;
            grid_clients.Columns["doi"].DisplayIndex = 2;
            grid_clients.Columns["phone"].DisplayIndex = 3;
            grid_clients.Columns["email"].DisplayIndex = 4;
            grid_clients.Columns["priority"].DisplayIndex = 5;
        }

        private void fill_GridView(List<Customer> list)
        {
            grid_clients.DataSource = new List<Customer>();
            grid_clients.DataSource = list;
            AdjustColumnOrder();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
