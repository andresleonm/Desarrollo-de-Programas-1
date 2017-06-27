namespace WindowsFormsApp1.Views
{
    partial class ProgressBarForm
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
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.progressBar.Location = new System.Drawing.Point(12, 24);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(306, 23);
            this.progressBar.Style = MetroFramework.MetroColorStyle.Teal;
            this.progressBar.TabIndex = 66;
            // 
            // ProgressBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 73);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar);
            this.Name = "ProgressBarForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesando...";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroProgressBar progressBar;
    }
}