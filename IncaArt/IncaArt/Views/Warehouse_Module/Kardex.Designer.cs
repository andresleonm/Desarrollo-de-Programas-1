namespace WindowsFormsApp1.Views.Warehouse_Module
{
    partial class Kardex
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
            this.comboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.dateTimePicker1 = new MetroFramework.Controls.MetroDateTime();
            this.dateTimePicker2 = new MetroFramework.Controls.MetroDateTime();
            this.label = new MetroFramework.Controls.MetroLabel();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 23;
            this.comboBox1.Items.AddRange(new object[] {
            "Productos",
            "Materiales"});
            this.comboBox1.Location = new System.Drawing.Point(188, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 29);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.UseSelectable = true;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(188, 191);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(467, 191);
            this.dateTimePicker2.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(91, 197);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(43, 19);
            this.label.TabIndex = 3;
            this.label.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "al";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generar";
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(91, 115);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(35, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Tipo";
            // 
            // Kardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 395);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Kardex";
            this.Text = "Kardex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox comboBox1;
        private MetroFramework.Controls.MetroDateTime dateTimePicker1;
        private MetroFramework.Controls.MetroDateTime dateTimePicker2;
        private MetroFramework.Controls.MetroLabel label;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroButton button1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}