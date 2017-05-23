﻿namespace WindowsFormsApp1.Views
{
    partial class UC_SalesMain
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.sales = new MetroFramework.Controls.MetroTile();
            this.invoice = new MetroFramework.Controls.MetroTile();
            this.register_sale = new MetroFramework.Controls.MetroTile();
            this.devolution = new MetroFramework.Controls.MetroTile();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Sales1 = new WindowsFormsApp1.Views.UC_Sales();
            this.uC_SalesOrder1 = new WindowsFormsApp1.Views.UC_SalesOrder();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sales
            // 
            this.sales.BackColor = System.Drawing.Color.DarkGreen;
            this.sales.CustomBackground = true;
            this.sales.Location = new System.Drawing.Point(32, 3);
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(177, 62);
            this.sales.TabIndex = 39;
            this.sales.Text = "Ventas";
            this.sales.TileImage = global::WindowsFormsApp1.Properties.Resources.Cash_Register_40px;
            this.sales.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sales.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.sales.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.sales.UseTileImage = true;
            this.sales.Click += new System.EventHandler(this.sales_Click);
            // 
            // invoice
            // 
            this.invoice.BackColor = System.Drawing.Color.Gold;
            this.invoice.CustomBackground = true;
            this.invoice.Location = new System.Drawing.Point(688, 3);
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(177, 62);
            this.invoice.TabIndex = 40;
            this.invoice.Text = "Generar Facturas";
            this.invoice.TileImage = global::WindowsFormsApp1.Properties.Resources.Documents_40px;
            this.invoice.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.invoice.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.invoice.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.invoice.UseTileImage = true;
            // 
            // register_sale
            // 
            this.register_sale.BackColor = System.Drawing.Color.DarkBlue;
            this.register_sale.CustomBackground = true;
            this.register_sale.Location = new System.Drawing.Point(252, 3);
            this.register_sale.Name = "register_sale";
            this.register_sale.Size = new System.Drawing.Size(177, 62);
            this.register_sale.TabIndex = 38;
            this.register_sale.Text = "Registrar Venta";
            this.register_sale.TileImage = global::WindowsFormsApp1.Properties.Resources.Shopping_Cart_40px;
            this.register_sale.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.register_sale.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.register_sale.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.register_sale.UseTileImage = true;
            this.register_sale.Click += new System.EventHandler(this.register_sale_Click);
            // 
            // devolution
            // 
            this.devolution.BackColor = System.Drawing.Color.Firebrick;
            this.devolution.CustomBackground = true;
            this.devolution.Location = new System.Drawing.Point(474, 3);
            this.devolution.Name = "devolution";
            this.devolution.PaintTileCount = false;
            this.devolution.Size = new System.Drawing.Size(177, 62);
            this.devolution.TabIndex = 37;
            this.devolution.Text = "Devoluciones";
            this.devolution.TileImage = global::WindowsFormsApp1.Properties.Resources.Undo_40px;
            this.devolution.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.devolution.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.devolution.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.devolution.UseTileImage = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.register_sale);
            this.panel1.Controls.Add(this.invoice);
            this.panel1.Controls.Add(this.sales);
            this.panel1.Controls.Add(this.devolution);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 70);
            this.panel1.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_Sales1);
            this.panel2.Controls.Add(this.uC_SalesOrder1);
            this.panel2.Location = new System.Drawing.Point(3, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 618);
            this.panel2.TabIndex = 42;
            // 
            // uC_Sales1
            // 
            this.uC_Sales1.BackColor = System.Drawing.Color.White;
            this.uC_Sales1.Location = new System.Drawing.Point(3, 3);
            this.uC_Sales1.Name = "uC_Sales1";
            this.uC_Sales1.Size = new System.Drawing.Size(900, 600);
            this.uC_Sales1.TabIndex = 1;
            // 
            // uC_SalesOrder1
            // 
            this.uC_SalesOrder1.BackColor = System.Drawing.Color.White;
            this.uC_SalesOrder1.Location = new System.Drawing.Point(3, 3);
            this.uC_SalesOrder1.Name = "uC_SalesOrder1";
            this.uC_SalesOrder1.Size = new System.Drawing.Size(872, 592);
            this.uC_SalesOrder1.TabIndex = 2;
            // 
            // UC_SalesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_SalesMain";
            this.Size = new System.Drawing.Size(900, 700);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile invoice;
        private MetroFramework.Controls.MetroTile sales;
        private MetroFramework.Controls.MetroTile register_sale;
        private MetroFramework.Controls.MetroTile devolution;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private UC_Sales uC_Sales1;
        private UC_SalesOrder uC_SalesOrder1;
    }
}