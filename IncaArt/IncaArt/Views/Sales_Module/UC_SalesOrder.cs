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
    public partial class UC_SalesOrder : MetroFramework.Controls.MetroUserControl
    {
        public UC_SalesOrder()
        {
            InitializeComponent();
            this.Style = mbStyle.Style;
        }

        private void UC_SalesOrder_Load(object sender, EventArgs e)
        {
            mbStyle.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void add_Click(object sender, EventArgs e)
        {
            Models.SalesOrderLine salesOrderLine= new Models.SalesOrderLine();
            Sales_Module.SalesOrderLine order_line = new Sales_Module.SalesOrderLine(salesOrderLine);
            order_line.ShowDialog();
            if (salesOrderLine != null)
            {
                //int num = dataGridView1.Rows.Count;
                //String[] row = new String[6];
                //row[0] = num.ToString();
                //row[1] = salesOrderLine.Product.ToString();
                //row[2] = salesOrderLine.Description.ToString();
                //row[3] = salesOrderLine.Quantity.ToString();
                //row[4] = salesOrderLine.Unit_price.ToString();
                //row[5] = (salesOrderLine.Quantity * salesOrderLine.Unit_price).ToString();
                //this.dataGridView1.Rows.Add(row);

            }
        }

        
    }
}
