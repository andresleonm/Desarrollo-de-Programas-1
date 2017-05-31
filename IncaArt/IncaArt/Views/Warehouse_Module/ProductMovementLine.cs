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
        List<Models.ProductMovementLine> lines;
        string user;
        string password;
        ProductsController pc;
        ProductMovementDetailController dc;
        bool flg = true;
        public void fillProducts()
        {
            pc = new ProductsController(user, password);
            dc = new ProductMovementDetailController(user, password);
            List<Models.Product> products = (List<Models.Product>)pc.getProducts().data;
            Models.Product p = new Product();
            p.Name = "Todos";
            p.Id = 0;
            products.Add(p);
            this.products.DataSource = products;
            this.products.DisplayMember = "name";
            this.products.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public ProductMovementLine(ref List<Models.ProductMovementLine> lines,string user,string password)
        {
            InitializeComponent();
            this.lines = lines;
            this.user = user;
            this.password = password;
            fillProducts();
        }

        private void ProductMovementLine_Load(object sender, EventArgs e)
        {

        }
        private void AdjustColumnOrder()
        {
            
            grid_products.Columns["product"].DisplayIndex = 0;
            grid_products.Columns["unit"].DisplayIndex = 1;
            grid_products.Columns["warehouse"].DisplayIndex = 2;
            grid_products.Columns["stockF"].DisplayIndex = 3;
            grid_products.Columns["stockL"].DisplayIndex = 4;
            grid_products.Columns["capacity"].DisplayIndex = 5;
            grid_products.Columns["quantity"].DisplayIndex = 6;
            grid_products.Columns["select"].DisplayIndex = 7;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var product = ((Product)this.products.SelectedItem).Id;
            List<ProductWarehouseM> warehouses = (List<ProductWarehouseM>)dc.getWarehouses(product).data;
            if (!flg)
                grid_products.DataSource = new List<ProductWarehouseM>();
            else flg = false;
            grid_products.DataSource = warehouses;
            AdjustColumnOrder();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            List<ProductWarehouseM> warehouses = (List<ProductWarehouseM>)grid_products.DataSource;
            int i = 0;
            foreach (ProductWarehouseM warehouse in warehouses)
            {                
                if (warehouse.selected)
                {
                    lines.Add(new Models.ProductMovementLine(user,password,warehouse, i + 1));
                }
                i++;
            }
            this.Close();

        }
    }
}
