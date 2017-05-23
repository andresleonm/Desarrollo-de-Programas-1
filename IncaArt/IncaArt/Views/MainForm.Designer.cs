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
            this.ts_almacen = new System.Windows.Forms.ToolStrip();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripButton();
            this.ts_ventas = new System.Windows.Forms.ToolStrip();
            this.btn_register_sale = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.ts_compras = new System.Windows.Forms.ToolStrip();
            this.btn_register_purchase = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.ts_mant = new System.Windows.Forms.ToolStrip();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.ts_main.SuspendLayout();
            this.ts_almacen.SuspendLayout();
            this.ts_ventas.SuspendLayout();
            this.ts_compras.SuspendLayout();
            this.ts_mant.SuspendLayout();
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
            // ts_almacen
            // 
            this.ts_almacen.Dock = System.Windows.Forms.DockStyle.Left;
            this.ts_almacen.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_almacen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.toolStripLabel1});
            this.ts_almacen.Location = new System.Drawing.Point(307, 25);
            this.ts_almacen.Name = "ts_almacen";
            this.ts_almacen.Size = new System.Drawing.Size(88, 447);
            this.ts_almacen.TabIndex = 3;
            this.ts_almacen.Text = "toolStrip3";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(85, 19);
            this.toolStripButton7.Text = "Mov Producto";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(85, 19);
            this.toolStripLabel1.Text = "Mov Material";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // ts_ventas
            // 
            this.ts_ventas.Dock = System.Windows.Forms.DockStyle.Left;
            this.ts_ventas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_ventas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_register_sale,
            this.toolStripButton13});
            this.ts_ventas.Location = new System.Drawing.Point(112, 25);
            this.ts_ventas.Name = "ts_ventas";
            this.ts_ventas.Size = new System.Drawing.Size(90, 447);
            this.ts_ventas.TabIndex = 4;
            this.ts_ventas.Text = "toolStrip4";
            // 
            // btn_register_sale
            // 
            this.btn_register_sale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_register_sale.Image = ((System.Drawing.Image)(resources.GetObject("btn_register_sale.Image")));
            this.btn_register_sale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_register_sale.Name = "btn_register_sale";
            this.btn_register_sale.Size = new System.Drawing.Size(87, 19);
            this.btn_register_sale.Text = "Registrar venta";
            this.btn_register_sale.Click += new System.EventHandler(this.btn_register_sale_Click);
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(87, 20);
            this.toolStripButton13.Text = "Nuevo";
            // 
            // ts_compras
            // 
            this.ts_compras.Dock = System.Windows.Forms.DockStyle.Left;
            this.ts_compras.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_compras.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_register_purchase});
            this.ts_compras.Location = new System.Drawing.Point(202, 25);
            this.ts_compras.Name = "ts_compras";
            this.ts_compras.Size = new System.Drawing.Size(105, 447);
            this.ts_compras.TabIndex = 5;
            this.ts_compras.Text = "toolStrip5";
            this.ts_compras.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ts_compras_ItemClicked);
            // 
            // btn_register_purchase
            // 
            this.btn_register_purchase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_register_purchase.Image = ((System.Drawing.Image)(resources.GetObject("btn_register_purchase.Image")));
            this.btn_register_purchase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_register_purchase.Name = "btn_register_purchase";
            this.btn_register_purchase.Size = new System.Drawing.Size(102, 19);
            this.btn_register_purchase.Text = "Orden de compra";
            this.btn_register_purchase.Click += new System.EventHandler(this.btn_register_purchase_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(109, 19);
            this.toolStripButton5.Text = "Usuarios";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(109, 19);
            this.toolStripButton6.Text = "Clientes";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(109, 19);
            this.toolStripButton1.Text = "Receta";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(109, 19);
            this.toolStripButton2.Text = "Puestos de Trabajo";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(109, 19);
            this.toolStripButton3.Text = "Trabajadores";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(109, 19);
            this.toolStripButton4.Text = "Materiales";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(109, 19);
            this.toolStripButton8.Text = "Productos";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(109, 19);
            this.toolStripButton11.Text = "Perfiles";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(109, 19);
            this.toolStripButton10.Text = "Turnos de trabajo";
            // 
            // ts_mant
            // 
            this.ts_mant.Dock = System.Windows.Forms.DockStyle.Left;
            this.ts_mant.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_mant.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton8,
            this.toolStripButton11,
            this.toolStripButton10,
            this.toolStripButton9,
            this.toolStripButton12});
            this.ts_mant.Location = new System.Drawing.Point(0, 25);
            this.ts_mant.Name = "ts_mant";
            this.ts_mant.Size = new System.Drawing.Size(112, 447);
            this.ts_mant.TabIndex = 2;
            this.ts_mant.Text = "toolStrip2";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(109, 19);
            this.toolStripButton9.Text = "Proveedor";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(109, 19);
            this.toolStripButton12.Text = "Almacén";
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
            this.Text = "Inca Art";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ts_main.ResumeLayout(false);
            this.ts_main.PerformLayout();
            this.ts_almacen.ResumeLayout(false);
            this.ts_almacen.PerformLayout();
            this.ts_ventas.ResumeLayout(false);
            this.ts_ventas.PerformLayout();
            this.ts_compras.ResumeLayout(false);
            this.ts_compras.PerformLayout();
            this.ts_mant.ResumeLayout(false);
            this.ts_mant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts_main;
        private System.Windows.Forms.ToolStripButton btn_Mant;
        private System.Windows.Forms.ToolStripButton btn_Almacen;
        private System.Windows.Forms.ToolStripButton btn_Ventas;
        private System.Windows.Forms.ToolStripButton btn_Compras;
        private System.Windows.Forms.ToolStrip ts_almacen;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStrip ts_ventas;
        private System.Windows.Forms.ToolStripButton btn_register_sale;
        private System.Windows.Forms.ToolStrip ts_compras;
        private System.Windows.Forms.ToolStripButton btn_register_purchase;
        private System.Windows.Forms.ToolStripButton toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStrip ts_mant;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
    }
}