using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views.Sales_Module
{
    public partial class SalesOrderLine : Form
    {
        Models.SalesOrderLine line;
        public SalesOrderLine(Models.SalesOrderLine sl)
        {
            InitializeComponent();
            txt_Quantity.Text = "0";
            line = sl;
        }

        private void SalesOrderLine_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_Quantity.Text) || String.IsNullOrWhiteSpace(txt_DeliverQuan.Text) || String.IsNullOrWhiteSpace(cbo_Product.Text) || String.IsNullOrWhiteSpace(cbo_UnitMeasure.Text) || String.IsNullOrWhiteSpace(cbo_Warehouse.Text))
            {
                MessageBox.Show(this, "Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show(this, "¿Está seguro que desea realizar esta operación?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Models.Product product = new Models.Product();
                    int quantity = int.Parse(this.txt_Quantity.Text);
                    int deliver_quantity = int.Parse(this.txt_DeliverQuan.Text);
                    double price = double.Parse(this.txt_UnitPrice.Text);
                    line.Product = product;
                    //line.Description = description;
                    line.Quantity = quantity;
                    line.Unit_price = price;
                    //line = new Models.SalesOrderLine(product, description, quantity, price);
                    this.Close();
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
               
    }
}
