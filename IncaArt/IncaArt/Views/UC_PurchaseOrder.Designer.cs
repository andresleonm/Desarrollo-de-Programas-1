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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_igv = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_currency = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_external_number = new MetroFramework.Controls.MetroTextBox();
            this.label_external_number = new MetroFramework.Controls.MetroLabel();
            this.date_order_date = new MetroFramework.Controls.MetroDateTime();
            this.txt_id = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.txt_supplier_phone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txt_address = new MetroFramework.Controls.MetroTextBox();
            this.txt_supplier_doi = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.btn_cancel = new MetroFramework.Controls.MetroButton();
            this.btn_save = new MetroFramework.Controls.MetroButton();
            this.txt_total = new MetroFramework.Controls.MetroTextBox();
            this.txt_taxes = new MetroFramework.Controls.MetroTextBox();
            this.txt_no_taxes = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid_order_lines = new MetroFramework.Controls.MetroGrid();
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
            this.txt_observation = new System.Windows.Forms.RichTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_state = new MetroFramework.Controls.MetroTextBox();
            this.dueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_measure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_order_lines)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_igv);
            this.panel2.Controls.Add(this.metroLabel6);
            this.panel2.Controls.Add(this.txt_currency);
            this.panel2.Controls.Add(this.metroLabel2);
            this.panel2.Controls.Add(this.txt_external_number);
            this.panel2.Controls.Add(this.label_external_number);
            this.panel2.Controls.Add(this.date_order_date);
            this.panel2.Controls.Add(this.txt_id);
            this.panel2.Controls.Add(this.metroLabel5);
            this.panel2.Controls.Add(this.metroTabControl1);
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 578);
            this.panel2.TabIndex = 22;
            // 
            // lbl_igv
            // 
            this.lbl_igv.AutoSize = true;
            this.lbl_igv.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_igv.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbl_igv.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_igv.ForeColor = System.Drawing.Color.Black;
            this.lbl_igv.Location = new System.Drawing.Point(84, 553);
            this.lbl_igv.Name = "lbl_igv";
            this.lbl_igv.Size = new System.Drawing.Size(21, 15);
            this.lbl_igv.TabIndex = 52;
            this.lbl_igv.Text = "18";
            this.lbl_igv.UseCustomBackColor = true;
            this.lbl_igv.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.Color.Black;
            this.metroLabel6.Location = new System.Drawing.Point(23, 553);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(60, 15);
            this.metroLabel6.TabIndex = 49;
            this.metroLabel6.Text = "*IGV (%): ";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // txt_currency
            // 
            this.txt_currency.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_currency.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_currency.CustomButton.Image = null;
            this.txt_currency.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txt_currency.CustomButton.Name = "";
            this.txt_currency.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_currency.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_currency.CustomButton.TabIndex = 1;
            this.txt_currency.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_currency.CustomButton.UseSelectable = true;
            this.txt_currency.CustomButton.UseVisualStyleBackColor = false;
            this.txt_currency.CustomButton.Visible = false;
            this.txt_currency.Enabled = false;
            this.txt_currency.Lines = new string[0];
            this.txt_currency.Location = new System.Drawing.Point(559, 64);
            this.txt_currency.MaxLength = 32767;
            this.txt_currency.Name = "txt_currency";
            this.txt_currency.PasswordChar = '\0';
            this.txt_currency.ReadOnly = true;
            this.txt_currency.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_currency.SelectedText = "";
            this.txt_currency.SelectionLength = 0;
            this.txt_currency.SelectionStart = 0;
            this.txt_currency.ShortcutsEnabled = true;
            this.txt_currency.Size = new System.Drawing.Size(207, 29);
            this.txt_currency.TabIndex = 51;
            this.txt_currency.UseCustomBackColor = true;
            this.txt_currency.UseSelectable = true;
            this.txt_currency.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_currency.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.Black;
            this.metroLabel2.Location = new System.Drawing.Point(495, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 15);
            this.metroLabel2.TabIndex = 50;
            this.metroLabel2.Text = "Moneda :";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // txt_external_number
            // 
            // 
            // 
            // 
            this.txt_external_number.CustomButton.Image = null;
            this.txt_external_number.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txt_external_number.CustomButton.Name = "";
            this.txt_external_number.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_external_number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_external_number.CustomButton.TabIndex = 1;
            this.txt_external_number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_external_number.CustomButton.UseSelectable = true;
            this.txt_external_number.CustomButton.Visible = false;
            this.txt_external_number.Lines = new string[0];
            this.txt_external_number.Location = new System.Drawing.Point(183, 64);
            this.txt_external_number.MaxLength = 32767;
            this.txt_external_number.Name = "txt_external_number";
            this.txt_external_number.PasswordChar = '\0';
            this.txt_external_number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_external_number.SelectedText = "";
            this.txt_external_number.SelectionLength = 0;
            this.txt_external_number.SelectionStart = 0;
            this.txt_external_number.ShortcutsEnabled = true;
            this.txt_external_number.Size = new System.Drawing.Size(207, 29);
            this.txt_external_number.TabIndex = 49;
            this.txt_external_number.UseSelectable = true;
            this.txt_external_number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_external_number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label_external_number
            // 
            this.label_external_number.AutoSize = true;
            this.label_external_number.BackColor = System.Drawing.SystemColors.Control;
            this.label_external_number.FontSize = MetroFramework.MetroLabelSize.Small;
            this.label_external_number.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label_external_number.ForeColor = System.Drawing.Color.Black;
            this.label_external_number.Location = new System.Drawing.Point(71, 64);
            this.label_external_number.Name = "label_external_number";
            this.label_external_number.Size = new System.Drawing.Size(106, 15);
            this.label_external_number.TabIndex = 48;
            this.label_external_number.Text = "Número Externo :";
            this.label_external_number.UseCustomBackColor = true;
            this.label_external_number.UseCustomForeColor = true;
            // 
            // date_order_date
            // 
            this.date_order_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_order_date.Location = new System.Drawing.Point(559, 16);
            this.date_order_date.MinimumSize = new System.Drawing.Size(0, 29);
            this.date_order_date.Name = "date_order_date";
            this.date_order_date.Size = new System.Drawing.Size(207, 29);
            this.date_order_date.TabIndex = 39;
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
            this.txt_id.Location = new System.Drawing.Point(183, 16);
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
            this.metroLabel5.Location = new System.Drawing.Point(455, 21);
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
            this.metroTabControl1.Size = new System.Drawing.Size(883, 442);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTabControl1.TabIndex = 32;
            this.metroTabControl1.UseCustomBackColor = true;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroTabPage1.Controls.Add(this.txt_state);
            this.metroTabPage1.Controls.Add(this.txt_supplier_phone);
            this.metroTabPage1.Controls.Add(this.metroLabel12);
            this.metroTabPage1.Controls.Add(this.txt_address);
            this.metroTabPage1.Controls.Add(this.txt_supplier_doi);
            this.metroTabPage1.Controls.Add(this.metroLabel11);
            this.metroTabPage1.Controls.Add(this.btn_cancel);
            this.metroTabPage1.Controls.Add(this.btn_save);
            this.metroTabPage1.Controls.Add(this.txt_total);
            this.metroTabPage1.Controls.Add(this.txt_taxes);
            this.metroTabPage1.Controls.Add(this.txt_no_taxes);
            this.metroTabPage1.Controls.Add(this.groupBox1);
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
            this.metroTabPage1.Size = new System.Drawing.Size(875, 409);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Orden de Compra";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // txt_supplier_phone
            // 
            this.txt_supplier_phone.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_supplier_phone.CustomButton.Image = null;
            this.txt_supplier_phone.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txt_supplier_phone.CustomButton.Name = "";
            this.txt_supplier_phone.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_supplier_phone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_supplier_phone.CustomButton.TabIndex = 1;
            this.txt_supplier_phone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_supplier_phone.CustomButton.UseSelectable = true;
            this.txt_supplier_phone.CustomButton.Visible = false;
            this.txt_supplier_phone.Enabled = false;
            this.txt_supplier_phone.Lines = new string[0];
            this.txt_supplier_phone.Location = new System.Drawing.Point(86, 56);
            this.txt_supplier_phone.MaxLength = 32767;
            this.txt_supplier_phone.Name = "txt_supplier_phone";
            this.txt_supplier_phone.PasswordChar = '\0';
            this.txt_supplier_phone.ReadOnly = true;
            this.txt_supplier_phone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_supplier_phone.SelectedText = "";
            this.txt_supplier_phone.SelectionLength = 0;
            this.txt_supplier_phone.SelectionStart = 0;
            this.txt_supplier_phone.ShortcutsEnabled = true;
            this.txt_supplier_phone.Size = new System.Drawing.Size(207, 29);
            this.txt_supplier_phone.TabIndex = 58;
            this.txt_supplier_phone.UseCustomBackColor = true;
            this.txt_supplier_phone.UseSelectable = true;
            this.txt_supplier_phone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_supplier_phone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.White;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.ForeColor = System.Drawing.Color.Black;
            this.metroLabel12.Location = new System.Drawing.Point(18, 56);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(62, 15);
            this.metroLabel12.TabIndex = 57;
            this.metroLabel12.Text = "Teléfono :";
            this.metroLabel12.UseCustomBackColor = true;
            this.metroLabel12.UseCustomForeColor = true;
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_address.CustomButton.Image = null;
            this.txt_address.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txt_address.CustomButton.Name = "";
            this.txt_address.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_address.CustomButton.TabIndex = 1;
            this.txt_address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_address.CustomButton.UseSelectable = true;
            this.txt_address.CustomButton.Visible = false;
            this.txt_address.Enabled = false;
            this.txt_address.Lines = new string[0];
            this.txt_address.Location = new System.Drawing.Point(385, 6);
            this.txt_address.MaxLength = 32767;
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.ReadOnly = true;
            this.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_address.SelectedText = "";
            this.txt_address.SelectionLength = 0;
            this.txt_address.SelectionStart = 0;
            this.txt_address.ShortcutsEnabled = true;
            this.txt_address.Size = new System.Drawing.Size(207, 29);
            this.txt_address.TabIndex = 56;
            this.txt_address.UseCustomBackColor = true;
            this.txt_address.UseSelectable = true;
            this.txt_address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_supplier_doi
            // 
            this.txt_supplier_doi.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_supplier_doi.CustomButton.Image = null;
            this.txt_supplier_doi.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txt_supplier_doi.CustomButton.Name = "";
            this.txt_supplier_doi.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_supplier_doi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_supplier_doi.CustomButton.TabIndex = 1;
            this.txt_supplier_doi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_supplier_doi.CustomButton.UseSelectable = true;
            this.txt_supplier_doi.CustomButton.Visible = false;
            this.txt_supplier_doi.Enabled = false;
            this.txt_supplier_doi.Lines = new string[0];
            this.txt_supplier_doi.Location = new System.Drawing.Point(651, 6);
            this.txt_supplier_doi.MaxLength = 32767;
            this.txt_supplier_doi.Name = "txt_supplier_doi";
            this.txt_supplier_doi.PasswordChar = '\0';
            this.txt_supplier_doi.ReadOnly = true;
            this.txt_supplier_doi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_supplier_doi.SelectedText = "";
            this.txt_supplier_doi.SelectionLength = 0;
            this.txt_supplier_doi.SelectionStart = 0;
            this.txt_supplier_doi.ShortcutsEnabled = true;
            this.txt_supplier_doi.Size = new System.Drawing.Size(207, 29);
            this.txt_supplier_doi.TabIndex = 55;
            this.txt_supplier_doi.UseCustomBackColor = true;
            this.txt_supplier_doi.UseSelectable = true;
            this.txt_supplier_doi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_supplier_doi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.White;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.ForeColor = System.Drawing.Color.Black;
            this.metroLabel11.Location = new System.Drawing.Point(608, 9);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(37, 15);
            this.metroLabel11.TabIndex = 54;
            this.metroLabel11.Text = "RUC :";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            this.btn_cancel.Highlight = true;
            this.btn_cancel.Location = new System.Drawing.Point(488, 371);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_cancel.TabIndex = 47;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseCustomBackColor = true;
            this.btn_cancel.UseCustomForeColor = true;
            this.btn_cancel.UseSelectable = true;
            this.btn_cancel.UseStyleColors = true;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            this.btn_save.Highlight = true;
            this.btn_save.Location = new System.Drawing.Point(354, 371);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_save.TabIndex = 46;
            this.btn_save.Text = "Grabar";
            this.btn_save.UseCustomBackColor = true;
            this.btn_save.UseCustomForeColor = true;
            this.btn_save.UseSelectable = true;
            this.btn_save.UseStyleColors = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
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
            this.txt_total.Location = new System.Drawing.Point(748, 320);
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
            this.txt_taxes.Location = new System.Drawing.Point(569, 320);
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
            this.txt_no_taxes.Location = new System.Drawing.Point(354, 320);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.grid_order_lines);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(13, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 202);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Líneas de la Orden de Compra";
            // 
            // grid_order_lines
            // 
            this.grid_order_lines.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_order_lines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_order_lines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_order_lines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_order_lines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.grid_order_lines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_order_lines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_order_lines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_order_lines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dueDate,
            this.material,
            this.quant,
            this.unit_measure,
            this.warehouse,
            this.unitPrice,
            this.sub_total});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_order_lines.DefaultCellStyle = dataGridViewCellStyle7;
            this.grid_order_lines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_order_lines.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_order_lines.EnableHeadersVisualStyles = false;
            this.grid_order_lines.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_order_lines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_order_lines.Location = new System.Drawing.Point(3, 16);
            this.grid_order_lines.MultiSelect = false;
            this.grid_order_lines.Name = "grid_order_lines";
            this.grid_order_lines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_order_lines.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_order_lines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_order_lines.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grid_order_lines.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_order_lines.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.grid_order_lines.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_order_lines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_order_lines.Size = new System.Drawing.Size(839, 183);
            this.grid_order_lines.TabIndex = 50;
            this.grid_order_lines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_order_lines_CellContentClick);
            this.grid_order_lines.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_order_lines_CellValueChanged);
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
            this.combo_supplier.SelectedIndexChanged += new System.EventHandler(this.combo_supplier_SelectedIndexChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.White;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.ForeColor = System.Drawing.Color.Black;
            this.metroLabel10.Location = new System.Drawing.Point(13, 325);
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
            this.metroLabel9.Location = new System.Drawing.Point(702, 325);
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
            this.metroLabel8.Location = new System.Drawing.Point(487, 325);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(76, 15);
            this.metroLabel8.TabIndex = 37;
            this.metroLabel8.Text = "*Impuestos :";
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
            this.metroLabel7.Location = new System.Drawing.Point(209, 325);
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
            this.metroLabel4.Location = new System.Drawing.Point(313, 9);
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
            this.metroTabPage2.Size = new System.Drawing.Size(875, 409);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Notas";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_observation);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(750, 345);
            this.panel4.TabIndex = 2;
            // 
            // txt_observation
            // 
            this.txt_observation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_observation.Location = new System.Drawing.Point(0, 0);
            this.txt_observation.Name = "txt_observation";
            this.txt_observation.Size = new System.Drawing.Size(750, 345);
            this.txt_observation.TabIndex = 0;
            this.txt_observation.Text = "";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(129, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 15);
            this.metroLabel1.TabIndex = 29;
            this.metroLabel1.Text = "Orden :";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txt_state
            // 
            this.txt_state.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_state.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_state.CustomButton.Image = null;
            this.txt_state.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txt_state.CustomButton.Name = "";
            this.txt_state.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_state.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_state.CustomButton.TabIndex = 1;
            this.txt_state.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_state.CustomButton.UseSelectable = true;
            this.txt_state.CustomButton.UseVisualStyleBackColor = false;
            this.txt_state.CustomButton.Visible = false;
            this.txt_state.Enabled = false;
            this.txt_state.Lines = new string[0];
            this.txt_state.Location = new System.Drawing.Point(68, 320);
            this.txt_state.MaxLength = 32767;
            this.txt_state.Name = "txt_state";
            this.txt_state.PasswordChar = '\0';
            this.txt_state.ReadOnly = true;
            this.txt_state.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_state.SelectedText = "";
            this.txt_state.SelectionLength = 0;
            this.txt_state.SelectionStart = 0;
            this.txt_state.ShortcutsEnabled = true;
            this.txt_state.Size = new System.Drawing.Size(110, 29);
            this.txt_state.TabIndex = 59;
            this.txt_state.UseCustomBackColor = true;
            this.txt_state.UseSelectable = true;
            this.txt_state.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_state.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dueDate
            // 
            this.dueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dueDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dueDate.HeaderText = "Fecha Programada";
            this.dueDate.Name = "dueDate";
            // 
            // material
            // 
            this.material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.material.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.material.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.material.HeaderText = "Material";
            this.material.Name = "material";
            this.material.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.material.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // quant
            // 
            this.quant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.quant.DefaultCellStyle = dataGridViewCellStyle4;
            this.quant.HeaderText = "Cantidad";
            this.quant.Name = "quant";
            // 
            // unit_measure
            // 
            this.unit_measure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unit_measure.HeaderText = "Unidad de Medida";
            this.unit_measure.Name = "unit_measure";
            this.unit_measure.ReadOnly = true;
            // 
            // warehouse
            // 
            this.warehouse.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.warehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warehouse.HeaderText = "Almacén";
            this.warehouse.Name = "warehouse";
            // 
            // unitPrice
            // 
            this.unitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.unitPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.unitPrice.HeaderText = "Precio Unitario";
            this.unitPrice.Name = "unitPrice";
            // 
            // sub_total
            // 
            this.sub_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.sub_total.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.Size = new System.Drawing.Size(924, 578);
            this.Load += new System.EventHandler(this.UC_PurchaseOrder_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_order_lines)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox txt_observation;        
        private MetroFramework.Controls.MetroDateTime date_order_date;
        private MetroFramework.Controls.MetroTextBox txt_id;
        private MetroFramework.Controls.MetroComboBox combo_supplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txt_total;
        private MetroFramework.Controls.MetroTextBox txt_taxes;
        private MetroFramework.Controls.MetroTextBox txt_no_taxes;
        private MetroFramework.Controls.MetroButton btn_cancel;
        private MetroFramework.Controls.MetroButton btn_save;
        private MetroFramework.Controls.MetroGrid grid_order_lines;
        private MetroFramework.Controls.MetroTextBox txt_external_number;
        private MetroFramework.Controls.MetroLabel label_external_number;
        private MetroFramework.Controls.MetroTextBox txt_currency;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lbl_igv;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txt_address;
        private MetroFramework.Controls.MetroTextBox txt_supplier_doi;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txt_supplier_phone;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txt_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_measure;
        private System.Windows.Forms.DataGridViewComboBoxColumn warehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_total;
    }
}
