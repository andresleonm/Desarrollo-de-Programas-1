namespace WindowsFormsApp1.Views
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ts_main = new System.Windows.Forms.ToolStrip();
            this.btn_Mant = new System.Windows.Forms.ToolStripButton();
            this.btn_Almacen = new System.Windows.Forms.ToolStripButton();
            this.btn_Ventas = new System.Windows.Forms.ToolStripButton();
            this.btn_Compras = new System.Windows.Forms.ToolStripButton();
            this.ts_mant = new System.Windows.Forms.ToolStrip();
            this.btn_crud_user = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.btn_crud_worker = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btn_crud_material = new System.Windows.Forms.ToolStripButton();
            this.ts_almacen = new System.Windows.Forms.ToolStrip();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.ts_ventas = new System.Windows.Forms.ToolStrip();
            this.btn_register_sale = new System.Windows.Forms.ToolStripButton();
            this.ts_compras = new System.Windows.Forms.ToolStrip();
            this.btn_register_purchase = new System.Windows.Forms.ToolStripButton();
            this.ts_main.SuspendLayout();
            this.ts_mant.SuspendLayout();
            this.ts_almacen.SuspendLayout();
            this.ts_ventas.SuspendLayout();
            this.ts_compras.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts_main
            // 
            this.ts_main.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Mant,
            this.btn_Almacen,
            this.btn_Ventas,
            this.btn_Compras});
            this.ts_main.Location = new System.Drawing.Point(0, 0);
            this.ts_main.Name = "ts_main";
            this.ts_main.Size = new System.Drawing.Size(805, 25);
            this.ts_main.TabIndex = 1;
            this.ts_main.Text = "toolStrip1";
            // 
            // btn_Mant
            // 
            this.btn_Mant.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Mant.Image = ((System.Drawing.Image)(resources.GetObject("btn_Mant.Image")));
            this.btn_Mant.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Mant.Name = "btn_Mant";
            this.btn_Mant.Size = new System.Drawing.Size(109, 22);
            this.btn_Mant.Text = "Mantenimiento";
            this.btn_Mant.Click += new System.EventHandler(this.btn_Mant_Click);
            // 
            // btn_Almacen
            // 
            this.btn_Almacen.Image = ((System.Drawing.Image)(resources.GetObject("btn_Almacen.Image")));
            this.btn_Almacen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Almacen.Name = "btn_Almacen";
            this.btn_Almacen.Size = new System.Drawing.Size(74, 22);
            this.btn_Almacen.Text = "Almacen";
            this.btn_Almacen.Click += new System.EventHandler(this.btn_Almacen_Click);
            // 
            // btn_Ventas
            // 
            this.btn_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ventas.Image")));
            this.btn_Ventas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Ventas.Name = "btn_Ventas";
            this.btn_Ventas.Size = new System.Drawing.Size(62, 22);
            this.btn_Ventas.Text = "Ventas";
            this.btn_Ventas.Click += new System.EventHandler(this.btn_Ventas_Click);
            // 
            // btn_Compras
            // 
            this.btn_Compras.Image = ((System.Drawing.Image)(resources.GetObject("btn_Compras.Image")));
            this.btn_Compras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Compras.Name = "btn_Compras";
            this.btn_Compras.Size = new System.Drawing.Size(75, 22);
            this.btn_Compras.Text = "Compras";
            this.btn_Compras.Click += new System.EventHandler(this.btn_Compras_Click);
            // 
            // ts_mant
            // 
            this.ts_mant.Dock = System.Windows.Forms.DockStyle.Left;
            this.ts_mant.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_mant.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_crud_user,
            this.toolStripButton6,
            this.btn_crud_worker,
            this.toolStripButton1,
            this.btn_crud_material});
            this.ts_mant.Location = new System.Drawing.Point(0, 25);
            this.ts_mant.Name = "ts_mant";
            this.ts_mant.Size = new System.Drawing.Size(91, 447);
            this.ts_mant.TabIndex = 2;
            this.ts_mant.Text = "toolStrip2";
            // 
            // btn_crud_user
            // 
            this.btn_crud_user.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_crud_user.Image = ((System.Drawing.Image)(resources.GetObject("btn_crud_user.Image")));
            this.btn_crud_user.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_crud_user.Name = "btn_crud_user";
            this.btn_crud_user.Size = new System.Drawing.Size(88, 19);
            this.btn_crud_user.Text = "Usuarios";
            this.btn_crud_user.Click += new System.EventHandler(this.btn_crud_user_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(88, 19);
            this.toolStripButton6.Text = "Clientes";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // btn_crud_worker
            // 
            this.btn_crud_worker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_crud_worker.Image = ((System.Drawing.Image)(resources.GetObject("btn_crud_worker.Image")));
            this.btn_crud_worker.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_crud_worker.Name = "btn_crud_worker";
            this.btn_crud_worker.Size = new System.Drawing.Size(88, 19);
            this.btn_crud_worker.Text = "Trabajadores";
            this.btn_crud_worker.Click += new System.EventHandler(this.btn_crud_worker_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(88, 4);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btn_crud_material
            // 
            this.btn_crud_material.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_crud_material.Image = ((System.Drawing.Image)(resources.GetObject("btn_crud_material.Image")));
            this.btn_crud_material.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_crud_material.Name = "btn_crud_material";
            this.btn_crud_material.Size = new System.Drawing.Size(88, 19);
            this.btn_crud_material.Text = "Materias Prima";
            this.btn_crud_material.Click += new System.EventHandler(this.btn_crud_material_Click);
            // 
            // ts_almacen
            // 
            this.ts_almacen.Dock = System.Windows.Forms.DockStyle.Left;
            this.ts_almacen.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_almacen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.toolStripButton8});
            this.ts_almacen.Location = new System.Drawing.Point(207, 25);
            this.ts_almacen.Name = "ts_almacen";
            this.ts_almacen.Size = new System.Drawing.Size(57, 447);
            this.ts_almacen.TabIndex = 3;
            this.ts_almacen.Text = "toolStrip3";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(54, 19);
            this.toolStripButton7.Text = "Entradas";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(54, 19);
            this.toolStripButton8.Text = "Salidas";
            // 
            // ts_ventas
            // 
            this.ts_ventas.Dock = System.Windows.Forms.DockStyle.Left;
            this.ts_ventas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_ventas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_register_sale});
            this.ts_ventas.Location = new System.Drawing.Point(91, 25);
            this.ts_ventas.Name = "ts_ventas";
            this.ts_ventas.Size = new System.Drawing.Size(58, 447);
            this.ts_ventas.TabIndex = 4;
            this.ts_ventas.Text = "toolStrip4";
            // 
            // btn_register_sale
            // 
            this.btn_register_sale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_register_sale.Image = ((System.Drawing.Image)(resources.GetObject("btn_register_sale.Image")));
            this.btn_register_sale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_register_sale.Name = "btn_register_sale";
            this.btn_register_sale.Size = new System.Drawing.Size(55, 19);
            this.btn_register_sale.Text = "Registrar";
            // 
            // ts_compras
            // 
            this.ts_compras.Dock = System.Windows.Forms.DockStyle.Left;
            this.ts_compras.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_compras.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_register_purchase});
            this.ts_compras.Location = new System.Drawing.Point(149, 25);
            this.ts_compras.Name = "ts_compras";
            this.ts_compras.Size = new System.Drawing.Size(58, 447);
            this.ts_compras.TabIndex = 5;
            this.ts_compras.Text = "toolStrip5";
            // 
            // btn_register_purchase
            // 
            this.btn_register_purchase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_register_purchase.Image = ((System.Drawing.Image)(resources.GetObject("btn_register_purchase.Image")));
            this.btn_register_purchase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_register_purchase.Name = "btn_register_purchase";
            this.btn_register_purchase.Size = new System.Drawing.Size(55, 19);
            this.btn_register_purchase.Text = "Registrar";
            this.btn_register_purchase.Click += new System.EventHandler(this.btn_register_purchase_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 472);
            this.Controls.Add(this.ts_almacen);
            this.Controls.Add(this.ts_compras);
            this.Controls.Add(this.ts_ventas);
            this.Controls.Add(this.ts_mant);
            this.Controls.Add(this.ts_main);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ts_main.ResumeLayout(false);
            this.ts_main.PerformLayout();
            this.ts_mant.ResumeLayout(false);
            this.ts_mant.PerformLayout();
            this.ts_almacen.ResumeLayout(false);
            this.ts_almacen.PerformLayout();
            this.ts_ventas.ResumeLayout(false);
            this.ts_ventas.PerformLayout();
            this.ts_compras.ResumeLayout(false);
            this.ts_compras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts_main;
        private System.Windows.Forms.ToolStripButton btn_Mant;
        private System.Windows.Forms.ToolStrip ts_mant;
        private System.Windows.Forms.ToolStripButton btn_Almacen;
        private System.Windows.Forms.ToolStripButton btn_Ventas;
        private System.Windows.Forms.ToolStripButton btn_Compras;
        private System.Windows.Forms.ToolStripButton btn_crud_user;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStrip ts_almacen;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStrip ts_ventas;
        private System.Windows.Forms.ToolStripButton btn_register_sale;
        private System.Windows.Forms.ToolStrip ts_compras;
        private System.Windows.Forms.ToolStripButton btn_register_purchase;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btn_crud_worker;
        private System.Windows.Forms.ToolStripButton btn_crud_material;
    }
}