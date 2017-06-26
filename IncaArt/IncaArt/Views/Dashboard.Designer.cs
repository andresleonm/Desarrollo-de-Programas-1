using WindowsFormsApp1.Views.Warehouse_Module;

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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.report_imagelist = new System.Windows.Forms.ImageList(this.components);
            this.btn_simulation = new System.Windows.Forms.Button();
            this.simulation_imagelist = new System.Windows.Forms.ImageList(this.components);
            this.btn_production = new System.Windows.Forms.Button();
            this.production_imagelist = new System.Windows.Forms.ImageList(this.components);
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
            this.label_user_role = new MetroFramework.Controls.MetroLabel();
            this.label_user_name = new MetroFramework.Controls.MetroLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.uc_recipe = new WindowsFormsApp1.Views.UC_Recipe();
            this.supplier1 = new WindowsFormsApp1.Views.Supplier();
            this.profile = new WindowsFormsApp1.Views.UC_Profile();
            this.parameters1 = new WindowsFormsApp1.Views.Parameters();
            this.shift = new WindowsFormsApp1.Views.UC_Shift();
            this.user = new WindowsFormsApp1.Views.UC_User();
            this.uc_workstation = new WindowsFormsApp1.Views.UC_Workstation();
            this.uc_worker = new WindowsFormsApp1.Views.UC_Worker();
            this.uC_Simulation1 = new WindowsFormsApp1.Views.UC_Simulation();
            this.uC_SalesMain1 = new WindowsFormsApp1.Views.UC_SalesMain();
            this.client1 = new WindowsFormsApp1.Views.Client();
            this.uc_reports = new WindowsFormsApp1.Views.Reports_Module.ReportDashboard();
            this.uc_ratio = new WindowsFormsApp1.Views.UC_Ratio();
            this.uc_product = new WindowsFormsApp1.Views.UC_Product();
            this.uC_CurrencyMain1 = new WindowsFormsApp1.Views.Currency_Module.UC_CurrencyMain();
            this.uc_material = new WindowsFormsApp1.Views.UC_Material();
            this.uc_ProductionMenu = new WindowsFormsApp1.Views.Production_Module.UC_ProductionMenu();
            this.uC_MovementsType1 = new WindowsFormsApp1.Views.MovementsType_Module.UC_MovementsType();
            this.mainDashboard1 = new WindowsFormsApp1.Views.MainDashboard();
            this.uC_PurchasesMenu1 = new WindowsFormsApp1.Views.UC_PurchasesMenu();
            this.uC_WarehouseMovement1 = new WindowsFormsApp1.Views.Warehouse_Module.UC_WarehouseMovement();
            this.typeWarehouseMain1 = new WindowsFormsApp1.Views.Warehouse_M_Module.TypeWarehouseMain();
            this.warehouse1 = new WindowsFormsApp1.Views.Warehouse();
            this.workersPerformance_Report1 = new WindowsFormsApp1.Views.WorkersPerformance_Report();
            this.uC_LogReport1 = new WindowsFormsApp1.Views.UC_LogReport();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 27);
            this.panel2.TabIndex = 10;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(801, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox_MouseHover);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(822, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox_MouseHover);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox4.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(843, 0);
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.panel1.Controls.Add(this.btn_reportes);
            this.panel1.Controls.Add(this.btn_simulation);
            this.panel1.Controls.Add(this.btn_production);
            this.panel1.Controls.Add(this.btn_purchase);
            this.panel1.Controls.Add(this.btn_sales);
            this.panel1.Controls.Add(this.btn_warehouse);
            this.panel1.Controls.Add(this.btn_config);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 379);
            this.panel1.TabIndex = 11;
            // 
            // btn_reportes
            // 
            this.btn_reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reportes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes.ForeColor = System.Drawing.Color.White;
            this.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.ImageIndex = 1;
            this.btn_reportes.ImageList = this.report_imagelist;
            this.btn_reportes.Location = new System.Drawing.Point(0, 297);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(141, 42);
            this.btn_reportes.TabIndex = 8;
            this.btn_reportes.Text = "Reportes";
            this.btn_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reportes.UseVisualStyleBackColor = false;
            this.btn_reportes.Click += new System.EventHandler(this.button1_Click);
            this.btn_reportes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menuButton_Click);
            // 
            // report_imagelist
            // 
            this.report_imagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("report_imagelist.ImageStream")));
            this.report_imagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.report_imagelist.Images.SetKeyName(0, "green_Increase_20px.png");
            this.report_imagelist.Images.SetKeyName(1, "Increase_20px.png");
            // 
            // btn_simulation
            // 
            this.btn_simulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_simulation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_simulation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_simulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_simulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simulation.ForeColor = System.Drawing.Color.White;
            this.btn_simulation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_simulation.ImageIndex = 1;
            this.btn_simulation.ImageList = this.simulation_imagelist;
            this.btn_simulation.Location = new System.Drawing.Point(0, 255);
            this.btn_simulation.Name = "btn_simulation";
            this.btn_simulation.Size = new System.Drawing.Size(141, 42);
            this.btn_simulation.TabIndex = 7;
            this.btn_simulation.Text = "Simulación";
            this.btn_simulation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_simulation.UseVisualStyleBackColor = false;
            this.btn_simulation.Click += new System.EventHandler(this.btn_simulation_Click);
            this.btn_simulation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menuButton_Click);
            // 
            // simulation_imagelist
            // 
            this.simulation_imagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("simulation_imagelist.ImageStream")));
            this.simulation_imagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.simulation_imagelist.Images.SetKeyName(0, "green_VirtualBox_20px.png");
            this.simulation_imagelist.Images.SetKeyName(1, "VirtualBox_20px.png");
            // 
            // btn_production
            // 
            this.btn_production.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_production.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_production.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_production.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_production.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_production.ForeColor = System.Drawing.Color.White;
            this.btn_production.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_production.ImageIndex = 1;
            this.btn_production.ImageList = this.production_imagelist;
            this.btn_production.Location = new System.Drawing.Point(0, 213);
            this.btn_production.Name = "btn_production";
            this.btn_production.Size = new System.Drawing.Size(141, 42);
            this.btn_production.TabIndex = 6;
            this.btn_production.Text = "Producción";
            this.btn_production.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_production.UseVisualStyleBackColor = false;
            this.btn_production.Click += new System.EventHandler(this.btn_production_Click);
            this.btn_production.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menuButton_Click);
            // 
            // production_imagelist
            // 
            this.production_imagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("production_imagelist.ImageStream")));
            this.production_imagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.production_imagelist.Images.SetKeyName(0, "green_Hammer_20px.png");
            this.production_imagelist.Images.SetKeyName(1, "Hammer_20px.png");
            // 
            // btn_purchase
            // 
            this.btn_purchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_purchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_purchase.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchase.ForeColor = System.Drawing.Color.White;
            this.btn_purchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_purchase.ImageIndex = 1;
            this.btn_purchase.ImageList = this.purchase_imagelist;
            this.btn_purchase.Location = new System.Drawing.Point(0, 171);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(141, 42);
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
            this.purchase_imagelist.Images.SetKeyName(0, "Shopping Cart_20px.png");
            this.purchase_imagelist.Images.SetKeyName(1, "Shopping Cart_52px.png");
            // 
            // btn_sales
            // 
            this.btn_sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_sales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sales.ForeColor = System.Drawing.Color.White;
            this.btn_sales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sales.ImageIndex = 1;
            this.btn_sales.ImageList = this.sales_imagelist;
            this.btn_sales.Location = new System.Drawing.Point(0, 129);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(141, 42);
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
            this.sales_imagelist.Images.SetKeyName(0, "Sales Performance_20px.png");
            this.sales_imagelist.Images.SetKeyName(1, "Sales Performance_64px.png");
            // 
            // btn_warehouse
            // 
            this.btn_warehouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_warehouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_warehouse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_warehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_warehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_warehouse.ForeColor = System.Drawing.Color.White;
            this.btn_warehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_warehouse.ImageIndex = 1;
            this.btn_warehouse.ImageList = this.warehouse_imagelist;
            this.btn_warehouse.Location = new System.Drawing.Point(0, 87);
            this.btn_warehouse.Name = "btn_warehouse";
            this.btn_warehouse.Size = new System.Drawing.Size(141, 42);
            this.btn_warehouse.TabIndex = 3;
            this.btn_warehouse.Text = "Almacén";
            this.btn_warehouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_warehouse.UseVisualStyleBackColor = false;
            this.btn_warehouse.Click += new System.EventHandler(this.btn_warehouse_Click_2);
            this.btn_warehouse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menuButton_Click);
            // 
            // warehouse_imagelist
            // 
            this.warehouse_imagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("warehouse_imagelist.ImageStream")));
            this.warehouse_imagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.warehouse_imagelist.Images.SetKeyName(0, "Move by Trolley_20px.png");
            this.warehouse_imagelist.Images.SetKeyName(1, "Hangar_64px.png");
            // 
            // btn_config
            // 
            this.btn_config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_config.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_config.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_config.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_config.ForeColor = System.Drawing.Color.White;
            this.btn_config.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_config.ImageIndex = 1;
            this.btn_config.ImageList = this.config_imagelist;
            this.btn_config.Location = new System.Drawing.Point(0, 45);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(141, 42);
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
            this.config_imagelist.Images.SetKeyName(0, "Settings_48px.png");
            this.config_imagelist.Images.SetKeyName(1, "Settings_48px.png");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_logo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 45);
            this.panel3.TabIndex = 0;
            // 
            // btn_logo
            // 
            this.btn_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_logo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_logo.FlatAppearance.BorderSize = 0;
            this.btn_logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logo.ForeColor = System.Drawing.Color.White;
            this.btn_logo.Image = ((System.Drawing.Image)(resources.GetObject("btn_logo.Image")));
            this.btn_logo.Location = new System.Drawing.Point(0, 0);
            this.btn_logo.Name = "btn_logo";
            this.btn_logo.Size = new System.Drawing.Size(141, 45);
            this.btn_logo.TabIndex = 6;
            this.btn_logo.Text = "INCA ART";
            this.btn_logo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_logo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_logo.UseVisualStyleBackColor = false;
            this.btn_logo.Click += new System.EventHandler(this.btn_logo_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.panel4.Controls.Add(this.label_user_role);
            this.panel4.Controls.Add(this.label_user_name);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(141, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(723, 45);
            this.panel4.TabIndex = 12;
            // 
            // label_user_role
            // 
            this.label_user_role.AutoSize = true;
            this.label_user_role.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_user_role.ForeColor = System.Drawing.Color.White;
            this.label_user_role.Location = new System.Drawing.Point(513, 0);
            this.label_user_role.Name = "label_user_role";
            this.label_user_role.Size = new System.Drawing.Size(101, 19);
            this.label_user_role.TabIndex = 2;
            this.label_user_role.Text = "(Administrador)";
            this.label_user_role.UseCustomBackColor = true;
            this.label_user_role.UseCustomForeColor = true;
            // 
            // label_user_name
            // 
            this.label_user_name.AutoSize = true;
            this.label_user_name.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_user_name.ForeColor = System.Drawing.Color.White;
            this.label_user_name.Location = new System.Drawing.Point(614, 0);
            this.label_user_name.Name = "label_user_name";
            this.label_user_name.Size = new System.Drawing.Size(78, 19);
            this.label_user_name.Style = MetroFramework.MetroColorStyle.White;
            this.label_user_name.TabIndex = 1;
            this.label_user_name.Text = "Rony Cueva";
            this.label_user_name.UseCustomBackColor = true;
            this.label_user_name.UseCustomForeColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(692, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.metroLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(1067, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 64;
            this.metroLabel1.Text = "Cerrar Sesión";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.Visible = false;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            this.metroLabel1.Leave += new System.EventHandler(this.metroLabel1_Leave);
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.uc_recipe);
            this.panel5.Controls.Add(this.supplier1);
            this.panel5.Controls.Add(this.profile);
            this.panel5.Controls.Add(this.parameters1);
            this.panel5.Controls.Add(this.shift);
            this.panel5.Controls.Add(this.user);
            this.panel5.Controls.Add(this.uc_workstation);
            this.panel5.Controls.Add(this.uc_worker);
            this.panel5.Controls.Add(this.uC_Simulation1);
            this.panel5.Controls.Add(this.uC_SalesMain1);
            this.panel5.Controls.Add(this.client1);
            this.panel5.Controls.Add(this.uc_reports);
            this.panel5.Controls.Add(this.uc_ratio);
            this.panel5.Controls.Add(this.uc_product);
            this.panel5.Controls.Add(this.uC_CurrencyMain1);
            this.panel5.Controls.Add(this.uc_material);
            this.panel5.Controls.Add(this.uc_ProductionMenu);
            this.panel5.Controls.Add(this.uC_MovementsType1);
            this.panel5.Controls.Add(this.mainDashboard1);
            this.panel5.Controls.Add(this.uC_PurchasesMenu1);
            this.panel5.Controls.Add(this.uC_WarehouseMovement1);
            this.panel5.Controls.Add(this.typeWarehouseMain1);
            this.panel5.Controls.Add(this.warehouse1);
            this.panel5.Controls.Add(this.workersPerformance_Report1);
            this.panel5.Controls.Add(this.uC_LogReport1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(141, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(723, 334);
            this.panel5.TabIndex = 66;
            // 
            // uc_recipe
            // 
            this.uc_recipe.AutoScroll = true;
            this.uc_recipe.BackColor = System.Drawing.Color.White;
            this.uc_recipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_recipe.Location = new System.Drawing.Point(0, 0);
            this.uc_recipe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uc_recipe.Name = "uc_recipe";
            this.uc_recipe.Size = new System.Drawing.Size(1046, 657);
            this.uc_recipe.TabIndex = 39;
            this.uc_recipe.UseCustomBackColor = true;
            this.uc_recipe.UseSelectable = true;
            this.uc_recipe.Visible = false;
            // 
            // supplier1
            // 
            this.supplier1.BackColor = System.Drawing.Color.White;
            this.supplier1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplier1.Location = new System.Drawing.Point(0, 0);
            this.supplier1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.supplier1.Name = "supplier1";
            this.supplier1.Size = new System.Drawing.Size(1046, 657);
            this.supplier1.TabIndex = 18;
            this.supplier1.UseSelectable = true;
            this.supplier1.Visible = false;
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.SystemColors.Window;
            this.profile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profile.Location = new System.Drawing.Point(0, 0);
            this.profile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(1046, 657);
            this.profile.TabIndex = 27;
            this.profile.UseCustomBackColor = true;
            this.profile.UseSelectable = true;
            // 
            // parameters1
            // 
            this.parameters1.AutoSize = true;
            this.parameters1.BackColor = System.Drawing.Color.White;
            this.parameters1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parameters1.Location = new System.Drawing.Point(0, 0);
            this.parameters1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.parameters1.Name = "parameters1";
            this.parameters1.Size = new System.Drawing.Size(1046, 657);
            this.parameters1.TabIndex = 22;
            this.parameters1.UseSelectable = true;
            this.parameters1.Visible = false;
            // 
            // shift
            // 
            this.shift.BackColor = System.Drawing.Color.White;
            this.shift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shift.Location = new System.Drawing.Point(0, 0);
            this.shift.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shift.Name = "shift";
            this.shift.Size = new System.Drawing.Size(1046, 657);
            this.shift.TabIndex = 28;
            this.shift.Visible = false;
            // 
            // user
            // 
            this.user.AutoScroll = true;
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.SystemColors.Window;
            this.user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user.Location = new System.Drawing.Point(0, 0);
            this.user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(1046, 657);
            this.user.TabIndex = 24;
            this.user.UseCustomBackColor = true;
            this.user.UseSelectable = true;
            this.user.Visible = false;
            // 
            // uc_workstation
            // 
            this.uc_workstation.AutoScroll = true;
            this.uc_workstation.BackColor = System.Drawing.Color.White;
            this.uc_workstation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_workstation.Location = new System.Drawing.Point(0, 0);
            this.uc_workstation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uc_workstation.Name = "uc_workstation";
            this.uc_workstation.Size = new System.Drawing.Size(1046, 657);
            this.uc_workstation.TabIndex = 43;
            this.uc_workstation.UseCustomBackColor = true;
            this.uc_workstation.UseSelectable = true;
            this.uc_workstation.Visible = false;
            // 
            // uc_worker
            // 
            this.uc_worker.AutoScroll = true;
            this.uc_worker.BackColor = System.Drawing.Color.White;
            this.uc_worker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_worker.Location = new System.Drawing.Point(0, 0);
            this.uc_worker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uc_worker.Name = "uc_worker";
            this.uc_worker.Size = new System.Drawing.Size(1046, 657);
            this.uc_worker.TabIndex = 41;
            this.uc_worker.UseCustomBackColor = true;
            this.uc_worker.UseSelectable = true;
            this.uc_worker.Visible = false;
            // 
            // uC_Simulation1
            // 
            this.uC_Simulation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Simulation1.Location = new System.Drawing.Point(0, 0);
            this.uC_Simulation1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uC_Simulation1.Name = "uC_Simulation1";
            this.uC_Simulation1.Size = new System.Drawing.Size(1046, 657);
            this.uC_Simulation1.TabIndex = 45;
            this.uC_Simulation1.Visible = false;
            // 
            // uC_SalesMain1
            // 
            this.uC_SalesMain1.BackColor = System.Drawing.Color.White;
            this.uC_SalesMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_SalesMain1.Location = new System.Drawing.Point(0, 0);
            this.uC_SalesMain1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uC_SalesMain1.Name = "uC_SalesMain1";
            this.uC_SalesMain1.Size = new System.Drawing.Size(1046, 657);
            this.uC_SalesMain1.TabIndex = 31;
            // 
            // client1
            // 
            this.client1.AutoSize = true;
            this.client1.BackColor = System.Drawing.Color.White;
            this.client1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.client1.Location = new System.Drawing.Point(0, 0);
            this.client1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.client1.Name = "client1";
            this.client1.Size = new System.Drawing.Size(1046, 657);
            this.client1.Style = MetroFramework.MetroColorStyle.Teal;
            this.client1.TabIndex = 18;
            this.client1.UseSelectable = true;
            // 
            // uc_reports
            // 
            this.uc_reports.BackColor = System.Drawing.Color.White;
            this.uc_reports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_reports.Location = new System.Drawing.Point(0, 0);
            this.uc_reports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uc_reports.Name = "uc_reports";
            this.uc_reports.Size = new System.Drawing.Size(1046, 657);
            this.uc_reports.TabIndex = 58;
            this.uc_reports.UseSelectable = true;
            this.uc_reports.Visible = false;
            // 
            // uc_ratio
            // 
            this.uc_ratio.AutoScroll = true;
            this.uc_ratio.BackColor = System.Drawing.Color.White;
            this.uc_ratio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_ratio.Location = new System.Drawing.Point(0, 0);
            this.uc_ratio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uc_ratio.Name = "uc_ratio";
            this.uc_ratio.Size = new System.Drawing.Size(1046, 657);
            this.uc_ratio.TabIndex = 47;
            this.uc_ratio.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uc_ratio.UseCustomBackColor = true;
            this.uc_ratio.UseSelectable = true;
            this.uc_ratio.Visible = false;
            // 
            // uc_product
            // 
            this.uc_product.AutoScroll = true;
            this.uc_product.BackColor = System.Drawing.Color.White;
            this.uc_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_product.Location = new System.Drawing.Point(0, 0);
            this.uc_product.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uc_product.Name = "uc_product";
            this.uc_product.Size = new System.Drawing.Size(1046, 657);
            this.uc_product.TabIndex = 37;
            this.uc_product.UseCustomBackColor = true;
            this.uc_product.UseSelectable = true;
            this.uc_product.Visible = false;
            // 
            // uC_CurrencyMain1
            // 
            this.uC_CurrencyMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_CurrencyMain1.Location = new System.Drawing.Point(0, 0);
            this.uC_CurrencyMain1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uC_CurrencyMain1.Name = "uC_CurrencyMain1";
            this.uC_CurrencyMain1.Size = new System.Drawing.Size(1046, 657);
            this.uC_CurrencyMain1.TabIndex = 51;
            this.uC_CurrencyMain1.UseSelectable = true;
            this.uC_CurrencyMain1.Visible = false;
            // 
            // uc_material
            // 
            this.uc_material.AutoScroll = true;
            this.uc_material.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.uc_material.BackColor = System.Drawing.Color.White;
            this.uc_material.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_material.Location = new System.Drawing.Point(0, 0);
            this.uc_material.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uc_material.Name = "uc_material";
            this.uc_material.Size = new System.Drawing.Size(1046, 657);
            this.uc_material.TabIndex = 35;
            this.uc_material.UseCustomBackColor = true;
            this.uc_material.UseSelectable = true;
            this.uc_material.Visible = false;
            // 
            // uc_ProductionMenu
            // 
            this.uc_ProductionMenu.BackColor = System.Drawing.SystemColors.Control;
            this.uc_ProductionMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_ProductionMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_ProductionMenu.Location = new System.Drawing.Point(0, 0);
            this.uc_ProductionMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uc_ProductionMenu.Name = "uc_ProductionMenu";
            this.uc_ProductionMenu.Size = new System.Drawing.Size(1046, 657);
            this.uc_ProductionMenu.TabIndex = 65;
            this.uc_ProductionMenu.UseSelectable = true;
            this.uc_ProductionMenu.Visible = false;
            // 
            // uC_MovementsType1
            // 
            this.uC_MovementsType1.AutoSize = true;
            this.uC_MovementsType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_MovementsType1.Location = new System.Drawing.Point(0, 0);
            this.uC_MovementsType1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_MovementsType1.Name = "uC_MovementsType1";
            this.uC_MovementsType1.Size = new System.Drawing.Size(1046, 657);
            this.uC_MovementsType1.TabIndex = 64;
            this.uC_MovementsType1.UseSelectable = true;
            this.uC_MovementsType1.Visible = false;
            // 
            // mainDashboard1
            // 
            this.mainDashboard1.BackColor = System.Drawing.Color.White;
            this.mainDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDashboard1.Location = new System.Drawing.Point(0, 0);
            this.mainDashboard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainDashboard1.Name = "mainDashboard1";
            this.mainDashboard1.Size = new System.Drawing.Size(1046, 657);
            this.mainDashboard1.TabIndex = 13;
            this.mainDashboard1.UseSelectable = true;
            // 
            // uC_PurchasesMenu1
            // 
            this.uC_PurchasesMenu1.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.uC_PurchasesMenu1.AutoSize = true;
            this.uC_PurchasesMenu1.BackColor = System.Drawing.SystemColors.Control;
            this.uC_PurchasesMenu1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_PurchasesMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_PurchasesMenu1.Location = new System.Drawing.Point(0, 0);
            this.uC_PurchasesMenu1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uC_PurchasesMenu1.Name = "uC_PurchasesMenu1";
            this.uC_PurchasesMenu1.Size = new System.Drawing.Size(1046, 657);
            this.uC_PurchasesMenu1.TabIndex = 16;
            this.uC_PurchasesMenu1.Visible = false;
            // 
            // uC_WarehouseMovement1
            // 
            this.uC_WarehouseMovement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_WarehouseMovement1.Location = new System.Drawing.Point(0, 0);
            this.uC_WarehouseMovement1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uC_WarehouseMovement1.Name = "uC_WarehouseMovement1";
            this.uC_WarehouseMovement1.Size = new System.Drawing.Size(1046, 657);
            this.uC_WarehouseMovement1.TabIndex = 47;
            this.uC_WarehouseMovement1.Visible = false;
            // 
            // typeWarehouseMain1
            // 
            this.typeWarehouseMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeWarehouseMain1.Location = new System.Drawing.Point(0, 0);
            this.typeWarehouseMain1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.typeWarehouseMain1.Name = "typeWarehouseMain1";
            this.typeWarehouseMain1.Size = new System.Drawing.Size(1046, 657);
            this.typeWarehouseMain1.TabIndex = 47;
            this.typeWarehouseMain1.UseSelectable = true;
            this.typeWarehouseMain1.Visible = false;
            // 
            // warehouse1
            // 
            this.warehouse1.AutoScroll = true;
            this.warehouse1.AutoSize = true;
            this.warehouse1.BackColor = System.Drawing.Color.White;
            this.warehouse1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warehouse1.Location = new System.Drawing.Point(0, 0);
            this.warehouse1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.warehouse1.Name = "warehouse1";
            this.warehouse1.Size = new System.Drawing.Size(1046, 657);
            this.warehouse1.Style = MetroFramework.MetroColorStyle.Blue;
            this.warehouse1.TabIndex = 66;
            this.warehouse1.UseCustomBackColor = true;
            this.warehouse1.UseCustomForeColor = true;
            this.warehouse1.UseSelectable = true;
            this.warehouse1.UseStyleColors = true;
            // 
            // workersPerformance_Report1
            // 
            this.workersPerformance_Report1.Location = new System.Drawing.Point(0, 0);
            this.workersPerformance_Report1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.workersPerformance_Report1.Name = "workersPerformance_Report1";
            this.workersPerformance_Report1.Size = new System.Drawing.Size(1046, 640);
            this.workersPerformance_Report1.TabIndex = 60;
            // 
            // uC_LogReport1
            // 
            this.uC_LogReport1.Location = new System.Drawing.Point(0, 81);
            this.uC_LogReport1.Name = "uC_LogReport1";
            this.uC_LogReport1.Size = new System.Drawing.Size(907, 576);
            this.uC_LogReport1.TabIndex = 67;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 406);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private MetroFramework.Controls.MetroLabel label_user_role;
        private MetroFramework.Controls.MetroLabel label_user_name;
        private System.Windows.Forms.ImageList config_imagelist;
        private System.Windows.Forms.ImageList warehouse_imagelist;
        private System.Windows.Forms.ImageList sales_imagelist;
        private System.Windows.Forms.ImageList purchase_imagelist;
        private UC_PurchasesMenu uC_PurchasesMenu1;
        private Supplier supplier1;
        private Client client1;
        private Parameters parameters1;
        private UC_User user;
        private UC_Profile profile;
        private UC_Shift shift;
        private UC_SalesMain uC_SalesMain1;
        private UC_Material uc_material;
        private UC_Product uc_product;
        private UC_Recipe uc_recipe;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_production;
        private UC_Workstation uc_workstation;
        private System.Windows.Forms.Button btn_simulation;
        private UC_Simulation uC_Simulation1;
        private System.Windows.Forms.ImageList simulation_imagelist;
        private System.Windows.Forms.ImageList production_imagelist;
        private Warehouse_M_Module.TypeWarehouseMain typeWarehouseMain1;
        private UC_WarehouseMovement uC_WarehouseMovement1;
        private UC_Ratio uc_ratio;
        private Currency_Module.UC_CurrencyMain uC_CurrencyMain1;
        private System.Windows.Forms.Button btn_reportes;
        private WindowsFormsApp1.Views.Reports_Module.ReportDashboard uc_reports;
        private WorkersPerformance_Report workersPerformance_Report1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private UC_Worker uc_worker;
        private System.Windows.Forms.ImageList report_imagelist;
        private System.Windows.Forms.Panel panel5;
        private Production_Module.UC_ProductionMenu uc_ProductionMenu;
        private MovementsType_Module.UC_MovementsType uC_MovementsType1;
        private Warehouse warehouse1;
        private UC_LogReport uC_LogReport1;
    }
}