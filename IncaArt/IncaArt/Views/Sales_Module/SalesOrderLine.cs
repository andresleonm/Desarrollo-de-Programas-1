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
        private string user = "dp1admin";
        private string password = "dp1admin";
        ProductMovementDetailController dc;
        ProductsController pc;
        bool flg = true;

        public SalesOrderLine(ref Models.SalesOrderLine sales)
        {
            InitializeComponent();            
            line = sales;
            dc = new ProductMovementDetailController(user, password);
            fillProducts();
        }

        private void SalesOrderLine_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;    
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cbo_Product.Text) )
            {
                MessageBox.Show(this, "Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show(this, "¿Está seguro que desea realizar esta operación?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    //line.Unit_measure = ;
                    //line.Quantity = int.Parse(this.txt_Quantity.Text);
                    //line.Unit_price = double.Parse(this.txt_UnitMeasure.Text);
                    //line.Status = "Active";
                    //line.Delivery_quantity = 0;
                    //line.Product = products.ElementAt(cbo_Product.SelectedIndex);
                    //line.Prod_warehouse = prod_warehouses.ElementAt(cbo_Warehouse.SelectedIndex);
                    this.Close();
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var product = ((Product)this.cbo_Product.SelectedItem).Id;
            List<ProductWarehouseS> warehouses = (List<ProductWarehouseS>)dc.getWarehousesS(product).data;
            if (!flg)
                grid_products.DataSource = new List<ProductWarehouseS>();
            else flg = false;
            grid_products.DataSource = warehouses;
            AdjustColumnOrder();

        }

        public void fillProducts()
        {
            pc = new ProductsController(user, password);
            dc = new ProductMovementDetailController(user, password);
            List<Models.Product> products = (List<Models.Product>)pc.getProducts().data;
            Models.Product p = new Product();
            p.Name = "Todos";
            p.Id = 0;
            products.Add(p);
            this.cbo_Product.DataSource = products;
            this.cbo_Product.DisplayMember = "name";
            this.cbo_Product.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AdjustColumnOrder()
        {
            grid_products.Columns["product"].DisplayIndex = 0;
            grid_products.Columns["unit"].DisplayIndex = 1;
            grid_products.Columns["warehouse"].DisplayIndex = 2;
            grid_products.Columns["stockL"].DisplayIndex = 3;
            grid_products.Columns["quantity"].DisplayIndex = 4;
            grid_products.Columns["unit_price"].DisplayIndex = 5;
            grid_products.Columns["select"].DisplayIndex = 6;
        }

    }
}
