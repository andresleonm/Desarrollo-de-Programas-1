namespace WindowsFormsApp1.Views
{
    partial class UC_PurchaseOrder
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.date_order_date = new MetroFramework.Controls.MetroDateTime();
            this.combo_warehouse = new MetroFramework.Controls.MetroComboBox();
            this.txt_id = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.combo_state = new MetroFramework.Controls.MetroComboBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.txt_total = new MetroFramework.Controls.MetroTextBox();
            this.txt_taxes = new MetroFramework.Controls.MetroTextBox();
            this.txt_no_taxes = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_address = new MetroFramework.Controls.MetroComboBox();
            this.combo_supplier = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.grid_order_lines = new MetroFramework.Controls.MetroGrid();
            this.dueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_measure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_order_lines)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.date_order_date);
            this.panel2.Controls.Add(this.combo_warehouse);
            this.panel2.Controls.Add(this.txt_id);
            this.panel2.Controls.Add(this.metroLabel5);
            this.panel2.Controls.Add(this.metroTabControl1);
            this.panel2.Controls.Add(this.metroLabel2);
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 526);
            this.panel2.TabIndex = 22;
            // 
            // date_order_date
            // 
            this.date_order_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_order_date.Location = new System.Drawing.Point(474, 16);
            this.date_order_date.MinimumSize = new System.Drawing.Size(0, 29);
            this.date_order_date.Name = "date_order_date";
            this.date_order_date.Size = new System.Drawing.Size(200, 29);
            this.date_order_date.TabIndex = 39;
            // 
            // combo_warehouse
            // 
            this.combo_warehouse.FormattingEnabled = true;
            this.combo_warehouse.ItemHeight = 23;
            this.combo_warehouse.Location = new System.Drawing.Point(86, 56);
            this.combo_warehouse.Name = "combo_warehouse";
            this.combo_warehouse.Size = new System.Drawing.Size(207, 29);
            this.combo_warehouse.TabIndex = 38;
            this.combo_warehouse.UseSelectable = true;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_id.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_id.CustomButton.Image = null;
            this.txt_id.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txt_id.CustomButton.Name = "";
            this.txt_id.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_id.CustomButton.TabIndex = 1;
            this.txt_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_id.CustomButton.UseSelectable = true;
            this.txt_id.CustomButton.UseVisualStyleBackColor = false;
            this.txt_id.CustomButton.Visible = false;
            this.txt_id.Enabled = false;
            this.txt_id.Lines = new string[0];
            this.txt_id.Location = new System.Drawing.Point(86, 16);
            this.txt_id.MaxLength = 32767;
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.ReadOnly = true;
            this.txt_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_id.SelectedText = "";
            this.txt_id.SelectionLength = 0;
            this.txt_id.SelectionStart = 0;
            this.txt_id.ShortcutsEnabled = true;
            this.txt_id.Size = new System.Drawing.Size(207, 29);
            this.txt_id.TabIndex = 37;
            this.txt_id.UseCustomBackColor = true;
            this.txt_id.UseSelectable = true;
            this.txt_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.Black;
            this.metroLabel5.Location = new System.Drawing.Point(370, 21);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(98, 15);
            this.metroLabel5.TabIndex = 33;
            this.metroLabel5.Text = "Fecha de orden :";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.metroTabControl1.HotTrack = true;
            this.metroTabControl1.ItemSize = new System.Drawing.Size(135, 25);
            this.metroTabControl1.Location = new System.Drawing.Point(19, 108);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(758, 404);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTabControl1.TabIndex = 32;
            this.metroTabControl1.UseCustomBackColor = true;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroTabPage1.Controls.Add(this.combo_state);
            this.metroTabPage1.Controls.Add(this.metroButton3);
            this.metroTabPage1.Controls.Add(this.metroButton2);
            this.metroTabPage1.Controls.Add(this.txt_total);
            this.metroTabPage1.Controls.Add(this.txt_taxes);
            this.metroTabPage1.Controls.Add(this.txt_no_taxes);
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.groupBox1);
            this.metroTabPage1.Controls.Add(this.combo_address);
            this.metroTabPage1.Controls.Add(this.combo_supplier);
            this.metroTabPage1.Controls.Add(this.metroLabel10);
            this.metroTabPage1.Controls.Add(this.metroLabel9);
            this.metroTabPage1.Controls.Add(this.metroLabel8);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 29);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(750, 371);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Orden de Compra";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // combo_state
            // 
            this.combo_state.FormattingEnabled = true;
            this.combo_state.ItemHeight = 23;
            this.combo_state.Location = new System.Drawing.Point(67, 310);
            this.combo_state.Name = "combo_state";
            this.combo_state.Size = new System.Drawing.Size(201, 29);
            this.combo_state.TabIndex = 48;
            this.combo_state.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.metroButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            this.metroButton3.Highlight = true;
            this.metroButton3.Location = new System.Drawing.Point(663, 316);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButton3.TabIndex = 47;
            this.metroButton3.Text = "Cancelar";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseCustomForeColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.UseStyleColors = true;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.metroButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(553, 318);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButton2.TabIndex = 46;
            this.metroButton2.Text = "Grabar";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_total.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_total.CustomButton.Image = null;
            this.txt_total.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txt_total.CustomButton.Name = "";
            this.txt_total.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_total.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_total.CustomButton.TabIndex = 1;
            this.txt_total.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_total.CustomButton.UseSelectable = true;
            this.txt_total.CustomButton.UseVisualStyleBackColor = false;
            this.txt_total.CustomButton.Visible = false;
            this.txt_total.Enabled = false;
            this.txt_total.Lines = new string[0];
            this.txt_total.Location = new System.Drawing.Point(631, 265);
            this.txt_total.MaxLength = 32767;
            this.txt_total.Name = "txt_total";
            this.txt_total.PasswordChar = '\0';
            this.txt_total.ReadOnly = true;
            this.txt_total.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_total.SelectedText = "";
            this.txt_total.SelectionLength = 0;
            this.txt_total.SelectionStart = 0;
            this.txt_total.ShortcutsEnabled = true;
            this.txt_total.Size = new System.Drawing.Size(110, 29);
            this.txt_total.TabIndex = 45;
            this.txt_total.UseCustomBackColor = true;
            this.txt_total.UseSelectable = true;
            this.txt_total.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_total.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_taxes
            // 
            this.txt_taxes.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_taxes.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_taxes.CustomButton.Image = null;
            this.txt_taxes.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txt_taxes.CustomButton.Name = "";
            this.txt_taxes.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_taxes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_taxes.CustomButton.TabIndex = 1;
            this.txt_taxes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_taxes.CustomButton.UseSelectable = true;
            this.txt_taxes.CustomButton.UseVisualStyleBackColor = false;
            this.txt_taxes.CustomButton.Visible = false;
            this.txt_taxes.Enabled = false;
            this.txt_taxes.Lines = new string[0];
            this.txt_taxes.Location = new System.Drawing.Point(400, 265);
            this.txt_taxes.MaxLength = 32767;
            this.txt_taxes.Name = "txt_taxes";
            this.txt_taxes.PasswordChar = '\0';
            this.txt_taxes.ReadOnly = true;
            this.txt_taxes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_taxes.SelectedText = "";
            this.txt_taxes.SelectionLength = 0;
            this.txt_taxes.SelectionStart = 0;
            this.txt_taxes.ShortcutsEnabled = true;
            this.txt_taxes.Size = new System.Drawing.Size(110, 29);
            this.txt_taxes.TabIndex = 44;
            this.txt_taxes.UseCustomBackColor = true;
            this.txt_taxes.UseSelectable = true;
            this.txt_taxes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_taxes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_no_taxes
            // 
            this.txt_no_taxes.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_no_taxes.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_no_taxes.CustomButton.Image = null;
            this.txt_no_taxes.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txt_no_taxes.CustomButton.Name = "";
            this.txt_no_taxes.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_no_taxes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_no_taxes.CustomButton.TabIndex = 1;
            this.txt_no_taxes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_no_taxes.CustomButton.UseSelectable = true;
            this.txt_no_taxes.CustomButton.UseVisualStyleBackColor = false;
            this.txt_no_taxes.CustomButton.Visible = false;
            this.txt_no_taxes.Enabled = false;
            this.txt_no_taxes.Lines = new string[0];
            this.txt_no_taxes.Location = new System.Drawing.Point(158, 265);
            this.txt_no_taxes.MaxLength = 32767;
            this.txt_no_taxes.Name = "txt_no_taxes";
            this.txt_no_taxes.PasswordChar = '\0';
            this.txt_no_taxes.ReadOnly = true;
            this.txt_no_taxes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_no_taxes.SelectedText = "";
            this.txt_no_taxes.SelectionLength = 0;
            this.txt_no_taxes.SelectionStart = 0;
            this.txt_no_taxes.ShortcutsEnabled = true;
            this.txt_no_taxes.Size = new System.Drawing.Size(110, 29);
            this.txt_no_taxes.TabIndex = 40;
            this.txt_no_taxes.UseCustomBackColor = true;
            this.txt_no_taxes.UseSelectable = true;
            this.txt_no_taxes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_no_taxes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.metroButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(663, 41);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButton1.TabIndex = 43;
            this.metroButton1.Text = "Nueva";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.grid_order_lines);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(13, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 192);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Líneas de la Orden de Compra";
            // 
            // combo_address
            // 
            this.combo_address.FormattingEnabled = true;
            this.combo_address.ItemHeight = 23;
            this.combo_address.Location = new System.Drawing.Point(501, 6);
            this.combo_address.Name = "combo_address";
            this.combo_address.Size = new System.Drawing.Size(207, 29);
            this.combo_address.TabIndex = 41;
            this.combo_address.UseSelectable = true;
            // 
            // combo_supplier
            // 
            this.combo_supplier.FormattingEnabled = true;
            this.combo_supplier.ItemHeight = 23;
            this.combo_supplier.Location = new System.Drawing.Point(86, 6);
            this.combo_supplier.Name = "combo_supplier";
            this.combo_supplier.Size = new System.Drawing.Size(207, 29);
            this.combo_supplier.TabIndex = 40;
            this.combo_supplier.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.White;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.ForeColor = System.Drawing.Color.Black;
            this.metroLabel10.Location = new System.Drawing.Point(12, 316);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(49, 15);
            this.metroLabel10.TabIndex = 39;
            this.metroLabel10.Text = "Estado :";
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.White;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.ForeColor = System.Drawing.Color.Black;
            this.metroLabel9.Location = new System.Drawing.Point(585, 270);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(40, 15);
            this.metroLabel9.TabIndex = 38;
            this.metroLabel9.Text = "Total :";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.White;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.ForeColor = System.Drawing.Color.Black;
            this.metroLabel8.Location = new System.Drawing.Point(323, 270);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(71, 15);
            this.metroLabel8.TabIndex = 37;
            this.metroLabel8.Text = "Impuestos :";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.White;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.Color.Black;
            this.metroLabel7.Location = new System.Drawing.Point(13, 270);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(139, 15);
            this.metroLabel7.TabIndex = 36;
            this.metroLabel7.Text = "Cantidad sin impuestos :";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.White;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.Black;
            this.metroLabel4.Location = new System.Drawing.Point(429, 9);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 15);
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "Dirección :";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.White;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(8, 9);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(72, 15);
            this.metroLabel3.TabIndex = 33;
            this.metroLabel3.Text = "Proveedor :";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(7, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 22;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.panel4);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 29);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(750, 371);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Notas";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.richTextBox1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(750, 345);
            this.panel4.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(750, 345);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.Black;
            this.metroLabel2.Location = new System.Drawing.Point(19, 58);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 15);
            this.metroLabel2.TabIndex = 31;
            this.metroLabel2.Text = "Almacen :";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(32, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 15);
            this.metroLabel1.TabIndex = 29;
            this.metroLabel1.Text = "Orden :";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // grid_order_lines
            // 
            this.grid_order_lines.AllowUserToResizeRows = false;
            this.grid_order_lines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_order_lines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_order_lines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_order_lines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_order_lines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_order_lines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dueDate,
            this.descrip,
            this.quant,
            this.unit_measure,
            this.unitPrice,
            this.sub_total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_order_lines.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_order_lines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid_order_lines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_order_lines.Size = new System.Drawing.Size(722, 173);
            this.grid_order_lines.TabIndex = 50;
            // 
            // dueDate
            // 
            this.dueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dueDate.HeaderText = "Fecha Programada";
            this.dueDate.Name = "dueDate";
            this.dueDate.ReadOnly = true;
            // 
            // descrip
            // 
            this.descrip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descrip.HeaderText = "Descripción";
            this.descrip.Name = "descrip";
            this.descrip.ReadOnly = true;
            // 
            // quant
            // 
            this.quant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quant.HeaderText = "Cantidad";
            this.quant.Name = "quant";
            this.quant.ReadOnly = true;
            // 
            // unit_measure
            // 
            this.unit_measure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unit_measure.HeaderText = "Unidad de Medida";
            this.unit_measure.Name = "unit_measure";
            this.unit_measure.ReadOnly = true;
            // 
            // unitPrice
            // 
            this.unitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitPrice.HeaderText = "Precio Unitario";
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.ReadOnly = true;
            // 
            // sub_total
            // 
            this.sub_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sub_total.HeaderText = "Subtotal";
            this.sub_total.Name = "sub_total";
            this.sub_total.ReadOnly = true;
            // 
            // UC_PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "UC_PurchaseOrder";
            this.Size = new System.Drawing.Size(787, 526);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_order_lines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox richTextBox1;        
        private MetroFramework.Controls.MetroDateTime date_order_date;
        private MetroFramework.Controls.MetroComboBox combo_warehouse;
        private MetroFramework.Controls.MetroTextBox txt_id;
        private MetroFramework.Controls.MetroComboBox combo_address;
        private MetroFramework.Controls.MetroComboBox combo_supplier;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txt_total;
        private MetroFramework.Controls.MetroTextBox txt_taxes;
        private MetroFramework.Controls.MetroTextBox txt_no_taxes;
        private MetroFramework.Controls.MetroComboBox combo_state;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroGrid grid_order_lines;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_measure;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_total;
    }
}
