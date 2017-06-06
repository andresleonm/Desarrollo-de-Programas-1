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

        Controller.ProductionOrderController order_controller;
        public UC_ProductionOrderSearch()
        {
            InitializeComponent();
            order_controller = new Controller.ProductionOrderController(user, password);
            datagrid_Products_Fill();
        }


        public void datagrid_Products_Fill() 
        {
            List<Models.ProductionOrder> orders = new List<Models.ProductionOrder>();         
            Controller.Result result = order_controller.getProductionOrders();

            if (((List<Models.ProductionOrder>)result.data).Count != 0)
            {
                datagrid_Products.Rows.Clear();
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

        private void UC_ProductionOrderSearch_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                datagrid_Products_Fill();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(datagrid_Products.SelectedRows[0]==null)
            {
                MessageBox.Show(this, "Primero debe seleccionar una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                int selected_index = Int32.Parse(this.datagrid_Products.SelectedRows[0].Cells[0].Value.ToString());
                UC_ProductionOrder uc_productionOrder = (UC_ProductionOrder)(this.Parent.Controls.Find("production_register", false)[0]);
                uc_productionOrder.editing = true;
                uc_productionOrder.fillEditForm(selected_index);
                uc_productionOrder.Visible = true;
                this.Visible = false;
            }
        }
    }
}
