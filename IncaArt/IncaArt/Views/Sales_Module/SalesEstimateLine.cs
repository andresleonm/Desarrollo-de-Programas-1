﻿using System;
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
    public partial class SalesEstimateLine : Form
    {
        private string user = "dp1admin";
        private string password = "dp1admin";
        private List<Models.SalesEstimateLine> lines;
        private SalesEstimateController sec;
        private ProductsController pc;
        private bool flg = true;

        public SalesEstimateLine(ref List<Models.SalesEstimateLine> lines, string user, string password)
        {
            InitializeComponent();
            sec = new SalesEstimateController(user, password);
            this.lines = lines;
            fillProducts();
        }

        private void SalesEstimateLine_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            List<ProductWarehouseS> warehouses = (List<ProductWarehouseS>)grid_products.DataSource;
            int i = 0;
            foreach (ProductWarehouseS warehouse in warehouses)
            {
                if (warehouse.selected)
                    lines.Add(new Models.SalesEstimateLine(warehouse));
                i++;
            }
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var product = ((Product)this.cbo_Product.SelectedItem).Id;
            List<ProductWarehouseS> warehouses = (List<ProductWarehouseS>)sec.getWarehousesS(product, '0').data;
            if (!flg)
                grid_products.DataSource = new List<ProductWarehouseS>();
            else flg = false;
            grid_products.DataSource = warehouses;
            AdjustColumnEstimate();
        }

        public void fillProducts()
        {
            pc = new ProductsController(user, password);
            sec = new SalesEstimateController(user, password);
            List<Models.Product> products = (List<Models.Product>)pc.getProducts().data;
            Models.Product p = new Product();
            p.Name = "Todos";
            p.Id = 0;
            products.Add(p);
            this.cbo_Product.DataSource = products;
            this.cbo_Product.DisplayMember = "name";
            this.cbo_Product.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AdjustColumnEstimate()
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