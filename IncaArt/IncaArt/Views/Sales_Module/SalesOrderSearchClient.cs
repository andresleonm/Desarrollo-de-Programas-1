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
        private string user = "dp1admin";
        private string password = "dp1admin";
        public List<Customer> cliente;

        public SalesOrderSearchClient( ref List<Customer> client, string user, string password)
        {
            InitializeComponent();

            CustomerController customer_controller = new CustomerController(user, password);
            Result result = customer_controller.getCustomers();
            this.customers = (List<Customer>)result.data;
            grid_clients.DataSource = new List<Customer>();
            grid_clients.DataSource = customers;
            AdjustColumnOrder();
            this.cliente = client;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                grid_clients.DataSource = customers;                
            }
            else
            {
                string text = "%" + txt_name.Text + "%";
                CustomerController customer_controller = new CustomerController(user, password);
                Result result = customer_controller.getCustomer_by_text(text);
                List<Customer> customers_found = new List<Customer>();
                customers_found = (List<Customer>)result.data;
                grid_clients.DataSource = new List<Customer>();
                grid_clients.DataSource = customers_found;                
            }
            AdjustColumnOrder();
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Customer cliente= (Customer)grid_clients.CurrentRow.DataBoundItem;
            this.cliente.Add(cliente);
            this.Close();
        }
    }
}
