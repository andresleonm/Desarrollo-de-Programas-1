﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Controller;


namespace WindowsFormsApp1.Views
{           
    public partial class UC_SalesOrder : MetroFramework.Controls.MetroUserControl
    {
        private List<Customer> customerL;
        private List<Currency> currencies;
        List<SalesOrderLine> lines;
        private string user = "dp1admin";
        private string password = "dp1admin";

        public UC_SalesOrder()
        {
            InitializeComponent();
            this.Style = mbStyle.Style;
        }

        private void UC_SalesOrder_Load(object sender, EventArgs e)
        {
            mbStyle.Style = MetroFramework.MetroColorStyle.Teal;
            CurrencyController currency_controller = new CurrencyController(user, password);            

            Result result = currency_controller.getCurrencies();
            this.currencies = (List<Currency>)result.data;
            foreach (Currency curr in currencies)
            {
                this.cbo_Currency.Items.Add(curr.Symbol +" - "+ curr.Name);
            }
            //this.cbo_Currency.SelectedItem = this.cbo_Currency.Items[0];
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            customerL= new List<Customer>();
            Sales_Module.SalesOrderSearchClient search_view = new Sales_Module.SalesOrderSearchClient(ref customerL, user, password);
            search_view.ShowDialog();
            if (customerL.Count != 0)
            {
                Customer customer = customerL[0];
                txt_name.Text = customer.Name;
                txt_address.Text = customer.Address;
                txt_Doi.Text= customer.Doi;
                txt_phone.Text = customer.Phone;
            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            lines = new List<SalesOrderLine>();
            Sales_Module.SalesOrderLine order_line = new Sales_Module.SalesOrderLine(ref lines, user,password);
            order_line.ShowDialog();

            List<Models.SalesOrderLine> current = (List<Models.SalesOrderLine>)this.grid_order_lines.DataSource;
            if (current == null)
                current = new List<SalesOrderLine>();
            current = current.Concat(lines).ToList();
            this.grid_order_lines.DataSource = current;
            AdjustColumnOrder();

            double acumulate = 0;
            for (int i = 0; i < grid_order_lines.RowCount; i++)
            {
                acumulate += double.Parse(grid_order_lines.Rows[i].Cells["amount"].Value.ToString());
            }
            txt_amount.Text = acumulate.ToString();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (customerL == null || String.IsNullOrWhiteSpace(cbo_Currency.Text) || String.IsNullOrWhiteSpace(txt_name.Text) || String.IsNullOrWhiteSpace(txt_address.Text) || String.IsNullOrWhiteSpace(txt_Doi.Text) || String.IsNullOrWhiteSpace(txt_phone.Text))
            {
                MessageBox.Show(this, "Debe completar los campos de cliente y/o moneda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SalesOrderController sales_order_controller = new SalesOrderController(user, password);
                SalesOrderLineController sales_order_line_controller = new SalesOrderLineController(user, password);
                SalesOrder sales_order = new SalesOrder();

                sales_order.Customer_id = customerL[0].Id;
                sales_order.Customer_name = txt_name.Text;
                sales_order.Customer_address = txt_address.Text;
                sales_order.Customer_doi = txt_Doi.Text;
                sales_order.Customer_phone = txt_phone.Text;
                sales_order.Currency_id = currencies.ElementAt(cbo_Currency.SelectedIndex).Id;
                sales_order.Currency_name = currencies.ElementAt(cbo_Currency.SelectedIndex).Name;
                sales_order.Currency_symbol = currencies.ElementAt(cbo_Currency.SelectedIndex).Symbol;
                sales_order.Issue_date = DateTime.Now;
                sales_order.Delivery_date = DateTime.Parse(dt_DeliveryDate.Text);
                sales_order.Observation = txt_observation.Text;
                sales_order.Amount = double.Parse(txt_amount.Text);
                sales_order.Status = "Registrado";
                sales_order.Lines = lines;

                int sales_order_id = Int32.Parse(sales_order_controller.insertSalesOrder(sales_order).data.ToString());

                int i = 1;
                foreach (SalesOrderLine sol in lines)
                {
                    sol.Id = i;
                    sol.Order_id = sales_order_id;
                    sol.Status = "Registrado";
                    i++;
                    sales_order_line_controller.insertSalesOrderLine(sol);
                }

                MessageBox.Show(this, "Orden guardada exitosamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                txt_idOrder.Text = sales_order_id.ToString();
                txt_Status.Text = sales_order.Status;

            }            
        }

        private void grid_order_lines_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 7 || e.ColumnIndex == 8)
                {
                    lines[e.RowIndex].Quantity = int.Parse(grid_order_lines.Rows[e.RowIndex].Cells["quantity"].Value.ToString());
                    lines[e.RowIndex].Unit_price = int.Parse(grid_order_lines.Rows[e.RowIndex].Cells["unit_price"].Value.ToString());

                    double update_amount = double.Parse(grid_order_lines.Rows[e.RowIndex].Cells["quantity"].Value.ToString()) * double.Parse(grid_order_lines.Rows[e.RowIndex].Cells["unit_price"].Value.ToString());
                    grid_order_lines.Rows[e.RowIndex].Cells["amount"].Value = update_amount;

                    double acumulate = 0;
                    for (int i = 0; i < grid_order_lines.RowCount; i++)
                    {
                        acumulate += double.Parse(grid_order_lines.Rows[i].Cells["amount"].Value.ToString());
                    }
                    txt_amount.Text = acumulate.ToString();
                }
            }            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void AdjustColumnOrder()
        {
            grid_order_lines.Columns["product"].DisplayIndex = 0;
            grid_order_lines.Columns["unit"].DisplayIndex = 1;
            grid_order_lines.Columns["warehouse"].DisplayIndex = 2;
            grid_order_lines.Columns["quantity"].DisplayIndex = 3;
            grid_order_lines.Columns["unit_price"].DisplayIndex = 4;
            grid_order_lines.Columns["amount"].DisplayIndex = 5;
            grid_order_lines.Columns["action"].DisplayIndex = 6;
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            txt_address.Text = "";
            txt_amount.Text = "";
            txt_Doi.Text = "";
            txt_idOrder.Text = "";
            txt_name.Text = "";
            txt_observation.Text = "";
            txt_phone.Text = "";
            txt_Status.Text = "";
            cbo_Currency.Text = "";
            lines.Clear();
        }
    }
}
