namespace WindowsFormsApp1.Views.MovementsType_Module
{
    partial class UC_MovementsType
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_ProductMovementsType1 = new WindowsFormsApp1.Views.MovementsType_Module.UC_ProductMovementsType();
            this.uC_MaterialMovementsType1 = new WindowsFormsApp1.Views.MovementsType_Module.UC_MaterialMovementsType();
            this.metroPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.metroPanel1.Size = new System.Drawing.Size(594, 72);
            this.metroPanel1.TabIndex = 44;
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
            this.select_materials.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.select_materials.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.select_materials.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.select_materials.UseCustomBackColor = true;
            this.select_materials.UseSelectable = true;
            this.select_materials.UseTileImage = true;
            this.select_materials.Click += new System.EventHandler(this.select_materials_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.uC_ProductMovementsType1);
            this.panel1.Controls.Add(this.uC_MaterialMovementsType1);
            this.panel1.Location = new System.Drawing.Point(4, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 650);
            this.panel1.TabIndex = 45;
            // 
            // uC_ProductMovementsType1
            // 
            this.uC_ProductMovementsType1.Location = new System.Drawing.Point(3, 0);
            this.uC_ProductMovementsType1.Name = "uC_ProductMovementsType1";
            this.uC_ProductMovementsType1.Size = new System.Drawing.Size(531, 643);
            this.uC_ProductMovementsType1.TabIndex = 1;
            this.uC_ProductMovementsType1.UseSelectable = true;
            // 
            // uC_MaterialMovementsType1
            // 
            this.uC_MaterialMovementsType1.Location = new System.Drawing.Point(3, 0);
            this.uC_MaterialMovementsType1.Name = "uC_MaterialMovementsType1";
            this.uC_MaterialMovementsType1.Size = new System.Drawing.Size(546, 645);
            this.uC_MaterialMovementsType1.TabIndex = 0;
            this.uC_MaterialMovementsType1.UseSelectable = true;
            // 
            // UC_MovementsType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "UC_MovementsType";
            this.Size = new System.Drawing.Size(597, 735);
            this.Load += new System.EventHandler(this.UC_MovementsType_Load);
            this.metroPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile select_products;
        private MetroFramework.Controls.MetroTile select_materials;
        private System.Windows.Forms.Panel panel1;
        private UC_MaterialMovementsType uC_MaterialMovementsType1;
        private UC_ProductMovementsType uC_ProductMovementsType1;
    }
}
