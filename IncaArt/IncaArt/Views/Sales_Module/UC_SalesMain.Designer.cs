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
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_SalesEstimate1 = new WindowsFormsApp1.Views.Sales_Module.UC_SalesEstimate();
            this.uC_SalesRefund1 = new WindowsFormsApp1.Views.Sales_Module.UC_SalesRefund();
            this.uC_SalesDocument2 = new WindowsFormsApp1.Views.Sales_Module.UC_SalesDocument();
            this.uC_SalesOrder2 = new WindowsFormsApp1.Views.UC_SalesOrder();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Estimates = new MetroFramework.Controls.MetroTile();
            this.btn_Documents = new MetroFramework.Controls.MetroTile();
            this.btn_Orders = new MetroFramework.Controls.MetroTile();
            this.btn_Refunds = new MetroFramework.Controls.MetroTile();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 700);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.uC_SalesEstimate1);
            this.panel2.Controls.Add(this.uC_SalesRefund1);
            this.panel2.Controls.Add(this.uC_SalesDocument2);
            this.panel2.Controls.Add(this.uC_SalesOrder2);
            this.panel2.Location = new System.Drawing.Point(-2, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 618);
            this.panel2.TabIndex = 44;
            // 
            // uC_SalesEstimate1
            // 
            this.uC_SalesEstimate1.BackColor = System.Drawing.Color.White;
            this.uC_SalesEstimate1.Location = new System.Drawing.Point(0, 3);
            this.uC_SalesEstimate1.Name = "uC_SalesEstimate1";
            this.uC_SalesEstimate1.Size = new System.Drawing.Size(875, 615);
            this.uC_SalesEstimate1.TabIndex = 3;
            // 
            // uC_SalesRefund1
            // 
            this.uC_SalesRefund1.BackColor = System.Drawing.Color.White;
            this.uC_SalesRefund1.Location = new System.Drawing.Point(3, 3);
            this.uC_SalesRefund1.Name = "uC_SalesRefund1";
            this.uC_SalesRefund1.Size = new System.Drawing.Size(1065, 625);
            this.uC_SalesRefund1.TabIndex = 2;
            // 
            // uC_SalesDocument2
            // 
            this.uC_SalesDocument2.BackColor = System.Drawing.Color.White;
            this.uC_SalesDocument2.Location = new System.Drawing.Point(3, 3);
            this.uC_SalesDocument2.Name = "uC_SalesDocument2";
            this.uC_SalesDocument2.Size = new System.Drawing.Size(1062, 626);
            this.uC_SalesDocument2.TabIndex = 1;
            // 
            // uC_SalesOrder2
            // 
            this.uC_SalesOrder2.BackColor = System.Drawing.Color.White;
            this.uC_SalesOrder2.Location = new System.Drawing.Point(3, 3);
            this.uC_SalesOrder2.Name = "uC_SalesOrder2";
            this.uC_SalesOrder2.Size = new System.Drawing.Size(872, 614);
            this.uC_SalesOrder2.Style = MetroFramework.MetroColorStyle.Blue;
            this.uC_SalesOrder2.TabIndex = 0;
            this.uC_SalesOrder2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uC_SalesOrder2.UseCustomBackColor = true;
            this.uC_SalesOrder2.UseSelectable = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Estimates);
            this.panel3.Controls.Add(this.btn_Documents);
            this.panel3.Controls.Add(this.btn_Orders);
            this.panel3.Controls.Add(this.btn_Refunds);
            this.panel3.Location = new System.Drawing.Point(-2, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(894, 73);
            this.panel3.TabIndex = 43;
            // 
            // btn_Estimates
            // 
            this.btn_Estimates.ActiveControl = null;
            this.btn_Estimates.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Estimates.Location = new System.Drawing.Point(18, 5);
            this.btn_Estimates.Name = "btn_Estimates";
            this.btn_Estimates.Size = new System.Drawing.Size(177, 62);
            this.btn_Estimates.TabIndex = 41;
            this.btn_Estimates.Text = "Cotizaciones";
            this.btn_Estimates.TileImage = global::WindowsFormsApp1.Properties.Resources.Coins_48px;
            this.btn_Estimates.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Estimates.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_Estimates.UseCustomBackColor = true;
            this.btn_Estimates.UseSelectable = true;
            this.btn_Estimates.UseTileImage = true;
            this.btn_Estimates.Click += new System.EventHandler(this.btn_Estimates_Click);
            // 
            // btn_Documents
            // 
            this.btn_Documents.ActiveControl = null;
            this.btn_Documents.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Documents.Location = new System.Drawing.Point(469, 5);
            this.btn_Documents.Name = "btn_Documents";
            this.btn_Documents.Size = new System.Drawing.Size(177, 62);
            this.btn_Documents.TabIndex = 40;
            this.btn_Documents.Text = "Documentos";
            this.btn_Documents.TileImage = global::WindowsFormsApp1.Properties.Resources.Documents_40px;
            this.btn_Documents.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Documents.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_Documents.UseCustomBackColor = true;
            this.btn_Documents.UseSelectable = true;
            this.btn_Documents.UseTileImage = true;
            this.btn_Documents.Click += new System.EventHandler(this.btn_Documents_Click);
            // 
            // btn_Orders
            // 
            this.btn_Orders.ActiveControl = null;
            this.btn_Orders.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Orders.Location = new System.Drawing.Point(244, 5);
            this.btn_Orders.Name = "btn_Orders";
            this.btn_Orders.Size = new System.Drawing.Size(177, 62);
            this.btn_Orders.TabIndex = 39;
            this.btn_Orders.Text = "Pedidos";
            this.btn_Orders.TileImage = global::WindowsFormsApp1.Properties.Resources.Shopping_Cart_40px;
            this.btn_Orders.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Orders.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_Orders.UseCustomBackColor = true;
            this.btn_Orders.UseSelectable = true;
            this.btn_Orders.UseTileImage = true;
            this.btn_Orders.Click += new System.EventHandler(this.btn_Orders_Click);
            // 
            // btn_Refunds
            // 
            this.btn_Refunds.ActiveControl = null;
            this.btn_Refunds.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Refunds.Location = new System.Drawing.Point(696, 5);
            this.btn_Refunds.Name = "btn_Refunds";
            this.btn_Refunds.PaintTileCount = false;
            this.btn_Refunds.Size = new System.Drawing.Size(177, 62);
            this.btn_Refunds.TabIndex = 37;
            this.btn_Refunds.Text = "Devoluciones";
            this.btn_Refunds.TileImage = global::WindowsFormsApp1.Properties.Resources.Undo_40px;
            this.btn_Refunds.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Refunds.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_Refunds.UseCustomBackColor = true;
            this.btn_Refunds.UseSelectable = true;
            this.btn_Refunds.UseTileImage = true;
            this.btn_Refunds.Click += new System.EventHandler(this.btn_Refunds_Click);
            // 
            // UC_SalesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "UC_SalesMain";
            this.Size = new System.Drawing.Size(1300, 700);
            this.Load += new System.EventHandler(this.UC_SalesMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Sales_Module.UC_SalesEstimate uC_SalesEstimate1;
        private Sales_Module.UC_SalesRefund uC_SalesRefund1;
        private Sales_Module.UC_SalesDocument uC_SalesDocument2;
        private UC_SalesOrder uC_SalesOrder2;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroTile btn_Estimates;
        private MetroFramework.Controls.MetroTile btn_Documents;
        private MetroFramework.Controls.MetroTile btn_Orders;
        private MetroFramework.Controls.MetroTile btn_Refunds;
    }
}
