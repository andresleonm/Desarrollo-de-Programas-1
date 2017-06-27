namespace WindowsFormsApp1.Views
{
    partial class UC_SimulationExecution
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.productLineAssignmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_total_products_per_hour = new MetroFramework.Controls.MetroTextBox();
            this.txt_total_accuracy = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.execution_workers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.execution_workstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efficiency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.production_line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productLineAssignmentBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_export);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 37);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.Save_40px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(133, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Guardar en Reportes";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_export
            // 
            this.btn_export.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Image = global::WindowsFormsApp1.Properties.Resources.Microsoft_Excel_40px;
            this.btn_export.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_export.Location = new System.Drawing.Point(0, 0);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(133, 37);
            this.btn_export.TabIndex = 0;
            this.btn_export.Text = "Exportar a Excel";
            this.btn_export.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // productLineAssignmentBindingSource
            // 
            this.productLineAssignmentBindingSource.DataSource = typeof(WindowsFormsApp1.Algorithm.ProductLineAssignment);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_total_products_per_hour);
            this.panel3.Controls.Add(this.txt_total_accuracy);
            this.panel3.Controls.Add(this.metroLabel1);
            this.panel3.Controls.Add(this.metroLabel11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 439);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(715, 36);
            this.panel3.TabIndex = 4;
            // 
            // txt_total_products_per_hour
            // 
            this.txt_total_products_per_hour.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_total_products_per_hour.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_total_products_per_hour.CustomButton.Image = null;
            this.txt_total_products_per_hour.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.txt_total_products_per_hour.CustomButton.Name = "";
            this.txt_total_products_per_hour.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_total_products_per_hour.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_total_products_per_hour.CustomButton.TabIndex = 1;
            this.txt_total_products_per_hour.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_total_products_per_hour.CustomButton.UseSelectable = true;
            this.txt_total_products_per_hour.CustomButton.UseVisualStyleBackColor = false;
            this.txt_total_products_per_hour.CustomButton.Visible = false;
            this.txt_total_products_per_hour.Enabled = false;
            this.txt_total_products_per_hour.Lines = new string[0];
            this.txt_total_products_per_hour.Location = new System.Drawing.Point(551, 3);
            this.txt_total_products_per_hour.MaxLength = 32767;
            this.txt_total_products_per_hour.Name = "txt_total_products_per_hour";
            this.txt_total_products_per_hour.PasswordChar = '\0';
            this.txt_total_products_per_hour.ReadOnly = true;
            this.txt_total_products_per_hour.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_total_products_per_hour.SelectedText = "";
            this.txt_total_products_per_hour.SelectionLength = 0;
            this.txt_total_products_per_hour.SelectionStart = 0;
            this.txt_total_products_per_hour.ShortcutsEnabled = true;
            this.txt_total_products_per_hour.Size = new System.Drawing.Size(93, 29);
            this.txt_total_products_per_hour.TabIndex = 53;
            this.txt_total_products_per_hour.UseCustomBackColor = true;
            this.txt_total_products_per_hour.UseSelectable = true;
            this.txt_total_products_per_hour.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_total_products_per_hour.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_total_accuracy
            // 
            this.txt_total_accuracy.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_total_accuracy.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_total_accuracy.CustomButton.Image = null;
            this.txt_total_accuracy.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.txt_total_accuracy.CustomButton.Name = "";
            this.txt_total_accuracy.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_total_accuracy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_total_accuracy.CustomButton.TabIndex = 1;
            this.txt_total_accuracy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_total_accuracy.CustomButton.UseSelectable = true;
            this.txt_total_accuracy.CustomButton.UseVisualStyleBackColor = false;
            this.txt_total_accuracy.CustomButton.Visible = false;
            this.txt_total_accuracy.Enabled = false;
            this.txt_total_accuracy.Lines = new string[0];
            this.txt_total_accuracy.Location = new System.Drawing.Point(279, 4);
            this.txt_total_accuracy.MaxLength = 32767;
            this.txt_total_accuracy.Name = "txt_total_accuracy";
            this.txt_total_accuracy.PasswordChar = '\0';
            this.txt_total_accuracy.ReadOnly = true;
            this.txt_total_accuracy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_total_accuracy.SelectedText = "";
            this.txt_total_accuracy.SelectionLength = 0;
            this.txt_total_accuracy.SelectionStart = 0;
            this.txt_total_accuracy.ShortcutsEnabled = true;
            this.txt_total_accuracy.Size = new System.Drawing.Size(93, 29);
            this.txt_total_accuracy.TabIndex = 52;
            this.txt_total_accuracy.UseCustomBackColor = true;
            this.txt_total_accuracy.UseSelectable = true;
            this.txt_total_accuracy.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_total_accuracy.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.White;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel1.Location = new System.Drawing.Point(394, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(151, 15);
            this.metroLabel1.TabIndex = 51;
            this.metroLabel1.Text = "Total Productos por Hora :";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.White;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel11.Location = new System.Drawing.Point(101, 3);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(172, 15);
            this.metroLabel11.TabIndex = 50;
            this.metroLabel11.Text = "Total Cantidad Rota por Hora :";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.metroGrid1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 402);
            this.panel1.TabIndex = 5;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.execution_workers,
            this.execution_workstation,
            this.product,
            this.efficiency,
            this.time,
            this.production_line});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 0);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(715, 402);
            this.metroGrid1.TabIndex = 2;
            // 
            // execution_workers
            // 
            this.execution_workers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.execution_workers.HeaderText = "Trabajador";
            this.execution_workers.Name = "execution_workers";
            this.execution_workers.ReadOnly = true;
            // 
            // execution_workstation
            // 
            this.execution_workstation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.execution_workstation.HeaderText = "Puesto de Trabajo";
            this.execution_workstation.Name = "execution_workstation";
            this.execution_workstation.ReadOnly = true;
            // 
            // product
            // 
            this.product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product.HeaderText = "Producto";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            // 
            // efficiency
            // 
            this.efficiency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.efficiency.DefaultCellStyle = dataGridViewCellStyle2;
            this.efficiency.HeaderText = "Cantidad Rota por Hora";
            this.efficiency.Name = "efficiency";
            this.efficiency.ReadOnly = true;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time.HeaderText = "Productos por Hora";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // production_line
            // 
            this.production_line.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.production_line.HeaderText = "Linea de Producción";
            this.production_line.Name = "production_line";
            this.production_line.ReadOnly = true;
            // 
            // UC_SimulationExecution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "UC_SimulationExecution";
            this.Size = new System.Drawing.Size(715, 475);
            this.VisibleChanged += new System.EventHandler(this.UC_SimulationExecution_VisibleChanged);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productLineAssignmentBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource productLineAssignmentBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroTextBox txt_total_products_per_hour;
        private MetroFramework.Controls.MetroTextBox txt_total_accuracy;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn execution_workers;
        private System.Windows.Forms.DataGridViewTextBoxColumn execution_workstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn efficiency;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn production_line;
    }
}
