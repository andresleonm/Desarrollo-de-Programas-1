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
            uC_SalesEstimate1.Visible = false;
            uC_SalesOrder2.Visible = false;
            uC_SalesDocument2.Visible = false;
            uC_SalesRefund1.Visible = false;
        }

        private void btn_Estimates_Click(object sender, EventArgs e)
        {
            uC_SalesEstimate1.Visible = true;
            uC_SalesEstimate1.btn_Clean.PerformClick();
            uC_SalesOrder2.Visible = false;
            uC_SalesDocument2.Visible = false;
            uC_SalesRefund1.Visible = false;
        }

        private void btn_Orders_Click(object sender, EventArgs e)
        {
            uC_SalesOrder2.Visible = true;
            uC_SalesOrder2.btn_Clean.PerformClick();
            uC_SalesDocument2.Visible = false;
            uC_SalesRefund1.Visible = false;
            uC_SalesEstimate1.Visible = false;
        }

        private void btn_Documents_Click(object sender, EventArgs e)
        {
            uC_SalesDocument2.Visible = true;
            uC_SalesDocument2.btn_Clean.PerformClick();
            uC_SalesEstimate1.Visible = false;
            uC_SalesOrder2.Visible = false;
            uC_SalesRefund1.Visible = false;
        }

        private void btn_Refunds_Click(object sender, EventArgs e)
        {
            uC_SalesRefund1.Visible = true;
            uC_SalesRefund1.btn_Clean.PerformClick();
            uC_SalesEstimate1.Visible = false;
            uC_SalesOrder2.Visible = false;
            uC_SalesDocument2.Visible = false;
        }
    }
}
