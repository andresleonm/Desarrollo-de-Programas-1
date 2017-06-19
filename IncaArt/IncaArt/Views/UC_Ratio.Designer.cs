namespace WindowsFormsApp1.Views
{
    partial class UC_Ratio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.consulta = new MetroFramework.Controls.MetroTabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combobox_ratio_type_s = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.combobox_product_s = new MetroFramework.Controls.MetroComboBox();
            this.combobox_workstation_s = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textbox_wname_s = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.textbox_wpaternal_s = new MetroFramework.Controls.MetroTextBox();
            this.textbox_wmaternal_s = new MetroFramework.Controls.MetroTextBox();
            this.btn_search = new MetroFramework.Controls.MetroButton();
            this.btn_clean_s = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.btn_export = new MetroFramework.Controls.MetroButton();
            this.btn_import = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.consulta.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.consulta);
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.metroTabControl1.Location = new System.Drawing.Point(12, 16);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(721, 502);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseCustomBackColor = true;
            this.metroTabControl1.UseCustomForeColor = true;
            this.metroTabControl1.UseSelectable = true;
            // 
            // consulta
            // 
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.metroGrid1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(17, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(650, 220);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(6, 25);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(623, 178);
            this.metroGrid1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Trabajador";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Producto";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Puesto de Trabajao";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tipo Ratio";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Valor";
            this.Column5.Name = "Column5";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.btn_import);
            this.groupBox2.Controls.Add(this.btn_export);
            this.groupBox2.Controls.Add(this.combobox_ratio_type_s);
            this.groupBox2.Controls.Add(this.metroLabel20);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.btn_clean_s);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(3, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 220);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // combobox_ratio_type_s
            // 
            this.combobox_ratio_type_s.FormattingEnabled = true;
            this.combobox_ratio_type_s.ItemHeight = 23;
            this.combobox_ratio_type_s.Location = new System.Drawing.Point(104, 159);
            this.combobox_ratio_type_s.Name = "combobox_ratio_type_s";
            this.combobox_ratio_type_s.Size = new System.Drawing.Size(143, 29);
            this.combobox_ratio_type_s.TabIndex = 24;
            this.combobox_ratio_type_s.UseSelectable = true;
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel20.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel20.Location = new System.Drawing.Point(15, 159);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(83, 15);
            this.metroLabel20.TabIndex = 20;
            this.metroLabel20.Text = "Tipo de Ratio:";
            this.metroLabel20.UseCustomForeColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.combobox_product_s);
            this.groupBox5.Controls.Add(this.combobox_workstation_s);
            this.groupBox5.Controls.Add(this.metroLabel2);
            this.groupBox5.Controls.Add(this.metroLabel15);
            this.groupBox5.Location = new System.Drawing.Point(326, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(250, 126);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Puesto de Trabajo";
            // 
            // combobox_product_s
            // 
            this.combobox_product_s.FormattingEnabled = true;
            this.combobox_product_s.ItemHeight = 23;
            this.combobox_product_s.Location = new System.Drawing.Point(87, 71);
            this.combobox_product_s.Name = "combobox_product_s";
            this.combobox_product_s.Size = new System.Drawing.Size(143, 29);
            this.combobox_product_s.TabIndex = 23;
            this.combobox_product_s.UseSelectable = true;
            // 
            // combobox_workstation_s
            // 
            this.combobox_workstation_s.FormattingEnabled = true;
            this.combobox_workstation_s.ItemHeight = 23;
            this.combobox_workstation_s.Location = new System.Drawing.Point(87, 25);
            this.combobox_workstation_s.Name = "combobox_workstation_s";
            this.combobox_workstation_s.Size = new System.Drawing.Size(143, 29);
            this.combobox_workstation_s.TabIndex = 22;
            this.combobox_workstation_s.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel2.Location = new System.Drawing.Point(6, 30);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 15);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Puesto:";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel15.Location = new System.Drawing.Point(6, 74);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(61, 15);
            this.metroLabel15.TabIndex = 21;
            this.metroLabel15.Text = "Producto:";
            this.metroLabel15.UseCustomForeColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textbox_wname_s);
            this.groupBox4.Controls.Add(this.metroLabel1);
            this.groupBox4.Controls.Add(this.metroLabel3);
            this.groupBox4.Controls.Add(this.metroLabel4);
            this.groupBox4.Controls.Add(this.textbox_wpaternal_s);
            this.groupBox4.Controls.Add(this.textbox_wmaternal_s);
            this.groupBox4.Location = new System.Drawing.Point(15, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(305, 128);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trabajador";
            // 
            // textbox_wname_s
            // 
            // 
            // 
            // 
            this.textbox_wname_s.CustomButton.Image = null;
            this.textbox_wname_s.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.textbox_wname_s.CustomButton.Name = "";
            this.textbox_wname_s.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_wname_s.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_wname_s.CustomButton.TabIndex = 1;
            this.textbox_wname_s.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_wname_s.CustomButton.UseSelectable = true;
            this.textbox_wname_s.CustomButton.Visible = false;
            this.textbox_wname_s.Lines = new string[0];
            this.textbox_wname_s.Location = new System.Drawing.Point(127, 27);
            this.textbox_wname_s.MaxLength = 32767;
            this.textbox_wname_s.Name = "textbox_wname_s";
            this.textbox_wname_s.PasswordChar = '\0';
            this.textbox_wname_s.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_wname_s.SelectedText = "";
            this.textbox_wname_s.SelectionLength = 0;
            this.textbox_wname_s.SelectionStart = 0;
            this.textbox_wname_s.ShortcutsEnabled = true;
            this.textbox_wname_s.Size = new System.Drawing.Size(120, 23);
            this.textbox_wname_s.TabIndex = 7;
            this.textbox_wname_s.UseSelectable = true;
            this.textbox_wname_s.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_wname_s.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel1.Location = new System.Drawing.Point(6, 32);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 15);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Nombre:";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel3.Location = new System.Drawing.Point(6, 59);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(102, 15);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Apellido Paterno:";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel4.Location = new System.Drawing.Point(6, 87);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(106, 15);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Apellido materno:";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // textbox_wpaternal_s
            // 
            // 
            // 
            // 
            this.textbox_wpaternal_s.CustomButton.Image = null;
            this.textbox_wpaternal_s.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.textbox_wpaternal_s.CustomButton.Name = "";
            this.textbox_wpaternal_s.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_wpaternal_s.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_wpaternal_s.CustomButton.TabIndex = 1;
            this.textbox_wpaternal_s.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_wpaternal_s.CustomButton.UseSelectable = true;
            this.textbox_wpaternal_s.CustomButton.Visible = false;
            this.textbox_wpaternal_s.Lines = new string[0];
            this.textbox_wpaternal_s.Location = new System.Drawing.Point(127, 56);
            this.textbox_wpaternal_s.MaxLength = 32767;
            this.textbox_wpaternal_s.Name = "textbox_wpaternal_s";
            this.textbox_wpaternal_s.PasswordChar = '\0';
            this.textbox_wpaternal_s.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_wpaternal_s.SelectedText = "";
            this.textbox_wpaternal_s.SelectionLength = 0;
            this.textbox_wpaternal_s.SelectionStart = 0;
            this.textbox_wpaternal_s.ShortcutsEnabled = true;
            this.textbox_wpaternal_s.Size = new System.Drawing.Size(120, 23);
            this.textbox_wpaternal_s.TabIndex = 17;
            this.textbox_wpaternal_s.UseSelectable = true;
            this.textbox_wpaternal_s.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_wpaternal_s.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textbox_wmaternal_s
            // 
            // 
            // 
            // 
            this.textbox_wmaternal_s.CustomButton.Image = null;
            this.textbox_wmaternal_s.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.textbox_wmaternal_s.CustomButton.Name = "";
            this.textbox_wmaternal_s.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_wmaternal_s.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_wmaternal_s.CustomButton.TabIndex = 1;
            this.textbox_wmaternal_s.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_wmaternal_s.CustomButton.UseSelectable = true;
            this.textbox_wmaternal_s.CustomButton.Visible = false;
            this.textbox_wmaternal_s.Lines = new string[0];
            this.textbox_wmaternal_s.Location = new System.Drawing.Point(127, 85);
            this.textbox_wmaternal_s.MaxLength = 32767;
            this.textbox_wmaternal_s.Name = "textbox_wmaternal_s";
            this.textbox_wmaternal_s.PasswordChar = '\0';
            this.textbox_wmaternal_s.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_wmaternal_s.SelectedText = "";
            this.textbox_wmaternal_s.SelectionLength = 0;
            this.textbox_wmaternal_s.SelectionStart = 0;
            this.textbox_wmaternal_s.ShortcutsEnabled = true;
            this.textbox_wmaternal_s.Size = new System.Drawing.Size(120, 23);
            this.textbox_wmaternal_s.TabIndex = 19;
            this.textbox_wmaternal_s.UseSelectable = true;
            this.textbox_wmaternal_s.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_wmaternal_s.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            this.btn_search.Location = new System.Drawing.Point(501, 191);
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
            this.btn_clean_s.Location = new System.Drawing.Point(583, 191);
            this.btn_clean_s.Name = "btn_clean_s";
            this.btn_clean_s.Size = new System.Drawing.Size(75, 23);
            this.btn_clean_s.TabIndex = 12;
            this.btn_clean_s.Text = "Limpiar";
            this.btn_clean_s.UseCustomBackColor = true;
            this.btn_clean_s.UseCustomForeColor = true;
            this.btn_clean_s.UseSelectable = true;
            this.btn_clean_s.Click += new System.EventHandler(this.btn_clean_s_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(19, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(57, 25);
            this.metroLabel11.TabIndex = 30;
            this.metroLabel11.Text = "Ratio";
            this.metroLabel11.UseCustomBackColor = true;
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_export.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            this.btn_export.Location = new System.Drawing.Point(6, 191);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 23);
            this.btn_export.TabIndex = 25;
            this.btn_export.Text = "Exportar";
            this.btn_export.UseCustomBackColor = true;
            this.btn_export.UseCustomForeColor = true;
            this.btn_export.UseSelectable = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_import
            // 
            this.btn_import.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_import.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            this.btn_import.Location = new System.Drawing.Point(87, 191);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(75, 23);
            this.btn_import.TabIndex = 26;
            this.btn_import.Text = "Importar";
            this.btn_import.UseCustomBackColor = true;
            this.btn_import.UseCustomForeColor = true;
            this.btn_import.UseSelectable = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // UC_Ratio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "UC_Ratio";
            this.Size = new System.Drawing.Size(826, 598);
            this.UseCustomBackColor = true;
            this.Load += new System.EventHandler(this.UC_Ratio_Load);
            this.VisibleChanged += new System.EventHandler(this.UC_Ratio_VisibleChanged);
            this.ParentChanged += new System.EventHandler(this.UC_Ratio_ParentChanged);
            this.metroTabControl1.ResumeLayout(false);
            this.consulta.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage consulta;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroComboBox combobox_ratio_type_s;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroComboBox combobox_product_s;
        private MetroFramework.Controls.MetroComboBox combobox_workstation_s;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroTextBox textbox_wname_s;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox textbox_wpaternal_s;
        private MetroFramework.Controls.MetroTextBox textbox_wmaternal_s;
        private MetroFramework.Controls.MetroButton btn_search;
        private MetroFramework.Controls.MetroButton btn_clean_s;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroButton btn_import;
        private MetroFramework.Controls.MetroButton btn_export;
    }
}
