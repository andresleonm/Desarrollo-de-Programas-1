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
            this.panel1 = new System.Windows.Forms.Panel();
            this.documents = new MetroFramework.Controls.MetroTile();
            this.orders = new MetroFramework.Controls.MetroTile();
            this.refunds = new MetroFramework.Controls.MetroTile();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_SalesDocument2 = new WindowsFormsApp1.Views.Sales_Module.UC_SalesDocument();
            this.uC_SalesOrder2 = new WindowsFormsApp1.Views.UC_SalesOrder();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.documents);
            this.panel1.Controls.Add(this.orders);
            this.panel1.Controls.Add(this.refunds);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 73);
            this.panel1.TabIndex = 41;
            // 
            // documents
            // 
            this.documents.ActiveControl = null;
            this.documents.BackColor = System.Drawing.Color.DarkCyan;
            this.documents.Location = new System.Drawing.Point(244, 5);
            this.documents.Name = "documents";
            this.documents.Size = new System.Drawing.Size(177, 62);
            this.documents.TabIndex = 40;
            this.documents.Text = "Documentos";
            this.documents.TileImage = global::WindowsFormsApp1.Properties.Resources.Documents_40px;
            this.documents.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.documents.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.documents.UseCustomBackColor = true;
            this.documents.UseSelectable = true;
            this.documents.UseTileImage = true;
            this.documents.Click += new System.EventHandler(this.documents_Click);
            // 
            // orders
            // 
            this.orders.ActiveControl = null;
            this.orders.BackColor = System.Drawing.Color.DarkCyan;
            this.orders.Location = new System.Drawing.Point(19, 5);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(177, 62);
            this.orders.TabIndex = 39;
            this.orders.Text = "Pedidos";
            this.orders.TileImage = global::WindowsFormsApp1.Properties.Resources.Shopping_Cart_40px;
            this.orders.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.orders.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.orders.UseCustomBackColor = true;
            this.orders.UseSelectable = true;
            this.orders.UseTileImage = true;
            this.orders.Click += new System.EventHandler(this.orders_Click);
            // 
            // refunds
            // 
            this.refunds.ActiveControl = null;
            this.refunds.BackColor = System.Drawing.Color.DarkCyan;
            this.refunds.Location = new System.Drawing.Point(471, 5);
            this.refunds.Name = "refunds";
            this.refunds.PaintTileCount = false;
            this.refunds.Size = new System.Drawing.Size(177, 62);
            this.refunds.TabIndex = 37;
            this.refunds.Text = "Devoluciones";
            this.refunds.TileImage = global::WindowsFormsApp1.Properties.Resources.Undo_40px;
            this.refunds.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.refunds.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.refunds.UseCustomBackColor = true;
            this.refunds.UseSelectable = true;
            this.refunds.UseTileImage = true;
            this.refunds.Click += new System.EventHandler(this.refunds_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.uC_SalesDocument2);
            this.panel2.Controls.Add(this.uC_SalesOrder2);
            this.panel2.Location = new System.Drawing.Point(3, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 618);
            this.panel2.TabIndex = 42;
            // 
            // uC_SalesDocument2
            // 
            this.uC_SalesDocument2.Location = new System.Drawing.Point(4, 4);
            this.uC_SalesDocument2.Name = "uC_SalesDocument2";
            this.uC_SalesDocument2.Size = new System.Drawing.Size(1062, 626);
            this.uC_SalesDocument2.TabIndex = 1;
            // 
            // uC_SalesOrder2
            // 
            this.uC_SalesOrder2.BackColor = System.Drawing.SystemColors.Control;
            this.uC_SalesOrder2.Location = new System.Drawing.Point(4, 4);
            this.uC_SalesOrder2.Name = "uC_SalesOrder2";
            this.uC_SalesOrder2.Size = new System.Drawing.Size(872, 614);
            this.uC_SalesOrder2.Style = MetroFramework.MetroColorStyle.Blue;
            this.uC_SalesOrder2.TabIndex = 0;
            this.uC_SalesOrder2.UseSelectable = true;
            // 
            // UC_SalesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "UC_SalesMain";
            this.Size = new System.Drawing.Size(1072, 700);
            this.Load += new System.EventHandler(this.UC_SalesMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile documents;
        private MetroFramework.Controls.MetroTile orders;
        private MetroFramework.Controls.MetroTile refunds;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Sales_Module.UC_SalesDocument uC_SalesDocument2;
        private UC_SalesOrder uC_SalesOrder2;
    }
}
