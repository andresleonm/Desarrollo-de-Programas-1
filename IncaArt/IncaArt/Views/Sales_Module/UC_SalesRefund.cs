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

namespace WindowsFormsApp1.Views.Sales_Module
{
    public partial class UC_SalesRefund : UserControl
    {
        private string user = "dp1admin";
        private string password = "dp1admin";
        private double igv = 0.18;
        private bool see = false;
        private SalesRefund sr_see;
        private SalesDocument document;
        private List<SalesRefund> sales_refunds;
        private SalesRefundController sales_refund_controller;
        private SalesRefundLineController sales_refund_line_controller;
        private SalesDocumentController sdc;
        private SalesDocumentLineController sdlc;
        private SalesOrderController soc;

        public UC_SalesRefund()
        {
            InitializeComponent();

            sales_refund_controller = new SalesRefundController(user,password);
            sales_refund_line_controller = new SalesRefundLineController(user, password);
            sdc = new SalesDocumentController(user, password);
            sdlc = new SalesDocumentLineController(user, password);
            soc = new SalesOrderController(user, password);

            fill_Sales_Refunds();
        }

        private void tab_Refund_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_Refund.SelectedIndex == 0) // Refunds
            {
                btn_Clean.PerformClick();
                btn_Clean.PerformClick();
                ctxt_refund_id.Text = "";
                ctxt_customer.Text = "";
                fill_Sales_Refunds();
            }
            else if (tab_Refund.SelectedIndex == 1) // New Refund
            {
                if (!see)
                {
                    btn_Clean.PerformClick();
                    btn_Clean.PerformClick();
                }
            }
        }

        #region CONSULTANT REFUND
        // -----------------------------------------------------
        //                   CONSULTANT REFUND
        // -----------------------------------------------------

        private void btn_Search_Client_Click(object sender, EventArgs e)
        {
            var customerL = new List<Customer>();
            Sales_Module.SalesOrderSearchClient search_view = new Sales_Module.SalesOrderSearchClient(ref customerL, user, password, 'A');
            search_view.ShowDialog();

            if (customerL.Count != 0)
            {
                Customer customer = customerL[0];
                ctxt_customer.Text = customer.Name;
            }
        }

        private void btn_Search_Refunds_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ctxt_refund_id.Text))
            {
                fill_Sales_Refunds();
            }
            else
            {
                sales_refunds = new List<SalesRefund>();
                Result result = sales_refund_controller.getSalesRefund(Int32.Parse(ctxt_refund_id.Text));
                SalesRefund sr = (SalesRefund)result.data;
                sales_refunds.Add(sr);
                fill_gridView_Refund(sales_refunds);
            }
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            int selectedRowCount = grid_Refunds.Rows.GetRowCount(DataGridViewElementStates.Selected);

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
                active_See();
            }
        }

        private void grid_Refunds_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            active_See();
        }

        private void active_See()
        {
            see = true;
            int index = grid_Refunds.SelectedRows[0].Index;
            var id = sales_refunds[index].Id;
            sr_see = (Models.SalesRefund)sales_refund_controller.getSalesRefund(id).data;
            grid_Refund_Lines.DataSource = sr_see.Lines;

            refresh_amount(sr_see);

            tab_Refund.SelectedIndex = 1;
            manipulate_options(false);
            fill_Sales_Refund_Form(sr_see);
        }

        private void fill_Sales_Refunds()
        {
            Result result = sales_refund_controller.getSalesRefunds();
            sales_refunds = (List<SalesRefund>)result.data;
            fill_gridView_Refund(sales_refunds);
        }

        private void fill_gridView_Refund(List<SalesRefund> list)
        {
            try{
                clean_gridView_Refund();
                List<SalesRefund> current = (List<SalesRefund>)this.grid_Refunds.DataSource;
                if (current == null)
                    current = new List<SalesRefund>();
                current = current.Concat(list).ToList();
                this.grid_Refunds.DataSource = current;
                AdjustColumnRefund();
            }
            catch{
                this.grid_Refunds.DataSource = new List<SalesRefund>();
                AdjustColumnRefund();
            }            
        }

        private void clean_gridView_Refund()
        {
            List<SalesRefund> empty_list = new List<SalesRefund>();
            grid_Refunds.DataSource = empty_list;
        }

        private void AdjustColumnRefund()
        {
            grid_Refunds.Columns["refund_id"].DisplayIndex = 0;
            grid_Refunds.Columns["customer_name"].DisplayIndex = 1;
            grid_Refunds.Columns["issue_date"].DisplayIndex = 2;
            grid_Refunds.Columns["currency_name"].DisplayIndex = 3;
            grid_Refunds.Columns["amount2"].DisplayIndex = 4;
            grid_Refunds.Columns["observation"].DisplayIndex = 5;
            grid_Refunds.Columns["status"].DisplayIndex = 6;
        }

        private void refresh_amount(SalesRefund sr)
        {
            for (int i = 0; i < grid_Refund_Lines.RowCount; i++)
                grid_Refund_Lines.Rows[i].Cells["amount"].Value = (sr.Lines[i].Quantity * sr.Lines[i].Unit_price).ToString("0.00");
        }

        #endregion


        #region REGISTER REFUND
        // -----------------------------------------------------
        //                   REGISTER REFUND
        // -----------------------------------------------------

        List<SalesRefundLine> ref_lines;

        private void btn_Search_Document_Click(object sender, EventArgs e)
        {
            var documentL = new List<SalesDocument>();
            Sales_Module.SalesRefundSearchDocument search_view = new Sales_Module.SalesRefundSearchDocument(ref documentL, user, password);
            search_view.ShowDialog();

            if (documentL.Count != 0)
            {
                document = documentL[0];
                fill_Sales_Refund_Form(document);
                SalesDocument sd = (SalesDocument)sdc.getSalesDocument(document.Id).data;

                ref_lines = new List<SalesRefundLine>();
                foreach (SalesDocumentLine line in sd.Lines) {
                    var lineR = new SalesRefundLine(line);
                    ref_lines.Add(lineR);
                }
                                
                int i = 0;
                grid_Refund_Lines.DataSource = ref_lines;
                AdjustColumnRefundLine();

                foreach (SalesRefundLine line in ref_lines)
                {
                    List<ProductWarehouseS> warehouses = (List<ProductWarehouseS>)soc.getWarehousesS(line.Product_id, '1').data;
                    
                    foreach (ProductWarehouseS w in warehouses)
                        ((DataGridViewComboBoxCell)grid_Refund_Lines.Rows[i].Cells["warehouses"]).Items.Add(w.Name);
                    i++;
                }

                update_Amount_Refund();
            }
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            dt_IssueHour.Text = "";
            dt_IssueDate.Text = "";

            if (document == null || String.IsNullOrWhiteSpace(txt_Document_id.Text))
            {
                MessageBox.Show(this, "Debe seleccionar un documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (document.Id.ToString() == "")                   
                {
                    MessageBox.Show(this, "Debe seleccionar un documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List<Models.SalesRefundLine> detail = (List<Models.SalesRefundLine>)this.grid_Refund_Lines.DataSource;
                if (detail == null || detail.Count == 0 || allIsZero(detail))
                {
                    MessageBox.Show("Seleccione por lo menos una línea de la devolución con cantidad diferente de 0");
                    return;
                }

                if (!allGreatherThanZero(detail))
                {
                    MessageBox.Show("Las cantidades deben ser mayores a 0");
                    return;
                }

                Models.SalesRefund sales_refund = new Models.SalesRefund();
                sales_refund.Lines = detail;
                fill_Sales_Refund_Object(sales_refund);

                sales_refund.Lines = (List<SalesRefundLine>)grid_Refund_Lines.DataSource;

                int i = 0;
                foreach (SalesRefundLine line in sales_refund.Lines)
                {
                    line.Prod_warehouse_destiny = (string)grid_Refund_Lines.Rows[i].Cells["warehouses"].Value;
                    i++;
                }

                Result result = sales_refund_controller.insertSalesRefund(sales_refund);

                if (result.success)
                {
                    MessageBox.Show(this, "Se ha creado la devolución N° : " + result.data.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    btn_Clean.PerformClick();
                    tab_Refund.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show(result.message);
                }
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
            see = false;
            sr_see = new SalesRefund();
            manipulate_options(true);
            Clean();
        }

        private void grid_Refund_Lines_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 13)
                {
                    double update_amount = double.Parse(grid_Refund_Lines.Rows[e.RowIndex].Cells["quantity"].Value.ToString()) * double.Parse(grid_Refund_Lines.Rows[e.RowIndex].Cells["unit_price"].Value.ToString());
                    grid_Refund_Lines.Rows[e.RowIndex].Cells["amount"].Value = update_amount;

                    update_Amount_Refund();
                }
            }
        }

        private void update_Amount_Refund()
        {
            double acumulate = 0;
            for (int i = 0; i < grid_Refund_Lines.RowCount; i++)
                acumulate += double.Parse(grid_Refund_Lines.Rows[i].Cells["amount"].Value.ToString());

            txt_amount.Text = acumulate.ToString("0.00");
            txt_igv.Text = Math.Round((acumulate * igv), 2).ToString("0.00");
            txt_total.Text = Math.Round((acumulate * (1 + igv)), 2).ToString("0.00");
        }

        private bool allIsZero(List<Models.SalesRefundLine> lines)
        {
            foreach (Models.SalesRefundLine line in lines)
            {
                if (line.Quantity != 0)
                    return false;
            }
            return true;
        }

        private bool allGreatherThanZero(List<Models.SalesRefundLine> lines)
        {
            foreach (Models.SalesRefundLine line in lines)
            {
                if (line.Quantity < 0)
                    return false;
            }
            return true;
        }

        private void fill_Sales_Refund_Object(SalesRefund sr)
        {
            sr.Currency_id = document.Currency_id;
            sr.Currency_name = document.Currency_name;
            sr.Currency_symbol = document.Currency_symbol;

            sr.Customer_id = document.Customer_id;
            sr.Customer_name = txt_name.Text;
            sr.Customer_address = txt_address.Text;
            sr.Customer_doi = txt_Doi.Text;
            sr.Customer_phone = txt_phone.Text;

            sr.Issue_date = dt_IssueDate.Value.Date + dt_IssueHour.Value.TimeOfDay;
            sr.Observation = txt_observation.Text;
            sr.Amount = double.Parse(txt_amount.Text);
            sr.Document_id = Int32.Parse(txt_Document_id.Text);
            sr.Porc_igv = igv;
        }

        private void fill_Sales_Refund_Form(SalesRefund sr)
        {
            Clean();
            txt_name.Text = sr.Customer_name;
            txt_address.Text = sr.Customer_address;
            txt_Doi.Text = sr.Customer_doi;
            txt_phone.Text = sr.Customer_phone;

            txt_Document_id.Text = sr.Document_id.ToString();
            txt_Refund_id.Text = sr.Id.ToString();
            txt_Currency.Text = sr.Currency_symbol + "  -  " + sr.Currency_name;
            dt_IssueDate.Text = sr.Issue_date.ToShortDateString();
            dt_IssueHour.Text = sr.Issue_date.ToLongTimeString();

            txt_observation.Text = sr.Observation;
            txt_amount.Text = sr.Amount.ToString();
            txt_igv.Text = (sr.Amount * sr.Porc_igv).ToString();
            txt_total.Text = (sr.Amount * (1 + sr.Porc_igv)).ToString();
            txt_Status.Text = sr.Status;
        }

        private void fill_Sales_Refund_Form(SalesDocument sd)
        {
            Clean();
            txt_name.Text = sd.Customer_name;
            txt_address.Text = sd.Customer_address;
            txt_Doi.Text = sd.Customer_doi;
            txt_phone.Text = sd.Customer_phone;

            txt_Document_id.Text = sd.Id.ToString();
            //txt_Refund_id.Text = sd.Id.ToString();
            txt_Currency.Text = sd.Currency_symbol + "  -  " + sd.Currency_name;
            dt_IssueDate.Text = sd.Issue_date.ToShortDateString();
            dt_IssueHour.Text = sd.Issue_date.ToLongTimeString();

            txt_observation.Text = sd.Observation;
            txt_amount.Text = sd.Amount.ToString();
            txt_igv.Text = (sd.Amount * sd.Porc_igv).ToString();
            txt_total.Text = (sd.Amount * (1 + sd.Porc_igv)).ToString();
            txt_Status.Text = sd.Status;
        }

        private void Clean()
        {
            txt_name.Text = "";
            txt_address.Text = "";
            txt_Doi.Text = "";
            txt_phone.Text = "";

            txt_Document_id.Text = "";
            txt_Refund_id.Text = "";
            txt_Currency.Text = "";

            txt_observation.Text = "";
            txt_amount.Text = "";
            txt_igv.Text = "";
            txt_total.Text = "";
            txt_Status.Text = "";

            dt_IssueHour.Text = "";
            dt_IssueDate.Text = "";

            clean_gridView_RefundLine();
        }

        private void clean_gridView_RefundLine()
        {
            List<SalesRefundLine> empty_list = new List<SalesRefundLine>();
            grid_Refund_Lines.DataSource = empty_list;
        }

        private void AdjustColumnRefundLine()
        {
            grid_Refund_Lines.Columns["product"].DisplayIndex = 0;
            grid_Refund_Lines.Columns["unit_measure"].DisplayIndex = 1;
            grid_Refund_Lines.Columns["prodwarehouse"].DisplayIndex = 2;
            grid_Refund_Lines.Columns["warehouses"].DisplayIndex = 3;
            grid_Refund_Lines.Columns["quantity_available"].DisplayIndex = 4;
            grid_Refund_Lines.Columns["refund_quantity"].DisplayIndex = 5;
            grid_Refund_Lines.Columns["quantity"].DisplayIndex = 6;
            grid_Refund_Lines.Columns["unit_price"].DisplayIndex = 7;
            grid_Refund_Lines.Columns["amount"].DisplayIndex = 8;
        }

        private void manipulate_options(bool flag)
        {
            Color color = flag ? Color.White : Color.LightGray;

            txt_observation.Enabled = flag;
            txt_observation.BackColor = color;

            btn_Search_Document.Visible = flag;
            btn_Save.Visible = flag;
            grid_Refund_Lines.Columns["Quantity"].ReadOnly = !flag;

        }


        #endregion

        private void grid_Refund_Lines_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}



