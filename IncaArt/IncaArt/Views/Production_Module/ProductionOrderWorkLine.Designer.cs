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
            this.work_line = new WindowsFormsApp1.Views.UC_ProductionOrderWorkLine();
            this.SuspendLayout();
            // 
            // work_line
            // 
            this.work_line.Location = new System.Drawing.Point(0, 0);
            this.work_line.Name = "work_line";
            this.work_line.Size = new System.Drawing.Size(800, 328);
            this.work_line.TabIndex = 0;
            // 
            // ProductionOrderWorkLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.work_line);
            this.Name = "ProductionOrderWorkLine";
            this.Text = "Registro de trabajo";
            this.ResumeLayout(false);

        }

        #endregion
        private UC_ProductionOrderWorkLine work_line;
    }
}