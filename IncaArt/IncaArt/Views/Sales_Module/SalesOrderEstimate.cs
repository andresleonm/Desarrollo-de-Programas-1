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
    public partial class SalesOrderEstimate : Form
    {
        private List<SalesEstimate> estimates;
        public List<SalesEstimate> estimateList;
        private SalesEstimateController estimate_controller;
        private int client_id;

        public SalesOrderEstimate(ref List<SalesEstimate> estimate, string user, string password, int cli_id)
        {
            InitializeComponent();
            estimateList = estimate;
            client_id = cli_id;
            estimate_controller = new SalesEstimateController(user, password);
            Result result = estimate_controller.getSalesEstimatesByClient(client_id);
            estimates = (List<SalesEstimate>)result.data;
            fill_GridView(estimates);
        }

        private void SalesOrderEstimate_Load(object sender, EventArgs e)
        {
            txt_name.Select();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                grid_estimates.DataSource = estimates;
                AdjustColumnEstimate();
            }
            else
            {
                string text = "%" + (txt_name.Text).ToLower() + "%";
                Result result = estimate_controller.getEstimate_by_text_by_client(text, client_id);
                List<SalesEstimate> estimates_found = new List<SalesEstimate>();
                estimates_found = (List<SalesEstimate>)result.data;
                fill_GridView(estimates_found);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int selectedRowCount = grid_estimates.Rows.GetRowCount(DataGridViewElementStates.Selected);

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
                SalesEstimate estimate_found = (SalesEstimate)grid_estimates.CurrentRow.DataBoundItem;
                estimateList.Add(estimate_found);
                this.Close();
            }
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_Search.PerformClick();
        }

        private void AdjustColumnEstimate()
        {
            grid_estimates.Columns["estimate_id"].DisplayIndex = 0;
            grid_estimates.Columns["customer_name"].DisplayIndex = 1;
            grid_estimates.Columns["issue_date"].DisplayIndex = 2;
            grid_estimates.Columns["currency_name"].DisplayIndex = 3;
            grid_estimates.Columns["amount"].DisplayIndex = 4;
            grid_estimates.Columns["observation"].DisplayIndex = 5;
            grid_estimates.Columns["status"].DisplayIndex = 6;
        }

        private void fill_GridView(List<SalesEstimate> list)
        {
            grid_estimates.DataSource = new List<SalesEstimate>();
            grid_estimates.DataSource = list;
            AdjustColumnEstimate();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
