﻿namespace WindowsFormsApp1.Views.Production_Module
{
    partial class ProductionOrderMaterialLine
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroTextBox_quantity_taken_real = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.comboBox_Warehouse = new System.Windows.Forms.ComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_Quantity = new MetroFramework.Controls.MetroTextBox();
            this.comboBox_Material = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Register = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.metroTextBox_quantity_taken_real);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.comboBox_Warehouse);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroTextBox_Quantity);
            this.groupBox1.Controls.Add(this.comboBox_Material);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.button_Cancel);
            this.groupBox1.Controls.Add(this.button_Register);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(34, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 232);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Línea de Material de Orden";
            // 
            // metroTextBox_quantity_taken_real
            // 
            this.metroTextBox_quantity_taken_real.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.metroTextBox_quantity_taken_real.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.metroTextBox_quantity_taken_real.CustomButton.Image = null;
            this.metroTextBox_quantity_taken_real.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.metroTextBox_quantity_taken_real.CustomButton.Name = "";
            this.metroTextBox_quantity_taken_real.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBox_quantity_taken_real.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_quantity_taken_real.CustomButton.TabIndex = 1;
            this.metroTextBox_quantity_taken_real.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_quantity_taken_real.CustomButton.UseSelectable = true;
            this.metroTextBox_quantity_taken_real.CustomButton.UseVisualStyleBackColor = false;
            this.metroTextBox_quantity_taken_real.CustomButton.Visible = false;
            this.metroTextBox_quantity_taken_real.Lines = new string[0];
            this.metroTextBox_quantity_taken_real.Location = new System.Drawing.Point(176, 141);
            this.metroTextBox_quantity_taken_real.MaxLength = 32767;
            this.metroTextBox_quantity_taken_real.Name = "metroTextBox_quantity_taken_real";
            this.metroTextBox_quantity_taken_real.PasswordChar = '\0';
            this.metroTextBox_quantity_taken_real.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_quantity_taken_real.SelectedText = "";
            this.metroTextBox_quantity_taken_real.SelectionLength = 0;
            this.metroTextBox_quantity_taken_real.SelectionStart = 0;
            this.metroTextBox_quantity_taken_real.ShortcutsEnabled = true;
            this.metroTextBox_quantity_taken_real.Size = new System.Drawing.Size(163, 21);
            this.metroTextBox_quantity_taken_real.TabIndex = 53;
            this.metroTextBox_quantity_taken_real.UseCustomBackColor = true;
            this.metroTextBox_quantity_taken_real.UseSelectable = true;
            this.metroTextBox_quantity_taken_real.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_quantity_taken_real.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel4.Location = new System.Drawing.Point(31, 141);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(139, 15);
            this.metroLabel4.TabIndex = 52;
            this.metroLabel4.Text = "Cantidad real solicitada :";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // comboBox_Warehouse
            // 
            this.comboBox_Warehouse.FormattingEnabled = true;
            this.comboBox_Warehouse.Location = new System.Drawing.Point(176, 103);
            this.comboBox_Warehouse.Name = "comboBox_Warehouse";
            this.comboBox_Warehouse.Size = new System.Drawing.Size(163, 21);
            this.comboBox_Warehouse.TabIndex = 51;
            this.comboBox_Warehouse.SelectedIndexChanged += new System.EventHandler(this.comboBox_Warehouse_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel3.Location = new System.Drawing.Point(33, 103);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 15);
            this.metroLabel3.TabIndex = 50;
            this.metroLabel3.Text = "Almacén :";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroTextBox_Quantity
            // 
            this.metroTextBox_Quantity.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.metroTextBox_Quantity.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.metroTextBox_Quantity.CustomButton.Image = null;
            this.metroTextBox_Quantity.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.metroTextBox_Quantity.CustomButton.Name = "";
            this.metroTextBox_Quantity.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBox_Quantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Quantity.CustomButton.TabIndex = 1;
            this.metroTextBox_Quantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Quantity.CustomButton.UseSelectable = true;
            this.metroTextBox_Quantity.CustomButton.UseVisualStyleBackColor = false;
            this.metroTextBox_Quantity.CustomButton.Visible = false;
            this.metroTextBox_Quantity.Lines = new string[0];
            this.metroTextBox_Quantity.Location = new System.Drawing.Point(176, 68);
            this.metroTextBox_Quantity.MaxLength = 32767;
            this.metroTextBox_Quantity.Name = "metroTextBox_Quantity";
            this.metroTextBox_Quantity.PasswordChar = '\0';
            this.metroTextBox_Quantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Quantity.SelectedText = "";
            this.metroTextBox_Quantity.SelectionLength = 0;
            this.metroTextBox_Quantity.SelectionStart = 0;
            this.metroTextBox_Quantity.ShortcutsEnabled = true;
            this.metroTextBox_Quantity.Size = new System.Drawing.Size(163, 21);
            this.metroTextBox_Quantity.TabIndex = 49;
            this.metroTextBox_Quantity.UseCustomBackColor = true;
            this.metroTextBox_Quantity.UseSelectable = true;
            this.metroTextBox_Quantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Quantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboBox_Material
            // 
            this.comboBox_Material.FormattingEnabled = true;
            this.comboBox_Material.Location = new System.Drawing.Point(176, 29);
            this.comboBox_Material.Name = "comboBox_Material";
            this.comboBox_Material.Size = new System.Drawing.Size(163, 21);
            this.comboBox_Material.TabIndex = 38;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel2.Location = new System.Drawing.Point(31, 68);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(118, 15);
            this.metroLabel2.TabIndex = 31;
            this.metroLabel2.Text = "Cantidad requerida :";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel1.Location = new System.Drawing.Point(31, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 15);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Material :";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.ForeColor = System.Drawing.Color.White;
            this.button_Cancel.Location = new System.Drawing.Point(223, 190);
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
            this.button_Register.Location = new System.Drawing.Point(103, 190);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(82, 23);
            this.button_Register.TabIndex = 16;
            this.button_Register.Text = "Grabar";
            this.button_Register.UseVisualStyleBackColor = false;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // ProductionOrderMaterialLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(449, 282);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductionOrderMaterialLine";
            this.Text = "Registro de material";
            this.Load += new System.EventHandler(this.ProductionOrderMaterialLine_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Quantity;
        private System.Windows.Forms.ComboBox comboBox_Material;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.ComboBox comboBox_Warehouse;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox_quantity_taken_real;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}