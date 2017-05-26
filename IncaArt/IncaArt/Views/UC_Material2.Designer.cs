namespace WindowsFormsApp1.Views
{
    partial class UC_Material
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.combobox_unit_s = new System.Windows.Forms.ComboBox();
            this.textbox_name_s = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textbox_max_stock = new System.Windows.Forms.TextBox();
            this.combobox_unit = new System.Windows.Forms.ComboBox();
            this.textbox_min_stock = new System.Windows.Forms.TextBox();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.material_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_unit_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(312, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(563, 383);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(555, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado de Materias Prima";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.btn_search);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.combobox_unit_s);
            this.groupBox3.Controls.Add(this.textbox_name_s);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(546, 114);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(368, 83);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(83, 25);
            this.btn_search.TabIndex = 27;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_delete.Enabled = false;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(457, 83);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(83, 25);
            this.btn_delete.TabIndex = 26;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // combobox_unit_s
            // 
            this.combobox_unit_s.FormattingEnabled = true;
            this.combobox_unit_s.Location = new System.Drawing.Point(59, 48);
            this.combobox_unit_s.Name = "combobox_unit_s";
            this.combobox_unit_s.Size = new System.Drawing.Size(121, 21);
            this.combobox_unit_s.TabIndex = 4;
            // 
            // textbox_name_s
            // 
            this.textbox_name_s.Location = new System.Drawing.Point(59, 22);
            this.textbox_name_s.Name = "textbox_name_s";
            this.textbox_name_s.Size = new System.Drawing.Size(121, 20);
            this.textbox_name_s.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Unidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.material_id,
            this.material_name,
            this.material_unit_id,
            this.max_stock,
            this.stock_min});
            this.dataGridView1.Location = new System.Drawing.Point(6, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 228);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(134, 363);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(83, 25);
            this.btn_edit.TabIndex = 35;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(223, 363);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(83, 25);
            this.btn_cancel.TabIndex = 34;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(45, 363);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(83, 25);
            this.btn_new.TabIndex = 33;
            this.btn_new.Text = "Nuevo";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.textbox_max_stock);
            this.groupBox1.Controls.Add(this.combobox_unit);
            this.groupBox1.Controls.Add(this.textbox_min_stock);
            this.groupBox1.Controls.Add(this.textbox_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 336);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Materia Prima";
            // 
            // textbox_max_stock
            // 
            this.textbox_max_stock.Location = new System.Drawing.Point(95, 117);
            this.textbox_max_stock.Name = "textbox_max_stock";
            this.textbox_max_stock.Size = new System.Drawing.Size(121, 20);
            this.textbox_max_stock.TabIndex = 8;
            // 
            // combobox_unit
            // 
            this.combobox_unit.FormattingEnabled = true;
            this.combobox_unit.Location = new System.Drawing.Point(95, 57);
            this.combobox_unit.Name = "combobox_unit";
            this.combobox_unit.Size = new System.Drawing.Size(121, 21);
            this.combobox_unit.TabIndex = 7;
            // 
            // textbox_min_stock
            // 
            this.textbox_min_stock.Location = new System.Drawing.Point(95, 87);
            this.textbox_min_stock.Name = "textbox_min_stock";
            this.textbox_min_stock.Size = new System.Drawing.Size(121, 20);
            this.textbox_min_stock.TabIndex = 6;
            // 
            // textbox_name
            // 
            this.textbox_name.Location = new System.Drawing.Point(95, 27);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(121, 20);
            this.textbox_name.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock máximo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock mínimo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // material_id
            // 
            this.material_id.HeaderText = "ID";
            this.material_id.Name = "material_id";
            this.material_id.Visible = false;
            // 
            // material_name
            // 
            this.material_name.HeaderText = "Nombre";
            this.material_name.Name = "material_name";
            // 
            // material_unit_id
            // 
            this.material_unit_id.HeaderText = "Unidad";
            this.material_unit_id.Name = "material_unit_id";
            // 
            // max_stock
            // 
            this.max_stock.HeaderText = "Stock Máximo";
            this.max_stock.Name = "max_stock";
            // 
            // stock_min
            // 
            this.stock_min.HeaderText = "Stock mínimo";
            this.stock_min.Name = "stock_min";
            // 
            // UC_Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Material";
            this.Size = new System.Drawing.Size(889, 400);
            this.Load += new System.EventHandler(this.Material_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Button btn_search;
        internal System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox combobox_unit_s;
        private System.Windows.Forms.TextBox textbox_name_s;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button btn_edit;
        internal System.Windows.Forms.Button btn_cancel;
        internal System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textbox_max_stock;
        private System.Windows.Forms.ComboBox combobox_unit;
        private System.Windows.Forms.TextBox textbox_min_stock;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_unit_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn max_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_min;
    }
}
