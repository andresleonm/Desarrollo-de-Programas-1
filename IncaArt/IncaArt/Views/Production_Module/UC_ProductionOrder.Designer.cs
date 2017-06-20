namespace WindowsFormsApp1.Views
{
    partial class UC_ProductionOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroTextBox_Estimate_line = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel_Estimate_line = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_Estimate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel_estimate = new MetroFramework.Controls.MetroLabel();
            this.label_Unit3 = new System.Windows.Forms.Label();
            this.label_Unit2 = new System.Windows.Forms.Label();
            this.label_Unit = new System.Windows.Forms.Label();
            this.metroTextBox_Quantity_warehouse = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_Quantity_produced = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.comboBox_Warehouse = new System.Windows.Forms.ComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.comboBox_Recipe = new System.Windows.Forms.ComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_Quantity = new MetroFramework.Controls.MetroTextBox();
            this.comboBox_Product = new System.Windows.Forms.ComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_OrderNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel_numOrder = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_Observation = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_Description = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime_Begin = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime_End = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage_Materials = new MetroFramework.Controls.MetroTabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.metroButton_DeleteMaterial = new MetroFramework.Controls.MetroButton();
            this.metroButton_EditMaterial = new MetroFramework.Controls.MetroButton();
            this.metroButton_AddMaterial = new MetroFramework.Controls.MetroButton();
            this.metroGrid_Material = new MetroFramework.Controls.MetroGrid();
            this.idMaterialLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_required = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_taken_real = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_id_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_name_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse_id_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse_name_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.metroTabPage_Workers = new System.Windows.Forms.TabPage();
            this.metroButton_DeleteWork = new MetroFramework.Controls.MetroButton();
            this.metroButton_EditWork = new MetroFramework.Controls.MetroButton();
            this.metroButton_AddWorker = new MetroFramework.Controls.MetroButton();
            this.metroGrid_Work = new MetroFramework.Controls.MetroGrid();
            this.idWorkLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worker_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worker_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workstation_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workstation_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_id_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_name_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroGrid_materials_summary = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroGrid_products_summary = new MetroFramework.Controls.MetroGrid();
            this.metroButton_Cancel = new MetroFramework.Controls.MetroButton();
            this.metroButton_Register = new MetroFramework.Controls.MetroButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage_Materials.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_Material)).BeginInit();
            this.metroTabPage_Workers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_Work)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_materials_summary)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_products_summary)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.metroButton_Cancel);
            this.panel1.Controls.Add(this.metroButton_Register);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 645);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.metroTabControl1);
            this.groupBox2.Location = new System.Drawing.Point(11, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 581);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.metroTextBox_Estimate_line);
            this.groupBox1.Controls.Add(this.metroLabel_Estimate_line);
            this.groupBox1.Controls.Add(this.metroTextBox_Estimate);
            this.groupBox1.Controls.Add(this.metroLabel_estimate);
            this.groupBox1.Controls.Add(this.label_Unit3);
            this.groupBox1.Controls.Add(this.label_Unit2);
            this.groupBox1.Controls.Add(this.label_Unit);
            this.groupBox1.Controls.Add(this.metroTextBox_Quantity_warehouse);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.metroTextBox_Quantity_produced);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.comboBox_Warehouse);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.comboBox_Recipe);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroTextBox_Quantity);
            this.groupBox1.Controls.Add(this.comboBox_Product);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroTextBox_OrderNumber);
            this.groupBox1.Controls.Add(this.metroLabel_numOrder);
            this.groupBox1.Controls.Add(this.metroTextBox_Observation);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroTextBox_Description);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroDateTime_Begin);
            this.groupBox1.Controls.Add(this.metroDateTime_End);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 270);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la orden de producción";
            // 
            // metroTextBox_Estimate_line
            // 
            this.metroTextBox_Estimate_line.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.metroTextBox_Estimate_line.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.metroTextBox_Estimate_line.CustomButton.Image = null;
            this.metroTextBox_Estimate_line.CustomButton.Location = new System.Drawing.Point(55, 1);
            this.metroTextBox_Estimate_line.CustomButton.Name = "";
            this.metroTextBox_Estimate_line.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBox_Estimate_line.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Estimate_line.CustomButton.TabIndex = 1;
            this.metroTextBox_Estimate_line.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Estimate_line.CustomButton.UseSelectable = true;
            this.metroTextBox_Estimate_line.CustomButton.UseVisualStyleBackColor = false;
            this.metroTextBox_Estimate_line.CustomButton.Visible = false;
            this.metroTextBox_Estimate_line.Lines = new string[0];
            this.metroTextBox_Estimate_line.Location = new System.Drawing.Point(562, 25);
            this.metroTextBox_Estimate_line.MaxLength = 8;
            this.metroTextBox_Estimate_line.Name = "metroTextBox_Estimate_line";
            this.metroTextBox_Estimate_line.PasswordChar = '\0';
            this.metroTextBox_Estimate_line.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Estimate_line.SelectedText = "";
            this.metroTextBox_Estimate_line.SelectionLength = 0;
            this.metroTextBox_Estimate_line.SelectionStart = 0;
            this.metroTextBox_Estimate_line.ShortcutsEnabled = true;
            this.metroTextBox_Estimate_line.Size = new System.Drawing.Size(75, 21);
            this.metroTextBox_Estimate_line.TabIndex = 73;
            this.metroTextBox_Estimate_line.UseCustomBackColor = true;
            this.metroTextBox_Estimate_line.UseSelectable = true;
            this.metroTextBox_Estimate_line.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Estimate_line.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox_Estimate_line.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox_Estimate_line_KeyPress);
            // 
            // metroLabel_Estimate_line
            // 
            this.metroLabel_Estimate_line.AutoSize = true;
            this.metroLabel_Estimate_line.BackColor = System.Drawing.SystemColors.Window;
            this.metroLabel_Estimate_line.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel_Estimate_line.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel_Estimate_line.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel_Estimate_line.Location = new System.Drawing.Point(483, 25);
            this.metroLabel_Estimate_line.Name = "metroLabel_Estimate_line";
            this.metroLabel_Estimate_line.Size = new System.Drawing.Size(56, 15);
            this.metroLabel_Estimate_line.TabIndex = 72;
            this.metroLabel_Estimate_line.Text = "Nº Línea:";
            this.metroLabel_Estimate_line.UseCustomBackColor = true;
            this.metroLabel_Estimate_line.UseCustomForeColor = true;
            // 
            // metroTextBox_Estimate
            // 
            this.metroTextBox_Estimate.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.metroTextBox_Estimate.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.metroTextBox_Estimate.CustomButton.Image = null;
            this.metroTextBox_Estimate.CustomButton.Location = new System.Drawing.Point(55, 1);
            this.metroTextBox_Estimate.CustomButton.Name = "";
            this.metroTextBox_Estimate.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBox_Estimate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Estimate.CustomButton.TabIndex = 1;
            this.metroTextBox_Estimate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Estimate.CustomButton.UseSelectable = true;
            this.metroTextBox_Estimate.CustomButton.UseVisualStyleBackColor = false;
            this.metroTextBox_Estimate.CustomButton.Visible = false;
            this.metroTextBox_Estimate.Lines = new string[0];
            this.metroTextBox_Estimate.Location = new System.Drawing.Point(360, 25);
            this.metroTextBox_Estimate.MaxLength = 8;
            this.metroTextBox_Estimate.Name = "metroTextBox_Estimate";
            this.metroTextBox_Estimate.PasswordChar = '\0';
            this.metroTextBox_Estimate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Estimate.SelectedText = "";
            this.metroTextBox_Estimate.SelectionLength = 0;
            this.metroTextBox_Estimate.SelectionStart = 0;
            this.metroTextBox_Estimate.ShortcutsEnabled = true;
            this.metroTextBox_Estimate.Size = new System.Drawing.Size(75, 21);
            this.metroTextBox_Estimate.TabIndex = 71;
            this.metroTextBox_Estimate.UseCustomBackColor = true;
            this.metroTextBox_Estimate.UseSelectable = true;
            this.metroTextBox_Estimate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Estimate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox_Estimate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox_Estimate_KeyPress);
            // 
            // metroLabel_estimate
            // 
            this.metroLabel_estimate.AutoSize = true;
            this.metroLabel_estimate.BackColor = System.Drawing.SystemColors.Window;
            this.metroLabel_estimate.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel_estimate.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel_estimate.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel_estimate.Location = new System.Drawing.Point(253, 25);
            this.metroLabel_estimate.Name = "metroLabel_estimate";
            this.metroLabel_estimate.Size = new System.Drawing.Size(84, 15);
            this.metroLabel_estimate.TabIndex = 70;
            this.metroLabel_estimate.Text = "Nº Cotización:";
            this.metroLabel_estimate.UseCustomBackColor = true;
            this.metroLabel_estimate.UseCustomForeColor = true;
            // 
            // label_Unit3
            // 
            this.label_Unit3.AutoSize = true;
            this.label_Unit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Unit3.Location = new System.Drawing.Point(656, 184);
            this.label_Unit3.Name = "label_Unit3";
            this.label_Unit3.Size = new System.Drawing.Size(0, 13);
            this.label_Unit3.TabIndex = 69;
            // 
            // label_Unit2
            // 
            this.label_Unit2.AutoSize = true;
            this.label_Unit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Unit2.Location = new System.Drawing.Point(656, 131);
            this.label_Unit2.Name = "label_Unit2";
            this.label_Unit2.Size = new System.Drawing.Size(0, 13);
            this.label_Unit2.TabIndex = 68;
            // 
            // label_Unit
            // 
            this.label_Unit.AutoSize = true;
            this.label_Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Unit.Location = new System.Drawing.Point(414, 131);
            this.label_Unit.Name = "label_Unit";
            this.label_Unit.Size = new System.Drawing.Size(0, 13);
            this.label_Unit.TabIndex = 67;
            // 
            // metroTextBox_Quantity_warehouse
            // 
            this.metroTextBox_Quantity_warehouse.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.metroTextBox_Quantity_warehouse.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.metroTextBox_Quantity_warehouse.CustomButton.Image = null;
            this.metroTextBox_Quantity_warehouse.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.metroTextBox_Quantity_warehouse.CustomButton.Name = "";
            this.metroTextBox_Quantity_warehouse.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBox_Quantity_warehouse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Quantity_warehouse.CustomButton.TabIndex = 1;
            this.metroTextBox_Quantity_warehouse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Quantity_warehouse.CustomButton.UseSelectable = true;
            this.metroTextBox_Quantity_warehouse.CustomButton.UseVisualStyleBackColor = false;
            this.metroTextBox_Quantity_warehouse.CustomButton.Visible = false;
            this.metroTextBox_Quantity_warehouse.Lines = new string[0];
            this.metroTextBox_Quantity_warehouse.Location = new System.Drawing.Point(562, 176);
            this.metroTextBox_Quantity_warehouse.MaxLength = 8;
            this.metroTextBox_Quantity_warehouse.Name = "metroTextBox_Quantity_warehouse";
            this.metroTextBox_Quantity_warehouse.PasswordChar = '\0';
            this.metroTextBox_Quantity_warehouse.ReadOnly = true;
            this.metroTextBox_Quantity_warehouse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Quantity_warehouse.SelectedText = "";
            this.metroTextBox_Quantity_warehouse.SelectionLength = 0;
            this.metroTextBox_Quantity_warehouse.SelectionStart = 0;
            this.metroTextBox_Quantity_warehouse.ShortcutsEnabled = true;
            this.metroTextBox_Quantity_warehouse.Size = new System.Drawing.Size(88, 21);
            this.metroTextBox_Quantity_warehouse.TabIndex = 66;
            this.metroTextBox_Quantity_warehouse.UseCustomBackColor = true;
            this.metroTextBox_Quantity_warehouse.UseSelectable = true;
            this.metroTextBox_Quantity_warehouse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Quantity_warehouse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel10.Location = new System.Drawing.Point(485, 170);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(72, 35);
            this.metroLabel10.TabIndex = 65;
            this.metroLabel10.Text = "Cantidad en almacén :";
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.UseCustomForeColor = true;
            this.metroLabel10.WrapToLine = true;
            // 
            // metroTextBox_Quantity_produced
            // 
            this.metroTextBox_Quantity_produced.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.metroTextBox_Quantity_produced.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.metroTextBox_Quantity_produced.CustomButton.Image = null;
            this.metroTextBox_Quantity_produced.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.metroTextBox_Quantity_produced.CustomButton.Name = "";
            this.metroTextBox_Quantity_produced.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBox_Quantity_produced.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Quantity_produced.CustomButton.TabIndex = 1;
            this.metroTextBox_Quantity_produced.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Quantity_produced.CustomButton.UseSelectable = true;
            this.metroTextBox_Quantity_produced.CustomButton.UseVisualStyleBackColor = false;
            this.metroTextBox_Quantity_produced.CustomButton.Visible = false;
            this.metroTextBox_Quantity_produced.Lines = new string[0];
            this.metroTextBox_Quantity_produced.Location = new System.Drawing.Point(562, 128);
            this.metroTextBox_Quantity_produced.MaxLength = 8;
            this.metroTextBox_Quantity_produced.Name = "metroTextBox_Quantity_produced";
            this.metroTextBox_Quantity_produced.PasswordChar = '\0';
            this.metroTextBox_Quantity_produced.ReadOnly = true;
            this.metroTextBox_Quantity_produced.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Quantity_produced.SelectedText = "";
            this.metroTextBox_Quantity_produced.SelectionLength = 0;
            this.metroTextBox_Quantity_produced.SelectionStart = 0;
            this.metroTextBox_Quantity_produced.ShortcutsEnabled = true;
            this.metroTextBox_Quantity_produced.Size = new System.Drawing.Size(88, 21);
            this.metroTextBox_Quantity_produced.TabIndex = 64;
            this.metroTextBox_Quantity_produced.UseCustomBackColor = true;
            this.metroTextBox_Quantity_produced.UseSelectable = true;
            this.metroTextBox_Quantity_produced.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Quantity_produced.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel9.Location = new System.Drawing.Point(473, 121);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(94, 49);
            this.metroLabel9.TabIndex = 63;
            this.metroLabel9.Text = "Cantidad producida :";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            this.metroLabel9.WrapToLine = true;
            // 
            // comboBox_Warehouse
            // 
            this.comboBox_Warehouse.FormattingEnabled = true;
            this.comboBox_Warehouse.Location = new System.Drawing.Point(320, 176);
            this.comboBox_Warehouse.Name = "comboBox_Warehouse";
            this.comboBox_Warehouse.Size = new System.Drawing.Size(153, 21);
            this.comboBox_Warehouse.TabIndex = 62;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel4.Location = new System.Drawing.Point(253, 176);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(61, 15);
            this.metroLabel4.TabIndex = 61;
            this.metroLabel4.Text = "Almacén :";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // comboBox_Recipe
            // 
            this.comboBox_Recipe.FormattingEnabled = true;
            this.comboBox_Recipe.Location = new System.Drawing.Point(100, 170);
            this.comboBox_Recipe.Name = "comboBox_Recipe";
            this.comboBox_Recipe.Size = new System.Drawing.Size(147, 21);
            this.comboBox_Recipe.TabIndex = 60;
            this.comboBox_Recipe.SelectedIndexChanged += new System.EventHandler(this.comboBox_Recipe_SelectedIndexChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel6.Location = new System.Drawing.Point(13, 170);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(52, 15);
            this.metroLabel6.TabIndex = 59;
            this.metroLabel6.Text = "Receta :";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroTextBox_Quantity
            // 
            this.metroTextBox_Quantity.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.metroTextBox_Quantity.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.metroTextBox_Quantity.CustomButton.Image = null;
            this.metroTextBox_Quantity.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.metroTextBox_Quantity.CustomButton.Name = "";
            this.metroTextBox_Quantity.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBox_Quantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Quantity.CustomButton.TabIndex = 1;
            this.metroTextBox_Quantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Quantity.CustomButton.UseSelectable = true;
            this.metroTextBox_Quantity.CustomButton.UseVisualStyleBackColor = false;
            this.metroTextBox_Quantity.CustomButton.Visible = false;
            this.metroTextBox_Quantity.Lines = new string[0];
            this.metroTextBox_Quantity.Location = new System.Drawing.Point(320, 128);
            this.metroTextBox_Quantity.MaxLength = 8;
            this.metroTextBox_Quantity.Name = "metroTextBox_Quantity";
            this.metroTextBox_Quantity.PasswordChar = '\0';
            this.metroTextBox_Quantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Quantity.SelectedText = "";
            this.metroTextBox_Quantity.SelectionLength = 0;
            this.metroTextBox_Quantity.SelectionStart = 0;
            this.metroTextBox_Quantity.ShortcutsEnabled = true;
            this.metroTextBox_Quantity.Size = new System.Drawing.Size(88, 21);
            this.metroTextBox_Quantity.TabIndex = 58;
            this.metroTextBox_Quantity.UseCustomBackColor = true;
            this.metroTextBox_Quantity.UseSelectable = true;
            this.metroTextBox_Quantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Quantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox_Quantity.TextChanged += new System.EventHandler(this.metroTextBox_Quantity_TextChanged);
            this.metroTextBox_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox_Quantity_KeyPress);
            // 
            // comboBox_Product
            // 
            this.comboBox_Product.FormattingEnabled = true;
            this.comboBox_Product.Location = new System.Drawing.Point(100, 128);
            this.comboBox_Product.Name = "comboBox_Product";
            this.comboBox_Product.Size = new System.Drawing.Size(147, 21);
            this.comboBox_Product.TabIndex = 57;
            this.comboBox_Product.SelectedIndexChanged += new System.EventHandler(this.comboBox_Product_SelectedIndexChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel7.Location = new System.Drawing.Point(253, 128);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(61, 15);
            this.metroLabel7.TabIndex = 56;
            this.metroLabel7.Text = "Cantidad :";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel8.Location = new System.Drawing.Point(13, 131);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(64, 15);
            this.metroLabel8.TabIndex = 55;
            this.metroLabel8.Text = "Producto :";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // metroTextBox_OrderNumber
            // 
            this.metroTextBox_OrderNumber.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.metroTextBox_OrderNumber.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.metroTextBox_OrderNumber.CustomButton.Image = null;
            this.metroTextBox_OrderNumber.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.metroTextBox_OrderNumber.CustomButton.Name = "";
            this.metroTextBox_OrderNumber.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBox_OrderNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_OrderNumber.CustomButton.TabIndex = 1;
            this.metroTextBox_OrderNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_OrderNumber.CustomButton.UseSelectable = true;
            this.metroTextBox_OrderNumber.CustomButton.UseVisualStyleBackColor = false;
            this.metroTextBox_OrderNumber.CustomButton.Visible = false;
            this.metroTextBox_OrderNumber.Enabled = false;
            this.metroTextBox_OrderNumber.Lines = new string[0];
            this.metroTextBox_OrderNumber.Location = new System.Drawing.Point(100, 25);
            this.metroTextBox_OrderNumber.MaxLength = 32767;
            this.metroTextBox_OrderNumber.Name = "metroTextBox_OrderNumber";
            this.metroTextBox_OrderNumber.PasswordChar = '\0';
            this.metroTextBox_OrderNumber.ReadOnly = true;
            this.metroTextBox_OrderNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_OrderNumber.SelectedText = "";
            this.metroTextBox_OrderNumber.SelectionLength = 0;
            this.metroTextBox_OrderNumber.SelectionStart = 0;
            this.metroTextBox_OrderNumber.ShortcutsEnabled = true;
            this.metroTextBox_OrderNumber.Size = new System.Drawing.Size(78, 21);
            this.metroTextBox_OrderNumber.TabIndex = 54;
            this.metroTextBox_OrderNumber.UseCustomBackColor = true;
            this.metroTextBox_OrderNumber.UseSelectable = true;
            this.metroTextBox_OrderNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_OrderNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel_numOrder
            // 
            this.metroLabel_numOrder.AutoSize = true;
            this.metroLabel_numOrder.BackColor = System.Drawing.SystemColors.Window;
            this.metroLabel_numOrder.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel_numOrder.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel_numOrder.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel_numOrder.Location = new System.Drawing.Point(10, 25);
            this.metroLabel_numOrder.Name = "metroLabel_numOrder";
            this.metroLabel_numOrder.Size = new System.Drawing.Size(62, 15);
            this.metroLabel_numOrder.TabIndex = 53;
            this.metroLabel_numOrder.Text = "Nº Orden:";
            this.metroLabel_numOrder.UseCustomBackColor = true;
            this.metroLabel_numOrder.UseCustomForeColor = true;
            // 
            // metroTextBox_Observation
            // 
            this.metroTextBox_Observation.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.metroTextBox_Observation.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.metroTextBox_Observation.CustomButton.Image = null;
            this.metroTextBox_Observation.CustomButton.Location = new System.Drawing.Point(544, 2);
            this.metroTextBox_Observation.CustomButton.Name = "";
            this.metroTextBox_Observation.CustomButton.Size = new System.Drawing.Size(53, 53);
            this.metroTextBox_Observation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Observation.CustomButton.TabIndex = 1;
            this.metroTextBox_Observation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Observation.CustomButton.UseSelectable = true;
            this.metroTextBox_Observation.CustomButton.UseVisualStyleBackColor = false;
            this.metroTextBox_Observation.CustomButton.Visible = false;
            this.metroTextBox_Observation.Lines = new string[0];
            this.metroTextBox_Observation.Location = new System.Drawing.Point(103, 206);
            this.metroTextBox_Observation.MaxLength = 600;
            this.metroTextBox_Observation.Multiline = true;
            this.metroTextBox_Observation.Name = "metroTextBox_Observation";
            this.metroTextBox_Observation.PasswordChar = '\0';
            this.metroTextBox_Observation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroTextBox_Observation.SelectedText = "";
            this.metroTextBox_Observation.SelectionLength = 0;
            this.metroTextBox_Observation.SelectionStart = 0;
            this.metroTextBox_Observation.ShortcutsEnabled = true;
            this.metroTextBox_Observation.Size = new System.Drawing.Size(600, 58);
            this.metroTextBox_Observation.TabIndex = 50;
            this.metroTextBox_Observation.UseCustomBackColor = true;
            this.metroTextBox_Observation.UseSelectable = true;
            this.metroTextBox_Observation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Observation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel3.Location = new System.Drawing.Point(7, 225);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 15);
            this.metroLabel3.TabIndex = 49;
            this.metroLabel3.Text = "Observaciones:";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroTextBox_Description
            // 
            this.metroTextBox_Description.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.metroTextBox_Description.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.metroTextBox_Description.CustomButton.Image = null;
            this.metroTextBox_Description.CustomButton.Location = new System.Drawing.Point(575, 1);
            this.metroTextBox_Description.CustomButton.Name = "";
            this.metroTextBox_Description.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBox_Description.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Description.CustomButton.TabIndex = 1;
            this.metroTextBox_Description.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Description.CustomButton.UseSelectable = true;
            this.metroTextBox_Description.CustomButton.UseVisualStyleBackColor = false;
            this.metroTextBox_Description.CustomButton.Visible = false;
            this.metroTextBox_Description.Lines = new string[0];
            this.metroTextBox_Description.Location = new System.Drawing.Point(100, 89);
            this.metroTextBox_Description.MaxLength = 15;
            this.metroTextBox_Description.Name = "metroTextBox_Description";
            this.metroTextBox_Description.PasswordChar = '\0';
            this.metroTextBox_Description.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Description.SelectedText = "";
            this.metroTextBox_Description.SelectionLength = 0;
            this.metroTextBox_Description.SelectionStart = 0;
            this.metroTextBox_Description.ShortcutsEnabled = true;
            this.metroTextBox_Description.Size = new System.Drawing.Size(603, 29);
            this.metroTextBox_Description.TabIndex = 48;
            this.metroTextBox_Description.UseCustomBackColor = true;
            this.metroTextBox_Description.UseSelectable = true;
            this.metroTextBox_Description.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Description.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox_Description.Validating += new System.ComponentModel.CancelEventHandler(this.metroTextBox_Description_Validating);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel5.Location = new System.Drawing.Point(10, 89);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(75, 15);
            this.metroLabel5.TabIndex = 42;
            this.metroLabel5.Text = "Descripción:";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroDateTime_Begin
            // 
            this.metroDateTime_Begin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime_Begin.Location = new System.Drawing.Point(100, 52);
            this.metroDateTime_Begin.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime_Begin.Name = "metroDateTime_Begin";
            this.metroDateTime_Begin.Size = new System.Drawing.Size(146, 29);
            this.metroDateTime_Begin.TabIndex = 41;
            this.metroDateTime_Begin.Validating += new System.ComponentModel.CancelEventHandler(this.metroDateTime_Begin_Validating);
            // 
            // metroDateTime_End
            // 
            this.metroDateTime_End.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime_End.Location = new System.Drawing.Point(562, 52);
            this.metroDateTime_End.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime_End.Name = "metroDateTime_End";
            this.metroDateTime_End.Size = new System.Drawing.Size(142, 29);
            this.metroDateTime_End.TabIndex = 40;
            this.metroDateTime_End.Validating += new System.ComponentModel.CancelEventHandler(this.metroDateTime_End_Validating);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel2.Location = new System.Drawing.Point(458, 54);
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
            this.metroLabel1.Location = new System.Drawing.Point(11, 54);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 15);
            this.metroLabel1.TabIndex = 34;
            this.metroLabel1.Text = "Fecha inicio:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.metroTabPage_Materials);
            this.metroTabControl1.Controls.Add(this.metroTabPage_Workers);
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.metroTabControl1.HotTrack = true;
            this.metroTabControl1.ItemSize = new System.Drawing.Size(135, 25);
            this.metroTabControl1.Location = new System.Drawing.Point(6, 283);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(732, 294);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTabControl1.TabIndex = 33;
            this.metroTabControl1.UseCustomBackColor = true;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage_Materials
            // 
            this.metroTabPage_Materials.Controls.Add(this.panel4);
            this.metroTabPage_Materials.HorizontalScrollbarBarColor = true;
            this.metroTabPage_Materials.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage_Materials.HorizontalScrollbarSize = 10;
            this.metroTabPage_Materials.Location = new System.Drawing.Point(4, 29);
            this.metroTabPage_Materials.Name = "metroTabPage_Materials";
            this.metroTabPage_Materials.Size = new System.Drawing.Size(724, 261);
            this.metroTabPage_Materials.TabIndex = 1;
            this.metroTabPage_Materials.Text = "Materiales";
            this.metroTabPage_Materials.VerticalScrollbarBarColor = true;
            this.metroTabPage_Materials.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage_Materials.VerticalScrollbarSize = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.metroButton_DeleteMaterial);
            this.panel4.Controls.Add(this.metroButton_EditMaterial);
            this.panel4.Controls.Add(this.metroButton_AddMaterial);
            this.panel4.Controls.Add(this.metroGrid_Material);
            this.panel4.Controls.Add(this.richTextBox1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(750, 345);
            this.panel4.TabIndex = 2;
            // 
            // metroButton_DeleteMaterial
            // 
            this.metroButton_DeleteMaterial.BackColor = System.Drawing.Color.DarkCyan;
            this.metroButton_DeleteMaterial.ForeColor = System.Drawing.Color.White;
            this.metroButton_DeleteMaterial.Highlight = true;
            this.metroButton_DeleteMaterial.Location = new System.Drawing.Point(629, 5);
            this.metroButton_DeleteMaterial.Name = "metroButton_DeleteMaterial";
            this.metroButton_DeleteMaterial.Size = new System.Drawing.Size(75, 23);
            this.metroButton_DeleteMaterial.Style = MetroFramework.MetroColorStyle.White;
            this.metroButton_DeleteMaterial.TabIndex = 61;
            this.metroButton_DeleteMaterial.Text = "Eliminar";
            this.metroButton_DeleteMaterial.UseCustomBackColor = true;
            this.metroButton_DeleteMaterial.UseCustomForeColor = true;
            this.metroButton_DeleteMaterial.UseSelectable = true;
            this.metroButton_DeleteMaterial.UseStyleColors = true;
            this.metroButton_DeleteMaterial.Click += new System.EventHandler(this.metroButton_DeleteMaterial_Click);
            // 
            // metroButton_EditMaterial
            // 
            this.metroButton_EditMaterial.BackColor = System.Drawing.Color.DarkCyan;
            this.metroButton_EditMaterial.ForeColor = System.Drawing.Color.White;
            this.metroButton_EditMaterial.Highlight = true;
            this.metroButton_EditMaterial.Location = new System.Drawing.Point(548, 5);
            this.metroButton_EditMaterial.Name = "metroButton_EditMaterial";
            this.metroButton_EditMaterial.Size = new System.Drawing.Size(75, 23);
            this.metroButton_EditMaterial.Style = MetroFramework.MetroColorStyle.White;
            this.metroButton_EditMaterial.TabIndex = 60;
            this.metroButton_EditMaterial.Text = "Editar";
            this.metroButton_EditMaterial.UseCustomBackColor = true;
            this.metroButton_EditMaterial.UseCustomForeColor = true;
            this.metroButton_EditMaterial.UseSelectable = true;
            this.metroButton_EditMaterial.UseStyleColors = true;
            this.metroButton_EditMaterial.Click += new System.EventHandler(this.metroButton_EditMaterial_Click);
            // 
            // metroButton_AddMaterial
            // 
            this.metroButton_AddMaterial.BackColor = System.Drawing.Color.DarkCyan;
            this.metroButton_AddMaterial.ForeColor = System.Drawing.Color.White;
            this.metroButton_AddMaterial.Highlight = true;
            this.metroButton_AddMaterial.Location = new System.Drawing.Point(467, 5);
            this.metroButton_AddMaterial.Name = "metroButton_AddMaterial";
            this.metroButton_AddMaterial.Size = new System.Drawing.Size(75, 23);
            this.metroButton_AddMaterial.Style = MetroFramework.MetroColorStyle.White;
            this.metroButton_AddMaterial.TabIndex = 57;
            this.metroButton_AddMaterial.Text = "Agregar";
            this.metroButton_AddMaterial.UseCustomBackColor = true;
            this.metroButton_AddMaterial.UseCustomForeColor = true;
            this.metroButton_AddMaterial.UseSelectable = true;
            this.metroButton_AddMaterial.UseStyleColors = true;
            this.metroButton_AddMaterial.Click += new System.EventHandler(this.metroButton_AddMaterial_Click);
            // 
            // metroGrid_Material
            // 
            this.metroGrid_Material.AllowUserToAddRows = false;
            this.metroGrid_Material.AllowUserToResizeRows = false;
            this.metroGrid_Material.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroGrid_Material.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid_Material.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_Material.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid_Material.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid_Material.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_Material.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.metroGrid_Material.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid_Material.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMaterialLine,
            this.material_id,
            this.Column4,
            this.quantity_required,
            this.quantity_taken_real,
            this.unit_id_2,
            this.unit_name_2,
            this.warehouse_id_2,
            this.warehouse_name_2,
            this.state_2});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid_Material.DefaultCellStyle = dataGridViewCellStyle17;
            this.metroGrid_Material.EnableHeadersVisualStyles = false;
            this.metroGrid_Material.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid_Material.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_Material.Location = new System.Drawing.Point(13, 34);
            this.metroGrid_Material.MultiSelect = false;
            this.metroGrid_Material.Name = "metroGrid_Material";
            this.metroGrid_Material.ReadOnly = true;
            this.metroGrid_Material.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_Material.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.metroGrid_Material.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid_Material.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid_Material.Size = new System.Drawing.Size(693, 203);
            this.metroGrid_Material.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroGrid_Material.TabIndex = 52;
            // 
            // idMaterialLine
            // 
            this.idMaterialLine.HeaderText = "id";
            this.idMaterialLine.Name = "idMaterialLine";
            this.idMaterialLine.ReadOnly = true;
            this.idMaterialLine.Visible = false;
            // 
            // material_id
            // 
            this.material_id.HeaderText = "material_id";
            this.material_id.Name = "material_id";
            this.material_id.ReadOnly = true;
            this.material_id.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre de material";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // quantity_required
            // 
            this.quantity_required.HeaderText = "Cantidad requerida";
            this.quantity_required.Name = "quantity_required";
            this.quantity_required.ReadOnly = true;
            // 
            // quantity_taken_real
            // 
            this.quantity_taken_real.HeaderText = "Cantidad real solicitada";
            this.quantity_taken_real.Name = "quantity_taken_real";
            this.quantity_taken_real.ReadOnly = true;
            // 
            // unit_id_2
            // 
            this.unit_id_2.HeaderText = "unit_id";
            this.unit_id_2.Name = "unit_id_2";
            this.unit_id_2.ReadOnly = true;
            this.unit_id_2.Visible = false;
            // 
            // unit_name_2
            // 
            this.unit_name_2.HeaderText = "Unidad de medida";
            this.unit_name_2.Name = "unit_name_2";
            this.unit_name_2.ReadOnly = true;
            // 
            // warehouse_id_2
            // 
            this.warehouse_id_2.HeaderText = "warehouse_id";
            this.warehouse_id_2.Name = "warehouse_id_2";
            this.warehouse_id_2.ReadOnly = true;
            this.warehouse_id_2.Visible = false;
            // 
            // warehouse_name_2
            // 
            this.warehouse_name_2.HeaderText = "Almacén";
            this.warehouse_name_2.Name = "warehouse_name_2";
            this.warehouse_name_2.ReadOnly = true;
            // 
            // state_2
            // 
            this.state_2.HeaderText = "state";
            this.state_2.Name = "state_2";
            this.state_2.ReadOnly = true;
            this.state_2.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(721, 249);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // metroTabPage_Workers
            // 
            this.metroTabPage_Workers.Controls.Add(this.metroButton_DeleteWork);
            this.metroTabPage_Workers.Controls.Add(this.metroButton_EditWork);
            this.metroTabPage_Workers.Controls.Add(this.metroButton_AddWorker);
            this.metroTabPage_Workers.Controls.Add(this.metroGrid_Work);
            this.metroTabPage_Workers.Controls.Add(this.richTextBox2);
            this.metroTabPage_Workers.Location = new System.Drawing.Point(4, 29);
            this.metroTabPage_Workers.Name = "metroTabPage_Workers";
            this.metroTabPage_Workers.Size = new System.Drawing.Size(724, 261);
            this.metroTabPage_Workers.TabIndex = 2;
            this.metroTabPage_Workers.Text = "Trabajadores";
            // 
            // metroButton_DeleteWork
            // 
            this.metroButton_DeleteWork.BackColor = System.Drawing.Color.DarkCyan;
            this.metroButton_DeleteWork.ForeColor = System.Drawing.Color.White;
            this.metroButton_DeleteWork.Highlight = true;
            this.metroButton_DeleteWork.Location = new System.Drawing.Point(635, 7);
            this.metroButton_DeleteWork.Name = "metroButton_DeleteWork";
            this.metroButton_DeleteWork.Size = new System.Drawing.Size(75, 23);
            this.metroButton_DeleteWork.Style = MetroFramework.MetroColorStyle.White;
            this.metroButton_DeleteWork.TabIndex = 61;
            this.metroButton_DeleteWork.Text = "Eliminar";
            this.metroButton_DeleteWork.UseCustomBackColor = true;
            this.metroButton_DeleteWork.UseCustomForeColor = true;
            this.metroButton_DeleteWork.UseSelectable = true;
            this.metroButton_DeleteWork.UseStyleColors = true;
            this.metroButton_DeleteWork.Click += new System.EventHandler(this.metroButton_DeleteWork_Click);
            // 
            // metroButton_EditWork
            // 
            this.metroButton_EditWork.BackColor = System.Drawing.Color.DarkCyan;
            this.metroButton_EditWork.ForeColor = System.Drawing.Color.White;
            this.metroButton_EditWork.Highlight = true;
            this.metroButton_EditWork.Location = new System.Drawing.Point(554, 7);
            this.metroButton_EditWork.Name = "metroButton_EditWork";
            this.metroButton_EditWork.Size = new System.Drawing.Size(75, 23);
            this.metroButton_EditWork.Style = MetroFramework.MetroColorStyle.White;
            this.metroButton_EditWork.TabIndex = 60;
            this.metroButton_EditWork.Text = "Editar";
            this.metroButton_EditWork.UseCustomBackColor = true;
            this.metroButton_EditWork.UseCustomForeColor = true;
            this.metroButton_EditWork.UseSelectable = true;
            this.metroButton_EditWork.UseStyleColors = true;
            this.metroButton_EditWork.Click += new System.EventHandler(this.metroButton_EditWork_Click);
            // 
            // metroButton_AddWorker
            // 
            this.metroButton_AddWorker.BackColor = System.Drawing.Color.DarkCyan;
            this.metroButton_AddWorker.ForeColor = System.Drawing.Color.White;
            this.metroButton_AddWorker.Highlight = true;
            this.metroButton_AddWorker.Location = new System.Drawing.Point(474, 7);
            this.metroButton_AddWorker.Name = "metroButton_AddWorker";
            this.metroButton_AddWorker.Size = new System.Drawing.Size(75, 23);
            this.metroButton_AddWorker.Style = MetroFramework.MetroColorStyle.White;
            this.metroButton_AddWorker.TabIndex = 58;
            this.metroButton_AddWorker.Text = "Agregar";
            this.metroButton_AddWorker.UseCustomBackColor = true;
            this.metroButton_AddWorker.UseCustomForeColor = true;
            this.metroButton_AddWorker.UseSelectable = true;
            this.metroButton_AddWorker.UseStyleColors = true;
            this.metroButton_AddWorker.Click += new System.EventHandler(this.metroButton_AddWorker_Click);
            // 
            // metroGrid_Work
            // 
            this.metroGrid_Work.AllowUserToAddRows = false;
            this.metroGrid_Work.AllowUserToResizeRows = false;
            this.metroGrid_Work.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroGrid_Work.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid_Work.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_Work.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid_Work.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid_Work.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_Work.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.metroGrid_Work.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid_Work.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idWorkLine,
            this.worker_id,
            this.worker_name,
            this.product_id_2,
            this.product_name_2,
            this.workstation_id,
            this.workstation_name,
            this.unit_id_3,
            this.unit_name_3,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.state_3});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid_Work.DefaultCellStyle = dataGridViewCellStyle20;
            this.metroGrid_Work.EnableHeadersVisualStyles = false;
            this.metroGrid_Work.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid_Work.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_Work.Location = new System.Drawing.Point(9, 36);
            this.metroGrid_Work.MultiSelect = false;
            this.metroGrid_Work.Name = "metroGrid_Work";
            this.metroGrid_Work.ReadOnly = true;
            this.metroGrid_Work.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_Work.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.metroGrid_Work.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid_Work.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid_Work.Size = new System.Drawing.Size(701, 213);
            this.metroGrid_Work.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroGrid_Work.TabIndex = 53;
            // 
            // idWorkLine
            // 
            this.idWorkLine.HeaderText = "id";
            this.idWorkLine.Name = "idWorkLine";
            this.idWorkLine.ReadOnly = true;
            this.idWorkLine.Visible = false;
            // 
            // worker_id
            // 
            this.worker_id.HeaderText = "worker_id";
            this.worker_id.Name = "worker_id";
            this.worker_id.ReadOnly = true;
            this.worker_id.Visible = false;
            // 
            // worker_name
            // 
            this.worker_name.HeaderText = "Nombre del trabajador";
            this.worker_name.Name = "worker_name";
            this.worker_name.ReadOnly = true;
            // 
            // product_id_2
            // 
            this.product_id_2.HeaderText = "product_id";
            this.product_id_2.Name = "product_id_2";
            this.product_id_2.ReadOnly = true;
            this.product_id_2.Visible = false;
            // 
            // product_name_2
            // 
            this.product_name_2.HeaderText = "Producto";
            this.product_name_2.Name = "product_name_2";
            this.product_name_2.ReadOnly = true;
            // 
            // workstation_id
            // 
            this.workstation_id.HeaderText = "workstation_id";
            this.workstation_id.Name = "workstation_id";
            this.workstation_id.ReadOnly = true;
            this.workstation_id.Visible = false;
            // 
            // workstation_name
            // 
            this.workstation_name.HeaderText = "Puesto del trabajo";
            this.workstation_name.Name = "workstation_name";
            this.workstation_name.ReadOnly = true;
            // 
            // unit_id_3
            // 
            this.unit_id_3.HeaderText = "unit_id";
            this.unit_id_3.Name = "unit_id_3";
            this.unit_id_3.ReadOnly = true;
            this.unit_id_3.Visible = false;
            // 
            // unit_name_3
            // 
            this.unit_name_3.HeaderText = "Unidad de medida";
            this.unit_name_3.Name = "unit_name_3";
            this.unit_name_3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Cantidad requerida";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Cantidad producida";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Cantidad de rotura";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Tiempo de producción";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Observaciones";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // state_3
            // 
            this.state_3.HeaderText = "state";
            this.state_3.Name = "state_3";
            this.state_3.ReadOnly = true;
            this.state_3.Visible = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox2.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(721, 259);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.metroGrid_materials_summary);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(761, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(452, 286);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resumen de materiales";
            // 
            // metroGrid_materials_summary
            // 
            this.metroGrid_materials_summary.AllowUserToAddRows = false;
            this.metroGrid_materials_summary.AllowUserToResizeRows = false;
            this.metroGrid_materials_summary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroGrid_materials_summary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid_materials_summary.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_materials_summary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid_materials_summary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid_materials_summary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_materials_summary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.metroGrid_materials_summary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid_materials_summary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn10});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid_materials_summary.DefaultCellStyle = dataGridViewCellStyle14;
            this.metroGrid_materials_summary.EnableHeadersVisualStyles = false;
            this.metroGrid_materials_summary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid_materials_summary.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_materials_summary.Location = new System.Drawing.Point(8, 25);
            this.metroGrid_materials_summary.MultiSelect = false;
            this.metroGrid_materials_summary.Name = "metroGrid_materials_summary";
            this.metroGrid_materials_summary.ReadOnly = true;
            this.metroGrid_materials_summary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_materials_summary.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.metroGrid_materials_summary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid_materials_summary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid_materials_summary.Size = new System.Drawing.Size(438, 240);
            this.metroGrid_materials_summary.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroGrid_materials_summary.TabIndex = 53;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre de material";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Cantidad requerida";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Unidad de medida";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.metroGrid_products_summary);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(761, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(452, 289);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resumen de productos";
            // 
            // metroGrid_products_summary
            // 
            this.metroGrid_products_summary.AllowUserToAddRows = false;
            this.metroGrid_products_summary.AllowUserToResizeRows = false;
            this.metroGrid_products_summary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroGrid_products_summary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid_products_summary.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_products_summary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid_products_summary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid_products_summary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_products_summary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.metroGrid_products_summary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid_products_summary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.Column1,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid_products_summary.DefaultCellStyle = dataGridViewCellStyle23;
            this.metroGrid_products_summary.EnableHeadersVisualStyles = false;
            this.metroGrid_products_summary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid_products_summary.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_products_summary.Location = new System.Drawing.Point(8, 35);
            this.metroGrid_products_summary.MultiSelect = false;
            this.metroGrid_products_summary.Name = "metroGrid_products_summary";
            this.metroGrid_products_summary.ReadOnly = true;
            this.metroGrid_products_summary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_products_summary.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.metroGrid_products_summary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid_products_summary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid_products_summary.Size = new System.Drawing.Size(438, 230);
            this.metroGrid_products_summary.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroGrid_products_summary.TabIndex = 52;
            // 
            // metroButton_Cancel
            // 
            this.metroButton_Cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.metroButton_Cancel.ForeColor = System.Drawing.SystemColors.Window;
            this.metroButton_Cancel.Highlight = true;
            this.metroButton_Cancel.Location = new System.Drawing.Point(672, 599);
            this.metroButton_Cancel.Name = "metroButton_Cancel";
            this.metroButton_Cancel.Size = new System.Drawing.Size(75, 23);
            this.metroButton_Cancel.Style = MetroFramework.MetroColorStyle.White;
            this.metroButton_Cancel.TabIndex = 60;
            this.metroButton_Cancel.Text = "Cancelar";
            this.metroButton_Cancel.UseCustomBackColor = true;
            this.metroButton_Cancel.UseCustomForeColor = true;
            this.metroButton_Cancel.UseSelectable = true;
            this.metroButton_Cancel.UseStyleColors = true;
            this.metroButton_Cancel.Click += new System.EventHandler(this.metroButton_Cancel_Click);
            // 
            // metroButton_Register
            // 
            this.metroButton_Register.BackColor = System.Drawing.Color.DarkCyan;
            this.metroButton_Register.ForeColor = System.Drawing.Color.White;
            this.metroButton_Register.Highlight = true;
            this.metroButton_Register.Location = new System.Drawing.Point(587, 599);
            this.metroButton_Register.Name = "metroButton_Register";
            this.metroButton_Register.Size = new System.Drawing.Size(75, 23);
            this.metroButton_Register.Style = MetroFramework.MetroColorStyle.White;
            this.metroButton_Register.TabIndex = 59;
            this.metroButton_Register.Text = "Grabar";
            this.metroButton_Register.UseCustomBackColor = true;
            this.metroButton_Register.UseCustomForeColor = true;
            this.metroButton_Register.UseSelectable = true;
            this.metroButton_Register.Click += new System.EventHandler(this.metroButton_Register_Click);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Puesto de trabajo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cantidad producida";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Unidad de medida";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // UC_ProductionOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "UC_ProductionOrder";
            this.Size = new System.Drawing.Size(1232, 645);
            this.Load += new System.EventHandler(this.UC_ProductionOrder_Load);
            this.VisibleChanged += new System.EventHandler(this.UC_ProductionOrder_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage_Materials.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_Material)).EndInit();
            this.metroTabPage_Workers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_Work)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_materials_summary)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_products_summary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroGrid metroGrid_materials_summary;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroGrid metroGrid_products_summary;
        private MetroFramework.Controls.MetroButton metroButton_Cancel;
        private MetroFramework.Controls.MetroButton metroButton_Register;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage_Materials;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroButton metroButton_DeleteMaterial;
        private MetroFramework.Controls.MetroButton metroButton_EditMaterial;
        private MetroFramework.Controls.MetroButton metroButton_AddMaterial;
        private MetroFramework.Controls.MetroGrid metroGrid_Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaterialLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_required;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_taken_real;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_id_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_name_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse_id_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse_name_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn state_2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage metroTabPage_Workers;
        private MetroFramework.Controls.MetroButton metroButton_DeleteWork;
        private MetroFramework.Controls.MetroButton metroButton_EditWork;
        private MetroFramework.Controls.MetroButton metroButton_AddWorker;
        private MetroFramework.Controls.MetroGrid metroGrid_Work;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWorkLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn worker_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn worker_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn workstation_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn workstation_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_id_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_name_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn state_3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox_OrderNumber;
        private MetroFramework.Controls.MetroLabel metroLabel_numOrder;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Observation;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Description;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime metroDateTime_Begin;
        private MetroFramework.Controls.MetroDateTime metroDateTime_End;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox comboBox_Warehouse;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ComboBox comboBox_Recipe;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Quantity;
        private System.Windows.Forms.ComboBox comboBox_Product;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Quantity_warehouse;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Quantity_produced;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.Label label_Unit3;
        private System.Windows.Forms.Label label_Unit2;
        private System.Windows.Forms.Label label_Unit;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Estimate;
        private MetroFramework.Controls.MetroLabel metroLabel_estimate;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Estimate_line;
        private MetroFramework.Controls.MetroLabel metroLabel_Estimate_line;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
