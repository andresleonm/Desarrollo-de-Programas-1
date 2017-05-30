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
            this.credit_notes = new MetroFramework.Controls.MetroTile();
            this.invoices = new MetroFramework.Controls.MetroTile();
            this.orders = new MetroFramework.Controls.MetroTile();
            this.refunds = new MetroFramework.Controls.MetroTile();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_SalesOrder1 = new WindowsFormsApp1.Views.UC_SalesOrder();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.credit_notes);
            this.panel1.Controls.Add(this.invoices);
            this.panel1.Controls.Add(this.orders);
            this.panel1.Controls.Add(this.refunds);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 73);
            this.panel1.TabIndex = 41;
            // 
            // credit_notes
            // 
            this.credit_notes.ActiveControl = null;
            this.credit_notes.BackColor = System.Drawing.Color.DarkCyan;
            this.credit_notes.Location = new System.Drawing.Point(683, 5);
            this.credit_notes.Name = "credit_notes";
            this.credit_notes.Size = new System.Drawing.Size(177, 62);
            this.credit_notes.TabIndex = 38;
            this.credit_notes.Text = "Notas de Crédito";
            this.credit_notes.TileImage = global::WindowsFormsApp1.Properties.Resources.Shopping_Cart_40px;
            this.credit_notes.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.credit_notes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.credit_notes.UseCustomBackColor = true;
            this.credit_notes.UseSelectable = true;
            this.credit_notes.UseTileImage = true;
            this.credit_notes.Click += new System.EventHandler(this.credit_notes_Click);
            // 
            // invoices
            // 
            this.invoices.ActiveControl = null;
            this.invoices.BackColor = System.Drawing.Color.DarkCyan;
            this.invoices.Location = new System.Drawing.Point(246, 5);
            this.invoices.Name = "invoices";
            this.invoices.Size = new System.Drawing.Size(177, 62);
            this.invoices.TabIndex = 40;
            this.invoices.Text = "Facturas";
            this.invoices.TileImage = global::WindowsFormsApp1.Properties.Resources.Documents_40px;
            this.invoices.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.invoices.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.invoices.UseCustomBackColor = true;
            this.invoices.UseSelectable = true;
            this.invoices.UseTileImage = true;
            this.invoices.Click += new System.EventHandler(this.invoices_Click);
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
            this.refunds.Location = new System.Drawing.Point(464, 5);
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
            this.panel2.Controls.Add(this.uC_SalesOrder1);
            this.panel2.Location = new System.Drawing.Point(3, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 618);
            this.panel2.TabIndex = 42;
            // 
            // uC_SalesOrder1
            // 
            this.uC_SalesOrder1.BackColor = System.Drawing.SystemColors.Control;
            this.uC_SalesOrder1.Location = new System.Drawing.Point(4, 4);
            this.uC_SalesOrder1.Name = "uC_SalesOrder1";
            this.uC_SalesOrder1.Size = new System.Drawing.Size(872, 614);
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
            this.Load += new System.EventHandler(this.UC_SalesMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile invoices;
        private MetroFramework.Controls.MetroTile orders;
        private MetroFramework.Controls.MetroTile credit_notes;
        private MetroFramework.Controls.MetroTile refunds;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private UC_SalesOrder uC_SalesOrder1;
    }
}
