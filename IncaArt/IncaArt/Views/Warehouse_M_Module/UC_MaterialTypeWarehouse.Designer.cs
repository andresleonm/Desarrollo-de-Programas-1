namespace WindowsFormsApp1.Views.Warehouse_M_Module
{
    partial class UC_MaterialTypeWarehouse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edit = new MetroFramework.Controls.MetroButton();
            this.register = new MetroFramework.Controls.MetroButton();
            this.combobox_class = new MetroFramework.Controls.MetroComboBox();
            this.textbox_name = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_clean = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combobox_type_s = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroButton1);
            this.metroTabPage2.Controls.Add(this.label2);
            this.metroTabPage2.Controls.Add(this.label1);
            this.metroTabPage2.Controls.Add(this.edit);
            this.metroTabPage2.Controls.Add(this.register);
            this.metroTabPage2.Controls.Add(this.combobox_class);
            this.metroTabPage2.Controls.Add(this.textbox_name);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(495, 671);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "  Registro  ";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DarkCyan;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(350, 161);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(98, 27);
            this.metroButton1.TabIndex = 76;
            this.metroButton1.Text = "Cancelar";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(79, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Clase :";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(79, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Nombre :";
            this.label1.UseWaitCursor = true;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.DarkCyan;
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(213, 161);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(98, 27);
            this.edit.TabIndex = 73;
            this.edit.Text = "Editar";
            this.edit.UseCustomBackColor = true;
            this.edit.UseCustomForeColor = true;
            this.edit.UseSelectable = true;
            this.edit.UseStyleColors = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.DarkCyan;
            this.register.ForeColor = System.Drawing.Color.White;
            this.register.Location = new System.Drawing.Point(78, 161);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(98, 27);
            this.register.TabIndex = 71;
            this.register.Text = "Registro";
            this.register.UseCustomBackColor = true;
            this.register.UseCustomForeColor = true;
            this.register.UseSelectable = true;
            this.register.UseStyleColors = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // combobox_class
            // 
            this.combobox_class.FormattingEnabled = true;
            this.combobox_class.ItemHeight = 23;
            this.combobox_class.Items.AddRange(new object[] {
            "Producción",
            "Observación"});
            this.combobox_class.Location = new System.Drawing.Point(191, 77);
            this.combobox_class.Name = "combobox_class";
            this.combobox_class.Size = new System.Drawing.Size(197, 29);
            this.combobox_class.TabIndex = 24;
            this.combobox_class.UseSelectable = true;
            // 
            // textbox_name
            // 
            // 
            // 
            // 
            this.textbox_name.CustomButton.Image = null;
            this.textbox_name.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.textbox_name.CustomButton.Name = "";
            this.textbox_name.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.textbox_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_name.CustomButton.TabIndex = 1;
            this.textbox_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_name.CustomButton.UseSelectable = true;
            this.textbox_name.CustomButton.Visible = false;
            this.textbox_name.Lines = new string[0];
            this.textbox_name.Location = new System.Drawing.Point(191, 33);
            this.textbox_name.MaxLength = 32767;
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.PasswordChar = '\0';
            this.textbox_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_name.SelectedText = "";
            this.textbox_name.SelectionLength = 0;
            this.textbox_name.SelectionStart = 0;
            this.textbox_name.ShortcutsEnabled = true;
            this.textbox_name.Size = new System.Drawing.Size(197, 27);
            this.textbox_name.TabIndex = 28;
            this.textbox_name.UseSelectable = true;
            this.textbox_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.groupBox2);
            this.metroTabPage1.Controls.Add(this.groupBox1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(495, 671);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "  Consultar  ";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btn_clean);
            this.groupBox2.Controls.Add(this.search);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.combobox_type_s);
            this.groupBox2.Controls.Add(this.metroComboBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(0, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 172);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            this.groupBox2.UseWaitCursor = true;
            // 
            // btn_clean
            // 
            this.btn_clean.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clean.ForeColor = System.Drawing.Color.White;
            this.btn_clean.Location = new System.Drawing.Point(367, 126);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(85, 29);
            this.btn_clean.TabIndex = 53;
            this.btn_clean.Text = "Limpiar";
            this.btn_clean.UseVisualStyleBackColor = false;
            this.btn_clean.UseWaitCursor = true;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.DarkCyan;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(249, 126);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(85, 29);
            this.search.TabIndex = 50;
            this.search.Text = "Buscar";
            this.search.UseVisualStyleBackColor = false;
            this.search.UseWaitCursor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkCyan;
            this.label13.Location = new System.Drawing.Point(29, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Clase :";
            this.label13.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(29, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado :";
            this.label3.UseWaitCursor = true;
            // 
            // combobox_type_s
            // 
            this.combobox_type_s.FormattingEnabled = true;
            this.combobox_type_s.ItemHeight = 23;
            this.combobox_type_s.Location = new System.Drawing.Point(112, 24);
            this.combobox_type_s.Name = "combobox_type_s";
            this.combobox_type_s.Size = new System.Drawing.Size(227, 29);
            this.combobox_type_s.TabIndex = 22;
            this.combobox_type_s.UseSelectable = true;
            this.combobox_type_s.UseWaitCursor = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(112, 75);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(227, 29);
            this.metroComboBox1.TabIndex = 27;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 370);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Almacenes";
            this.groupBox1.UseWaitCursor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.metroGrid1);
            this.panel4.Location = new System.Drawing.Point(6, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(488, 246);
            this.panel4.TabIndex = 0;
            this.panel4.UseWaitCursor = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(3, 0);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(443, 190);
            this.metroGrid1.TabIndex = 2;
            this.metroGrid1.UseWaitCursor = true;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Clase";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Estado";
            this.Column4.Name = "Column4";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(189, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 29);
            this.button1.TabIndex = 51;
            this.button1.Text = "Eliminar ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(503, 713);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // UC_MaterialTypeWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Name = "UC_MaterialTypeWarehouse";
            this.Size = new System.Drawing.Size(527, 868);
            this.Load += new System.EventHandler(this.UC_MaterialTypeWarehouse_Load);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton edit;
        private MetroFramework.Controls.MetroButton register;
        private MetroFramework.Controls.MetroComboBox combobox_class;
        private MetroFramework.Controls.MetroTextBox textbox_name;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label13;
        private MetroFramework.Controls.MetroComboBox combobox_type_s;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}
