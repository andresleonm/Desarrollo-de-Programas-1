namespace WindowsFormsApp1.Views.Production_Module
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
            this.material_line = new WindowsFormsApp1.Views.UC_ProductionOrderMaterialLine();
            this.SuspendLayout();
            // 
            // material_line
            // 
            this.material_line.Location = new System.Drawing.Point(12, 2);
            this.material_line.Name = "material_line";
            this.material_line.Size = new System.Drawing.Size(420, 244);
            this.material_line.TabIndex = 1;
            // 
            // ProductionOrderMaterialLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 256);
            this.Controls.Add(this.material_line);
            this.Name = "ProductionOrderMaterialLine";
            this.Text = "Registro de material";
            this.ResumeLayout(false);

        }

        #endregion
        private UC_ProductionOrderMaterialLine material_line;
    }
}