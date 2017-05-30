namespace WindowsFormsApp1.Views
{
    partial class UC_Recipe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.consulta = new MetroFramework.Controls.MetroTabPage();
            this.btn_delete = new MetroFramework.Controls.MetroButton();
            this.btn_clean_s = new MetroFramework.Controls.MetroButton();
            this.btn_search = new MetroFramework.Controls.MetroButton();
            this.textbox_name_s = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro = new MetroFramework.Controls.MetroTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textbox_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.combobox_product = new MetroFramework.Controls.MetroComboBox();
            this.textbox_description = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_mat_delete = new MetroFramework.Controls.MetroButton();
            this.btn_mat_edit = new MetroFramework.Controls.MetroButton();
            this.btn_mat_add = new MetroFramework.Controls.MetroButton();
            this.textbox_quantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.combobox_material = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.recipe_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cancel = new MetroFramework.Controls.MetroButton();
            this.btn_edit = new MetroFramework.Controls.MetroButton();
            this.btn_new = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.registro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.consulta);
            this.metroTabControl1.Controls.Add(this.registro);
            this.metroTabControl1.Location = new System.Drawing.Point(25, 34);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(753, 456);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // consulta
            // 
            this.consulta.Controls.Add(this.btn_delete);
            this.consulta.Controls.Add(this.btn_clean_s);
            this.consulta.Controls.Add(this.btn_search);
            this.consulta.Controls.Add(this.textbox_name_s);
            this.consulta.Controls.Add(this.metroLabel1);
            this.consulta.Controls.Add(this.metroGrid1);
            this.consulta.HorizontalScrollbarBarColor = true;
            this.consulta.HorizontalScrollbarHighlightOnWheel = false;
            this.consulta.HorizontalScrollbarSize = 10;
            this.consulta.Location = new System.Drawing.Point(4, 38);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(713, 408);
            this.consulta.TabIndex = 0;
            this.consulta.Text = "Consulta";
            this.consulta.VerticalScrollbarBarColor = true;
            this.consulta.VerticalScrollbarHighlightOnWheel = false;
            this.consulta.VerticalScrollbarSize = 10;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(248, 341);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseSelectable = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clean_s
            // 
            this.btn_clean_s.Location = new System.Drawing.Point(244, 106);
            this.btn_clean_s.Name = "btn_clean_s";
            this.btn_clean_s.Size = new System.Drawing.Size(75, 23);
            this.btn_clean_s.TabIndex = 12;
            this.btn_clean_s.Text = "Limpiar";
            this.btn_clean_s.UseSelectable = true;
            this.btn_clean_s.Click += new System.EventHandler(this.btn_clean_s_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(148, 106);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseSelectable = true;
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
            this.textbox_name_s.Location = new System.Drawing.Point(103, 22);
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Nombre:";
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
            this.id,
            this.index,
            this.nombre,
            this.product});
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
            this.metroGrid1.Location = new System.Drawing.Point(35, 147);
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
            this.metroGrid1.Size = new System.Drawing.Size(288, 178);
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
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // product
            // 
            this.product.HeaderText = "Producto";
            this.product.Name = "product";
            // 
            // registro
            // 
            this.registro.Controls.Add(this.btn_cancel);
            this.registro.Controls.Add(this.btn_new);
            this.registro.Controls.Add(this.btn_edit);
            this.registro.Controls.Add(this.groupBox2);
            this.registro.Controls.Add(this.groupBox1);
            this.registro.Controls.Add(this.metroGrid2);
            this.registro.HorizontalScrollbarBarColor = true;
            this.registro.HorizontalScrollbarHighlightOnWheel = false;
            this.registro.HorizontalScrollbarSize = 10;
            this.registro.Location = new System.Drawing.Point(4, 38);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(745, 414);
            this.registro.TabIndex = 1;
            this.registro.Text = "Registro";
            this.registro.VerticalScrollbarBarColor = true;
            this.registro.VerticalScrollbarHighlightOnWheel = false;
            this.registro.VerticalScrollbarSize = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.textbox_name);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.combobox_product);
            this.groupBox2.Controls.Add(this.textbox_description);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Location = new System.Drawing.Point(11, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 215);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Receta";
            // 
            // textbox_name
            // 
            // 
            // 
            // 
            this.textbox_name.CustomButton.Image = null;
            this.textbox_name.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.textbox_name.CustomButton.Name = "";
            this.textbox_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_name.CustomButton.TabIndex = 1;
            this.textbox_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_name.CustomButton.UseSelectable = true;
            this.textbox_name.CustomButton.Visible = false;
            this.textbox_name.Lines = new string[0];
            this.textbox_name.Location = new System.Drawing.Point(118, 29);
            this.textbox_name.MaxLength = 32767;
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.PasswordChar = '\0';
            this.textbox_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_name.SelectedText = "";
            this.textbox_name.SelectionLength = 0;
            this.textbox_name.SelectionStart = 0;
            this.textbox_name.ShortcutsEnabled = true;
            this.textbox_name.Size = new System.Drawing.Size(179, 23);
            this.textbox_name.TabIndex = 6;
            this.textbox_name.UseSelectable = true;
            this.textbox_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(15, 34);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Nombre:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 72);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Descripción:";
            // 
            // combobox_product
            // 
            this.combobox_product.FormattingEnabled = true;
            this.combobox_product.ItemHeight = 23;
            this.combobox_product.Location = new System.Drawing.Point(118, 167);
            this.combobox_product.Name = "combobox_product";
            this.combobox_product.Size = new System.Drawing.Size(179, 29);
            this.combobox_product.TabIndex = 16;
            this.combobox_product.UseSelectable = true;
            // 
            // textbox_description
            // 
            // 
            // 
            // 
            this.textbox_description.CustomButton.Image = null;
            this.textbox_description.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.textbox_description.CustomButton.Name = "";
            this.textbox_description.CustomButton.Size = new System.Drawing.Size(73, 73);
            this.textbox_description.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_description.CustomButton.TabIndex = 1;
            this.textbox_description.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_description.CustomButton.UseSelectable = true;
            this.textbox_description.CustomButton.Visible = false;
            this.textbox_description.Lines = new string[0];
            this.textbox_description.Location = new System.Drawing.Point(118, 72);
            this.textbox_description.MaxLength = 32767;
            this.textbox_description.Name = "textbox_description";
            this.textbox_description.PasswordChar = '\0';
            this.textbox_description.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_description.SelectedText = "";
            this.textbox_description.SelectionLength = 0;
            this.textbox_description.SelectionStart = 0;
            this.textbox_description.ShortcutsEnabled = true;
            this.textbox_description.Size = new System.Drawing.Size(352, 75);
            this.textbox_description.TabIndex = 14;
            this.textbox_description.UseSelectable = true;
            this.textbox_description.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_description.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(15, 170);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Producto:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.btn_mat_delete);
            this.groupBox1.Controls.Add(this.btn_mat_edit);
            this.groupBox1.Controls.Add(this.btn_mat_add);
            this.groupBox1.Controls.Add(this.textbox_quantity);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.combobox_material);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Location = new System.Drawing.Point(368, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 150);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Material";
            // 
            // btn_mat_delete
            // 
            this.btn_mat_delete.Location = new System.Drawing.Point(169, 121);
            this.btn_mat_delete.Name = "btn_mat_delete";
            this.btn_mat_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_mat_delete.TabIndex = 6;
            this.btn_mat_delete.Text = "Eliminar";
            this.btn_mat_delete.UseSelectable = true;
            this.btn_mat_delete.Click += new System.EventHandler(this.btn_mat_delete_Click);
            // 
            // btn_mat_edit
            // 
            this.btn_mat_edit.Location = new System.Drawing.Point(88, 121);
            this.btn_mat_edit.Name = "btn_mat_edit";
            this.btn_mat_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_mat_edit.TabIndex = 5;
            this.btn_mat_edit.Text = "Editar";
            this.btn_mat_edit.UseSelectable = true;
            this.btn_mat_edit.Click += new System.EventHandler(this.btn_mat_edit_Click);
            // 
            // btn_mat_add
            // 
            this.btn_mat_add.Location = new System.Drawing.Point(7, 121);
            this.btn_mat_add.Name = "btn_mat_add";
            this.btn_mat_add.Size = new System.Drawing.Size(75, 23);
            this.btn_mat_add.TabIndex = 4;
            this.btn_mat_add.Text = "Agregar";
            this.btn_mat_add.UseSelectable = true;
            this.btn_mat_add.Click += new System.EventHandler(this.btn_mat_add_Click);
            // 
            // textbox_quantity
            // 
            // 
            // 
            // 
            this.textbox_quantity.CustomButton.Image = null;
            this.textbox_quantity.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.textbox_quantity.CustomButton.Name = "";
            this.textbox_quantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_quantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_quantity.CustomButton.TabIndex = 1;
            this.textbox_quantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_quantity.CustomButton.UseSelectable = true;
            this.textbox_quantity.CustomButton.Visible = false;
            this.textbox_quantity.Lines = new string[0];
            this.textbox_quantity.Location = new System.Drawing.Point(74, 75);
            this.textbox_quantity.MaxLength = 32767;
            this.textbox_quantity.Name = "textbox_quantity";
            this.textbox_quantity.PasswordChar = '\0';
            this.textbox_quantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_quantity.SelectedText = "";
            this.textbox_quantity.SelectionLength = 0;
            this.textbox_quantity.SelectionStart = 0;
            this.textbox_quantity.ShortcutsEnabled = true;
            this.textbox_quantity.Size = new System.Drawing.Size(121, 23);
            this.textbox_quantity.TabIndex = 3;
            this.textbox_quantity.UseSelectable = true;
            this.textbox_quantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_quantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(2, 75);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(65, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Cantidad:";
            // 
            // combobox_material
            // 
            this.combobox_material.FormattingEnabled = true;
            this.combobox_material.ItemHeight = 23;
            this.combobox_material.Location = new System.Drawing.Point(74, 31);
            this.combobox_material.Name = "combobox_material";
            this.combobox_material.Size = new System.Drawing.Size(121, 29);
            this.combobox_material.TabIndex = 1;
            this.combobox_material.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(7, 34);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(60, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Material:";
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recipe_id,
            this.material_row,
            this.operation,
            this.material_name,
            this.unit,
            this.quantity});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(11, 242);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(351, 150);
            this.metroGrid2.TabIndex = 17;
            this.metroGrid2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid2_CellClick);
            this.metroGrid2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid2_CellDoubleClick);
            // 
            // recipe_id
            // 
            this.recipe_id.HeaderText = "ID";
            this.recipe_id.Name = "recipe_id";
            this.recipe_id.Visible = false;
            // 
            // material_row
            // 
            this.material_row.HeaderText = "Index";
            this.material_row.Name = "material_row";
            this.material_row.Visible = false;
            // 
            // operation
            // 
            this.operation.HeaderText = "Operation";
            this.operation.Name = "operation";
            this.operation.Visible = false;
            this.operation.Width = 75;
            // 
            // material_name
            // 
            this.material_name.HeaderText = "Material";
            this.material_name.Name = "material_name";
            // 
            // unit
            // 
            this.unit.HeaderText = "Unidad";
            this.unit.Name = "unit";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Cantidad";
            this.quantity.Name = "quantity";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(217, 369);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseSelectable = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(124, 369);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 11;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseSelectable = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(30, 369);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 10;
            this.btn_new.Text = "Registrar";
            this.btn_new.UseSelectable = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // UC_Recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Name = "UC_Recipe";
            this.Size = new System.Drawing.Size(840, 545);
            this.Load += new System.EventHandler(this.UC_Recipe_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.consulta.ResumeLayout(false);
            this.consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.registro.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
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
        private MetroFramework.Controls.MetroTabPage registro;
        private MetroFramework.Controls.MetroButton btn_cancel;
        private MetroFramework.Controls.MetroButton btn_edit;
        private MetroFramework.Controls.MetroButton btn_new;
        private MetroFramework.Controls.MetroTextBox textbox_name;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox combobox_product;
        private MetroFramework.Controls.MetroTextBox textbox_description;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox combobox_material;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private MetroFramework.Controls.MetroTextBox textbox_quantity;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btn_mat_delete;
        private MetroFramework.Controls.MetroButton btn_mat_edit;
        private MetroFramework.Controls.MetroButton btn_mat_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipe_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_row;
        private System.Windows.Forms.DataGridViewTextBoxColumn operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}
