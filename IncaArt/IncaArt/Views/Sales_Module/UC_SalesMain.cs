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
    public partial class UC_SalesMain : UserControl
    {
        public UC_SalesMain()
        {
            InitializeComponent();
        }

        private void UC_SalesMain_Load(object sender, EventArgs e)
        {
            uC_SalesOrder1.Visible = false;
            uC_SalesOrderList1.Visible = false;
        }

        private void register_order_Click(object sender, EventArgs e)
        {
            uC_SalesOrder1.Visible = true;
            uC_SalesOrderList1.Visible = false;
        }

        private void orders_Click(object sender, EventArgs e)
        {
            uC_SalesOrderList1.Visible = true;
            uC_SalesOrder1.Visible = false;            
        }

        private void refund_Click(object sender, EventArgs e)
        {

        }
        
    }
}
