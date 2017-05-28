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
                first_time = false;
            }
        }

        public void fill_grid() // llena con todas las órdenes de trabajo
        {
            List<Models.PurchaseOrder> orders = new List<Models.PurchaseOrder>();
            Controller.PurchaseOrderController controller = new Controller.PurchaseOrderController("dp1admin", "dp1admin");
            Controller.Result result = controller.getPurchaseOrders();
            string[] grid_row = new string[5];
            foreach (DataService.Row r in (List<DataService.Row>)result.data)
            {
                grid_row[0] = r.getColumn(0);
                grid_row[1] = r.getColumn(9);
                grid_row[2] = r.getColumn(3);
                grid_row[3] = r.getColumn(6);
                grid_row[4] = r.getColumn(7);
                this.metroGrid1.Rows.Add(grid_row);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (this.metroGrid1.SelectedRows[0] == null)
            {
                MessageBox.Show(this, "Primero debe seleccionar una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Controller.PurchaseOrderController po_controller = new Controller.PurchaseOrderController("dp1admin", "dp1admin");
                Controller.PurchaseOrderLineController pol_controller = new Controller.PurchaseOrderLineController("dp1admin", "dp1admin");

                Controller.Result result = po_controller.getPurchaseOrder(Int32.Parse(this.metroGrid1.SelectedRows[0].Cells[0].Value.ToString()));
                Models.PurchaseOrder purchase_order = (Models.PurchaseOrder)result.data;

                result = pol_controller.getPurchaseOrderLines(Int32.Parse(this.metroGrid1.SelectedRows[0].Cells[0].Value.ToString()));
                List<Models.PurchaseOrderLine> lines = (List<Models.PurchaseOrderLine>)result.data;

                UC_PurchaseOrder uc = (UC_PurchaseOrder)(this.FindForm().Controls.Find("uC_PurchaseOrder1", false)[0]);
                uc.Controls.Find("txt_id", false)[0].Text = purchase_order.Id.ToString();
                uc.Controls.Find("date_order_date", false)[0].Text = purchase_order.Creation_date.ToShortDateString();
                uc.Controls.Find("txt_external_number", false)[0].Text = purchase_order.External_number;

                MetroFramework.Controls.MetroGrid po_grid = (MetroFramework.Controls.MetroGrid)uc.Controls.Find("grid_order_lines", false)[0];
                string[] grid_row = new string[6];
                foreach (Models.PurchaseOrderLine line in lines)
                {
                    grid_row[0] = line.Scheluded_date.ToShortTimeString();
                    //grid_row[1] = line.Material
                    //****************************************************************************************
                }
                

            }
        }
    }
}
