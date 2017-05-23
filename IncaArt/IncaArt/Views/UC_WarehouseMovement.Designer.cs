namespace WindowsFormsApp1.Views
{
    partial class UC_WarehouseMovement
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.register_sale = new MetroFramework.Controls.MetroTile();
            this.sales = new MetroFramework.Controls.MetroTile();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UC_WarehouseMovementP = new WindowsFormsApp1.Views.UC_WarehouseMovementP();
            this.UC_WarehouseMovementM = new WindowsFormsApp1.Views.UC_WarehouseMovementM();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // register_sale
            // 
            this.register_sale.BackColor = System.Drawing.Color.DarkBlue;
            this.register_sale.CustomBackground = true;
            this.register_sale.Location = new System.Drawing.Point(31, 3);
            this.register_sale.Name = "register_sale";
            this.register_sale.Size = new System.Drawing.Size(177, 62);
            this.register_sale.TabIndex = 38;
            this.register_sale.Text = "Productos";
            this.register_sale.TileImage = global::WindowsFormsApp1.Properties.Resources.Shopping_Cart_40px;
            this.register_sale.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.register_sale.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.register_sale.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.register_sale.UseTileImage = true;
            this.register_sale.Click += new System.EventHandler(this.register_sale_Click_1);
            // 
            // sales
            // 
            this.sales.BackColor = System.Drawing.Color.DarkGreen;
            this.sales.CustomBackground = true;
            this.sales.Location = new System.Drawing.Point(250, 3);
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(177, 62);
            this.sales.TabIndex = 39;
            this.sales.Text = "Materiales";
            this.sales.TileImage = global::WindowsFormsApp1.Properties.Resources.Cash_Register_40px;
            this.sales.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sales.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.sales.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.sales.UseTileImage = true;
            this.sales.Click += new System.EventHandler(this.sales_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.register_sale);
            this.panel1.Controls.Add(this.sales);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 70);
            this.panel1.TabIndex = 42;
            // 
            // UC_WarehouseMovementP
            // 
            this.UC_WarehouseMovementP.BackColor = System.Drawing.SystemColors.Control;
            this.UC_WarehouseMovementP.Location = new System.Drawing.Point(0, 79);
            this.UC_WarehouseMovementP.Name = "UC_WarehouseMovementP";
            this.UC_WarehouseMovementP.Size = new System.Drawing.Size(1093, 490);
            this.UC_WarehouseMovementP.TabIndex = 43;
            // 
            // UC_WarehouseMovementM
            // 
            this.UC_WarehouseMovementM.BackColor = System.Drawing.SystemColors.Control;
            this.UC_WarehouseMovementM.Location = new System.Drawing.Point(0, 79);
            this.UC_WarehouseMovementM.Name = "UC_WarehouseMovementM";
            this.UC_WarehouseMovementM.Size = new System.Drawing.Size(1093, 490);
            this.UC_WarehouseMovementM.TabIndex = 43;
            // 
            // UC_WarehouseMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UC_WarehouseMovementP);
            this.Controls.Add(this.UC_WarehouseMovementM);
            this.Controls.Add(this.panel1);
            this.Name = "UC_WarehouseMovement";
            this.Size = new System.Drawing.Size(1096, 572);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile register_sale;
        private MetroFramework.Controls.MetroTile sales;
        private System.Windows.Forms.Panel panel1;
        private UC_WarehouseMovementP UC_WarehouseMovementP;
        private UC_WarehouseMovementM UC_WarehouseMovementM;
    }
}
