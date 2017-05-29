namespace WindowsFormsApp1.Views
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
            this.product_line = new WindowsFormsApp1.Views.UC_ProductionOrderProductLine();
            this.SuspendLayout();
            // 
            // product_line
            // 
            this.product_line.Location = new System.Drawing.Point(2, -1);
            this.product_line.Name = "product_line";
            this.product_line.Size = new System.Drawing.Size(438, 246);
            this.product_line.TabIndex = 1;
            // 
            // ProductionOrderProductLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 243);
            this.Controls.Add(this.product_line);
            this.Name = "ProductionOrderProductLine";
            this.Text = "Registro de producto";
            this.ResumeLayout(false);

        }

        #endregion
        private UC_ProductionOrderProductLine product_line;
    }
}