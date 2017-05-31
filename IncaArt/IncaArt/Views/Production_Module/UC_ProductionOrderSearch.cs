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
    public partial class UC_ProductionOrderSearch : UserControl
    {
        string user = "dp1admin";
        string password = "dp1admin";

        public UC_ProductionOrderSearch()
        {
            InitializeComponent();
            datagrid_Products_Fill();
        }


        public void datagrid_Products_Fill() 
        {
            List<Models.ProductionOrder> orders = new List<Models.ProductionOrder>();
            Controller.ProductionOrderController controller = new Controller.ProductionOrderController(user, password);
            Controller.Result result = controller.getProductionOrders();

            if (((List<Models.ProductionOrder>)result.data).Count != 0)
            {
                string[] grid_row = new string[5];
                foreach (Models.ProductionOrder po in (List<Models.ProductionOrder>)result.data)
                {
                    grid_row[0] = po.Id.ToString();
                    grid_row[1] = po.Begin.ToShortDateString();
                    grid_row[2] = po.End.ToShortDateString();
                    grid_row[3] = po.Description;
                    grid_row[4] = po.Observation;
                    this.datagrid_Products.Rows.Add(grid_row);
                }
            }
        }

        private void UC_ProductionOrderSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
