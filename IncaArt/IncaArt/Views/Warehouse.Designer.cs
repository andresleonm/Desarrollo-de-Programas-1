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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelA = new System.Windows.Forms.Button();
            this.editA = new System.Windows.Forms.Button();
            this.newA = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Producto = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.unity2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.actual_capacity = new System.Windows.Forms.TextBox();
            this.unity1 = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.max_capacity = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(453, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 458);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(542, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Almacén";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SteelBlue;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(433, 399);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 27);
            this.button5.TabIndex = 20;
            this.button5.Text = "Eliminar";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column5,
            this.Column2,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(20, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(516, 235);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Almacen";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Producto / Material";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Unidad";
            this.Column5.Name = "Column5";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Capacidad Actual";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Máxima Capacidad";
            this.Column4.Name = "Column4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Location = new System.Drawing.Point(20, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 135);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Producto / Material :";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(152, 63);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(193, 21);
            this.comboBox4.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Nombre :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(152, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(84, 20);
            this.textBox3.TabIndex = 37;
            this.textBox3.Text = "50";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(152, 27);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(193, 21);
            this.comboBox3.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(379, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 27);
            this.button4.TabIndex = 3;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Capacidad Actual :";
            // 
            // cancelA
            // 
            this.cancelA.BackColor = System.Drawing.Color.SteelBlue;
            this.cancelA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelA.ForeColor = System.Drawing.Color.White;
            this.cancelA.Location = new System.Drawing.Point(300, 388);
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
            this.editA.Location = new System.Drawing.Point(176, 388);
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
            this.newA.Location = new System.Drawing.Point(51, 388);
            this.newA.Name = "newA";
            this.newA.Size = new System.Drawing.Size(103, 27);
            this.newA.TabIndex = 15;
            this.newA.Text = "Nuevo";
            this.newA.UseVisualStyleBackColor = false;
            this.newA.Click += new System.EventHandler(this.newA_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.type);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.Producto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.unity2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.actual_capacity);
            this.groupBox1.Controls.Add(this.unity1);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.max_capacity);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(42, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 259);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Almacén";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Producto / Material :";
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(168, 135);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(179, 21);
            this.type.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Tipo de Almacenaje :";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(168, 98);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 17);
            this.checkBox2.TabIndex = 41;
            this.checkBox2.Text = "Material";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Producto
            // 
            this.Producto.AutoSize = true;
            this.Producto.Checked = true;
            this.Producto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Producto.Location = new System.Drawing.Point(168, 75);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(77, 17);
            this.Producto.TabIndex = 40;
            this.Producto.Text = "Producto";
            this.Producto.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Nombre :";
            // 
            // unity2
            // 
            this.unity2.FormattingEnabled = true;
            this.unity2.Items.AddRange(new object[] {
            "lts",
            "mls",
            "gal"});
            this.unity2.Location = new System.Drawing.Point(266, 217);
            this.unity2.Name = "unity2";
            this.unity2.Size = new System.Drawing.Size(81, 21);
            this.unity2.TabIndex = 36;
            this.unity2.Text = "und";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Capacidad Actual :";
            // 
            // actual_capacity
            // 
            this.actual_capacity.Location = new System.Drawing.Point(167, 218);
            this.actual_capacity.Name = "actual_capacity";
            this.actual_capacity.Size = new System.Drawing.Size(84, 20);
            this.actual_capacity.TabIndex = 34;
            this.actual_capacity.Text = "50";
            // 
            // unity1
            // 
            this.unity1.FormattingEnabled = true;
            this.unity1.Items.AddRange(new object[] {
            "lts",
            "mls",
            "gal"});
            this.unity1.Location = new System.Drawing.Point(266, 179);
            this.unity1.Name = "unity1";
            this.unity1.Size = new System.Drawing.Size(81, 21);
            this.unity1.TabIndex = 33;
            this.unity1.Text = "und";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(167, 41);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Máxima Capacidad :";
            // 
            // max_capacity
            // 
            this.max_capacity.Location = new System.Drawing.Point(167, 180);
            this.max_capacity.Name = "max_capacity";
            this.max_capacity.Size = new System.Drawing.Size(84, 20);
            this.max_capacity.TabIndex = 24;
            this.max_capacity.Text = "50";
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cancelA);
            this.Controls.Add(this.editA);
            this.Controls.Add(this.newA);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Warehouse";
            this.Size = new System.Drawing.Size(1023, 531);
            this.Load += new System.EventHandler(this.Warehouse_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelA;
        private System.Windows.Forms.Button editA;
        private System.Windows.Forms.Button newA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox Producto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox unity2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox actual_capacity;
        private System.Windows.Forms.ComboBox unity1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox max_capacity;
    }
}
