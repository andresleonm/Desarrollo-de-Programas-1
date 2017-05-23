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
        public UC_PurchaseOrder()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Purchase_Module.PurchaseOrderLine order_line = new Purchase_Module.PurchaseOrderLine();
            order_line.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(grid_order_lines.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar por lo menos una línea a la orden de compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
