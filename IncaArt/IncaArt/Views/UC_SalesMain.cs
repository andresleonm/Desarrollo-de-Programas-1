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
    public partial class UC_SalesMain : UserControl
    {
        public UC_SalesMain()
        {
            InitializeComponent();
        }

        private void register_sale_Click(object sender, EventArgs e)
        {
            uC_SalesOrder1.Visible = true;
        }
    }
}
