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
            this.btm_edit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_paternal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_maternal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_profile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textbox_username_s = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.combobox_profile_s = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textbox_maternal_s = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textbox_paternal_s = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textbox_name_s = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textbox_username = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.combobox_profile = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.textbox_email = new System.Windows.Forms.TextBox();
            this.textbox_phone = new System.Windows.Forms.TextBox();
            this.textbox_maternal = new System.Windows.Forms.TextBox();
            this.textbox_paternal = new System.Windows.Forms.TextBox();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textbox_address = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btm_edit
            // 
            this.btm_edit.BackColor = System.Drawing.Color.SteelBlue;
            this.btm_edit.ForeColor = System.Drawing.Color.White;
            this.btm_edit.Location = new System.Drawing.Point(155, 369);
            this.btm_edit.Name = "btm_edit";
            this.btm_edit.Size = new System.Drawing.Size(83, 25);
            this.btm_edit.TabIndex = 24;
            this.btm_edit.Text = "Editar";
            this.btm_edit.UseVisualStyleBackColor = false;
            this.btm_edit.Click += new System.EventHandler(this.btm_edit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(334, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(671, 393);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(663, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado de Usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.user_name,
            this.user_paternal,
            this.user_maternal,
            this.user_username,
            this.user_profile});
            this.dataGridView1.Location = new System.Drawing.Point(6, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 174);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // user_id
            // 
            this.user_id.HeaderText = "ID";
            this.user_id.Name = "user_id";
            // 
            // user_name
            // 
            this.user_name.HeaderText = "Nombre";
            this.user_name.Name = "user_name";
            // 
            // user_paternal
            // 
            this.user_paternal.HeaderText = "Apellido Paterno";
            this.user_paternal.Name = "user_paternal";
            // 
            // user_maternal
            // 
            this.user_maternal.HeaderText = "Apellido Materno";
            this.user_maternal.Name = "user_maternal";
            // 
            // user_username
            // 
            this.user_username.HeaderText = "Usuario";
            this.user_username.Name = "user_username";
            // 
            // user_profile
            // 
            this.user_profile.HeaderText = "Perfil";
            this.user_profile.Name = "user_profile";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textbox_username_s);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.combobox_profile_s);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textbox_maternal_s);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_search);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textbox_paternal_s);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textbox_name_s);
            this.groupBox3.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(647, 167);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos";
            // 
            // textbox_username_s
            // 
            this.textbox_username_s.Location = new System.Drawing.Point(273, 14);
            this.textbox_username_s.Name = "textbox_username_s";
            this.textbox_username_s.Size = new System.Drawing.Size(100, 20);
            this.textbox_username_s.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(221, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Usuario:";
            // 
            // combobox_profile_s
            // 
            this.combobox_profile_s.FormattingEnabled = true;
            this.combobox_profile_s.Location = new System.Drawing.Point(273, 44);
            this.combobox_profile_s.Name = "combobox_profile_s";
            this.combobox_profile_s.Size = new System.Drawing.Size(100, 21);
            this.combobox_profile_s.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(221, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Perfil:";
            // 
            // textbox_maternal_s
            // 
            this.textbox_maternal_s.Location = new System.Drawing.Point(99, 71);
            this.textbox_maternal_s.Name = "textbox_maternal_s";
            this.textbox_maternal_s.Size = new System.Drawing.Size(100, 20);
            this.textbox_maternal_s.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Apellido Materno:";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_delete.Enabled = false;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(558, 135);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(83, 25);
            this.btn_delete.TabIndex = 20;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(469, 135);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(83, 25);
            this.btn_search.TabIndex = 19;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Apellido Paterno:";
            // 
            // textbox_paternal_s
            // 
            this.textbox_paternal_s.Location = new System.Drawing.Point(99, 45);
            this.textbox_paternal_s.Name = "textbox_paternal_s";
            this.textbox_paternal_s.Size = new System.Drawing.Size(100, 20);
            this.textbox_paternal_s.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nombre:";
            // 
            // textbox_name_s
            // 
            this.textbox_name_s.Location = new System.Drawing.Point(99, 14);
            this.textbox_name_s.Name = "textbox_name_s";
            this.textbox_name_s.Size = new System.Drawing.Size(100, 20);
            this.textbox_name_s.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(244, 369);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(83, 25);
            this.btn_cancel.TabIndex = 23;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(66, 369);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(83, 25);
            this.btn_new.TabIndex = 22;
            this.btn_new.Text = "Nuevo";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textbox_address);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textbox_username);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.combobox_profile);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textbox_password);
            this.groupBox1.Controls.Add(this.textbox_email);
            this.groupBox1.Controls.Add(this.textbox_phone);
            this.groupBox1.Controls.Add(this.textbox_maternal);
            this.groupBox1.Controls.Add(this.textbox_paternal);
            this.groupBox1.Controls.Add(this.textbox_name);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(5, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 325);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Usuario";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Usuario:";
            // 
            // textbox_username
            // 
            this.textbox_username.Location = new System.Drawing.Point(110, 232);
            this.textbox_username.Name = "textbox_username";
            this.textbox_username.Size = new System.Drawing.Size(100, 20);
            this.textbox_username.TabIndex = 20;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(150, 115);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "F";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(110, 115);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(34, 17);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "M";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // combobox_profile
            // 
            this.combobox_profile.FormattingEnabled = true;
            this.combobox_profile.Location = new System.Drawing.Point(110, 285);
            this.combobox_profile.Name = "combobox_profile";
            this.combobox_profile.Size = new System.Drawing.Size(100, 21);
            this.combobox_profile.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Perfil:";
            // 
            // textbox_password
            // 
            this.textbox_password.Location = new System.Drawing.Point(110, 258);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.PasswordChar = '*';
            this.textbox_password.Size = new System.Drawing.Size(100, 20);
            this.textbox_password.TabIndex = 15;
            // 
            // textbox_email
            // 
            this.textbox_email.Location = new System.Drawing.Point(110, 175);
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(100, 20);
            this.textbox_email.TabIndex = 14;
            // 
            // textbox_phone
            // 
            this.textbox_phone.Location = new System.Drawing.Point(110, 145);
            this.textbox_phone.Name = "textbox_phone";
            this.textbox_phone.Size = new System.Drawing.Size(100, 20);
            this.textbox_phone.TabIndex = 12;
            // 
            // textbox_maternal
            // 
            this.textbox_maternal.Location = new System.Drawing.Point(110, 85);
            this.textbox_maternal.Name = "textbox_maternal";
            this.textbox_maternal.Size = new System.Drawing.Size(100, 20);
            this.textbox_maternal.TabIndex = 11;
            // 
            // textbox_paternal
            // 
            this.textbox_paternal.Location = new System.Drawing.Point(110, 55);
            this.textbox_paternal.Name = "textbox_paternal";
            this.textbox_paternal.Size = new System.Drawing.Size(100, 20);
            this.textbox_paternal.TabIndex = 10;
            // 
            // textbox_name
            // 
            this.textbox_name.Location = new System.Drawing.Point(110, 22);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(100, 20);
            this.textbox_name.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Materno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido Paterno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Direccion:";
            // 
            // textbox_address
            // 
            this.textbox_address.Location = new System.Drawing.Point(110, 206);
            this.textbox_address.Name = "textbox_address";
            this.textbox_address.Size = new System.Drawing.Size(100, 20);
            this.textbox_address.TabIndex = 23;
            // 
            // UC_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btm_edit);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_User";
            this.Size = new System.Drawing.Size(1033, 428);
            this.Load += new System.EventHandler(this.User_Load);
            this.Leave += new System.EventHandler(this.UC_User_Leave);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btm_edit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox combobox_profile_s;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textbox_maternal_s;
        private System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Button btn_delete;
        internal System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textbox_paternal_s;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textbox_name_s;
        internal System.Windows.Forms.Button btn_cancel;
        internal System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox combobox_profile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.TextBox textbox_email;
        private System.Windows.Forms.TextBox textbox_phone;
        private System.Windows.Forms.TextBox textbox_maternal;
        private System.Windows.Forms.TextBox textbox_paternal;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textbox_username;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textbox_username_s;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_paternal;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_maternal;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_profile;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textbox_address;
    }
}
