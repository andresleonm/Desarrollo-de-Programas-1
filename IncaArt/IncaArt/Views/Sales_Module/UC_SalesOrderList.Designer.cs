namespace WindowsFormsApp1.Views
{
    partial class UC_SalesOrderList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.gb_OrderLine = new System.Windows.Forms.GroupBox();
            this.grid_order_lines = new MetroFramework.Controls.MetroGrid();
            this.idOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.cb_Currency = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.dt_DeliveryDate = new MetroFramework.Controls.MetroDateTime();
            this.btn_SearchClient = new MetroFramework.Controls.MetroTile();
            this.txt_idOrder = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gb_OrderLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_order_lines)).BeginInit();
            this.gbClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Edit);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.gb_OrderLine);
            this.panel1.Controls.Add(this.gbClient);
            this.panel1.Location = new System.Drawing.Point(9, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 607);
            this.panel1.TabIndex = 0;
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Location = new System.Drawing.Point(300, 545);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(82, 29);
            this.btn_Edit.TabIndex = 48;
            this.btn_Edit.Text = "Editar";
            this.btn_Edit.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(445, 545);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(82, 29);
            this.btn_Delete.TabIndex = 49;
            this.btn_Delete.Text = "Eliminar";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // gb_OrderLine
            // 
            this.gb_OrderLine.BackColor = System.Drawing.Color.White;
            this.gb_OrderLine.Controls.Add(this.grid_order_lines);
            this.gb_OrderLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_OrderLine.ForeColor = System.Drawing.Color.Black;
            this.gb_OrderLine.Location = new System.Drawing.Point(14, 191);
            this.gb_OrderLine.Name = "gb_OrderLine";
            this.gb_OrderLine.Size = new System.Drawing.Size(826, 321);
            this.gb_OrderLine.TabIndex = 46;
            this.gb_OrderLine.TabStop = false;
            this.gb_OrderLine.Text = "Pedidos";
            // 
            // grid_order_lines
            // 
            this.grid_order_lines.AllowUserToResizeRows = false;
            this.grid_order_lines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_order_lines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_order_lines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_order_lines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_order_lines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_order_lines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_order_lines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrder,
            this.client,
            this.observation,
            this.issueDate,
            this.deliveryDate,
            this.amount,
            this.status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_order_lines.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_order_lines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_order_lines.EnableHeadersVisualStyles = false;
            this.grid_order_lines.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_order_lines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_order_lines.Location = new System.Drawing.Point(3, 16);
            this.grid_order_lines.Name = "grid_order_lines";
            this.grid_order_lines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_order_lines.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_order_lines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid_order_lines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_order_lines.Size = new System.Drawing.Size(820, 302);
            this.grid_order_lines.TabIndex = 50;
            // 
            // idOrder
            // 
            this.idOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idOrder.HeaderText = "N° Orden";
            this.idOrder.Name = "idOrder";
            this.idOrder.ReadOnly = true;
            // 
            // client
            // 
            this.client.HeaderText = "Cliente";
            this.client.Name = "client";
            // 
            // observation
            // 
            this.observation.HeaderText = "Observación";
            this.observation.Name = "observation";
            // 
            // issueDate
            // 
            this.issueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.issueDate.HeaderText = "Fecha de Emisión";
            this.issueDate.Name = "issueDate";
            this.issueDate.ReadOnly = true;
            // 
            // deliveryDate
            // 
            this.deliveryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deliveryDate.HeaderText = "Fecha de Entrega";
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amount.HeaderText = "Total";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Estado";
            this.status.Name = "status";
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.cb_Currency);
            this.gbClient.Controls.Add(this.label2);
            this.gbClient.Controls.Add(this.btn_Search);
            this.gbClient.Controls.Add(this.metroDateTime1);
            this.gbClient.Controls.Add(this.dt_DeliveryDate);
            this.gbClient.Controls.Add(this.btn_SearchClient);
            this.gbClient.Controls.Add(this.txt_idOrder);
            this.gbClient.Controls.Add(this.label1);
            this.gbClient.Controls.Add(this.txt_name);
            this.gbClient.Controls.Add(this.label7);
            this.gbClient.Controls.Add(this.label9);
            this.gbClient.Controls.Add(this.label12);
            this.gbClient.ForeColor = System.Drawing.Color.DarkCyan;
            this.gbClient.Location = new System.Drawing.Point(14, 3);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(826, 169);
            this.gbClient.TabIndex = 40;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Filtros";
            // 
            // cb_Currency
            // 
            this.cb_Currency.FormattingEnabled = true;
            this.cb_Currency.ItemHeight = 23;
            this.cb_Currency.Location = new System.Drawing.Point(79, 118);
            this.cb_Currency.Name = "cb_Currency";
            this.cb_Currency.Size = new System.Drawing.Size(229, 29);
            this.cb_Currency.TabIndex = 52;
            this.cb_Currency.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(6, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Estado :";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(431, 119);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(85, 29);
            this.btn_Search.TabIndex = 50;
            this.btn_Search.Text = "Buscar";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(562, 24);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(209, 29);
            this.metroDateTime1.TabIndex = 49;
            // 
            // dt_DeliveryDate
            // 
            this.dt_DeliveryDate.Location = new System.Drawing.Point(562, 66);
            this.dt_DeliveryDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_DeliveryDate.Name = "dt_DeliveryDate";
            this.dt_DeliveryDate.Size = new System.Drawing.Size(209, 29);
            this.dt_DeliveryDate.TabIndex = 48;
            // 
            // btn_SearchClient
            // 
            this.btn_SearchClient.ActiveControl = null;
            this.btn_SearchClient.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_SearchClient.Location = new System.Drawing.Point(327, 73);
            this.btn_SearchClient.Name = "btn_SearchClient";
            this.btn_SearchClient.Size = new System.Drawing.Size(41, 29);
            this.btn_SearchClient.TabIndex = 43;
            this.btn_SearchClient.TileImage = global::WindowsFormsApp1.Properties.Resources.Search_16;
            this.btn_SearchClient.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SearchClient.UseCustomBackColor = true;
            this.btn_SearchClient.UseCustomForeColor = true;
            this.btn_SearchClient.UseSelectable = true;
            this.btn_SearchClient.UseStyleColors = true;
            this.btn_SearchClient.UseTileImage = true;
            // 
            // txt_idOrder
            // 
            // 
            // 
            // 
            this.txt_idOrder.CustomButton.Image = null;
            this.txt_idOrder.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.txt_idOrder.CustomButton.Name = "";
            this.txt_idOrder.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_idOrder.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_idOrder.CustomButton.TabIndex = 1;
            this.txt_idOrder.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_idOrder.CustomButton.UseSelectable = true;
            this.txt_idOrder.CustomButton.Visible = false;
            this.txt_idOrder.Lines = new string[0];
            this.txt_idOrder.Location = new System.Drawing.Point(79, 28);
            this.txt_idOrder.MaxLength = 32767;
            this.txt_idOrder.Name = "txt_idOrder";
            this.txt_idOrder.PasswordChar = '\0';
            this.txt_idOrder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_idOrder.SelectedText = "";
            this.txt_idOrder.SelectionLength = 0;
            this.txt_idOrder.SelectionStart = 0;
            this.txt_idOrder.ShortcutsEnabled = true;
            this.txt_idOrder.Size = new System.Drawing.Size(229, 29);
            this.txt_idOrder.TabIndex = 42;
            this.txt_idOrder.UseSelectable = true;
            this.txt_idOrder.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_idOrder.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(428, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Fecha de Entrega :";
            // 
            // txt_name
            // 
            // 
            // 
            // 
            this.txt_name.CustomButton.Image = null;
            this.txt_name.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.txt_name.CustomButton.Name = "";
            this.txt_name.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_name.CustomButton.TabIndex = 1;
            this.txt_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_name.CustomButton.UseSelectable = true;
            this.txt_name.CustomButton.Visible = false;
            this.txt_name.Lines = new string[0];
            this.txt_name.Location = new System.Drawing.Point(79, 73);
            this.txt_name.MaxLength = 32767;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(229, 29);
            this.txt_name.TabIndex = 38;
            this.txt_name.UseSelectable = true;
            this.txt_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "N° Orden :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(6, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Cliente :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkCyan;
            this.label12.Location = new System.Drawing.Point(428, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Fecha de Emisión :";
            // 
            // UC_SalesOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "UC_SalesOrderList";
            this.Size = new System.Drawing.Size(872, 624);
            this.Load += new System.EventHandler(this.UC_SalesOrderList_Load);
            this.panel1.ResumeLayout(false);
            this.gb_OrderLine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_order_lines)).EndInit();
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbClient;
        private MetroFramework.Controls.MetroTile btn_SearchClient;
        private MetroFramework.Controls.MetroTextBox txt_idOrder;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txt_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroDateTime dt_DeliveryDate;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox gb_OrderLine;
        private MetroFramework.Controls.MetroGrid grid_order_lines;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox cb_Currency;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn observation;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}
