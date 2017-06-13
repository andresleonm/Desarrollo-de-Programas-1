namespace WindowsFormsApp1.Views.Production_Module
{
    partial class ProductionOrderWorkLine
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_Minute = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Hours = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SearchClient = new MetroFramework.Controls.MetroTile();
            this.metroTextBox_observations = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_quantity_produced = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_quantity_broken = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_quantity_required = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.comboBox_Workstation = new System.Windows.Forms.ComboBox();
            this.comboBox_Product = new System.Windows.Forms.ComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.comboBox_Worker = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Register = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown_Minute);
            this.groupBox1.Controls.Add(this.numericUpDown_Hours);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_SearchClient);
            this.groupBox1.Controls.Add(this.metroTextBox_observations);
            this.groupBox1.Controls.Add(this.metroTextBox_quantity_produced);
            this.groupBox1.Controls.Add(this.metroTextBox_quantity_broken);
            this.groupBox1.Controls.Add(this.metroTextBox_quantity_required);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.comboBox_Workstation);
            this.groupBox1.Controls.Add(this.comboBox_Product);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.comboBox_Worker);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.button_Cancel);
            this.groupBox1.Controls.Add(this.button_Register);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(21, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 291);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Línea de Trabajador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(718, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "min";
            // 
            // numericUpDown_Minute
            // 
            this.numericUpDown_Minute.Location = new System.Drawing.Point(653, 134);
            this.numericUpDown_Minute.Name = "numericUpDown_Minute";
            this.numericUpDown_Minute.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown_Minute.TabIndex = 68;
            this.numericUpDown_Minute.Validating += new System.ComponentModel.CancelEventHandler(this.numericUpDown_Minute_Validating);
            // 
            // numericUpDown_Hours
            // 
            this.numericUpDown_Hours.Location = new System.Drawing.Point(550, 135);
            this.numericUpDown_Hours.Name = "numericUpDown_Hours";
            this.numericUpDown_Hours.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown_Hours.TabIndex = 67;
            this.numericUpDown_Hours.Validating += new System.ComponentModel.CancelEventHandler(this.numericUpDown_Hours_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "horas";
            // 
            // btn_SearchClient
            // 
            this.btn_SearchClient.ActiveControl = null;
            this.btn_SearchClient.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_SearchClient.Location = new System.Drawing.Point(328, 29);
            this.btn_SearchClient.Name = "btn_SearchClient";
            this.btn_SearchClient.Size = new System.Drawing.Size(29, 24);
            this.btn_SearchClient.TabIndex = 64;
            this.btn_SearchClient.TileImage = global::WindowsFormsApp1.Properties.Resources.Search_16;
            this.btn_SearchClient.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SearchClient.UseCustomBackColor = true;
            this.btn_SearchClient.UseCustomForeColor = true;
            this.btn_SearchClient.UseSelectable = true;
            this.btn_SearchClient.UseStyleColors = true;
            this.btn_SearchClient.UseTileImage = true;
            // 
            // metroTextBox_observations
            // 
            this.metroTextBox_observations.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.metroTextBox_observations.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.metroTextBox_observations.CustomButton.Image = null;
            this.metroTextBox_observations.CustomButton.Location = new System.Drawing.Point(521, 2);
            this.metroTextBox_observations.CustomButton.Name = "";
            this.metroTextBox_observations.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.metroTextBox_observations.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_observations.CustomButton.TabIndex = 1;
            this.metroTextBox_observations.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_observations.CustomButton.UseSelectable = true;
            this.metroTextBox_observations.CustomButton.UseVisualStyleBackColor = false;
            this.metroTextBox_observations.CustomButton.Visible = false;
            this.metroTextBox_observations.Lines = new string[0];
            this.metroTextBox_observations.Location = new System.Drawing.Point(152, 174);
            this.metroTextBox_observations.MaxLength = 32767;
            this.metroTextBox_observations.Name = "metroTextBox_observations";
            this.metroTextBox_observations.PasswordChar = '\0';
            this.metroTextBox_observations.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_observations.SelectedText = "";
            this.metroTextBox_observations.SelectionLength = 0;
            this.metroTextBox_observations.SelectionStart = 0;
            this.metroTextBox_observations.ShortcutsEnabled = true;
            this.metroTextBox_observations.Size = new System.Drawing.Size(561, 42);
            this.metroTextBox_observations.TabIndex = 63;
            this.metroTextBox_observations.UseCustomBackColor = true;
            this.metroTextBox_observations.UseSelectable = true;
            this.metroTextBox_observations.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_observations.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox_quantity_produced
            // 
            this.metroTextBox_quantity_produced.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.metroTextBox_quantity_produced.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.metroTextBox_quantity_produced.CustomButton.Image = null;
            this.metroTextBox_quantity_produced.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.metroTextBox_quantity_produced.CustomButton.Name = "";
            this.metroTextBox_quantity_produced.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBox_quantity_produced.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_quantity_produced.CustomButton.TabIndex = 1;
            this.metroTextBox_quantity_produced.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_quantity_produced.CustomButton.UseSelectable = true;
            this.metroTextBox_quantity_produced.CustomButton.UseVisualStyleBackColor = false;
            this.metroTextBox_quantity_produced.CustomButton.Visible = false;
            this.metroTextBox_quantity_produced.Lines = new string[0];
            this.metroTextBox_quantity_produced.Location = new System.Drawing.Point(550, 99);
            this.metroTextBox_quantity_produced.MaxLength = 32767;
            this.metroTextBox_quantity_produced.Name = "metroTextBox_quantity_produced";
            this.metroTextBox_quantity_produced.PasswordChar = '\0';
            this.metroTextBox_quantity_produced.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_quantity_produced.SelectedText = "";
            this.metroTextBox_quantity_produced.SelectionLength = 0;
            this.metroTextBox_quantity_produced.SelectionStart = 0;
            this.metroTextBox_quantity_produced.ShortcutsEnabled = true;
            this.metroTextBox_quantity_produced.Size = new System.Drawing.Size(163, 21);
            this.metroTextBox_quantity_produced.TabIndex = 61;
            this.metroTextBox_quantity_produced.UseCustomBackColor = true;
            this.metroTextBox_quantity_produced.UseSelectable = true;
            this.metroTextBox_quantity_produced.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_quantity_produced.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox_quantity_produced.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox_quantity_produced_KeyPress);
            this.metroTextBox_quantity_produced.Validating += new System.ComponentModel.CancelEventHandler(this.metroTextBox_Validating);
            // 
            // metroTextBox_quantity_broken
            // 
            this.metroTextBox_quantity_broken.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.metroTextBox_quantity_broken.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.metroTextBox_quantity_broken.CustomButton.Image = null;
            this.metroTextBox_quantity_broken.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.metroTextBox_quantity_broken.CustomButton.Name = "";
            this.metroTextBox_quantity_broken.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBox_quantity_broken.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_quantity_broken.CustomButton.TabIndex = 1;
            this.metroTextBox_quantity_broken.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_quantity_broken.CustomButton.UseSelectable = true;
            this.metroTextBox_quantity_broken.CustomButton.UseVisualStyleBackColor = false;
            this.metroTextBox_quantity_broken.CustomButton.Visible = false;
            this.metroTextBox_quantity_broken.Lines = new string[0];
            this.metroTextBox_quantity_broken.Location = new System.Drawing.Point(152, 134);
            this.metroTextBox_quantity_broken.MaxLength = 32767;
            this.metroTextBox_quantity_broken.Name = "metroTextBox_quantity_broken";
            this.metroTextBox_quantity_broken.PasswordChar = '\0';
            this.metroTextBox_quantity_broken.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_quantity_broken.SelectedText = "";
            this.metroTextBox_quantity_broken.SelectionLength = 0;
            this.metroTextBox_quantity_broken.SelectionStart = 0;
            this.metroTextBox_quantity_broken.ShortcutsEnabled = true;
            this.metroTextBox_quantity_broken.Size = new System.Drawing.Size(163, 21);
            this.metroTextBox_quantity_broken.TabIndex = 60;
            this.metroTextBox_quantity_broken.UseCustomBackColor = true;
            this.metroTextBox_quantity_broken.UseSelectable = true;
            this.metroTextBox_quantity_broken.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_quantity_broken.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox_quantity_broken.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox_quantity_broken_KeyPress);
            this.metroTextBox_quantity_broken.Validating += new System.ComponentModel.CancelEventHandler(this.metroTextBox_Validating);
            // 
            // metroTextBox_quantity_required
            // 
            this.metroTextBox_quantity_required.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.metroTextBox_quantity_required.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.metroTextBox_quantity_required.CustomButton.Image = null;
            this.metroTextBox_quantity_required.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.metroTextBox_quantity_required.CustomButton.Name = "";
            this.metroTextBox_quantity_required.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBox_quantity_required.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_quantity_required.CustomButton.TabIndex = 1;
            this.metroTextBox_quantity_required.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_quantity_required.CustomButton.UseSelectable = true;
            this.metroTextBox_quantity_required.CustomButton.UseVisualStyleBackColor = false;
            this.metroTextBox_quantity_required.CustomButton.Visible = false;
            this.metroTextBox_quantity_required.Lines = new string[0];
            this.metroTextBox_quantity_required.Location = new System.Drawing.Point(152, 99);
            this.metroTextBox_quantity_required.MaxLength = 32767;
            this.metroTextBox_quantity_required.Name = "metroTextBox_quantity_required";
            this.metroTextBox_quantity_required.PasswordChar = '\0';
            this.metroTextBox_quantity_required.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_quantity_required.SelectedText = "";
            this.metroTextBox_quantity_required.SelectionLength = 0;
            this.metroTextBox_quantity_required.SelectionStart = 0;
            this.metroTextBox_quantity_required.ShortcutsEnabled = true;
            this.metroTextBox_quantity_required.Size = new System.Drawing.Size(163, 21);
            this.metroTextBox_quantity_required.TabIndex = 59;
            this.metroTextBox_quantity_required.UseCustomBackColor = true;
            this.metroTextBox_quantity_required.UseSelectable = true;
            this.metroTextBox_quantity_required.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_quantity_required.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox_quantity_required.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox_quantity_required_KeyPress);
            this.metroTextBox_quantity_required.Validating += new System.ComponentModel.CancelEventHandler(this.metroTextBox_Validating);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel9.Location = new System.Drawing.Point(29, 174);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(91, 15);
            this.metroLabel9.TabIndex = 58;
            this.metroLabel9.Text = "Observaciones:";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel8.Location = new System.Drawing.Point(27, 134);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(113, 15);
            this.metroLabel8.TabIndex = 57;
            this.metroLabel8.Text = "Cantidad de rotura:";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel7.Location = new System.Drawing.Point(407, 134);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(137, 15);
            this.metroLabel7.TabIndex = 56;
            this.metroLabel7.Text = "Tiempo de producción :";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel6.Location = new System.Drawing.Point(407, 99);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(119, 15);
            this.metroLabel6.TabIndex = 55;
            this.metroLabel6.Text = "Cantidad producida :";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel5.Location = new System.Drawing.Point(27, 99);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(115, 15);
            this.metroLabel5.TabIndex = 54;
            this.metroLabel5.Text = "Cantidad requerida:";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // comboBox_Workstation
            // 
            this.comboBox_Workstation.FormattingEnabled = true;
            this.comboBox_Workstation.Location = new System.Drawing.Point(550, 58);
            this.comboBox_Workstation.Name = "comboBox_Workstation";
            this.comboBox_Workstation.Size = new System.Drawing.Size(163, 21);
            this.comboBox_Workstation.TabIndex = 53;
            this.comboBox_Workstation.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
            // 
            // comboBox_Product
            // 
            this.comboBox_Product.FormattingEnabled = true;
            this.comboBox_Product.Location = new System.Drawing.Point(152, 64);
            this.comboBox_Product.Name = "comboBox_Product";
            this.comboBox_Product.Size = new System.Drawing.Size(163, 21);
            this.comboBox_Product.TabIndex = 52;
            this.comboBox_Product.SelectedIndexChanged += new System.EventHandler(this.comboBox_Product_SelectedIndexChanged);
            this.comboBox_Product.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel4.Location = new System.Drawing.Point(407, 64);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(104, 15);
            this.metroLabel4.TabIndex = 51;
            this.metroLabel4.Text = "Puesto de trabajo";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // comboBox_Worker
            // 
            this.comboBox_Worker.FormattingEnabled = true;
            this.comboBox_Worker.Location = new System.Drawing.Point(152, 29);
            this.comboBox_Worker.Name = "comboBox_Worker";
            this.comboBox_Worker.Size = new System.Drawing.Size(163, 21);
            this.comboBox_Worker.TabIndex = 38;
            this.comboBox_Worker.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel2.Location = new System.Drawing.Point(27, 64);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 15);
            this.metroLabel2.TabIndex = 31;
            this.metroLabel2.Text = "Producto:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel1.Location = new System.Drawing.Point(27, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 15);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Trabajador:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.ForeColor = System.Drawing.Color.White;
            this.button_Cancel.Location = new System.Drawing.Point(397, 245);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(82, 23);
            this.button_Cancel.TabIndex = 17;
            this.button_Cancel.Text = "Cancelar";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Register
            // 
            this.button_Register.BackColor = System.Drawing.Color.DarkCyan;
            this.button_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Register.ForeColor = System.Drawing.Color.White;
            this.button_Register.Location = new System.Drawing.Point(275, 245);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(82, 23);
            this.button_Register.TabIndex = 16;
            this.button_Register.Text = "Grabar";
            this.button_Register.UseVisualStyleBackColor = false;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ProductionOrderWorkLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductionOrderWorkLine";
            this.Text = "Registro de trabajo";
            this.Load += new System.EventHandler(this.ProductionOrderWorkLine_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox_observations;
        private MetroFramework.Controls.MetroTextBox metroTextBox_quantity_produced;
        private MetroFramework.Controls.MetroTextBox metroTextBox_quantity_broken;
        private MetroFramework.Controls.MetroTextBox metroTextBox_quantity_required;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.ComboBox comboBox_Workstation;
        private System.Windows.Forms.ComboBox comboBox_Product;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ComboBox comboBox_Worker;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Register;
        private MetroFramework.Controls.MetroTile btn_SearchClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Minute;
        private System.Windows.Forms.NumericUpDown numericUpDown_Hours;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}