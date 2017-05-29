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
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1.Views.Warehouse_Module
{
    public partial class ProductMovementLine : Form
    {
        Models.ProductMovementLine line;
        public ProductMovementLine(ref Models.ProductMovementLine line)
        {
            InitializeComponent();
            txt_Quantity.Text = "0";
            this.line = line;
        }        
    }
}
