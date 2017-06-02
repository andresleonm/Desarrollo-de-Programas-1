namespace WindowsFormsApp1.Views
{
    partial class ForgotPassword
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.text_box_nickname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel1.Location = new System.Drawing.Point(30, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(317, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Ingresa tu nombre de usuario y te enviaremos";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel2.Location = new System.Drawing.Point(64, 86);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(232, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "un email con tu nueva contraseña";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DarkCyan;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(133, 186);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(111, 23);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Enviar";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            // 
            // text_box_nickname
            // 
            // 
            // 
            // 
            this.text_box_nickname.CustomButton.Image = null;
            this.text_box_nickname.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.text_box_nickname.CustomButton.Name = "";
            this.text_box_nickname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.text_box_nickname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.text_box_nickname.CustomButton.TabIndex = 1;
            this.text_box_nickname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.text_box_nickname.CustomButton.UseSelectable = true;
            this.text_box_nickname.CustomButton.Visible = false;
            this.text_box_nickname.Lines = new string[0];
            this.text_box_nickname.Location = new System.Drawing.Point(113, 139);
            this.text_box_nickname.MaxLength = 32767;
            this.text_box_nickname.Name = "text_box_nickname";
            this.text_box_nickname.PasswordChar = '*';
            this.text_box_nickname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_box_nickname.SelectedText = "";
            this.text_box_nickname.SelectionLength = 0;
            this.text_box_nickname.SelectionStart = 0;
            this.text_box_nickname.ShortcutsEnabled = true;
            this.text_box_nickname.Size = new System.Drawing.Size(234, 23);
            this.text_box_nickname.TabIndex = 8;
            this.text_box_nickname.UseSelectable = true;
            this.text_box_nickname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.text_box_nickname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(30, 139);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Usuario:";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(376, 248);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.text_box_nickname);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgotPassword";
            this.Text = "Olvidé mi contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox text_box_nickname;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}