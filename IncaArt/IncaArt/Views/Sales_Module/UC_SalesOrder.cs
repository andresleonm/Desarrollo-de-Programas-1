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
            CurrencyController currency_controller = new CurrencyController(user, password);            

            Result result = currency_controller.getCurrencies();
            this.currencies = (List<Currency>)result.data;
            foreach (Currency curr in currencies)
            {
                this.cbo_Currency.Items.Add(curr.Name);
            }
            //this.cbo_Currency.SelectedItem = this.cbo_Currency.Items[0];
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            List<Customer> customerL= new List<Customer>();
            Sales_Module.SalesOrderSearchClient search_view = new Sales_Module.SalesOrderSearchClient(ref customerL, user, password);
            search_view.ShowDialog();
            if (customerL.Count != 0)
            {
                Customer customer = customerL[0];
                txt_name.Text = customer.Name;
                txt_address.Text = customer.Address;
                txt_Doi.Text= customer.Doi;
                txt_phone.Text = customer.Phone;

            }
            
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            List<SalesOrderLine> lines = new List<SalesOrderLine>();
            Sales_Module.SalesOrderLine order_line = new Sales_Module.SalesOrderLine(ref lines, user,password);
            order_line.ShowDialog();

            List<Models.SalesOrderLine> current = (List<Models.SalesOrderLine>)this.grid_order_lines.DataSource;
            if (current == null)
                current = new List<SalesOrderLine>();
            current = current.Concat(lines).ToList();
            this.grid_order_lines.DataSource = current;

            AdjustColumnOrder();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            
        }

        private void AdjustColumnOrder()
        {
            grid_order_lines.Columns["product"].DisplayIndex = 0;
            grid_order_lines.Columns["unit"].DisplayIndex = 1;
            grid_order_lines.Columns["warehouse"].DisplayIndex = 2;
            grid_order_lines.Columns["quantity"].DisplayIndex = 3;
            grid_order_lines.Columns["unit_price"].DisplayIndex = 4;
            grid_order_lines.Columns["amount"].DisplayIndex = 5;
            grid_order_lines.Columns["action"].DisplayIndex = 6;
        }
        
    }
}
