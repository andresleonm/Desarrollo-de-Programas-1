namespace WindowsFormsApp1.Views
{
    partial class UC_PurchasesMenu
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
            this.btn_new_purchase_order = new MetroFramework.Controls.MetroTile();
            this.btn_purchase_orders = new MetroFramework.Controls.MetroTile();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_PurchaseOrderGrid1 = new WindowsFormsApp1.Views.UC_PurchaseOrderGrid();
            this.uC_PurchaseOrder1 = new WindowsFormsApp1.Views.UC_PurchaseOrder();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_new_purchase_order);
            this.panel1.Controls.Add(this.btn_purchase_orders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 70);
            this.panel1.TabIndex = 0;
            // 
            // btn_new_purchase_order
            // 
            this.btn_new_purchase_order.ActiveControl = null;
            this.btn_new_purchase_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_new_purchase_order.Location = new System.Drawing.Point(213, 5);
            this.btn_new_purchase_order.Name = "btn_new_purchase_order";
            this.btn_new_purchase_order.Size = new System.Drawing.Size(177, 62);
            this.btn_new_purchase_order.TabIndex = 1;
            this.btn_new_purchase_order.Text = "Nueva Orden";
            this.btn_new_purchase_order.UseCustomBackColor = true;
            this.btn_new_purchase_order.UseSelectable = true;
            this.btn_new_purchase_order.Click += new System.EventHandler(this.btn_new_purchase_order_Click);
            // 
            // btn_purchase_orders
            // 
            this.btn_purchase_orders.ActiveControl = null;
            this.btn_purchase_orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_purchase_orders.Location = new System.Drawing.Point(3, 5);
            this.btn_purchase_orders.Name = "btn_purchase_orders";
            this.btn_purchase_orders.Size = new System.Drawing.Size(177, 62);
            this.btn_purchase_orders.TabIndex = 0;
            this.btn_purchase_orders.Text = "Órdenes de Compra";
            this.btn_purchase_orders.UseCustomBackColor = true;
            this.btn_purchase_orders.UseSelectable = true;
            this.btn_purchase_orders.Click += new System.EventHandler(this.btn_purchases_orders_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_PurchaseOrderGrid1);
            this.panel2.Controls.Add(this.uC_PurchaseOrder1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 452);
            this.panel2.TabIndex = 1;
            // 
            // uC_PurchaseOrderGrid1
            // 
            this.uC_PurchaseOrderGrid1.BackColor = System.Drawing.Color.White;
            this.uC_PurchaseOrderGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_PurchaseOrderGrid1.Location = new System.Drawing.Point(0, 0);
            this.uC_PurchaseOrderGrid1.Name = "uC_PurchaseOrderGrid1";
            this.uC_PurchaseOrderGrid1.Size = new System.Drawing.Size(774, 452);
            this.uC_PurchaseOrderGrid1.TabIndex = 0;
            this.uC_PurchaseOrderGrid1.Visible = false;
            // 
            // uC_PurchaseOrder1
            // 
            this.uC_PurchaseOrder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_PurchaseOrder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_PurchaseOrder1.Location = new System.Drawing.Point(0, 0);
            this.uC_PurchaseOrder1.Name = "uC_PurchaseOrder1";
            this.uC_PurchaseOrder1.Size = new System.Drawing.Size(774, 452);
            this.uC_PurchaseOrder1.TabIndex = 1;
            this.uC_PurchaseOrder1.Visible = false;
            // 
            // UC_PurchasesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_PurchasesMenu";
            this.Size = new System.Drawing.Size(774, 522);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private UC_PurchaseOrderGrid uC_PurchaseOrderGrid1;
        private UC_PurchaseOrder uC_PurchaseOrder1;
        private MetroFramework.Controls.MetroTile btn_purchase_orders;
        private MetroFramework.Controls.MetroTile btn_new_purchase_order;
    }
}
