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
    public partial class SalesRefundSearchDocument : Form
    {
        public List<SalesDocument> documentList;
        private SalesDocumentController sales_document_controller;

        public SalesRefundSearchDocument(ref List<SalesDocument> docL, string user, string password)
        {
            InitializeComponent();
            this.documentList = docL;
            sales_document_controller = new SalesDocumentController(user, password);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            var documents = new List<SalesDocument>();
            grid_Documents.DataSource = documents;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var documents = (List<SalesDocument>)sales_document_controller.getSalesDocumentsforRefund().data;
            if (documents == null)
                documents = new List<SalesDocument>();
            grid_Documents.DataSource = documents;
        }

        private void btn_Save_Click(object sender, EventArgs e)
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
                SalesDocument document_found = (SalesDocument)grid_Documents.CurrentRow.DataBoundItem;
                documentList.Add(document_found);
                this.Close();
            }
        }
    }
}
