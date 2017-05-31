namespace WindowsFormsApp1.Views.Purchase_Module
{
    partial class PurchaseOrderLine
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new MetroFramework.Controls.MetroButton();
            this.btn_save = new MetroFramework.Controls.MetroButton();
            this.date_due_date = new MetroFramework.Controls.MetroDateTime();
            this.txt_unit_price = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_measure_unit = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txt_quantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.combo_material = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.combo_warehouse = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 27);
            this.panel2.TabIndex = 11;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.Minimize_Window_52px;
            this.pictureBox5.Location = new System.Drawing.Point(664, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(21, 27);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseEnter += new System.EventHandler(this.pictureBox_MouseHover);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox5.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.Maximize_Window_64px;
            this.pictureBox3.Location = new System.Drawing.Point(685, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox_MouseHover);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Close_Window_52px;
            this.pictureBox4.Location = new System.Drawing.Point(706, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox_MouseHover);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox4.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Minimize_Window_52px;
            this.pictureBox2.Location = new System.Drawing.Point(1319, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Close_Window_52px;
            this.pictureBox1.Location = new System.Drawing.Point(1346, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 265);
            this.panel1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.date_due_date);
            this.groupBox1.Controls.Add(this.txt_unit_price);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txt_measure_unit);
            this.groupBox1.Controls.Add(this.metroLabel14);
            this.groupBox1.Controls.Add(this.txt_quantity);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.combo_material);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.combo_warehouse);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 265);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Línea de Orden";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(198)))));
            this.btn_cancel.Highlight = true;
            this.btn_cancel.Location = new System.Drawing.Point(408, 200);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_cancel.TabIndex = 59;
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
            this.btn_save.Location = new System.Drawing.Point(276, 200);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_save.TabIndex = 58;
            this.btn_save.Text = "Grabar";
            this.btn_save.UseCustomBackColor = true;
            this.btn_save.UseCustomForeColor = true;
            this.btn_save.UseSelectable = true;
            this.btn_save.UseStyleColors = true;
            // 
            // date_due_date
            // 
            this.date_due_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_due_date.Location = new System.Drawing.Point(124, 128);
            this.date_due_date.MinimumSize = new System.Drawing.Size(0, 29);
            this.date_due_date.Name = "date_due_date";
            this.date_due_date.Size = new System.Drawing.Size(208, 29);
            this.date_due_date.TabIndex = 57;
            // 
            // txt_unit_price
            // 
            // 
            // 
            // 
            this.txt_unit_price.CustomButton.Image = null;
            this.txt_unit_price.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txt_unit_price.CustomButton.Name = "";
            this.txt_unit_price.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_unit_price.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_unit_price.CustomButton.TabIndex = 1;
            this.txt_unit_price.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_unit_price.CustomButton.UseSelectable = true;
            this.txt_unit_price.CustomButton.Visible = false;
            this.txt_unit_price.Lines = new string[0];
            this.txt_unit_price.Location = new System.Drawing.Point(489, 128);
            this.txt_unit_price.MaxLength = 32767;
            this.txt_unit_price.Name = "txt_unit_price";
            this.txt_unit_price.PasswordChar = '\0';
            this.txt_unit_price.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_unit_price.SelectedText = "";
            this.txt_unit_price.SelectionLength = 0;
            this.txt_unit_price.SelectionStart = 0;
            this.txt_unit_price.ShortcutsEnabled = true;
            this.txt_unit_price.Size = new System.Drawing.Size(208, 29);
            this.txt_unit_price.TabIndex = 56;
            this.txt_unit_price.UseSelectable = true;
            this.txt_unit_price.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_unit_price.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.Black;
            this.metroLabel4.Location = new System.Drawing.Point(387, 128);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(96, 15);
            this.metroLabel4.TabIndex = 55;
            this.metroLabel4.Text = "Precio Unitario :";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(3, 128);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(115, 15);
            this.metroLabel3.TabIndex = 54;
            this.metroLabel3.Text = "Fecha Programada :";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // txt_measure_unit
            // 
            this.txt_measure_unit.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_measure_unit.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_measure_unit.CustomButton.Image = null;
            this.txt_measure_unit.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txt_measure_unit.CustomButton.Name = "";
            this.txt_measure_unit.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_measure_unit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_measure_unit.CustomButton.TabIndex = 1;
            this.txt_measure_unit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_measure_unit.CustomButton.UseSelectable = true;
            this.txt_measure_unit.CustomButton.UseVisualStyleBackColor = false;
            this.txt_measure_unit.CustomButton.Visible = false;
            this.txt_measure_unit.Enabled = false;
            this.txt_measure_unit.Lines = new string[0];
            this.txt_measure_unit.Location = new System.Drawing.Point(489, 84);
            this.txt_measure_unit.MaxLength = 32767;
            this.txt_measure_unit.Name = "txt_measure_unit";
            this.txt_measure_unit.PasswordChar = '\0';
            this.txt_measure_unit.ReadOnly = true;
            this.txt_measure_unit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_measure_unit.SelectedText = "";
            this.txt_measure_unit.SelectionLength = 0;
            this.txt_measure_unit.SelectionStart = 0;
            this.txt_measure_unit.ShortcutsEnabled = true;
            this.txt_measure_unit.Size = new System.Drawing.Size(208, 29);
            this.txt_measure_unit.TabIndex = 51;
            this.txt_measure_unit.UseCustomBackColor = true;
            this.txt_measure_unit.UseSelectable = true;
            this.txt_measure_unit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_measure_unit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.ForeColor = System.Drawing.Color.Black;
            this.metroLabel14.Location = new System.Drawing.Point(370, 85);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(113, 15);
            this.metroLabel14.TabIndex = 50;
            this.metroLabel14.Text = "Unidad de Medida :";
            this.metroLabel14.UseCustomBackColor = true;
            this.metroLabel14.UseCustomForeColor = true;
            // 
            // txt_quantity
            // 
            // 
            // 
            // 
            this.txt_quantity.CustomButton.Image = null;
            this.txt_quantity.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txt_quantity.CustomButton.Name = "";
            this.txt_quantity.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_quantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_quantity.CustomButton.TabIndex = 1;
            this.txt_quantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_quantity.CustomButton.UseSelectable = true;
            this.txt_quantity.CustomButton.Visible = false;
            this.txt_quantity.Lines = new string[0];
            this.txt_quantity.Location = new System.Drawing.Point(124, 84);
            this.txt_quantity.MaxLength = 32767;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.PasswordChar = '\0';
            this.txt_quantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_quantity.SelectedText = "";
            this.txt_quantity.SelectionLength = 0;
            this.txt_quantity.SelectionStart = 0;
            this.txt_quantity.ShortcutsEnabled = true;
            this.txt_quantity.Size = new System.Drawing.Size(208, 29);
            this.txt_quantity.TabIndex = 49;
            this.txt_quantity.UseSelectable = true;
            this.txt_quantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_quantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.ForeColor = System.Drawing.Color.Black;
            this.metroLabel11.Location = new System.Drawing.Point(70, 85);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(48, 15);
            this.metroLabel11.TabIndex = 48;
            this.metroLabel11.Text = "Orden :";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // combo_material
            // 
            this.combo_material.FormattingEnabled = true;
            this.combo_material.ItemHeight = 23;
            this.combo_material.Location = new System.Drawing.Point(124, 40);
            this.combo_material.MaxDropDownItems = 20;
            this.combo_material.Name = "combo_material";
            this.combo_material.Size = new System.Drawing.Size(208, 29);
            this.combo_material.TabIndex = 42;
            this.combo_material.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(59, 42);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 15);
            this.metroLabel1.TabIndex = 41;
            this.metroLabel1.Text = "Material :";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // combo_warehouse
            // 
            this.combo_warehouse.FormattingEnabled = true;
            this.combo_warehouse.ItemHeight = 23;
            this.combo_warehouse.Location = new System.Drawing.Point(489, 40);
            this.combo_warehouse.MaxDropDownItems = 20;
            this.combo_warehouse.Name = "combo_warehouse";
            this.combo_warehouse.Size = new System.Drawing.Size(208, 29);
            this.combo_warehouse.TabIndex = 40;
            this.combo_warehouse.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.Color.Black;
            this.metroLabel7.Location = new System.Drawing.Point(422, 42);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(61, 15);
            this.metroLabel7.TabIndex = 39;
            this.metroLabel7.Text = "Almacen :";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // PurchaseOrderLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 292);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseOrderLine";
            this.Text = "Línea de Orden de Compra";
            this.Load += new System.EventHandler(this.PurchaseOrderLine_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroDateTime date_due_date;
        private MetroFramework.Controls.MetroTextBox txt_unit_price;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_measure_unit;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txt_quantity;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox combo_material;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox combo_warehouse;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton btn_cancel;
        private MetroFramework.Controls.MetroButton btn_save;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}