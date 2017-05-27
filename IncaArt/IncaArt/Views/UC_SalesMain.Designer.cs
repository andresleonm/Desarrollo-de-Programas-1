namespace WindowsFormsApp1.Views
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
            this.register_order = new MetroFramework.Controls.MetroTile();
            this.invoice = new MetroFramework.Controls.MetroTile();
            this.orders = new MetroFramework.Controls.MetroTile();
            this.refund = new MetroFramework.Controls.MetroTile();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_SalesOrder1 = new WindowsFormsApp1.Views.UC_SalesOrder();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.register_order);
            this.panel1.Controls.Add(this.invoice);
            this.panel1.Controls.Add(this.orders);
            this.panel1.Controls.Add(this.refund);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 70);
            this.panel1.TabIndex = 41;
            // 
            // register_order
            // 
            this.register_order.ActiveControl = null;
            this.register_order.BackColor = System.Drawing.Color.DarkCyan;
            this.register_order.Location = new System.Drawing.Point(252, 3);
            this.register_order.Name = "register_order";
            this.register_order.Size = new System.Drawing.Size(177, 62);
            this.register_order.TabIndex = 38;
            this.register_order.Text = "Registrar Pedido";
            this.register_order.TileImage = global::WindowsFormsApp1.Properties.Resources.Shopping_Cart_40px;
            this.register_order.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.register_order.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.register_order.UseCustomBackColor = true;
            this.register_order.UseSelectable = true;
            this.register_order.UseTileImage = true;
            this.register_order.Click += new System.EventHandler(this.register_order_Click);
            // 
            // invoice
            // 
            this.invoice.ActiveControl = null;
            this.invoice.BackColor = System.Drawing.Color.DarkCyan;
            this.invoice.Location = new System.Drawing.Point(688, 3);
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(177, 62);
            this.invoice.TabIndex = 40;
            this.invoice.Text = "Generar Facturas";
            this.invoice.TileImage = global::WindowsFormsApp1.Properties.Resources.Documents_40px;
            this.invoice.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.invoice.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.invoice.UseCustomBackColor = true;
            this.invoice.UseSelectable = true;
            this.invoice.UseTileImage = true;
            // 
            // orders
            // 
            this.orders.ActiveControl = null;
            this.orders.BackColor = System.Drawing.Color.DarkCyan;
            this.orders.Location = new System.Drawing.Point(32, 3);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(177, 62);
            this.orders.TabIndex = 39;
            this.orders.Text = "Pedidos";
            this.orders.TileImage = global::WindowsFormsApp1.Properties.Resources.Cash_Register_40px;
            this.orders.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.orders.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.orders.UseCustomBackColor = true;
            this.orders.UseSelectable = true;
            this.orders.UseTileImage = true;
            this.orders.Click += new System.EventHandler(this.orders_Click);
            // 
            // refund
            // 
            this.refund.ActiveControl = null;
            this.refund.BackColor = System.Drawing.Color.DarkCyan;
            this.refund.Location = new System.Drawing.Point(474, 3);
            this.refund.Name = "refund";
            this.refund.PaintTileCount = false;
            this.refund.Size = new System.Drawing.Size(177, 62);
            this.refund.TabIndex = 37;
            this.refund.Text = "Devoluciones";
            this.refund.TileImage = global::WindowsFormsApp1.Properties.Resources.Undo_40px;
            this.refund.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.refund.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.refund.UseCustomBackColor = true;
            this.refund.UseSelectable = true;
            this.refund.UseTileImage = true;
            this.refund.Click += new System.EventHandler(this.refund_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_SalesOrder1);
            this.panel2.Location = new System.Drawing.Point(3, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 618);
            this.panel2.TabIndex = 42;
            // 
            // uC_SalesOrder1
            // 
            this.uC_SalesOrder1.BackColor = System.Drawing.Color.White;
            this.uC_SalesOrder1.Location = new System.Drawing.Point(1, 1);
            this.uC_SalesOrder1.Name = "uC_SalesOrder1";
            this.uC_SalesOrder1.Size = new System.Drawing.Size(872, 592);
            this.uC_SalesOrder1.Style = MetroFramework.MetroColorStyle.Blue;
            this.uC_SalesOrder1.TabIndex = 0;
            this.uC_SalesOrder1.UseSelectable = true;
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
            this.Size = new System.Drawing.Size(900, 700);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile invoice;
        private MetroFramework.Controls.MetroTile orders;
        private MetroFramework.Controls.MetroTile register_order;
        private MetroFramework.Controls.MetroTile refund;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private UC_SalesOrder uC_SalesOrder1;
    }
}
