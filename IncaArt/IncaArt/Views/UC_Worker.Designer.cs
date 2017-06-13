namespace WindowsFormsApp1.Views
{
    partial class UC_Worker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.consulta = new MetroFramework.Controls.MetroTabPage();
            this.btn_delete = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paternal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maternal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textbox_name_s = new MetroFramework.Controls.MetroTextBox();
            this.btn_search = new MetroFramework.Controls.MetroButton();
            this.combobox_shift_s = new MetroFramework.Controls.MetroComboBox();
            this.btn_clean_s = new MetroFramework.Controls.MetroButton();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textbox_maternal_s = new MetroFramework.Controls.MetroTextBox();
            this.textbox_doi_s = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.textbox_paternal_s = new MetroFramework.Controls.MetroTextBox();
            this.registro = new MetroFramework.Controls.MetroTabPage();
            this.group = new System.Windows.Forms.GroupBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.combobox_currency = new MetroFramework.Controls.MetroComboBox();
            this.textbox_salary = new MetroFramework.Controls.MetroTextBox();
            this.combobox_shift = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.textbox_address = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.radiobutton_f = new MetroFramework.Controls.MetroRadioButton();
            this.radiobutton_m = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.textbox_doi = new MetroFramework.Controls.MetroTextBox();
            this.textbox_maternal = new MetroFramework.Controls.MetroTextBox();
            this.textbox_email = new MetroFramework.Controls.MetroTextBox();
            this.textbox_phone = new MetroFramework.Controls.MetroTextBox();
            this.textbox_telephone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.datetime_birthday = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.textbox_paternal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.textbox_name = new MetroFramework.Controls.MetroTextBox();
            this.btn_cancel = new MetroFramework.Controls.MetroButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_save = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.consulta.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.registro.SuspendLayout();
            this.group.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.consulta);
            this.metroTabControl1.Controls.Add(this.registro);
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.metroTabControl1.Location = new System.Drawing.Point(15, 15);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(721, 502);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseCustomForeColor = true;
            this.metroTabControl1.UseSelectable = true;
            // 
            // consulta
            // 
            this.consulta.Controls.Add(this.btn_delete);
            this.consulta.Controls.Add(this.groupBox3);
            this.consulta.Controls.Add(this.groupBox2);
            this.consulta.HorizontalScrollbarBarColor = true;
            this.consulta.HorizontalScrollbarHighlightOnWheel = false;
            this.consulta.HorizontalScrollbarSize = 10;
            this.consulta.Location = new System.Drawing.Point(4, 38);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(713, 460);
            this.consulta.TabIndex = 0;
            this.consulta.Text = "Consulta";
            this.consulta.VerticalScrollbarBarColor = true;
            this.consulta.VerticalScrollbarHighlightOnWheel = false;
            this.consulta.VerticalScrollbarSize = 10;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            this.btn_delete.Location = new System.Drawing.Point(490, 434);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseCustomBackColor = true;
            this.btn_delete.UseCustomForeColor = true;
            this.btn_delete.UseSelectable = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.metroGrid1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(3, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(562, 220);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.index,
            this.doi,
            this.name,
            this.paternal,
            this.maternal,
            this.shift});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(6, 25);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(545, 178);
            this.metroGrid1.TabIndex = 2;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            this.metroGrid1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellDoubleClick);
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
            // doi
            // 
            this.doi.HeaderText = "DOI";
            this.doi.Name = "doi";
            // 
            // name
            // 
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            // 
            // paternal
            // 
            this.paternal.HeaderText = "Apellido Paterno";
            this.paternal.Name = "paternal";
            // 
            // maternal
            // 
            this.maternal.HeaderText = "Apellido Materno";
            this.maternal.Name = "maternal";
            // 
            // shift
            // 
            this.shift.HeaderText = "Turno";
            this.shift.Name = "shift";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.textbox_name_s);
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.combobox_shift_s);
            this.groupBox2.Controls.Add(this.btn_clean_s);
            this.groupBox2.Controls.Add(this.metroLabel15);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.textbox_maternal_s);
            this.groupBox2.Controls.Add(this.textbox_doi_s);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.textbox_paternal_s);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(3, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 188);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel1.Location = new System.Drawing.Point(15, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 15);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Nombre:";
            this.metroLabel1.UseCustomForeColor = true;
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
            this.textbox_name_s.Location = new System.Drawing.Point(137, 27);
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
            this.btn_search.Location = new System.Drawing.Point(395, 159);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseCustomBackColor = true;
            this.btn_search.UseCustomForeColor = true;
            this.btn_search.UseSelectable = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // combobox_shift_s
            // 
            this.combobox_shift_s.FormattingEnabled = true;
            this.combobox_shift_s.ItemHeight = 23;
            this.combobox_shift_s.Location = new System.Drawing.Point(136, 107);
            this.combobox_shift_s.Name = "combobox_shift_s";
            this.combobox_shift_s.Size = new System.Drawing.Size(121, 29);
            this.combobox_shift_s.TabIndex = 21;
            this.combobox_shift_s.UseSelectable = true;
            // 
            // btn_clean_s
            // 
            this.btn_clean_s.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_clean_s.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            this.btn_clean_s.Location = new System.Drawing.Point(476, 159);
            this.btn_clean_s.Name = "btn_clean_s";
            this.btn_clean_s.Size = new System.Drawing.Size(75, 23);
            this.btn_clean_s.TabIndex = 12;
            this.btn_clean_s.Text = "Limpiar";
            this.btn_clean_s.UseCustomBackColor = true;
            this.btn_clean_s.UseCustomForeColor = true;
            this.btn_clean_s.UseSelectable = true;
            this.btn_clean_s.Click += new System.EventHandler(this.btn_clean_s_Click);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel15.Location = new System.Drawing.Point(15, 107);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(43, 15);
            this.metroLabel15.TabIndex = 20;
            this.metroLabel15.Text = "Turno:";
            this.metroLabel15.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel2.Location = new System.Drawing.Point(276, 27);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(32, 15);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "DOI:";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // textbox_maternal_s
            // 
            // 
            // 
            // 
            this.textbox_maternal_s.CustomButton.Image = null;
            this.textbox_maternal_s.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.textbox_maternal_s.CustomButton.Name = "";
            this.textbox_maternal_s.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_maternal_s.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_maternal_s.CustomButton.TabIndex = 1;
            this.textbox_maternal_s.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_maternal_s.CustomButton.UseSelectable = true;
            this.textbox_maternal_s.CustomButton.Visible = false;
            this.textbox_maternal_s.Lines = new string[0];
            this.textbox_maternal_s.Location = new System.Drawing.Point(400, 66);
            this.textbox_maternal_s.MaxLength = 32767;
            this.textbox_maternal_s.Name = "textbox_maternal_s";
            this.textbox_maternal_s.PasswordChar = '\0';
            this.textbox_maternal_s.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_maternal_s.SelectedText = "";
            this.textbox_maternal_s.SelectionLength = 0;
            this.textbox_maternal_s.SelectionStart = 0;
            this.textbox_maternal_s.ShortcutsEnabled = true;
            this.textbox_maternal_s.Size = new System.Drawing.Size(120, 23);
            this.textbox_maternal_s.TabIndex = 19;
            this.textbox_maternal_s.UseSelectable = true;
            this.textbox_maternal_s.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_maternal_s.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textbox_doi_s
            // 
            // 
            // 
            // 
            this.textbox_doi_s.CustomButton.Image = null;
            this.textbox_doi_s.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.textbox_doi_s.CustomButton.Name = "";
            this.textbox_doi_s.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_doi_s.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_doi_s.CustomButton.TabIndex = 1;
            this.textbox_doi_s.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_doi_s.CustomButton.UseSelectable = true;
            this.textbox_doi_s.CustomButton.Visible = false;
            this.textbox_doi_s.Lines = new string[0];
            this.textbox_doi_s.Location = new System.Drawing.Point(400, 27);
            this.textbox_doi_s.MaxLength = 32767;
            this.textbox_doi_s.Name = "textbox_doi_s";
            this.textbox_doi_s.PasswordChar = '\0';
            this.textbox_doi_s.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_doi_s.SelectedText = "";
            this.textbox_doi_s.SelectionLength = 0;
            this.textbox_doi_s.SelectionStart = 0;
            this.textbox_doi_s.ShortcutsEnabled = true;
            this.textbox_doi_s.Size = new System.Drawing.Size(120, 23);
            this.textbox_doi_s.TabIndex = 15;
            this.textbox_doi_s.UseSelectable = true;
            this.textbox_doi_s.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_doi_s.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel4.Location = new System.Drawing.Point(276, 65);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(106, 15);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Apellido materno:";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel3.Location = new System.Drawing.Point(15, 66);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(102, 15);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Apellido Paterno:";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // textbox_paternal_s
            // 
            // 
            // 
            // 
            this.textbox_paternal_s.CustomButton.Image = null;
            this.textbox_paternal_s.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.textbox_paternal_s.CustomButton.Name = "";
            this.textbox_paternal_s.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_paternal_s.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_paternal_s.CustomButton.TabIndex = 1;
            this.textbox_paternal_s.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_paternal_s.CustomButton.UseSelectable = true;
            this.textbox_paternal_s.CustomButton.Visible = false;
            this.textbox_paternal_s.Lines = new string[0];
            this.textbox_paternal_s.Location = new System.Drawing.Point(137, 66);
            this.textbox_paternal_s.MaxLength = 32767;
            this.textbox_paternal_s.Name = "textbox_paternal_s";
            this.textbox_paternal_s.PasswordChar = '\0';
            this.textbox_paternal_s.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_paternal_s.SelectedText = "";
            this.textbox_paternal_s.SelectionLength = 0;
            this.textbox_paternal_s.SelectionStart = 0;
            this.textbox_paternal_s.ShortcutsEnabled = true;
            this.textbox_paternal_s.Size = new System.Drawing.Size(120, 23);
            this.textbox_paternal_s.TabIndex = 17;
            this.textbox_paternal_s.UseSelectable = true;
            this.textbox_paternal_s.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_paternal_s.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // registro
            // 
            this.registro.Controls.Add(this.btn_save);
            this.registro.Controls.Add(this.group);
            this.registro.Controls.Add(this.groupBox1);
            this.registro.Controls.Add(this.btn_cancel);
            this.registro.HorizontalScrollbarBarColor = true;
            this.registro.HorizontalScrollbarHighlightOnWheel = false;
            this.registro.HorizontalScrollbarSize = 10;
            this.registro.Location = new System.Drawing.Point(4, 38);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(713, 460);
            this.registro.TabIndex = 1;
            this.registro.Text = "Registro";
            this.registro.VerticalScrollbarBarColor = true;
            this.registro.VerticalScrollbarHighlightOnWheel = false;
            this.registro.VerticalScrollbarSize = 10;
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.group.Controls.Add(this.metroLabel19);
            this.group.Controls.Add(this.combobox_currency);
            this.group.Controls.Add(this.textbox_salary);
            this.group.Controls.Add(this.combobox_shift);
            this.group.Controls.Add(this.metroLabel14);
            this.group.Controls.Add(this.metroLabel13);
            this.group.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.group.Location = new System.Drawing.Point(366, 9);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(326, 119);
            this.group.TabIndex = 17;
            this.group.TabStop = false;
            this.group.Text = "Datos del Trabajador";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel19.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel19.Location = new System.Drawing.Point(4, 101);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(134, 15);
            this.metroLabel19.TabIndex = 18;
            this.metroLabel19.Text = "(*) Campos obligatorios";
            this.metroLabel19.UseCustomForeColor = true;
            // 
            // combobox_currency
            // 
            this.combobox_currency.FormattingEnabled = true;
            this.combobox_currency.ItemHeight = 23;
            this.combobox_currency.Location = new System.Drawing.Point(215, 59);
            this.combobox_currency.Name = "combobox_currency";
            this.combobox_currency.Size = new System.Drawing.Size(41, 29);
            this.combobox_currency.TabIndex = 4;
            this.combobox_currency.UseSelectable = true;
            this.combobox_currency.Validating += new System.ComponentModel.CancelEventHandler(this.combobox_Validating);
            // 
            // textbox_salary
            // 
            // 
            // 
            // 
            this.textbox_salary.CustomButton.Image = null;
            this.textbox_salary.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.textbox_salary.CustomButton.Name = "";
            this.textbox_salary.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_salary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_salary.CustomButton.TabIndex = 1;
            this.textbox_salary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_salary.CustomButton.UseSelectable = true;
            this.textbox_salary.CustomButton.Visible = false;
            this.textbox_salary.Lines = new string[0];
            this.textbox_salary.Location = new System.Drawing.Point(68, 59);
            this.textbox_salary.MaxLength = 32767;
            this.textbox_salary.Name = "textbox_salary";
            this.textbox_salary.PasswordChar = '\0';
            this.textbox_salary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_salary.SelectedText = "";
            this.textbox_salary.SelectionLength = 0;
            this.textbox_salary.SelectionStart = 0;
            this.textbox_salary.ShortcutsEnabled = true;
            this.textbox_salary.Size = new System.Drawing.Size(121, 23);
            this.textbox_salary.TabIndex = 3;
            this.textbox_salary.UseSelectable = true;
            this.textbox_salary.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_salary.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_salary.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_number_Validating);
            // 
            // combobox_shift
            // 
            this.combobox_shift.FormattingEnabled = true;
            this.combobox_shift.ItemHeight = 23;
            this.combobox_shift.Location = new System.Drawing.Point(68, 23);
            this.combobox_shift.Name = "combobox_shift";
            this.combobox_shift.Size = new System.Drawing.Size(188, 29);
            this.combobox_shift.TabIndex = 2;
            this.combobox_shift.UseSelectable = true;
            this.combobox_shift.Validating += new System.ComponentModel.CancelEventHandler(this.combobox_Validating);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel14.Location = new System.Drawing.Point(7, 60);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(60, 15);
            this.metroLabel14.TabIndex = 1;
            this.metroLabel14.Text = "Salario (*)";
            this.metroLabel14.UseCustomForeColor = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel13.Location = new System.Drawing.Point(6, 27);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(56, 15);
            this.metroLabel13.TabIndex = 0;
            this.metroLabel13.Text = "Turno (*)";
            this.metroLabel13.UseCustomForeColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.metroLabel18);
            this.groupBox1.Controls.Add(this.textbox_address);
            this.groupBox1.Controls.Add(this.metroLabel17);
            this.groupBox1.Controls.Add(this.radiobutton_f);
            this.groupBox1.Controls.Add(this.radiobutton_m);
            this.groupBox1.Controls.Add(this.metroLabel16);
            this.groupBox1.Controls.Add(this.textbox_doi);
            this.groupBox1.Controls.Add(this.textbox_maternal);
            this.groupBox1.Controls.Add(this.textbox_email);
            this.groupBox1.Controls.Add(this.textbox_phone);
            this.groupBox1.Controls.Add(this.textbox_telephone);
            this.groupBox1.Controls.Add(this.metroLabel12);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.datetime_birthday);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.textbox_paternal);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.textbox_name);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(3, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 344);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel18.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel18.Location = new System.Drawing.Point(6, 326);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(134, 15);
            this.metroLabel18.TabIndex = 18;
            this.metroLabel18.Text = "(*) Campos obligatorios";
            this.metroLabel18.UseCustomForeColor = true;
            // 
            // textbox_address
            // 
            // 
            // 
            // 
            this.textbox_address.CustomButton.Image = null;
            this.textbox_address.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.textbox_address.CustomButton.Name = "";
            this.textbox_address.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_address.CustomButton.TabIndex = 1;
            this.textbox_address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_address.CustomButton.UseSelectable = true;
            this.textbox_address.CustomButton.Visible = false;
            this.textbox_address.Lines = new string[0];
            this.textbox_address.Location = new System.Drawing.Point(147, 298);
            this.textbox_address.MaxLength = 32767;
            this.textbox_address.Name = "textbox_address";
            this.textbox_address.PasswordChar = '\0';
            this.textbox_address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_address.SelectedText = "";
            this.textbox_address.SelectionLength = 0;
            this.textbox_address.SelectionStart = 0;
            this.textbox_address.ShortcutsEnabled = true;
            this.textbox_address.Size = new System.Drawing.Size(122, 23);
            this.textbox_address.TabIndex = 28;
            this.textbox_address.UseSelectable = true;
            this.textbox_address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.metroLabel17.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel17.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel17.Location = new System.Drawing.Point(8, 298);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(63, 15);
            this.metroLabel17.TabIndex = 27;
            this.metroLabel17.Text = "Dirección:";
            this.metroLabel17.UseCustomForeColor = true;
            // 
            // radiobutton_f
            // 
            this.radiobutton_f.AutoSize = true;
            this.radiobutton_f.Location = new System.Drawing.Point(199, 183);
            this.radiobutton_f.Name = "radiobutton_f";
            this.radiobutton_f.Size = new System.Drawing.Size(29, 15);
            this.radiobutton_f.TabIndex = 26;
            this.radiobutton_f.Text = "F";
            this.radiobutton_f.UseSelectable = true;
            // 
            // radiobutton_m
            // 
            this.radiobutton_m.AutoSize = true;
            this.radiobutton_m.Location = new System.Drawing.Point(149, 183);
            this.radiobutton_m.Name = "radiobutton_m";
            this.radiobutton_m.Size = new System.Drawing.Size(34, 15);
            this.radiobutton_m.TabIndex = 25;
            this.radiobutton_m.Text = "M";
            this.radiobutton_m.UseSelectable = true;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.metroLabel16.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel16.Location = new System.Drawing.Point(9, 180);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(52, 15);
            this.metroLabel16.TabIndex = 24;
            this.metroLabel16.Text = "Género:";
            this.metroLabel16.UseCustomForeColor = true;
            // 
            // textbox_doi
            // 
            // 
            // 
            // 
            this.textbox_doi.CustomButton.Image = null;
            this.textbox_doi.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.textbox_doi.CustomButton.Name = "";
            this.textbox_doi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_doi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_doi.CustomButton.TabIndex = 1;
            this.textbox_doi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_doi.CustomButton.UseSelectable = true;
            this.textbox_doi.CustomButton.Visible = false;
            this.textbox_doi.Lines = new string[0];
            this.textbox_doi.Location = new System.Drawing.Point(147, 115);
            this.textbox_doi.MaxLength = 32767;
            this.textbox_doi.Name = "textbox_doi";
            this.textbox_doi.PasswordChar = '\0';
            this.textbox_doi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_doi.SelectedText = "";
            this.textbox_doi.SelectionLength = 0;
            this.textbox_doi.SelectionStart = 0;
            this.textbox_doi.ShortcutsEnabled = true;
            this.textbox_doi.Size = new System.Drawing.Size(121, 23);
            this.textbox_doi.TabIndex = 23;
            this.textbox_doi.UseSelectable = true;
            this.textbox_doi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_doi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_doi.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_number_Validating);
            // 
            // textbox_maternal
            // 
            // 
            // 
            // 
            this.textbox_maternal.CustomButton.Image = null;
            this.textbox_maternal.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.textbox_maternal.CustomButton.Name = "";
            this.textbox_maternal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_maternal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_maternal.CustomButton.TabIndex = 1;
            this.textbox_maternal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_maternal.CustomButton.UseSelectable = true;
            this.textbox_maternal.CustomButton.Visible = false;
            this.textbox_maternal.Lines = new string[0];
            this.textbox_maternal.Location = new System.Drawing.Point(147, 84);
            this.textbox_maternal.MaxLength = 32767;
            this.textbox_maternal.Name = "textbox_maternal";
            this.textbox_maternal.PasswordChar = '\0';
            this.textbox_maternal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_maternal.SelectedText = "";
            this.textbox_maternal.SelectionLength = 0;
            this.textbox_maternal.SelectionStart = 0;
            this.textbox_maternal.ShortcutsEnabled = true;
            this.textbox_maternal.Size = new System.Drawing.Size(121, 23);
            this.textbox_maternal.TabIndex = 22;
            this.textbox_maternal.UseSelectable = true;
            this.textbox_maternal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_maternal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_maternal.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validating);
            // 
            // textbox_email
            // 
            // 
            // 
            // 
            this.textbox_email.CustomButton.Image = null;
            this.textbox_email.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.textbox_email.CustomButton.Name = "";
            this.textbox_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_email.CustomButton.TabIndex = 1;
            this.textbox_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_email.CustomButton.UseSelectable = true;
            this.textbox_email.CustomButton.Visible = false;
            this.textbox_email.Lines = new string[0];
            this.textbox_email.Location = new System.Drawing.Point(148, 264);
            this.textbox_email.MaxLength = 32767;
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.PasswordChar = '\0';
            this.textbox_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_email.SelectedText = "";
            this.textbox_email.SelectionLength = 0;
            this.textbox_email.SelectionStart = 0;
            this.textbox_email.ShortcutsEnabled = true;
            this.textbox_email.Size = new System.Drawing.Size(121, 23);
            this.textbox_email.TabIndex = 21;
            this.textbox_email.UseSelectable = true;
            this.textbox_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_email.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_email_Validating);
            // 
            // textbox_phone
            // 
            // 
            // 
            // 
            this.textbox_phone.CustomButton.Image = null;
            this.textbox_phone.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.textbox_phone.CustomButton.Name = "";
            this.textbox_phone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_phone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_phone.CustomButton.TabIndex = 1;
            this.textbox_phone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_phone.CustomButton.UseSelectable = true;
            this.textbox_phone.CustomButton.Visible = false;
            this.textbox_phone.Lines = new string[0];
            this.textbox_phone.Location = new System.Drawing.Point(148, 234);
            this.textbox_phone.MaxLength = 32767;
            this.textbox_phone.Name = "textbox_phone";
            this.textbox_phone.PasswordChar = '\0';
            this.textbox_phone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_phone.SelectedText = "";
            this.textbox_phone.SelectionLength = 0;
            this.textbox_phone.SelectionStart = 0;
            this.textbox_phone.ShortcutsEnabled = true;
            this.textbox_phone.Size = new System.Drawing.Size(121, 23);
            this.textbox_phone.TabIndex = 20;
            this.textbox_phone.UseSelectable = true;
            this.textbox_phone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_phone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textbox_telephone
            // 
            // 
            // 
            // 
            this.textbox_telephone.CustomButton.Image = null;
            this.textbox_telephone.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.textbox_telephone.CustomButton.Name = "";
            this.textbox_telephone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_telephone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_telephone.CustomButton.TabIndex = 1;
            this.textbox_telephone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_telephone.CustomButton.UseSelectable = true;
            this.textbox_telephone.CustomButton.Visible = false;
            this.textbox_telephone.Lines = new string[0];
            this.textbox_telephone.Location = new System.Drawing.Point(148, 205);
            this.textbox_telephone.MaxLength = 32767;
            this.textbox_telephone.Name = "textbox_telephone";
            this.textbox_telephone.PasswordChar = '\0';
            this.textbox_telephone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_telephone.SelectedText = "";
            this.textbox_telephone.SelectionLength = 0;
            this.textbox_telephone.SelectionStart = 0;
            this.textbox_telephone.ShortcutsEnabled = true;
            this.textbox_telephone.Size = new System.Drawing.Size(121, 23);
            this.textbox_telephone.TabIndex = 19;
            this.textbox_telephone.UseSelectable = true;
            this.textbox_telephone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_telephone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel12.Location = new System.Drawing.Point(10, 264);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(61, 15);
            this.metroLabel12.TabIndex = 18;
            this.metroLabel12.Text = "Correo (*)";
            this.metroLabel12.UseCustomForeColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel11.Location = new System.Drawing.Point(8, 234);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(48, 15);
            this.metroLabel11.TabIndex = 17;
            this.metroLabel11.Text = "Celular:";
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel10.Location = new System.Drawing.Point(8, 205);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(60, 15);
            this.metroLabel10.TabIndex = 16;
            this.metroLabel10.Text = "Teléfono:";
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel5.Location = new System.Drawing.Point(6, 27);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(69, 15);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Nombre (*)";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // datetime_birthday
            // 
            this.datetime_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime_birthday.Location = new System.Drawing.Point(148, 146);
            this.datetime_birthday.MinimumSize = new System.Drawing.Size(0, 29);
            this.datetime_birthday.Name = "datetime_birthday";
            this.datetime_birthday.Size = new System.Drawing.Size(119, 29);
            this.datetime_birthday.TabIndex = 15;
            this.datetime_birthday.Value = new System.DateTime(2017, 5, 28, 14, 18, 3, 0);
            this.datetime_birthday.Validating += new System.ComponentModel.CancelEventHandler(this.datetimepicker_Validating);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel6.Location = new System.Drawing.Point(6, 53);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(115, 15);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Apellido Paterno (*)";
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // textbox_paternal
            // 
            // 
            // 
            // 
            this.textbox_paternal.CustomButton.Image = null;
            this.textbox_paternal.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.textbox_paternal.CustomButton.Name = "";
            this.textbox_paternal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_paternal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_paternal.CustomButton.TabIndex = 1;
            this.textbox_paternal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_paternal.CustomButton.UseSelectable = true;
            this.textbox_paternal.CustomButton.Visible = false;
            this.textbox_paternal.Lines = new string[0];
            this.textbox_paternal.Location = new System.Drawing.Point(147, 53);
            this.textbox_paternal.MaxLength = 32767;
            this.textbox_paternal.Name = "textbox_paternal";
            this.textbox_paternal.PasswordChar = '\0';
            this.textbox_paternal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_paternal.SelectedText = "";
            this.textbox_paternal.SelectionLength = 0;
            this.textbox_paternal.SelectionStart = 0;
            this.textbox_paternal.ShortcutsEnabled = true;
            this.textbox_paternal.Size = new System.Drawing.Size(121, 23);
            this.textbox_paternal.TabIndex = 14;
            this.textbox_paternal.UseSelectable = true;
            this.textbox_paternal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_paternal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_paternal.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validating);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel7.Location = new System.Drawing.Point(6, 84);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(119, 15);
            this.metroLabel7.TabIndex = 4;
            this.metroLabel7.Text = "Apellido Materno (*)";
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel9.Location = new System.Drawing.Point(7, 150);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(139, 15);
            this.metroLabel9.TabIndex = 13;
            this.metroLabel9.Text = "Fecha de Nacimiento (*)";
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel8.Location = new System.Drawing.Point(6, 118);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(45, 15);
            this.metroLabel8.TabIndex = 5;
            this.metroLabel8.Text = "DOI (*)";
            this.metroLabel8.UseCustomForeColor = true;
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
            this.textbox_name.Location = new System.Drawing.Point(147, 23);
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
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            this.btn_cancel.Location = new System.Drawing.Point(616, 359);
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
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            this.btn_save.Location = new System.Drawing.Point(535, 359);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 19;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseCustomBackColor = true;
            this.btn_save.UseCustomForeColor = true;
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // UC_Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Name = "UC_Worker";
            this.Size = new System.Drawing.Size(794, 527);
            this.Load += new System.EventHandler(this.UC_Worker_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.consulta.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.registro.ResumeLayout(false);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage consulta;
        private MetroFramework.Controls.MetroButton btn_delete;
        private MetroFramework.Controls.MetroButton btn_clean_s;
        private MetroFramework.Controls.MetroButton btn_search;
        private MetroFramework.Controls.MetroTextBox textbox_name_s;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTextBox textbox_maternal_s;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox textbox_paternal_s;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox textbox_doi_s;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn doi;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn paternal;
        private System.Windows.Forms.DataGridViewTextBoxColumn maternal;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift;
        private MetroFramework.Controls.MetroComboBox combobox_shift_s;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTabPage registro;
        private System.Windows.Forms.GroupBox group;
        private MetroFramework.Controls.MetroTextBox textbox_salary;
        private MetroFramework.Controls.MetroComboBox combobox_shift;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox textbox_address;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroRadioButton radiobutton_f;
        private MetroFramework.Controls.MetroRadioButton radiobutton_m;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox textbox_doi;
        private MetroFramework.Controls.MetroTextBox textbox_maternal;
        private MetroFramework.Controls.MetroTextBox textbox_email;
        private MetroFramework.Controls.MetroTextBox textbox_phone;
        private MetroFramework.Controls.MetroTextBox textbox_telephone;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime datetime_birthday;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox textbox_paternal;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox textbox_name;
        private MetroFramework.Controls.MetroButton btn_cancel;
        private MetroFramework.Controls.MetroComboBox combobox_currency;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroButton btn_save;
    }
}
