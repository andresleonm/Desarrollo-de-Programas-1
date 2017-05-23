namespace WindowsFormsApp1.Views
{
    partial class Worker
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.worker_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worker_doi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worker_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worker_last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worker_shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textbox_maternal_s = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.textbox_dni_s = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.textbox_paternal_s = new System.Windows.Forms.TextBox();
            this.textbox_name_s = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textbox_email = new System.Windows.Forms.TextBox();
            this.textbox_address = new System.Windows.Forms.TextBox();
            this.combobox_shift = new System.Windows.Forms.ComboBox();
            this.textbox_cellphone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datetimepicker_birthday = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_dni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_maternal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_paternal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(416, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(575, 422);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado de Trabajadores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.worker_id,
            this.worker_doi,
            this.worker_name,
            this.worker_last_name,
            this.worker_shift});
            this.dataGridView1.Location = new System.Drawing.Point(6, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 260);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // worker_id
            // 
            this.worker_id.HeaderText = "ID";
            this.worker_id.Name = "worker_id";
            // 
            // worker_doi
            // 
            this.worker_doi.HeaderText = "DOI";
            this.worker_doi.Name = "worker_doi";
            // 
            // worker_name
            // 
            this.worker_name.HeaderText = "Nombre";
            this.worker_name.Name = "worker_name";
            // 
            // worker_last_name
            // 
            this.worker_last_name.HeaderText = "Apellido";
            this.worker_last_name.Name = "worker_last_name";
            // 
            // worker_shift
            // 
            this.worker_shift.HeaderText = "Turno";
            this.worker_shift.Name = "worker_shift";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textbox_maternal_s);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.btn_search);
            this.groupBox5.Controls.Add(this.textbox_dni_s);
            this.groupBox5.Controls.Add(this.btn_delete);
            this.groupBox5.Controls.Add(this.textbox_paternal_s);
            this.groupBox5.Controls.Add(this.textbox_name_s);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(551, 117);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos";
            // 
            // textbox_maternal_s
            // 
            this.textbox_maternal_s.Location = new System.Drawing.Point(336, 16);
            this.textbox_maternal_s.Name = "textbox_maternal_s";
            this.textbox_maternal_s.Size = new System.Drawing.Size(100, 20);
            this.textbox_maternal_s.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(241, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Apellido Materno:";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(373, 86);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(83, 25);
            this.btn_search.TabIndex = 24;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // textbox_dni_s
            // 
            this.textbox_dni_s.Location = new System.Drawing.Point(336, 42);
            this.textbox_dni_s.Name = "textbox_dni_s";
            this.textbox_dni_s.Size = new System.Drawing.Size(100, 20);
            this.textbox_dni_s.TabIndex = 5;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_delete.Enabled = false;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(462, 86);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(83, 25);
            this.btn_delete.TabIndex = 23;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // textbox_paternal_s
            // 
            this.textbox_paternal_s.Location = new System.Drawing.Point(101, 45);
            this.textbox_paternal_s.Name = "textbox_paternal_s";
            this.textbox_paternal_s.Size = new System.Drawing.Size(100, 20);
            this.textbox_paternal_s.TabIndex = 4;
            // 
            // textbox_name_s
            // 
            this.textbox_name_s.Location = new System.Drawing.Point(101, 19);
            this.textbox_name_s.Name = "textbox_name_s";
            this.textbox_name_s.Size = new System.Drawing.Size(100, 20);
            this.textbox_name_s.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(241, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "DNI:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Apellido Paternal:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Nombre:";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(202, 409);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(83, 25);
            this.btn_edit.TabIndex = 32;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.textbox_email);
            this.groupBox1.Controls.Add(this.textbox_address);
            this.groupBox1.Controls.Add(this.combobox_shift);
            this.groupBox1.Controls.Add(this.textbox_cellphone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.datetimepicker_birthday);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textbox_dni);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textbox_phone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textbox_maternal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textbox_paternal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textbox_name);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 375);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Trabajador";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(169, 146);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "F";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(129, 146);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(34, 17);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "M";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textbox_email
            // 
            this.textbox_email.Location = new System.Drawing.Point(129, 245);
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(155, 20);
            this.textbox_email.TabIndex = 5;
            // 
            // textbox_address
            // 
            this.textbox_address.Location = new System.Drawing.Point(129, 168);
            this.textbox_address.Name = "textbox_address";
            this.textbox_address.Size = new System.Drawing.Size(155, 20);
            this.textbox_address.TabIndex = 12;
            // 
            // combobox_shift
            // 
            this.combobox_shift.FormattingEnabled = true;
            this.combobox_shift.Location = new System.Drawing.Point(129, 273);
            this.combobox_shift.Name = "combobox_shift";
            this.combobox_shift.Size = new System.Drawing.Size(155, 21);
            this.combobox_shift.TabIndex = 5;
            // 
            // textbox_cellphone
            // 
            this.textbox_cellphone.Location = new System.Drawing.Point(129, 219);
            this.textbox_cellphone.Name = "textbox_cellphone";
            this.textbox_cellphone.Size = new System.Drawing.Size(155, 20);
            this.textbox_cellphone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(10, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Turno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido Paterno:";
            // 
            // datetimepicker_birthday
            // 
            this.datetimepicker_birthday.Location = new System.Drawing.Point(129, 118);
            this.datetimepicker_birthday.Name = "datetimepicker_birthday";
            this.datetimepicker_birthday.Size = new System.Drawing.Size(214, 20);
            this.datetimepicker_birthday.TabIndex = 10;
            this.datetimepicker_birthday.Value = new System.DateTime(2017, 5, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellido Materno:";
            // 
            // textbox_dni
            // 
            this.textbox_dni.Location = new System.Drawing.Point(129, 93);
            this.textbox_dni.Name = "textbox_dni";
            this.textbox_dni.Size = new System.Drawing.Size(155, 20);
            this.textbox_dni.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha de Nacimiento:";
            // 
            // textbox_phone
            // 
            this.textbox_phone.Location = new System.Drawing.Point(129, 194);
            this.textbox_phone.Name = "textbox_phone";
            this.textbox_phone.Size = new System.Drawing.Size(155, 20);
            this.textbox_phone.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sexo:";
            // 
            // textbox_maternal
            // 
            this.textbox_maternal.Location = new System.Drawing.Point(129, 68);
            this.textbox_maternal.Name = "textbox_maternal";
            this.textbox_maternal.Size = new System.Drawing.Size(155, 20);
            this.textbox_maternal.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Teléfono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Correo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "DNI:";
            // 
            // textbox_paternal
            // 
            this.textbox_paternal.Location = new System.Drawing.Point(129, 43);
            this.textbox_paternal.Name = "textbox_paternal";
            this.textbox_paternal.Size = new System.Drawing.Size(155, 20);
            this.textbox_paternal.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dirección:";
            // 
            // textbox_name
            // 
            this.textbox_name.Location = new System.Drawing.Point(129, 18);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(155, 20);
            this.textbox_name.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Celular:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(291, 409);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(83, 25);
            this.btn_cancel.TabIndex = 31;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(113, 409);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(83, 25);
            this.btn_new.TabIndex = 30;
            this.btn_new.Text = "Nuevo";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_new);
            this.Name = "Worker";
            this.Size = new System.Drawing.Size(999, 443);
            this.Load += new System.EventHandler(this.Worker_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn worker_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn worker_doi;
        private System.Windows.Forms.DataGridViewTextBoxColumn worker_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn worker_last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn worker_shift;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textbox_maternal_s;
        private System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textbox_dni_s;
        internal System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox textbox_paternal_s;
        private System.Windows.Forms.TextBox textbox_name_s;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textbox_email;
        private System.Windows.Forms.TextBox textbox_address;
        private System.Windows.Forms.ComboBox combobox_shift;
        private System.Windows.Forms.TextBox textbox_cellphone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datetimepicker_birthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_dni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbox_phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_maternal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textbox_paternal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Button btn_cancel;
        internal System.Windows.Forms.Button btn_new;
    }
}
