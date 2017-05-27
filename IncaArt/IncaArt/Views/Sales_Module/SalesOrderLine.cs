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

namespace WindowsFormsApp1.Views.Sales_Module
{
    public partial class SalesOrderLine : Form
    {
        Models.SalesOrderLine line;
        private List<Product> products;
        private List<UnitOfMeasure> units;

        public SalesOrderLine(ref Models.SalesOrderLine sales)
        {
            InitializeComponent();
            txt_Quantity.Text = "0";
            line = sales;
        }

        private void SalesOrderLine_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            string user = "dp1admin";
            string password = "dp1admin";

            // ComboBox
            ProductsController product_controller = new ProductsController(user, password);
            UnitController unit_controller = new UnitController(user, password);

            Result result = product_controller.getProducts();
            this.products = (List<Product>)result.data;

            result = unit_controller.getUnits();
            this.units = (List<UnitOfMeasure>)result.data;

            foreach (Product prod in products)
            {
                this.cbo_Product.Items.Add(prod.Name);
            }
            //this.cbo_Product.SelectedItem = this.cbo_Product.Items[0];

            foreach (UnitOfMeasure unit in units)
            {
                this.cbo_UnitMeasure.Items.Add(unit.Name);
            }
            //this.cbo_UnitMeasure.SelectedItem = this.cbo_UnitMeasure.Items[0];


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

        private void cbo_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_UnitPrice.Text = Math.Round(products.ElementAt(cbo_Product.SelectedIndex).Unit_price,2).ToString();
        }
    }
}
