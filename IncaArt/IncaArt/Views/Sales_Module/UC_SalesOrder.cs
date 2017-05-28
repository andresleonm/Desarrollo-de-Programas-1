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

        private void btn_New_Click(object sender, EventArgs e)
        {
            Models.SalesOrderLine salesOrderLine = new Models.SalesOrderLine();
            Sales_Module.SalesOrderLine order_line = new Sales_Module.SalesOrderLine(ref salesOrderLine);
            order_line.ShowDialog();

            if (salesOrderLine != null)
            {
                String[] row = new String[6];
                row[0] = salesOrderLine.Product.Name;
                row[1] = salesOrderLine.Quantity.ToString();
                row[2] = salesOrderLine.Unit_measure.Name;
                row[3] = salesOrderLine.Warehouse.Name;
                row[4] = salesOrderLine.Delivery_quantity.ToString();
                row[5] = salesOrderLine.Unit_price.ToString();
                row[6] = Math.Round((salesOrderLine.Quantity * salesOrderLine.Unit_price),2).ToString();
                this.grid_order_lines.Rows.Add(row);
            }

        }
    }
}
