namespace WindowsFormsApp1.Views
{
    partial class ProgressForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.progressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.labelMessage = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCancel.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(114, 66);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(82, 25);
            this.buttonCancel.TabIndex = 62;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.progressBar1.Location = new System.Drawing.Point(12, 37);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(289, 23);
            this.progressBar1.Style = MetroFramework.MetroColorStyle.Teal;
            this.progressBar1.TabIndex = 63;
            // 
            // labelMessage
            // 
            this.labelMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMessage.AutoSize = true;
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelMessage.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelMessage.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelMessage.Location = new System.Drawing.Point(12, 19);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(80, 15);
            this.labelMessage.TabIndex = 64;
            this.labelMessage.Text = "Procesando...";
            this.labelMessage.UseCustomBackColor = true;
            this.labelMessage.UseCustomForeColor = true;
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 103);
            this.ControlBox = false;
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonCancel);
            this.Name = "ProgressForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulación";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private MetroFramework.Controls.MetroProgressBar progressBar1;
        private MetroFramework.Controls.MetroLabel labelMessage;
    }
}