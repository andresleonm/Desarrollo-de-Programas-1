﻿namespace WindowsFormsApp1
{
    partial class Frm_Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_Username = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_CancelLogin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(87, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_Username
            // 
            this.Lbl_Username.AutoSize = true;
            this.Lbl_Username.Location = new System.Drawing.Point(67, 87);
            this.Lbl_Username.Name = "Lbl_Username";
            this.Lbl_Username.Size = new System.Drawing.Size(43, 13);
            this.Lbl_Username.TabIndex = 1;
            this.Lbl_Username.Text = "Usuario";
            this.Lbl_Username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_Username.UseMnemonic = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(67, 120);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(61, 13);
            this.Lbl_Password.TabIndex = 3;
            this.Lbl_Password.Text = "Contraseña";
            this.Lbl_Password.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_Password.UseMnemonic = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 20);
            this.textBox2.TabIndex = 4;
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(70, 184);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(75, 23);
            this.Btn_Login.TabIndex = 5;
            this.Btn_Login.Text = "Ingresar";
            this.Btn_Login.UseVisualStyleBackColor = true;
            // 
            // Btn_CancelLogin
            // 
            this.Btn_CancelLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_CancelLogin.Location = new System.Drawing.Point(201, 184);
            this.Btn_CancelLogin.Name = "Btn_CancelLogin";
            this.Btn_CancelLogin.Size = new System.Drawing.Size(75, 23);
            this.Btn_CancelLogin.TabIndex = 6;
            this.Btn_CancelLogin.Text = "Cancelar";
            this.Btn_CancelLogin.UseVisualStyleBackColor = true;
            this.Btn_CancelLogin.Click += new System.EventHandler(this.Btn_CancelLogin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(131, 145);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(149, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Has olvidado tu contraseña?";
            // 
            // Frm_Login
            // 
            this.AcceptButton = this.Btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_CancelLogin;
            this.ClientSize = new System.Drawing.Size(352, 219);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Btn_CancelLogin);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lbl_Username);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inca Art";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_Username;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Btn_CancelLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

