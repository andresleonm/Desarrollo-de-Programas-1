namespace WindowsFormsApp1.Views
{
    partial class Supplier
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
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btn_import = new MetroFramework.Controls.MetroTile();
            this.btn_template = new MetroFramework.Controls.MetroTile();
            this.delete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_name_s = new MetroFramework.Controls.MetroTextBox();
            this.btn_clean = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textbox_doi_s = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Almacén = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textbox_email = new MetroFramework.Controls.MetroTextBox();
            this.textbox_phone = new MetroFramework.Controls.MetroTextBox();
            this.Cancel = new MetroFramework.Controls.MetroButton();
            this.register = new MetroFramework.Controls.MetroButton();
            this.textbox_name = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textbox_doi = new MetroFramework.Controls.MetroTextBox();
            this.textbox_address = new MetroFramework.Controls.MetroTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(915, 713);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTabControl1.TabIndex = 22;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.Enter += new System.EventHandler(this.tabIndex_Enter);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btn_import);
            this.metroTabPage2.Controls.Add(this.btn_template);
            this.metroTabPage2.Controls.Add(this.delete);
            this.metroTabPage2.Controls.Add(this.groupBox2);
            this.metroTabPage2.Controls.Add(this.groupBox1);
            this.metroTabPage2.ForeColor = System.Drawing.Color.White;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(907, 671);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "  Consultar  ";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            this.metroTabPage2.Enter += new System.EventHandler(this.tabIndex_Enter);
            // 
            // btn_import
            // 
            this.btn_import.ActiveControl = null;
            this.btn_import.BackColor = System.Drawing.Color.Transparent;
            this.btn_import.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_import.Location = new System.Drawing.Point(99, 513);
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
            this.btn_template.Location = new System.Drawing.Point(0, 513);
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
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DarkCyan;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(816, 513);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(85, 29);
            this.delete.TabIndex = 51;
            this.delete.Text = "Eliminar ";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textbox_name_s);
            this.groupBox2.Controls.Add(this.btn_clean);
            this.groupBox2.Controls.Add(this.search);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textbox_doi_s);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(0, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(904, 172);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(23, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Nombre :";
            // 
            // textbox_name_s
            // 
            // 
            // 
            // 
            this.textbox_name_s.CustomButton.Image = null;
            this.textbox_name_s.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.textbox_name_s.CustomButton.Name = "";
            this.textbox_name_s.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.textbox_name_s.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_name_s.CustomButton.TabIndex = 1;
            this.textbox_name_s.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_name_s.CustomButton.UseSelectable = true;
            this.textbox_name_s.CustomButton.Visible = false;
            this.textbox_name_s.Lines = new string[0];
            this.textbox_name_s.Location = new System.Drawing.Point(93, 45);
            this.textbox_name_s.MaxLength = 100;
            this.textbox_name_s.Name = "textbox_name_s";
            this.textbox_name_s.PasswordChar = '\0';
            this.textbox_name_s.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_name_s.SelectedText = "";
            this.textbox_name_s.SelectionLength = 0;
            this.textbox_name_s.SelectionStart = 0;
            this.textbox_name_s.ShortcutsEnabled = true;
            this.textbox_name_s.Size = new System.Drawing.Size(176, 27);
            this.textbox_name_s.TabIndex = 54;
            this.textbox_name_s.UseSelectable = true;
            this.textbox_name_s.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_name_s.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_clean
            // 
            this.btn_clean.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clean.ForeColor = System.Drawing.Color.White;
            this.btn_clean.Location = new System.Drawing.Point(398, 127);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(85, 29);
            this.btn_clean.TabIndex = 53;
            this.btn_clean.Text = "Limpiar";
            this.btn_clean.UseVisualStyleBackColor = false;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.DarkCyan;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(280, 127);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(85, 29);
            this.search.TabIndex = 50;
            this.search.Text = "Buscar";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkCyan;
            this.label14.Location = new System.Drawing.Point(432, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "DOI :";
            // 
            // textbox_doi_s
            // 
            // 
            // 
            // 
            this.textbox_doi_s.CustomButton.Image = null;
            this.textbox_doi_s.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.textbox_doi_s.CustomButton.Name = "";
            this.textbox_doi_s.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.textbox_doi_s.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_doi_s.CustomButton.TabIndex = 1;
            this.textbox_doi_s.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_doi_s.CustomButton.UseSelectable = true;
            this.textbox_doi_s.CustomButton.Visible = false;
            this.textbox_doi_s.Lines = new string[0];
            this.textbox_doi_s.Location = new System.Drawing.Point(514, 45);
            this.textbox_doi_s.MaxLength = 11;
            this.textbox_doi_s.Name = "textbox_doi_s";
            this.textbox_doi_s.PasswordChar = '\0';
            this.textbox_doi_s.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_doi_s.SelectedText = "";
            this.textbox_doi_s.SelectionLength = 0;
            this.textbox_doi_s.SelectionStart = 0;
            this.textbox_doi_s.ShortcutsEnabled = true;
            this.textbox_doi_s.Size = new System.Drawing.Size(176, 27);
            this.textbox_doi_s.TabIndex = 26;
            this.textbox_doi_s.UseSelectable = true;
            this.textbox_doi_s.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_doi_s.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 315);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedores";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.metroGrid1);
            this.panel4.Location = new System.Drawing.Point(6, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(895, 246);
            this.panel4.TabIndex = 0;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToOrderColumns = true;
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
            this.Column2,
            this.Column4,
            this.Column3,
            this.Almacén,
            this.Column1,
            this.Column6,
            this.Column11});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 0);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(895, 246);
            this.metroGrid1.TabIndex = 28;
            this.metroGrid1.UseCustomBackColor = true;
            this.metroGrid1.UseCustomForeColor = true;
            this.metroGrid1.UseStyleColors = true;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            this.metroGrid1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellDoubleClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            this.Column2.Width = 20;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "index";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            this.Column4.Width = 20;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.FillWeight = 49.76717F;
            this.Column3.HeaderText = "RUC";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 52;
            // 
            // Almacén
            // 
            this.Almacén.FillWeight = 320.8219F;
            this.Almacén.HeaderText = "Nombre";
            this.Almacén.Name = "Almacén";
            this.Almacén.ReadOnly = true;
            this.Almacén.Width = 300;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 139.2251F;
            this.Column1.HeaderText = "Dirección";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 28.84549F;
            this.Column6.HeaderText = "Teléfono";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.FillWeight = 93.35954F;
            this.Column11.HeaderText = "Correo";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage3.Controls.Add(this.label10);
            this.metroTabPage3.Controls.Add(this.label11);
            this.metroTabPage3.Controls.Add(this.label12);
            this.metroTabPage3.Controls.Add(this.label16);
            this.metroTabPage3.Controls.Add(this.label17);
            this.metroTabPage3.Controls.Add(this.textbox_email);
            this.metroTabPage3.Controls.Add(this.textbox_phone);
            this.metroTabPage3.Controls.Add(this.Cancel);
            this.metroTabPage3.Controls.Add(this.register);
            this.metroTabPage3.Controls.Add(this.textbox_name);
            this.metroTabPage3.Controls.Add(this.groupBox3);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(907, 671);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "  Registrar  ";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(239, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 92;
            this.label10.Text = "Correo (*) :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(239, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 91;
            this.label11.Text = "Teléfono (*):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkCyan;
            this.label12.Location = new System.Drawing.Point(239, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 90;
            this.label12.Text = "DOI (*):";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkCyan;
            this.label16.Location = new System.Drawing.Point(239, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 89;
            this.label16.Text = "Dirección :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkCyan;
            this.label17.Location = new System.Drawing.Point(239, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 88;
            this.label17.Text = "Nombre (*):";
            // 
            // textbox_email
            // 
            // 
            // 
            // 
            this.textbox_email.CustomButton.Image = null;
            this.textbox_email.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.textbox_email.CustomButton.Name = "";
            this.textbox_email.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.textbox_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_email.CustomButton.TabIndex = 1;
            this.textbox_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_email.CustomButton.UseSelectable = true;
            this.textbox_email.CustomButton.Visible = false;
            this.textbox_email.Lines = new string[0];
            this.textbox_email.Location = new System.Drawing.Point(361, 213);
            this.textbox_email.MaxLength = 100;
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.PasswordChar = '\0';
            this.textbox_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_email.SelectedText = "";
            this.textbox_email.SelectionLength = 0;
            this.textbox_email.SelectionStart = 0;
            this.textbox_email.ShortcutsEnabled = true;
            this.textbox_email.Size = new System.Drawing.Size(245, 27);
            this.textbox_email.TabIndex = 78;
            this.textbox_email.UseSelectable = true;
            this.textbox_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_email.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_ValidatingEmail);
            // 
            // textbox_phone
            // 
            // 
            // 
            // 
            this.textbox_phone.CustomButton.Image = null;
            this.textbox_phone.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.textbox_phone.CustomButton.Name = "";
            this.textbox_phone.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.textbox_phone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_phone.CustomButton.TabIndex = 1;
            this.textbox_phone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_phone.CustomButton.UseSelectable = true;
            this.textbox_phone.CustomButton.Visible = false;
            this.textbox_phone.Lines = new string[0];
            this.textbox_phone.Location = new System.Drawing.Point(361, 169);
            this.textbox_phone.MaxLength = 11;
            this.textbox_phone.Name = "textbox_phone";
            this.textbox_phone.PasswordChar = '\0';
            this.textbox_phone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_phone.SelectedText = "";
            this.textbox_phone.SelectionLength = 0;
            this.textbox_phone.SelectionStart = 0;
            this.textbox_phone.ShortcutsEnabled = true;
            this.textbox_phone.Size = new System.Drawing.Size(245, 27);
            this.textbox_phone.TabIndex = 76;
            this.textbox_phone.UseSelectable = true;
            this.textbox_phone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_phone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_phone.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_ValidatingPhone);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(493, 360);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(98, 27);
            this.Cancel.TabIndex = 70;
            this.Cancel.Text = "Cancelar";
            this.Cancel.UseCustomBackColor = true;
            this.Cancel.UseCustomForeColor = true;
            this.Cancel.UseSelectable = true;
            this.Cancel.UseStyleColors = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.DarkCyan;
            this.register.ForeColor = System.Drawing.Color.White;
            this.register.Location = new System.Drawing.Point(318, 360);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(98, 27);
            this.register.TabIndex = 66;
            this.register.Text = "Editar";
            this.register.UseCustomBackColor = true;
            this.register.UseCustomForeColor = true;
            this.register.UseSelectable = true;
            this.register.UseStyleColors = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // textbox_name
            // 
            // 
            // 
            // 
            this.textbox_name.CustomButton.Image = null;
            this.textbox_name.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.textbox_name.CustomButton.Name = "";
            this.textbox_name.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.textbox_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_name.CustomButton.TabIndex = 1;
            this.textbox_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_name.CustomButton.UseSelectable = true;
            this.textbox_name.CustomButton.Visible = false;
            this.textbox_name.Lines = new string[0];
            this.textbox_name.Location = new System.Drawing.Point(361, 33);
            this.textbox_name.MaxLength = 100;
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.PasswordChar = '\0';
            this.textbox_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_name.SelectedText = "";
            this.textbox_name.SelectionLength = 0;
            this.textbox_name.SelectionStart = 0;
            this.textbox_name.ShortcutsEnabled = true;
            this.textbox_name.Size = new System.Drawing.Size(245, 27);
            this.textbox_name.TabIndex = 54;
            this.textbox_name.UseSelectable = true;
            this.textbox_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_name.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validating);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textbox_doi);
            this.groupBox3.Controls.Add(this.textbox_address);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(217, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 284);
            this.groupBox3.TabIndex = 97;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Proveedor";
            // 
            // textbox_doi
            // 
            // 
            // 
            // 
            this.textbox_doi.CustomButton.Image = null;
            this.textbox_doi.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.textbox_doi.CustomButton.Name = "";
            this.textbox_doi.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.textbox_doi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_doi.CustomButton.TabIndex = 1;
            this.textbox_doi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_doi.CustomButton.UseSelectable = true;
            this.textbox_doi.CustomButton.Visible = false;
            this.textbox_doi.Lines = new string[0];
            this.textbox_doi.Location = new System.Drawing.Point(144, 64);
            this.textbox_doi.MaxLength = 12;
            this.textbox_doi.Name = "textbox_doi";
            this.textbox_doi.PasswordChar = '\0';
            this.textbox_doi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_doi.SelectedText = "";
            this.textbox_doi.SelectionLength = 0;
            this.textbox_doi.SelectionStart = 0;
            this.textbox_doi.ShortcutsEnabled = true;
            this.textbox_doi.Size = new System.Drawing.Size(245, 27);
            this.textbox_doi.TabIndex = 74;
            this.textbox_doi.UseSelectable = true;
            this.textbox_doi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_doi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_doi.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validating);
            // 
            // textbox_address
            // 
            // 
            // 
            // 
            this.textbox_address.CustomButton.Image = null;
            this.textbox_address.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.textbox_address.CustomButton.Name = "";
            this.textbox_address.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.textbox_address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_address.CustomButton.TabIndex = 1;
            this.textbox_address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_address.CustomButton.UseSelectable = true;
            this.textbox_address.CustomButton.Visible = false;
            this.textbox_address.Lines = new string[0];
            this.textbox_address.Location = new System.Drawing.Point(144, 107);
            this.textbox_address.MaxLength = 200;
            this.textbox_address.Name = "textbox_address";
            this.textbox_address.PasswordChar = '\0';
            this.textbox_address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_address.SelectedText = "";
            this.textbox_address.SelectionLength = 0;
            this.textbox_address.SelectionStart = 0;
            this.textbox_address.ShortcutsEnabled = true;
            this.textbox_address.Size = new System.Drawing.Size(245, 27);
            this.textbox_address.TabIndex = 72;
            this.textbox_address.UseSelectable = true;
            this.textbox_address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_address.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Supplier";
            this.Size = new System.Drawing.Size(915, 713);
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton Cancel;
        private MetroFramework.Controls.MetroButton register;
        private MetroFramework.Controls.MetroTextBox textbox_name;
        private MetroFramework.Controls.MetroTextBox textbox_email;
        private MetroFramework.Controls.MetroTextBox textbox_phone;
        private MetroFramework.Controls.MetroTextBox textbox_doi;
        private MetroFramework.Controls.MetroTextBox textbox_address;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox textbox_name_s;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label14;
        private MetroFramework.Controls.MetroTextBox textbox_doi_s;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTile btn_import;
        private MetroFramework.Controls.MetroTile btn_template;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Almacén;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}
