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
        private Customer customer;
        private SalesEstimate estimate;
        private List<Currency> currencies;
        private CurrencyController currency_controller;
        private SalesOrderController sales_order_controller;
        private SalesEstimateLineController sales_estimate_line_controller;
        private SalesOrderLineController sales_order_line_controller;


        public UC_SalesOrder()
        {
            InitializeComponent();

            currency_controller = new CurrencyController(user, password);
            sales_order_controller = new SalesOrderController(user, password);
            sales_order_line_controller = new SalesOrderLineController(user, password);
            sales_estimate_line_controller = new SalesEstimateLineController(user, password);

            fill_Sales_Order();
        }

        private void UC_SalesOrder_Load(object sender, EventArgs e)
        {
            Result result = currency_controller.getCurrencies();
            currencies = (List<Currency>)result.data;

            foreach (Currency curr in currencies)
                this.cbo_Currency.Items.Add(curr.Symbol + "  -  " + curr.Name);
        }

        private void tab_Order_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_Order.SelectedIndex == 0) // Orders
            {
                btn_Clean.PerformClick();
                btn_Clean.PerformClick();
                ctxt_order_id.Text = "";
                ctxt_customer.Text = "";
                customer = new Customer();
                estimate = new SalesEstimate();
                fill_Sales_Order();
            }
            else if (tab_Order.SelectedIndex == 1) // New Order
            {
                if (!edit)
                {
                    customer = new Customer();
                    estimate = new SalesEstimate();
                    btn_Clean.PerformClick();
                    btn_Clean.PerformClick();
                }
            }
        }

        #region CONSULTANT ORDER
        // -----------------------------------------------------
        //                   CONSULTANT ORDER
        // -----------------------------------------------------

        private void btn_SearchClient_Click(object sender, EventArgs e)
        {
            var customerL = new List<Customer>();
            Sales_Module.SalesOrderSearchClient search_view = new Sales_Module.SalesOrderSearchClient(ref customerL, user, password, 'A');
            search_view.ShowDialog();

            if (customerL.Count != 0)
            {
                customer = customerL[0];
                ctxt_customer.Text = customer.Name;
            }
        }

        private void btn_Search_Orders_Click(object sender, EventArgs e)
        {
            SalesOrder sales_order = new SalesOrder();
            DateTime init = dt_iniDate.Value.Date;
            DateTime end = dt_endDate.Value.Date;
            Boolean equals = false;
            if (init == end) equals = true;
            if (ctxt_order_id.Text != "")
                sales_order.Id = Int32.Parse((ctxt_order_id.Text));
            else
                sales_order.Id = -1;

            sales_order.Customer_name = ctxt_customer.Text;

            Result result = sales_order_controller.getSalesOrder_by_filter(sales_order, init, end,equals);

            if (result.data == null)
                MessageBox.Show(result.message, "Error al buscar pedidos con filtros", MessageBoxButtons.OK);
            else
            {
                sales_orders = new List<SalesOrder>();
                sales_orders = (List<SalesOrder>)result.data;
                fill_gridView_Order(sales_orders);
            }
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
                active_Edit();
            }
        }

        private void grid_orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            active_Edit();
        }

        private void active_Edit()
        {
            edit = true;
            int index = grid_orders.SelectedRows[0].Index;
            var id = sales_orders[index].Id;
            so_edit = (Models.SalesOrder)sales_order_controller.getSalesOrder(id).data;
            grid_order_lines.DataSource = so_edit.Lines;

            tab_Order.SelectedIndex = 1;
            fill_Sales_Order_Form(so_edit);
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
            AdjustColumnOrder();
        }

        private void clean_gridView_Order()
        {
            List<SalesOrder> empty_list = new List<SalesOrder>();
            grid_orders.DataSource = empty_list;
        }

        private void AdjustColumnOrder()
        {
            grid_orders.Columns["order_id2"].DisplayIndex = 0;
            grid_orders.Columns["customer_name"].DisplayIndex = 1;
            grid_orders.Columns["issue_date"].DisplayIndex = 2;
            grid_orders.Columns["currency_name"].DisplayIndex = 3;
            grid_orders.Columns["amount2"].DisplayIndex = 4;
            grid_orders.Columns["observation"].DisplayIndex = 5;
            grid_orders.Columns["status"].DisplayIndex = 6;
        }

         #endregion

        #region REGISTER ORDER
        // -----------------------------------------------------
        //                   REGISTER ORDER
        // -----------------------------------------------------

        private void btn_Search_Client_Click(object sender, EventArgs e)
        {            
            clean_Customer();
            var customerL = new List<Customer>();
            Sales_Module.SalesOrderSearchClient search_view = new Sales_Module.SalesOrderSearchClient(ref customerL, user, password, 'A');
            search_view.ShowDialog();

            if (customerL.Count != 0)
            {
                customer = customerL[0];

                if (customer.Type.Equals("Extranjero"))
                {
                    var estimateL = new List<SalesEstimate>();
                    Sales_Module.SalesOrderEstimate search_view2 = new Sales_Module.SalesOrderEstimate(ref estimateL, user, password, customer.Id);
                    search_view2.ShowDialog();

                    if (estimateL.Count != 0)
                    {
                        estimate = estimateL[0];
                        txt_name.Text = estimate.Customer_name;
                        txt_address.Text = estimate.Customer_address;
                        txt_Doi.Text = estimate.Customer_doi;
                        txt_phone.Text = estimate.Customer_phone;

                        var lines = sales_estimate_line_controller.getSalesEstimateLines(estimate.Id).data;
                        estimate.Lines = (List<SalesEstimateLine>)lines;
                        fill_Sales_Order_Form_With_Estimation(estimate);
                        manipulate_options(false);
                    }
                    else
                    {
                        btn_Clean.PerformClick();
                        btn_Clean.PerformClick();
                    }
                }
                else
                {
                    btn_Clean.PerformClick();
                    btn_Clean.PerformClick();
                    customer = customerL[0];
                    txt_name.Text = customer.Name;
                    txt_address.Text = customer.Address;
                    txt_Doi.Text = customer.Doi;
                    txt_phone.Text = customer.Phone;
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var lines = new List<SalesOrderLine>();
            Sales_Module.SalesOrderLine order_line = new Sales_Module.SalesOrderLine(ref lines, user, password);
            order_line.ShowDialog();

            fill_gridView_OrderLine(lines);

            double acumulate = 0;
            for (int i = 0; i < grid_order_lines.RowCount; i++)
                acumulate += double.Parse(grid_order_lines.Rows[i].Cells["amount"].Value.ToString());
            txt_amount.Text = acumulate.ToString("0.00");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            dt_IssueHour.Text = "";
            dt_IssueDate.Text = "";

            if (customer == null)
                customer = new Customer(txt_name.Text, txt_address.Text, txt_phone.Text, txt_Doi.Text);
            if (edit)
            {
                fill_Sales_Order_Object(so_edit);

                if (customer != null)
                    so_edit.Customer_id = customer.Id;

                var lines = (List<SalesOrderLine>)grid_order_lines.DataSource;
                if (lines.Count > 0)
                    so_edit.Lines = lines;

                Result result = sales_order_controller.updateSalesOrder(so_edit);

                if (result.success)
                {
                    int id = so_edit.getMaxId();
                    int i = 1;
                    foreach (SalesOrderLine sol in so_edit.Lines)
                    {
                        if (sol.Id == 0)
                        {
                            sol.Id = id + 1;
                            sol.Order_id = so_edit.Id;
                            result = sales_order_line_controller.insertSalesOrderLine(sol);
                            id++;
                        }
                        else
                            result = sales_order_line_controller.updateSalesOrderLine(sol);

                        if (!result.success)
                        {
                            MessageBox.Show(this, result.message + "  -  Error fila " + i.ToString(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        i++;
                    }
                    btn_Clean.PerformClick();
                    tab_Order.SelectedIndex = 0;
                    MessageBox.Show(this, "Orden actualizada exitosamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    edit = false;
                    so_edit = new SalesOrder();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la orden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (customer.Name == "" || customer.Phone == "" || customer.Doi == "" ||
                    String.IsNullOrWhiteSpace(cbo_Currency.Text) || 
                    String.IsNullOrWhiteSpace(txt_name.Text) || String.IsNullOrWhiteSpace(txt_address.Text) || String.IsNullOrWhiteSpace(txt_Doi.Text) || String.IsNullOrWhiteSpace(txt_phone.Text))
                {
                    MessageBox.Show(this, "Debe completar los campos de cliente y/o moneda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List<Models.SalesOrderLine> detail = (List<Models.SalesOrderLine>)this.grid_order_lines.DataSource;
                if (detail == null || detail.Count == 0 || allIsZero(detail))
                {
                    MessageBox.Show("Seleccione por lo menos una línea del pedido con cantidad diferente de 0");
                    return;
                }

                if (!allGreatherThanZero(detail))
                {
                    MessageBox.Show("Las cantidades deben ser mayores a 0");
                    return;
                }

                Models.SalesOrder sales_order = new Models.SalesOrder();
                sales_order.Lines = detail;
                fill_Sales_Order_Object(sales_order);
                sales_order.Customer_id = customer.Id;

                Result result = sales_order_controller.insertSalesOrder(sales_order);

                if (result.success)
                {                    
                    MessageBox.Show(this, "Se ha creado el pedido N° : " + result.data.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    btn_Clean.PerformClick();
                    tab_Order.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show(result.message);
                }
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                List<Models.SalesOrderLine> data = (List<Models.SalesOrderLine>)grid_order_lines.DataSource;
                try
                {
                    Models.SalesOrderLine currentObject = (Models.SalesOrderLine)grid_order_lines.CurrentRow.DataBoundItem;
                    if (currentObject == null)
                        MessageBox.Show("Seleccione la línea que desea eliminar");
                    data.Remove(currentObject);
                    data = data.Concat(new List<Models.SalesOrderLine>().ToList()).ToList();
                    grid_order_lines.DataSource = data;
                    AdjustColumnOrderLine();
                    refresh_amount();
                }
                catch
                {
                    grid_order_lines.DataSource = new List<Models.SalesOrderLine>();
                    return;
                }
            }
            catch 
            {
                grid_order_lines.DataSource = new List<Models.SalesOrderLine>();
                return;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            btn_Clean.PerformClick();
            btn_Clean.PerformClick();
            this.Visible = false;
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            edit = false;
            so_edit = new SalesOrder();
            manipulate_options(true);
            Clean();
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                txt_Doi.Select();
        }

        private void txt_Doi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                txt_address.Select();
        }

        private void txt_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                txt_phone.Select();
        }

        private void grid_order_lines_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 6 || e.ColumnIndex == 7)
                {
                    double update_amount = double.Parse(grid_order_lines.Rows[e.RowIndex].Cells["quantity"].Value.ToString()) * double.Parse(grid_order_lines.Rows[e.RowIndex].Cells["unit_price"].Value.ToString());
                    grid_order_lines.Rows[e.RowIndex].Cells["amount"].Value = update_amount;

                    refresh_amount();
                }
            }
        }

        private void refresh_amount()
        {
            double acumulate = 0;
            for (int i = 0; i < grid_order_lines.RowCount; i++)
            {
                acumulate += double.Parse(grid_order_lines.Rows[i].Cells["amount"].Value.ToString());
            }
            txt_amount.Text = acumulate.ToString("0.00");
        }

        private bool allIsZero(List<Models.SalesOrderLine> lines)
        {
            foreach (Models.SalesOrderLine line in lines)
            {
                if (line.Quantity != 0)
                    return false;
            }
            return true;
        }

        private bool allGreatherThanZero(List<Models.SalesOrderLine> lines)
        {
            foreach (Models.SalesOrderLine line in lines)
            {
                if (line.Quantity < 0)
                    return false;
            }
            return true;
        }

        private void fill_Sales_Order_Object(SalesOrder so)
        {
            so.Customer_name = txt_name.Text;
            so.Customer_doi = txt_Doi.Text;
            so.Customer_address = txt_address.Text;
            so.Customer_phone = txt_phone.Text;

            so.Currency_id = currencies.ElementAt(cbo_Currency.SelectedIndex).Id;
            so.Currency_name = currencies.ElementAt(cbo_Currency.SelectedIndex).Name;
            so.Currency_symbol = currencies.ElementAt(cbo_Currency.SelectedIndex).Symbol;

            so.Issue_date = dt_IssueDate.Value.Date + dt_IssueHour.Value.TimeOfDay;

            so.Observation = txt_observation.Text;
            so.Amount = double.Parse(txt_amount.Text);
        }

        private void fill_Sales_Order_Form(SalesOrder so)
        {
            Clean();
            txt_name.Text = so.Customer_name;
            txt_Doi.Text = so.Customer_doi;
            txt_address.Text = so.Customer_address;
            txt_phone.Text = so.Customer_phone;

            txt_idOrder.Text = so.Id.ToString();
            cbo_Currency.Text = so.Currency_symbol + "  -  " + so.Currency_name;
            dt_IssueDate.Text = so.Issue_date.ToShortDateString();
            dt_IssueHour.Text = so.Issue_date.ToLongTimeString();

            txt_observation.Text = so.Observation;
            txt_amount.Text = so.Amount.ToString("0.00");
            txt_Status.Text = so.Status;

            fill_gridView_OrderLine(so.Lines);

            int i = 0;
            foreach (SalesOrderLine sol in so.Lines)
            {
                grid_order_lines.Rows[i].Cells["amount"].Value = (sol.Quantity * sol.Unit_price).ToString();
                i++;
            }
        }

        private void fill_Sales_Order_Form_With_Estimation(SalesEstimate se)
        {
            Clean();
            txt_name.Text = se.Customer_name;
            txt_Doi.Text = se.Customer_doi;
            txt_address.Text = se.Customer_address;
            txt_phone.Text = se.Customer_phone;

            txt_idOrder.Text = se.Id.ToString();
            cbo_Currency.Text = se.Currency_symbol + "  -  " + se.Currency_name;
            dt_IssueDate.Text = se.Issue_date.ToShortDateString();
            dt_IssueHour.Text = se.Issue_date.ToLongTimeString();

            txt_observation.Text = se.Observation;
            txt_amount.Text = se.Amount.ToString("0.00");
            txt_Status.Text = se.Status;

            int i = 0;
            List<SalesOrderLine> sols = new List<SalesOrderLine>();

            foreach (SalesEstimateLine sel in se.Lines)
            {
                sols.Add(new SalesOrderLine(sel));
            }

            fill_gridView_OrderLine(sols);

            foreach (SalesEstimateLine sel in se.Lines)
            {
                grid_order_lines.Rows[i].Cells["amount"].Value = (sel.Quantity * sel.Unit_price).ToString();
                i++;
            }
        }

        private void Clean()
        {
            clean_Customer();
            
            txt_idOrder.Text = "";
            cbo_Currency.Text = "";

            txt_observation.Text = "";
            txt_amount.Text = "";
            txt_Status.Text = "";

            dt_IssueHour.Text = "";
            dt_IssueDate.Text = "";

            customer = new Customer();
            clean_gridView_OrderLine();
        }

        private void clean_Customer()
        {
            txt_name.Text = "";
            txt_Doi.Text = "";
            txt_address.Text = "";
            txt_phone.Text = "";
        }

        private void clean_gridView_OrderLine()
        {
            List<SalesOrderLine> empty_list = new List<SalesOrderLine>();
            grid_order_lines.DataSource = empty_list;
        }

        private void fill_gridView_OrderLine(List<SalesOrderLine> list)
        {

            List<SalesOrderLine> current = (List<SalesOrderLine>)this.grid_order_lines.DataSource;
            if (current == null)
                current = new List<SalesOrderLine>();
            current = current.Concat(list).ToList();
            this.grid_order_lines.DataSource = current;
            AdjustColumnOrderLine();
        }

        private void AdjustColumnOrderLine()
        {
            grid_order_lines.Columns["product"].DisplayIndex = 0;
            grid_order_lines.Columns["unit"].DisplayIndex = 1;
            grid_order_lines.Columns["warehouse"].DisplayIndex = 2;
            grid_order_lines.Columns["quantity"].DisplayIndex = 3;
            grid_order_lines.Columns["unit_price"].DisplayIndex = 4;
            grid_order_lines.Columns["amount"].DisplayIndex = 5;
        }

        private void manipulate_options(bool flag)
        {
            Color color = flag ? Color.White : Color.LightGray;

            txt_name.Enabled = flag;
            txt_name.BackColor = color;

            txt_Doi.Enabled = flag;
            txt_Doi.BackColor = color;

            txt_address.Enabled = flag;
            txt_address.BackColor = color;

            txt_phone.Enabled = flag;
            txt_phone.BackColor = color;

            cbo_Currency.Enabled = flag;
            cbo_Currency.BackColor = color;

            //dt_IssueDate.Enabled = flag;
            //dt_IssueHour.Enabled = flag;

            txt_observation.Enabled = flag;
            txt_observation.BackColor = color;

            btn_Add.Visible = flag;
            btn_Delete.Visible = flag;

            grid_order_lines.Columns["quantity"].ReadOnly = !flag;
            
        }


        #endregion

    }
}
