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

        public void fillGrid()
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataGridViewRow gridline = new DataGridViewRow();
            gridline = dataGridView2.SelectedRows[0];
                        
            Models.PurchaseOrder p_order = 
                ((Dashboard)Parent.Parent).purchase_order_list.Where(Ord => Ord.Id == int.Parse(gridline.Cells[0].Value.ToString())).ElementAt(0);

            UC_PurchaseOrder order = (UC_PurchaseOrder)Parent.Controls.Find("uC_PurchaseOrder1", false)[0];

            order.fillForm(p_order);

        }

        private void UC_PurchaseOrderGrid_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == true)
            {
                fillGrid();
            }
        }
    }
}
