namespace WindowsFormsApp1.Views
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.purchase_imagelist = new System.Windows.Forms.ImageList(this.components);
            this.btn_sales = new System.Windows.Forms.Button();
            this.sales_imagelist = new System.Windows.Forms.ImageList(this.components);
            this.btn_warehouse = new System.Windows.Forms.Button();
            this.warehouse_imagelist = new System.Windows.Forms.ImageList(this.components);
            this.btn_config = new System.Windows.Forms.Button();
            this.config_imagelist = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_logo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.uC_SalesMain1 = new WindowsFormsApp1.Views.UC_SalesMain();
            this.parameters1 = new WindowsFormsApp1.Views.Parameters();
            this.warehouse1 = new WindowsFormsApp1.Views.Warehouse();
            this.supplier1 = new WindowsFormsApp1.Views.Supplier();
            this.workstation1 = new WindowsFormsApp1.Views.Workstation();
            this.bom1 = new WindowsFormsApp1.Views.BOM();
            this.client1 = new WindowsFormsApp1.Views.Client();
            this.uC_PurchasesMenu1 = new WindowsFormsApp1.Views.UC_PurchasesMenu();
            this.mainDashboard1 = new WindowsFormsApp1.Views.MainDashboard();
            this.user = new WindowsFormsApp1.Views.UC_User();
            this.material = new WindowsFormsApp1.Views.UC_Material();
            this.worker = new WindowsFormsApp1.Views.UC_Worker();
            this.profile = new WindowsFormsApp1.Views.Profile();
            this.shift = new WindowsFormsApp1.Views.Shift();
            this.product = new WindowsFormsApp1.Views.Product();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 27);
            this.panel2.TabIndex = 10;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Minimize_Window_52px;
            this.pictureBox2.Location = new System.Drawing.Point(909, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox_MouseHover);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Close_Window_52px;
            this.pictureBox1.Location = new System.Drawing.Point(930, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox_MouseHover);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btn_purchase);
            this.panel1.Controls.Add(this.btn_sales);
            this.panel1.Controls.Add(this.btn_warehouse);
            this.panel1.Controls.Add(this.btn_config);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 559);
            this.panel1.TabIndex = 11;
            // 
            // btn_purchase
            // 
            this.btn_purchase.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_purchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_purchase.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchase.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchase.ForeColor = System.Drawing.Color.White;
            this.btn_purchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_purchase.ImageIndex = 1;
            this.btn_purchase.ImageList = this.purchase_imagelist;
            this.btn_purchase.Location = new System.Drawing.Point(0, 171);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(132, 42);
            this.btn_purchase.TabIndex = 5;
            this.btn_purchase.Text = "Compras";
            this.btn_purchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_purchase.UseVisualStyleBackColor = false;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            this.btn_purchase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menuButton_Click);
            // 
            // purchase_imagelist
            // 
            this.purchase_imagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("purchase_imagelist.ImageStream")));
            this.purchase_imagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.purchase_imagelist.Images.SetKeyName(0, "blue_Shopping Cart_20px.png");
            this.purchase_imagelist.Images.SetKeyName(1, "Shopping Cart_52px.png");
            // 
            // btn_sales
            // 
            this.btn_sales.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_sales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sales.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sales.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sales.ForeColor = System.Drawing.Color.White;
            this.btn_sales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sales.ImageIndex = 1;
            this.btn_sales.ImageList = this.sales_imagelist;
            this.btn_sales.Location = new System.Drawing.Point(0, 129);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(132, 42);
            this.btn_sales.TabIndex = 4;
            this.btn_sales.Text = "Ventas";
            this.btn_sales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sales.UseVisualStyleBackColor = false;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            this.btn_sales.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menuButton_Click);
            // 
            // sales_imagelist
            // 
            this.sales_imagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("sales_imagelist.ImageStream")));
            this.sales_imagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.sales_imagelist.Images.SetKeyName(0, "blue_Sales Performance_20px.png");
            this.sales_imagelist.Images.SetKeyName(1, "Sales Performance_64px.png");
            // 
            // btn_warehouse
            // 
            this.btn_warehouse.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_warehouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_warehouse.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_warehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_warehouse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_warehouse.ForeColor = System.Drawing.Color.White;
            this.btn_warehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_warehouse.ImageIndex = 1;
            this.btn_warehouse.ImageList = this.warehouse_imagelist;
            this.btn_warehouse.Location = new System.Drawing.Point(0, 87);
            this.btn_warehouse.Name = "btn_warehouse";
            this.btn_warehouse.Size = new System.Drawing.Size(132, 42);
            this.btn_warehouse.TabIndex = 3;
            this.btn_warehouse.Text = "Almacén";
            this.btn_warehouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_warehouse.UseVisualStyleBackColor = false;
            this.btn_warehouse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menuButton_Click);
            // 
            // warehouse_imagelist
            // 
            this.warehouse_imagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("warehouse_imagelist.ImageStream")));
            this.warehouse_imagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.warehouse_imagelist.Images.SetKeyName(0, "blue_Move by Trolley_20px.png");
            this.warehouse_imagelist.Images.SetKeyName(1, "Hangar_64px.png");
            // 
            // btn_config
            // 
            this.btn_config.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_config.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_config.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_config.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_config.ForeColor = System.Drawing.Color.White;
            this.btn_config.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_config.ImageIndex = 1;
            this.btn_config.ImageList = this.config_imagelist;
            this.btn_config.Location = new System.Drawing.Point(0, 45);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(132, 42);
            this.btn_config.TabIndex = 2;
            this.btn_config.Text = "Mantenimiento";
            this.btn_config.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_config.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_config.UseVisualStyleBackColor = false;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            this.btn_config.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menuButton_Click);
            // 
            // config_imagelist
            // 
            this.config_imagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("config_imagelist.ImageStream")));
            this.config_imagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.config_imagelist.Images.SetKeyName(0, "Blue_Settings_40px.png");
            this.config_imagelist.Images.SetKeyName(1, "Settings_48px.png");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_logo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 45);
            this.panel3.TabIndex = 0;
            // 
            // btn_logo
            // 
            this.btn_logo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_logo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_logo.FlatAppearance.BorderSize = 0;
            this.btn_logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logo.ForeColor = System.Drawing.Color.White;
            this.btn_logo.Image = global::WindowsFormsApp1.Properties.Resources.American_Indians_Seminole_white_40px;
            this.btn_logo.Location = new System.Drawing.Point(0, 0);
            this.btn_logo.Name = "btn_logo";
            this.btn_logo.Size = new System.Drawing.Size(132, 45);
            this.btn_logo.TabIndex = 6;
            this.btn_logo.Text = "INCA ART";
            this.btn_logo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_logo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_logo.UseVisualStyleBackColor = false;
            this.btn_logo.Click += new System.EventHandler(this.btn_logo_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel4.Controls.Add(this.metroLabel2);
            this.panel4.Controls.Add(this.metroLabel1);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(132, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(819, 45);
            this.panel4.TabIndex = 12;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroLabel2.Location = new System.Drawing.Point(609, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(101, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "(Administrador)";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroLabel1.Location = new System.Drawing.Point(710, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Rony Cueva";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.Circled_User_Male_40px;
            this.pictureBox3.Location = new System.Drawing.Point(788, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // uC_SalesMain1
            // 
            this.uC_SalesMain1.BackColor = System.Drawing.Color.White;
            this.uC_SalesMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_SalesMain1.Location = new System.Drawing.Point(132, 72);
            this.uC_SalesMain1.Name = "uC_SalesMain1";
            this.uC_SalesMain1.Size = new System.Drawing.Size(819, 514);
            this.uC_SalesMain1.TabIndex = 31;
            // 
            // parameters1
            // 
            this.parameters1.Location = new System.Drawing.Point(132, 72);
            this.parameters1.Name = "parameters1";
            this.parameters1.Size = new System.Drawing.Size(819, 514);
            this.parameters1.TabIndex = 22;
            this.parameters1.Visible = false;
            // 
            // warehouse1
            // 
            this.warehouse1.Location = new System.Drawing.Point(132, 72);
            this.warehouse1.Name = "warehouse1";
            this.warehouse1.Size = new System.Drawing.Size(1023, 531);
            this.warehouse1.TabIndex = 20;
            // 
            // supplier1
            // 
            this.supplier1.Location = new System.Drawing.Point(132, 72);
            this.supplier1.Name = "supplier1";
            this.supplier1.Size = new System.Drawing.Size(1064, 652);
            this.supplier1.TabIndex = 18;
            // 
            // workstation1
            // 
            this.workstation1.Location = new System.Drawing.Point(132, 72);
            this.workstation1.Name = "workstation1";
            this.workstation1.Size = new System.Drawing.Size(850, 489);
            this.workstation1.TabIndex = 20;
            // 
            // bom1
            // 
            this.bom1.Location = new System.Drawing.Point(132, 72);
            this.bom1.Name = "bom1";
            this.bom1.Size = new System.Drawing.Size(882, 489);
            this.bom1.TabIndex = 19;
            // 
            // client1
            // 
            this.client1.Location = new System.Drawing.Point(132, 72);
            this.client1.Name = "client1";
            this.client1.Size = new System.Drawing.Size(898, 532);
            this.client1.TabIndex = 18;
            // 
            // uC_PurchasesMenu1
            // 
            this.uC_PurchasesMenu1.BackColor = System.Drawing.SystemColors.Control;
            this.uC_PurchasesMenu1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_PurchasesMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_PurchasesMenu1.Location = new System.Drawing.Point(132, 72);
            this.uC_PurchasesMenu1.Name = "uC_PurchasesMenu1";
            this.uC_PurchasesMenu1.Size = new System.Drawing.Size(819, 514);
            this.uC_PurchasesMenu1.TabIndex = 16;
            // 
            // mainDashboard1
            // 
            this.mainDashboard1.BackColor = System.Drawing.Color.White;
            this.mainDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDashboard1.Location = new System.Drawing.Point(132, 72);
            this.mainDashboard1.Name = "mainDashboard1";
            this.mainDashboard1.Size = new System.Drawing.Size(819, 514);
            this.mainDashboard1.TabIndex = 13;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(132, 72);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(1017, 439);
            this.user.TabIndex = 24;
            this.user.Visible = false;
            // 
            // material
            // 
            this.material.Location = new System.Drawing.Point(132, 72);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(889, 400);
            this.material.TabIndex = 25;
            this.material.Visible = false;
            // 
            // worker
            // 
            this.worker.Location = new System.Drawing.Point(132, 72);
            this.worker.Name = "worker";
            this.worker.Size = new System.Drawing.Size(1107, 462);
            this.worker.TabIndex = 26;
            this.worker.Visible = false;
            // 
            // profile
            // 
            this.profile.Location = new System.Drawing.Point(132, 72);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(873, 442);
            this.profile.TabIndex = 27;
            // 
            // shift
            // 
            this.shift.Location = new System.Drawing.Point(132, 72);
            this.shift.Name = "shift";
            this.shift.Size = new System.Drawing.Size(819, 447);
            this.shift.TabIndex = 28;
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(132, 72);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(915, 549);
            this.product.TabIndex = 29;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 586);
            this.Controls.Add(this.uC_SalesMain1);
            this.Controls.Add(this.parameters1);
            this.Controls.Add(this.warehouse1);
            this.Controls.Add(this.supplier1);
            this.Controls.Add(this.workstation1);
            this.Controls.Add(this.bom1);
            this.Controls.Add(this.client1);
            this.Controls.Add(this.uC_PurchasesMenu1);
            this.Controls.Add(this.mainDashboard1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.user);
            this.Controls.Add(this.material);
            this.Controls.Add(this.worker);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.shift);
            this.Controls.Add(this.product);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.Button btn_sales;
        private System.Windows.Forms.Button btn_warehouse;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_logo;
        private System.Windows.Forms.Panel panel4;
        private MainDashboard mainDashboard1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ImageList config_imagelist;
        private System.Windows.Forms.ImageList warehouse_imagelist;
        private System.Windows.Forms.ImageList sales_imagelist;
        private System.Windows.Forms.ImageList purchase_imagelist;
        private UC_PurchasesMenu uC_PurchasesMenu1;
        private Supplier supplier1;
        private Warehouse warehouse1;
        private Client client1;
        private BOM bom1;
        private Workstation workstation1;
        private Parameters parameters1;
        private UC_User user;
        private UC_Material material;
        private UC_Worker worker;
        private Profile profile;
        private Product product;
        private Shift shift;
        private UC_SalesMain uC_SalesMain1;
    }
}