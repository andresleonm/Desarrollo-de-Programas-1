using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class UC_PurchasesMenu : UserControl
    {
        public UC_PurchasesMenu()
        {
            InitializeComponent();
        }

        private void btn_purchases_orders_Click(object sender, EventArgs e)
        {
            uC_PurchaseOrder1.Visible = false;
            uC_PurchaseOrderGrid1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uC_PurchaseOrderGrid1.Visible = false;
            uC_PurchaseOrder1.Visible = true;
        }        
       
    }
}
