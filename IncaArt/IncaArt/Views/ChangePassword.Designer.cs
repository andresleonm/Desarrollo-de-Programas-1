namespace WindowsFormsApp1.Views
{
    partial class ChangePassword
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.text_box_password = new MetroFramework.Controls.MetroTextBox();
            this.text_box_confirmation = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel1.Location = new System.Drawing.Point(84, 57);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(295, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Hemos configurado una contraseña para ti";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.DarkCyan;
            this.metroLabel2.Location = new System.Drawing.Point(127, 76);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(198, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Por favor ingresa una nueva";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(29, 128);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(119, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Nueva Contraseña:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(29, 170);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(142, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Confirmar Contraseña:";
            // 
            // text_box_password
            // 
            // 
            // 
            // 
            this.text_box_password.CustomButton.Image = null;
            this.text_box_password.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.text_box_password.CustomButton.Name = "";
            this.text_box_password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.text_box_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.text_box_password.CustomButton.TabIndex = 1;
            this.text_box_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.text_box_password.CustomButton.UseSelectable = true;
            this.text_box_password.CustomButton.Visible = false;
            this.text_box_password.Lines = new string[0];
            this.text_box_password.Location = new System.Drawing.Point(191, 124);
            this.text_box_password.MaxLength = 32767;
            this.text_box_password.Name = "text_box_password";
            this.text_box_password.PasswordChar = '*';
            this.text_box_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_box_password.SelectedText = "";
            this.text_box_password.SelectionLength = 0;
            this.text_box_password.SelectionStart = 0;
            this.text_box_password.ShortcutsEnabled = true;
            this.text_box_password.Size = new System.Drawing.Size(211, 23);
            this.text_box_password.TabIndex = 4;
            this.text_box_password.UseSelectable = true;
            this.text_box_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.text_box_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // text_box_confirmation
            // 
            // 
            // 
            // 
            this.text_box_confirmation.CustomButton.Image = null;
            this.text_box_confirmation.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.text_box_confirmation.CustomButton.Name = "";
            this.text_box_confirmation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.text_box_confirmation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.text_box_confirmation.CustomButton.TabIndex = 1;
            this.text_box_confirmation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.text_box_confirmation.CustomButton.UseSelectable = true;
            this.text_box_confirmation.CustomButton.Visible = false;
            this.text_box_confirmation.Lines = new string[0];
            this.text_box_confirmation.Location = new System.Drawing.Point(191, 170);
            this.text_box_confirmation.MaxLength = 32767;
            this.text_box_confirmation.Name = "text_box_confirmation";
            this.text_box_confirmation.PasswordChar = '*';
            this.text_box_confirmation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_box_confirmation.SelectedText = "";
            this.text_box_confirmation.SelectionLength = 0;
            this.text_box_confirmation.SelectionStart = 0;
            this.text_box_confirmation.ShortcutsEnabled = true;
            this.text_box_confirmation.Size = new System.Drawing.Size(211, 23);
            this.text_box_confirmation.TabIndex = 5;
            this.text_box_confirmation.UseSelectable = true;
            this.text_box_confirmation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.text_box_confirmation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DarkCyan;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(175, 213);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(111, 23);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Guardar";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 261);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.text_box_confirmation);
            this.Controls.Add(this.text_box_password);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassword";
            this.Text = "Cambiar Contraseña";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePassword_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox text_box_password;
        private MetroFramework.Controls.MetroTextBox text_box_confirmation;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}