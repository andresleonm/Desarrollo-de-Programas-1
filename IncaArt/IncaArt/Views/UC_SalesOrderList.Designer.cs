namespace WindowsFormsApp1.Views
{
    partial class UC_SalesOrderList
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.btn_Search = new MetroFramework.Controls.MetroTile();
            this.txt_Doi = new MetroFramework.Controls.MetroTextBox();
            this.txt_address = new MetroFramework.Controls.MetroTextBox();
            this.txt_phone = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbClient);
            this.panel1.Location = new System.Drawing.Point(9, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 607);
            this.panel1.TabIndex = 0;
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.btn_Search);
            this.gbClient.Controls.Add(this.txt_Doi);
            this.gbClient.Controls.Add(this.txt_address);
            this.gbClient.Controls.Add(this.txt_phone);
            this.gbClient.Controls.Add(this.label1);
            this.gbClient.Controls.Add(this.txt_name);
            this.gbClient.Controls.Add(this.label7);
            this.gbClient.Controls.Add(this.label9);
            this.gbClient.Controls.Add(this.label12);
            this.gbClient.ForeColor = System.Drawing.Color.DarkCyan;
            this.gbClient.Location = new System.Drawing.Point(14, 3);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(826, 171);
            this.gbClient.TabIndex = 40;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Filtros";
            // 
            // btn_Search
            // 
            this.btn_Search.ActiveControl = null;
            this.btn_Search.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Search.Location = new System.Drawing.Point(373, 22);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(46, 23);
            this.btn_Search.TabIndex = 43;
            this.btn_Search.TileImage = global::WindowsFormsApp1.Properties.Resources.Search_16;
            this.btn_Search.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Search.UseCustomBackColor = true;
            this.btn_Search.UseCustomForeColor = true;
            this.btn_Search.UseSelectable = true;
            this.btn_Search.UseStyleColors = true;
            this.btn_Search.UseTileImage = true;
            // 
            // txt_Doi
            // 
            // 
            // 
            // 
            this.txt_Doi.CustomButton.Image = null;
            this.txt_Doi.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.txt_Doi.CustomButton.Name = "";
            this.txt_Doi.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_Doi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Doi.CustomButton.TabIndex = 1;
            this.txt_Doi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Doi.CustomButton.UseSelectable = true;
            this.txt_Doi.CustomButton.Visible = false;
            this.txt_Doi.Lines = new string[0];
            this.txt_Doi.Location = new System.Drawing.Point(115, 59);
            this.txt_Doi.MaxLength = 32767;
            this.txt_Doi.Name = "txt_Doi";
            this.txt_Doi.PasswordChar = '\0';
            this.txt_Doi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Doi.SelectedText = "";
            this.txt_Doi.SelectionLength = 0;
            this.txt_Doi.SelectionStart = 0;
            this.txt_Doi.ShortcutsEnabled = true;
            this.txt_Doi.Size = new System.Drawing.Size(240, 25);
            this.txt_Doi.TabIndex = 42;
            this.txt_Doi.UseSelectable = true;
            this.txt_Doi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Doi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_address
            // 
            // 
            // 
            // 
            this.txt_address.CustomButton.Image = null;
            this.txt_address.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.txt_address.CustomButton.Name = "";
            this.txt_address.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_address.CustomButton.TabIndex = 1;
            this.txt_address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_address.CustomButton.UseSelectable = true;
            this.txt_address.CustomButton.Visible = false;
            this.txt_address.Lines = new string[0];
            this.txt_address.Location = new System.Drawing.Point(115, 96);
            this.txt_address.MaxLength = 32767;
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_address.SelectedText = "";
            this.txt_address.SelectionLength = 0;
            this.txt_address.SelectionStart = 0;
            this.txt_address.ShortcutsEnabled = true;
            this.txt_address.Size = new System.Drawing.Size(240, 25);
            this.txt_address.TabIndex = 41;
            this.txt_address.UseSelectable = true;
            this.txt_address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_phone
            // 
            // 
            // 
            // 
            this.txt_phone.CustomButton.Image = null;
            this.txt_phone.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.txt_phone.CustomButton.Name = "";
            this.txt_phone.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_phone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_phone.CustomButton.TabIndex = 1;
            this.txt_phone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_phone.CustomButton.UseSelectable = true;
            this.txt_phone.CustomButton.Visible = false;
            this.txt_phone.Lines = new string[0];
            this.txt_phone.Location = new System.Drawing.Point(115, 133);
            this.txt_phone.MaxLength = 32767;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.PasswordChar = '\0';
            this.txt_phone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_phone.SelectedText = "";
            this.txt_phone.SelectionLength = 0;
            this.txt_phone.SelectionStart = 0;
            this.txt_phone.ShortcutsEnabled = true;
            this.txt_phone.Size = new System.Drawing.Size(240, 25);
            this.txt_phone.TabIndex = 40;
            this.txt_phone.UseSelectable = true;
            this.txt_phone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_phone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(6, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Teléfono :";
            // 
            // txt_name
            // 
            // 
            // 
            // 
            this.txt_name.CustomButton.Image = null;
            this.txt_name.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.txt_name.CustomButton.Name = "";
            this.txt_name.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_name.CustomButton.TabIndex = 1;
            this.txt_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_name.CustomButton.UseSelectable = true;
            this.txt_name.CustomButton.Visible = false;
            this.txt_name.Lines = new string[0];
            this.txt_name.Location = new System.Drawing.Point(115, 22);
            this.txt_name.MaxLength = 32767;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(240, 25);
            this.txt_name.TabIndex = 38;
            this.txt_name.UseSelectable = true;
            this.txt_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(6, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "N° Documento :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(6, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Cliente :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkCyan;
            this.label12.Location = new System.Drawing.Point(6, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Dirección :";
            // 
            // UC_SalesOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "UC_SalesOrderList";
            this.Size = new System.Drawing.Size(872, 624);
            this.panel1.ResumeLayout(false);
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbClient;
        private MetroFramework.Controls.MetroTile btn_Search;
        private MetroFramework.Controls.MetroTextBox txt_Doi;
        private MetroFramework.Controls.MetroTextBox txt_address;
        private MetroFramework.Controls.MetroTextBox txt_phone;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txt_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
    }
}
