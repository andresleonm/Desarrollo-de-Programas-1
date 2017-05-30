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


namespace WindowsFormsApp1.Views
{           
    public partial class UC_SalesOrder : MetroFramework.Controls.MetroUserControl
    {
        private List<SalesOrderLine> list_order_detail = new List<SalesOrderLine>();
        private List<Currency> currencies;
        private string user = "dp1admin";
        private string password = "dp1admin";

        public UC_SalesOrder()
        {
            InitializeComponent();
            this.Style = mbStyle.Style;
        }

        private void UC_SalesOrder_Load(object sender, EventArgs e)
        {
            mbStyle.Style = MetroFramework.MetroColorStyle.Teal;
            List<SalesOrderLine> list_order_detail = new List<SalesOrderLine>();
            CurrencyController currency_controller = new CurrencyController(user, password);            

            Result result = currency_controller.getCurrencies();
            this.currencies = (List<Currency>)result.data;
            foreach (Currency curr in currencies)
            {
                this.cbo_Currency.Items.Add(curr.Name);
            }
            //this.cbo_Currency.SelectedItem = this.cbo_Currency.Items[0];
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            SalesOrderLine salesOrderLine = new SalesOrderLine();
            Sales_Module.SalesOrderLine order_line = new Sales_Module.SalesOrderLine(ref salesOrderLine);
            order_line.ShowDialog();

            if (salesOrderLine != null)
            {
                String[] row = new String[6];
                row[0] = salesOrderLine.Product.Name;
                row[1] = salesOrderLine.Unit_measure.Name;
                row[2] = salesOrderLine.Prod_warehouse.Name;
                row[3] = salesOrderLine.Quantity.ToString();
                row[4] = salesOrderLine.Unit_price.ToString();
                row[5] = Math.Round((salesOrderLine.Quantity * salesOrderLine.Unit_price),2).ToString();
                this.grid_order_lines.Rows.Add(row);
                list_order_detail.Add(salesOrderLine);
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SalesOrderLineController sales_order_line_controller = new SalesOrderLineController(user, password);

            Result result;
            foreach (SalesOrderLine order_detail in list_order_detail) {
                result = sales_order_line_controller.insertSalesOrderLine(order_detail);
            }
        }
    }
}
