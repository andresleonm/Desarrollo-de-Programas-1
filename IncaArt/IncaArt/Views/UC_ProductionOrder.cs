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
    public partial class UC_ProductionOrder : UserControl
    {
        public UC_ProductionOrder()
        {
            InitializeComponent();
        }
        
        private bool validate_data()
        {
            bool isCorrect = true;

            return isCorrect;
        }

        private void metroButton_Register_Click(object sender, EventArgs e)
        {
            if (validate_data())
            {
                int numOrder = Int32.Parse(metroTextBox_OrderNumber.Text);
                DateTime begin = metroDateTime_Begin.Value;
                DateTime end = metroDateTime_End.Value;
                string description = metroTextBox_Description.Text;
                string observations = metroTextBox_Observation.Text;
                string status = "Created";
                Models.ProductionOrder productionOrder = new Models.ProductionOrder(description,observations,begin,end,status);

                List<Models.ProductionOrderProductLine> productLines = new List<Models.ProductionOrderProductLine>();
                List<Models.ProductionOrderWorkLine> workLines = new List<Models.ProductionOrderWorkLine>();

            }
        }
    }
}
