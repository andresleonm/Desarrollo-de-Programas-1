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
    public partial class UC_PurchaseOrderGrid : UserControl
    {
        private bool first_time = true;
        public UC_PurchaseOrderGrid()
        {
            InitializeComponent();
        }

        private void UC_PurchaseOrderGrid_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true && first_time)
            {
                fill_grid();
            }
        }

        private void fill_grid()
        {
            List<Models.PurchaseOrder> orders = new List<Models.PurchaseOrder>();
            Controller.PurchaseOrderController controller = new Controller.PurchaseOrderController("dp1admin", "dp1admin");
            Controller.Result result = controller.getPurchaseOrders();

            foreach (DataService.Row r in (List<DataService.Row>)result.data)
            {
            }
        }
    }
}
