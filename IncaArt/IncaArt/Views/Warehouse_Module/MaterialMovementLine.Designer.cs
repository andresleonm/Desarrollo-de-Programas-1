namespace WindowsFormsApp1.Views.Warehouse_Module
{
    partial class MaterialMovementLine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_OrderLine = new System.Windows.Forms.GroupBox();
            this.grid_materials = new MetroFramework.Controls.MetroGrid();
            this.btn_Add = new System.Windows.Forms.Button();
            this.materials = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gb_OrderLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_materials)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_OrderLine
            // 
            this.gb_OrderLine.BackColor = System.Drawing.Color.White;
            this.gb_OrderLine.Controls.Add(this.grid_materials);
            this.gb_OrderLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_OrderLine.ForeColor = System.Drawing.Color.Black;
            this.gb_OrderLine.Location = new System.Drawing.Point(12, 56);
            this.gb_OrderLine.Name = "gb_OrderLine";
            this.gb_OrderLine.Size = new System.Drawing.Size(962, 189);
            this.gb_OrderLine.TabIndex = 65;
            this.gb_OrderLine.TabStop = false;
            this.gb_OrderLine.Text = "Detalle del Movimiento";
            // 
            // grid_materials
            // 
            this.grid_materials.AllowUserToAddRows = false;
            this.grid_materials.AllowUserToResizeRows = false;
            this.grid_materials.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_materials.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_materials.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.grid_materials.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_materials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_materials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_materials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Type_id,
            this.Material_id,
            this.state,
            this.unitId,
            this.material,
            this.unit,
            this.warehouse,
            this.stockF,
            this.stockL,
            this.capacity,
            this.quantity,
            this.select});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_materials.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid_materials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_materials.EnableHeadersVisualStyles = false;
            this.grid_materials.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_materials.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_materials.Location = new System.Drawing.Point(3, 16);
            this.grid_materials.Name = "grid_materials";
            this.grid_materials.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_materials.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_materials.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid_materials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_materials.Size = new System.Drawing.Size(956, 170);
            this.grid_materials.TabIndex = 50;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(494, 274);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(82, 29);
            this.btn_Add.TabIndex = 66;
            this.btn_Add.Text = "Agregar";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // materials
            // 
            this.materials.FormattingEnabled = true;
            this.materials.ItemHeight = 23;
            this.materials.Location = new System.Drawing.Point(155, 12);
            this.materials.Name = "materials";
            this.materials.Size = new System.Drawing.Size(230, 29);
            this.materials.TabIndex = 52;
            this.materials.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(14, 12);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(63, 19);
            this.metroLabel5.TabIndex = 51;
            this.metroLabel5.Text = "Materialo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(419, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 29);
            this.button1.TabIndex = 67;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Type_id
            // 
            this.Type_id.DataPropertyName = "type_id";
            this.Type_id.HeaderText = "Type_id";
            this.Type_id.Name = "Type_id";
            this.Type_id.Visible = false;
            // 
            // Material_id
            // 
            this.Material_id.DataPropertyName = "material_id";
            this.Material_id.HeaderText = "Material_id";
            this.Material_id.Name = "Material_id";
            this.Material_id.Visible = false;
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "state";
            this.state.Name = "state";
            this.state.Visible = false;
            // 
            // unitId
            // 
            this.unitId.DataPropertyName = "unitId";
            this.unitId.HeaderText = "unitId";
            this.unitId.Name = "unitId";
            this.unitId.Visible = false;
            // 
            // material
            // 
            this.material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.material.DataPropertyName = "materialName";
            this.material.FillWeight = 150F;
            this.material.HeaderText = "Materialo";
            this.material.Name = "material";
            this.material.ReadOnly = true;
            this.material.Width = 77;
            // 
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.unit.DataPropertyName = "unitName";
            this.unit.HeaderText = "Unidad de Medida";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Width = 115;
            // 
            // warehouse
            // 
            this.warehouse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.warehouse.DataPropertyName = "name";
            this.warehouse.HeaderText = "Almacen";
            this.warehouse.Name = "warehouse";
            this.warehouse.ReadOnly = true;
            // 
            // stockF
            // 
            this.stockF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.stockF.DataPropertyName = "current_physical_stock";
            this.stockF.HeaderText = "Stock Fisico";
            this.stockF.Name = "stockF";
            this.stockF.ReadOnly = true;
            this.stockF.Width = 83;
            // 
            // stockL
            // 
            this.stockL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.stockL.DataPropertyName = "current_logical_stock";
            this.stockL.HeaderText = "Stock Logico";
            this.stockL.Name = "stockL";
            this.stockL.Width = 87;
            // 
            // capacity
            // 
            this.capacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.capacity.DataPropertyName = "max_capacity";
            this.capacity.HeaderText = "Capacidad Maxima";
            this.capacity.Name = "capacity";
            this.capacity.Width = 115;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Cantidad";
            this.quantity.Name = "quantity";
            this.quantity.Width = 77;
            // 
            // select
            // 
            this.select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.select.DataPropertyName = "selected";
            this.select.HeaderText = "Seleccionar";
            this.select.Name = "select";
            this.select.Width = 69;
            // 
            // MaterialMovementLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1009, 315);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.materials);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.gb_OrderLine);
            this.Name = "MaterialMovementLine";
            this.Text = "Línea de Venta";
           
            this.gb_OrderLine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_materials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_OrderLine;
        private MetroFramework.Controls.MetroGrid grid_materials;
        private System.Windows.Forms.Button btn_Add;
        private MetroFramework.Controls.MetroComboBox materials;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockF;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockL;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
    }
}