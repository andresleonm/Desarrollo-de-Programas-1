namespace WindowsFormsApp1.Views.Purchase_Module
{
    partial class UC_PurchasesMain
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Estimates = new MetroFramework.Controls.MetroTile();
            this.uC_SalesEstimate1 = new WindowsFormsApp1.Views.Purchase_Module.UC_PurchaseOrder();
            this.uC_SalesRefund1 = new WindowsFormsApp1.Views.Sales_Module.UC_SalesRefund();
            this.uC_SalesDocument2 = new WindowsFormsApp1.Views.Sales_Module.UC_SalesDocument();
            this.uC_SalesOrder2 = new WindowsFormsApp1.Views.UC_SalesOrder();
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Estimates);
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
            this.btn_Estimates.Text = "Ordenes de Compra";
            this.btn_Estimates.TileImage = global::WindowsFormsApp1.Properties.Resources.Coins_48px;
            this.btn_Estimates.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Estimates.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_Estimates.UseCustomBackColor = true;
            this.btn_Estimates.UseSelectable = true;
            this.btn_Estimates.UseTileImage = true;
            this.btn_Estimates.Click += new System.EventHandler(this.btn_Estimates_Click);
            // 
            // uC_SalesEstimate1
            // 
            this.uC_SalesEstimate1.BackColor = System.Drawing.Color.White;
            this.uC_SalesEstimate1.Location = new System.Drawing.Point(0, 3);
            this.uC_SalesEstimate1.Name = "uC_SalesEstimate1";
            this.uC_SalesEstimate1.Size = new System.Drawing.Size(875, 615);
            this.uC_SalesEstimate1.TabIndex = 3;
            this.uC_SalesEstimate1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uC_SalesEstimate1.UseCustomBackColor = true;
            this.uC_SalesEstimate1.UseSelectable = true;
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
            // UC_PurchasesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "UC_PurchasesMain";
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
        private Purchase_Module.UC_PurchaseOrder uC_SalesEstimate1;
        private Sales_Module.UC_SalesRefund uC_SalesRefund1;
        private Sales_Module.UC_SalesDocument uC_SalesDocument2;
        private UC_SalesOrder uC_SalesOrder2;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroTile btn_Estimates;
    }
}
