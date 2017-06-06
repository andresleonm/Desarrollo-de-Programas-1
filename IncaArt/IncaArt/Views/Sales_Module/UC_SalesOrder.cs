using System;
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
        private string user = "dp1admin";
        private string password = "dp1admin";
        private bool edit = false;
        private SalesOrder so_edit;
        private List<SalesOrder> sales_orders;
        private List<Customer> customerL;
        private List<Currency> currencies;
        private List<SalesOrderLine> lines;
        private CurrencyController currency_controller;
        private SalesOrderController sales_order_controller;
        private SalesOrderLineController sales_order_line_controller;


        public UC_SalesOrder()
        {
            InitializeComponent();
            this.Style = mbStyle.Style;
        }

        private void UC_SalesOrder_Load(object sender, EventArgs e)
        {
            mbStyle.Style = MetroFramework.MetroColorStyle.Teal;

            currency_controller = new CurrencyController(user, password);
            sales_order_controller = new SalesOrderController(user, password);
            sales_order_line_controller = new SalesOrderLineController(user, password);

            fill_Sales_Order();

            Result result = currency_controller.getCurrencies();
            currencies = (List<Currency>)result.data;

            foreach (Currency curr in currencies)
                this.cbo_Currency.Items.Add(curr.Symbol + "  -  " + curr.Name);

        }

        private void tab_Order_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_Order.SelectedIndex == 0) // Orders
            {
                ctxt_order_id.Text = "";
                ctxt_customer.Text = "";
                //fill_Sales_Order();
            }
            else if(tab_Order.SelectedIndex == 1) // New_Order
            {                
                if (!edit)
                {
                    btn_Clean.PerformClick();
                    txt_idOrder.Text = (sales_orders.Count + 1).ToString();
                }           
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            customerL = new List<Customer>();
            Sales_Module.SalesOrderSearchClient search_view = new Sales_Module.SalesOrderSearchClient(ref customerL, user, password);
            search_view.ShowDialog();

            if (customerL.Count != 0)
            {
                Customer customer = customerL[0];
                txt_name.Text = customer.Name;
                txt_address.Text = customer.Address;
                txt_Doi.Text = customer.Doi;
                txt_phone.Text = customer.Phone;
            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            lines = new List<SalesOrderLine>();
            Sales_Module.SalesOrderLine order_line = new Sales_Module.SalesOrderLine(ref lines, user, password);
            order_line.ShowDialog();

            fill_gridView_OrderLine(lines);

            double acumulate = 0;
            for (int i = 0; i < grid_order_lines.RowCount; i++)
                acumulate += double.Parse(grid_order_lines.Rows[i].Cells["amount"].Value.ToString());
            txt_amount.Text = acumulate.ToString();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                fill_Sales_Order_Object(so_edit);

                if (customerL != null)
                    so_edit.Customer_id = customerL[0].Id;
                
                if (lines.Count > 0)
                    so_edit.Lines = lines;

                //so_edit.Status = "Registrado";

                Result result = sales_order_controller.updateSalesOrder(so_edit);

                if (result.success)
                {
                    foreach (SalesOrderLine sol in so_edit.Lines)
                    {
                        sales_order_line_controller.updateSalesOrderLine(sol);
                    }
                    fill_Sales_Order();
                    edit = false;
                    btn_Clean.PerformClick();
                    tab_Order.SelectedIndex = 0;
                    MessageBox.Show(this, "Orden actualizada exitosamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la orden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (customerL == null || lines == null || String.IsNullOrWhiteSpace(cbo_Currency.Text) || String.IsNullOrWhiteSpace(txt_name.Text) || String.IsNullOrWhiteSpace(txt_address.Text) || String.IsNullOrWhiteSpace(txt_Doi.Text) || String.IsNullOrWhiteSpace(txt_phone.Text))
                {
                    MessageBox.Show(this, "Debe completar los campos de cliente y/o moneda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SalesOrder sales_order = new SalesOrder();
                    fill_Sales_Order_Object(sales_order);
                    sales_order.Customer_id = customerL[0].Id;
                    sales_order.Status = "Registrado";
                    sales_order.Lines = lines;

                    int sales_order_id = Int32.Parse(sales_order_controller.insertSalesOrder(sales_order).data.ToString());

                    if (sales_order_id > 0)
                    {
                        int i = 1;
                        foreach (SalesOrderLine sol in lines)
                        {
                            sol.Id = i;
                            sol.Order_id = sales_order_id;
                            sol.Status = "Registrado";
                            i++;
                            sales_order_line_controller.insertSalesOrderLine(sol);
                        }
                        txt_idOrder.Text = sales_order_id.ToString();
                        txt_Status.Text = sales_order.Status;
                        fill_Sales_Order();
                        btn_Clean.PerformClick();
                        tab_Order.SelectedIndex = 0;
                        MessageBox.Show(this, "Orden creada exitosamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear la orden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            edit = false;
        }

        private void fill_Sales_Order_Object(SalesOrder so)
        {
            so.Customer_name = txt_name.Text;
            so.Customer_address = txt_address.Text;
            so.Customer_doi = txt_Doi.Text;
            so.Customer_phone = txt_phone.Text;
            so.Currency_id = currencies.ElementAt(cbo_Currency.SelectedIndex).Id;
            so.Currency_name = currencies.ElementAt(cbo_Currency.SelectedIndex).Name;
            so.Currency_symbol = currencies.ElementAt(cbo_Currency.SelectedIndex).Symbol;
            so.Issue_date = DateTime.Parse(dt_IssueDate.Text);
            so.Observation = txt_observation.Text;
            so.Amount = double.Parse(txt_amount.Text);
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

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            edit = false;
            txt_address.Text = "";
            txt_amount.Text = "";
            txt_Doi.Text = "";
            txt_idOrder.Text = "";
            txt_name.Text = "";
            txt_observation.Text = "";
            txt_phone.Text = "";
            txt_Status.Text = "";
            cbo_Currency.Text = "";
            customerL = new List<Customer>();
            lines = new List<SalesOrderLine>();
            clean_gridView_OrderLine();
        }

        private void btn_Search_Order_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ctxt_order_id.Text))
            {
                fill_Sales_Order();
            }
            else
            {
                sales_orders = new List<SalesOrder>();
                Result result = sales_order_controller.getSalesOrder(Int32.Parse(ctxt_order_id.Text));
                SalesOrder sol = (SalesOrder)result.data;
                sales_orders.Add(sol);
                fill_gridView_Order(sales_orders);
            }
        }

        private void fill_Sales_Order()
        {
            Result result = sales_order_controller.getSalesOrders();
            sales_orders = (List<SalesOrder>)result.data;
            fill_gridView_Order(sales_orders);
        }

        private void fill_gridView_Order(List<SalesOrder> list)
        {
            clean_gridView_Order();
            List<SalesOrder> current = (List<SalesOrder>)this.grid_orders.DataSource;
            if (current == null)
                current = new List<SalesOrder>();
            current = current.Concat(list).ToList();
            this.grid_orders.DataSource = current;
            AdjustColumnOrder_byOrder();
        }

        private void fill_gridView_OrderLine(List<SalesOrderLine> list)
        {
            clean_gridView_OrderLine();
            List<SalesOrderLine> current = (List<SalesOrderLine>)this.grid_order_lines.DataSource;
            if (current == null)
                current = new List<SalesOrderLine>();
            current = current.Concat(list).ToList();
            this.grid_order_lines.DataSource = current;
            AdjustColumnOrder();
        }

        private void clean_gridView_Order()
        {
            List<SalesOrder> empty_list = new List<SalesOrder>();
            grid_orders.DataSource = empty_list;
        }

        private void clean_gridView_OrderLine()
        {
            List<SalesOrderLine> empty_list = new List<SalesOrderLine>();
            grid_order_lines.DataSource = empty_list;
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

        private void AdjustColumnOrder_byOrder()
        {
            grid_orders.Columns["order_id2"].DisplayIndex = 0;
            grid_orders.Columns["customer_name"].DisplayIndex = 1;
            grid_orders.Columns["issue_date"].DisplayIndex = 2;
            grid_orders.Columns["delivery_date"].DisplayIndex = 3;
            grid_orders.Columns["currency_name"].DisplayIndex = 4;
            grid_orders.Columns["amount2"].DisplayIndex = 5;
            grid_orders.Columns["observation"].DisplayIndex = 6;
            grid_orders.Columns["status"].DisplayIndex = 7;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {            
            int selectedRowCount = grid_orders.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount <= 0)
            {
                MessageBox.Show(this, "Primero debe seleccionar una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (selectedRowCount > 1)
            {
                MessageBox.Show(this, "Solo debe seleccionar una fila para poder editar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (selectedRowCount == 1)
            {
                edit = true;
                int index = grid_orders.SelectedRows[0].Index;
                so_edit = sales_orders[index];
                lines = so_edit.Lines;
                tab_Order.SelectedIndex = 1;
                fill_Sales_Order_Form(so_edit);
            }
        }

        private void fill_Sales_Order_Form(SalesOrder so)
        {
            txt_idOrder.Text = so.Id.ToString();
            txt_name.Text = so.Customer_name;
            txt_address.Text = so.Customer_address;
            txt_Doi.Text = so.Customer_doi;
            txt_phone.Text = so.Customer_phone;
            txt_observation.Text = so.Observation;
            txt_amount.Text = so.Amount.ToString();
            txt_Status.Text = so.Status;
            cbo_Currency.Text = so.Currency_symbol + "  -  " + so.Currency_name;
            dt_IssueDate.Text = so.Issue_date.ToString();

            fill_gridView_OrderLine(so.Lines);

            int i = 0;
            foreach (SalesOrderLine sol in so.Lines)
            {
                grid_order_lines.Rows[i].Cells["amount"].Value = (sol.Quantity * sol.Unit_price).ToString();
                i++;
            }
        }
        
    }
}
