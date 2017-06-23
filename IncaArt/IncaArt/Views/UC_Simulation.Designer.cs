namespace WindowsFormsApp1.Views
{
    partial class UC_Simulation
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.btn_purchase_orders = new MetroFramework.Controls.MetroTile();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_SimulationExecution1 = new WindowsFormsApp1.Views.UC_SimulationExecution();
            this.uC_SimulationConfig2 = new WindowsFormsApp1.Views.UC_SimulationConfig();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroTile1);
            this.panel1.Controls.Add(this.btn_purchase_orders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 70);
            this.panel1.TabIndex = 8;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.DarkCyan;
            this.metroTile1.Location = new System.Drawing.Point(294, 4);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(177, 62);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "Ejecución";
            this.metroTile1.TileImage = global::WindowsFormsApp1.Properties.Resources.Documents_40px;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // btn_purchase_orders
            // 
            this.btn_purchase_orders.ActiveControl = null;
            this.btn_purchase_orders.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_purchase_orders.Location = new System.Drawing.Point(27, 5);
            this.btn_purchase_orders.Name = "btn_purchase_orders";
            this.btn_purchase_orders.Size = new System.Drawing.Size(177, 62);
            this.btn_purchase_orders.TabIndex = 2;
            this.btn_purchase_orders.Text = "Configuración";
            this.btn_purchase_orders.TileImage = global::WindowsFormsApp1.Properties.Resources.Documents_40px;
            this.btn_purchase_orders.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_purchase_orders.UseCustomBackColor = true;
            this.btn_purchase_orders.UseSelectable = true;
            this.btn_purchase_orders.UseTileImage = true;
            this.btn_purchase_orders.Click += new System.EventHandler(this.btn_purchase_orders_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_SimulationConfig2);
            this.panel2.Controls.Add(this.uC_SimulationExecution1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 461);
            this.panel2.TabIndex = 11;
            // 
            // uC_SimulationExecution1
            // 
            this.uC_SimulationExecution1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uC_SimulationExecution1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_SimulationExecution1.Location = new System.Drawing.Point(0, 0);
            this.uC_SimulationExecution1.Name = "uC_SimulationExecution1";
            this.uC_SimulationExecution1.Size = new System.Drawing.Size(764, 461);
            this.uC_SimulationExecution1.TabIndex = 14;
            this.uC_SimulationExecution1.Visible = false;
            // 
            // uC_SimulationConfig2
            // 
            this.uC_SimulationConfig2.BackColor = System.Drawing.Color.White;
            this.uC_SimulationConfig2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_SimulationConfig2.Location = new System.Drawing.Point(0, 0);
            this.uC_SimulationConfig2.Name = "uC_SimulationConfig2";
            this.uC_SimulationConfig2.Size = new System.Drawing.Size(764, 461);
            this.uC_SimulationConfig2.TabIndex = 15;
            // 
            // UC_Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Simulation";
            this.Size = new System.Drawing.Size(764, 531);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile btn_purchase_orders;
        private System.Windows.Forms.Panel panel2;
        private UC_SimulationConfig uC_SimulationConfig2;
        private UC_SimulationExecution uC_SimulationExecution1;
    }
}
