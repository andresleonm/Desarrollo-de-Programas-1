using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views.Production_Module
{
    public partial class UC_ProductionMenu : UserControl
    {
        public UC_ProductionMenu()
        {
            InitializeComponent();
        }

        private void metroTile_RegisterOrder_Click(object sender, EventArgs e)
        {
            production_register.Visible = true;
            production_search.Visible = false;
        }

        private void metroTitle_SearchOrder_Click(object sender, EventArgs e)
        {
            production_register.Visible = false;
            production_search.Visible = true;
        }
    }
}
