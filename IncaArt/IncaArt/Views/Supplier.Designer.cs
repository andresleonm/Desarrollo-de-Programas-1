﻿namespace WindowsFormsApp1.Views
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_clean = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.combobox_priority_s = new MetroFramework.Controls.MetroComboBox();
            this.doi_s = new MetroFramework.Controls.MetroTextBox();
            this.combobox_type_s = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Almacén = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.Button();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_priority = new MetroFramework.Controls.MetroTextBox();
            this.textbox_email = new MetroFramework.Controls.MetroTextBox();
            this.textbox_phone = new MetroFramework.Controls.MetroTextBox();
            this.textbox_doi = new MetroFramework.Controls.MetroTextBox();
            this.textbox_address = new MetroFramework.Controls.MetroTextBox();
            this.Cancel = new MetroFramework.Controls.MetroButton();
            this.edit = new MetroFramework.Controls.MetroButton();
            this.register = new MetroFramework.Controls.MetroButton();
            this.textbox_type = new MetroFramework.Controls.MetroTextBox();
            this.textbox_name = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(915, 713);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTabControl1.TabIndex = 22;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage2
            // 
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
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btn_clean);
            this.groupBox2.Controls.Add(this.search);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.combobox_priority_s);
            this.groupBox2.Controls.Add(this.doi_s);
            this.groupBox2.Controls.Add(this.combobox_type_s);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(0, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(904, 172);
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
            this.btn_clean.Location = new System.Drawing.Point(742, 119);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(85, 29);
            this.btn_clean.TabIndex = 53;
            this.btn_clean.Text = "Limpiar";
            this.btn_clean.UseVisualStyleBackColor = false;
            this.btn_clean.UseWaitCursor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.DarkCyan;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(624, 119);
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
            this.label13.Location = new System.Drawing.Point(6, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Prioridad :";
            this.label13.UseWaitCursor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkCyan;
            this.label14.Location = new System.Drawing.Point(264, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "DOI :";
            this.label14.UseWaitCursor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkCyan;
            this.label15.Location = new System.Drawing.Point(31, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Tipo :";
            this.label15.UseWaitCursor = true;
            // 
            // combobox_priority_s
            // 
            this.combobox_priority_s.FormattingEnabled = true;
            this.combobox_priority_s.ItemHeight = 23;
            this.combobox_priority_s.Location = new System.Drawing.Point(112, 24);
            this.combobox_priority_s.Name = "combobox_priority_s";
            this.combobox_priority_s.Size = new System.Drawing.Size(105, 29);
            this.combobox_priority_s.TabIndex = 22;
            this.combobox_priority_s.UseSelectable = true;
            this.combobox_priority_s.UseWaitCursor = true;
            // 
            // doi_s
            // 
            // 
            // 
            // 
            this.doi_s.CustomButton.Image = null;
            this.doi_s.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.doi_s.CustomButton.Name = "";
            this.doi_s.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.doi_s.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.doi_s.CustomButton.TabIndex = 1;
            this.doi_s.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.doi_s.CustomButton.UseSelectable = true;
            this.doi_s.CustomButton.UseWaitCursor = true;
            this.doi_s.CustomButton.Visible = false;
            this.doi_s.Lines = new string[0];
            this.doi_s.Location = new System.Drawing.Point(318, 26);
            this.doi_s.MaxLength = 32767;
            this.doi_s.Name = "doi_s";
            this.doi_s.PasswordChar = '\0';
            this.doi_s.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.doi_s.SelectedText = "";
            this.doi_s.SelectionLength = 0;
            this.doi_s.SelectionStart = 0;
            this.doi_s.ShortcutsEnabled = true;
            this.doi_s.Size = new System.Drawing.Size(176, 27);
            this.doi_s.TabIndex = 26;
            this.doi_s.UseSelectable = true;
            this.doi_s.UseWaitCursor = true;
            this.doi_s.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.doi_s.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // combobox_type_s
            // 
            this.combobox_type_s.FormattingEnabled = true;
            this.combobox_type_s.ItemHeight = 23;
            this.combobox_type_s.Location = new System.Drawing.Point(112, 87);
            this.combobox_type_s.Name = "combobox_type_s";
            this.combobox_type_s.Size = new System.Drawing.Size(105, 29);
            this.combobox_type_s.TabIndex = 27;
            this.combobox_type_s.UseSelectable = true;
            this.combobox_type_s.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 315);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedores";
            this.groupBox1.UseWaitCursor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.metroGrid1);
            this.panel4.Location = new System.Drawing.Point(6, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(895, 246);
            this.panel4.TabIndex = 0;
            this.panel4.UseWaitCursor = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToOrderColumns = true;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Almacén,
            this.Column1,
            this.Column6,
            this.Column11,
            this.Tipo,
            this.Column8});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle11;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 0);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(895, 204);
            this.metroGrid1.TabIndex = 28;
            this.metroGrid1.UseCustomBackColor = true;
            this.metroGrid1.UseCustomForeColor = true;
            this.metroGrid1.UseStyleColors = true;
            this.metroGrid1.UseWaitCursor = true;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            this.metroGrid1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellDoubleClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DOI";
            this.Column3.Name = "Column3";
            // 
            // Almacén
            // 
            this.Almacén.HeaderText = "Nombre";
            this.Almacén.Name = "Almacén";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Dirección";
            this.Column1.Name = "Column1";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Teléfono";
            this.Column6.Name = "Column6";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Correo";
            this.Column11.Name = "Column11";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Prioridad";
            this.Column8.Name = "Column8";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DarkCyan;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(409, 280);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(85, 29);
            this.delete.TabIndex = 51;
            this.delete.Text = "Eliminar ";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.UseWaitCursor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage3.Controls.Add(this.label7);
            this.metroTabPage3.Controls.Add(this.label6);
            this.metroTabPage3.Controls.Add(this.label5);
            this.metroTabPage3.Controls.Add(this.label4);
            this.metroTabPage3.Controls.Add(this.label3);
            this.metroTabPage3.Controls.Add(this.label2);
            this.metroTabPage3.Controls.Add(this.label1);
            this.metroTabPage3.Controls.Add(this.textbox_priority);
            this.metroTabPage3.Controls.Add(this.textbox_email);
            this.metroTabPage3.Controls.Add(this.textbox_phone);
            this.metroTabPage3.Controls.Add(this.textbox_doi);
            this.metroTabPage3.Controls.Add(this.textbox_address);
            this.metroTabPage3.Controls.Add(this.Cancel);
            this.metroTabPage3.Controls.Add(this.edit);
            this.metroTabPage3.Controls.Add(this.register);
            this.metroTabPage3.Controls.Add(this.textbox_type);
            this.metroTabPage3.Controls.Add(this.textbox_name);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(244, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "Prioridad :";
            this.label7.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(244, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "Tipo :";
            this.label6.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(244, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "Correo :";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(244, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Teléfono :";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(244, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "DOI :";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(244, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Dirección :";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(244, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Nombre :";
            this.label1.UseWaitCursor = true;
            // 
            // textbox_priority
            // 
            // 
            // 
            // 
            this.textbox_priority.CustomButton.Image = null;
            this.textbox_priority.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.textbox_priority.CustomButton.Name = "";
            this.textbox_priority.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.textbox_priority.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_priority.CustomButton.TabIndex = 1;
            this.textbox_priority.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_priority.CustomButton.UseSelectable = true;
            this.textbox_priority.CustomButton.Visible = false;
            this.textbox_priority.Lines = new string[0];
            this.textbox_priority.Location = new System.Drawing.Point(361, 305);
            this.textbox_priority.MaxLength = 32767;
            this.textbox_priority.Name = "textbox_priority";
            this.textbox_priority.PasswordChar = '\0';
            this.textbox_priority.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_priority.SelectedText = "";
            this.textbox_priority.SelectionLength = 0;
            this.textbox_priority.SelectionStart = 0;
            this.textbox_priority.ShortcutsEnabled = true;
            this.textbox_priority.Size = new System.Drawing.Size(98, 27);
            this.textbox_priority.TabIndex = 80;
            this.textbox_priority.UseSelectable = true;
            this.textbox_priority.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_priority.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.textbox_email.MaxLength = 32767;
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
            this.textbox_phone.MaxLength = 32767;
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
            this.textbox_doi.Location = new System.Drawing.Point(361, 126);
            this.textbox_doi.MaxLength = 32767;
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
            this.textbox_address.Location = new System.Drawing.Point(361, 76);
            this.textbox_address.MaxLength = 32767;
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
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(518, 378);
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
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.DarkCyan;
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(383, 378);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(98, 27);
            this.edit.TabIndex = 67;
            this.edit.Text = "Editar";
            this.edit.UseCustomBackColor = true;
            this.edit.UseCustomForeColor = true;
            this.edit.UseSelectable = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.DarkCyan;
            this.register.ForeColor = System.Drawing.Color.White;
            this.register.Location = new System.Drawing.Point(242, 378);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(98, 27);
            this.register.TabIndex = 66;
            this.register.Text = "Registro";
            this.register.UseCustomBackColor = true;
            this.register.UseCustomForeColor = true;
            this.register.UseSelectable = true;
            this.register.UseStyleColors = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // textbox_type
            // 
            // 
            // 
            // 
            this.textbox_type.CustomButton.Image = null;
            this.textbox_type.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.textbox_type.CustomButton.Name = "";
            this.textbox_type.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.textbox_type.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_type.CustomButton.TabIndex = 1;
            this.textbox_type.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_type.CustomButton.UseSelectable = true;
            this.textbox_type.CustomButton.Visible = false;
            this.textbox_type.Lines = new string[0];
            this.textbox_type.Location = new System.Drawing.Point(361, 262);
            this.textbox_type.MaxLength = 32767;
            this.textbox_type.Name = "textbox_type";
            this.textbox_type.PasswordChar = '\0';
            this.textbox_type.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_type.SelectedText = "";
            this.textbox_type.SelectionLength = 0;
            this.textbox_type.SelectionStart = 0;
            this.textbox_type.ShortcutsEnabled = true;
            this.textbox_type.Size = new System.Drawing.Size(98, 27);
            this.textbox_type.TabIndex = 61;
            this.textbox_type.UseSelectable = true;
            this.textbox_type.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_type.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.textbox_name.MaxLength = 32767;
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
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton Cancel;
        private MetroFramework.Controls.MetroButton edit;
        private MetroFramework.Controls.MetroButton register;
        private MetroFramework.Controls.MetroTextBox textbox_type;
        private MetroFramework.Controls.MetroTextBox textbox_name;
        private MetroFramework.Controls.MetroTextBox textbox_priority;
        private MetroFramework.Controls.MetroTextBox textbox_email;
        private MetroFramework.Controls.MetroTextBox textbox_phone;
        private MetroFramework.Controls.MetroTextBox textbox_doi;
        private MetroFramework.Controls.MetroTextBox textbox_address;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private MetroFramework.Controls.MetroComboBox combobox_priority_s;
        private MetroFramework.Controls.MetroTextBox doi_s;
        private MetroFramework.Controls.MetroComboBox combobox_type_s;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Almacén;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
