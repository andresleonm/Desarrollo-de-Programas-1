namespace WindowsFormsApp1.Views
{
    partial class UC_User
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabIndex = new System.Windows.Forms.TabPage();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btn_new = new MetroFramework.Controls.MetroButton();
            this.combobox_profile = new MetroFramework.Controls.MetroComboBox();
            this.textbox_password = new MetroFramework.Controls.MetroTextBox();
            this.textbox_username = new MetroFramework.Controls.MetroTextBox();
            this.textbox_address = new MetroFramework.Controls.MetroTextBox();
            this.textbox_email = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.radioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.radioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.textbox_phone = new MetroFramework.Controls.MetroTextBox();
            this.textbox_maternal = new MetroFramework.Controls.MetroTextBox();
            this.textbox_paternal = new MetroFramework.Controls.MetroTextBox();
            this.textbox_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonEliminar = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.tabIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.tabRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.tabIndex);
            this.metroTabControl1.Controls.Add(this.tabRegister);
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.metroTabControl1.HotTrack = true;
            this.metroTabControl1.Location = new System.Drawing.Point(40, 98);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(952, 348);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTabControl1.TabIndex = 25;
            this.metroTabControl1.UseCustomBackColor = true;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabIndex
            // 
            this.tabIndex.BackColor = System.Drawing.SystemColors.Window;
            this.tabIndex.Controls.Add(this.metroGrid1);
            this.tabIndex.Location = new System.Drawing.Point(4, 41);
            this.tabIndex.Name = "tabIndex";
            this.tabIndex.Size = new System.Drawing.Size(944, 303);
            this.tabIndex.TabIndex = 0;
            this.tabIndex.Text = "Consulta    ";
            this.tabIndex.Enter += new System.EventHandler(this.tabIndex_Enter);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column9,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(27, 98);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(896, 187);
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido Pat.";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellido Mat.";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Usuario";
            this.Column4.Name = "Column4";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Perfil";
            this.Column9.Name = "Column9";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Teléfono";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Dirección";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Sexo";
            this.Column8.Name = "Column8";
            // 
            // tabRegister
            // 
            this.tabRegister.BackColor = System.Drawing.SystemColors.Window;
            this.tabRegister.Controls.Add(this.metroButton1);
            this.tabRegister.Controls.Add(this.btn_new);
            this.tabRegister.Controls.Add(this.combobox_profile);
            this.tabRegister.Controls.Add(this.textbox_password);
            this.tabRegister.Controls.Add(this.textbox_username);
            this.tabRegister.Controls.Add(this.textbox_address);
            this.tabRegister.Controls.Add(this.textbox_email);
            this.tabRegister.Controls.Add(this.metroLabel11);
            this.tabRegister.Controls.Add(this.metroLabel10);
            this.tabRegister.Controls.Add(this.metroLabel9);
            this.tabRegister.Controls.Add(this.metroLabel8);
            this.tabRegister.Controls.Add(this.metroLabel4);
            this.tabRegister.Controls.Add(this.radioButton2);
            this.tabRegister.Controls.Add(this.radioButton1);
            this.tabRegister.Controls.Add(this.textbox_phone);
            this.tabRegister.Controls.Add(this.textbox_maternal);
            this.tabRegister.Controls.Add(this.textbox_paternal);
            this.tabRegister.Controls.Add(this.textbox_name);
            this.tabRegister.Controls.Add(this.metroLabel7);
            this.tabRegister.Controls.Add(this.metroLabel6);
            this.tabRegister.Controls.Add(this.metroLabel5);
            this.tabRegister.Controls.Add(this.metroLabel3);
            this.tabRegister.Controls.Add(this.metroLabel2);
            this.tabRegister.Location = new System.Drawing.Point(4, 41);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Size = new System.Drawing.Size(944, 303);
            this.tabRegister.TabIndex = 1;
            this.tabRegister.Text = "Registro    ";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DarkCyan;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(502, 251);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(103, 23);
            this.metroButton1.TabIndex = 23;
            this.metroButton1.Text = "Cancelar";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(340, 251);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(103, 23);
            this.btn_new.TabIndex = 22;
            this.btn_new.Text = "Guardar";
            this.btn_new.UseCustomBackColor = true;
            this.btn_new.UseCustomForeColor = true;
            this.btn_new.UseSelectable = true;
            this.btn_new.UseStyleColors = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // combobox_profile
            // 
            this.combobox_profile.FormattingEnabled = true;
            this.combobox_profile.ItemHeight = 23;
            this.combobox_profile.Location = new System.Drawing.Point(598, 185);
            this.combobox_profile.Name = "combobox_profile";
            this.combobox_profile.Size = new System.Drawing.Size(276, 29);
            this.combobox_profile.TabIndex = 21;
            this.combobox_profile.UseSelectable = true;
            // 
            // textbox_password
            // 
            // 
            // 
            // 
            this.textbox_password.CustomButton.Image = null;
            this.textbox_password.CustomButton.Location = new System.Drawing.Point(249, 2);
            this.textbox_password.CustomButton.Name = "";
            this.textbox_password.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.textbox_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_password.CustomButton.TabIndex = 1;
            this.textbox_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_password.CustomButton.UseSelectable = true;
            this.textbox_password.CustomButton.Visible = false;
            this.textbox_password.Lines = new string[0];
            this.textbox_password.Location = new System.Drawing.Point(598, 149);
            this.textbox_password.MaxLength = 32767;
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.PasswordChar = '*';
            this.textbox_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_password.SelectedText = "";
            this.textbox_password.SelectionLength = 0;
            this.textbox_password.SelectionStart = 0;
            this.textbox_password.ShortcutsEnabled = true;
            this.textbox_password.Size = new System.Drawing.Size(277, 30);
            this.textbox_password.TabIndex = 20;
            this.textbox_password.UseSelectable = true;
            this.textbox_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textbox_username
            // 
            // 
            // 
            // 
            this.textbox_username.CustomButton.Image = null;
            this.textbox_username.CustomButton.Location = new System.Drawing.Point(249, 2);
            this.textbox_username.CustomButton.Name = "";
            this.textbox_username.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.textbox_username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_username.CustomButton.TabIndex = 1;
            this.textbox_username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_username.CustomButton.UseSelectable = true;
            this.textbox_username.CustomButton.Visible = false;
            this.textbox_username.Lines = new string[0];
            this.textbox_username.Location = new System.Drawing.Point(598, 113);
            this.textbox_username.MaxLength = 32767;
            this.textbox_username.Name = "textbox_username";
            this.textbox_username.PasswordChar = '\0';
            this.textbox_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_username.SelectedText = "";
            this.textbox_username.SelectionLength = 0;
            this.textbox_username.SelectionStart = 0;
            this.textbox_username.ShortcutsEnabled = true;
            this.textbox_username.Size = new System.Drawing.Size(277, 30);
            this.textbox_username.TabIndex = 19;
            this.textbox_username.UseSelectable = true;
            this.textbox_username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textbox_address
            // 
            // 
            // 
            // 
            this.textbox_address.CustomButton.Image = null;
            this.textbox_address.CustomButton.Location = new System.Drawing.Point(249, 2);
            this.textbox_address.CustomButton.Name = "";
            this.textbox_address.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.textbox_address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_address.CustomButton.TabIndex = 1;
            this.textbox_address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_address.CustomButton.UseSelectable = true;
            this.textbox_address.CustomButton.Visible = false;
            this.textbox_address.Lines = new string[0];
            this.textbox_address.Location = new System.Drawing.Point(598, 76);
            this.textbox_address.MaxLength = 32767;
            this.textbox_address.Name = "textbox_address";
            this.textbox_address.PasswordChar = '\0';
            this.textbox_address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_address.SelectedText = "";
            this.textbox_address.SelectionLength = 0;
            this.textbox_address.SelectionStart = 0;
            this.textbox_address.ShortcutsEnabled = true;
            this.textbox_address.Size = new System.Drawing.Size(277, 30);
            this.textbox_address.TabIndex = 18;
            this.textbox_address.UseSelectable = true;
            this.textbox_address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textbox_email
            // 
            // 
            // 
            // 
            this.textbox_email.CustomButton.Image = null;
            this.textbox_email.CustomButton.Location = new System.Drawing.Point(249, 2);
            this.textbox_email.CustomButton.Name = "";
            this.textbox_email.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.textbox_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_email.CustomButton.TabIndex = 1;
            this.textbox_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_email.CustomButton.UseSelectable = true;
            this.textbox_email.CustomButton.Visible = false;
            this.textbox_email.Lines = new string[0];
            this.textbox_email.Location = new System.Drawing.Point(598, 40);
            this.textbox_email.MaxLength = 32767;
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.PasswordChar = '\0';
            this.textbox_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_email.SelectedText = "";
            this.textbox_email.SelectionLength = 0;
            this.textbox_email.SelectionStart = 0;
            this.textbox_email.ShortcutsEnabled = true;
            this.textbox_email.Size = new System.Drawing.Size(277, 30);
            this.textbox_email.TabIndex = 17;
            this.textbox_email.UseSelectable = true;
            this.textbox_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(502, 193);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(42, 19);
            this.metroLabel11.TabIndex = 16;
            this.metroLabel11.Text = "Perfil:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(502, 152);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(78, 19);
            this.metroLabel10.TabIndex = 15;
            this.metroLabel10.Text = "Contraseña:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(502, 118);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(56, 19);
            this.metroLabel9.TabIndex = 14;
            this.metroLabel9.Text = "Usuario:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(502, 80);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(66, 19);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = "Dirección:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(502, 44);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Email:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(259, 156);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(29, 15);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "F";
            this.radioButton2.UseSelectable = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(170, 156);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(34, 15);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.Text = "M";
            this.radioButton1.UseSelectable = true;
            // 
            // textbox_phone
            // 
            // 
            // 
            // 
            this.textbox_phone.CustomButton.Image = null;
            this.textbox_phone.CustomButton.Location = new System.Drawing.Point(249, 1);
            this.textbox_phone.CustomButton.Name = "";
            this.textbox_phone.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textbox_phone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_phone.CustomButton.TabIndex = 1;
            this.textbox_phone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_phone.CustomButton.UseSelectable = true;
            this.textbox_phone.CustomButton.Visible = false;
            this.textbox_phone.Lines = new string[0];
            this.textbox_phone.Location = new System.Drawing.Point(170, 183);
            this.textbox_phone.MaxLength = 32767;
            this.textbox_phone.Name = "textbox_phone";
            this.textbox_phone.PasswordChar = '\0';
            this.textbox_phone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_phone.SelectedText = "";
            this.textbox_phone.SelectionLength = 0;
            this.textbox_phone.SelectionStart = 0;
            this.textbox_phone.ShortcutsEnabled = true;
            this.textbox_phone.Size = new System.Drawing.Size(277, 29);
            this.textbox_phone.TabIndex = 9;
            this.textbox_phone.UseSelectable = true;
            this.textbox_phone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_phone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textbox_maternal
            // 
            // 
            // 
            // 
            this.textbox_maternal.CustomButton.Image = null;
            this.textbox_maternal.CustomButton.Location = new System.Drawing.Point(249, 2);
            this.textbox_maternal.CustomButton.Name = "";
            this.textbox_maternal.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.textbox_maternal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_maternal.CustomButton.TabIndex = 1;
            this.textbox_maternal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_maternal.CustomButton.UseSelectable = true;
            this.textbox_maternal.CustomButton.Visible = false;
            this.textbox_maternal.Lines = new string[0];
            this.textbox_maternal.Location = new System.Drawing.Point(170, 113);
            this.textbox_maternal.MaxLength = 32767;
            this.textbox_maternal.Name = "textbox_maternal";
            this.textbox_maternal.PasswordChar = '\0';
            this.textbox_maternal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_maternal.SelectedText = "";
            this.textbox_maternal.SelectionLength = 0;
            this.textbox_maternal.SelectionStart = 0;
            this.textbox_maternal.ShortcutsEnabled = true;
            this.textbox_maternal.Size = new System.Drawing.Size(277, 30);
            this.textbox_maternal.TabIndex = 8;
            this.textbox_maternal.UseSelectable = true;
            this.textbox_maternal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_maternal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textbox_paternal
            // 
            // 
            // 
            // 
            this.textbox_paternal.CustomButton.Image = null;
            this.textbox_paternal.CustomButton.Location = new System.Drawing.Point(249, 2);
            this.textbox_paternal.CustomButton.Name = "";
            this.textbox_paternal.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.textbox_paternal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_paternal.CustomButton.TabIndex = 1;
            this.textbox_paternal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_paternal.CustomButton.UseSelectable = true;
            this.textbox_paternal.CustomButton.Visible = false;
            this.textbox_paternal.Lines = new string[0];
            this.textbox_paternal.Location = new System.Drawing.Point(170, 76);
            this.textbox_paternal.MaxLength = 32767;
            this.textbox_paternal.Name = "textbox_paternal";
            this.textbox_paternal.PasswordChar = '\0';
            this.textbox_paternal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_paternal.SelectedText = "";
            this.textbox_paternal.SelectionLength = 0;
            this.textbox_paternal.SelectionStart = 0;
            this.textbox_paternal.ShortcutsEnabled = true;
            this.textbox_paternal.Size = new System.Drawing.Size(277, 30);
            this.textbox_paternal.TabIndex = 7;
            this.textbox_paternal.UseSelectable = true;
            this.textbox_paternal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_paternal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textbox_name
            // 
            // 
            // 
            // 
            this.textbox_name.CustomButton.Image = null;
            this.textbox_name.CustomButton.Location = new System.Drawing.Point(249, 2);
            this.textbox_name.CustomButton.Name = "";
            this.textbox_name.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.textbox_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_name.CustomButton.TabIndex = 1;
            this.textbox_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_name.CustomButton.UseSelectable = true;
            this.textbox_name.CustomButton.Visible = false;
            this.textbox_name.Lines = new string[0];
            this.textbox_name.Location = new System.Drawing.Point(170, 40);
            this.textbox_name.MaxLength = 32767;
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.PasswordChar = '\0';
            this.textbox_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_name.SelectedText = "";
            this.textbox_name.SelectionLength = 0;
            this.textbox_name.SelectionStart = 0;
            this.textbox_name.ShortcutsEnabled = true;
            this.textbox_name.Size = new System.Drawing.Size(277, 30);
            this.textbox_name.TabIndex = 6;
            this.textbox_name.UseSelectable = true;
            this.textbox_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(32, 152);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(40, 19);
            this.metroLabel7.TabIndex = 5;
            this.metroLabel7.Text = "Sexo:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(32, 80);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(111, 19);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "Apellido Paterno:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(32, 193);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(63, 19);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Telefono:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(32, 118);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(115, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Apellido Materno:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 44);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Nombre:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(44, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 25);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Usuarios";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // metroButtonEliminar
            // 
            this.metroButtonEliminar.BackColor = System.Drawing.Color.DarkCyan;
            this.metroButtonEliminar.ForeColor = System.Drawing.Color.White;
            this.metroButtonEliminar.Location = new System.Drawing.Point(864, 471);
            this.metroButtonEliminar.Name = "metroButtonEliminar";
            this.metroButtonEliminar.Size = new System.Drawing.Size(103, 23);
            this.metroButtonEliminar.TabIndex = 27;
            this.metroButtonEliminar.Text = "Eliminar";
            this.metroButtonEliminar.UseCustomBackColor = true;
            this.metroButtonEliminar.UseCustomForeColor = true;
            this.metroButtonEliminar.UseSelectable = true;
            this.metroButtonEliminar.UseStyleColors = true;
            this.metroButtonEliminar.Click += new System.EventHandler(this.metroButtonEliminar_Click);
            // 
            // UC_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.metroButtonEliminar);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "UC_User";
            this.Size = new System.Drawing.Size(1479, 671);
            this.UseCustomBackColor = true;
            this.VisibleChanged += new System.EventHandler(this.UC_User_VisibleChanged);
            this.Leave += new System.EventHandler(this.UC_User_Leave);
            this.ParentChanged += new System.EventHandler(this.UC_User_ParentChanged);
            this.metroTabControl1.ResumeLayout(false);
            this.tabIndex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabIndex;
        private System.Windows.Forms.TabPage tabRegister;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textbox_phone;
        private MetroFramework.Controls.MetroTextBox textbox_maternal;
        private MetroFramework.Controls.MetroTextBox textbox_paternal;
        private MetroFramework.Controls.MetroTextBox textbox_name;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox combobox_profile;
        private MetroFramework.Controls.MetroTextBox textbox_password;
        private MetroFramework.Controls.MetroTextBox textbox_username;
        private MetroFramework.Controls.MetroTextBox textbox_address;
        private MetroFramework.Controls.MetroTextBox textbox_email;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroRadioButton radioButton2;
        private MetroFramework.Controls.MetroRadioButton radioButton1;
        private MetroFramework.Controls.MetroButton btn_new;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private MetroFramework.Controls.MetroButton metroButtonEliminar;
    }
}
