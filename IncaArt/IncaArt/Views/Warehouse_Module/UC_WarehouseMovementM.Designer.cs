namespace WindowsFormsApp1.Views.Warehouse_Module
{
    partial class UC_WarehouseMovementM
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab_movement = new MetroFramework.Controls.MetroTabControl();
            this.consulta = new MetroFramework.Controls.MetroTabPage();
            this.btn_Kardex = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.fec_fin = new MetroFramework.Controls.MetroDateTime();
            this.fec_ini = new MetroFramework.Controls.MetroDateTime();
            this.buttonSearchV = new System.Windows.Forms.Button();
            this.buttonCleanV = new System.Windows.Forms.Button();
            this.buttonViewV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.movements_grid = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movementName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumentoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumentoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumentoFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumentoFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro = new MetroFramework.Controls.MetroTabPage();
            this.hour = new MetroFramework.Controls.MetroDateTime();
            this.date = new MetroFramework.Controls.MetroDateTime();
            this.but_delete = new System.Windows.Forms.Button();
            this.gb_OrderLine = new System.Windows.Forms.GroupBox();
            this.grid_movement_lines = new MetroFramework.Controls.MetroGrid();
            this.movement_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocumentLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Clean = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.buttonAddRow = new System.Windows.Forms.Button();
            this.documents_list = new MetroFramework.Controls.MetroComboBox();
            this.document_input = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.types_movements = new MetroFramework.Controls.MetroComboBox();
            this.textbox_observation = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tab_movement.SuspendLayout();
            this.consulta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movements_grid)).BeginInit();
            this.registro.SuspendLayout();
            this.gb_OrderLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_movement_lines)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_movement
            // 
            this.tab_movement.Controls.Add(this.consulta);
            this.tab_movement.Controls.Add(this.registro);
            this.tab_movement.Location = new System.Drawing.Point(10, 14);
            this.tab_movement.Name = "tab_movement";
            this.tab_movement.SelectedIndex = 1;
            this.tab_movement.Size = new System.Drawing.Size(1062, 550);
            this.tab_movement.TabIndex = 0;
            this.tab_movement.UseSelectable = true;
            // 
            // consulta
            // 
            this.consulta.Controls.Add(this.btn_Kardex);
            this.consulta.Controls.Add(this.metroLabel2);
            this.consulta.Controls.Add(this.metroLabel1);
            this.consulta.Controls.Add(this.fec_fin);
            this.consulta.Controls.Add(this.fec_ini);
            this.consulta.Controls.Add(this.buttonSearchV);
            this.consulta.Controls.Add(this.buttonCleanV);
            this.consulta.Controls.Add(this.buttonViewV);
            this.consulta.Controls.Add(this.groupBox1);
            this.consulta.HorizontalScrollbarBarColor = true;
            this.consulta.HorizontalScrollbarHighlightOnWheel = false;
            this.consulta.HorizontalScrollbarSize = 10;
            this.consulta.Location = new System.Drawing.Point(4, 38);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(1054, 508);
            this.consulta.TabIndex = 0;
            this.consulta.Text = "Consulta";
            this.consulta.VerticalScrollbarBarColor = true;
            this.consulta.VerticalScrollbarHighlightOnWheel = false;
            this.consulta.VerticalScrollbarSize = 10;
            this.consulta.Click += new System.EventHandler(this.consulta_Click);
            // 
            // btn_Kardex
            // 
            this.btn_Kardex.ActiveControl = null;
            this.btn_Kardex.BackColor = System.Drawing.Color.Transparent;
            this.btn_Kardex.Location = new System.Drawing.Point(791, 34);
            this.btn_Kardex.Name = "btn_Kardex";
            this.btn_Kardex.Size = new System.Drawing.Size(145, 38);
            this.btn_Kardex.TabIndex = 76;
            this.btn_Kardex.Text = "Generar Kardex";
            this.btn_Kardex.TileImage = global::WindowsFormsApp1.Properties.Resources.Microsoft_Excel_40px;
            this.btn_Kardex.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Kardex.UseCustomBackColor = true;
            this.btn_Kardex.UseCustomForeColor = true;
            this.btn_Kardex.UseSelectable = true;
            this.btn_Kardex.UseStyleColors = true;
            this.btn_Kardex.UseTileImage = true;
            this.btn_Kardex.Click += new System.EventHandler(this.btn_Kardex_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(496, 34);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(21, 19);
            this.metroLabel2.TabIndex = 73;
            this.metroLabel2.Text = "Al";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(315, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 72;
            this.metroLabel1.Text = "Fecha";
            // 
            // fec_fin
            // 
            this.fec_fin.CustomFormat = "DD/MM/YYYY";
            this.fec_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fec_fin.Location = new System.Drawing.Point(523, 30);
            this.fec_fin.MinimumSize = new System.Drawing.Size(0, 29);
            this.fec_fin.Name = "fec_fin";
            this.fec_fin.Size = new System.Drawing.Size(116, 29);
            this.fec_fin.TabIndex = 71;
            this.fec_fin.Value = new System.DateTime(2017, 5, 29, 6, 10, 20, 0);
            // 
            // fec_ini
            // 
            this.fec_ini.CustomFormat = "DD/MM/YYYY";
            this.fec_ini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fec_ini.Location = new System.Drawing.Point(376, 30);
            this.fec_ini.MinimumSize = new System.Drawing.Size(0, 29);
            this.fec_ini.Name = "fec_ini";
            this.fec_ini.Size = new System.Drawing.Size(116, 29);
            this.fec_ini.TabIndex = 70;
            this.fec_ini.Value = new System.DateTime(2017, 5, 29, 6, 10, 20, 0);
            // 
            // buttonSearchV
            // 
            this.buttonSearchV.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonSearchV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchV.ForeColor = System.Drawing.Color.White;
            this.buttonSearchV.Location = new System.Drawing.Point(369, 74);
            this.buttonSearchV.Name = "buttonSearchV";
            this.buttonSearchV.Size = new System.Drawing.Size(85, 29);
            this.buttonSearchV.TabIndex = 69;
            this.buttonSearchV.Text = "Buscar";
            this.buttonSearchV.UseVisualStyleBackColor = false;
            this.buttonSearchV.Click += new System.EventHandler(this.buttonSearchV_Click);
            // 
            // buttonCleanV
            // 
            this.buttonCleanV.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonCleanV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCleanV.ForeColor = System.Drawing.Color.White;
            this.buttonCleanV.Location = new System.Drawing.Point(553, 74);
            this.buttonCleanV.Name = "buttonCleanV";
            this.buttonCleanV.Size = new System.Drawing.Size(85, 29);
            this.buttonCleanV.TabIndex = 68;
            this.buttonCleanV.Text = "Limpiar";
            this.buttonCleanV.UseVisualStyleBackColor = false;
            this.buttonCleanV.Click += new System.EventHandler(this.buttonCleanV_Click);
            // 
            // buttonViewV
            // 
            this.buttonViewV.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonViewV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewV.ForeColor = System.Drawing.Color.White;
            this.buttonViewV.Location = new System.Drawing.Point(478, 383);
            this.buttonViewV.Name = "buttonViewV";
            this.buttonViewV.Size = new System.Drawing.Size(85, 29);
            this.buttonViewV.TabIndex = 67;
            this.buttonViewV.Text = "Ver";
            this.buttonViewV.UseVisualStyleBackColor = false;
            this.buttonViewV.Click += new System.EventHandler(this.buttonViewV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.movements_grid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(18, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1005, 267);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movimientos";
            // 
            // movements_grid
            // 
            this.movements_grid.AllowUserToResizeRows = false;
            this.movements_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.movements_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.movements_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.movements_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.movements_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.movements_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movements_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.movementName,
            this.Tipo,
            this.Observacion,
            this.Fecha,
            this.TipoDocumentoOrigen,
            this.NroDocumentoOrigen,
            this.TipoDocumentoFin,
            this.NroDocumentoFin,
            this.estado,
            this.detail});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.movements_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.movements_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movements_grid.EnableHeadersVisualStyles = false;
            this.movements_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.movements_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.movements_grid.Location = new System.Drawing.Point(3, 16);
            this.movements_grid.Name = "movements_grid";
            this.movements_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.movements_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.movements_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.movements_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.movements_grid.Size = new System.Drawing.Size(999, 248);
            this.movements_grid.TabIndex = 50;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // movementName
            // 
            this.movementName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.movementName.DataPropertyName = "movementName";
            this.movementName.HeaderText = "Movimiento";
            this.movementName.Name = "movementName";
            this.movementName.Width = 91;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 52;
            // 
            // Observacion
            // 
            this.Observacion.DataPropertyName = "Observacion";
            this.Observacion.HeaderText = "Observacion";
            this.Observacion.Name = "Observacion";
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 60;
            // 
            // TipoDocumentoOrigen
            // 
            this.TipoDocumentoOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TipoDocumentoOrigen.DataPropertyName = "TipoDocumentoOrigen";
            this.TipoDocumentoOrigen.HeaderText = "Documento Origen";
            this.TipoDocumentoOrigen.Name = "TipoDocumentoOrigen";
            this.TipoDocumentoOrigen.Width = 118;
            // 
            // NroDocumentoOrigen
            // 
            this.NroDocumentoOrigen.DataPropertyName = "NroDocumentoOrigen";
            this.NroDocumentoOrigen.HeaderText = "Nro";
            this.NroDocumentoOrigen.Name = "NroDocumentoOrigen";
            // 
            // TipoDocumentoFin
            // 
            this.TipoDocumentoFin.DataPropertyName = "TipoDocumentoFin";
            this.TipoDocumentoFin.HeaderText = "Documento  Fin";
            this.TipoDocumentoFin.Name = "TipoDocumentoFin";
            this.TipoDocumentoFin.Visible = false;
            // 
            // NroDocumentoFin
            // 
            this.NroDocumentoFin.DataPropertyName = "NroDocumentoFin";
            this.NroDocumentoFin.HeaderText = "Nro";
            this.NroDocumentoFin.Name = "NroDocumentoFin";
            this.NroDocumentoFin.Visible = false;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "State";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // detail
            // 
            this.detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detail.DataPropertyName = "detail";
            this.detail.HeaderText = "detail";
            this.detail.Name = "detail";
            this.detail.Visible = false;
            // 
            // registro
            // 
            this.registro.Controls.Add(this.hour);
            this.registro.Controls.Add(this.date);
            this.registro.Controls.Add(this.but_delete);
            this.registro.Controls.Add(this.gb_OrderLine);
            this.registro.Controls.Add(this.btn_Clean);
            this.registro.Controls.Add(this.btn_Cancel);
            this.registro.Controls.Add(this.btn_Save);
            this.registro.Controls.Add(this.buttonAddRow);
            this.registro.Controls.Add(this.documents_list);
            this.registro.Controls.Add(this.document_input);
            this.registro.Controls.Add(this.metroLabel3);
            this.registro.Controls.Add(this.types_movements);
            this.registro.Controls.Add(this.textbox_observation);
            this.registro.Controls.Add(this.metroLabel6);
            this.registro.Controls.Add(this.metroLabel5);
            this.registro.HorizontalScrollbarBarColor = true;
            this.registro.HorizontalScrollbarHighlightOnWheel = false;
            this.registro.HorizontalScrollbarSize = 10;
            this.registro.Location = new System.Drawing.Point(4, 38);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(1054, 508);
            this.registro.TabIndex = 1;
            this.registro.Text = "Registro";
            this.registro.VerticalScrollbarBarColor = true;
            this.registro.VerticalScrollbarHighlightOnWheel = false;
            this.registro.VerticalScrollbarSize = 10;
            // 
            // hour
            // 
            this.hour.Location = new System.Drawing.Point(704, 60);
            this.hour.Margin = new System.Windows.Forms.Padding(2);
            this.hour.MinimumSize = new System.Drawing.Size(0, 29);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(107, 29);
            this.hour.TabIndex = 69;
            // 
            // date
            // 
            this.date.CustomFormat = "MM/dd/yyyy";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(594, 60);
            this.date.MinimumSize = new System.Drawing.Size(0, 29);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(107, 29);
            this.date.TabIndex = 68;
            this.date.Value = new System.DateTime(2017, 5, 29, 6, 10, 20, 0);
            // 
            // but_delete
            // 
            this.but_delete.BackColor = System.Drawing.Color.DarkCyan;
            this.but_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_delete.ForeColor = System.Drawing.Color.White;
            this.but_delete.Location = new System.Drawing.Point(615, 129);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(82, 25);
            this.but_delete.TabIndex = 65;
            this.but_delete.Text = "Eliminar";
            this.but_delete.UseVisualStyleBackColor = false;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // gb_OrderLine
            // 
            this.gb_OrderLine.BackColor = System.Drawing.Color.White;
            this.gb_OrderLine.Controls.Add(this.grid_movement_lines);
            this.gb_OrderLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_OrderLine.ForeColor = System.Drawing.Color.Black;
            this.gb_OrderLine.Location = new System.Drawing.Point(19, 160);
            this.gb_OrderLine.Name = "gb_OrderLine";
            this.gb_OrderLine.Size = new System.Drawing.Size(791, 189);
            this.gb_OrderLine.TabIndex = 64;
            this.gb_OrderLine.TabStop = false;
            this.gb_OrderLine.Text = "Detalle del Movimiento";
            this.gb_OrderLine.Enter += new System.EventHandler(this.gb_OrderLine_Enter);
            // 
            // grid_movement_lines
            // 
            this.grid_movement_lines.AllowUserToResizeRows = false;
            this.grid_movement_lines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_movement_lines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_movement_lines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_movement_lines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_movement_lines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_movement_lines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movement_id,
            this.unit_id,
            this.warehouse_id,
            this.material_id,
            this.line_id,
            this.material,
            this.unit,
            this.warehouse,
            this.stock,
            this.documentQuantity,
            this.quantity,
            this.state,
            this.idDocumentLine});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_movement_lines.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid_movement_lines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_movement_lines.EnableHeadersVisualStyles = false;
            this.grid_movement_lines.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_movement_lines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_movement_lines.Location = new System.Drawing.Point(3, 16);
            this.grid_movement_lines.Name = "grid_movement_lines";
            this.grid_movement_lines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_movement_lines.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_movement_lines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid_movement_lines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_movement_lines.Size = new System.Drawing.Size(785, 170);
            this.grid_movement_lines.TabIndex = 50;
            this.grid_movement_lines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_order_lines_CellContentClick);
            // 
            // movement_id
            // 
            this.movement_id.DataPropertyName = "movementId";
            this.movement_id.HeaderText = "movement_id";
            this.movement_id.Name = "movement_id";
            this.movement_id.Visible = false;
            // 
            // unit_id
            // 
            this.unit_id.DataPropertyName = "unit_id";
            this.unit_id.HeaderText = "unit_id";
            this.unit_id.Name = "unit_id";
            this.unit_id.Visible = false;
            // 
            // warehouse_id
            // 
            this.warehouse_id.DataPropertyName = "warehouse_id";
            this.warehouse_id.HeaderText = "warehouse_id";
            this.warehouse_id.Name = "warehouse_id";
            this.warehouse_id.Visible = false;
            // 
            // material_id
            // 
            this.material_id.DataPropertyName = "material_id";
            this.material_id.HeaderText = "material_id";
            this.material_id.Name = "material_id";
            this.material_id.Visible = false;
            // 
            // line_id
            // 
            this.line_id.DataPropertyName = "id";
            this.line_id.HeaderText = "line_id";
            this.line_id.Name = "line_id";
            this.line_id.Visible = false;
            // 
            // material
            // 
            this.material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.material.DataPropertyName = "material_name";
            this.material.HeaderText = "Material";
            this.material.Name = "material";
            this.material.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit_name";
            this.unit.HeaderText = "Unidad de Medida";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // warehouse
            // 
            this.warehouse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.warehouse.DataPropertyName = "warehouse_name";
            this.warehouse.HeaderText = "Almacen";
            this.warehouse.Name = "warehouse";
            this.warehouse.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock.DataPropertyName = "warehouseQuantity";
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // documentQuantity
            // 
            this.documentQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.documentQuantity.DataPropertyName = "documentQuantity";
            this.documentQuantity.HeaderText = "Cantidad Documento";
            this.documentQuantity.Name = "documentQuantity";
            this.documentQuantity.ReadOnly = true;
            this.documentQuantity.Visible = false;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Cantidad";
            this.quantity.Name = "quantity";
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "Estado";
            this.state.Name = "state";
            this.state.Visible = false;
            // 
            // idDocumentLine
            // 
            this.idDocumentLine.DataPropertyName = "idDocumentLine";
            this.idDocumentLine.HeaderText = "document_line";
            this.idDocumentLine.Name = "idDocumentLine";
            this.idDocumentLine.Visible = false;
            // 
            // btn_Clean
            // 
            this.btn_Clean.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clean.ForeColor = System.Drawing.Color.White;
            this.btn_Clean.Location = new System.Drawing.Point(276, 366);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(82, 29);
            this.btn_Clean.TabIndex = 62;
            this.btn_Clean.Text = "Limpiar";
            this.btn_Clean.UseVisualStyleBackColor = false;
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(514, 366);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(82, 29);
            this.btn_Cancel.TabIndex = 61;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(395, 366);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(82, 29);
            this.btn_Save.TabIndex = 60;
            this.btn_Save.Text = "Guardar";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // buttonAddRow
            // 
            this.buttonAddRow.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonAddRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRow.ForeColor = System.Drawing.Color.White;
            this.buttonAddRow.Location = new System.Drawing.Point(724, 129);
            this.buttonAddRow.Name = "buttonAddRow";
            this.buttonAddRow.Size = new System.Drawing.Size(82, 25);
            this.buttonAddRow.TabIndex = 47;
            this.buttonAddRow.Text = "Nueva";
            this.buttonAddRow.UseVisualStyleBackColor = false;
            this.buttonAddRow.Click += new System.EventHandler(this.buttonAddRow_Click);
            // 
            // documents_list
            // 
            this.documents_list.FormattingEnabled = true;
            this.documents_list.ItemHeight = 23;
            this.documents_list.Location = new System.Drawing.Point(598, 24);
            this.documents_list.Name = "documents_list";
            this.documents_list.Size = new System.Drawing.Size(245, 29);
            this.documents_list.TabIndex = 17;
            this.documents_list.UseSelectable = true;
            this.documents_list.Visible = false;
            this.documents_list.SelectedIndexChanged += new System.EventHandler(this.documents_list_SelectedIndexChanged);
            // 
            // document_input
            // 
            this.document_input.AutoSize = true;
            this.document_input.Location = new System.Drawing.Point(495, 25);
            this.document_input.Name = "document_input";
            this.document_input.Size = new System.Drawing.Size(77, 19);
            this.document_input.TabIndex = 15;
            this.document_input.Text = "Documento";
            this.document_input.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(495, 64);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Fecha";
            // 
            // types_movements
            // 
            this.types_movements.FormattingEnabled = true;
            this.types_movements.ItemHeight = 23;
            this.types_movements.Location = new System.Drawing.Point(160, 25);
            this.types_movements.Name = "types_movements";
            this.types_movements.Size = new System.Drawing.Size(230, 29);
            this.types_movements.TabIndex = 9;
            this.types_movements.UseSelectable = true;
            this.types_movements.SelectedIndexChanged += new System.EventHandler(this.combobox_unit_SelectedIndexChanged);
            // 
            // textbox_observation
            // 
            // 
            // 
            // 
            this.textbox_observation.CustomButton.Image = null;
            this.textbox_observation.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.textbox_observation.CustomButton.Name = "";
            this.textbox_observation.CustomButton.Size = new System.Drawing.Size(75, 75);
            this.textbox_observation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_observation.CustomButton.TabIndex = 1;
            this.textbox_observation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_observation.CustomButton.UseSelectable = true;
            this.textbox_observation.CustomButton.Visible = false;
            this.textbox_observation.Lines = new string[0];
            this.textbox_observation.Location = new System.Drawing.Point(160, 60);
            this.textbox_observation.MaxLength = 32767;
            this.textbox_observation.Name = "textbox_observation";
            this.textbox_observation.PasswordChar = '\0';
            this.textbox_observation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_observation.SelectedText = "";
            this.textbox_observation.SelectionLength = 0;
            this.textbox_observation.SelectionStart = 0;
            this.textbox_observation.ShortcutsEnabled = true;
            this.textbox_observation.Size = new System.Drawing.Size(284, 80);
            this.textbox_observation.TabIndex = 8;
            this.textbox_observation.UseSelectable = true;
            this.textbox_observation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_observation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_observation.Click += new System.EventHandler(this.textbox_observation_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(19, 58);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(83, 19);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Observacion";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(19, 25);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(128, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Tipo de Movimiento";
            // 
            // UC_WarehouseMovementM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tab_movement);
            this.DoubleBuffered = true;
            this.Name = "UC_WarehouseMovementM";
            this.Size = new System.Drawing.Size(1075, 567);
            this.tab_movement.ResumeLayout(false);
            this.consulta.ResumeLayout(false);
            this.consulta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movements_grid)).EndInit();
            this.registro.ResumeLayout(false);
            this.registro.PerformLayout();
            this.gb_OrderLine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_movement_lines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tab_movement;
        private MetroFramework.Controls.MetroTabPage consulta;
        private MetroFramework.Controls.MetroTabPage registro;
        private System.Windows.Forms.Button btn_Clean;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button buttonAddRow;
        private MetroFramework.Controls.MetroComboBox documents_list;
        private MetroFramework.Controls.MetroLabel document_input;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox types_movements;
        private MetroFramework.Controls.MetroTextBox textbox_observation;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.GroupBox gb_OrderLine;
        private MetroFramework.Controls.MetroGrid grid_movement_lines;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroGrid movements_grid;
        private System.Windows.Forms.Button buttonSearchV;
        private System.Windows.Forms.Button buttonCleanV;
        private System.Windows.Forms.Button buttonViewV;
        private MetroFramework.Controls.MetroDateTime fec_fin;
        private MetroFramework.Controls.MetroDateTime fec_ini;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn movement_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn line_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocumentLine;
        private MetroFramework.Controls.MetroDateTime date;
        private MetroFramework.Controls.MetroTile btn_Kardex;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn movementName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumentoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumentoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumentoFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumentoFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail;
        private MetroFramework.Controls.MetroDateTime hour;
    }
}
