namespace WindowsFormsApp1
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
            this.Lbl_Username = new System.Windows.Forms.Label();
            this.textBoxNickname = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_CancelLogin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Username
            // 
            this.Lbl_Username.AutoSize = true;
            this.Lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Username.ForeColor = System.Drawing.Color.DarkCyan;
            this.Lbl_Username.Location = new System.Drawing.Point(78, 193);
            this.Lbl_Username.Name = "Lbl_Username";
            this.Lbl_Username.Size = new System.Drawing.Size(50, 13);
            this.Lbl_Username.TabIndex = 1;
            this.Lbl_Username.Text = "Usuario";
            this.Lbl_Username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_Username.UseMnemonic = false;
            // 
            // textBoxNickname
            // 
            this.textBoxNickname.Location = new System.Drawing.Point(155, 190);
            this.textBoxNickname.Name = "textBoxNickname";
            this.textBoxNickname.Size = new System.Drawing.Size(142, 20);
            this.textBoxNickname.TabIndex = 2;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Password.ForeColor = System.Drawing.Color.DarkCyan;
            this.Lbl_Password.Location = new System.Drawing.Point(78, 226);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(71, 13);
            this.Lbl_Password.TabIndex = 3;
            this.Lbl_Password.Text = "Contraseña";
            this.Lbl_Password.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_Password.UseMnemonic = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(155, 223);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(142, 20);
            this.textBoxPassword.TabIndex = 4;
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_Login.ForeColor = System.Drawing.Color.White;
            this.Btn_Login.Location = new System.Drawing.Point(81, 293);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(80, 23);
            this.Btn_Login.TabIndex = 5;
            this.Btn_Login.Text = "Ingresar";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_CancelLogin
            // 
            this.Btn_CancelLogin.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_CancelLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_CancelLogin.ForeColor = System.Drawing.Color.White;
            this.Btn_CancelLogin.Location = new System.Drawing.Point(217, 293);
            this.Btn_CancelLogin.Name = "Btn_CancelLogin";
            this.Btn_CancelLogin.Size = new System.Drawing.Size(80, 23);
            this.Btn_CancelLogin.TabIndex = 6;
            this.Btn_CancelLogin.Text = "Cancelar";
            this.Btn_CancelLogin.UseVisualStyleBackColor = false;
            this.Btn_CancelLogin.Click += new System.EventHandler(this.Btn_CancelLogin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(152, 256);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(149, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Has olvidado tu contraseña?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Inca_Art;
            this.pictureBox1.Location = new System.Drawing.Point(128, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Login
            // 
            this.AcceptButton = this.Btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.Btn_CancelLogin;
            this.ClientSize = new System.Drawing.Size(401, 339);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Btn_CancelLogin);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.textBoxNickname);
            this.Controls.Add(this.Lbl_Username);
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inca Art";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Username;
        private System.Windows.Forms.TextBox textBoxNickname;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Btn_CancelLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

