namespace WindowsFormsApp1.Views.Sales_Module
{
    partial class UC_SalesEstimate
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
            this.tab_Estimate = new MetroFramework.Controls.MetroTabControl();
            this.order = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.gb_Estimates = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grid_estimates = new MetroFramework.Controls.MetroGrid();
            this.currencyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencysymbolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerdoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimate_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issue_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesEstimateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gb_Filter = new System.Windows.Forms.GroupBox();
            this.btn_Search_Estimates = new System.Windows.Forms.Button();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.btn_SearchClient = new MetroFramework.Controls.MetroTile();
            this.ctxt_estimate_id = new MetroFramework.Controls.MetroTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ctxt_customer = new MetroFramework.Controls.MetroTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.newOrder = new System.Windows.Forms.TabPage();
            this.gb_Estimate = new System.Windows.Forms.GroupBox();
            this.dt_IssueHour = new MetroFramework.Controls.MetroDateTime();
            this.cbo_Currency = new MetroFramework.Controls.MetroComboBox();
            this.dt_IssueDate = new MetroFramework.Controls.MetroDateTime();
            this.txt_idEstimate = new MetroFramework.Controls.MetroTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_Client = new System.Windows.Forms.GroupBox();
            this.btn_Search_Client = new MetroFramework.Controls.MetroTile();
            this.txt_Doi = new MetroFramework.Controls.MetroTextBox();
            this.txt_address = new MetroFramework.Controls.MetroTextBox();
            this.txt_phone = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Status = new MetroFramework.Controls.MetroTextBox();
            this.txt_observation = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_amount = new MetroFramework.Controls.MetroTextBox();
            this.btn_Clean = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_EstimateLine = new System.Windows.Forms.GroupBox();
            this.btn_New = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grid_estimate_lines = new MetroFramework.Controls.MetroGrid();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Estimate_id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delivery_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_warehouse_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tab_Estimate.SuspendLayout();
            this.order.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gb_Estimates.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_estimates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesEstimateBindingSource)).BeginInit();
            this.gb_Filter.SuspendLayout();
            this.newOrder.SuspendLayout();
            this.gb_Estimate.SuspendLayout();
            this.gb_Client.SuspendLayout();
            this.gb_EstimateLine.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_estimate_lines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tab_Estimate);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 615);
            this.panel1.TabIndex = 0;
            // 
            // tab_Estimate
            // 
            this.tab_Estimate.CausesValidation = false;
            this.tab_Estimate.Controls.Add(this.order);
            this.tab_Estimate.Controls.Add(this.newOrder);
            this.tab_Estimate.Location = new System.Drawing.Point(10, 5);
            this.tab_Estimate.Name = "tab_Estimate";
            this.tab_Estimate.SelectedIndex = 1;
            this.tab_Estimate.Size = new System.Drawing.Size(849, 608);
            this.tab_Estimate.Style = MetroFramework.MetroColorStyle.Teal;
            this.tab_Estimate.TabIndex = 42;
            this.tab_Estimate.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tab_Estimate.UseCustomForeColor = true;
            this.tab_Estimate.UseSelectable = true;
            this.tab_Estimate.UseStyleColors = true;
            this.tab_Estimate.SelectedIndexChanged += new System.EventHandler(this.tab_Estimate_SelectedIndexChanged);
            // 
            // order
            // 
            this.order.BackColor = System.Drawing.Color.White;
            this.order.Controls.Add(this.panel3);
            this.order.Location = new System.Drawing.Point(4, 38);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(841, 566);
            this.order.TabIndex = 1;
            this.order.Text = "Consulta";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Edit);
            this.panel3.Controls.Add(this.btn_Delete);
            this.panel3.Controls.Add(this.gb_Estimates);
            this.panel3.Controls.Add(this.gb_Filter);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(835, 538);
            this.panel3.TabIndex = 1;
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Location = new System.Drawing.Point(300, 495);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(82, 29);
            this.btn_Edit.TabIndex = 48;
            this.btn_Edit.Text = "Editar";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(445, 495);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(82, 29);
            this.btn_Delete.TabIndex = 49;
            this.btn_Delete.Text = "Anular";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // gb_Estimates
            // 
            this.gb_Estimates.BackColor = System.Drawing.Color.White;
            this.gb_Estimates.Controls.Add(this.panel4);
            this.gb_Estimates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Estimates.ForeColor = System.Drawing.Color.Black;
            this.gb_Estimates.Location = new System.Drawing.Point(14, 184);
            this.gb_Estimates.Name = "gb_Estimates";
            this.gb_Estimates.Size = new System.Drawing.Size(811, 289);
            this.gb_Estimates.TabIndex = 46;
            this.gb_Estimates.TabStop = false;
            this.gb_Estimates.Text = "Cotizaciones";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grid_estimates);
            this.panel4.Location = new System.Drawing.Point(9, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(792, 255);
            this.panel4.TabIndex = 0;
            // 
            // grid_estimates
            // 
            this.grid_estimates.AllowUserToAddRows = false;
            this.grid_estimates.AllowUserToDeleteRows = false;
            this.grid_estimates.AllowUserToResizeRows = false;
            this.grid_estimates.AutoGenerateColumns = false;
            this.grid_estimates.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_estimates.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_estimates.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_estimates.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_estimates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_estimates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_estimates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currencyidDataGridViewTextBoxColumn,
            this.currencysymbolDataGridViewTextBoxColumn,
            this.customeridDataGridViewTextBoxColumn,
            this.customerdoiDataGridViewTextBoxColumn,
            this.customeraddressDataGridViewTextBoxColumn,
            this.customerphoneDataGridViewTextBoxColumn,
            this.customertypeDataGridViewTextBoxColumn,
            this.estimate_id,
            this.customer_name,
            this.currency_name,
            this.issue_date,
            this.amount2,
            this.observation,
            this.status});
            this.grid_estimates.DataSource = this.salesEstimateBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_estimates.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_estimates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_estimates.EnableHeadersVisualStyles = false;
            this.grid_estimates.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_estimates.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_estimates.Location = new System.Drawing.Point(0, 0);
            this.grid_estimates.Name = "grid_estimates";
            this.grid_estimates.ReadOnly = true;
            this.grid_estimates.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_estimates.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_estimates.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid_estimates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_estimates.Size = new System.Drawing.Size(792, 255);
            this.grid_estimates.TabIndex = 51;
            // 
            // currencyidDataGridViewTextBoxColumn
            // 
            this.currencyidDataGridViewTextBoxColumn.DataPropertyName = "Currency_id";
            this.currencyidDataGridViewTextBoxColumn.HeaderText = "Currency_id";
            this.currencyidDataGridViewTextBoxColumn.Name = "currencyidDataGridViewTextBoxColumn";
            this.currencyidDataGridViewTextBoxColumn.ReadOnly = true;
            this.currencyidDataGridViewTextBoxColumn.Visible = false;
            // 
            // currencysymbolDataGridViewTextBoxColumn
            // 
            this.currencysymbolDataGridViewTextBoxColumn.DataPropertyName = "Currency_symbol";
            this.currencysymbolDataGridViewTextBoxColumn.HeaderText = "Currency_symbol";
            this.currencysymbolDataGridViewTextBoxColumn.Name = "currencysymbolDataGridViewTextBoxColumn";
            this.currencysymbolDataGridViewTextBoxColumn.ReadOnly = true;
            this.currencysymbolDataGridViewTextBoxColumn.Visible = false;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "Customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "Customer_id";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.ReadOnly = true;
            this.customeridDataGridViewTextBoxColumn.Visible = false;
            // 
            // customerdoiDataGridViewTextBoxColumn
            // 
            this.customerdoiDataGridViewTextBoxColumn.DataPropertyName = "Customer_doi";
            this.customerdoiDataGridViewTextBoxColumn.HeaderText = "Customer_doi";
            this.customerdoiDataGridViewTextBoxColumn.Name = "customerdoiDataGridViewTextBoxColumn";
            this.customerdoiDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerdoiDataGridViewTextBoxColumn.Visible = false;
            // 
            // customeraddressDataGridViewTextBoxColumn
            // 
            this.customeraddressDataGridViewTextBoxColumn.DataPropertyName = "Customer_address";
            this.customeraddressDataGridViewTextBoxColumn.HeaderText = "Customer_address";
            this.customeraddressDataGridViewTextBoxColumn.Name = "customeraddressDataGridViewTextBoxColumn";
            this.customeraddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.customeraddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // customerphoneDataGridViewTextBoxColumn
            // 
            this.customerphoneDataGridViewTextBoxColumn.DataPropertyName = "Customer_phone";
            this.customerphoneDataGridViewTextBoxColumn.HeaderText = "Customer_phone";
            this.customerphoneDataGridViewTextBoxColumn.Name = "customerphoneDataGridViewTextBoxColumn";
            this.customerphoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerphoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // customertypeDataGridViewTextBoxColumn
            // 
            this.customertypeDataGridViewTextBoxColumn.DataPropertyName = "Customer_type";
            this.customertypeDataGridViewTextBoxColumn.HeaderText = "Customer_type";
            this.customertypeDataGridViewTextBoxColumn.Name = "customertypeDataGridViewTextBoxColumn";
            this.customertypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.customertypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // estimate_id
            // 
            this.estimate_id.DataPropertyName = "Id";
            this.estimate_id.HeaderText = "Cotización";
            this.estimate_id.Name = "estimate_id";
            this.estimate_id.ReadOnly = true;
            // 
            // customer_name
            // 
            this.customer_name.DataPropertyName = "Customer_name";
            this.customer_name.HeaderText = "Cliente";
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            this.customer_name.Width = 150;
            // 
            // currency_name
            // 
            this.currency_name.DataPropertyName = "Currency_name";
            this.currency_name.HeaderText = "Moneda";
            this.currency_name.Name = "currency_name";
            this.currency_name.ReadOnly = true;
            // 
            // issue_date
            // 
            this.issue_date.DataPropertyName = "Issue_date";
            this.issue_date.HeaderText = "Fecha de emisión";
            this.issue_date.Name = "issue_date";
            this.issue_date.ReadOnly = true;
            // 
            // amount2
            // 
            this.amount2.DataPropertyName = "Amount";
            this.amount2.HeaderText = "Total";
            this.amount2.Name = "amount2";
            this.amount2.ReadOnly = true;
            // 
            // observation
            // 
            this.observation.DataPropertyName = "Observation";
            this.observation.HeaderText = "Observación";
            this.observation.Name = "observation";
            this.observation.ReadOnly = true;
            this.observation.Width = 150;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "Estado";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // salesEstimateBindingSource
            // 
            this.salesEstimateBindingSource.DataSource = typeof(WindowsFormsApp1.Models.SalesEstimate);
            // 
            // gb_Filter
            // 
            this.gb_Filter.Controls.Add(this.btn_Search_Estimates);
            this.gb_Filter.Controls.Add(this.metroDateTime1);
            this.gb_Filter.Controls.Add(this.metroDateTime2);
            this.gb_Filter.Controls.Add(this.btn_SearchClient);
            this.gb_Filter.Controls.Add(this.ctxt_estimate_id);
            this.gb_Filter.Controls.Add(this.label10);
            this.gb_Filter.Controls.Add(this.ctxt_customer);
            this.gb_Filter.Controls.Add(this.label13);
            this.gb_Filter.Controls.Add(this.label14);
            this.gb_Filter.Controls.Add(this.label15);
            this.gb_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Filter.ForeColor = System.Drawing.Color.Black;
            this.gb_Filter.Location = new System.Drawing.Point(14, 3);
            this.gb_Filter.Name = "gb_Filter";
            this.gb_Filter.Size = new System.Drawing.Size(807, 161);
            this.gb_Filter.TabIndex = 40;
            this.gb_Filter.TabStop = false;
            this.gb_Filter.Text = "Filtros";
            // 
            // btn_Search_Estimates
            // 
            this.btn_Search_Estimates.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Search_Estimates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Estimates.ForeColor = System.Drawing.Color.White;
            this.btn_Search_Estimates.Location = new System.Drawing.Point(358, 126);
            this.btn_Search_Estimates.Name = "btn_Search_Estimates";
            this.btn_Search_Estimates.Size = new System.Drawing.Size(85, 29);
            this.btn_Search_Estimates.TabIndex = 50;
            this.btn_Search_Estimates.Text = "Buscar";
            this.btn_Search_Estimates.UseVisualStyleBackColor = false;
            this.btn_Search_Estimates.Click += new System.EventHandler(this.btn_Search_Estimates_Click);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(562, 24);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(209, 29);
            this.metroDateTime1.TabIndex = 49;
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Location = new System.Drawing.Point(562, 66);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(209, 29);
            this.metroDateTime2.TabIndex = 48;
            // 
            // btn_SearchClient
            // 
            this.btn_SearchClient.ActiveControl = null;
            this.btn_SearchClient.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_SearchClient.Location = new System.Drawing.Point(327, 73);
            this.btn_SearchClient.Name = "btn_SearchClient";
            this.btn_SearchClient.Size = new System.Drawing.Size(41, 29);
            this.btn_SearchClient.TabIndex = 43;
            this.btn_SearchClient.TileImage = global::WindowsFormsApp1.Properties.Resources.Search_16;
            this.btn_SearchClient.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SearchClient.UseCustomBackColor = true;
            this.btn_SearchClient.UseCustomForeColor = true;
            this.btn_SearchClient.UseSelectable = true;
            this.btn_SearchClient.UseStyleColors = true;
            this.btn_SearchClient.UseTileImage = true;
            this.btn_SearchClient.Click += new System.EventHandler(this.btn_SearchClient_Click);
            // 
            // ctxt_estimate_id
            // 
            // 
            // 
            // 
            this.ctxt_estimate_id.CustomButton.Image = null;
            this.ctxt_estimate_id.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.ctxt_estimate_id.CustomButton.Name = "";
            this.ctxt_estimate_id.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ctxt_estimate_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ctxt_estimate_id.CustomButton.TabIndex = 1;
            this.ctxt_estimate_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ctxt_estimate_id.CustomButton.UseSelectable = true;
            this.ctxt_estimate_id.CustomButton.Visible = false;
            this.ctxt_estimate_id.Lines = new string[0];
            this.ctxt_estimate_id.Location = new System.Drawing.Point(104, 28);
            this.ctxt_estimate_id.MaxLength = 32767;
            this.ctxt_estimate_id.Name = "ctxt_estimate_id";
            this.ctxt_estimate_id.PasswordChar = '\0';
            this.ctxt_estimate_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ctxt_estimate_id.SelectedText = "";
            this.ctxt_estimate_id.SelectionLength = 0;
            this.ctxt_estimate_id.SelectionStart = 0;
            this.ctxt_estimate_id.ShortcutsEnabled = true;
            this.ctxt_estimate_id.Size = new System.Drawing.Size(204, 29);
            this.ctxt_estimate_id.TabIndex = 42;
            this.ctxt_estimate_id.UseSelectable = true;
            this.ctxt_estimate_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ctxt_estimate_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(428, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Fecha de Entrega :";
            // 
            // ctxt_customer
            // 
            // 
            // 
            // 
            this.ctxt_customer.CustomButton.Image = null;
            this.ctxt_customer.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.ctxt_customer.CustomButton.Name = "";
            this.ctxt_customer.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ctxt_customer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ctxt_customer.CustomButton.TabIndex = 1;
            this.ctxt_customer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ctxt_customer.CustomButton.UseSelectable = true;
            this.ctxt_customer.CustomButton.Visible = false;
            this.ctxt_customer.Lines = new string[0];
            this.ctxt_customer.Location = new System.Drawing.Point(104, 73);
            this.ctxt_customer.MaxLength = 32767;
            this.ctxt_customer.Name = "ctxt_customer";
            this.ctxt_customer.PasswordChar = '\0';
            this.ctxt_customer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ctxt_customer.SelectedText = "";
            this.ctxt_customer.SelectionLength = 0;
            this.ctxt_customer.SelectionStart = 0;
            this.ctxt_customer.ShortcutsEnabled = true;
            this.ctxt_customer.Size = new System.Drawing.Size(204, 29);
            this.ctxt_customer.TabIndex = 38;
            this.ctxt_customer.UseSelectable = true;
            this.ctxt_customer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ctxt_customer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkCyan;
            this.label13.Location = new System.Drawing.Point(6, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "N° Cotización :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkCyan;
            this.label14.Location = new System.Drawing.Point(6, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Cliente :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkCyan;
            this.label15.Location = new System.Drawing.Point(428, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Fecha de Emisión :";
            // 
            // newOrder
            // 
            this.newOrder.BackColor = System.Drawing.Color.White;
            this.newOrder.CausesValidation = false;
            this.newOrder.Controls.Add(this.gb_Estimate);
            this.newOrder.Controls.Add(this.gb_Client);
            this.newOrder.Controls.Add(this.txt_Status);
            this.newOrder.Controls.Add(this.txt_observation);
            this.newOrder.Controls.Add(this.label3);
            this.newOrder.Controls.Add(this.txt_amount);
            this.newOrder.Controls.Add(this.btn_Clean);
            this.newOrder.Controls.Add(this.btn_Cancel);
            this.newOrder.Controls.Add(this.btn_Save);
            this.newOrder.Controls.Add(this.label6);
            this.newOrder.Controls.Add(this.label5);
            this.newOrder.Controls.Add(this.gb_EstimateLine);
            this.newOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrder.Location = new System.Drawing.Point(4, 38);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(841, 566);
            this.newOrder.TabIndex = 0;
            this.newOrder.Text = "Registro";
            // 
            // gb_Estimate
            // 
            this.gb_Estimate.Controls.Add(this.dt_IssueHour);
            this.gb_Estimate.Controls.Add(this.cbo_Currency);
            this.gb_Estimate.Controls.Add(this.dt_IssueDate);
            this.gb_Estimate.Controls.Add(this.txt_idEstimate);
            this.gb_Estimate.Controls.Add(this.label11);
            this.gb_Estimate.Controls.Add(this.label8);
            this.gb_Estimate.Controls.Add(this.label2);
            this.gb_Estimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Estimate.ForeColor = System.Drawing.Color.Black;
            this.gb_Estimate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gb_Estimate.Location = new System.Drawing.Point(450, 7);
            this.gb_Estimate.Name = "gb_Estimate";
            this.gb_Estimate.Size = new System.Drawing.Size(374, 160);
            this.gb_Estimate.TabIndex = 65;
            this.gb_Estimate.TabStop = false;
            this.gb_Estimate.Text = "Datos de la Cotización";
            // 
            // dt_IssueHour
            // 
            this.dt_IssueHour.Enabled = false;
            this.dt_IssueHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_IssueHour.Location = new System.Drawing.Point(254, 105);
            this.dt_IssueHour.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_IssueHour.Name = "dt_IssueHour";
            this.dt_IssueHour.Size = new System.Drawing.Size(107, 29);
            this.dt_IssueHour.TabIndex = 49;
            // 
            // cbo_Currency
            // 
            this.cbo_Currency.FormattingEnabled = true;
            this.cbo_Currency.ItemHeight = 23;
            this.cbo_Currency.Location = new System.Drawing.Point(134, 64);
            this.cbo_Currency.Name = "cbo_Currency";
            this.cbo_Currency.Size = new System.Drawing.Size(227, 29);
            this.cbo_Currency.TabIndex = 48;
            this.cbo_Currency.UseSelectable = true;
            // 
            // dt_IssueDate
            // 
            this.dt_IssueDate.Enabled = false;
            this.dt_IssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_IssueDate.Location = new System.Drawing.Point(134, 105);
            this.dt_IssueDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_IssueDate.Name = "dt_IssueDate";
            this.dt_IssueDate.Size = new System.Drawing.Size(107, 29);
            this.dt_IssueDate.TabIndex = 47;
            // 
            // txt_idEstimate
            // 
            this.txt_idEstimate.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_idEstimate.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_idEstimate.CustomButton.Image = null;
            this.txt_idEstimate.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txt_idEstimate.CustomButton.Name = "";
            this.txt_idEstimate.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_idEstimate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_idEstimate.CustomButton.TabIndex = 1;
            this.txt_idEstimate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_idEstimate.CustomButton.UseSelectable = true;
            this.txt_idEstimate.CustomButton.UseVisualStyleBackColor = false;
            this.txt_idEstimate.CustomButton.Visible = false;
            this.txt_idEstimate.Enabled = false;
            this.txt_idEstimate.Lines = new string[0];
            this.txt_idEstimate.Location = new System.Drawing.Point(134, 22);
            this.txt_idEstimate.MaxLength = 32767;
            this.txt_idEstimate.Name = "txt_idEstimate";
            this.txt_idEstimate.PasswordChar = '\0';
            this.txt_idEstimate.ReadOnly = true;
            this.txt_idEstimate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_idEstimate.SelectedText = "";
            this.txt_idEstimate.SelectionLength = 0;
            this.txt_idEstimate.SelectionStart = 0;
            this.txt_idEstimate.ShortcutsEnabled = true;
            this.txt_idEstimate.Size = new System.Drawing.Size(227, 29);
            this.txt_idEstimate.TabIndex = 38;
            this.txt_idEstimate.UseCustomBackColor = true;
            this.txt_idEstimate.UseSelectable = true;
            this.txt_idEstimate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_idEstimate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(6, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Fecha de Emisión :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(6, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "N° Cotización :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Moneda :";
            // 
            // gb_Client
            // 
            this.gb_Client.Controls.Add(this.btn_Search_Client);
            this.gb_Client.Controls.Add(this.txt_Doi);
            this.gb_Client.Controls.Add(this.txt_address);
            this.gb_Client.Controls.Add(this.txt_phone);
            this.gb_Client.Controls.Add(this.label1);
            this.gb_Client.Controls.Add(this.txt_name);
            this.gb_Client.Controls.Add(this.label7);
            this.gb_Client.Controls.Add(this.label9);
            this.gb_Client.Controls.Add(this.label12);
            this.gb_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Client.ForeColor = System.Drawing.Color.Black;
            this.gb_Client.Location = new System.Drawing.Point(9, 7);
            this.gb_Client.Name = "gb_Client";
            this.gb_Client.Size = new System.Drawing.Size(427, 160);
            this.gb_Client.TabIndex = 64;
            this.gb_Client.TabStop = false;
            this.gb_Client.Text = "Datos del Cliente";
            // 
            // btn_Search_Client
            // 
            this.btn_Search_Client.ActiveControl = null;
            this.btn_Search_Client.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Search_Client.Location = new System.Drawing.Point(377, 22);
            this.btn_Search_Client.Name = "btn_Search_Client";
            this.btn_Search_Client.Size = new System.Drawing.Size(41, 29);
            this.btn_Search_Client.TabIndex = 43;
            this.btn_Search_Client.TileImage = global::WindowsFormsApp1.Properties.Resources.Search_16;
            this.btn_Search_Client.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Search_Client.UseCustomBackColor = true;
            this.btn_Search_Client.UseCustomForeColor = true;
            this.btn_Search_Client.UseSelectable = true;
            this.btn_Search_Client.UseStyleColors = true;
            this.btn_Search_Client.UseTileImage = true;
            this.btn_Search_Client.Click += new System.EventHandler(this.btn_Search_Client_Click);
            // 
            // txt_Doi
            // 
            // 
            // 
            // 
            this.txt_Doi.CustomButton.Image = null;
            this.txt_Doi.CustomButton.Location = new System.Drawing.Point(228, 2);
            this.txt_Doi.CustomButton.Name = "";
            this.txt_Doi.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_Doi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Doi.CustomButton.TabIndex = 1;
            this.txt_Doi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Doi.CustomButton.UseSelectable = true;
            this.txt_Doi.CustomButton.Visible = false;
            this.txt_Doi.Lines = new string[0];
            this.txt_Doi.Location = new System.Drawing.Point(113, 60);
            this.txt_Doi.MaxLength = 32767;
            this.txt_Doi.Name = "txt_Doi";
            this.txt_Doi.PasswordChar = '\0';
            this.txt_Doi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Doi.SelectedText = "";
            this.txt_Doi.SelectionLength = 0;
            this.txt_Doi.SelectionStart = 0;
            this.txt_Doi.ShortcutsEnabled = true;
            this.txt_Doi.Size = new System.Drawing.Size(250, 24);
            this.txt_Doi.TabIndex = 42;
            this.txt_Doi.UseSelectable = true;
            this.txt_Doi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Doi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Doi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Doi_KeyDown);
            this.txt_Doi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Doi_KeyPress);
            // 
            // txt_address
            // 
            // 
            // 
            // 
            this.txt_address.CustomButton.Image = null;
            this.txt_address.CustomButton.Location = new System.Drawing.Point(228, 2);
            this.txt_address.CustomButton.Name = "";
            this.txt_address.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_address.CustomButton.TabIndex = 1;
            this.txt_address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_address.CustomButton.UseSelectable = true;
            this.txt_address.CustomButton.Visible = false;
            this.txt_address.Lines = new string[0];
            this.txt_address.Location = new System.Drawing.Point(113, 92);
            this.txt_address.MaxLength = 32767;
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_address.SelectedText = "";
            this.txt_address.SelectionLength = 0;
            this.txt_address.SelectionStart = 0;
            this.txt_address.ShortcutsEnabled = true;
            this.txt_address.Size = new System.Drawing.Size(250, 24);
            this.txt_address.TabIndex = 41;
            this.txt_address.UseSelectable = true;
            this.txt_address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_address_KeyDown);
            // 
            // txt_phone
            // 
            // 
            // 
            // 
            this.txt_phone.CustomButton.Image = null;
            this.txt_phone.CustomButton.Location = new System.Drawing.Point(228, 2);
            this.txt_phone.CustomButton.Name = "";
            this.txt_phone.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_phone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_phone.CustomButton.TabIndex = 1;
            this.txt_phone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_phone.CustomButton.UseSelectable = true;
            this.txt_phone.CustomButton.Visible = false;
            this.txt_phone.Lines = new string[0];
            this.txt_phone.Location = new System.Drawing.Point(113, 125);
            this.txt_phone.MaxLength = 32767;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.PasswordChar = '\0';
            this.txt_phone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_phone.SelectedText = "";
            this.txt_phone.SelectionLength = 0;
            this.txt_phone.SelectionStart = 0;
            this.txt_phone.ShortcutsEnabled = true;
            this.txt_phone.Size = new System.Drawing.Size(250, 24);
            this.txt_phone.TabIndex = 40;
            this.txt_phone.UseSelectable = true;
            this.txt_phone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_phone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_phone.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_ValidatingPhone);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(6, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Teléfono :";
            // 
            // txt_name
            // 
            // 
            // 
            // 
            this.txt_name.CustomButton.Image = null;
            this.txt_name.CustomButton.Location = new System.Drawing.Point(228, 2);
            this.txt_name.CustomButton.Name = "";
            this.txt_name.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_name.CustomButton.TabIndex = 1;
            this.txt_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_name.CustomButton.UseSelectable = true;
            this.txt_name.CustomButton.Visible = false;
            this.txt_name.Lines = new string[0];
            this.txt_name.Location = new System.Drawing.Point(113, 27);
            this.txt_name.MaxLength = 32767;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(250, 24);
            this.txt_name.TabIndex = 38;
            this.txt_name.UseSelectable = true;
            this.txt_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_name_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(6, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "N° Documento :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(6, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Nombres :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkCyan;
            this.label12.Location = new System.Drawing.Point(6, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Dirección :";
            // 
            // txt_Status
            // 
            this.txt_Status.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_Status.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Status.CustomButton.Image = null;
            this.txt_Status.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txt_Status.CustomButton.Name = "";
            this.txt_Status.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_Status.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Status.CustomButton.TabIndex = 1;
            this.txt_Status.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Status.CustomButton.UseSelectable = true;
            this.txt_Status.CustomButton.UseVisualStyleBackColor = false;
            this.txt_Status.CustomButton.Visible = false;
            this.txt_Status.Enabled = false;
            this.txt_Status.Lines = new string[0];
            this.txt_Status.Location = new System.Drawing.Point(108, 479);
            this.txt_Status.MaxLength = 32767;
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.PasswordChar = '\0';
            this.txt_Status.ReadOnly = true;
            this.txt_Status.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Status.SelectedText = "";
            this.txt_Status.SelectionLength = 0;
            this.txt_Status.SelectionStart = 0;
            this.txt_Status.ShortcutsEnabled = true;
            this.txt_Status.Size = new System.Drawing.Size(145, 29);
            this.txt_Status.TabIndex = 63;
            this.txt_Status.UseCustomBackColor = true;
            this.txt_Status.UseSelectable = true;
            this.txt_Status.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Status.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_observation
            // 
            // 
            // 
            // 
            this.txt_observation.CustomButton.Image = null;
            this.txt_observation.CustomButton.Location = new System.Drawing.Point(329, 2);
            this.txt_observation.CustomButton.Name = "";
            this.txt_observation.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.txt_observation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_observation.CustomButton.TabIndex = 1;
            this.txt_observation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_observation.CustomButton.UseSelectable = true;
            this.txt_observation.CustomButton.Visible = false;
            this.txt_observation.Lines = new string[0];
            this.txt_observation.Location = new System.Drawing.Point(108, 408);
            this.txt_observation.MaxLength = 32767;
            this.txt_observation.Multiline = true;
            this.txt_observation.Name = "txt_observation";
            this.txt_observation.PasswordChar = '\0';
            this.txt_observation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_observation.SelectedText = "";
            this.txt_observation.SelectionLength = 0;
            this.txt_observation.SelectionStart = 0;
            this.txt_observation.ShortcutsEnabled = true;
            this.txt_observation.Size = new System.Drawing.Size(387, 60);
            this.txt_observation.TabIndex = 62;
            this.txt_observation.UseSelectable = true;
            this.txt_observation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_observation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_observation.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_ValidatingObs);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(15, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Estado :";
            // 
            // txt_amount
            // 
            this.txt_amount.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_amount.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_amount.CustomButton.Image = null;
            this.txt_amount.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txt_amount.CustomButton.Name = "";
            this.txt_amount.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_amount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_amount.CustomButton.TabIndex = 1;
            this.txt_amount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_amount.CustomButton.UseSelectable = true;
            this.txt_amount.CustomButton.UseVisualStyleBackColor = false;
            this.txt_amount.CustomButton.Visible = false;
            this.txt_amount.Enabled = false;
            this.txt_amount.Lines = new string[0];
            this.txt_amount.Location = new System.Drawing.Point(668, 408);
            this.txt_amount.MaxLength = 32767;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.PasswordChar = '\0';
            this.txt_amount.ReadOnly = true;
            this.txt_amount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_amount.SelectedText = "";
            this.txt_amount.SelectionLength = 0;
            this.txt_amount.SelectionStart = 0;
            this.txt_amount.ShortcutsEnabled = true;
            this.txt_amount.Size = new System.Drawing.Size(145, 29);
            this.txt_amount.TabIndex = 60;
            this.txt_amount.UseCustomBackColor = true;
            this.txt_amount.UseSelectable = true;
            this.txt_amount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_amount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_Clean
            // 
            this.btn_Clean.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clean.ForeColor = System.Drawing.Color.White;
            this.btn_Clean.Location = new System.Drawing.Point(294, 525);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(82, 29);
            this.btn_Clean.TabIndex = 59;
            this.btn_Clean.Text = "Limpiar";
            this.btn_Clean.UseVisualStyleBackColor = false;
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(532, 525);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(82, 29);
            this.btn_Cancel.TabIndex = 57;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(413, 525);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(82, 29);
            this.btn_Save.TabIndex = 56;
            this.btn_Save.Text = "Guardar";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(15, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Observación :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(611, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Total :";
            // 
            // gb_EstimateLine
            // 
            this.gb_EstimateLine.BackColor = System.Drawing.Color.White;
            this.gb_EstimateLine.Controls.Add(this.btn_New);
            this.gb_EstimateLine.Controls.Add(this.panel2);
            this.gb_EstimateLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_EstimateLine.ForeColor = System.Drawing.Color.Black;
            this.gb_EstimateLine.Location = new System.Drawing.Point(9, 173);
            this.gb_EstimateLine.Name = "gb_EstimateLine";
            this.gb_EstimateLine.Size = new System.Drawing.Size(815, 229);
            this.gb_EstimateLine.TabIndex = 45;
            this.gb_EstimateLine.TabStop = false;
            this.gb_EstimateLine.Text = "Detalle de la Cotización";
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.ForeColor = System.Drawing.Color.White;
            this.btn_New.Location = new System.Drawing.Point(721, 11);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(82, 25);
            this.btn_New.TabIndex = 47;
            this.btn_New.Text = "Nueva";
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grid_estimate_lines);
            this.panel2.Location = new System.Drawing.Point(9, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 168);
            this.panel2.TabIndex = 0;
            // 
            // grid_estimate_lines
            // 
            this.grid_estimate_lines.AllowUserToAddRows = false;
            this.grid_estimate_lines.AllowUserToResizeRows = false;
            this.grid_estimate_lines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_estimate_lines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_estimate_lines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.grid_estimate_lines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_estimate_lines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_estimate_lines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_estimate_lines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estimate_id2,
            this.Id,
            this.Type_id,
            this.Product_id,
            this.state,
            this.unitId,
            this.delivery_quantity,
            this.prod_warehouse_id,
            this.product,
            this.unit,
            this.warehouse,
            this.quantity,
            this.unit_Price,
            this.amount});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_estimate_lines.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid_estimate_lines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_estimate_lines.EnableHeadersVisualStyles = false;
            this.grid_estimate_lines.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_estimate_lines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_estimate_lines.Location = new System.Drawing.Point(0, 0);
            this.grid_estimate_lines.Name = "grid_estimate_lines";
            this.grid_estimate_lines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_estimate_lines.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_estimate_lines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid_estimate_lines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_estimate_lines.Size = new System.Drawing.Size(794, 168);
            this.grid_estimate_lines.TabIndex = 52;
            this.grid_estimate_lines.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_estimate_lines_CellValueChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Estimate_id2
            // 
            this.Estimate_id2.DataPropertyName = "estimate_id";
            this.Estimate_id2.HeaderText = "Estimate_id";
            this.Estimate_id2.Name = "Estimate_id2";
            this.Estimate_id2.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Type_id
            // 
            this.Type_id.DataPropertyName = "order_id";
            this.Type_id.HeaderText = "Order_id";
            this.Type_id.Name = "Type_id";
            this.Type_id.Visible = false;
            // 
            // Product_id
            // 
            this.Product_id.DataPropertyName = "product_id";
            this.Product_id.HeaderText = "Product_id";
            this.Product_id.Name = "Product_id";
            this.Product_id.Visible = false;
            // 
            // state
            // 
            this.state.DataPropertyName = "status";
            this.state.HeaderText = "state";
            this.state.Name = "state";
            this.state.Visible = false;
            // 
            // unitId
            // 
            this.unitId.DataPropertyName = "unit_measure_id";
            this.unitId.HeaderText = "unitId";
            this.unitId.Name = "unitId";
            this.unitId.Visible = false;
            // 
            // delivery_quantity
            // 
            this.delivery_quantity.DataPropertyName = "delivery_quantity";
            this.delivery_quantity.HeaderText = "delivery_quantity";
            this.delivery_quantity.Name = "delivery_quantity";
            this.delivery_quantity.Visible = false;
            // 
            // prod_warehouse_id
            // 
            this.prod_warehouse_id.DataPropertyName = "prod_warehouse_id";
            this.prod_warehouse_id.HeaderText = "prod_warehouse_id";
            this.prod_warehouse_id.Name = "prod_warehouse_id";
            this.prod_warehouse_id.Visible = false;
            // 
            // product
            // 
            this.product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.product.DataPropertyName = "product_name";
            this.product.FillWeight = 150F;
            this.product.HeaderText = "Producto";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            this.product.Width = 77;
            // 
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.unit.DataPropertyName = "unit_measure_name";
            this.unit.HeaderText = "Unidad de Medida";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Width = 115;
            // 
            // warehouse
            // 
            this.warehouse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.warehouse.DataPropertyName = "prod_warehouse_name";
            this.warehouse.HeaderText = "Almacen";
            this.warehouse.Name = "warehouse";
            this.warehouse.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Cantidad";
            this.quantity.Name = "quantity";
            this.quantity.Width = 77;
            // 
            // unit_Price
            // 
            this.unit_Price.DataPropertyName = "unit_price";
            this.unit_Price.HeaderText = "Precio Unitario";
            this.unit_Price.Name = "unit_Price";
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "SubTotal";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // UC_SalesEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "UC_SalesEstimate";
            this.Size = new System.Drawing.Size(875, 615);
            this.panel1.ResumeLayout(false);
            this.tab_Estimate.ResumeLayout(false);
            this.order.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gb_Estimates.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_estimates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesEstimateBindingSource)).EndInit();
            this.gb_Filter.ResumeLayout(false);
            this.gb_Filter.PerformLayout();
            this.newOrder.ResumeLayout(false);
            this.newOrder.PerformLayout();
            this.gb_Estimate.ResumeLayout(false);
            this.gb_Estimate.PerformLayout();
            this.gb_Client.ResumeLayout(false);
            this.gb_Client.PerformLayout();
            this.gb_EstimateLine.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_estimate_lines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl tab_Estimate;
        private System.Windows.Forms.TabPage order;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.GroupBox gb_Estimates;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroGrid grid_estimates;
        private System.Windows.Forms.GroupBox gb_Filter;
        private System.Windows.Forms.Button btn_Search_Estimates;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroTile btn_SearchClient;
        private MetroFramework.Controls.MetroTextBox ctxt_estimate_id;
        private System.Windows.Forms.Label label10;
        private MetroFramework.Controls.MetroTextBox ctxt_customer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage newOrder;
        private System.Windows.Forms.GroupBox gb_Estimate;
        private MetroFramework.Controls.MetroDateTime dt_IssueHour;
        private MetroFramework.Controls.MetroComboBox cbo_Currency;
        private MetroFramework.Controls.MetroDateTime dt_IssueDate;
        private MetroFramework.Controls.MetroTextBox txt_idEstimate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_Client;
        private MetroFramework.Controls.MetroTile btn_Search_Client;
        private MetroFramework.Controls.MetroTextBox txt_Doi;
        private MetroFramework.Controls.MetroTextBox txt_address;
        private MetroFramework.Controls.MetroTextBox txt_phone;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txt_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private MetroFramework.Controls.MetroTextBox txt_Status;
        private MetroFramework.Controls.MetroTextBox txt_observation;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txt_amount;
        private System.Windows.Forms.Button btn_Clean;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_EstimateLine;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroGrid grid_estimate_lines;
        private System.Windows.Forms.BindingSource salesEstimateBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencysymbolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerdoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeraddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimate_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount2;
        private System.Windows.Forms.DataGridViewTextBoxColumn observation;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estimate_id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn delivery_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_warehouse_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
    }
}
