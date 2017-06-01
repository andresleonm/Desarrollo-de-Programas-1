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
            this.btn_purchase_orders = new MetroFramework.Controls.MetroTile();
            this.uC_SimulationConfig1 = new WindowsFormsApp1.Views.UC_SimulationConfig();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_purchase_orders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 70);
            this.panel1.TabIndex = 2;
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
            // uC_SimulationConfig1
            // 
            this.uC_SimulationConfig1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_SimulationConfig1.Location = new System.Drawing.Point(0, 70);
            this.uC_SimulationConfig1.Name = "uC_SimulationConfig1";
            this.uC_SimulationConfig1.Size = new System.Drawing.Size(764, 461);
            this.uC_SimulationConfig1.TabIndex = 5;
            // 
            // UC_Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uC_SimulationConfig1);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Simulation";
            this.Size = new System.Drawing.Size(764, 531);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile btn_purchase_orders;
        private UC_SimulationConfig uC_SimulationConfig1;
    }
}
