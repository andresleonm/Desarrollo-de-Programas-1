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

namespace WindowsFormsApp1.Views.Sales_Module
{
    public partial class UC_SalesEstimate : UserControl
    {
        private string user = "dp1admin";
        private string password = "dp1admin";
        private bool edit = false;
        private SalesEstimate se_edit;
        private List<SalesEstimate> sales_estimates;
        private Customer customer;
        private List<Currency> currencies;
        private CurrencyController currency_controller;
        private SalesEstimateController sales_estimate_controller;
        private SalesEstimateLineController sales_estimate_line_controller;


        public UC_SalesEstimate()
        {
            InitializeComponent();

            currency_controller = new CurrencyController(user, password);
            sales_estimate_controller = new SalesEstimateController(user, password);
            sales_estimate_line_controller = new SalesEstimateLineController(user, password);

            fill_Sales_Estimate();

            Result result = currency_controller.getCurrencies();
            currencies = (List<Currency>)result.data;

            foreach (Currency curr in currencies)
                this.cbo_Currency.Items.Add(curr.Symbol + "  -  " + curr.Name);

        }

        private void tab_Estimate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_Estimate.SelectedIndex == 0) // Estimates
            {
                ctxt_estimate_id.Text = "";
                ctxt_customer.Text = "";
                customer = new Customer();
                fill_Sales_Estimate();
            }
            else if (tab_Estimate.SelectedIndex == 1) // New_Estimate
            {
                if (!edit)
                {
                    customer = new Customer();
                    btn_Clean.PerformClick();
                }
            }
        }

        #region CONSULTANT ESTIMATE
        // -----------------------------------------------------
        //                   CONSULTANT ESTIMATE
        // -----------------------------------------------------

        private void btn_SearchClient_Click(object sender, EventArgs e)
        {
            var customerL = new List<Customer>();
            Sales_Module.SalesOrderSearchClient search_view = new Sales_Module.SalesOrderSearchClient(ref customerL, user, password, 'E');
            search_view.ShowDialog();

            if (customerL.Count != 0)
            {
                customer = customerL[0];
                ctxt_customer.Text = customer.Name;
            }
        }

        private void btn_Search_Estimates_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ctxt_estimate_id.Text))
            {
                fill_Sales_Estimate();
            }
            else
            {
                sales_estimates = new List<SalesEstimate>();
                Result result = sales_estimate_controller.getSalesEstimate(Int32.Parse(ctxt_estimate_id.Text));
                SalesEstimate se = (SalesEstimate)result.data;
                sales_estimates.Add(se);
                fill_gridView_Estimate(sales_estimates);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int selectedRowCount = grid_estimates.Rows.GetRowCount(DataGridViewElementStates.Selected);

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
                int index = grid_estimates.SelectedRows[0].Index;
                var id = sales_estimates[index].Id;
                se_edit = (Models.SalesEstimate)sales_estimate_controller.getSalesEstimate(id).data;
                grid_estimate_lines.DataSource = se_edit.Lines;
                tab_Estimate.SelectedIndex = 1;
                //fill_Sales_Estimate_Form(se_edit);
            }
        }

        private void fill_Sales_Estimate()
        {
            Result result = sales_estimate_controller.getSalesEstimates();
            sales_estimates = (List<SalesEstimate>)result.data;
            fill_gridView_Estimate(sales_estimates);
        }

        private void fill_gridView_Estimate(List<SalesEstimate> list)
        {
            clean_gridView_Estimate();
            List<SalesEstimate> current = (List<SalesEstimate>)this.grid_estimates.DataSource;
            if (current == null)
                current = new List<SalesEstimate>();
            current = current.Concat(list).ToList();
            this.grid_estimates.DataSource = current;
            AdjustColumnEstimate();
        }

        private void clean_gridView_Estimate()
        {
            List<SalesEstimate> empty_list = new List<SalesEstimate>();
            grid_estimates.DataSource = empty_list;
        }

        private void AdjustColumnEstimate()
        {
            grid_estimates.Columns["estimate_id2"].DisplayIndex = 0;
            grid_estimates.Columns["customer_name"].DisplayIndex = 1;
            grid_estimates.Columns["issue_date"].DisplayIndex = 2;
            grid_estimates.Columns["currency_name"].DisplayIndex = 3;
            grid_estimates.Columns["amount2"].DisplayIndex = 4;
            grid_estimates.Columns["observation"].DisplayIndex = 5;
            grid_estimates.Columns["status"].DisplayIndex = 6;
        }

        #endregion


    }
}
