namespace WindowsFormsApp1.Views.Warehouse_M_Module
{
    partial class TypeWarehouseMain
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.select_products = new MetroFramework.Controls.MetroTile();
            this.select_materials = new MetroFramework.Controls.MetroTile();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.uC_MaterialTypeWarehouse1 = new WindowsFormsApp1.Views.Warehouse_M_Module.UC_MaterialTypeWarehouse();
            this.uC_ProductTypeWarehouse1 = new WindowsFormsApp1.Views.Warehouse_M_Module.UC_ProductTypeWarehouse();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel1.Controls.Add(this.select_products);
            this.metroPanel1.Controls.Add(this.select_materials);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(766, 72);
            this.metroPanel1.TabIndex = 43;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // select_products
            // 
            this.select_products.ActiveControl = null;
            this.select_products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.select_products.Location = new System.Drawing.Point(3, 3);
            this.select_products.Name = "select_products";
            this.select_products.Size = new System.Drawing.Size(177, 62);
            this.select_products.TabIndex = 40;
            this.select_products.Text = "Productos";
            this.select_products.TileImage = global::WindowsFormsApp1.Properties.Resources.Shopping_Cart_40px;
            this.select_products.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.select_products.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.select_products.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.select_products.UseCustomBackColor = true;
            this.select_products.UseSelectable = true;
            this.select_products.UseTileImage = true;
            this.select_products.Click += new System.EventHandler(this.select_products_Click);
            // 
            // select_materials
            // 
            this.select_materials.ActiveControl = null;
            this.select_materials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.select_materials.Location = new System.Drawing.Point(205, 3);
            this.select_materials.Name = "select_materials";
            this.select_materials.Size = new System.Drawing.Size(177, 62);
            this.select_materials.TabIndex = 41;
            this.select_materials.Text = "Materiales";
            this.select_materials.TileImage = global::WindowsFormsApp1.Properties.Resources.Cash_Register_40px;
            this.select_materials.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.select_materials.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.select_materials.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.select_materials.UseCustomBackColor = true;
            this.select_materials.UseSelectable = true;
            this.select_materials.UseTileImage = true;
            this.select_materials.Click += new System.EventHandler(this.select_materials_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.uC_ProductTypeWarehouse1);
            this.metroPanel2.Controls.Add(this.uC_MaterialTypeWarehouse1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(6, 81);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(763, 542);
            this.metroPanel2.TabIndex = 44;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // uC_MaterialTypeWarehouse1
            // 
            this.uC_MaterialTypeWarehouse1.AutoSize = true;
            this.uC_MaterialTypeWarehouse1.Location = new System.Drawing.Point(3, 3);
            this.uC_MaterialTypeWarehouse1.Name = "uC_MaterialTypeWarehouse1";
            this.uC_MaterialTypeWarehouse1.Size = new System.Drawing.Size(757, 1155);
            this.uC_MaterialTypeWarehouse1.TabIndex = 45;
            this.uC_MaterialTypeWarehouse1.UseSelectable = true;
            // 
            // uC_ProductTypeWarehouse1
            // 
            this.uC_ProductTypeWarehouse1.BackColor = System.Drawing.Color.White;
            this.uC_ProductTypeWarehouse1.Location = new System.Drawing.Point(0, 0);
            this.uC_ProductTypeWarehouse1.Name = "uC_ProductTypeWarehouse1";
            this.uC_ProductTypeWarehouse1.Size = new System.Drawing.Size(552, 862);
            this.uC_ProductTypeWarehouse1.TabIndex = 46;
            this.uC_ProductTypeWarehouse1.UseSelectable = true;
            // 
            // TypeWarehouseMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "TypeWarehouseMain";
            this.Size = new System.Drawing.Size(769, 722);
            this.Load += new System.EventHandler(this.TypeWarehouseMain_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile select_products;
        private MetroFramework.Controls.MetroTile select_materials;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private UC_MaterialTypeWarehouse uC_MaterialTypeWarehouse1;
        private UC_ProductTypeWarehouse uC_ProductTypeWarehouse1;
    }
}
