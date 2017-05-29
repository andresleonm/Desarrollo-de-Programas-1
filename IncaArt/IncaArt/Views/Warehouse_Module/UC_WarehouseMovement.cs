using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views.Warehouse_Module
{
    public partial class UC_WarehouseMovement : UserControl
    {
        string user;
        string password;
        public UC_WarehouseMovement(string user,string password)
        {
            InitializeComponent();
            this.user = user;
            this.password = password;
        }

        private void hide_UserControls()
        {
            foreach (UserControl uc in this.Controls.OfType<UserControl>())
            {
                uc.Visible = false;
            }
        }

        private void register_sale_Click_1(object sender, EventArgs e)
        {
            hide_UserControls();
            UC_WarehouseMovementP.Visible = true;
        }

        private void sales_Click(object sender, EventArgs e)
        {
            hide_UserControls();
            UC_WarehouseMovementM.Visible = true;
        }
    }
}
