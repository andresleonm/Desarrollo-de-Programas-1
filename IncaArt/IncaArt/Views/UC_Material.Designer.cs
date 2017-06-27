namespace WindowsFormsApp1.Views
{
    partial class UC_Material
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.consulta = new MetroFramework.Controls.MetroTabPage();
            this.btn_import = new MetroFramework.Controls.MetroTile();
            this.btn_template = new MetroFramework.Controls.MetroTile();
            this.btn_delete = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combobox_unit_s = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textbox_name_s = new MetroFramework.Controls.MetroTextBox();
            this.btn_search = new MetroFramework.Controls.MetroButton();
            this.btn_clean_s = new MetroFramework.Controls.MetroButton();
            this.tabRegister = new MetroFramework.Controls.MetroTabPage();
            this.btn_save = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.combobox_currency = new MetroFramework.Controls.MetroComboBox();
            this.textbox_cost = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.textbox_name = new MetroFramework.Controls.MetroTextBox();
            this.textbox_stock_max = new MetroFramework.Controls.MetroTextBox();
            this.combobox_unit = new MetroFramework.Controls.MetroComboBox();
            this.textbox_stock_min = new MetroFramework.Controls.MetroTextBox();
            this.btn_cancel = new MetroFramework.Controls.MetroButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_maximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.consulta.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.consulta);
            this.metroTabControl1.Controls.Add(this.tabRegister);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(752, 484);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseCustomForeColor = true;
            this.metroTabControl1.UseSelectable = true;
            // 
            // consulta
            // 
            this.consulta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.consulta.Controls.Add(this.btn_import);
            this.consulta.Controls.Add(this.btn_template);
            this.consulta.Controls.Add(this.btn_delete);
            this.consulta.Controls.Add(this.groupBox2);
            this.consulta.Controls.Add(this.groupBox1);
            this.consulta.HorizontalScrollbarBarColor = true;
            this.consulta.HorizontalScrollbarHighlightOnWheel = false;
            this.consulta.HorizontalScrollbarSize = 10;
            this.consulta.Location = new System.Drawing.Point(4, 38);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(744, 442);
            this.consulta.TabIndex = 0;
            this.consulta.Text = "Consulta";
            this.consulta.UseCustomBackColor = true;
            this.consulta.VerticalScrollbarBarColor = true;
            this.consulta.VerticalScrollbarHighlightOnWheel = false;
            this.consulta.VerticalScrollbarSize = 10;
            // 
            // btn_import
            // 
            this.btn_import.ActiveControl = null;
            this.btn_import.BackColor = System.Drawing.Color.Transparent;
            this.btn_import.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_import.Location = new System.Drawing.Point(134, 367);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(106, 38);
            this.btn_import.TabIndex = 82;
            this.btn_import.Text = "Importar";
            this.btn_import.TileImage = global::WindowsFormsApp1.Properties.Resources.Microsoft_Excel_40px;
            this.btn_import.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_import.UseCustomBackColor = true;
            this.btn_import.UseCustomForeColor = true;
            this.btn_import.UseSelectable = true;
            this.btn_import.UseStyleColors = true;
            this.btn_import.UseTileImage = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_template
            // 
            this.btn_template.ActiveControl = null;
            this.btn_template.BackColor = System.Drawing.Color.Transparent;
            this.btn_template.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_template.Location = new System.Drawing.Point(35, 367);
            this.btn_template.Name = "btn_template";
            this.btn_template.Size = new System.Drawing.Size(96, 38);
            this.btn_template.TabIndex = 81;
            this.btn_template.Text = "Plantilla";
            this.btn_template.TileImage = global::WindowsFormsApp1.Properties.Resources.Microsoft_Excel_40px;
            this.btn_template.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_template.UseCustomBackColor = true;
            this.btn_template.UseCustomForeColor = true;
            this.btn_template.UseSelectable = true;
            this.btn_template.UseStyleColors = true;
            this.btn_template.UseTileImage = true;
            this.btn_template.Click += new System.EventHandler(this.btn_template_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            this.btn_delete.Location = new System.Drawing.Point(479, 367);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseCustomBackColor = true;
            this.btn_delete.UseCustomForeColor = true;
            this.btn_delete.UseSelectable = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.metroGrid1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(35, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 214);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeColumns = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(3, 16);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(513, 195);
            this.metroGrid1.TabIndex = 2;
            this.metroGrid1.UseCustomForeColor = true;
            this.metroGrid1.UseStyleColors = true;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.metroGrid1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.combobox_unit_s);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.textbox_name_s);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.btn_clean_s);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(35, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 127);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // combobox_unit_s
            // 
            this.combobox_unit_s.FormattingEnabled = true;
            this.combobox_unit_s.ItemHeight = 23;
            this.combobox_unit_s.Location = new System.Drawing.Point(75, 51);
            this.combobox_unit_s.Name = "combobox_unit_s";
            this.combobox_unit_s.Size = new System.Drawing.Size(121, 29);
            this.combobox_unit_s.TabIndex = 10;
            this.combobox_unit_s.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel1.Location = new System.Drawing.Point(7, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 15);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Nombre:";
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel2.Location = new System.Drawing.Point(7, 57);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 15);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Unidad:";
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
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
            this.textbox_name_s.Location = new System.Drawing.Point(75, 19);
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
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            this.btn_search.Location = new System.Drawing.Point(356, 98);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseCustomBackColor = true;
            this.btn_search.UseCustomForeColor = true;
            this.btn_search.UseSelectable = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_clean_s
            // 
            this.btn_clean_s.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_clean_s.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            this.btn_clean_s.Location = new System.Drawing.Point(437, 98);
            this.btn_clean_s.Name = "btn_clean_s";
            this.btn_clean_s.Size = new System.Drawing.Size(75, 23);
            this.btn_clean_s.TabIndex = 12;
            this.btn_clean_s.Text = "Limpiar";
            this.btn_clean_s.UseCustomBackColor = true;
            this.btn_clean_s.UseCustomForeColor = true;
            this.btn_clean_s.UseSelectable = true;
            this.btn_clean_s.Click += new System.EventHandler(this.btn_clean_s_Click);
            // 
            // tabRegister
            // 
            this.tabRegister.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabRegister.Controls.Add(this.btn_save);
            this.tabRegister.Controls.Add(this.groupBox3);
            this.tabRegister.Controls.Add(this.btn_cancel);
            this.tabRegister.HorizontalScrollbarBarColor = true;
            this.tabRegister.HorizontalScrollbarHighlightOnWheel = false;
            this.tabRegister.HorizontalScrollbarSize = 10;
            this.tabRegister.Location = new System.Drawing.Point(4, 38);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Size = new System.Drawing.Size(744, 442);
            this.tabRegister.TabIndex = 1;
            this.tabRegister.Text = "Registro";
            this.tabRegister.UseCustomBackColor = true;
            this.tabRegister.VerticalScrollbarBarColor = true;
            this.tabRegister.VerticalScrollbarHighlightOnWheel = false;
            this.tabRegister.VerticalScrollbarSize = 10;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            this.btn_save.Location = new System.Drawing.Point(146, 290);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseCustomBackColor = true;
            this.btn_save.UseCustomForeColor = true;
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.metroLabel10);
            this.groupBox3.Controls.Add(this.combobox_currency);
            this.groupBox3.Controls.Add(this.textbox_cost);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.metroLabel9);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Controls.Add(this.metroLabel7);
            this.groupBox3.Controls.Add(this.metroLabel8);
            this.groupBox3.Controls.Add(this.textbox_name);
            this.groupBox3.Controls.Add(this.textbox_stock_max);
            this.groupBox3.Controls.Add(this.combobox_unit);
            this.groupBox3.Controls.Add(this.textbox_stock_min);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(19, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 262);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de Materia Prima";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel10.Location = new System.Drawing.Point(6, 198);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(68, 15);
            this.metroLabel10.TabIndex = 24;
            this.metroLabel10.Text = "Moneda (*)";
            this.metroLabel10.UseCustomForeColor = true;
            this.metroLabel10.UseStyleColors = true;
            // 
            // combobox_currency
            // 
            this.combobox_currency.FormattingEnabled = true;
            this.combobox_currency.ItemHeight = 23;
            this.combobox_currency.Location = new System.Drawing.Point(109, 194);
            this.combobox_currency.Name = "combobox_currency";
            this.combobox_currency.Size = new System.Drawing.Size(121, 29);
            this.combobox_currency.TabIndex = 23;
            this.combobox_currency.UseSelectable = true;
            this.combobox_currency.Validating += new System.ComponentModel.CancelEventHandler(this.combobox_Validating);
            // 
            // textbox_cost
            // 
            // 
            // 
            // 
            this.textbox_cost.CustomButton.Image = null;
            this.textbox_cost.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.textbox_cost.CustomButton.Name = "";
            this.textbox_cost.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_cost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_cost.CustomButton.TabIndex = 1;
            this.textbox_cost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_cost.CustomButton.UseSelectable = true;
            this.textbox_cost.CustomButton.Visible = false;
            this.textbox_cost.Lines = new string[0];
            this.textbox_cost.Location = new System.Drawing.Point(109, 163);
            this.textbox_cost.MaxLength = 32767;
            this.textbox_cost.Name = "textbox_cost";
            this.textbox_cost.PasswordChar = '\0';
            this.textbox_cost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_cost.SelectedText = "";
            this.textbox_cost.SelectionLength = 0;
            this.textbox_cost.SelectionStart = 0;
            this.textbox_cost.ShortcutsEnabled = true;
            this.textbox_cost.Size = new System.Drawing.Size(121, 23);
            this.textbox_cost.TabIndex = 22;
            this.textbox_cost.UseSelectable = true;
            this.textbox_cost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_cost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_number_KeyPress);
            this.textbox_cost.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validating);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel4.Location = new System.Drawing.Point(6, 168);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 15);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "Costo(*)";
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel9.Location = new System.Drawing.Point(6, 239);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(134, 15);
            this.metroLabel9.TabIndex = 20;
            this.metroLabel9.Text = "(*) Campos obligatorios";
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel5.Location = new System.Drawing.Point(6, 29);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(69, 15);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Nombre (*)";
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel6.Location = new System.Drawing.Point(6, 62);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 15);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Unidad (*)";
            this.metroLabel6.UseCustomForeColor = true;
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel7.Location = new System.Drawing.Point(6, 98);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(100, 15);
            this.metroLabel7.TabIndex = 4;
            this.metroLabel7.Text = "Stock Mínimo (*)";
            this.metroLabel7.UseCustomForeColor = true;
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel8.Location = new System.Drawing.Point(6, 134);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(103, 15);
            this.metroLabel8.TabIndex = 5;
            this.metroLabel8.Text = "Stock Máximo (*)";
            this.metroLabel8.UseCustomForeColor = true;
            this.metroLabel8.UseStyleColors = true;
            // 
            // textbox_name
            // 
            // 
            // 
            // 
            this.textbox_name.CustomButton.Image = null;
            this.textbox_name.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.textbox_name.CustomButton.Name = "";
            this.textbox_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_name.CustomButton.TabIndex = 1;
            this.textbox_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_name.CustomButton.UseSelectable = true;
            this.textbox_name.CustomButton.Visible = false;
            this.textbox_name.Lines = new string[0];
            this.textbox_name.Location = new System.Drawing.Point(109, 24);
            this.textbox_name.MaxLength = 32767;
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.PasswordChar = '\0';
            this.textbox_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_name.SelectedText = "";
            this.textbox_name.SelectionLength = 0;
            this.textbox_name.SelectionStart = 0;
            this.textbox_name.ShortcutsEnabled = true;
            this.textbox_name.Size = new System.Drawing.Size(121, 23);
            this.textbox_name.TabIndex = 6;
            this.textbox_name.UseSelectable = true;
            this.textbox_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_name.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validating);
            // 
            // textbox_stock_max
            // 
            // 
            // 
            // 
            this.textbox_stock_max.CustomButton.Image = null;
            this.textbox_stock_max.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.textbox_stock_max.CustomButton.Name = "";
            this.textbox_stock_max.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_stock_max.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_stock_max.CustomButton.TabIndex = 1;
            this.textbox_stock_max.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_stock_max.CustomButton.UseSelectable = true;
            this.textbox_stock_max.CustomButton.Visible = false;
            this.textbox_stock_max.Lines = new string[0];
            this.textbox_stock_max.Location = new System.Drawing.Point(109, 130);
            this.textbox_stock_max.MaxLength = 32767;
            this.textbox_stock_max.Name = "textbox_stock_max";
            this.textbox_stock_max.PasswordChar = '\0';
            this.textbox_stock_max.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_stock_max.SelectedText = "";
            this.textbox_stock_max.SelectionLength = 0;
            this.textbox_stock_max.SelectionStart = 0;
            this.textbox_stock_max.ShortcutsEnabled = true;
            this.textbox_stock_max.Size = new System.Drawing.Size(121, 23);
            this.textbox_stock_max.TabIndex = 7;
            this.textbox_stock_max.UseSelectable = true;
            this.textbox_stock_max.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_stock_max.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_stock_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_number_KeyPress);
            this.textbox_stock_max.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_number_Validating);
            // 
            // combobox_unit
            // 
            this.combobox_unit.FormattingEnabled = true;
            this.combobox_unit.ItemHeight = 23;
            this.combobox_unit.Location = new System.Drawing.Point(109, 58);
            this.combobox_unit.Name = "combobox_unit";
            this.combobox_unit.Size = new System.Drawing.Size(121, 29);
            this.combobox_unit.TabIndex = 9;
            this.combobox_unit.UseSelectable = true;
            this.combobox_unit.Validating += new System.ComponentModel.CancelEventHandler(this.combobox_Validating);
            // 
            // textbox_stock_min
            // 
            // 
            // 
            // 
            this.textbox_stock_min.CustomButton.Image = null;
            this.textbox_stock_min.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.textbox_stock_min.CustomButton.Name = "";
            this.textbox_stock_min.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_stock_min.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_stock_min.CustomButton.TabIndex = 1;
            this.textbox_stock_min.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_stock_min.CustomButton.UseSelectable = true;
            this.textbox_stock_min.CustomButton.Visible = false;
            this.textbox_stock_min.Lines = new string[0];
            this.textbox_stock_min.Location = new System.Drawing.Point(109, 98);
            this.textbox_stock_min.MaxLength = 32767;
            this.textbox_stock_min.Name = "textbox_stock_min";
            this.textbox_stock_min.PasswordChar = '\0';
            this.textbox_stock_min.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_stock_min.SelectedText = "";
            this.textbox_stock_min.SelectionLength = 0;
            this.textbox_stock_min.SelectionStart = 0;
            this.textbox_stock_min.ShortcutsEnabled = true;
            this.textbox_stock_min.Size = new System.Drawing.Size(121, 23);
            this.textbox_stock_min.TabIndex = 8;
            this.textbox_stock_min.UseSelectable = true;
            this.textbox_stock_min.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_stock_min.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_stock_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_number_KeyPress);
            this.textbox_stock_min.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_number_Validating);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            this.btn_cancel.Location = new System.Drawing.Point(227, 290);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseCustomBackColor = true;
            this.btn_cancel.UseCustomForeColor = true;
            this.btn_cancel.UseSelectable = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(0, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(101, 25);
            this.metroLabel3.TabIndex = 27;
            this.metroLabel3.Text = "Materiales";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 28);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.metroTabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 484);
            this.panel2.TabIndex = 29;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // index
            // 
            this.index.HeaderText = "Index";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Visible = false;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // unidad
            // 
            this.unidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unidad.HeaderText = "Unidad";
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            // 
            // stock_minimo
            // 
            this.stock_minimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock_minimo.HeaderText = "Stock Mínimo";
            this.stock_minimo.Name = "stock_minimo";
            this.stock_minimo.ReadOnly = true;
            // 
            // stock_maximo
            // 
            this.stock_maximo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock_maximo.HeaderText = "Stock Máximo";
            this.stock_maximo.Name = "stock_maximo";
            this.stock_maximo.ReadOnly = true;
            // 
            // UC_Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Material";
            this.Size = new System.Drawing.Size(752, 512);
            this.UseCustomBackColor = true;
            this.Load += new System.EventHandler(this.UC_Material_Load);
            this.VisibleChanged += new System.EventHandler(this.UC_Material_VisibleChanged);
            this.metroTabControl1.ResumeLayout(false);
            this.consulta.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabRegister.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage consulta;
        private MetroFramework.Controls.MetroTabPage tabRegister;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox combobox_unit_s;
        private MetroFramework.Controls.MetroTextBox textbox_name_s;
        private MetroFramework.Controls.MetroButton btn_clean_s;
        private MetroFramework.Controls.MetroButton btn_search;
        private MetroFramework.Controls.MetroButton btn_delete;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox combobox_unit;
        private MetroFramework.Controls.MetroTextBox textbox_stock_min;
        private MetroFramework.Controls.MetroTextBox textbox_stock_max;
        private MetroFramework.Controls.MetroTextBox textbox_name;
        private MetroFramework.Controls.MetroButton btn_cancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton btn_save;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox textbox_cost;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroComboBox combobox_currency;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile btn_import;
        private MetroFramework.Controls.MetroTile btn_template;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_maximo;
    }
}
