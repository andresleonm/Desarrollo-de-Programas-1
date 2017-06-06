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

        public UC_SalesDocument()
        {
            InitializeComponent();
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
            }
        }
    }
}
