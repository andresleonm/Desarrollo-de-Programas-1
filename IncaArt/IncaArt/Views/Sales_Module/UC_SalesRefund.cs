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
    public partial class UC_SalesRefund : UserControl
    {
        private string user = "dp1admin";
        private string password = "dp1admin";
        private SalesDocument document;
        private List<SalesRefund> sales_refunds;
        private SalesRefundController sales_refund_controller;
        private SalesRefundLineController sales_refund_line_controller;
        private SalesDocumentController sdc;

        public UC_SalesRefund()
        {
            InitializeComponent();
            sales_refund_controller = new SalesRefundController(user,password);
            sales_refund_line_controller = new SalesRefundLineController(user, password);
            sdc = new SalesDocumentController(user, password);
            fill_Sales_Refunds();
        }

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

                List<SalesRefundLine> ref_lines = new List<SalesRefundLine>();
                foreach (SalesDocumentLine line in sd.Lines)
                    ref_lines.Add(new SalesRefundLine(line));

                grid_Refund_Lines.DataSource = ref_lines;
                AdjustColumnRefundLine();
            }            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btn_Search_Refunds_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ctxt_refund_id.Text))
            {
                fill_Sales_Refund_Grid();
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

        private void fill_Sales_Refund_Grid()
        {
            Result result = sales_refund_controller.getSalesRefunds();
            sales_refunds = (List<SalesRefund>)result.data;
            fill_gridView_Refund(sales_refunds);
        }

        private void fill_Sales_Refunds()
        {
            Result result = sales_refund_controller.getSalesRefunds();
            sales_refunds = (List<SalesRefund>)result.data;
            fill_gridView_Refund(sales_refunds);
        }

        private void fill_gridView_Refund(List<SalesRefund> list)
        {
            clean_gridView_Refund();
            List<SalesRefund> current = (List<SalesRefund>)this.grid_Refunds.DataSource;
            if (current == null)
                current = new List<SalesRefund>();
            current = current.Concat(list).ToList();
            this.grid_Refunds.DataSource = current;
            AdjustColumnRefund();
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (document == null || String.IsNullOrWhiteSpace(txt_Document_id.Text))
            {
                MessageBox.Show(this, "Debe seleccionar un documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Result result;
                SalesRefund sales_refund = new SalesRefund();
                fill_Sales_Refund_Object(sales_refund);

                sales_refund.Lines = (List<SalesRefundLine>)grid_Refund_Lines.DataSource;

                int sales_refund_id = Int32.Parse(sales_refund_controller.insertSalesRefund(sales_refund).data.ToString());
                sales_refund.Document_id = document.Id;

                if (sales_refund_id > 0)
                {
                    int i = 1;
                    foreach (SalesRefundLine srl in sales_refund.Lines)
                    {
                        srl.Id = i;
                        srl.Refund_id = sales_refund_id;
                        srl.Status = "Registrado";                        
                        result = sales_refund_line_controller.insertSalesRefundLine(srl);
                        if (!result.success)
                        {
                            MessageBox.Show(this, result.message + "  -  Error fila " + i.ToString(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        i++;
                    }
                    txt_Refund_id.Text = sales_refund_id.ToString();
                    txt_Status.Text = sales_refund.Status;
                    fill_Sales_Refunds();
                    btn_Clean.PerformClick();
                    tab_Refund.SelectedIndex = 0;
                    MessageBox.Show(this, "Devolución creada exitosamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("No se pudo crear la devolución", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
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

            sr.Issue_date = DateTime.Parse(dt_IssueDate.Text);
            sr.Observation = txt_observation.Text;
            sr.Amount = double.Parse(txt_amount.Text);
            sr.Status = "Registrado";
        }

        private void fill_Sales_Refund_Form(SalesDocument sd)
        {
            Clean();
            txt_name.Text = sd.Customer_name;
            txt_address.Text = sd.Customer_address;
            txt_Doi.Text = sd.Customer_doi;
            txt_phone.Text = sd.Customer_phone;

            txt_Document_id.Text = sd.Id.ToString();
            txt_Currency.Text = sd.Currency_symbol + "  -  " + sd.Currency_name;
            dt_IssueDate.Text = sd.Issue_date.ToString();

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
            grid_Refund_Lines.Columns["unit"].DisplayIndex = 1;
            grid_Refund_Lines.Columns["warehouse"].DisplayIndex = 2;
            grid_Refund_Lines.Columns["quantity_available"].DisplayIndex = 3;
            grid_Refund_Lines.Columns["quantity"].DisplayIndex = 4;
            grid_Refund_Lines.Columns["Refund_quantity"].DisplayIndex = 5;
            grid_Refund_Lines.Columns["unit_price"].DisplayIndex = 6;
            grid_Refund_Lines.Columns["amount"].DisplayIndex = 7;
        }

        private void grid_Refund_Lines_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 7 || e.ColumnIndex == 8)
                {
                    //double update_amount = double.Parse(grid_order_lines.Rows[e.RowIndex].Cells["quantity"].Value.ToString()) * double.Parse(grid_order_lines.Rows[e.RowIndex].Cells["unit_price"].Value.ToString());
                    //grid_order_lines.Rows[e.RowIndex].Cells["amount"].Value = update_amount;

                    //double acumulate = 0;
                    //for (int i = 0; i < grid_order_lines.RowCount; i++)
                    //{
                    //    acumulate += double.Parse(grid_order_lines.Rows[i].Cells["amount"].Value.ToString());
                    //}
                    //txt_amount.Text = acumulate.ToString();
                }
            }
        }

        
    }
}
