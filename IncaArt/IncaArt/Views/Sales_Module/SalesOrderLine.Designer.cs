﻿namespace WindowsFormsApp1.Views.Sales_Module
{
    partial class SalesOrderLine
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
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.dud_Quantity = new System.Windows.Forms.DomainUpDown();
            this.cancel = new System.Windows.Forms.Button();
            this.line_register = new System.Windows.Forms.Button();
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_Product = new System.Windows.Forms.ComboBox();
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
            this.groupBox1.Controls.Add(this.txt_Description);
            this.groupBox1.Controls.Add(this.dud_Quantity);
            this.groupBox1.Controls.Add(this.cancel);
            this.groupBox1.Controls.Add(this.line_register);
            this.groupBox1.Controls.Add(this.txt_UnitPrice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbo_Product);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 260);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Línea de Venta";
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(116, 119);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(346, 82);
            this.txt_Description.TabIndex = 19;
            // 
            // dud_Quantity
            // 
            this.dud_Quantity.Location = new System.Drawing.Point(116, 69);
            this.dud_Quantity.Name = "dud_Quantity";
            this.dud_Quantity.Size = new System.Drawing.Size(130, 20);
            this.dud_Quantity.TabIndex = 18;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(271, 218);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(82, 23);
            this.cancel.TabIndex = 17;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // line_register
            // 
            this.line_register.BackColor = System.Drawing.Color.CornflowerBlue;
            this.line_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line_register.ForeColor = System.Drawing.Color.White;
            this.line_register.Location = new System.Drawing.Point(164, 218);
            this.line_register.Name = "line_register";
            this.line_register.Size = new System.Drawing.Size(82, 23);
            this.line_register.TabIndex = 16;
            this.line_register.Text = "Grabar";
            this.line_register.UseVisualStyleBackColor = false;
            this.line_register.Click += new System.EventHandler(this.line_register_Click);
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.Location = new System.Drawing.Point(384, 28);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.ReadOnly = true;
            this.txt_UnitPrice.Size = new System.Drawing.Size(78, 20);
            this.txt_UnitPrice.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(268, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Precio Unitario :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(22, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descripción :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad :";
            // 
            // cbo_Product
            // 
            this.cbo_Product.FormattingEnabled = true;
            this.cbo_Product.Items.AddRange(new object[] {
            "Cerámico",
            "Retablo",
            "Piedra Tallada"});
            this.cbo_Product.Location = new System.Drawing.Point(116, 28);
            this.cbo_Product.Name = "cbo_Product";
            this.cbo_Product.Size = new System.Drawing.Size(130, 21);
            this.cbo_Product.TabIndex = 1;
            this.cbo_Product.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto :";
            // 
            // SalesOrderLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 274);
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
        private System.Windows.Forms.DomainUpDown dud_Quantity;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button line_register;
        private System.Windows.Forms.TextBox txt_UnitPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Description;
    }
}