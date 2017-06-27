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

using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using System.Diagnostics;



namespace WindowsFormsApp1.Views.Purchase_Module
{
    public partial class UC_PurchaseOrder : MetroFramework.Controls.MetroUserControl
    {
        private string user = "dp1admin";
        private string password = "dp1admin";
        private bool edit = false;
        private PurchaseOrder so_edit;
        private List<PurchaseOrder> sales_orders;
        private Models.Supplier customer;
        private List<Currency> currencies;
        private CurrencyController currency_controller;
        private PurchaseOrderController sales_order_controller;
        private PurchaseOrderLineController sales_order_line_controller;


        public UC_PurchaseOrder()
        {
            InitializeComponent();

            currency_controller = new CurrencyController(user, password);
            sales_order_controller = new PurchaseOrderController(user, password);
            sales_order_line_controller = new PurchaseOrderLineController(user, password);

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
                customer = new Models.Supplier();
                fill_Sales_Order();
            }
            else if (tab_Order.SelectedIndex == 1) // New Order
            {
                if (!edit)
                {
                    customer = new Models.Supplier();
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
            var customerL = new List<Models.Supplier>();
            Purchase_Module.PurchaseOrderSearchSupplier search_view = new Purchase_Module.PurchaseOrderSearchSupplier(ref customerL, user, password);
            search_view.ShowDialog();

            if (customerL.Count != 0)
            {
                customer = customerL[0];
                ctxt_customer.Text = customer.Name;
            }
        }

        private void btn_Search_Orders_Click(object sender, EventArgs e)
        {
            PurchaseOrder sales_order = new PurchaseOrder();
            DateTime init = dt_iniDate.Value.Date;
            DateTime end = dt_endDate.Value.Date;
            Boolean equals = false;
            if (init == end) equals = true;
            if (ctxt_order_id.Text != "")
                sales_order.Id = Int32.Parse((ctxt_order_id.Text));
            else
                sales_order.Id = -1;

            sales_order.Supplier_name = ctxt_customer.Text;

            Result result = sales_order_controller.getPurchaseOrder_by_filter(sales_order, init, end,equals);

            if (result.data == null)
                MessageBox.Show(result.message, "Error al buscar ordenes de compra con filtros", MessageBoxButtons.OK);
            else
            {
                sales_orders = new List<PurchaseOrder>();
                sales_orders = (List<PurchaseOrder>)result.data;
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
            so_edit = (Models.PurchaseOrder)sales_order_controller.getPurchaseOrder(id).data;
            grid_order_lines.DataSource = so_edit.Lines;
            tab_Order.SelectedIndex = 1;
            fill_Sales_Order_Form(so_edit);
        }

        private void fill_Sales_Order()
        {
            Result result = sales_order_controller.getPurchaseOrders();
            sales_orders = (List<PurchaseOrder>)result.data;
            fill_gridView_Order(sales_orders);
        }

        private void fill_gridView_Order(List<PurchaseOrder> list)
        {
            clean_gridView_Order();
            List<PurchaseOrder> current = (List<PurchaseOrder>)this.grid_orders.DataSource;
            if (current == null)
                current = new List<PurchaseOrder>();
            current = current.Concat(list).ToList();
            this.grid_orders.DataSource = current;
            AdjustColumnOrder();
        }

        private void clean_gridView_Order()
        {
            List<PurchaseOrder> empty_list = new List<PurchaseOrder>();
            grid_orders.DataSource = empty_list;
        }

        private void AdjustColumnOrder()
        {
            grid_orders.Columns["purchase_id2"].DisplayIndex = 0;
            grid_orders.Columns["supplier_name"].DisplayIndex = 1;
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
            var customerL = new List<Models.Supplier>();
            Purchase_Module.PurchaseOrderSearchSupplier search_view = new Purchase_Module.PurchaseOrderSearchSupplier(ref customerL, user, password);
            search_view.ShowDialog();

            if (customerL.Count != 0)
            {
                customer = customerL[0];
                
                    btn_Clean.PerformClick();
                    btn_Clean.PerformClick();
                    customer = customerL[0];
                    txt_name.Text = customer.Name;
                    txt_address.Text = customer.Address;
                    txt_Doi.Text = customer.Doi;
                    txt_phone.Text = customer.Phone;
                
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var lines = new List<Models.PurchaseOrderLine>();
            Purchase_Module.PurchaseOrderLine order_line = new Purchase_Module.PurchaseOrderLine(ref lines, user, password);
            order_line.ShowDialog();

            fill_gridView_OrderLine(lines);

            double acumulate = 0;
            for (int i = 0; i < grid_order_lines.RowCount; i++)
                acumulate += double.Parse(grid_order_lines.Rows[i].Cells["amount"].Value.ToString());
            txt_amount.Text = acumulate.ToString("0.00");
            var igvp = Double.Parse(igv_label.Text);
            igv_amount.Text = (acumulate * (igvp / 100)).ToString("0.00");
            subtotal.Text = acumulate.ToString("0.00");
            txt_amount.Text = (acumulate * (1+(igvp / 100))).ToString("0.00");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            dt_IssueHour.Text = "";
            dt_IssueDate.Text = "";

            if (customer == null)
                customer = new Models.Supplier(txt_name.Text, txt_address.Text, txt_phone.Text, txt_Doi.Text);
            if (edit)
            {
                fill_Sales_Order_Object(so_edit);

                if (customer != null)
                    so_edit.Supplier_id = customer.Id;

                var lines = (List<Models.PurchaseOrderLine>)grid_order_lines.DataSource;
                if (lines.Count > 0)
                    so_edit.Lines = lines;
                so_edit.Igv_amount = Double.Parse(igv_amount.Text);
                so_edit.Igv_percentage = Double.Parse(igv_label.Text);
                Result result = sales_order_controller.updatePurchaseOrder(so_edit);

                if (result.success)
                {
                    int id = so_edit.getMaxId();
                    int i = 1;
                    foreach (Models.PurchaseOrderLine sol in so_edit.Lines)
                    {
                        if (sol.Id == 0)
                        {
                            sol.Id = id + 1;
                            sol.Order_id = so_edit.Id;
                            result = sales_order_line_controller.insertPurchaseOrderLine(sol);
                            id++;
                        }
                        else
                            result = sales_order_line_controller.updatePurchaseOrderLine(sol);

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
                    so_edit = new PurchaseOrder();
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

                List<Models.PurchaseOrderLine> detail = (List<Models.PurchaseOrderLine>)this.grid_order_lines.DataSource;
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

                Models.PurchaseOrder sales_order = new Models.PurchaseOrder();
                sales_order.Lines = detail;
                fill_Sales_Order_Object(sales_order);
                sales_order.Supplier_id = customer.Id;
                sales_order.Igv_amount = Double.Parse(igv_amount.Text);
                sales_order.Igv_percentage = Double.Parse(igv_label.Text);
                Result result = sales_order_controller.insertPurchaseOrder(sales_order);

                if (result.success)
                {                    
                    MessageBox.Show(this, "Se ha creado la orden de compra N° : " + result.data.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
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
                List<Models.PurchaseOrderLine> data = (List<Models.PurchaseOrderLine>)grid_order_lines.DataSource;
                try
                {
                    Models.PurchaseOrderLine currentObject = (Models.PurchaseOrderLine)grid_order_lines.CurrentRow.DataBoundItem;
                    if (currentObject == null)
                        MessageBox.Show("Seleccione la línea que desea eliminar");
                    data.Remove(currentObject);
                    data = data.Concat(new List<Models.PurchaseOrderLine>().ToList()).ToList();
                    grid_order_lines.DataSource = data;
                    AdjustColumnOrderLine();
                    refresh_amount();
                }
                catch
                {
                    grid_order_lines.DataSource = new List<Models.PurchaseOrderLine>();
                    return;
                }
            }
            catch 
            {
                grid_order_lines.DataSource = new List<Models.PurchaseOrderLine>();
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
            so_edit = new PurchaseOrder();
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
            var igvp = Double.Parse(igv_label.Text);
            igv_amount.Text = (acumulate * (igvp/100)).ToString("0.00");
            subtotal.Text = acumulate.ToString("0.00");
            txt_amount.Text = (acumulate * (1+(igvp / 100))).ToString("0.00");
        }

        private bool allIsZero(List<Models.PurchaseOrderLine> lines)
        {
            foreach (Models.PurchaseOrderLine line in lines)
            {
                if (line.Quantity != 0)
                    return false;
            }
            return true;
        }

        private bool allGreatherThanZero(List<Models.PurchaseOrderLine> lines)
        {
            foreach (Models.PurchaseOrderLine line in lines)
            {
                if (line.Quantity < 0)
                    return false;
            }
            return true;
        }

        private void fill_Sales_Order_Object(PurchaseOrder so)
        {
            so.Supplier_name = txt_name.Text;
            so.Supplier_doi = txt_Doi.Text;
            so.Supplier_address = txt_address.Text;
            so.Supplier_phone = txt_phone.Text;

            so.Currency_id = currencies.ElementAt(cbo_Currency.SelectedIndex).Id;
            so.Currency_name = currencies.ElementAt(cbo_Currency.SelectedIndex).Name;
            so.Currency_symbol = currencies.ElementAt(cbo_Currency.SelectedIndex).Symbol;

            so.Issue_date = dt_IssueDate.Value.Date + dt_IssueHour.Value.TimeOfDay;

            so.Observation = txt_observation.Text;
            so.Amount = double.Parse(txt_amount.Text);
        }

        private void fill_Sales_Order_Form(PurchaseOrder so)
        {
            Clean();
            txt_name.Text = so.Supplier_name;
            txt_Doi.Text = so.Supplier_doi;
            txt_address.Text = so.Supplier_address;
            txt_phone.Text = so.Supplier_phone;

            txt_idOrder.Text = so.Id.ToString();
            cbo_Currency.Text = so.Currency_symbol + "  -  " + so.Currency_name;
            dt_IssueDate.Text = so.Issue_date.ToShortDateString();
            dt_IssueHour.Text = so.Issue_date.ToLongTimeString();

            txt_observation.Text = so.Observation;
            subtotal.Text = (so.Amount - so.Igv_amount).ToString("0.00");
            igv_amount.Text = so.Igv_amount.ToString("0.00");
            igv_label.Text = so.Igv_percentage.ToString("0.00");
            txt_amount.Text = so.Amount.ToString("0.00");
            txt_Status.Text = so.Status;

            fill_gridView_OrderLine(so.Lines);

            int i = 0;
            foreach (Models.PurchaseOrderLine sol in so.Lines)
            {
                grid_order_lines.Rows[i].Cells["amount"].Value = (sol.Quantity * sol.Unit_price).ToString();
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

            customer = new Models.Supplier();
            clean_gridView_OrderLine();
        }

        private void clean_Customer()
        {
            txt_name.Text = "";
            txt_Doi.Text = "";
            txt_address.Text = "";
            txt_phone.Text = "";
        }

        private void btn_Pdf_Click(object sender, EventArgs e)
        {
            if (edit)
                To_pdf(so_edit);
            else
                MessageBox.Show(this, "Debe haber seleccionado un documento, primero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void To_pdf(Models.PurchaseOrder sd)
        {
            Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:";
            saveFileDialog1.Title = "Guardar Reporte";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            string filename = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
            }

            if (filename.Trim() != "")
            {
                FileStream file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();
                string date = DateTime.Now.ToString();

                Chunk chunk = new Chunk("Orden de Compra " + "N° " + sd.Id.ToString(), FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
                doc.Add(new Paragraph(chunk));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("Proveedor              " + sd.Supplier_name.ToUpper(), FontFactory.GetFont("ARIAL", 16, iTextSharp.text.Font.BOLD)));
                doc.Add(new Paragraph("                                        Dirección: " + sd.Supplier_address));
                doc.Add(new Paragraph("                                        Teléfono: " + sd.Supplier_phone));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("     Fecha: " + date));
                doc.Add(new Paragraph("     Fecha de Emisión: " + sd.Issue_date));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("_________________________________________________________________________________________________________________________"));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                GenerateDocument(doc, grid_order_lines);
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.AddCreationDate();
                doc.Add(new Paragraph("_________________________________________________________________________________________________________________________"));
                doc.Add(new Paragraph("                                                                                                                                                                                            SubTotal   " + (sd.Igv_amount / 0.18 - sd.Igv_amount), FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
                doc.Add(new Paragraph("                                                                                                                                                                                                 IGV   " + (sd.Igv_amount * sd.Amount).ToString("0.00"), FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
                doc.Add(new Paragraph("                                                                                                                                                                                                          __________________"));
                doc.Add(new Paragraph("                                                                                                                                                                                               Total   " + ((1 + sd.Amount) * sd.Amount).ToString("0.00"), FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
                doc.Add(new Paragraph("_________________________________________________________________________________________________________________________"));
                doc.Close();
                Process.Start(filename);//Esta parte se puede omitir, si solo se desea guardar el archivo, y que este no se ejecute al instante
            }

        }

        public void GenerateDocument(Document document, DataGridView dgv)
        {
            int i, j;
            int visibleColums = getColumsVisible(dgv);
            PdfPTable datatable = new PdfPTable(visibleColums);
            datatable.DefaultCell.Padding = 3;

            float[] headerwidths = GetSizeColumn(dgv, visibleColums);

            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 0;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            for (i = 0; i < dgv.ColumnCount; i++)
            {
                if (dgv.Columns[i].Visible == true && !dgv.Columns[i].HeaderText.Equals("Almacen"))
                    datatable.AddCell(new Phrase(dgv.Columns[i].HeaderText, FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
            }

            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 0;
            for (i = 0; i < dgv.Rows.Count; i++)
            {
                for (j = 0; j < dgv.Columns.Count; j++)
                {
                    if (dgv[j, i].Value != null && (dgv.Columns[j].Visible == true) && !dgv.Columns[j].HeaderText.Equals("Almacen"))
                    {
                        datatable.AddCell(new Phrase(dgv[j, i].Value.ToString()));//En esta parte, se esta agregando un renglon por cada registro en el datagrid
                    }
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }
        private void clean_gridView_OrderLine()
        {
            List<Models.PurchaseOrderLine> empty_list = new List<Models.PurchaseOrderLine>();
            grid_order_lines.DataSource = empty_list;
        }

        private int getColumsVisible(DataGridView dgv)
        {
            int quantity = 0;
            for (int i = 0; i < dgv.ColumnCount; i++)
                if (dgv.Columns[i].Visible == true && !dgv.Columns[i].HeaderText.Equals("Almacen")) quantity++;

            return quantity;
        }

        private float[] GetSizeColumn(DataGridView dgv, int colums)
        {
            float[] values = new float[colums];
            int j = 0;
            for (int i = 0; i < dgv.ColumnCount; i++)
                if (dgv.Columns[i].Visible == true && !dgv.Columns[i].HeaderText.Equals("Almacen"))
                {
                    values[j] = (float)dgv.Columns[i].Width;
                    j++;
                }
            return values;
        }
        private void fill_gridView_OrderLine(List<Models.PurchaseOrderLine> list)
        {

            List<Models.PurchaseOrderLine> current = (List<Models.PurchaseOrderLine>)this.grid_order_lines.DataSource;
            if (current == null)
                current = new List<Models.PurchaseOrderLine>();
            current = current.Concat(list).ToList();
            this.grid_order_lines.DataSource = current;
            AdjustColumnOrderLine();
        }

        private void AdjustColumnOrderLine()
        {
            grid_order_lines.Columns["material"].DisplayIndex = 0;
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

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
