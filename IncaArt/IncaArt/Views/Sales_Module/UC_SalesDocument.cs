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
    public partial class UC_SalesDocument : UserControl
    {
        private string user = "dp1admin";
        private string password = "dp1admin";
        private double igv = 0.18;
        private bool edit = false;
        private SalesOrder so;
        private SalesRefund rf;
        private SalesDocument sd_edit;
        private ProductMovement prodMovement;
        private List<SalesDocument> sales_documents;
        private ProductMovementController pmc;
        private SalesDocumentController sales_document_controller;
        private SalesDocumentLineController sales_document_line_controller;

        public UC_SalesDocument()
        {
            InitializeComponent();
            sales_document_controller = new SalesDocumentController(user, password);
            sales_document_line_controller = new SalesDocumentLineController(user, password);
            pmc = new ProductMovementController(user, password);
            fill_Sales_Documents();
        }

        private void btn_Search_Documents_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ctxt_document_id.Text))
            {
                fill_Sales_Document_Grid();
            }
            else
            {
                sales_documents = new List<SalesDocument>();
                Result result = sales_document_controller.getSalesDocument(Int32.Parse(ctxt_document_id.Text));
                SalesDocument sd = (SalesDocument)result.data;
                sales_documents.Add(sd);
                fill_gridView_Document(sales_documents);
            }
        }

        private void btn_Search_Movement_Click(object sender, EventArgs e)
        {
            if (cbo_document_type.Text != "") {
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

                    double acumulate = 0;
                    for (int i = 0; i < grid_Document_Lines.RowCount; i++)
                    {
                        acumulate += double.Parse(grid_Document_Lines.Rows[i].Cells["amount"].Value.ToString());
                    }
                    txt_amount.Text = acumulate.ToString();
                    txt_igv.Text = (acumulate * igv).ToString();
                    txt_total.Text = (acumulate * (1 + igv)).ToString();
                }
            }
            else
            {
                MessageBox.Show(this, "Seleccione un tipo de documento, antes de continuar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
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
                dt_IssueDate.Text = rf.Issue_date.ToString();
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
                dt_IssueDate.Text = so.Issue_date.ToString();
            }           
        }

        private void fill_Sales_Document_Form(SalesDocument sd)
        {
            Clean();
            txt_name.Text = sd.Customer_name;
            txt_address.Text = sd.Customer_address;
            txt_Doi.Text = sd.Customer_doi;
            txt_phone.Text = sd.Customer_phone;
            txt_Document_id.Text = sd.Id.ToString();
            txt_Currency.Text = sd.Currency_symbol + "  -  " + sd.Currency_name;
            dt_IssueDate.Text = sd.Issue_date.ToString();
            txt_Movement_id.Text = sd.Movement_id.ToString();
            txt_external.Text = sd.External_number;
            txt_observation.Text = sd.Observation;
            txt_amount.Text = sd.Amount.ToString();
            txt_igv.Text = (sd.Amount * sd.Porc_igv).ToString();
            txt_total.Text = (sd.Amount * (1 + sd.Porc_igv)).ToString();
            txt_Status.Text = sd.Status;

            if (sd.Type_document_id.ToString().Equals('F'))
                cbo_document_type.Text = "Factura";
            else if (sd.Type_document_id.ToString().Equals('B'))
                cbo_document_type.Text = "Boleta";
            else if (sd.Type_document_id.ToString().Equals('N'))
                cbo_document_type.Text = "Nota de Crédito";
            cbo_document_type.Refresh();

            grid_Document_Lines.DataSource = sd.Lines;
            AdjustColumnDocumentLine();
        }

        private void Clean()
        {
            txt_name.Text = "";
            txt_address.Text = "";
            txt_Doi.Text = "";
            txt_phone.Text = "";
            txt_Document_id.Text = "";
            txt_Movement_id.Text = "";
            txt_Currency.Text = "";
            txt_external.Text = "";
            txt_Status.Text = "";
            txt_observation.Text = "";
            txt_amount.Text = "";
            txt_igv.Text = "";
            txt_total.Text = "";
            prodMovement = new ProductMovement();
            clean_gridView_DocumentLine();
        }

        private void clean_gridView_DocumentLine()
        {
            List<SalesDocumentLine> empty_list = new List<SalesDocumentLine>();
            grid_Document_Lines.DataSource = empty_list;
        }

        private void fill_Sales_Documents()
        {
            Result result = sales_document_controller.getSalesDocuments();
            sales_documents = (List<SalesDocument>)result.data;
            fill_gridView_Document(sales_documents);
        }

        private void fill_Sales_Document_Grid()
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

        private void AdjustColumnDocumentLine()
        {
            grid_Document_Lines.Columns["product"].DisplayIndex = 0;
            grid_Document_Lines.Columns["unit"].DisplayIndex = 1;
            grid_Document_Lines.Columns["warehouse"].DisplayIndex = 2;
            grid_Document_Lines.Columns["quantity"].DisplayIndex = 3;
            grid_Document_Lines.Columns["unit_price"].DisplayIndex = 4;
            grid_Document_Lines.Columns["amount"].DisplayIndex = 5;
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //if (edit)
            //{

            //}
            //else { }


            if ( prodMovement == null || String.IsNullOrWhiteSpace(cbo_document_type.Text) || String.IsNullOrWhiteSpace(txt_external.Text) || String.IsNullOrWhiteSpace(txt_Movement_id.Text))
            {
                MessageBox.Show(this, "Debe completar los datos del documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        sdl.Status = "Registrado";
                        i++;
                        sales_document_line_controller.insertSalesDocumentLine(sdl);
                    }
                    txt_Document_id.Text = sales_document_id.ToString();
                    txt_Status.Text = sales_document.Status;
                    fill_Sales_Documents();
                    btn_Clean.PerformClick();
                    tab_Document.SelectedIndex = 0;
                    MessageBox.Show(this, "Documento creado exitosamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("No se pudo crear el documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void fill_Sales_Document_Object(SalesDocument sd)
        {
            if(cbo_document_type.Text[0] == 'N')
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
            
            sd.Issue_date = DateTime.Parse(dt_IssueDate.Text);
            sd.Observation = txt_observation.Text;
            sd.Amount = double.Parse(txt_amount.Text);
            sd.Porc_igv = igv;
            sd.Type_document_id = cbo_document_type.Text[0];
            sd.Movement_id = prodMovement.id;
            sd.External_number = txt_external.Text;            
            sd.Status = "Registrado";
        }

        private void cbo_document_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clean();
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            edit = false;
            Clean();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
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
                edit = true;
                int index = grid_Documents.SelectedRows[0].Index;
                var id = sales_documents[index].Id;
                sd_edit = (Models.SalesDocument)sales_document_controller.getSalesDocument(id).data;
                grid_Document_Lines.DataSource = sd_edit.Lines;
                tab_Document.SelectedIndex = 1;
                fill_Sales_Document_Form(sd_edit);
            }
        }

        private void tab_Document_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_Document.SelectedIndex == 0) // Documents
            {
                ctxt_document_id.Text = "";
                ctxt_customer.Text = "";
            }
            else if (tab_Document.SelectedIndex == 1) // New_Document
            {
                if (!edit)
                {
                    btn_Clean.PerformClick();
                    txt_Document_id.Text = (sales_documents.Count + 1).ToString();
                }
            }
        }
    }
}
