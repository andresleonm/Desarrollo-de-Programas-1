namespace WindowsFormsApp1.Views.Sales_Module
{
    partial class UC_SalesRefund
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
            this.tab_Refund = new MetroFramework.Controls.MetroTabControl();
            this.refund = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Detail = new System.Windows.Forms.Button();
            this.gb_Refunds = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grid_Refunds = new MetroFramework.Controls.MetroGrid();
            this.currencyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencysymbolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerdoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refund_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issue_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesRefundBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gb_Filter = new System.Windows.Forms.GroupBox();
            this.btn_Search_Refunds = new System.Windows.Forms.Button();
            this.dt_iniDate = new MetroFramework.Controls.MetroDateTime();
            this.dt_endDate = new MetroFramework.Controls.MetroDateTime();
            this.btn_Search_Client = new MetroFramework.Controls.MetroTile();
            this.ctxt_refund_id = new MetroFramework.Controls.MetroTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ctxt_customer = new MetroFramework.Controls.MetroTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.newRefund = new System.Windows.Forms.TabPage();
            this.txt_total = new MetroFramework.Controls.MetroTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_igv = new MetroFramework.Controls.MetroTextBox();
            this.label = new System.Windows.Forms.Label();
            this.gb_Client = new System.Windows.Forms.GroupBox();
            this.txt_Doi = new MetroFramework.Controls.MetroTextBox();
            this.txt_address = new MetroFramework.Controls.MetroTextBox();
            this.txt_phone = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gb_Refund = new System.Windows.Forms.GroupBox();
            this.dt_IssueHour = new MetroFramework.Controls.MetroDateTime();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Currency = new MetroFramework.Controls.MetroTextBox();
            this.dt_IssueDate = new MetroFramework.Controls.MetroDateTime();
            this.txt_Refund_id = new MetroFramework.Controls.MetroTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Document_id = new MetroFramework.Controls.MetroTextBox();
            this.btn_Search_Document = new MetroFramework.Controls.MetroTile();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_Status = new MetroFramework.Controls.MetroTextBox();
            this.txt_observation = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_amount = new MetroFramework.Controls.MetroTextBox();
            this.btn_Clean = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_RefundLine = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grid_Refund_Lines = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refund_id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documenti_d_line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitmeasureidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodwarehouseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_measure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodwarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refund_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesRefundLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.tab_Refund.SuspendLayout();
            this.refund.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gb_Refunds.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Refunds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRefundBindingSource)).BeginInit();
            this.gb_Filter.SuspendLayout();
            this.newRefund.SuspendLayout();
            this.gb_Client.SuspendLayout();
            this.gb_Refund.SuspendLayout();
            this.gb_RefundLine.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Refund_Lines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRefundLineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tab_Refund);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 622);
            this.panel1.TabIndex = 0;
            // 
            // tab_Refund
            // 
            this.tab_Refund.CausesValidation = false;
            this.tab_Refund.Controls.Add(this.refund);
            this.tab_Refund.Controls.Add(this.newRefund);
            this.tab_Refund.Location = new System.Drawing.Point(10, 5);
            this.tab_Refund.Name = "tab_Refund";
            this.tab_Refund.SelectedIndex = 1;
            this.tab_Refund.Size = new System.Drawing.Size(1042, 605);
            this.tab_Refund.Style = MetroFramework.MetroColorStyle.Teal;
            this.tab_Refund.TabIndex = 44;
            this.tab_Refund.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tab_Refund.UseCustomForeColor = true;
            this.tab_Refund.UseSelectable = true;
            this.tab_Refund.UseStyleColors = true;
            // 
            // refund
            // 
            this.refund.BackColor = System.Drawing.Color.White;
            this.refund.Controls.Add(this.panel3);
            this.refund.Location = new System.Drawing.Point(4, 38);
            this.refund.Name = "refund";
            this.refund.Size = new System.Drawing.Size(1034, 563);
            this.refund.TabIndex = 1;
            this.refund.Text = "Consulta";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Detail);
            this.panel3.Controls.Add(this.gb_Refunds);
            this.panel3.Controls.Add(this.gb_Filter);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1028, 557);
            this.panel3.TabIndex = 1;
            // 
            // btn_Detail
            // 
            this.btn_Detail.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Detail.ForeColor = System.Drawing.Color.White;
            this.btn_Detail.Location = new System.Drawing.Point(462, 493);
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.Size = new System.Drawing.Size(99, 29);
            this.btn_Detail.TabIndex = 48;
            this.btn_Detail.Text = "Detalle";
            this.btn_Detail.UseVisualStyleBackColor = false;
            // 
            // gb_Refunds
            // 
            this.gb_Refunds.BackColor = System.Drawing.Color.White;
            this.gb_Refunds.Controls.Add(this.panel4);
            this.gb_Refunds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Refunds.ForeColor = System.Drawing.Color.Black;
            this.gb_Refunds.Location = new System.Drawing.Point(14, 184);
            this.gb_Refunds.Name = "gb_Refunds";
            this.gb_Refunds.Size = new System.Drawing.Size(1000, 289);
            this.gb_Refunds.TabIndex = 46;
            this.gb_Refunds.TabStop = false;
            this.gb_Refunds.Text = "Devoluciones";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grid_Refunds);
            this.panel4.Location = new System.Drawing.Point(13, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(975, 255);
            this.panel4.TabIndex = 0;
            // 
            // grid_Refunds
            // 
            this.grid_Refunds.AllowUserToAddRows = false;
            this.grid_Refunds.AllowUserToDeleteRows = false;
            this.grid_Refunds.AllowUserToResizeRows = false;
            this.grid_Refunds.AutoGenerateColumns = false;
            this.grid_Refunds.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_Refunds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_Refunds.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_Refunds.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Refunds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Refunds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Refunds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currencyidDataGridViewTextBoxColumn,
            this.customeraddressDataGridViewTextBoxColumn,
            this.currencysymbolDataGridViewTextBoxColumn,
            this.customeridDataGridViewTextBoxColumn,
            this.customerphoneDataGridViewTextBoxColumn,
            this.customerdoiDataGridViewTextBoxColumn,
            this.documentidDataGridViewTextBoxColumn,
            this.refund_id,
            this.customer_name,
            this.issue_date,
            this.currency_name,
            this.amount2,
            this.observation,
            this.status});
            this.grid_Refunds.DataSource = this.salesRefundBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Refunds.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Refunds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Refunds.EnableHeadersVisualStyles = false;
            this.grid_Refunds.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_Refunds.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_Refunds.Location = new System.Drawing.Point(0, 0);
            this.grid_Refunds.Name = "grid_Refunds";
            this.grid_Refunds.ReadOnly = true;
            this.grid_Refunds.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Refunds.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_Refunds.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid_Refunds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Refunds.Size = new System.Drawing.Size(975, 255);
            this.grid_Refunds.TabIndex = 52;
            // 
            // currencyidDataGridViewTextBoxColumn
            // 
            this.currencyidDataGridViewTextBoxColumn.DataPropertyName = "Currency_id";
            this.currencyidDataGridViewTextBoxColumn.HeaderText = "Currency_id";
            this.currencyidDataGridViewTextBoxColumn.Name = "currencyidDataGridViewTextBoxColumn";
            this.currencyidDataGridViewTextBoxColumn.ReadOnly = true;
            this.currencyidDataGridViewTextBoxColumn.Visible = false;
            // 
            // customeraddressDataGridViewTextBoxColumn
            // 
            this.customeraddressDataGridViewTextBoxColumn.DataPropertyName = "Customer_address";
            this.customeraddressDataGridViewTextBoxColumn.HeaderText = "Customer_address";
            this.customeraddressDataGridViewTextBoxColumn.Name = "customeraddressDataGridViewTextBoxColumn";
            this.customeraddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.customeraddressDataGridViewTextBoxColumn.Visible = false;
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
            // customerphoneDataGridViewTextBoxColumn
            // 
            this.customerphoneDataGridViewTextBoxColumn.DataPropertyName = "Customer_phone";
            this.customerphoneDataGridViewTextBoxColumn.HeaderText = "Customer_phone";
            this.customerphoneDataGridViewTextBoxColumn.Name = "customerphoneDataGridViewTextBoxColumn";
            this.customerphoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerphoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // customerdoiDataGridViewTextBoxColumn
            // 
            this.customerdoiDataGridViewTextBoxColumn.DataPropertyName = "Customer_doi";
            this.customerdoiDataGridViewTextBoxColumn.HeaderText = "Customer_doi";
            this.customerdoiDataGridViewTextBoxColumn.Name = "customerdoiDataGridViewTextBoxColumn";
            this.customerdoiDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerdoiDataGridViewTextBoxColumn.Visible = false;
            // 
            // documentidDataGridViewTextBoxColumn
            // 
            this.documentidDataGridViewTextBoxColumn.DataPropertyName = "Document_id";
            this.documentidDataGridViewTextBoxColumn.HeaderText = "Document_id";
            this.documentidDataGridViewTextBoxColumn.Name = "documentidDataGridViewTextBoxColumn";
            this.documentidDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentidDataGridViewTextBoxColumn.Visible = false;
            // 
            // refund_id
            // 
            this.refund_id.DataPropertyName = "Id";
            this.refund_id.HeaderText = "N° Devolución";
            this.refund_id.Name = "refund_id";
            this.refund_id.ReadOnly = true;
            // 
            // customer_name
            // 
            this.customer_name.DataPropertyName = "Customer_name";
            this.customer_name.HeaderText = "Cliente";
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            this.customer_name.Width = 200;
            // 
            // issue_date
            // 
            this.issue_date.DataPropertyName = "Issue_date";
            this.issue_date.HeaderText = "Fecha de emisión";
            this.issue_date.Name = "issue_date";
            this.issue_date.ReadOnly = true;
            // 
            // currency_name
            // 
            this.currency_name.DataPropertyName = "Currency_name";
            this.currency_name.HeaderText = "Moneda";
            this.currency_name.Name = "currency_name";
            this.currency_name.ReadOnly = true;
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
            this.observation.HeaderText = "Observacion";
            this.observation.Name = "observation";
            this.observation.ReadOnly = true;
            this.observation.Width = 200;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "Estado";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // salesRefundBindingSource
            // 
            this.salesRefundBindingSource.DataSource = typeof(WindowsFormsApp1.Models.SalesRefund);
            // 
            // gb_Filter
            // 
            this.gb_Filter.Controls.Add(this.btn_Search_Refunds);
            this.gb_Filter.Controls.Add(this.dt_iniDate);
            this.gb_Filter.Controls.Add(this.dt_endDate);
            this.gb_Filter.Controls.Add(this.btn_Search_Client);
            this.gb_Filter.Controls.Add(this.ctxt_refund_id);
            this.gb_Filter.Controls.Add(this.label10);
            this.gb_Filter.Controls.Add(this.ctxt_customer);
            this.gb_Filter.Controls.Add(this.label13);
            this.gb_Filter.Controls.Add(this.label14);
            this.gb_Filter.Controls.Add(this.label15);
            this.gb_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Filter.ForeColor = System.Drawing.Color.Black;
            this.gb_Filter.Location = new System.Drawing.Point(14, 3);
            this.gb_Filter.Name = "gb_Filter";
            this.gb_Filter.Size = new System.Drawing.Size(1000, 161);
            this.gb_Filter.TabIndex = 40;
            this.gb_Filter.TabStop = false;
            this.gb_Filter.Text = "Filtros";
            // 
            // btn_Search_Refunds
            // 
            this.btn_Search_Refunds.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Search_Refunds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Refunds.ForeColor = System.Drawing.Color.White;
            this.btn_Search_Refunds.Location = new System.Drawing.Point(448, 117);
            this.btn_Search_Refunds.Name = "btn_Search_Refunds";
            this.btn_Search_Refunds.Size = new System.Drawing.Size(99, 29);
            this.btn_Search_Refunds.TabIndex = 60;
            this.btn_Search_Refunds.Text = "Buscar";
            this.btn_Search_Refunds.UseVisualStyleBackColor = false;
            this.btn_Search_Refunds.Click += new System.EventHandler(this.btn_Search_Refunds_Click);
            // 
            // dt_iniDate
            // 
            this.dt_iniDate.Location = new System.Drawing.Point(664, 22);
            this.dt_iniDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_iniDate.Name = "dt_iniDate";
            this.dt_iniDate.Size = new System.Drawing.Size(222, 29);
            this.dt_iniDate.TabIndex = 59;
            // 
            // dt_endDate
            // 
            this.dt_endDate.Location = new System.Drawing.Point(664, 74);
            this.dt_endDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_endDate.Name = "dt_endDate";
            this.dt_endDate.Size = new System.Drawing.Size(222, 29);
            this.dt_endDate.TabIndex = 58;
            // 
            // btn_Search_Client
            // 
            this.btn_Search_Client.ActiveControl = null;
            this.btn_Search_Client.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Search_Client.Location = new System.Drawing.Point(368, 74);
            this.btn_Search_Client.Name = "btn_Search_Client";
            this.btn_Search_Client.Size = new System.Drawing.Size(41, 29);
            this.btn_Search_Client.TabIndex = 57;
            this.btn_Search_Client.TileImage = global::WindowsFormsApp1.Properties.Resources.Search_16;
            this.btn_Search_Client.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Search_Client.UseCustomBackColor = true;
            this.btn_Search_Client.UseCustomForeColor = true;
            this.btn_Search_Client.UseSelectable = true;
            this.btn_Search_Client.UseStyleColors = true;
            this.btn_Search_Client.UseTileImage = true;
            // 
            // ctxt_refund_id
            // 
            // 
            // 
            // 
            this.ctxt_refund_id.CustomButton.Image = null;
            this.ctxt_refund_id.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.ctxt_refund_id.CustomButton.Name = "";
            this.ctxt_refund_id.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ctxt_refund_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ctxt_refund_id.CustomButton.TabIndex = 1;
            this.ctxt_refund_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ctxt_refund_id.CustomButton.UseSelectable = true;
            this.ctxt_refund_id.CustomButton.Visible = false;
            this.ctxt_refund_id.Lines = new string[0];
            this.ctxt_refund_id.Location = new System.Drawing.Point(127, 22);
            this.ctxt_refund_id.MaxLength = 32767;
            this.ctxt_refund_id.Name = "ctxt_refund_id";
            this.ctxt_refund_id.PasswordChar = '\0';
            this.ctxt_refund_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ctxt_refund_id.SelectedText = "";
            this.ctxt_refund_id.SelectionLength = 0;
            this.ctxt_refund_id.SelectionStart = 0;
            this.ctxt_refund_id.ShortcutsEnabled = true;
            this.ctxt_refund_id.Size = new System.Drawing.Size(216, 29);
            this.ctxt_refund_id.TabIndex = 56;
            this.ctxt_refund_id.UseSelectable = true;
            this.ctxt_refund_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ctxt_refund_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(543, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "A la Fecha :";
            // 
            // ctxt_customer
            // 
            // 
            // 
            // 
            this.ctxt_customer.CustomButton.Image = null;
            this.ctxt_customer.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.ctxt_customer.CustomButton.Name = "";
            this.ctxt_customer.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ctxt_customer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ctxt_customer.CustomButton.TabIndex = 1;
            this.ctxt_customer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ctxt_customer.CustomButton.UseSelectable = true;
            this.ctxt_customer.CustomButton.Visible = false;
            this.ctxt_customer.Lines = new string[0];
            this.ctxt_customer.Location = new System.Drawing.Point(127, 74);
            this.ctxt_customer.MaxLength = 32767;
            this.ctxt_customer.Name = "ctxt_customer";
            this.ctxt_customer.PasswordChar = '\0';
            this.ctxt_customer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ctxt_customer.SelectedText = "";
            this.ctxt_customer.SelectionLength = 0;
            this.ctxt_customer.SelectionStart = 0;
            this.ctxt_customer.ShortcutsEnabled = true;
            this.ctxt_customer.Size = new System.Drawing.Size(216, 29);
            this.ctxt_customer.TabIndex = 54;
            this.ctxt_customer.UseSelectable = true;
            this.ctxt_customer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ctxt_customer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkCyan;
            this.label13.Location = new System.Drawing.Point(14, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "N° Devolución:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkCyan;
            this.label14.Location = new System.Drawing.Point(50, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "Cliente :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkCyan;
            this.label15.Location = new System.Drawing.Point(543, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 51;
            this.label15.Text = "De Fecha :";
            // 
            // newRefund
            // 
            this.newRefund.BackColor = System.Drawing.Color.White;
            this.newRefund.CausesValidation = false;
            this.newRefund.Controls.Add(this.txt_total);
            this.newRefund.Controls.Add(this.label20);
            this.newRefund.Controls.Add(this.txt_igv);
            this.newRefund.Controls.Add(this.label);
            this.newRefund.Controls.Add(this.gb_Client);
            this.newRefund.Controls.Add(this.gb_Refund);
            this.newRefund.Controls.Add(this.txt_Status);
            this.newRefund.Controls.Add(this.txt_observation);
            this.newRefund.Controls.Add(this.label3);
            this.newRefund.Controls.Add(this.txt_amount);
            this.newRefund.Controls.Add(this.btn_Clean);
            this.newRefund.Controls.Add(this.btn_Cancel);
            this.newRefund.Controls.Add(this.btn_Save);
            this.newRefund.Controls.Add(this.label6);
            this.newRefund.Controls.Add(this.label5);
            this.newRefund.Controls.Add(this.gb_RefundLine);
            this.newRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newRefund.Location = new System.Drawing.Point(4, 38);
            this.newRefund.Name = "newRefund";
            this.newRefund.Size = new System.Drawing.Size(1034, 563);
            this.newRefund.TabIndex = 0;
            this.newRefund.Text = "Registro";
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_total.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_total.CustomButton.Image = null;
            this.txt_total.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txt_total.CustomButton.Name = "";
            this.txt_total.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_total.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_total.CustomButton.TabIndex = 1;
            this.txt_total.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_total.CustomButton.UseSelectable = true;
            this.txt_total.CustomButton.UseVisualStyleBackColor = false;
            this.txt_total.CustomButton.Visible = false;
            this.txt_total.Enabled = false;
            this.txt_total.Lines = new string[0];
            this.txt_total.Location = new System.Drawing.Point(863, 450);
            this.txt_total.MaxLength = 32767;
            this.txt_total.Name = "txt_total";
            this.txt_total.PasswordChar = '\0';
            this.txt_total.ReadOnly = true;
            this.txt_total.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_total.SelectedText = "";
            this.txt_total.SelectionLength = 0;
            this.txt_total.SelectionStart = 0;
            this.txt_total.ShortcutsEnabled = true;
            this.txt_total.Size = new System.Drawing.Size(145, 29);
            this.txt_total.TabIndex = 72;
            this.txt_total.UseCustomBackColor = true;
            this.txt_total.UseSelectable = true;
            this.txt_total.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_total.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkCyan;
            this.label20.Location = new System.Drawing.Point(780, 458);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 71;
            this.label20.Text = "Total :";
            // 
            // txt_igv
            // 
            this.txt_igv.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_igv.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_igv.CustomButton.Image = null;
            this.txt_igv.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.txt_igv.CustomButton.Name = "";
            this.txt_igv.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_igv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_igv.CustomButton.TabIndex = 1;
            this.txt_igv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_igv.CustomButton.UseSelectable = true;
            this.txt_igv.CustomButton.UseVisualStyleBackColor = false;
            this.txt_igv.CustomButton.Visible = false;
            this.txt_igv.Enabled = false;
            this.txt_igv.Lines = new string[0];
            this.txt_igv.Location = new System.Drawing.Point(616, 412);
            this.txt_igv.MaxLength = 32767;
            this.txt_igv.Name = "txt_igv";
            this.txt_igv.PasswordChar = '\0';
            this.txt_igv.ReadOnly = true;
            this.txt_igv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_igv.SelectedText = "";
            this.txt_igv.SelectionLength = 0;
            this.txt_igv.SelectionStart = 0;
            this.txt_igv.ShortcutsEnabled = true;
            this.txt_igv.Size = new System.Drawing.Size(116, 29);
            this.txt_igv.TabIndex = 70;
            this.txt_igv.UseCustomBackColor = true;
            this.txt_igv.UseSelectable = true;
            this.txt_igv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_igv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.DarkCyan;
            this.label.Location = new System.Drawing.Point(568, 421);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(36, 13);
            this.label.TabIndex = 69;
            this.label.Text = "IGV :";
            // 
            // gb_Client
            // 
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
            this.gb_Client.Location = new System.Drawing.Point(662, 7);
            this.gb_Client.Name = "gb_Client";
            this.gb_Client.Size = new System.Drawing.Size(357, 160);
            this.gb_Client.TabIndex = 68;
            this.gb_Client.TabStop = false;
            this.gb_Client.Text = "Datos del Cliente";
            // 
            // txt_Doi
            // 
            this.txt_Doi.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_Doi.CustomButton.Image = null;
            this.txt_Doi.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.txt_Doi.CustomButton.Name = "";
            this.txt_Doi.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_Doi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Doi.CustomButton.TabIndex = 1;
            this.txt_Doi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Doi.CustomButton.UseSelectable = true;
            this.txt_Doi.CustomButton.Visible = false;
            this.txt_Doi.Enabled = false;
            this.txt_Doi.Lines = new string[0];
            this.txt_Doi.Location = new System.Drawing.Point(113, 60);
            this.txt_Doi.MaxLength = 32767;
            this.txt_Doi.Name = "txt_Doi";
            this.txt_Doi.PasswordChar = '\0';
            this.txt_Doi.ReadOnly = true;
            this.txt_Doi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Doi.SelectedText = "";
            this.txt_Doi.SelectionLength = 0;
            this.txt_Doi.SelectionStart = 0;
            this.txt_Doi.ShortcutsEnabled = true;
            this.txt_Doi.Size = new System.Drawing.Size(228, 24);
            this.txt_Doi.TabIndex = 42;
            this.txt_Doi.UseCustomBackColor = true;
            this.txt_Doi.UseSelectable = true;
            this.txt_Doi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Doi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_address.CustomButton.Image = null;
            this.txt_address.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.txt_address.CustomButton.Name = "";
            this.txt_address.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_address.CustomButton.TabIndex = 1;
            this.txt_address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_address.CustomButton.UseSelectable = true;
            this.txt_address.CustomButton.Visible = false;
            this.txt_address.Enabled = false;
            this.txt_address.Lines = new string[0];
            this.txt_address.Location = new System.Drawing.Point(113, 92);
            this.txt_address.MaxLength = 32767;
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.ReadOnly = true;
            this.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_address.SelectedText = "";
            this.txt_address.SelectionLength = 0;
            this.txt_address.SelectionStart = 0;
            this.txt_address.ShortcutsEnabled = true;
            this.txt_address.Size = new System.Drawing.Size(228, 24);
            this.txt_address.TabIndex = 41;
            this.txt_address.UseCustomBackColor = true;
            this.txt_address.UseSelectable = true;
            this.txt_address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_phone.CustomButton.Image = null;
            this.txt_phone.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.txt_phone.CustomButton.Name = "";
            this.txt_phone.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_phone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_phone.CustomButton.TabIndex = 1;
            this.txt_phone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_phone.CustomButton.UseSelectable = true;
            this.txt_phone.CustomButton.Visible = false;
            this.txt_phone.Enabled = false;
            this.txt_phone.Lines = new string[0];
            this.txt_phone.Location = new System.Drawing.Point(113, 125);
            this.txt_phone.MaxLength = 32767;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.PasswordChar = '\0';
            this.txt_phone.ReadOnly = true;
            this.txt_phone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_phone.SelectedText = "";
            this.txt_phone.SelectionLength = 0;
            this.txt_phone.SelectionStart = 0;
            this.txt_phone.ShortcutsEnabled = true;
            this.txt_phone.Size = new System.Drawing.Size(228, 24);
            this.txt_phone.TabIndex = 40;
            this.txt_phone.UseCustomBackColor = true;
            this.txt_phone.UseSelectable = true;
            this.txt_phone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_phone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txt_name.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_name.CustomButton.Image = null;
            this.txt_name.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.txt_name.CustomButton.Name = "";
            this.txt_name.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_name.CustomButton.TabIndex = 1;
            this.txt_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_name.CustomButton.UseSelectable = true;
            this.txt_name.CustomButton.Visible = false;
            this.txt_name.Enabled = false;
            this.txt_name.Lines = new string[0];
            this.txt_name.Location = new System.Drawing.Point(113, 27);
            this.txt_name.MaxLength = 32767;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.ReadOnly = true;
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(228, 24);
            this.txt_name.TabIndex = 38;
            this.txt_name.UseCustomBackColor = true;
            this.txt_name.UseSelectable = true;
            this.txt_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // gb_Refund
            // 
            this.gb_Refund.Controls.Add(this.dt_IssueHour);
            this.gb_Refund.Controls.Add(this.label4);
            this.gb_Refund.Controls.Add(this.txt_Currency);
            this.gb_Refund.Controls.Add(this.dt_IssueDate);
            this.gb_Refund.Controls.Add(this.txt_Refund_id);
            this.gb_Refund.Controls.Add(this.label11);
            this.gb_Refund.Controls.Add(this.label8);
            this.gb_Refund.Controls.Add(this.label2);
            this.gb_Refund.Controls.Add(this.txt_Document_id);
            this.gb_Refund.Controls.Add(this.btn_Search_Document);
            this.gb_Refund.Controls.Add(this.label18);
            this.gb_Refund.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Refund.ForeColor = System.Drawing.Color.Black;
            this.gb_Refund.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gb_Refund.Location = new System.Drawing.Point(10, 7);
            this.gb_Refund.Name = "gb_Refund";
            this.gb_Refund.Size = new System.Drawing.Size(636, 160);
            this.gb_Refund.TabIndex = 67;
            this.gb_Refund.TabStop = false;
            this.gb_Refund.Text = "Datos de la Devolución :";
            // 
            // dt_IssueHour
            // 
            this.dt_IssueHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_IssueHour.Location = new System.Drawing.Point(213, 92);
            this.dt_IssueHour.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_IssueHour.Name = "dt_IssueHour";
            this.dt_IssueHour.Size = new System.Drawing.Size(92, 29);
            this.dt_IssueHour.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Emisión :";
            // 
            // txt_Currency
            // 
            this.txt_Currency.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_Currency.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Currency.CustomButton.Image = null;
            this.txt_Currency.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txt_Currency.CustomButton.Name = "";
            this.txt_Currency.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_Currency.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Currency.CustomButton.TabIndex = 1;
            this.txt_Currency.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Currency.CustomButton.UseSelectable = true;
            this.txt_Currency.CustomButton.UseVisualStyleBackColor = false;
            this.txt_Currency.CustomButton.Visible = false;
            this.txt_Currency.Enabled = false;
            this.txt_Currency.Lines = new string[0];
            this.txt_Currency.Location = new System.Drawing.Point(445, 92);
            this.txt_Currency.MaxLength = 32767;
            this.txt_Currency.Name = "txt_Currency";
            this.txt_Currency.PasswordChar = '\0';
            this.txt_Currency.ReadOnly = true;
            this.txt_Currency.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Currency.SelectedText = "";
            this.txt_Currency.SelectionLength = 0;
            this.txt_Currency.SelectionStart = 0;
            this.txt_Currency.ShortcutsEnabled = true;
            this.txt_Currency.Size = new System.Drawing.Size(178, 29);
            this.txt_Currency.TabIndex = 65;
            this.txt_Currency.UseCustomBackColor = true;
            this.txt_Currency.UseSelectable = true;
            this.txt_Currency.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Currency.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dt_IssueDate
            // 
            this.dt_IssueDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.dt_IssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_IssueDate.Location = new System.Drawing.Point(93, 92);
            this.dt_IssueDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_IssueDate.Name = "dt_IssueDate";
            this.dt_IssueDate.Size = new System.Drawing.Size(114, 29);
            this.dt_IssueDate.TabIndex = 64;
            this.dt_IssueDate.UseCustomBackColor = true;
            this.dt_IssueDate.UseCustomForeColor = true;
            // 
            // txt_Refund_id
            // 
            this.txt_Refund_id.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_Refund_id.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Refund_id.CustomButton.Image = null;
            this.txt_Refund_id.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txt_Refund_id.CustomButton.Name = "";
            this.txt_Refund_id.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_Refund_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Refund_id.CustomButton.TabIndex = 1;
            this.txt_Refund_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Refund_id.CustomButton.UseSelectable = true;
            this.txt_Refund_id.CustomButton.UseVisualStyleBackColor = false;
            this.txt_Refund_id.CustomButton.Visible = false;
            this.txt_Refund_id.Enabled = false;
            this.txt_Refund_id.Lines = new string[0];
            this.txt_Refund_id.Location = new System.Drawing.Point(445, 32);
            this.txt_Refund_id.MaxLength = 32767;
            this.txt_Refund_id.Name = "txt_Refund_id";
            this.txt_Refund_id.PasswordChar = '\0';
            this.txt_Refund_id.ReadOnly = true;
            this.txt_Refund_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Refund_id.SelectedText = "";
            this.txt_Refund_id.SelectionLength = 0;
            this.txt_Refund_id.SelectionStart = 0;
            this.txt_Refund_id.ShortcutsEnabled = true;
            this.txt_Refund_id.Size = new System.Drawing.Size(178, 29);
            this.txt_Refund_id.TabIndex = 63;
            this.txt_Refund_id.UseCustomBackColor = true;
            this.txt_Refund_id.UseSelectable = true;
            this.txt_Refund_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Refund_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(6, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "Fecha de";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(338, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "N° Devolución :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(338, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Moneda :";
            // 
            // txt_Document_id
            // 
            this.txt_Document_id.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_Document_id.CustomButton.Image = null;
            this.txt_Document_id.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.txt_Document_id.CustomButton.Name = "";
            this.txt_Document_id.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_Document_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Document_id.CustomButton.TabIndex = 1;
            this.txt_Document_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Document_id.CustomButton.UseSelectable = true;
            this.txt_Document_id.CustomButton.Visible = false;
            this.txt_Document_id.Enabled = false;
            this.txt_Document_id.Lines = new string[0];
            this.txt_Document_id.Location = new System.Drawing.Point(93, 32);
            this.txt_Document_id.MaxLength = 32767;
            this.txt_Document_id.Name = "txt_Document_id";
            this.txt_Document_id.PasswordChar = '\0';
            this.txt_Document_id.ReadOnly = true;
            this.txt_Document_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Document_id.SelectedText = "";
            this.txt_Document_id.SelectionLength = 0;
            this.txt_Document_id.SelectionStart = 0;
            this.txt_Document_id.ShortcutsEnabled = true;
            this.txt_Document_id.Size = new System.Drawing.Size(165, 29);
            this.txt_Document_id.TabIndex = 58;
            this.txt_Document_id.UseCustomBackColor = true;
            this.txt_Document_id.UseSelectable = true;
            this.txt_Document_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Document_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_Search_Document
            // 
            this.btn_Search_Document.ActiveControl = null;
            this.btn_Search_Document.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Search_Document.Location = new System.Drawing.Point(264, 33);
            this.btn_Search_Document.Name = "btn_Search_Document";
            this.btn_Search_Document.Size = new System.Drawing.Size(41, 29);
            this.btn_Search_Document.TabIndex = 43;
            this.btn_Search_Document.TileImage = global::WindowsFormsApp1.Properties.Resources.Search_16;
            this.btn_Search_Document.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Search_Document.UseCustomBackColor = true;
            this.btn_Search_Document.UseCustomForeColor = true;
            this.btn_Search_Document.UseSelectable = true;
            this.btn_Search_Document.UseStyleColors = true;
            this.btn_Search_Document.UseTileImage = true;
            this.btn_Search_Document.Click += new System.EventHandler(this.btn_Search_Document_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkCyan;
            this.label18.Location = new System.Drawing.Point(5, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "Documento :";
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
            this.txt_observation.BackColor = System.Drawing.Color.White;
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
            this.txt_observation.UseCustomBackColor = true;
            this.txt_observation.UseSelectable = true;
            this.txt_observation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_observation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txt_amount.Location = new System.Drawing.Point(863, 408);
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
            this.btn_Clean.Location = new System.Drawing.Point(376, 525);
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
            this.btn_Cancel.Location = new System.Drawing.Point(614, 525);
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
            this.btn_Save.Location = new System.Drawing.Point(495, 525);
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
            this.label5.Location = new System.Drawing.Point(780, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Sub Total :";
            // 
            // gb_RefundLine
            // 
            this.gb_RefundLine.BackColor = System.Drawing.Color.White;
            this.gb_RefundLine.Controls.Add(this.panel2);
            this.gb_RefundLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_RefundLine.ForeColor = System.Drawing.Color.Black;
            this.gb_RefundLine.Location = new System.Drawing.Point(9, 173);
            this.gb_RefundLine.Name = "gb_RefundLine";
            this.gb_RefundLine.Size = new System.Drawing.Size(1011, 229);
            this.gb_RefundLine.TabIndex = 45;
            this.gb_RefundLine.TabStop = false;
            this.gb_RefundLine.Text = "Detalle de la Devolución";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grid_Refund_Lines);
            this.panel2.Location = new System.Drawing.Point(14, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 191);
            this.panel2.TabIndex = 0;
            // 
            // grid_Refund_Lines
            // 
            this.grid_Refund_Lines.AllowUserToAddRows = false;
            this.grid_Refund_Lines.AllowUserToResizeRows = false;
            this.grid_Refund_Lines.AutoGenerateColumns = false;
            this.grid_Refund_Lines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_Refund_Lines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_Refund_Lines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.grid_Refund_Lines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Refund_Lines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_Refund_Lines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Refund_Lines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.refund_id2,
            this.documenti_d_line,
            this.product_id,
            this.unitmeasureidDataGridViewTextBoxColumn,
            this.prodwarehouseidDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.product,
            this.unit_measure,
            this.prodwarehouse,
            this.quantity_available,
            this.refund_quantity,
            this.quantity,
            this.unit_price,
            this.amount});
            this.grid_Refund_Lines.DataSource = this.salesRefundLineBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Refund_Lines.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid_Refund_Lines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Refund_Lines.EnableHeadersVisualStyles = false;
            this.grid_Refund_Lines.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_Refund_Lines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_Refund_Lines.Location = new System.Drawing.Point(0, 0);
            this.grid_Refund_Lines.Name = "grid_Refund_Lines";
            this.grid_Refund_Lines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Refund_Lines.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_Refund_Lines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid_Refund_Lines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Refund_Lines.Size = new System.Drawing.Size(984, 191);
            this.grid_Refund_Lines.TabIndex = 52;
            this.grid_Refund_Lines.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Refund_Lines_CellValueChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // refund_id2
            // 
            this.refund_id2.DataPropertyName = "Refund_id";
            this.refund_id2.HeaderText = "Refund_id";
            this.refund_id2.Name = "refund_id2";
            this.refund_id2.Visible = false;
            // 
            // documenti_d_line
            // 
            this.documenti_d_line.DataPropertyName = "Document_id_line";
            this.documenti_d_line.HeaderText = "Document_id_line";
            this.documenti_d_line.Name = "documenti_d_line";
            this.documenti_d_line.Visible = false;
            // 
            // product_id
            // 
            this.product_id.DataPropertyName = "Product_id";
            this.product_id.HeaderText = "Product_id";
            this.product_id.Name = "product_id";
            this.product_id.Visible = false;
            // 
            // unitmeasureidDataGridViewTextBoxColumn
            // 
            this.unitmeasureidDataGridViewTextBoxColumn.DataPropertyName = "Unit_measure_id";
            this.unitmeasureidDataGridViewTextBoxColumn.HeaderText = "Unit_measure_id";
            this.unitmeasureidDataGridViewTextBoxColumn.Name = "unitmeasureidDataGridViewTextBoxColumn";
            this.unitmeasureidDataGridViewTextBoxColumn.Visible = false;
            // 
            // prodwarehouseidDataGridViewTextBoxColumn
            // 
            this.prodwarehouseidDataGridViewTextBoxColumn.DataPropertyName = "Prod_warehouse_id";
            this.prodwarehouseidDataGridViewTextBoxColumn.HeaderText = "Prod_warehouse_id";
            this.prodwarehouseidDataGridViewTextBoxColumn.Name = "prodwarehouseidDataGridViewTextBoxColumn";
            this.prodwarehouseidDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // product
            // 
            this.product.DataPropertyName = "Product_name";
            this.product.HeaderText = "Producto";
            this.product.Name = "product";
            this.product.Width = 150;
            // 
            // unit_measure
            // 
            this.unit_measure.DataPropertyName = "Unit_measure_name";
            this.unit_measure.HeaderText = "Unidad de Medida";
            this.unit_measure.Name = "unit_measure";
            // 
            // prodwarehouse
            // 
            this.prodwarehouse.DataPropertyName = "Prod_warehouse_name";
            this.prodwarehouse.HeaderText = "Almacén";
            this.prodwarehouse.Name = "prodwarehouse";
            this.prodwarehouse.Width = 200;
            // 
            // quantity_available
            // 
            this.quantity_available.DataPropertyName = "Quantity_available";
            this.quantity_available.HeaderText = "Cantidad Disponible";
            this.quantity_available.Name = "quantity_available";
            // 
            // refund_quantity
            // 
            this.refund_quantity.DataPropertyName = "Refund_quantity";
            this.refund_quantity.HeaderText = "Cantidad Devuelta Física";
            this.refund_quantity.Name = "refund_quantity";
            this.refund_quantity.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "Quantity";
            this.quantity.HeaderText = "Cantidad a Devolver";
            this.quantity.Name = "quantity";
            // 
            // unit_price
            // 
            this.unit_price.DataPropertyName = "Unit_price";
            this.unit_price.HeaderText = "Precio Unitario";
            this.unit_price.Name = "unit_price";
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amount.DataPropertyName = "Amount";
            this.amount.HeaderText = "SubTotal";
            this.amount.Name = "amount";
            // 
            // salesRefundLineBindingSource
            // 
            this.salesRefundLineBindingSource.DataSource = typeof(WindowsFormsApp1.Models.SalesRefundLine);
            // 
            // UC_SalesRefund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "UC_SalesRefund";
            this.Size = new System.Drawing.Size(1065, 625);
            this.panel1.ResumeLayout(false);
            this.tab_Refund.ResumeLayout(false);
            this.refund.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gb_Refunds.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Refunds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRefundBindingSource)).EndInit();
            this.gb_Filter.ResumeLayout(false);
            this.gb_Filter.PerformLayout();
            this.newRefund.ResumeLayout(false);
            this.newRefund.PerformLayout();
            this.gb_Client.ResumeLayout(false);
            this.gb_Client.PerformLayout();
            this.gb_Refund.ResumeLayout(false);
            this.gb_Refund.PerformLayout();
            this.gb_RefundLine.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Refund_Lines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRefundLineBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl tab_Refund;
        private System.Windows.Forms.TabPage refund;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Detail;
        private System.Windows.Forms.GroupBox gb_Refunds;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroGrid grid_Refunds;
        private System.Windows.Forms.GroupBox gb_Filter;
        private System.Windows.Forms.Button btn_Search_Refunds;
        private MetroFramework.Controls.MetroDateTime dt_iniDate;
        private MetroFramework.Controls.MetroDateTime dt_endDate;
        private MetroFramework.Controls.MetroTile btn_Search_Client;
        private MetroFramework.Controls.MetroTextBox ctxt_refund_id;
        private System.Windows.Forms.Label label10;
        private MetroFramework.Controls.MetroTextBox ctxt_customer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage newRefund;
        private MetroFramework.Controls.MetroTextBox txt_total;
        private System.Windows.Forms.Label label20;
        private MetroFramework.Controls.MetroTextBox txt_igv;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox gb_Client;
        private MetroFramework.Controls.MetroTextBox txt_Doi;
        private MetroFramework.Controls.MetroTextBox txt_address;
        private MetroFramework.Controls.MetroTextBox txt_phone;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txt_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gb_Refund;
        private MetroFramework.Controls.MetroTextBox txt_Currency;
        private MetroFramework.Controls.MetroDateTime dt_IssueDate;
        private MetroFramework.Controls.MetroTextBox txt_Refund_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txt_Document_id;
        private MetroFramework.Controls.MetroTile btn_Search_Document;
        private System.Windows.Forms.Label label18;
        private MetroFramework.Controls.MetroTextBox txt_Status;
        private MetroFramework.Controls.MetroTextBox txt_observation;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txt_amount;
        private System.Windows.Forms.Button btn_Clean;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_RefundLine;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroGrid grid_Refund_Lines;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource salesRefundLineBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn refund_id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn documenti_d_line;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitmeasureidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodwarehouseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_measure;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodwarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_available;
        private System.Windows.Forms.DataGridViewTextBoxColumn refund_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.BindingSource salesRefundBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeraddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencysymbolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerdoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refund_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount2;
        private System.Windows.Forms.DataGridViewTextBoxColumn observation;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private MetroFramework.Controls.MetroDateTime dt_IssueHour;
    }
}
