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
            this.sales = new MetroFramework.Controls.MetroTile();
            this.invoice = new MetroFramework.Controls.MetroTile();
            this.register = new MetroFramework.Controls.MetroTile();
            this.devolution = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // sales
            // 
            this.sales.BackColor = System.Drawing.Color.DarkGreen;
            this.sales.CustomBackground = true;
            this.sales.Location = new System.Drawing.Point(372, 67);
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(177, 81);
            this.sales.TabIndex = 39;
            this.sales.Text = "Ventas";
            this.sales.TileImage = global::WindowsFormsApp1.Properties.Resources.Cash_Register_40px;
            this.sales.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sales.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.sales.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.sales.UseTileImage = true;
            // 
            // invoice
            // 
            this.invoice.BackColor = System.Drawing.Color.Gold;
            this.invoice.CustomBackground = true;
            this.invoice.Location = new System.Drawing.Point(372, 183);
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(177, 81);
            this.invoice.TabIndex = 40;
            this.invoice.Text = "Generar Facturas";
            this.invoice.TileImage = global::WindowsFormsApp1.Properties.Resources.Documents_40px;
            this.invoice.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.invoice.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.invoice.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.invoice.UseTileImage = true;
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.DarkBlue;
            this.register.CustomBackground = true;
            this.register.Location = new System.Drawing.Point(152, 67);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(177, 81);
            this.register.TabIndex = 38;
            this.register.Text = "Registrar";
            this.register.TileImage = global::WindowsFormsApp1.Properties.Resources.Shopping_Cart_40px;
            this.register.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.register.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.register.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.register.UseTileImage = true;
            // 
            // devolution
            // 
            this.devolution.BackColor = System.Drawing.Color.Firebrick;
            this.devolution.CustomBackground = true;
            this.devolution.Location = new System.Drawing.Point(152, 183);
            this.devolution.Name = "devolution";
            this.devolution.PaintTileCount = false;
            this.devolution.Size = new System.Drawing.Size(177, 81);
            this.devolution.TabIndex = 37;
            this.devolution.Text = "Devoluciones";
            this.devolution.TileImage = global::WindowsFormsApp1.Properties.Resources.Undo_40px;
            this.devolution.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.devolution.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.devolution.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.devolution.UseTileImage = true;
            // 
            // UC_SalesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.invoice);
            this.Controls.Add(this.sales);
            this.Controls.Add(this.register);
            this.Controls.Add(this.devolution);
            this.Name = "UC_SalesMain";
            this.Size = new System.Drawing.Size(700, 330);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile invoice;
        private MetroFramework.Controls.MetroTile sales;
        private MetroFramework.Controls.MetroTile register;
        private MetroFramework.Controls.MetroTile devolution;
    }
}
