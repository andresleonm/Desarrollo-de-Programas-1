namespace WindowsFormsApp1.Views.Sales_Module
{
    partial class SalesRefundSearchDocument
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.btn_Clean = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grid_Documents = new MetroFramework.Controls.MetroGrid();
            this.currency_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porc_igv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movement_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency_symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_doi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.document_id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_document_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.external_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issue_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Documents)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.metroDateTime2);
            this.groupBox1.Controls.Add(this.metroDateTime1);
            this.groupBox1.Controls.Add(this.btn_Clean);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 395);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Location = new System.Drawing.Point(554, 19);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(193, 29);
            this.metroDateTime2.TabIndex = 80;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(300, 19);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(193, 29);
            this.metroDateTime1.TabIndex = 79;
            // 
            // btn_Clean
            // 
            this.btn_Clean.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clean.ForeColor = System.Drawing.Color.White;
            this.btn_Clean.Location = new System.Drawing.Point(554, 77);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(85, 29);
            this.btn_Clean.TabIndex = 77;
            this.btn_Clean.Text = "Limpiar";
            this.btn_Clean.UseVisualStyleBackColor = false;
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(509, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Al :";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(411, 77);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(82, 29);
            this.btn_Search.TabIndex = 54;
            this.btn_Search.Text = "Buscar";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(18, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(988, 212);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Documentos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grid_Documents);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 187);
            this.panel1.TabIndex = 52;
            // 
            // grid_Documents
            // 
            this.grid_Documents.AllowUserToAddRows = false;
            this.grid_Documents.AllowUserToDeleteRows = false;
            this.grid_Documents.AllowUserToResizeRows = false;
            this.grid_Documents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_Documents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_Documents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_Documents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Documents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_Documents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Documents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currency_id,
            this.order_id,
            this.porc_igv,
            this.movement_id,
            this.currency_symbol,
            this.customer_id,
            this.customer_address,
            this.customer_phone,
            this.customer_doi,
            this.document_id2,
            this.type_document_id,
            this.tipoid,
            this.external_number,
            this.customer_name,
            this.issue_date,
            this.currency_name,
            this.amount2,
            this.observation,
            this.status});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Documents.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid_Documents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Documents.EnableHeadersVisualStyles = false;
            this.grid_Documents.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_Documents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_Documents.Location = new System.Drawing.Point(0, 0);
            this.grid_Documents.Name = "grid_Documents";
            this.grid_Documents.ReadOnly = true;
            this.grid_Documents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Documents.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_Documents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid_Documents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Documents.Size = new System.Drawing.Size(976, 187);
            this.grid_Documents.TabIndex = 53;
            // 
            // currency_id
            // 
            this.currency_id.DataPropertyName = "currency_id";
            this.currency_id.HeaderText = "currency_id";
            this.currency_id.Name = "currency_id";
            this.currency_id.ReadOnly = true;
            this.currency_id.Visible = false;
            // 
            // order_id
            // 
            this.order_id.DataPropertyName = "order_id";
            this.order_id.HeaderText = "order_id";
            this.order_id.Name = "order_id";
            this.order_id.ReadOnly = true;
            this.order_id.Visible = false;
            // 
            // porc_igv
            // 
            this.porc_igv.DataPropertyName = "porc_igv";
            this.porc_igv.HeaderText = "porc_igv";
            this.porc_igv.Name = "porc_igv";
            this.porc_igv.ReadOnly = true;
            this.porc_igv.Visible = false;
            // 
            // movement_id
            // 
            this.movement_id.DataPropertyName = "movement_id";
            this.movement_id.HeaderText = "movement_id";
            this.movement_id.Name = "movement_id";
            this.movement_id.ReadOnly = true;
            this.movement_id.Visible = false;
            // 
            // currency_symbol
            // 
            this.currency_symbol.DataPropertyName = "currency_symbol";
            this.currency_symbol.HeaderText = "currency_symbol";
            this.currency_symbol.Name = "currency_symbol";
            this.currency_symbol.ReadOnly = true;
            this.currency_symbol.Visible = false;
            // 
            // customer_id
            // 
            this.customer_id.DataPropertyName = "customer_id";
            this.customer_id.HeaderText = "customer_id";
            this.customer_id.Name = "customer_id";
            this.customer_id.ReadOnly = true;
            this.customer_id.Visible = false;
            // 
            // customer_address
            // 
            this.customer_address.DataPropertyName = "customer_address";
            this.customer_address.HeaderText = "customer_address";
            this.customer_address.Name = "customer_address";
            this.customer_address.ReadOnly = true;
            this.customer_address.Visible = false;
            // 
            // customer_phone
            // 
            this.customer_phone.DataPropertyName = "customer_phone";
            this.customer_phone.HeaderText = "customer_phone";
            this.customer_phone.Name = "customer_phone";
            this.customer_phone.ReadOnly = true;
            this.customer_phone.Visible = false;
            // 
            // customer_doi
            // 
            this.customer_doi.DataPropertyName = "customer_doi";
            this.customer_doi.HeaderText = "customer_doi";
            this.customer_doi.Name = "customer_doi";
            this.customer_doi.ReadOnly = true;
            this.customer_doi.Visible = false;
            // 
            // document_id2
            // 
            this.document_id2.DataPropertyName = "id";
            this.document_id2.HeaderText = "Documento";
            this.document_id2.Name = "document_id2";
            this.document_id2.ReadOnly = true;
            // 
            // type_document_id
            // 
            this.type_document_id.DataPropertyName = "type_name";
            this.type_document_id.HeaderText = "Tipo Documento";
            this.type_document_id.Name = "type_document_id";
            this.type_document_id.ReadOnly = true;
            // 
            // tipoid
            // 
            this.tipoid.DataPropertyName = "type_document_id";
            this.tipoid.HeaderText = "tipoid";
            this.tipoid.Name = "tipoid";
            this.tipoid.ReadOnly = true;
            this.tipoid.Visible = false;
            // 
            // external_number
            // 
            this.external_number.DataPropertyName = "external_number";
            this.external_number.HeaderText = "Numero externo";
            this.external_number.Name = "external_number";
            this.external_number.ReadOnly = true;
            // 
            // customer_name
            // 
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.HeaderText = "Cliente";
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            // 
            // issue_date
            // 
            this.issue_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.issue_date.DataPropertyName = "issue_date";
            this.issue_date.HeaderText = "Fecha de Emisión";
            this.issue_date.Name = "issue_date";
            this.issue_date.ReadOnly = true;
            // 
            // currency_name
            // 
            this.currency_name.DataPropertyName = "currency_name";
            this.currency_name.HeaderText = "Moneda";
            this.currency_name.Name = "currency_name";
            this.currency_name.ReadOnly = true;
            // 
            // amount2
            // 
            this.amount2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amount2.DataPropertyName = "amount";
            this.amount2.HeaderText = "Total";
            this.amount2.Name = "amount2";
            this.amount2.ReadOnly = true;
            // 
            // observation
            // 
            this.observation.DataPropertyName = "observation";
            this.observation.HeaderText = "Observación";
            this.observation.Name = "observation";
            this.observation.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Estado";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(554, 347);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(85, 29);
            this.btn_Cancel.TabIndex = 17;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(411, 347);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(82, 29);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "Grabar";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(244, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha :";
            // 
            // SalesRefundSearchDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 416);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalesRefundSearchDocument";
            this.Text = "SalesRefundSearchDocument";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Documents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.Button btn_Clean;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroGrid grid_Documents;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn porc_igv;
        private System.Windows.Forms.DataGridViewTextBoxColumn movement_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency_symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_doi;
        private System.Windows.Forms.DataGridViewTextBoxColumn document_id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_document_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn external_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount2;
        private System.Windows.Forms.DataGridViewTextBoxColumn observation;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}