namespace WindowsFormsApp1.Views.Warehouse_Module
{
    partial class ProductMovementLine
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
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_UnitPrice = new MetroFramework.Controls.MetroTextBox();
            this.txt_Quantity = new MetroFramework.Controls.MetroTextBox();
            this.cbo_UnitMeasure = new MetroFramework.Controls.MetroComboBox();
            this.cbo_Warehouse = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DeliverQuan = new MetroFramework.Controls.MetroTextBox();
            this.cbo_Product = new MetroFramework.Controls.MetroComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_UnitPrice);
            this.groupBox1.Controls.Add(this.txt_Quantity);
            this.groupBox1.Controls.Add(this.cbo_UnitMeasure);
            this.groupBox1.Controls.Add(this.cbo_Warehouse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_DeliverQuan);
            this.groupBox1.Controls.Add(this.cbo_Product);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 262);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Línea de Venta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(6, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Cantidad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Unidad de medida :";
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.txt_UnitPrice.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_UnitPrice.CustomButton.Image = null;
            this.txt_UnitPrice.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txt_UnitPrice.CustomButton.Name = "";
            this.txt_UnitPrice.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_UnitPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_UnitPrice.CustomButton.TabIndex = 1;
            this.txt_UnitPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_UnitPrice.CustomButton.UseSelectable = true;
            this.txt_UnitPrice.CustomButton.UseVisualStyleBackColor = false;
            this.txt_UnitPrice.CustomButton.Visible = false;
            this.txt_UnitPrice.Enabled = false;
            this.txt_UnitPrice.Lines = new string[0];
            this.txt_UnitPrice.Location = new System.Drawing.Point(476, 35);
            this.txt_UnitPrice.MaxLength = 32767;
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.PasswordChar = '\0';
            this.txt_UnitPrice.ReadOnly = true;
            this.txt_UnitPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_UnitPrice.SelectedText = "";
            this.txt_UnitPrice.SelectionLength = 0;
            this.txt_UnitPrice.SelectionStart = 0;
            this.txt_UnitPrice.ShortcutsEnabled = true;
            this.txt_UnitPrice.Size = new System.Drawing.Size(160, 29);
            this.txt_UnitPrice.TabIndex = 55;
            this.txt_UnitPrice.UseCustomBackColor = true;
            this.txt_UnitPrice.UseSelectable = true;
            this.txt_UnitPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_UnitPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_Quantity
            // 
            // 
            // 
            // 
            this.txt_Quantity.CustomButton.Image = null;
            this.txt_Quantity.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txt_Quantity.CustomButton.Name = "";
            this.txt_Quantity.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_Quantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Quantity.CustomButton.TabIndex = 1;
            this.txt_Quantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Quantity.CustomButton.UseSelectable = true;
            this.txt_Quantity.CustomButton.Visible = false;
            this.txt_Quantity.Lines = new string[0];
            this.txt_Quantity.Location = new System.Drawing.Point(136, 146);
            this.txt_Quantity.MaxLength = 32767;
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.PasswordChar = '\0';
            this.txt_Quantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Quantity.SelectedText = "";
            this.txt_Quantity.SelectionLength = 0;
            this.txt_Quantity.SelectionStart = 0;
            this.txt_Quantity.ShortcutsEnabled = true;
            this.txt_Quantity.Size = new System.Drawing.Size(160, 29);
            this.txt_Quantity.TabIndex = 54;
            this.txt_Quantity.UseSelectable = true;
            this.txt_Quantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Quantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbo_UnitMeasure
            // 
            this.cbo_UnitMeasure.FormattingEnabled = true;
            this.cbo_UnitMeasure.ItemHeight = 23;
            this.cbo_UnitMeasure.Location = new System.Drawing.Point(136, 93);
            this.cbo_UnitMeasure.Name = "cbo_UnitMeasure";
            this.cbo_UnitMeasure.Size = new System.Drawing.Size(160, 29);
            this.cbo_UnitMeasure.TabIndex = 53;
            this.cbo_UnitMeasure.UseSelectable = true;
            // 
            // cbo_Warehouse
            // 
            this.cbo_Warehouse.FormattingEnabled = true;
            this.cbo_Warehouse.ItemHeight = 23;
            this.cbo_Warehouse.Location = new System.Drawing.Point(476, 87);
            this.cbo_Warehouse.Name = "cbo_Warehouse";
            this.cbo_Warehouse.Size = new System.Drawing.Size(160, 29);
            this.cbo_Warehouse.TabIndex = 52;
            this.cbo_Warehouse.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(333, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Precio Unitario :";
            // 
            // txt_DeliverQuan
            // 
            // 
            // 
            // 
            this.txt_DeliverQuan.CustomButton.Image = null;
            this.txt_DeliverQuan.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txt_DeliverQuan.CustomButton.Name = "";
            this.txt_DeliverQuan.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_DeliverQuan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_DeliverQuan.CustomButton.TabIndex = 1;
            this.txt_DeliverQuan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_DeliverQuan.CustomButton.UseSelectable = true;
            this.txt_DeliverQuan.CustomButton.Visible = false;
            this.txt_DeliverQuan.Lines = new string[0];
            this.txt_DeliverQuan.Location = new System.Drawing.Point(476, 146);
            this.txt_DeliverQuan.MaxLength = 32767;
            this.txt_DeliverQuan.Name = "txt_DeliverQuan";
            this.txt_DeliverQuan.PasswordChar = '\0';
            this.txt_DeliverQuan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_DeliverQuan.SelectedText = "";
            this.txt_DeliverQuan.SelectionLength = 0;
            this.txt_DeliverQuan.SelectionStart = 0;
            this.txt_DeliverQuan.ShortcutsEnabled = true;
            this.txt_DeliverQuan.Size = new System.Drawing.Size(160, 29);
            this.txt_DeliverQuan.TabIndex = 50;
            this.txt_DeliverQuan.UseSelectable = true;
            this.txt_DeliverQuan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_DeliverQuan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbo_Product
            // 
            this.cbo_Product.FormattingEnabled = true;
            this.cbo_Product.ItemHeight = 23;
            this.cbo_Product.Location = new System.Drawing.Point(136, 40);
            this.cbo_Product.Name = "cbo_Product";
            this.cbo_Product.Size = new System.Drawing.Size(160, 29);
            this.cbo_Product.TabIndex = 49;
            this.cbo_Product.UseSelectable = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(336, 214);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(82, 29);
            this.btn_Cancel.TabIndex = 17;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(229, 214);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(82, 29);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "Grabar";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(333, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Almacén :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(333, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad entregada :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto :";
            // 
            // SalesOrderLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 278);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalesOrderLine";
            this.Text = "Línea de Venta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cbo_Product;
        private MetroFramework.Controls.MetroTextBox txt_DeliverQuan;
        private MetroFramework.Controls.MetroComboBox cbo_Warehouse;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cbo_UnitMeasure;
        private MetroFramework.Controls.MetroTextBox txt_Quantity;
        private MetroFramework.Controls.MetroTextBox txt_UnitPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}