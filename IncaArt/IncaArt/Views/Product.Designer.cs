namespace WindowsFormsApp1.Views
{
    partial class Product
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
            this.groupBox_Product = new System.Windows.Forms.GroupBox();
            this.comboBox_Currency = new System.Windows.Forms.ComboBox();
            this.comboBox_UnitMeasure = new System.Windows.Forms.ComboBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_StockMax = new System.Windows.Forms.Label();
            this.label_StockMin = new System.Windows.Forms.Label();
            this.label_UnitMeasure = new System.Windows.Forms.Label();
            this.textBox_StockMax = new System.Windows.Forms.TextBox();
            this.textBox_StockMin = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.tabControl_List = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Measure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_StockMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_StockMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Delete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NameSearch = new System.Windows.Forms.TextBox();
            this.label_NameSearch = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_New = new System.Windows.Forms.Button();
            this.groupBox_Product.SuspendLayout();
            this.tabControl_List.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Product
            // 
            this.groupBox_Product.Controls.Add(this.comboBox_Currency);
            this.groupBox_Product.Controls.Add(this.comboBox_UnitMeasure);
            this.groupBox_Product.Controls.Add(this.textBox_Price);
            this.groupBox_Product.Controls.Add(this.label_Price);
            this.groupBox_Product.Controls.Add(this.label_StockMax);
            this.groupBox_Product.Controls.Add(this.label_StockMin);
            this.groupBox_Product.Controls.Add(this.label_UnitMeasure);
            this.groupBox_Product.Controls.Add(this.textBox_StockMax);
            this.groupBox_Product.Controls.Add(this.textBox_StockMin);
            this.groupBox_Product.Controls.Add(this.textBox_Name);
            this.groupBox_Product.Controls.Add(this.label_Name);
            this.groupBox_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Product.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox_Product.Location = new System.Drawing.Point(13, 86);
            this.groupBox_Product.Name = "groupBox_Product";
            this.groupBox_Product.Size = new System.Drawing.Size(347, 258);
            this.groupBox_Product.TabIndex = 3;
            this.groupBox_Product.TabStop = false;
            this.groupBox_Product.Text = "Datos del producto";
            // 
            // comboBox_Currency
            // 
            this.comboBox_Currency.FormattingEnabled = true;
            this.comboBox_Currency.Items.AddRange(new object[] {
            "soles",
            "dólares"});
            this.comboBox_Currency.Location = new System.Drawing.Point(254, 124);
            this.comboBox_Currency.Name = "comboBox_Currency";
            this.comboBox_Currency.Size = new System.Drawing.Size(75, 21);
            this.comboBox_Currency.TabIndex = 12;
            // 
            // comboBox_UnitMeasure
            // 
            this.comboBox_UnitMeasure.FormattingEnabled = true;
            this.comboBox_UnitMeasure.Items.AddRange(new object[] {
            "kilos",
            "metros cuadrados"});
            this.comboBox_UnitMeasure.Location = new System.Drawing.Point(162, 92);
            this.comboBox_UnitMeasure.Name = "comboBox_UnitMeasure";
            this.comboBox_UnitMeasure.Size = new System.Drawing.Size(167, 21);
            this.comboBox_UnitMeasure.TabIndex = 11;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(162, 124);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(86, 20);
            this.textBox_Price.TabIndex = 9;
            this.textBox_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Price_KeyPress);
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(34, 127);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(47, 13);
            this.label_Price.TabIndex = 8;
            this.label_Price.Text = "Precio:";
            // 
            // label_StockMax
            // 
            this.label_StockMax.AutoSize = true;
            this.label_StockMax.Location = new System.Drawing.Point(37, 196);
            this.label_StockMax.Name = "label_StockMax";
            this.label_StockMax.Size = new System.Drawing.Size(89, 13);
            this.label_StockMax.TabIndex = 7;
            this.label_StockMax.Text = "Stock máximo:";
            // 
            // label_StockMin
            // 
            this.label_StockMin.AutoSize = true;
            this.label_StockMin.Location = new System.Drawing.Point(34, 160);
            this.label_StockMin.Name = "label_StockMin";
            this.label_StockMin.Size = new System.Drawing.Size(88, 13);
            this.label_StockMin.TabIndex = 6;
            this.label_StockMin.Text = "Stock mínimo:";
            // 
            // label_UnitMeasure
            // 
            this.label_UnitMeasure.AutoSize = true;
            this.label_UnitMeasure.Location = new System.Drawing.Point(34, 95);
            this.label_UnitMeasure.Name = "label_UnitMeasure";
            this.label_UnitMeasure.Size = new System.Drawing.Size(113, 13);
            this.label_UnitMeasure.TabIndex = 5;
            this.label_UnitMeasure.Text = "Unidad de medida:";
            // 
            // textBox_StockMax
            // 
            this.textBox_StockMax.Location = new System.Drawing.Point(162, 193);
            this.textBox_StockMax.Name = "textBox_StockMax";
            this.textBox_StockMax.Size = new System.Drawing.Size(167, 20);
            this.textBox_StockMax.TabIndex = 3;
            this.textBox_StockMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_StockMax_KeyPress);
            // 
            // textBox_StockMin
            // 
            this.textBox_StockMin.Location = new System.Drawing.Point(162, 160);
            this.textBox_StockMin.Name = "textBox_StockMin";
            this.textBox_StockMin.Size = new System.Drawing.Size(167, 20);
            this.textBox_StockMin.TabIndex = 2;
            this.textBox_StockMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_StockMin_KeyPress);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(162, 59);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(167, 20);
            this.textBox_Name.TabIndex = 1;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(34, 62);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(54, 13);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Nombre:";
            // 
            // tabControl_List
            // 
            this.tabControl_List.Controls.Add(this.tabPage1);
            this.tabControl_List.Location = new System.Drawing.Point(379, 33);
            this.tabControl_List.Name = "tabControl_List";
            this.tabControl_List.SelectedIndex = 0;
            this.tabControl_List.Size = new System.Drawing.Size(504, 490);
            this.tabControl_List.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button_Delete);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(496, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado de Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Name,
            this.Column_Measure,
            this.Column_Price,
            this.Column_StockMin,
            this.Column_StockMax});
            this.dataGridView1.Location = new System.Drawing.Point(25, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 242);
            this.dataGridView1.TabIndex = 21;
            // 
            // Column_Name
            // 
            this.Column_Name.HeaderText = "Nombre";
            this.Column_Name.Name = "Column_Name";
            // 
            // Column_Measure
            // 
            this.Column_Measure.HeaderText = "Medida";
            this.Column_Measure.Name = "Column_Measure";
            // 
            // Column_Price
            // 
            this.Column_Price.HeaderText = "Precio";
            this.Column_Price.Name = "Column_Price";
            // 
            // Column_StockMin
            // 
            this.Column_StockMin.HeaderText = "Stock mínimo";
            this.Column_StockMin.Name = "Column_StockMin";
            // 
            // Column_StockMax
            // 
            this.Column_StockMax.HeaderText = "Stock máximo";
            this.Column_StockMax.Name = "Column_StockMax";
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Delete.Location = new System.Drawing.Point(370, 411);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(103, 27);
            this.button_Delete.TabIndex = 20;
            this.button_Delete.Text = "Eliminar";
            this.button_Delete.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_NameSearch);
            this.groupBox2.Controls.Add(this.label_NameSearch);
            this.groupBox2.Controls.Add(this.button_Search);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Location = new System.Drawing.Point(21, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 99);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "kilos",
            "metros cuadrados"});
            this.comboBox3.Location = new System.Drawing.Point(315, 28);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(148, 21);
            this.comboBox3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Unidad de medida:";
            // 
            // textBox_NameSearch
            // 
            this.textBox_NameSearch.Location = new System.Drawing.Point(66, 29);
            this.textBox_NameSearch.Name = "textBox_NameSearch";
            this.textBox_NameSearch.Size = new System.Drawing.Size(108, 20);
            this.textBox_NameSearch.TabIndex = 17;
            // 
            // label_NameSearch
            // 
            this.label_NameSearch.AutoSize = true;
            this.label_NameSearch.Location = new System.Drawing.Point(6, 32);
            this.label_NameSearch.Name = "label_NameSearch";
            this.label_NameSearch.Size = new System.Drawing.Size(54, 13);
            this.label_NameSearch.TabIndex = 4;
            this.label_NameSearch.Text = "Nombre:";
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.Location = new System.Drawing.Point(327, 66);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(103, 27);
            this.button_Search.TabIndex = 3;
            this.button_Search.Text = "Buscar";
            this.button_Search.UseVisualStyleBackColor = false;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Cancel.ForeColor = System.Drawing.SystemColors.Window;
            this.button_Cancel.Location = new System.Drawing.Point(237, 414);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 21;
            this.button_Cancel.Text = "Cancelar";
            this.button_Cancel.UseVisualStyleBackColor = false;
            // 
            // button_Edit
            // 
            this.button_Edit.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Edit.ForeColor = System.Drawing.SystemColors.Menu;
            this.button_Edit.Location = new System.Drawing.Point(146, 414);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(75, 23);
            this.button_Edit.TabIndex = 20;
            this.button_Edit.Text = "Editar";
            this.button_Edit.UseVisualStyleBackColor = false;
            // 
            // button_New
            // 
            this.button_New.BackColor = System.Drawing.Color.SteelBlue;
            this.button_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_New.ForeColor = System.Drawing.SystemColors.Menu;
            this.button_New.Location = new System.Drawing.Point(47, 414);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(75, 23);
            this.button_New.TabIndex = 19;
            this.button_New.Text = "Nuevo";
            this.button_New.UseVisualStyleBackColor = false;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.tabControl_List);
            this.Controls.Add(this.groupBox_Product);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(915, 549);
            this.groupBox_Product.ResumeLayout(false);
            this.groupBox_Product.PerformLayout();
            this.tabControl_List.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Product;
        private System.Windows.Forms.ComboBox comboBox_Currency;
        private System.Windows.Forms.ComboBox comboBox_UnitMeasure;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_StockMax;
        private System.Windows.Forms.Label label_StockMin;
        private System.Windows.Forms.Label label_UnitMeasure;
        private System.Windows.Forms.TextBox textBox_StockMax;
        private System.Windows.Forms.TextBox textBox_StockMin;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TabControl tabControl_List;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Measure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_StockMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_StockMax;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NameSearch;
        private System.Windows.Forms.Label label_NameSearch;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_New;
    }
}
