namespace WindowsFormsApp1.Views
{
    partial class Warehouse
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
            this.cancelA = new System.Windows.Forms.Button();
            this.editA = new System.Windows.Forms.Button();
            this.newA = new System.Windows.Forms.Button();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Almacén = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroComboBox5 = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox4 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.state = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.product = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.max_capacity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.type_warehouse = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mStyle = new MetroFramework.Components.MetroStyleManager(this.components);
            this.combobox_obtener = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mStyle)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelA
            // 
            this.cancelA.BackColor = System.Drawing.Color.SteelBlue;
            this.cancelA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelA.ForeColor = System.Drawing.Color.White;
            this.cancelA.Location = new System.Drawing.Point(311, 485);
            this.cancelA.Name = "cancelA";
            this.cancelA.Size = new System.Drawing.Size(103, 27);
            this.cancelA.TabIndex = 17;
            this.cancelA.Text = "Cancelar";
            this.cancelA.UseVisualStyleBackColor = false;
            // 
            // editA
            // 
            this.editA.BackColor = System.Drawing.Color.SteelBlue;
            this.editA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editA.ForeColor = System.Drawing.Color.White;
            this.editA.Location = new System.Drawing.Point(187, 485);
            this.editA.Name = "editA";
            this.editA.Size = new System.Drawing.Size(103, 27);
            this.editA.TabIndex = 16;
            this.editA.Text = "Editar";
            this.editA.UseVisualStyleBackColor = false;
            // 
            // newA
            // 
            this.newA.BackColor = System.Drawing.Color.SteelBlue;
            this.newA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newA.ForeColor = System.Drawing.Color.White;
            this.newA.Location = new System.Drawing.Point(62, 485);
            this.newA.Name = "newA";
            this.newA.Size = new System.Drawing.Size(103, 27);
            this.newA.TabIndex = 15;
            this.newA.Text = "Nuevo";
            this.newA.UseVisualStyleBackColor = false;
            this.newA.Click += new System.EventHandler(this.newA_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(37, 91);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(922, 568);
            this.metroTabControl1.TabIndex = 19;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroButton5);
            this.metroTabPage2.Controls.Add(this.metroButton1);
            this.metroTabPage2.Controls.Add(this.metroGrid1);
            this.metroTabPage2.Controls.Add(this.metroComboBox5);
            this.metroTabPage2.Controls.Add(this.metroTextBox4);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.metroComboBox4);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(914, 526);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Consultar";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(522, 99);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(116, 29);
            this.metroButton5.TabIndex = 29;
            this.metroButton5.Text = "Grabar";
            this.metroButton5.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(372, 99);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(116, 29);
            this.metroButton1.TabIndex = 20;
            this.metroButton1.Text = "Buscar";
            this.metroButton1.UseSelectable = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Almacén,
            this.Column6,
            this.Column11,
            this.Column7,
            this.Column8,
            this.Column10,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 177);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(698, 235);
            this.metroGrid1.TabIndex = 28;
            // 
            // Almacén
            // 
            this.Almacén.HeaderText = "Almacén";
            this.Almacén.Name = "Almacén";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Producto/Material";
            this.Column6.Name = "Column6";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Unidad";
            this.Column11.Name = "Column11";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Capacidad Actual";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Capacidad Máxima";
            this.Column8.Name = "Column8";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Eliminar";
            this.Column10.Name = "Column10";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Editar";
            this.Column1.Name = "Column1";
            // 
            // metroComboBox5
            // 
            this.metroComboBox5.FormattingEnabled = true;
            this.metroComboBox5.ItemHeight = 23;
            this.metroComboBox5.Location = new System.Drawing.Point(478, 33);
            this.metroComboBox5.Name = "metroComboBox5";
            this.metroComboBox5.Size = new System.Drawing.Size(160, 29);
            this.metroComboBox5.TabIndex = 27;
            this.metroComboBox5.UseSelectable = true;
            // 
            // metroTextBox4
            // 
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.Lines = new string[0];
            this.metroTextBox4.Location = new System.Drawing.Point(159, 86);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(105, 27);
            this.metroTextBox4.TabIndex = 26;
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(23, 86);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(119, 19);
            this.metroLabel8.TabIndex = 25;
            this.metroLabel8.Text = "Capacidad Actual :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(353, 36);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(119, 19);
            this.metroLabel7.TabIndex = 23;
            this.metroLabel7.Text = "Producto/Material:";
            // 
            // metroComboBox4
            // 
            this.metroComboBox4.FormattingEnabled = true;
            this.metroComboBox4.ItemHeight = 23;
            this.metroComboBox4.Location = new System.Drawing.Point(159, 33);
            this.metroComboBox4.Name = "metroComboBox4";
            this.metroComboBox4.Size = new System.Drawing.Size(160, 29);
            this.metroComboBox4.TabIndex = 22;
            this.metroComboBox4.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 33);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(66, 19);
            this.metroLabel6.TabIndex = 21;
            this.metroLabel6.Text = "Nombre :";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.combobox_obtener);
            this.metroTabPage3.Controls.Add(this.state);
            this.metroTabPage3.Controls.Add(this.metroLabel10);
            this.metroTabPage3.Controls.Add(this.product);
            this.metroTabPage3.Controls.Add(this.metroLabel9);
            this.metroTabPage3.Controls.Add(this.metroButton3);
            this.metroTabPage3.Controls.Add(this.metroButton2);
            this.metroTabPage3.Controls.Add(this.metroComboBox2);
            this.metroTabPage3.Controls.Add(this.max_capacity);
            this.metroTabPage3.Controls.Add(this.metroLabel4);
            this.metroTabPage3.Controls.Add(this.type_warehouse);
            this.metroTabPage3.Controls.Add(this.metroLabel3);
            this.metroTabPage3.Controls.Add(this.name);
            this.metroTabPage3.Controls.Add(this.metroLabel1);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(914, 526);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Registro";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            this.metroTabPage3.Click += new System.EventHandler(this.metroTabPage3_Click);
            // 
            // state
            // 
            // 
            // 
            // 
            this.state.CustomButton.Image = null;
            this.state.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.state.CustomButton.Name = "";
            this.state.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.state.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.state.CustomButton.TabIndex = 1;
            this.state.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.state.CustomButton.UseSelectable = true;
            this.state.CustomButton.Visible = false;
            this.state.Lines = new string[0];
            this.state.Location = new System.Drawing.Point(378, 237);
            this.state.MaxLength = 32767;
            this.state.Name = "state";
            this.state.PasswordChar = '\0';
            this.state.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.state.SelectedText = "";
            this.state.SelectionLength = 0;
            this.state.SelectionStart = 0;
            this.state.ShortcutsEnabled = true;
            this.state.Size = new System.Drawing.Size(98, 27);
            this.state.TabIndex = 71;
            this.state.UseSelectable = true;
            this.state.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.state.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.state.Click += new System.EventHandler(this.metroTextBox5_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(252, 245);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(55, 19);
            this.metroLabel10.TabIndex = 70;
            this.metroLabel10.Text = "Estado :";
            // 
            // product
            // 
            this.product.FormattingEnabled = true;
            this.product.ItemHeight = 23;
            this.product.Location = new System.Drawing.Point(378, 104);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(245, 29);
            this.product.TabIndex = 69;
            this.product.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(252, 107);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(70, 19);
            this.metroLabel9.TabIndex = 68;
            this.metroLabel9.Text = "Producto :";
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(441, 323);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(98, 27);
            this.metroButton3.TabIndex = 67;
            this.metroButton3.Text = "Cancelar";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(300, 323);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(98, 27);
            this.metroButton2.TabIndex = 66;
            this.metroButton2.Text = "Guardar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(482, 189);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(81, 29);
            this.metroComboBox2.TabIndex = 62;
            this.metroComboBox2.UseSelectable = true;
            // 
            // max_capacity
            // 
            // 
            // 
            // 
            this.max_capacity.CustomButton.Image = null;
            this.max_capacity.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.max_capacity.CustomButton.Name = "";
            this.max_capacity.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.max_capacity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.max_capacity.CustomButton.TabIndex = 1;
            this.max_capacity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.max_capacity.CustomButton.UseSelectable = true;
            this.max_capacity.CustomButton.Visible = false;
            this.max_capacity.Lines = new string[0];
            this.max_capacity.Location = new System.Drawing.Point(378, 189);
            this.max_capacity.MaxLength = 32767;
            this.max_capacity.Name = "max_capacity";
            this.max_capacity.PasswordChar = '\0';
            this.max_capacity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.max_capacity.SelectedText = "";
            this.max_capacity.SelectionLength = 0;
            this.max_capacity.SelectionStart = 0;
            this.max_capacity.ShortcutsEnabled = true;
            this.max_capacity.Size = new System.Drawing.Size(98, 27);
            this.max_capacity.TabIndex = 61;
            this.max_capacity.UseSelectable = true;
            this.max_capacity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.max_capacity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(252, 188);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(130, 19);
            this.metroLabel4.TabIndex = 60;
            this.metroLabel4.Text = "Capacidad Máxima :";
            // 
            // type_warehouse
            // 
            this.type_warehouse.FormattingEnabled = true;
            this.type_warehouse.ItemHeight = 23;
            this.type_warehouse.Location = new System.Drawing.Point(378, 139);
            this.type_warehouse.Name = "type_warehouse";
            this.type_warehouse.Size = new System.Drawing.Size(245, 29);
            this.type_warehouse.TabIndex = 57;
            this.type_warehouse.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(252, 142);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 19);
            this.metroLabel3.TabIndex = 56;
            this.metroLabel3.Text = "Tipo Almacén :";
            // 
            // name
            // 
            // 
            // 
            // 
            this.name.CustomButton.Image = null;
            this.name.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.name.CustomButton.Name = "";
            this.name.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.name.CustomButton.TabIndex = 1;
            this.name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.name.CustomButton.UseSelectable = true;
            this.name.CustomButton.Visible = false;
            this.name.Lines = new string[0];
            this.name.Location = new System.Drawing.Point(378, 55);
            this.name.MaxLength = 32767;
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name.SelectedText = "";
            this.name.SelectionLength = 0;
            this.name.SelectionStart = 0;
            this.name.ShortcutsEnabled = true;
            this.name.Size = new System.Drawing.Size(245, 27);
            this.name.TabIndex = 54;
            this.name.UseSelectable = true;
            this.name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(252, 55);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 53;
            this.metroLabel1.Text = "Nombre : ";
            // 
            // mStyle
            // 
            this.mStyle.Owner = this;
            // 
            // combobox_obtener
            // 
            this.combobox_obtener.Location = new System.Drawing.Point(47, 323);
            this.combobox_obtener.Name = "combobox_obtener";
            this.combobox_obtener.Size = new System.Drawing.Size(98, 26);
            this.combobox_obtener.TabIndex = 72;
            this.combobox_obtener.Text = "Obtener";
            this.combobox_obtener.UseSelectable = true;
            this.combobox_obtener.Click += new System.EventHandler(this.combobox_obtener_Click);
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.cancelA);
            this.Controls.Add(this.editA);
            this.Controls.Add(this.newA);
            this.DoubleBuffered = true;
            this.Name = "Warehouse";
            this.Size = new System.Drawing.Size(992, 729);
            this.Load += new System.EventHandler(this.Warehouse_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mStyle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cancelA;
        private System.Windows.Forms.Button editA;
        private System.Windows.Forms.Button newA;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroComboBox metroComboBox5;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox metroComboBox4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Almacén;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroTextBox max_capacity;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox type_warehouse;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox name;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private MetroFramework.Components.MetroStyleManager mStyle;
        private MetroFramework.Controls.MetroComboBox product;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox state;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton combobox_obtener;
    }
}
