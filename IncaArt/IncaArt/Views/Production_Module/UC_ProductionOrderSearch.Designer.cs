namespace WindowsFormsApp1.Views
{
    partial class UC_ProductionOrderSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.metroTextBox_description = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_numOrder = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime_Begin = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime_End = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datagrid_ProductionOrders = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_ProductionOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.metroTextBox_description);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroTextBox_numOrder);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroDateTime_Begin);
            this.groupBox1.Controls.Add(this.metroDateTime_End);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 148);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(641, 113);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(82, 29);
            this.btn_Search.TabIndex = 67;
            this.btn_Search.Text = "Buscar";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // metroTextBox_description
            // 
            this.metroTextBox_description.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.metroTextBox_description.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.metroTextBox_description.CustomButton.Image = null;
            this.metroTextBox_description.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.metroTextBox_description.CustomButton.Name = "";
            this.metroTextBox_description.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBox_description.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_description.CustomButton.TabIndex = 1;
            this.metroTextBox_description.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_description.CustomButton.UseSelectable = true;
            this.metroTextBox_description.CustomButton.UseVisualStyleBackColor = false;
            this.metroTextBox_description.CustomButton.Visible = false;
            this.metroTextBox_description.Lines = new string[0];
            this.metroTextBox_description.Location = new System.Drawing.Point(523, 28);
            this.metroTextBox_description.MaxLength = 32767;
            this.metroTextBox_description.Name = "metroTextBox_description";
            this.metroTextBox_description.PasswordChar = '\0';
            this.metroTextBox_description.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_description.SelectedText = "";
            this.metroTextBox_description.SelectionLength = 0;
            this.metroTextBox_description.SelectionStart = 0;
            this.metroTextBox_description.ShortcutsEnabled = true;
            this.metroTextBox_description.Size = new System.Drawing.Size(200, 29);
            this.metroTextBox_description.TabIndex = 57;
            this.metroTextBox_description.UseCustomBackColor = true;
            this.metroTextBox_description.UseSelectable = true;
            this.metroTextBox_description.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_description.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel3.Location = new System.Drawing.Point(415, 28);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 15);
            this.metroLabel3.TabIndex = 56;
            this.metroLabel3.Text = "Descripción:";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroTextBox_numOrder
            // 
            this.metroTextBox_numOrder.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.metroTextBox_numOrder.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.metroTextBox_numOrder.CustomButton.Image = null;
            this.metroTextBox_numOrder.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.metroTextBox_numOrder.CustomButton.Name = "";
            this.metroTextBox_numOrder.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBox_numOrder.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_numOrder.CustomButton.TabIndex = 1;
            this.metroTextBox_numOrder.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_numOrder.CustomButton.UseSelectable = true;
            this.metroTextBox_numOrder.CustomButton.UseVisualStyleBackColor = false;
            this.metroTextBox_numOrder.CustomButton.Visible = false;
            this.metroTextBox_numOrder.Lines = new string[0];
            this.metroTextBox_numOrder.Location = new System.Drawing.Point(133, 28);
            this.metroTextBox_numOrder.MaxLength = 32767;
            this.metroTextBox_numOrder.Name = "metroTextBox_numOrder";
            this.metroTextBox_numOrder.PasswordChar = '\0';
            this.metroTextBox_numOrder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_numOrder.SelectedText = "";
            this.metroTextBox_numOrder.SelectionLength = 0;
            this.metroTextBox_numOrder.SelectionStart = 0;
            this.metroTextBox_numOrder.ShortcutsEnabled = true;
            this.metroTextBox_numOrder.Size = new System.Drawing.Size(200, 29);
            this.metroTextBox_numOrder.TabIndex = 54;
            this.metroTextBox_numOrder.UseCustomBackColor = true;
            this.metroTextBox_numOrder.UseSelectable = true;
            this.metroTextBox_numOrder.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_numOrder.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel4.Location = new System.Drawing.Point(17, 28);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(111, 15);
            this.metroLabel4.TabIndex = 53;
            this.metroLabel4.Text = "Número de Orden:";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroDateTime_Begin
            // 
            this.metroDateTime_Begin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime_Begin.Location = new System.Drawing.Point(133, 69);
            this.metroDateTime_Begin.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime_Begin.Name = "metroDateTime_Begin";
            this.metroDateTime_Begin.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime_Begin.TabIndex = 41;
            // 
            // metroDateTime_End
            // 
            this.metroDateTime_End.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime_End.Location = new System.Drawing.Point(523, 69);
            this.metroDateTime_End.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime_End.Name = "metroDateTime_End";
            this.metroDateTime_End.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime_End.TabIndex = 40;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel2.Location = new System.Drawing.Point(415, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 15);
            this.metroLabel2.TabIndex = 35;
            this.metroLabel2.Text = "Fecha fin:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel1.Location = new System.Drawing.Point(16, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 15);
            this.metroLabel1.TabIndex = 34;
            this.metroLabel1.Text = "Fecha inicio:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.datagrid_ProductionOrders);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 289);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados de búsqueda";
            // 
            // datagrid_ProductionOrders
            // 
            this.datagrid_ProductionOrders.AllowUserToAddRows = false;
            this.datagrid_ProductionOrders.AllowUserToDeleteRows = false;
            this.datagrid_ProductionOrders.AllowUserToOrderColumns = true;
            this.datagrid_ProductionOrders.AllowUserToResizeRows = false;
            this.datagrid_ProductionOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datagrid_ProductionOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_ProductionOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.datagrid_ProductionOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagrid_ProductionOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datagrid_ProductionOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_ProductionOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_ProductionOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_ProductionOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_ProductionOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_ProductionOrders.EnableHeadersVisualStyles = false;
            this.datagrid_ProductionOrders.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.datagrid_ProductionOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.datagrid_ProductionOrders.Location = new System.Drawing.Point(28, 29);
            this.datagrid_ProductionOrders.MultiSelect = false;
            this.datagrid_ProductionOrders.Name = "datagrid_ProductionOrders";
            this.datagrid_ProductionOrders.ReadOnly = true;
            this.datagrid_ProductionOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_ProductionOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_ProductionOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagrid_ProductionOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_ProductionOrders.Size = new System.Drawing.Size(718, 201);
            this.datagrid_ProductionOrders.Style = MetroFramework.MetroColorStyle.Teal;
            this.datagrid_ProductionOrders.TabIndex = 52;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nº orden";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha de inicio";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha de fin";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Producto";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Almacén";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Receta";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Cantidad";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Cotización";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Location = new System.Drawing.Point(14, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(805, 502);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(664, 254);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(82, 29);
            this.btn_delete.TabIndex = 74;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(561, 254);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(82, 29);
            this.btn_edit.TabIndex = 73;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // UC_ProductionOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "UC_ProductionOrderSearch";
            this.Size = new System.Drawing.Size(838, 508);
            this.Load += new System.EventHandler(this.UC_ProductionOrderSearch_Load);
            this.VisibleChanged += new System.EventHandler(this.UC_ProductionOrderSearch_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_ProductionOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox_numOrder;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime metroDateTime_Begin;
        private MetroFramework.Controls.MetroDateTime metroDateTime_End;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroGrid datagrid_ProductionOrders;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox_description;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
    }
}
