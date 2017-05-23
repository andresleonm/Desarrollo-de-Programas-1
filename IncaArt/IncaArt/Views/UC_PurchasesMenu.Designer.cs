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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_purchases_orders = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_PurchaseOrder1 = new WindowsFormsApp1.Views.UC_PurchaseOrder();
            this.uC_PurchaseOrderGrid1 = new WindowsFormsApp1.Views.UC_PurchaseOrderGrid();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_purchases_orders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 37);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 1;
            this.button1.Location = new System.Drawing.Point(140, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nueva Orden";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_purchases_orders
            // 
            this.btn_purchases_orders.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_purchases_orders.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_purchases_orders.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_purchases_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchases_orders.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchases_orders.ForeColor = System.Drawing.Color.White;
            this.btn_purchases_orders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_purchases_orders.ImageIndex = 1;
            this.btn_purchases_orders.Location = new System.Drawing.Point(0, 0);
            this.btn_purchases_orders.Name = "btn_purchases_orders";
            this.btn_purchases_orders.Size = new System.Drawing.Size(140, 37);
            this.btn_purchases_orders.TabIndex = 3;
            this.btn_purchases_orders.Text = "Órdenes de Compra";
            this.btn_purchases_orders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_purchases_orders.UseVisualStyleBackColor = false;
            this.btn_purchases_orders.Click += new System.EventHandler(this.btn_purchases_orders_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_PurchaseOrderGrid1);
            this.panel2.Controls.Add(this.uC_PurchaseOrder1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 485);
            this.panel2.TabIndex = 1;
            // 
            // uC_PurchaseOrder1
            // 
            this.uC_PurchaseOrder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_PurchaseOrder1.Location = new System.Drawing.Point(0, 0);
            this.uC_PurchaseOrder1.Name = "uC_PurchaseOrder1";
            this.uC_PurchaseOrder1.Size = new System.Drawing.Size(771, 482);
            this.uC_PurchaseOrder1.TabIndex = 1;
            this.uC_PurchaseOrder1.Visible = false;
            // 
            // uC_PurchaseOrderGrid1
            // 
            this.uC_PurchaseOrderGrid1.Location = new System.Drawing.Point(0, 0);
            this.uC_PurchaseOrderGrid1.Name = "uC_PurchaseOrderGrid1";
            this.uC_PurchaseOrderGrid1.Size = new System.Drawing.Size(593, 485);
            this.uC_PurchaseOrderGrid1.TabIndex = 0;
            // 
            // uC_PurchaseOrderGrid1
            // 
            this.uC_PurchaseOrderGrid1.Location = new System.Drawing.Point(0, 0);
            this.uC_PurchaseOrderGrid1.Name = "uC_PurchaseOrderGrid1";
            this.uC_PurchaseOrderGrid1.Size = new System.Drawing.Size(593, 485);
            this.uC_PurchaseOrderGrid1.TabIndex = 0;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_purchases_orders;
        private System.Windows.Forms.Panel panel2;
        private UC_PurchaseOrderGrid uC_PurchaseOrderGrid1;
        private UC_PurchaseOrder uC_PurchaseOrder1;
    }
}
