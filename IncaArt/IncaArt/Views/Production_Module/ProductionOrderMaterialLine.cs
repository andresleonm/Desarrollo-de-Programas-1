using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views.Production_Module
{
    public partial class ProductionOrderMaterialLine : Form
    {
        private Models.ProductionOrderMaterialLine line;
        private bool isRegistered = false;

        internal Models.ProductionOrderMaterialLine Line
        {
            get
            {
                return line;
            }

            set
            {
                line = value;
            }
        }

        public bool IsRegistered
        {
            get
            {
                return isRegistered;
            }

            set
            {
                isRegistered = value;
            }
        }

        public ProductionOrderMaterialLine()
        {
            InitializeComponent();
        }

        private bool validate_data()
        {
            return true;
        }
        private void button_Register_Click(object sender, EventArgs e)
        {
            if (validate_data())
            {
                IsRegistered = true;
                Line.Material = new Models.Material();
                Line.Quantity_required = Int32.Parse(metroTextBox_Quantity.Text);   
                this.Close();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
