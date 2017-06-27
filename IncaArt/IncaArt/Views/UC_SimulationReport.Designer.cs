namespace WindowsFormsApp1.Views
{
    partial class UC_SimulationReport
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accuracy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products_per_hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_total_products_per_hour = new MetroFramework.Controls.MetroTextBox();
            this.txt_total_accuracy = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accuracy1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.production_line1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simulationreportheaderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accuracyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simulationReportHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simulationReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationReportHeaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroTabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 549);
            this.panel1.TabIndex = 0;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(825, 549);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.VisibleChanged += new System.EventHandler(this.metroTabControl1_VisibleChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.panel2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(817, 507);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Reportes";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.metroGrid2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 507);
            this.panel2.TabIndex = 2;
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToAddRows = false;
            this.metroGrid2.AllowUserToDeleteRows = false;
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.AutoGenerateColumns = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.White;
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.accuracy,
            this.products_per_hour,
            this.simulationreportheaderidDataGridViewTextBoxColumn,
            this.accuracyDataGridViewTextBoxColumn1,
            this.productsDataGridViewTextBoxColumn});
            this.metroGrid2.DataSource = this.simulationReportHeaderBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(0, 0);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.ReadOnly = true;
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(817, 507);
            this.metroGrid2.TabIndex = 3;
            this.metroGrid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid2_CellDoubleClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "simulation_report_header_id";
            this.id.HeaderText = "Identificador";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // accuracy
            // 
            this.accuracy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accuracy.DataPropertyName = "accuracy";
            this.accuracy.HeaderText = "Productos Rotos por Hora";
            this.accuracy.Name = "accuracy";
            this.accuracy.ReadOnly = true;
            // 
            // products_per_hour
            // 
            this.products_per_hour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.products_per_hour.DataPropertyName = "products";
            this.products_per_hour.HeaderText = "Productos por Hora";
            this.products_per_hour.Name = "products_per_hour";
            this.products_per_hour.ReadOnly = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.panel3);
            this.metroTabPage2.Controls.Add(this.metroGrid1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(817, 507);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Detalle";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txt_total_products_per_hour);
            this.panel3.Controls.Add(this.txt_total_accuracy);
            this.panel3.Controls.Add(this.metroLabel1);
            this.panel3.Controls.Add(this.metroLabel11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 471);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 36);
            this.panel3.TabIndex = 4;
            // 
            // txt_total_products_per_hour
            // 
            this.txt_total_products_per_hour.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_total_products_per_hour.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_total_products_per_hour.CustomButton.Image = null;
            this.txt_total_products_per_hour.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.txt_total_products_per_hour.CustomButton.Name = "";
            this.txt_total_products_per_hour.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_total_products_per_hour.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_total_products_per_hour.CustomButton.TabIndex = 1;
            this.txt_total_products_per_hour.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_total_products_per_hour.CustomButton.UseSelectable = true;
            this.txt_total_products_per_hour.CustomButton.UseVisualStyleBackColor = false;
            this.txt_total_products_per_hour.CustomButton.Visible = false;
            this.txt_total_products_per_hour.Enabled = false;
            this.txt_total_products_per_hour.Lines = new string[0];
            this.txt_total_products_per_hour.Location = new System.Drawing.Point(551, 3);
            this.txt_total_products_per_hour.MaxLength = 32767;
            this.txt_total_products_per_hour.Name = "txt_total_products_per_hour";
            this.txt_total_products_per_hour.PasswordChar = '\0';
            this.txt_total_products_per_hour.ReadOnly = true;
            this.txt_total_products_per_hour.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_total_products_per_hour.SelectedText = "";
            this.txt_total_products_per_hour.SelectionLength = 0;
            this.txt_total_products_per_hour.SelectionStart = 0;
            this.txt_total_products_per_hour.ShortcutsEnabled = true;
            this.txt_total_products_per_hour.Size = new System.Drawing.Size(93, 29);
            this.txt_total_products_per_hour.TabIndex = 53;
            this.txt_total_products_per_hour.UseCustomBackColor = true;
            this.txt_total_products_per_hour.UseSelectable = true;
            this.txt_total_products_per_hour.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_total_products_per_hour.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_total_accuracy
            // 
            this.txt_total_accuracy.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_total_accuracy.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_total_accuracy.CustomButton.Image = null;
            this.txt_total_accuracy.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.txt_total_accuracy.CustomButton.Name = "";
            this.txt_total_accuracy.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_total_accuracy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_total_accuracy.CustomButton.TabIndex = 1;
            this.txt_total_accuracy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_total_accuracy.CustomButton.UseSelectable = true;
            this.txt_total_accuracy.CustomButton.UseVisualStyleBackColor = false;
            this.txt_total_accuracy.CustomButton.Visible = false;
            this.txt_total_accuracy.Enabled = false;
            this.txt_total_accuracy.Lines = new string[0];
            this.txt_total_accuracy.Location = new System.Drawing.Point(279, 4);
            this.txt_total_accuracy.MaxLength = 32767;
            this.txt_total_accuracy.Name = "txt_total_accuracy";
            this.txt_total_accuracy.PasswordChar = '\0';
            this.txt_total_accuracy.ReadOnly = true;
            this.txt_total_accuracy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_total_accuracy.SelectedText = "";
            this.txt_total_accuracy.SelectionLength = 0;
            this.txt_total_accuracy.SelectionStart = 0;
            this.txt_total_accuracy.ShortcutsEnabled = true;
            this.txt_total_accuracy.Size = new System.Drawing.Size(93, 29);
            this.txt_total_accuracy.TabIndex = 52;
            this.txt_total_accuracy.UseCustomBackColor = true;
            this.txt_total_accuracy.UseSelectable = true;
            this.txt_total_accuracy.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_total_accuracy.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.White;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel1.Location = new System.Drawing.Point(394, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(151, 15);
            this.metroLabel1.TabIndex = 51;
            this.metroLabel1.Text = "Total Productos por Hora :";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.White;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel11.Location = new System.Drawing.Point(101, 3);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(172, 15);
            this.metroLabel11.TabIndex = 50;
            this.metroLabel11.Text = "Total Cantidad Rota por Hora :";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.White;
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.worker,
            this.workstation,
            this.product,
            this.accuracy1,
            this.products1,
            this.production_line1});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 0);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(817, 507);
            this.metroGrid1.TabIndex = 3;
            // 
            // worker
            // 
            this.worker.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.worker.HeaderText = "Trabajador";
            this.worker.Name = "worker";
            this.worker.ReadOnly = true;
            // 
            // workstation
            // 
            this.workstation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workstation.HeaderText = "Puesto de Trabajo";
            this.workstation.Name = "workstation";
            this.workstation.ReadOnly = true;
            // 
            // product
            // 
            this.product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product.HeaderText = "Producto";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            // 
            // accuracy1
            // 
            this.accuracy1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accuracy1.HeaderText = "Cantidad Rota por Hora";
            this.accuracy1.Name = "accuracy1";
            this.accuracy1.ReadOnly = true;
            // 
            // products1
            // 
            this.products1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.products1.HeaderText = "Productos por Hora";
            this.products1.Name = "products1";
            this.products1.ReadOnly = true;
            // 
            // production_line1
            // 
            this.production_line1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.production_line1.HeaderText = "Línea de Producción";
            this.production_line1.Name = "production_line1";
            this.production_line1.ReadOnly = true;
            // 
            // simulationreportheaderidDataGridViewTextBoxColumn
            // 
            this.simulationreportheaderidDataGridViewTextBoxColumn.DataPropertyName = "simulation_report_header_id";
            this.simulationreportheaderidDataGridViewTextBoxColumn.HeaderText = "simulation_report_header_id";
            this.simulationreportheaderidDataGridViewTextBoxColumn.Name = "simulationreportheaderidDataGridViewTextBoxColumn";
            this.simulationreportheaderidDataGridViewTextBoxColumn.ReadOnly = true;
            this.simulationreportheaderidDataGridViewTextBoxColumn.Visible = false;
            // 
            // accuracyDataGridViewTextBoxColumn1
            // 
            this.accuracyDataGridViewTextBoxColumn1.DataPropertyName = "accuracy";
            this.accuracyDataGridViewTextBoxColumn1.HeaderText = "accuracy";
            this.accuracyDataGridViewTextBoxColumn1.Name = "accuracyDataGridViewTextBoxColumn1";
            this.accuracyDataGridViewTextBoxColumn1.ReadOnly = true;
            this.accuracyDataGridViewTextBoxColumn1.Visible = false;
            // 
            // productsDataGridViewTextBoxColumn
            // 
            this.productsDataGridViewTextBoxColumn.DataPropertyName = "products";
            this.productsDataGridViewTextBoxColumn.HeaderText = "products";
            this.productsDataGridViewTextBoxColumn.Name = "productsDataGridViewTextBoxColumn";
            this.productsDataGridViewTextBoxColumn.ReadOnly = true;
            this.productsDataGridViewTextBoxColumn.Visible = false;
            // 
            // simulationReportHeaderBindingSource
            // 
            this.simulationReportHeaderBindingSource.DataSource = typeof(WindowsFormsApp1.Models.SimulationReportHeader);
            // 
            // simulationReportBindingSource
            // 
            this.simulationReportBindingSource.DataSource = typeof(WindowsFormsApp1.Models.SimulationReport);
            // 
            // UC_SimulationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "UC_SimulationReport";
            this.Size = new System.Drawing.Size(825, 549);
            this.panel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationReportHeaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource simulationReportBindingSource;
        private System.Windows.Forms.BindingSource simulationReportHeaderBindingSource;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn accuracy;
        private System.Windows.Forms.DataGridViewTextBoxColumn products_per_hour;
        private System.Windows.Forms.DataGridViewTextBoxColumn simulationreportheaderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accuracyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroTextBox txt_total_products_per_hour;
        private MetroFramework.Controls.MetroTextBox txt_total_accuracy;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn workstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn accuracy1;
        private System.Windows.Forms.DataGridViewTextBoxColumn products1;
        private System.Windows.Forms.DataGridViewTextBoxColumn production_line1;
    }
}
