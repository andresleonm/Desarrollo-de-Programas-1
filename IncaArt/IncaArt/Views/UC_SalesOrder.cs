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
    public partial class UC_SalesOrder : UserControl
    {
        public UC_SalesOrder()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Models.SalesOrderLine sl= new Models.SalesOrderLine();
            Sales_Module.SalesOrderLine order_line = new Sales_Module.SalesOrderLine(sl);
            order_line.ShowDialog();
            if (sl!=null)
            {

            }
        }
    }
}
