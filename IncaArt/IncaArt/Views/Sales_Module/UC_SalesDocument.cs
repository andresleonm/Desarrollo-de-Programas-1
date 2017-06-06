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
        private ProductMovement prodMovement;
        private ProductMovementController pmc;

        public UC_SalesDocument()
        {
            InitializeComponent();
            pmc = new ProductMovementController(user, password);
        }

        private void btn_Search_Documents_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Document_Click(object sender, EventArgs e)
        {
            var movementL = new List<ProductMovement>();
            Sales_Module.SalesDocumentSearchMovement search_view = new Sales_Module.SalesDocumentSearchMovement(ref movementL, user, password);
            search_view.ShowDialog();

            if (movementL.Count != 0)
            {
                prodMovement = movementL[0];
                txt_Document_id.Text = prodMovement.id.ToString();
                ProductMovement pm = (ProductMovement)pmc.getMovement(prodMovement.id).data;

                List<SalesDocumentLine> doc_lines = new List<SalesDocumentLine>();
                foreach (ProductMovementLine pml in pm.detail)
                    doc_lines.Add(new SalesDocumentLine(pml));

                grid_Document_Lines.DataSource = doc_lines;
                AdjustColumnOrder();
            }
        }

        private void AdjustColumnOrder()
        {
            grid_Document_Lines.Columns["product"].DisplayIndex = 0;
            grid_Document_Lines.Columns["unit"].DisplayIndex = 1;
            grid_Document_Lines.Columns["warehouse"].DisplayIndex = 2;
            grid_Document_Lines.Columns["quantity"].DisplayIndex = 3;
            grid_Document_Lines.Columns["unit_price"].DisplayIndex = 4;
            grid_Document_Lines.Columns["amount"].DisplayIndex = 5;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
