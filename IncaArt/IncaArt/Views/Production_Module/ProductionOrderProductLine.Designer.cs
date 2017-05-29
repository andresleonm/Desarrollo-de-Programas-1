﻿namespace WindowsFormsApp1.Views
{
    partial class ProductionOrderProductLine
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
            this.comboBox_Warehouse = new System.Windows.Forms.ComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.comboBox_Recipe = new System.Windows.Forms.ComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_Unit = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_Quantity = new MetroFramework.Controls.MetroTextBox();
            this.comboBox_Product = new System.Windows.Forms.ComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
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
            this.groupBox1.Controls.Add(this.comboBox_Warehouse);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.comboBox_Recipe);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroTextBox_Unit);
            this.groupBox1.Controls.Add(this.metroTextBox_Quantity);
            this.groupBox1.Controls.Add(this.comboBox_Product);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.button_Cancel);
            this.groupBox1.Controls.Add(this.button_Register);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(30, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 270);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Línea de Producto de Orden";
            // 
            // comboBox_Warehouse
            // 
            this.comboBox_Warehouse.FormattingEnabled = true;
            this.comboBox_Warehouse.Location = new System.Drawing.Point(153, 167);
            this.comboBox_Warehouse.Name = "comboBox_Warehouse";
            this.comboBox_Warehouse.Size = new System.Drawing.Size(163, 21);
            this.comboBox_Warehouse.TabIndex = 54;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.Black;
            this.metroLabel5.Location = new System.Drawing.Point(34, 173);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(61, 15);
            this.metroLabel5.TabIndex = 53;
            this.metroLabel5.Text = "Almacén :";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // comboBox_Recipe
            // 
            this.comboBox_Recipe.FormattingEnabled = true;
            this.comboBox_Recipe.Location = new System.Drawing.Point(153, 134);
            this.comboBox_Recipe.Name = "comboBox_Recipe";
            this.comboBox_Recipe.Size = new System.Drawing.Size(163, 21);
            this.comboBox_Recipe.TabIndex = 52;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.Black;
            this.metroLabel4.Location = new System.Drawing.Point(34, 134);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(52, 15);
            this.metroLabel4.TabIndex = 51;
            this.metroLabel4.Text = "Receta :";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroTextBox_Unit
            // 
            this.metroTextBox_Unit.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.metroTextBox_Unit.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.metroTextBox_Unit.CustomButton.Image = null;
            this.metroTextBox_Unit.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.metroTextBox_Unit.CustomButton.Name = "";
            this.metroTextBox_Unit.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBox_Unit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Unit.CustomButton.TabIndex = 1;
            this.metroTextBox_Unit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Unit.CustomButton.UseSelectable = true;
            this.metroTextBox_Unit.CustomButton.UseVisualStyleBackColor = false;
            this.metroTextBox_Unit.CustomButton.Visible = false;
            this.metroTextBox_Unit.Enabled = false;
            this.metroTextBox_Unit.Lines = new string[0];
            this.metroTextBox_Unit.Location = new System.Drawing.Point(153, 97);
            this.metroTextBox_Unit.MaxLength = 32767;
            this.metroTextBox_Unit.Name = "metroTextBox_Unit";
            this.metroTextBox_Unit.PasswordChar = '\0';
            this.metroTextBox_Unit.ReadOnly = true;
            this.metroTextBox_Unit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Unit.SelectedText = "";
            this.metroTextBox_Unit.SelectionLength = 0;
            this.metroTextBox_Unit.SelectionStart = 0;
            this.metroTextBox_Unit.ShortcutsEnabled = true;
            this.metroTextBox_Unit.Size = new System.Drawing.Size(163, 21);
            this.metroTextBox_Unit.TabIndex = 50;
            this.metroTextBox_Unit.UseCustomBackColor = true;
            this.metroTextBox_Unit.UseSelectable = true;
            this.metroTextBox_Unit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Unit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.metroTextBox_Quantity.Enabled = false;
            this.metroTextBox_Quantity.Lines = new string[0];
            this.metroTextBox_Quantity.Location = new System.Drawing.Point(153, 64);
            this.metroTextBox_Quantity.MaxLength = 32767;
            this.metroTextBox_Quantity.Name = "metroTextBox_Quantity";
            this.metroTextBox_Quantity.PasswordChar = '\0';
            this.metroTextBox_Quantity.ReadOnly = true;
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
            // comboBox_Product
            // 
            this.comboBox_Product.FormattingEnabled = true;
            this.comboBox_Product.Location = new System.Drawing.Point(153, 29);
            this.comboBox_Product.Name = "comboBox_Product";
            this.comboBox_Product.Size = new System.Drawing.Size(163, 21);
            this.comboBox_Product.TabIndex = 38;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(31, 97);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(113, 15);
            this.metroLabel3.TabIndex = 32;
            this.metroLabel3.Text = "Unidad de medida :";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.Black;
            this.metroLabel2.Location = new System.Drawing.Point(34, 64);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 15);
            this.metroLabel2.TabIndex = 31;
            this.metroLabel2.Text = "Cantidad :";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(31, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 15);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Producto :";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.ForeColor = System.Drawing.Color.White;
            this.button_Cancel.Location = new System.Drawing.Point(270, 215);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(82, 23);
            this.button_Cancel.TabIndex = 17;
            this.button_Cancel.Text = "Cancelar";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Register
            // 
            this.button_Register.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Register.ForeColor = System.Drawing.Color.White;
            this.button_Register.Location = new System.Drawing.Point(148, 215);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(82, 23);
            this.button_Register.TabIndex = 16;
            this.button_Register.Text = "Grabar";
            this.button_Register.UseVisualStyleBackColor = false;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // ProductionOrderProductLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 322);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductionOrderProductLine";
            this.Text = "Registro de producto";
            this.Load += new System.EventHandler(this.ProductionOrderProductLine_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_Warehouse;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.ComboBox comboBox_Recipe;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Unit;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Quantity;
        private System.Windows.Forms.ComboBox comboBox_Product;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Register;
    }
}