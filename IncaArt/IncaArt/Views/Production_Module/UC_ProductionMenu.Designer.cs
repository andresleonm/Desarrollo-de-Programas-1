namespace WindowsFormsApp1.Views.Production_Module
{
    partial class UC_ProductionMenu
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
            this.production_search = new WindowsFormsApp1.Views.UC_ProductionOrderSearch();
            this.production_register = new WindowsFormsApp1.Views.UC_ProductionOrder();
            this.worker_performance = new WindowsFormsApp1.Views.WorkersPerformance_Report();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroTile_RegisterOrder = new MetroFramework.Controls.MetroTile();
            this.metroTitle_SearchOrder = new MetroFramework.Controls.MetroTile();
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
            this.panel1.Size = new System.Drawing.Size(1265, 650);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.production_search);
            this.panel2.Controls.Add(this.production_register);
            this.panel2.Controls.Add(this.worker_performance);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1265, 580);
            this.panel2.TabIndex = 4;
            // 
            // production_search
            // 
            this.production_search.BackColor = System.Drawing.Color.White;
            this.production_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.production_search.Location = new System.Drawing.Point(0, 0);
            this.production_search.Name = "production_search";
            this.production_search.Size = new System.Drawing.Size(1265, 580);
            this.production_search.TabIndex = 0;
            this.production_search.UseSelectable = true;
            // 
            // production_register
            // 
            this.production_register.BackColor = System.Drawing.Color.White;
            this.production_register.Dock = System.Windows.Forms.DockStyle.Fill;
            this.production_register.Location = new System.Drawing.Point(0, 0);
            this.production_register.Name = "production_register";
            this.production_register.Size = new System.Drawing.Size(1265, 580);
            this.production_register.TabIndex = 1;
            // 
            // worker_performance
            // 
            this.worker_performance.Location = new System.Drawing.Point(0, 0);
            this.worker_performance.Name = "worker_performance";
            this.worker_performance.Size = new System.Drawing.Size(838, 508);
            this.worker_performance.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.metroTile_RegisterOrder);
            this.panel3.Controls.Add(this.metroTitle_SearchOrder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1265, 70);
            this.panel3.TabIndex = 3;
            this.panel3.BackColor = System.Drawing.Color.White;
            // 
            // metroTile_RegisterOrder
            // 
            this.metroTile_RegisterOrder.ActiveControl = null;
            this.metroTile_RegisterOrder.BackColor = System.Drawing.Color.DarkCyan;
            this.metroTile_RegisterOrder.Location = new System.Drawing.Point(242, 3);
            this.metroTile_RegisterOrder.Name = "metroTile_RegisterOrder";
            this.metroTile_RegisterOrder.Size = new System.Drawing.Size(171, 61);
            this.metroTile_RegisterOrder.TabIndex = 41;
            this.metroTile_RegisterOrder.Text = "Registrar orden";
            this.metroTile_RegisterOrder.TileImage = global::WindowsFormsApp1.Properties.Resources.Add_File_40px;
            this.metroTile_RegisterOrder.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile_RegisterOrder.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile_RegisterOrder.UseCustomBackColor = true;
            this.metroTile_RegisterOrder.UseSelectable = true;
            this.metroTile_RegisterOrder.UseTileImage = true;
            this.metroTile_RegisterOrder.Click += new System.EventHandler(this.metroTile_RegisterOrder_Click);
            // 
            // metroTitle_SearchOrder
            // 
            this.metroTitle_SearchOrder.ActiveControl = null;
            this.metroTitle_SearchOrder.BackColor = System.Drawing.Color.DarkCyan;
            this.metroTitle_SearchOrder.Location = new System.Drawing.Point(13, 3);
            this.metroTitle_SearchOrder.Name = "metroTitle_SearchOrder";
            this.metroTitle_SearchOrder.PaintTileCount = false;
            this.metroTitle_SearchOrder.Size = new System.Drawing.Size(183, 64);
            this.metroTitle_SearchOrder.TabIndex = 40;
            this.metroTitle_SearchOrder.Text = "Orden de producción";
            this.metroTitle_SearchOrder.TileImage = global::WindowsFormsApp1.Properties.Resources.Documents_40px;
            this.metroTitle_SearchOrder.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTitle_SearchOrder.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTitle_SearchOrder.UseCustomBackColor = true;
            this.metroTitle_SearchOrder.UseSelectable = true;
            this.metroTitle_SearchOrder.UseTileImage = true;
            this.metroTitle_SearchOrder.Click += new System.EventHandler(this.metroTitle_SearchOrder_Click);
            // 
            // UC_ProductionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "UC_ProductionMenu";
            this.Size = new System.Drawing.Size(1265, 650);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private UC_ProductionOrderSearch production_search;
        private UC_ProductionOrder production_register;
        private WorkersPerformance_Report worker_performance;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroTile metroTile_RegisterOrder;
        private MetroFramework.Controls.MetroTile metroTitle_SearchOrder;
    }
}
