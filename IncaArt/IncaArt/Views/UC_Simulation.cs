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
    public partial class UC_Simulation : UserControl
    {
        public UC_Simulation()
        {
            InitializeComponent();
        }

        private void btn_purchase_orders_Click(object sender, EventArgs e)
        {
            uC_SimulationConfig2.Visible = true;
            uC_SimulationExecution1.Visible = false;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            uC_SimulationExecution1.Visible = true;
            uC_SimulationConfig2.Visible = false;

            //Algorithm.TabuSearch tabu = new Algorithm.TabuSearch();
        }        
    }
}
