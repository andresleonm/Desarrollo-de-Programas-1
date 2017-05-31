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
        public UC_PurchaseOrderGrid()
        {
            InitializeComponent();
        }

        private void UC_PurchaseOrderGrid_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                fill_grid();               
            }
        }

        public void fill_grid() // llena con todas las órdenes de trabajo
        {
            metroGrid1.Rows.Clear();
            List<Models.PurchaseOrder> orders = new List<Models.PurchaseOrder>();
            Controller.PurchaseOrderController controller = new Controller.PurchaseOrderController("dp1admin", "dp1admin");
            Controller.Result result = controller.getPurchaseOrders();
            if (((List<Models.PurchaseOrder>)result.data).Count != 0)
            {
                string[] grid_row = new string[5];
                foreach (Models.PurchaseOrder po in (List<Models.PurchaseOrder>)result.data)
                {
                    grid_row[0] = po.Id.ToString();
                    grid_row[1] = po.Creation_date.ToShortDateString();
                    grid_row[2] = po.Supplier_name;
                    grid_row[3] = po.Amount.ToString();                                        
                    grid_row[4] = po.State;
                    this.metroGrid1.Rows.Add(grid_row);
                }
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

                UC_PurchaseOrder uc = ((UC_PurchaseOrder)(this.Parent.Controls.Find("uC_PurchaseOrder1", false)[0]));                
                
                foreach (Models.PurchaseOrderLine line in lines)
                {
                    purchase_order.Lines.Add(line);
                }                
                this.Visible = false;                
                uc.fillForm(purchase_order);                     
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            Controller.PurchaseOrderController po_controller = new Controller.PurchaseOrderController("dp1admin", "dp1admin");
            Controller.PurchaseOrderLineController pol_controller = new Controller.PurchaseOrderLineController("dp1admin", "dp1admin");

            Controller.Result result = po_controller.getPurchaseOrder(Int32.Parse(this.metroGrid1.SelectedRows[0].Cells[0].Value.ToString()));
            Models.PurchaseOrder purchase_order = (Models.PurchaseOrder)result.data;

            result = pol_controller.getPurchaseOrderLines(Int32.Parse(this.metroGrid1.SelectedRows[0].Cells[0].Value.ToString()));
            List<Models.PurchaseOrderLine> lines = (List<Models.PurchaseOrderLine>)result.data;

            UC_PurchaseOrder uc = ((UC_PurchaseOrder)(this.Parent.Controls.Find("uC_PurchaseOrder1", false)[0]));

            foreach (Models.PurchaseOrderLine line in lines)
            {
                purchase_order.Lines.Add(line);
            }
            purchase_order.State = "Anulado";
            po_controller.updatePurchaseOrder(purchase_order);

        }
    }
}
