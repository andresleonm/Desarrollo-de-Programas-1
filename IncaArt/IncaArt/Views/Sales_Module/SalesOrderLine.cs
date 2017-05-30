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
        private List<ProductWarehouse> prod_warehouses;
        private string user = "dp1admin";
        private string password = "dp1admin";

        public SalesOrderLine(ref Models.SalesOrderLine sales)
        {
            InitializeComponent();
            txt_Quantity.Text = "0";
            line = sales;
        }

        private void SalesOrderLine_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            cbo_Warehouse.Enabled = false;

            // ComboBox
            ProductsController product_controller = new ProductsController(user, password);
            
            Result result = product_controller.getProducts();
            this.products = (List<Product>)result.data;
            
            foreach (Product prod in products)
            {
                this.cbo_Product.Items.Add(prod.Name);
            }
            //this.cbo_Product.SelectedItem = this.cbo_Product.Items[0];

        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_Quantity.Text) || String.IsNullOrWhiteSpace(cbo_Product.Text) || String.IsNullOrWhiteSpace(txt_UnitMeasure.Text) || String.IsNullOrWhiteSpace(cbo_Warehouse.Text))
            {
                MessageBox.Show(this, "Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show(this, "¿Está seguro que desea realizar esta operación?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    //line.Unit_measure = ;
                    line.Quantity = int.Parse(this.txt_Quantity.Text);
                    line.Unit_price = double.Parse(this.txt_UnitMeasure.Text);
                    line.Status = "Active";
                    line.Delivery_quantity = 0;
                    line.Product = products.ElementAt(cbo_Product.SelectedIndex);
                    line.Prod_warehouse = prod_warehouses.ElementAt(cbo_Warehouse.SelectedIndex);
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
            txt_UnitMeasure.Text = Math.Round(products.ElementAt(cbo_Product.SelectedIndex).Unit_price,2).ToString();
            txt_UnitMeasure.Text = products.ElementAt(cbo_Product.SelectedIndex).Unit_id.ToString();
            cbo_Warehouse.Enabled = true;
            cbo_Warehouse.Text = "";
            cbo_Warehouse.Items.Clear();

            ProductWarehouseController prod_warehouse_controller = new ProductWarehouseController(user, password);
            int id_product = products.ElementAt(cbo_Product.SelectedIndex).Id;
            Result result = prod_warehouse_controller.getProductWarehouses_by_idProduct(id_product, '0');
            this.prod_warehouses = (List<ProductWarehouse>)result.data;

            foreach (ProductWarehouse prod_ware in prod_warehouses)
            {
                this.cbo_Warehouse.Items.Add(prod_ware.Name);
            }
            //this.cbo_Warehouse.SelectedItem = this.cbo_Warehouse.Items[0];
        }
    }
}
