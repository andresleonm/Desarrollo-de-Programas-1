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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Diagnostics;
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1.Views.Sales_Module
{
    public partial class UC_SalesDocument : UserControl
    {
        private string user = "dp1admin";
        private string password = "dp1admin";
        private double igv = 0.18;
        private string company_name= "Inca Art";
        private string company_phone = "(01)565-1541 / (01)566-1023";
        private string company_mail = "inca_art@gmail.com";
        private string company_address = "Jr. Cajamarca 658 - Lima";
        private bool see = false;
        private SalesOrder so;
        private SalesRefund rf;
        private SalesDocument sd_see;
        private ProductMovement prodMovement;
        private ProductMovementController pmc;
        private List<SalesDocument> sales_documents;
        private SalesDocumentController sales_document_controller;
        private SalesDocumentLineController sales_document_line_controller;
        private ParametersController rucParam;
        public UC_SalesDocument()
        {
            InitializeComponent();

            sales_document_controller = new SalesDocumentController(user, password);
            sales_document_line_controller = new SalesDocumentLineController(user, password);
            pmc = new ProductMovementController(user, password);
            rucParam = new ParametersController(user, password);
            ccbo_document_type.SelectedIndex = 0;
            fill_Sales_Documents();
        }

        private void tab_Document_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_Document.SelectedIndex == 0) // Documents
            {
                btn_Clean.PerformClick();
                btn_Clean.PerformClick();
                ctxt_document_id.Text = "";
                ctxt_customer.Text = "";
                fill_Sales_Documents();
            }
            else if (tab_Document.SelectedIndex == 1) // New Document
            {
                if (!see)
                {
                    btn_Clean.PerformClick();
                    btn_Clean.PerformClick();                    
                }
            }
        }

        #region CONSULTANT DOCUMENT
        // -----------------------------------------------------
        //                   CONSULTANT DOCUMENT
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

        private void btn_Search_Documents_Click(object sender, EventArgs e)
        {
                SalesDocument sales_doc = new SalesDocument();
                DateTime init = dt_iniDate.Value.Date;
                DateTime end = dt_endDate.Value.Date;
                sales_doc.Type_document_id = ccbo_document_type.Text[0];
                Boolean equals = false;
                if (init == end) equals = true;
                if (ctxt_document_id.Text != "")
                    sales_doc.Id = Int32.Parse((ctxt_document_id.Text));
                else
                    sales_doc.Id = -1;

                sales_doc.Customer_name = ctxt_customer.Text;

                Result result = sales_document_controller.getSalesDocuments_by_filter(sales_doc, init, end,equals);

                if (result.data == null)
                    MessageBox.Show(result.message, "Error al buscar documentos con filtros", MessageBoxButtons.OK);
                else
                {
                    sales_documents = new List<SalesDocument>();
                    sales_documents = (List<SalesDocument>)result.data;
                    fill_gridView_Document(sales_documents);
               }
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            int selectedRowCount = grid_Documents.Rows.GetRowCount(DataGridViewElementStates.Selected);

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

        private void grid_Documents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            active_See();
        }

        private void active_See()
        {
            see = true;
            int index = grid_Documents.SelectedRows[0].Index;
            var id = sales_documents[index].Id;
            sd_see = (Models.SalesDocument)sales_document_controller.getSalesDocument(id).data;
            grid_Document_Lines.DataSource = sd_see.Lines;

            refresh_amount(sd_see);

            tab_Document.SelectedIndex = 1;
            manipulate_options(false);
            fill_Sales_Document_Form(sd_see);
        }

        private void fill_Sales_Documents()
        {
            Result result = sales_document_controller.getSalesDocuments();
            sales_documents = (List<SalesDocument>)result.data;
            fill_gridView_Document(sales_documents);
        }

        private void fill_gridView_Document(List<SalesDocument> list)
        {
            clean_gridView_Document();
            List<SalesDocument> current = (List<SalesDocument>)this.grid_Documents.DataSource;
            if (current == null)
                current = new List<SalesDocument>();
            current = current.Concat(list).ToList();
            this.grid_Documents.DataSource = current;
            AdjustColumnDocument();
        }

        private void clean_gridView_Document()
        {
            List<SalesDocument> empty_list = new List<SalesDocument>();
            grid_Documents.DataSource = empty_list;
        }

        private void AdjustColumnDocument()
        {
            grid_Documents.Columns["document_id2"].DisplayIndex = 0;
            grid_Documents.Columns["type_document_id"].DisplayIndex = 1;
            grid_Documents.Columns["external_number"].DisplayIndex = 2;
            grid_Documents.Columns["customer_name"].DisplayIndex = 3;
            grid_Documents.Columns["issue_date"].DisplayIndex = 4;
            grid_Documents.Columns["currency_name"].DisplayIndex = 5;
            grid_Documents.Columns["amount2"].DisplayIndex = 6;
            grid_Documents.Columns["observation"].DisplayIndex = 7;
            grid_Documents.Columns["status"].DisplayIndex = 8;
        }

        private void refresh_amount(SalesDocument sd)
        {
            for (int i = 0; i < grid_Document_Lines.RowCount; i++)
                grid_Document_Lines.Rows[i].Cells["amount"].Value = (sd.Lines[i].Quantity * sd.Lines[i].Unit_price).ToString("0.00");
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            //Path
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = string.Format("{0}Resources\\Excel\\SalesReport.xlsx", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            // Creating an Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(fileName);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Ventas";

                int cellRowIndex = 7;
                double acumulate = 0;

                // Formato
           


                Microsoft.Office.Interop.Excel.Range formatRange;
                formatRange = worksheet.get_Range("a1","h1");
                formatRange.EntireRow.Font.Bold = true;
                worksheet.Cells[1, 5] = "Bold";

                formatRange.Interior.Color = System.Drawing.
                ColorTranslator.ToOle(System.Drawing.Color.DarkCyan);
                formatRange.EntireRow.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White); ;
                worksheet.Cells[1, 5] = "DarkCyan";



                //Loop through each row and read value from each column. 
                for (int i = 0; i < grid_Documents.Rows.Count; i++)
                {                                                               
                    cellPainted(worksheet, cellRowIndex, 2, i, "document_id2");
                    cellPainted(worksheet, cellRowIndex, 3, i, "type_document_id");
                    cellPainted(worksheet, cellRowIndex, 4, i, "external_number");
                    cellPainted(worksheet, cellRowIndex, 5, i, "customer_name");
                    cellPainted(worksheet, cellRowIndex, 6, i, "observation");
                    cellPainted(worksheet, cellRowIndex, 7, i, "issue_date");
                    cellPainted(worksheet, cellRowIndex, 8, i, "currency_name");
                    cellPainted(worksheet, cellRowIndex, 9, i, "amount2");
                    cellPainted(worksheet, cellRowIndex, 10, i, "status");

                    string type = grid_Documents.Rows[i].Cells["type_document_id"].Value.ToString();
                    type.ToLower();
                    double amount = Double.Parse(grid_Documents.Rows[i].Cells["amount2"].Value.ToString());

                    if (type.Equals("factura") || type.Equals("boleta"))
                        acumulate += amount;
                    else if(type.Equals("nota de crédito"))
                        acumulate -= amount;

                    cellRowIndex++;
                }

                worksheet.Cells[4, 5] = "Desde el " + dt_iniDate.Value.Date.ToString("dd/MM/yyyy") + " hasta el " + dt_endDate.Value.Date.ToString("dd/MM/yyyy");
                //worksheet.Columns.AutoFit();

                worksheet.Cells[cellRowIndex + 3, 8] = "Total: ";
                worksheet.Cells[cellRowIndex + 3, 8].Font.Bold = true;
                worksheet.Cells[cellRowIndex + 3, 8].BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
                worksheet.Cells[cellRowIndex + 3, 9] = acumulate.ToString("0.00");
                worksheet.Cells[cellRowIndex + 3, 9].Font.Bold = true;
                worksheet.Cells[cellRowIndex + 3, 9].BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);


                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;
                saveDialog.FileName = "Ventas";

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Exportado correctamente", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                {
                    excel.Quit();
                    workbook = null;
                    excel = null;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);               
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        private void cellPainted(Microsoft.Office.Interop.Excel._Worksheet worksheet, int row_excel, int col_excel, int row_grid, string col_grid)
        {
            worksheet.Cells[row_excel, col_excel] = grid_Documents.Rows[row_grid].Cells[col_grid].Value.ToString();
            worksheet.Cells[row_excel, col_excel].BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
        }

        #endregion

        #region REGISTER DOCUMENT
        // -----------------------------------------------------
        //                   REGISTER DOCUMENT
        // -----------------------------------------------------

        private void btn_Search_Movement_Click(object sender, EventArgs e)
        {
            if (cbo_document_type.Text != "")
            {
                var movementL = new List<ProductMovement>();
                Sales_Module.SalesDocumentSearchMovement search_view = new Sales_Module.SalesDocumentSearchMovement(ref movementL, cbo_document_type.Text[0], user, password);
                search_view.ShowDialog();

                if (movementL.Count != 0)
                {
                    prodMovement = movementL[0];
                    fill_Sales_Document_Form(prodMovement);
                    txt_Movement_id.Text = prodMovement.id.ToString();
                    ProductMovement pm = (ProductMovement)pmc.getMovement(prodMovement.id).data;

                    List<SalesDocumentLine> doc_lines = new List<SalesDocumentLine>();
                    foreach (ProductMovementLine pml in pm.detail)
                        doc_lines.Add(new SalesDocumentLine(pml));

                    grid_Document_Lines.DataSource = doc_lines;
                    AdjustColumnDocumentLine();

                    update_Amount_Document();
                }
            }
            else
            {
                MessageBox.Show(this, "Seleccione un tipo de documento, antes de continuar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            dt_IssueHour.Text = "";
            dt_IssueDate.Text = "";
            int num;
            if (prodMovement == null || String.IsNullOrWhiteSpace(cbo_document_type.Text) || String.IsNullOrWhiteSpace(txt_external.Text) || String.IsNullOrWhiteSpace(txt_Movement_id.Text))
            {
                MessageBox.Show(this, "Debe completar los datos del documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (!Int32.TryParse(txt_external.Text,out num)){
                MessageBox.Show(this, "El número externo es inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {                
                SalesDocument sales_document = new SalesDocument();
                fill_Sales_Document_Object(sales_document);

                sales_document.Lines = (List<SalesDocumentLine>)grid_Document_Lines.DataSource;

                int sales_document_id = Int32.Parse(sales_document_controller.insertSalesDocument(sales_document).data.ToString());

                if (sales_document_id > 0)
                {
                    int i = 1;
                    foreach (SalesDocumentLine sdl in sales_document.Lines)
                    {
                        sdl.Id = i;
                        sdl.Document_id = sales_document_id;
                        var result = sales_document_line_controller.insertSalesDocumentLine(sdl);
                        if (!result.success)
                        {
                            MessageBox.Show(this, result.message);
                            return;
                        }
                        i++;
                    }
                    btn_Clean.PerformClick();
                    btn_Clean.PerformClick();
                    tab_Document.SelectedIndex = 0;
                    MessageBox.Show(this, "Se ha creado el documento N° : " + sales_document_id.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("No se pudo crear el documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            sd_see = new SalesDocument();
            manipulate_options(true);
            Clean();
        }

        private void update_Amount_Document()
        {
            double acumulate = 0;
            for (int i = 0; i < grid_Document_Lines.RowCount; i++)
                acumulate += double.Parse(grid_Document_Lines.Rows[i].Cells["amount"].Value.ToString());

            txt_amount.Text = acumulate.ToString("0.00");
            txt_igv.Text = Math.Round((acumulate * igv), 2).ToString("0.00");
            txt_total.Text = Math.Round((acumulate * (1 + igv)), 2).ToString("0.00");
        }

        private void fill_Sales_Document_Object(SalesDocument sd)
        {
            if (cbo_document_type.Text[0] == 'N')
            {
                sd.Currency_id = rf.Currency_id;
                sd.Currency_name = rf.Currency_name;
                sd.Currency_symbol = rf.Currency_symbol;
                sd.Customer_id = rf.Customer_id;
                sd.Order_id = rf.Id;
            }
            else
            {
                sd.Currency_id = so.Currency_id;
                sd.Currency_name = so.Currency_name;
                sd.Currency_symbol = so.Currency_symbol;
                sd.Customer_id = so.Customer_id;
                sd.Order_id = so.Id;
            }

            sd.Customer_name = txt_name.Text;
            sd.Customer_address = txt_address.Text;
            sd.Customer_doi = txt_Doi.Text;
            sd.Customer_phone = txt_phone.Text;

            sd.Issue_date = dt_IssueDate.Value.Date + dt_IssueHour.Value.TimeOfDay;
            sd.Observation = txt_observation.Text;
            sd.Amount = double.Parse(txt_amount.Text);
            sd.Porc_igv = igv;
            sd.Type_document_id = cbo_document_type.Text[0];
            sd.Movement_id = prodMovement.id;
            sd.External_number = txt_external.Text;
        }

        private void fill_Sales_Document_Form(ProductMovement pm)
        {
            Clean();

            if (cbo_document_type.Text[0] == 'N')
            {
                SalesRefundController rc = new SalesRefundController(user, password);
                rf = (SalesRefund)rc.getSalesRefund(Int32.Parse(pm.NroDocumentoOrigen)).data;
                txt_name.Text = rf.Customer_name;
                txt_address.Text = rf.Customer_address;
                txt_Doi.Text = rf.Customer_doi;
                txt_phone.Text = rf.Customer_phone;
                txt_observation.Text = rf.Observation;
                txt_amount.Text = rf.Amount.ToString();
                txt_Status.Text = rf.Status;
                txt_Currency.Text = rf.Currency_symbol + "  -  " + rf.Currency_name;
                dt_IssueDate.Text = rf.Issue_date.ToShortDateString();
                dt_IssueHour.Text = rf.Issue_date.ToLongTimeString();
            }
            else
            {
                SalesOrderController soc = new SalesOrderController(user, password);
                so = (SalesOrder)soc.getSalesOrder(Int32.Parse(pm.NroDocumentoOrigen)).data;
                txt_name.Text = so.Customer_name;
                txt_address.Text = so.Customer_address;
                txt_Doi.Text = so.Customer_doi;
                txt_phone.Text = so.Customer_phone;
                txt_observation.Text = so.Observation;
                txt_amount.Text = so.Amount.ToString();
                txt_Status.Text = so.Status;
                txt_Currency.Text = so.Currency_symbol + "  -  " + so.Currency_name;
                dt_IssueDate.Text = so.Issue_date.ToShortDateString();
                dt_IssueHour.Text = so.Issue_date.ToLongTimeString();
            }
        }

        private void fill_Sales_Document_Form(SalesDocument sd)
        {
            Clean();
            clean_gridView_DocumentLine();
            txt_name.Text = sd.Customer_name;
            txt_address.Text = sd.Customer_address;
            txt_Doi.Text = sd.Customer_doi;
            txt_phone.Text = sd.Customer_phone;
            txt_Document_id.Text = sd.Id.ToString();
            txt_Currency.Text = sd.Currency_symbol + "  -  " + sd.Currency_name;
            dt_IssueDate.Text = sd.Issue_date.ToShortDateString();
            dt_IssueHour.Text = sd.Issue_date.ToLongTimeString();
            txt_Movement_id.Text = sd.Movement_id.ToString();
            txt_external.Text = sd.External_number;
            txt_observation.Text = sd.Observation;
            txt_amount.Text = sd.Amount.ToString("0.00");
            txt_igv.Text = (sd.Amount * sd.Porc_igv).ToString("0.00");
            txt_total.Text = (sd.Amount * (1 + sd.Porc_igv)).ToString("0.00");
            txt_Status.Text = sd.Status;
            cbo_document_type.Text = sd.Type_name;

            grid_Document_Lines.DataSource = sd.Lines;
            AdjustColumnDocumentLine();
        }

        private void Clean()
        {
            txt_name.Text = "";
            txt_Doi.Text = "";
            txt_address.Text = "";            
            txt_phone.Text = "";

            txt_Document_id.Text = "";
            txt_Currency.Text = "";

            cbo_document_type.Text = "";
            txt_Movement_id.Text = "";            
            txt_external.Text = "";
            
            txt_observation.Text = "";
            txt_amount.Text = "";
            txt_igv.Text = "";
            txt_total.Text = "";
            txt_Status.Text = "";

            dt_IssueHour.Text = "";
            dt_IssueDate.Text = "";
            
            clean_gridView_DocumentLine();
        }

        private void clean_gridView_DocumentLine()
        {
            List<SalesDocumentLine> empty_list = new List<SalesDocumentLine>();
            grid_Document_Lines.DataSource = empty_list;
        }

        private void AdjustColumnDocumentLine()
        {
            grid_Document_Lines.Columns["product"].DisplayIndex = 0;
            grid_Document_Lines.Columns["unit"].DisplayIndex = 1;
            grid_Document_Lines.Columns["warehouse"].DisplayIndex = 2;
            grid_Document_Lines.Columns["quantity"].DisplayIndex = 3;
            grid_Document_Lines.Columns["unit_price"].DisplayIndex = 4;
            grid_Document_Lines.Columns["amount"].DisplayIndex = 5;
        }

        private void manipulate_options(bool booleano)
        {
            Color color = booleano ? Color.White : Color.LightGray;
            
            cbo_document_type.Enabled = booleano;
            cbo_document_type.BackColor = color;

            txt_external.Enabled = booleano;
            txt_external.BackColor = color;

            //dt_IssueDate.Enabled = booleano;
            //dt_IssueHour.Enabled = booleano;

            txt_observation.Enabled = booleano;
            txt_observation.BackColor = color;

            btn_Search_Movement.Visible = booleano;
            btn_Save.Visible = booleano;
            btn_Pdf.Visible = !booleano;
        }

        private void btn_Pdf_Click(object sender, EventArgs e)
        {
            if (sd_see != null)
                To_pdf(sd_see);
            else
                MessageBox.Show(this, "Debe haber seleccionado un documento, primero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region crearPDF
        private void To_pdf(SalesDocument sd)
        {
            Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:";
            saveFileDialog1.Title = "Guardar Reporte";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = sd_see.Type_name + " " + sd_see.Id.ToString();
            string filename = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
            }

           
            if (filename.Trim() != "")
            {
                try
                {
                    FileStream file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

                    PdfWriter.GetInstance(doc, file);
                    String cadena;
                    String ruc;
                    ruc = ((Models.Parameters)rucParam.getParameterByName("ruc").data).Value;
                    doc.Open();
                    string date = DateTime.Now.ToString();
                    if (sd.Type_document_id == 'N')
                    {
                        cadena = "";
                    }
                    else {
                        cadena = "              ";
                    }
                    doc.Add(new Paragraph("                                                                              RUC: " + ruc, FontFactory.GetFont("ARIAL", 25, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.GRAY)));
                    Chunk chunk = new Chunk("                                                                           " + cadena + sd.Type_name.ToUpper() + "\n" +
                                            "                                                                                  " + "    N° " + sd.Id.ToString() + " - " + sd.External_number.ToString(), FontFactory.GetFont("ARIAL", 25, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.GRAY));
                    doc.Add(new Paragraph(chunk));
                    doc.Add(new Paragraph("                       " + company_name.ToUpper(), FontFactory.GetFont("ARIAL", 16, iTextSharp.text.Font.BOLD)));
                    doc.Add(new Paragraph("                                        Dirección: " + company_address, FontFactory.GetFont("ARIAL", 16, iTextSharp.text.Font.BOLD)));
                    doc.Add(new Paragraph("                                        Teléfono: " + company_phone, FontFactory.GetFont("ARIAL", 16, iTextSharp.text.Font.BOLD)));
                    doc.Add(new Paragraph("                                        Correo: " + company_mail, FontFactory.GetFont("ARIAL", 16, iTextSharp.text.Font.BOLD)));
                    doc.Add(new Paragraph("                       "));
                    doc.Add(new Paragraph("     Fecha     :  " + date, FontFactory.GetFont("ARIAL", 15, iTextSharp.text.Font.BOLD)));
                    doc.Add(new Paragraph("     Cliente   :  " + sd.Customer_name, FontFactory.GetFont("ARIAL", 15, iTextSharp.text.Font.BOLD)));
                    doc.Add(new Paragraph("     RUC       :  " + sd.Customer_doi, FontFactory.GetFont("ARIAL", 15, iTextSharp.text.Font.BOLD)));
                    doc.Add(new Paragraph("     Dirección :  " + sd.Customer_address, FontFactory.GetFont("ARIAL", 15, iTextSharp.text.Font.BOLD)));
                    doc.Add(new Paragraph("     Teléfono  :  " + sd.Customer_phone, FontFactory.GetFont("ARIAL", 15, iTextSharp.text.Font.BOLD)));
                    doc.Add(new Paragraph("_________________________________________________________________________________________________________________________"));
                    GenerateDocument(doc, grid_Document_Lines);
                    doc.AddCreationDate();
                    doc.Add(new Paragraph("_________________________________________________________________________________________________________________________"));
                    doc.Add(new Paragraph("                                                                                                                                                                                                        SubTotal    :    " + sd.Amount.ToString("0.00"), FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
                    doc.Add(new Paragraph("                                                                                                                                                                                                        IGV           :    " + (sd.Porc_igv * sd.Amount).ToString("0.00"), FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
                    doc.Add(new Paragraph("                                                                                                                                                                                                                             -------------"));
                    doc.Add(new Paragraph("                                                                                                                                                                                                        Total         :    " + ((1 + sd.Porc_igv) * sd.Amount).ToString("0.00"), FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
                    doc.Add(new Paragraph("_________________________________________________________________________________________________________________________"));
                    doc.Close();
                    Process.Start(filename);//Esta parte se puede omitir, si solo se desea guardar el archivo, y que este no se ejecute al instante
                    file.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(this, "Ya existe un archivo con el mismo nombre", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                    datatable.AddCell(new Phrase(dgv.Columns[i].HeaderText, FontFactory.GetFont("ARIAL", 14, iTextSharp.text.Font.BOLD)));
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

        #endregion

        #endregion
        

        private void printDocument()
        {
            try
            {
                #region Common Part

                PdfPTable pdfTableBlank = new PdfPTable(1);

                // Footer Section
                PdfPTable pdfTableFooter = new PdfPTable(1);
                pdfTableFooter.DefaultCell.BorderWidth = 0;
                pdfTableFooter.WidthPercentage = 100;
                pdfTableFooter.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

                Chunk cnkFooter = new Chunk("Enterprise2", FontFactory.GetFont("Times New Roman"));
                //cnkFooter.Font.SetStyle(1);
                cnkFooter.Font.Size = 10;
                pdfTableFooter.AddCell(new Phrase(cnkFooter));
                // end of footer section

                pdfTableBlank.AddCell(new Phrase(" "));
                pdfTableBlank.DefaultCell.Border = 0;
                #endregion

                #region Page

                #region Section-1 <Header FORM>
                PdfPTable pdfTable1 = new PdfPTable(1); // Here 1 is used for count of column
                PdfPTable pdfTable2 = new PdfPTable(1);
                PdfPTable pdfTable3 = new PdfPTable(2);

                // Font Style
                System.Drawing.Font fontH1 = new System.Drawing.Font("Curier", 16);

                //pdfTable1.DefaultCell.Padding = 5;
                pdfTable1.WidthPercentage = 80;
                pdfTable1.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTable1.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
                //pdfTable1.DefaultCell.BackgroundColor = new iTextSharp.text.BaseColor(64, 134, 170);
                pdfTable1.DefaultCell.BorderWidth = 0;

                //pdfTable1.DefaultCell.Padding = 5;
                pdfTable2.WidthPercentage = 80;
                pdfTable2.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTable2.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
                //pdfTable2.DefaultCell.BackgroundColor = new iTextSharp.text.BaseColor(64, 134, 170);
                pdfTable2.DefaultCell.BorderWidth = 0;

                pdfTable3.DefaultCell.Padding = 5;
                pdfTable3.WidthPercentage = 80;
                pdfTable3.DefaultCell.BorderWidth = 0.5f;

                Chunk c1 = new Chunk("Enterprise1", FontFactory.GetFont("Times New Roman"));
                c1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c1.Font.SetStyle(0);
                c1.Font.Size = 14;

                Phrase p1 = new Phrase();
                p1.Add(c1);
                pdfTable1.AddCell(p1);

                Chunk c2 = new Chunk("28/3, XXX Narayan XXXXX, Kolkata ", FontFactory.GetFont("Times New Roman"));
                c2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c2.Font.SetStyle(0);
                c2.Font.Size = 11;

                Phrase p2 = new Phrase();
                p2.Add(c2);
                pdfTable2.AddCell(p2);

                Chunk c3 = new Chunk("28/3, XXX Narayan XXXXX, Kolkata ", FontFactory.GetFont("Times New Roman"));
                c3.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c3.Font.SetStyle(0);
                c3.Font.Size = 11;

                Phrase p3 = new Phrase();
                p3.Add(c3);
                pdfTable3.AddCell(p3);

                #endregion

                #region Section-1 <Bill Upper>
                PdfPTable pdfTable4 = new PdfPTable(4);
                pdfTable4.DefaultCell.Padding = 5;
                pdfTable4.WidthPercentage = 80;
                pdfTable4.DefaultCell.BorderWidth = 0.0f;

                pdfTable4.AddCell(new Phrase("Bill N° "));
                pdfTable4.AddCell(new Phrase("B001"));
                pdfTable4.AddCell(new Phrase("Date "));
                pdfTable4.AddCell(new Phrase("01-01-2017"));
                pdfTable4.AddCell(new Phrase("Vendor"));
                pdfTable4.AddCell(new Phrase("Demo Vendor"));
                pdfTable4.AddCell(new Phrase("Address"));
                pdfTable4.AddCell(new Phrase("Kolkata"));
                #endregion

                #region Section-Image

                string imageURL = @"";
                iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(imageURL);

                // Resize image
                jpg.ScaleToFit(140f, 120f);
                // Give space before image
                jpg.SpacingBefore = 10f;
                // Give some space after the image
                jpg.SpacingAfter = 1f;

                jpg.Alignment = Element.ALIGN_CENTER;

                #endregion

                #region section Table

                pdfTable3.AddCell(new Phrase("Company name: "));
                pdfTable3.AddCell(new Phrase(" "));
                pdfTable3.AddCell(new Phrase("Job title: "));
                pdfTable3.AddCell(new Phrase(" "));

                pdfTable3.AddCell(new Phrase("Address"));
                pdfTable3.AddCell(new Phrase(" "));
                pdfTable3.AddCell(new Phrase("Contact N°: "));
                pdfTable3.AddCell(new Phrase(" "));

                #endregion

                #endregion

                #region Pdf Generation
                string folderPath = "D:\\PDF\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // File Name
                int fileCount = Directory.GetFiles(@"D:\\PDF").Length;
                string strFileName = "JobDescriptionForm" + (fileCount + 1) + ".pdf";

                #endregion

                
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
           

        }

        private void txt_external_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
        }
    }
}
