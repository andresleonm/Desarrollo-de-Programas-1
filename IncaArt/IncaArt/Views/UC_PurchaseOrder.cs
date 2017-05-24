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
    public partial class UC_PurchaseOrder : UserControl
    {
        Boolean editing;
        Models.PurchaseOrder editing_order;
        public UC_PurchaseOrder()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Models.PurchaseOrderLine line = new Models.PurchaseOrderLine();
            Purchase_Module.PurchaseOrderLine order_line = new Purchase_Module.PurchaseOrderLine(line);
            order_line.ShowDialog();
            if (line != null)
            {
                string[] grid_line = new string[6];
                //grid_line[0] = order.Due_date.ToString();
                grid_line[1] = "";
                grid_line[2] = line.Quantity.ToString();
                grid_line[3] = line.Material.Name;
                grid_line[4] = line.Price.ToString();
                grid_line[5] = (line.Quantity * line.Price).ToString();
                grid_order_lines.Rows.Add(grid_line);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(grid_order_lines.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar por lo menos una línea a la orden de compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (editing)
                {
                    int index = ((Dashboard)(this.FindForm().FindForm())).purchase_order_list.FindIndex(or => or.Id == editing_order.Id);
                    ((Dashboard)(this.FindForm().FindForm())).purchase_order_list[index] = editing_order;
                }
            }
        }

        public void fillForm(Models.PurchaseOrder order)
        {
            editing = true;
            editing_order = order;
            txt_id.Text = order.Id.ToString();
            date_order_date.Text = order.Creation_date.ToString();
            combo_warehouse.Text = order.Warehouse.Name;
            combo_supplier.Text = order.Supplier.Supplier_name;
            combo_address.Text = order.Supplier.Supplier_addres;
            combo_state.Text = order.State;

            foreach(Models.PurchaseOrderLine line in order.Lines)
            {
                string[] grid_line = new string[6];
                grid_line[0] = order.Due_date.ToString();
                grid_line[1] = "";
                grid_line[2] = line.Quantity.ToString();
                grid_line[3] = line.Material.Name;
                grid_line[4] = line.Price.ToString();
                grid_line[5] = (line.Quantity * line.Price).ToString();
                grid_order_lines.Rows.Add(grid_line);
            }
            

        }

        private void grid_order_lines_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            txt_no_taxes.Text = (Double.Parse(txt_no_taxes.Text) + (Double.Parse(grid_order_lines.Rows[grid_order_lines.Rows.Count].Cells[5].Value.ToString())) / 1.18).ToString();
            txt_taxes.Text = (Double.Parse(txt_no_taxes.Text) * 0.18).ToString();
            txt_total.Text = (Double.Parse(txt_no_taxes.Text) + Double.Parse(txt_taxes.Text)).ToString();
        }

    }
}
