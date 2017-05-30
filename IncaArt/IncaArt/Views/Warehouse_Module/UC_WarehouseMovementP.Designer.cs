namespace WindowsFormsApp1.Views.Warehouse_Module
{
    partial class UC_WarehouseMovementP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.consulta = new MetroFramework.Controls.MetroTabPage();
            this.btn_delete = new MetroFramework.Controls.MetroButton();
            this.btn_clean_s = new MetroFramework.Controls.MetroButton();
            this.btn_search = new MetroFramework.Controls.MetroButton();
            this.combobox_unit_s = new MetroFramework.Controls.MetroComboBox();
            this.textbox_name_s = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.movement_grid = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_maximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro = new MetroFramework.Controls.MetroTabPage();
            this.gb_OrderLine = new System.Windows.Forms.GroupBox();
            this.grid_movement_lines = new MetroFramework.Controls.MetroGrid();
            this.date = new MetroFramework.Controls.MetroDateTime();
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
            this.movement_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionbutton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocumentLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movement_grid)).BeginInit();
            this.registro.SuspendLayout();
            this.gb_OrderLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_movement_lines)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.consulta);
            this.metroTabControl1.Controls.Add(this.registro);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 3);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(865, 450);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // consulta
            // 
            this.consulta.Controls.Add(this.btn_delete);
            this.consulta.Controls.Add(this.btn_clean_s);
            this.consulta.Controls.Add(this.btn_search);
            this.consulta.Controls.Add(this.combobox_unit_s);
            this.consulta.Controls.Add(this.textbox_name_s);
            this.consulta.Controls.Add(this.metroLabel2);
            this.consulta.Controls.Add(this.metroLabel1);
            this.consulta.Controls.Add(this.movement_grid);
            this.consulta.HorizontalScrollbarBarColor = true;
            this.consulta.HorizontalScrollbarHighlightOnWheel = false;
            this.consulta.HorizontalScrollbarSize = 10;
            this.consulta.Location = new System.Drawing.Point(4, 38);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(857, 408);
            this.consulta.TabIndex = 0;
            this.consulta.Text = "Consulta";
            this.consulta.VerticalScrollbarBarColor = true;
            this.consulta.VerticalScrollbarHighlightOnWheel = false;
            this.consulta.VerticalScrollbarSize = 10;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(439, 343);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Ver";
            this.btn_delete.UseSelectable = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clean_s
            // 
            this.btn_clean_s.Location = new System.Drawing.Point(432, 109);
            this.btn_clean_s.Name = "btn_clean_s";
            this.btn_clean_s.Size = new System.Drawing.Size(75, 23);
            this.btn_clean_s.TabIndex = 12;
            this.btn_clean_s.Text = "Limpiar";
            this.btn_clean_s.UseSelectable = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(351, 109);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseSelectable = true;
            // 
            // combobox_unit_s
            // 
            this.combobox_unit_s.FormattingEnabled = true;
            this.combobox_unit_s.ItemHeight = 23;
            this.combobox_unit_s.Location = new System.Drawing.Point(386, 23);
            this.combobox_unit_s.Name = "combobox_unit_s";
            this.combobox_unit_s.Size = new System.Drawing.Size(121, 29);
            this.combobox_unit_s.TabIndex = 10;
            this.combobox_unit_s.UseSelectable = true;
            // 
            // textbox_name_s
            // 
            // 
            // 
            // 
            this.textbox_name_s.CustomButton.Image = null;
            this.textbox_name_s.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.textbox_name_s.CustomButton.Name = "";
            this.textbox_name_s.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_name_s.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_name_s.CustomButton.TabIndex = 1;
            this.textbox_name_s.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_name_s.CustomButton.UseSelectable = true;
            this.textbox_name_s.CustomButton.Visible = false;
            this.textbox_name_s.Lines = new string[0];
            this.textbox_name_s.Location = new System.Drawing.Point(103, 23);
            this.textbox_name_s.MaxLength = 32767;
            this.textbox_name_s.Name = "textbox_name_s";
            this.textbox_name_s.PasswordChar = '\0';
            this.textbox_name_s.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_name_s.SelectedText = "";
            this.textbox_name_s.SelectionLength = 0;
            this.textbox_name_s.SelectionStart = 0;
            this.textbox_name_s.ShortcutsEnabled = true;
            this.textbox_name_s.Size = new System.Drawing.Size(120, 23);
            this.textbox_name_s.TabIndex = 7;
            this.textbox_name_s.UseSelectable = true;
            this.textbox_name_s.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_name_s.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(326, 28);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Unidad:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Nombre:";
            // 
            // movement_grid
            // 
            this.movement_grid.AllowUserToResizeRows = false;
            this.movement_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.movement_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movement_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.movement_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.movement_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.movement_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movement_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.index,
            this.nombre,
            this.unidad,
            this.stock_minimo,
            this.stock_maximo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.movement_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.movement_grid.EnableHeadersVisualStyles = false;
            this.movement_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.movement_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.movement_grid.Location = new System.Drawing.Point(35, 147);
            this.movement_grid.Name = "movement_grid";
            this.movement_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.movement_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.movement_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.movement_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.movement_grid.Size = new System.Drawing.Size(777, 178);
            this.movement_grid.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // index
            // 
            this.index.HeaderText = "Index";
            this.index.Name = "index";
            this.index.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad";
            this.unidad.Name = "unidad";
            // 
            // stock_minimo
            // 
            this.stock_minimo.HeaderText = "Stock Mínimo";
            this.stock_minimo.Name = "stock_minimo";
            this.stock_minimo.Width = 110;
            // 
            // stock_maximo
            // 
            this.stock_maximo.HeaderText = "Stock Máximo";
            this.stock_maximo.Name = "stock_maximo";
            this.stock_maximo.Width = 110;
            // 
            // registro
            // 
            this.registro.Controls.Add(this.gb_OrderLine);
            this.registro.Controls.Add(this.date);
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
            this.registro.Size = new System.Drawing.Size(857, 408);
            this.registro.TabIndex = 1;
            this.registro.Text = "Registro";
            this.registro.VerticalScrollbarBarColor = true;
            this.registro.VerticalScrollbarHighlightOnWheel = false;
            this.registro.VerticalScrollbarSize = 10;
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
            this.grid_movement_lines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
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
            this.line_id,
            this.product,
            this.unit,
            this.warehouse,
            this.stock,
            this.documentQuantity,
            this.quantity,
            this.actionbutton,
            this.state,
            this.idDocumentLine});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_movement_lines.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_movement_lines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_movement_lines.EnableHeadersVisualStyles = false;
            this.grid_movement_lines.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_movement_lines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_movement_lines.Location = new System.Drawing.Point(3, 16);
            this.grid_movement_lines.Name = "grid_movement_lines";
            this.grid_movement_lines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_movement_lines.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_movement_lines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid_movement_lines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_movement_lines.Size = new System.Drawing.Size(785, 170);
            this.grid_movement_lines.TabIndex = 50;
            this.grid_movement_lines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_order_lines_CellContentClick);
            // 
            // date
            // 
            this.date.CustomFormat = "DD/MM/YYYY";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(598, 64);
            this.date.MinimumSize = new System.Drawing.Size(0, 29);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(208, 29);
            this.date.TabIndex = 63;
            this.date.Value = new System.DateTime(2017, 5, 29, 6, 10, 20, 0);
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
            // movement_id
            // 
            this.movement_id.DataPropertyName = "movementId";
            this.movement_id.HeaderText = "movement_id";
            this.movement_id.Name = "movement_id";
            this.movement_id.Visible = false;
            // 
            // line_id
            // 
            this.line_id.DataPropertyName = "id";
            this.line_id.HeaderText = "line_id";
            this.line_id.Name = "line_id";
            this.line_id.Visible = false;
            // 
            // product
            // 
            this.product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product.DataPropertyName = "product";
            this.product.HeaderText = "Producto";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.HeaderText = "Unidad de Medida";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // warehouse
            // 
            this.warehouse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.warehouse.DataPropertyName = "warehouse";
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
            // actionbutton
            // 
            this.actionbutton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.actionbutton.DefaultCellStyle = dataGridViewCellStyle5;
            this.actionbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionbutton.HeaderText = "Accion";
            this.actionbutton.Name = "actionbutton";
            this.actionbutton.Text = "X";
            this.actionbutton.Width = 40;
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
            // UC_WarehouseMovementP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.DoubleBuffered = true;
            this.Name = "UC_WarehouseMovementP";
            this.Size = new System.Drawing.Size(1126, 521);
            this.metroTabControl1.ResumeLayout(false);
            this.consulta.ResumeLayout(false);
            this.consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movement_grid)).EndInit();
            this.registro.ResumeLayout(false);
            this.registro.PerformLayout();
            this.gb_OrderLine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_movement_lines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage consulta;
        private MetroFramework.Controls.MetroButton btn_delete;
        private MetroFramework.Controls.MetroButton btn_clean_s;
        private MetroFramework.Controls.MetroButton btn_search;
        private MetroFramework.Controls.MetroComboBox combobox_unit_s;
        private MetroFramework.Controls.MetroTextBox textbox_name_s;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid movement_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_maximo;
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
        private MetroFramework.Controls.MetroDateTime date;
        private System.Windows.Forms.GroupBox gb_OrderLine;
        private MetroFramework.Controls.MetroGrid grid_movement_lines;
        private System.Windows.Forms.DataGridViewTextBoxColumn movement_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn line_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewButtonColumn actionbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocumentLine;
    }
}
