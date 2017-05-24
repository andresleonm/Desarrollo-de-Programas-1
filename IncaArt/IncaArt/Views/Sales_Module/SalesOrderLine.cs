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
            dud_Quantity.Text = "0";
            line = sl;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_Product.SelectedItem.Equals("Cerámico"))
            {
                txt_UnitPrice.Text = "5.00";
            }else if (cbo_Product.SelectedItem.Equals("Retablo"))
            {
                txt_UnitPrice.Text = "7.00";
            }else if (cbo_Product.SelectedItem.Equals("Piedra Tallada"))
            {
                txt_UnitPrice.Text = "10.00";
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void line_register_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(dud_Quantity.Text) || String.IsNullOrWhiteSpace(cbo_Product.Text) || String.IsNullOrWhiteSpace(txt_UnitPrice.Text))
            {
                MessageBox.Show(this, "Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show(this, "¿Está seguro que desea realizar esta operación?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Models.Product product = new Models.Product();
                    int quantity = int.Parse(this.dud_Quantity.Text);
                    string description = this.txt_Description.Text;
                    double price = double.Parse(this.txt_UnitPrice.Text);
                    line.Product = product;
                    line.Description = description;
                    line.Quantity = quantity;
                    line.Unit_price = price;
                    //line = new Models.SalesOrderLine(product, description, quantity, price);
                    this.Close();
                }
            }
        }
    }
}
