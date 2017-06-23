﻿namespace WindowsFormsApp1.Views.Warehouse_Module
{
    partial class ViewWarehouseMovementM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.registro = new MetroFramework.Controls.MetroTabPage();
            this.movementid = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.fecha = new MetroFramework.Controls.MetroTextBox();
            this.document = new MetroFramework.Controls.MetroTextBox();
            this.gb_OrderLine = new System.Windows.Forms.GroupBox();
            this.grid_movement_lines = new MetroFramework.Controls.MetroGrid();
            this.movement_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocumentLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Anular = new System.Windows.Forms.Button();
            this.document_input = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.types_movements = new MetroFramework.Controls.MetroComboBox();
            this.textbox_observation = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.registro.SuspendLayout();
            this.gb_OrderLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_movement_lines)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.registro);
            this.metroTabControl1.Location = new System.Drawing.Point(2, 1);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(865, 478);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // registro
            // 
            this.registro.Controls.Add(this.movementid);
            this.registro.Controls.Add(this.metroLabel2);
            this.registro.Controls.Add(this.fecha);
            this.registro.Controls.Add(this.document);
            this.registro.Controls.Add(this.gb_OrderLine);
            this.registro.Controls.Add(this.btn_Anular);
            this.registro.Controls.Add(this.document_input);
            this.registro.Controls.Add(this.metroLabel3);
            this.registro.Controls.Add(this.types_movements);
            this.registro.Controls.Add(this.textbox_observation);
            this.registro.Controls.Add(this.metroLabel6);
            this.registro.Controls.Add(this.metroLabel5);
            this.registro.HorizontalScrollbarBarColor = true;
            this.registro.HorizontalScrollbarHighlightOnWheel = false;
            this.registro.HorizontalScrollbarSize = 10;
            this.registro.Location = new System.Drawing.Point(4, 38);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(857, 436);
            this.registro.TabIndex = 1;
            this.registro.Text = "Ver";
            this.registro.VerticalScrollbarBarColor = true;
            this.registro.VerticalScrollbarHighlightOnWheel = false;
            this.registro.VerticalScrollbarSize = 10;
            // 
            // movementid
            // 
            // 
            // 
            // 
            this.movementid.CustomButton.Image = null;
            this.movementid.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.movementid.CustomButton.Name = "";
            this.movementid.CustomButton.Size = new System.Drawing.Size(17, 16);
            this.movementid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.movementid.CustomButton.TabIndex = 1;
            this.movementid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.movementid.CustomButton.UseSelectable = true;
            this.movementid.CustomButton.UseWaitCursor = true;
            this.movementid.CustomButton.Visible = false;
            this.movementid.Enabled = false;
            this.movementid.Lines = new string[0];
            this.movementid.Location = new System.Drawing.Point(160, 18);
            this.movementid.MaxLength = 32767;
            this.movementid.Name = "movementid";
            this.movementid.PasswordChar = '\0';
            this.movementid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.movementid.SelectedText = "";
            this.movementid.SelectionLength = 0;
            this.movementid.SelectionStart = 0;
            this.movementid.ShortcutsEnabled = true;
            this.movementid.Size = new System.Drawing.Size(200, 30);
            this.movementid.TabIndex = 69;
            this.movementid.UseSelectable = true;
            this.movementid.UseWaitCursor = true;
            this.movementid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.movementid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 26);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 19);
            this.metroLabel2.TabIndex = 68;
            this.metroLabel2.Text = "Movimiento Nro";
            // 
            // movementid
            // 
            // 
            // 
            // 
            this.movementid.CustomButton.Image = null;
            this.movementid.CustomButton.Location = new System.Drawing.Point(256, 2);
            this.movementid.CustomButton.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.movementid.CustomButton.Name = "";
            this.movementid.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.movementid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.movementid.CustomButton.TabIndex = 1;
            this.movementid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.movementid.CustomButton.UseSelectable = true;
            this.movementid.CustomButton.UseWaitCursor = true;
            this.movementid.CustomButton.Visible = false;
            this.movementid.Enabled = false;
            this.movementid.Lines = new string[0];
            this.movementid.Location = new System.Drawing.Point(240, 28);
            this.movementid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.movementid.MaxLength = 32767;
            this.movementid.Name = "movementid";
            this.movementid.PasswordChar = '\0';
            this.movementid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.movementid.SelectedText = "";
            this.movementid.SelectionLength = 0;
            this.movementid.SelectionStart = 0;
            this.movementid.ShortcutsEnabled = true;
            this.movementid.Size = new System.Drawing.Size(300, 46);
            this.movementid.TabIndex = 69;
            this.movementid.UseSelectable = true;
            this.movementid.UseWaitCursor = true;
            this.movementid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.movementid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(28, 40);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 19);
            this.metroLabel2.TabIndex = 68;
            this.metroLabel2.Text = "Movimiento Nro";
            // 
            // fecha
            // 
            // 
            // 
            // 
            this.fecha.CustomButton.Image = null;
            this.fecha.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.fecha.CustomButton.Name = "";
            this.fecha.CustomButton.Size = new System.Drawing.Size(17, 16);
            this.fecha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fecha.CustomButton.TabIndex = 1;
            this.fecha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fecha.CustomButton.UseSelectable = true;
            this.fecha.CustomButton.Visible = false;
            this.fecha.Enabled = false;
            this.fecha.Lines = new string[0];
            this.fecha.Location = new System.Drawing.Point(571, 54);
            this.fecha.MaxLength = 32767;
            this.fecha.Name = "fecha";
            this.fecha.PasswordChar = '\0';
            this.fecha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fecha.SelectedText = "";
            this.fecha.SelectionLength = 0;
            this.fecha.SelectionStart = 0;
            this.fecha.ShortcutsEnabled = true;
            this.fecha.Size = new System.Drawing.Size(200, 30);
            this.fecha.TabIndex = 67;
            this.fecha.UseSelectable = true;
            this.fecha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fecha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // document
            // 
            // 
            // 
            // 
            this.document.CustomButton.Image = null;
            this.document.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.document.CustomButton.Name = "";
            this.document.CustomButton.Size = new System.Drawing.Size(17, 16);
            this.document.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.document.CustomButton.TabIndex = 1;
            this.document.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.document.CustomButton.UseSelectable = true;
            this.document.CustomButton.Visible = false;
            this.document.Enabled = false;
            this.document.Lines = new string[0];
            this.document.Location = new System.Drawing.Point(571, 18);
            this.document.MaxLength = 32767;
            this.document.Name = "document";
            this.document.PasswordChar = '\0';
            this.document.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.document.SelectedText = "";
            this.document.SelectionLength = 0;
            this.document.SelectionStart = 0;
            this.document.ShortcutsEnabled = true;
            this.document.Size = new System.Drawing.Size(200, 30);
            this.document.TabIndex = 66;
            this.document.UseSelectable = true;
            this.document.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.document.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gb_OrderLine
            // 
            this.gb_OrderLine.BackColor = System.Drawing.Color.White;
            this.gb_OrderLine.Controls.Add(this.grid_movement_lines);
            this.gb_OrderLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_OrderLine.ForeColor = System.Drawing.Color.Black;
            this.gb_OrderLine.Location = new System.Drawing.Point(19, 194);
            this.gb_OrderLine.Name = "gb_OrderLine";
            this.gb_OrderLine.Size = new System.Drawing.Size(791, 189);
            this.gb_OrderLine.TabIndex = 65;
            this.gb_OrderLine.TabStop = false;
            this.gb_OrderLine.Text = "Detalle del Movimiento";
            // 
            // grid_movement_lines
            // 
            this.grid_movement_lines.AllowUserToResizeRows = false;
            this.grid_movement_lines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_movement_lines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_movement_lines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_movement_lines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_movement_lines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_movement_lines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movement_id,
            this.unit_price,
            this.unit_id,
            this.warehouse_id,
            this.material_id,
            this.line_id,
            this.material,
            this.unit,
            this.warehouse,
            this.stock,
            this.documentQuantity,
            this.quantity,
            this.state,
            this.idDocumentLine});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_movement_lines.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_movement_lines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_movement_lines.Enabled = false;
            this.grid_movement_lines.EnableHeadersVisualStyles = false;
            this.grid_movement_lines.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_movement_lines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_movement_lines.Location = new System.Drawing.Point(3, 16);
            this.grid_movement_lines.Name = "grid_movement_lines";
            this.grid_movement_lines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_movement_lines.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_movement_lines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid_movement_lines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_movement_lines.Size = new System.Drawing.Size(785, 170);
            this.grid_movement_lines.TabIndex = 50;
            // 
            // movement_id
            // 
            this.movement_id.DataPropertyName = "movementId";
            this.movement_id.HeaderText = "movement_id";
            this.movement_id.Name = "movement_id";
            this.movement_id.Visible = false;
            // 
            // unit_price
            // 
            this.unit_price.DataPropertyName = "unit_price";
            this.unit_price.HeaderText = "unit_price";
            this.unit_price.Name = "unit_price";
            this.unit_price.Visible = false;
            // 
            // unit_id
            // 
            this.unit_id.DataPropertyName = "unit_id";
            this.unit_id.HeaderText = "unit_id";
            this.unit_id.Name = "unit_id";
            this.unit_id.Visible = false;
            // 
            // warehouse_id
            // 
            this.warehouse_id.DataPropertyName = "warehouse_id";
            this.warehouse_id.HeaderText = "warehouse_id";
            this.warehouse_id.Name = "warehouse_id";
            this.warehouse_id.Visible = false;
            // 
            // material_id
            // 
            this.material_id.DataPropertyName = "material_id";
            this.material_id.HeaderText = "material_id";
            this.material_id.Name = "material_id";
            this.material_id.Visible = false;
            // 
            // line_id
            // 
            this.line_id.DataPropertyName = "id";
            this.line_id.HeaderText = "line_id";
            this.line_id.Name = "line_id";
            this.line_id.Visible = false;
            // 
            // material
            // 
            this.material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.material.DataPropertyName = "material_name";
            this.material.HeaderText = "Material";
            this.material.Name = "material";
            this.material.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit_name";
            this.unit.HeaderText = "Unidad de Medida";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // warehouse
            // 
            this.warehouse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.warehouse.DataPropertyName = "warehouse_name";
            this.warehouse.HeaderText = "Almacen";
            this.warehouse.Name = "warehouse";
            this.warehouse.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock.DataPropertyName = "warehouseQuantity";
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // documentQuantity
            // 
            this.documentQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.documentQuantity.DataPropertyName = "documentQuantity";
            this.documentQuantity.HeaderText = "Cantidad Documento";
            this.documentQuantity.Name = "documentQuantity";
            this.documentQuantity.ReadOnly = true;
            this.documentQuantity.Visible = false;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Cantidad";
            this.quantity.Name = "quantity";
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "Estado";
            this.state.Name = "state";
            this.state.Visible = false;
            // 
            // idDocumentLine
            // 
            this.idDocumentLine.DataPropertyName = "idDocumentLine";
            this.idDocumentLine.HeaderText = "document_line";
            this.idDocumentLine.Name = "idDocumentLine";
            this.idDocumentLine.Visible = false;
            // 
            // btn_Anular
            // 
            this.btn_Anular.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Anular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Anular.ForeColor = System.Drawing.Color.White;
            this.btn_Anular.Location = new System.Drawing.Point(592, 622);
            this.btn_Anular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Anular.Name = "btn_Anular";
            this.btn_Anular.Size = new System.Drawing.Size(123, 45);
            this.btn_Anular.TabIndex = 60;
            this.btn_Anular.Text = "Anular";
            this.btn_Anular.UseVisualStyleBackColor = false;
            this.btn_Anular.Click += new System.EventHandler(this.btn_Save_Click_1);
            // 
            // document_input
            // 
            this.document_input.AutoSize = true;
            this.document_input.Location = new System.Drawing.Point(488, 19);
            this.document_input.Name = "document_input";
            this.document_input.Size = new System.Drawing.Size(77, 19);
            this.document_input.TabIndex = 15;
            this.document_input.Text = "Documento";
            this.document_input.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(488, 58);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Fecha";
            // 
            // types_movements
            // 
            this.types_movements.Enabled = false;
            this.types_movements.FormattingEnabled = true;
            this.types_movements.ItemHeight = 23;
            this.types_movements.Location = new System.Drawing.Point(160, 63);
            this.types_movements.Name = "types_movements";
            this.types_movements.Size = new System.Drawing.Size(230, 29);
            this.types_movements.TabIndex = 9;
            this.types_movements.UseSelectable = true;
            // 
            // textbox_observation
            // 
            // 
            // 
            // 
            this.textbox_observation.CustomButton.Image = null;
            this.textbox_observation.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.textbox_observation.CustomButton.Name = "";
            this.textbox_observation.CustomButton.Size = new System.Drawing.Size(50, 49);
            this.textbox_observation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_observation.CustomButton.TabIndex = 1;
            this.textbox_observation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_observation.CustomButton.UseSelectable = true;
            this.textbox_observation.CustomButton.Visible = false;
            this.textbox_observation.Enabled = false;
            this.textbox_observation.Lines = new string[0];
            this.textbox_observation.Location = new System.Drawing.Point(160, 98);
            this.textbox_observation.MaxLength = 32767;
            this.textbox_observation.Name = "textbox_observation";
            this.textbox_observation.PasswordChar = '\0';
            this.textbox_observation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_observation.SelectedText = "";
            this.textbox_observation.SelectionLength = 0;
            this.textbox_observation.SelectionStart = 0;
            this.textbox_observation.ShortcutsEnabled = true;
            this.textbox_observation.Size = new System.Drawing.Size(284, 80);
            this.textbox_observation.TabIndex = 8;
            this.textbox_observation.UseSelectable = true;
            this.textbox_observation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_observation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(19, 96);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(83, 19);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Observacion";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(19, 63);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(128, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Tipo de Movimiento";
            // 
            // ViewWarehouseMovementM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 475);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "ViewWarehouseMovementM";
            this.Text = "Movimiento";
            this.metroTabControl1.ResumeLayout(false);
            this.registro.ResumeLayout(false);
            this.registro.PerformLayout();
            this.gb_OrderLine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_movement_lines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage registro;
        private System.Windows.Forms.Button btn_Anular;
        private MetroFramework.Controls.MetroLabel document_input;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox types_movements;
        private MetroFramework.Controls.MetroTextBox textbox_observation;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.GroupBox gb_OrderLine;
        private MetroFramework.Controls.MetroGrid grid_movement_lines;
        private MetroFramework.Controls.MetroTextBox fecha;
        private MetroFramework.Controls.MetroTextBox document;
        private System.Windows.Forms.DataGridViewTextBoxColumn movement_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn line_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocumentLine;
        private MetroFramework.Controls.MetroTextBox movementid;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}